using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

var solutionDirectory = args.ElementAtOrDefault(0) ??
                        Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../../.."));
var readmePath = Path.Combine(solutionDirectory, "README.md");
var mkDocsPath = Path.Combine(solutionDirectory, "mkdocs.yml");
var docsDirectory = Path.Combine(solutionDirectory, "docs");
var docsExamplesDirectory = Path.Combine(docsDirectory, "examples");
var legacyDocsSamplesDirectory = Path.Combine(docsDirectory, "samples");
var exampleSourceDirectory = Path.Combine(solutionDirectory, "src", "tests", "IntegrationTests", "Examples");

Directory.CreateDirectory(docsExamplesDirectory);

if (Directory.Exists(legacyDocsSamplesDirectory))
{
    Directory.Delete(legacyDocsSamplesDirectory, recursive: true);
}

foreach (var path in Directory.EnumerateFiles(docsExamplesDirectory, "*.md", SearchOption.TopDirectoryOnly))
{
    File.Delete(path);
}

var examples = Directory
    .EnumerateFiles(exampleSourceDirectory, "*.cs", SearchOption.AllDirectories)
    .Select(LoadExample)
    .OrderBy(x => x.Order)
    .ThenBy(x => x.Title, StringComparer.Ordinal)
    .ToList();

if (examples.Count == 0)
{
    throw new InvalidOperationException($"No documentation examples found in '{exampleSourceDirectory}'.");
}

var readme = await File.ReadAllTextAsync(readmePath);
readme = ReplaceBlock(
    NormalizeNewlines(readme),
    "<!-- EXAMPLES:START -->",
    "<!-- EXAMPLES:END -->",
    BuildReadmeExamples(examples));
await File.WriteAllTextAsync(readmePath, readme);
await File.WriteAllTextAsync(Path.Combine(docsDirectory, "index.md"), readme);

foreach (var example in examples)
{
    var page = BuildExamplePage(example);
    await File.WriteAllTextAsync(Path.Combine(docsExamplesDirectory, $"{example.Slug}.md"), page);
}

var mkDocs = await File.ReadAllTextAsync(mkDocsPath);
mkDocs = ReplaceBlock(
    NormalizeNewlines(mkDocs),
    "# EXAMPLES:START",
    "# EXAMPLES:END",
    BuildMkDocsExamples(examples));
await File.WriteAllTextAsync(mkDocsPath, mkDocs);

Console.WriteLine($"Generated {examples.Count} documentation examples.");

static ExampleDocument LoadExample(string path)
{
    var text = NormalizeNewlines(File.ReadAllText(path));
    var metadata = ExampleMetadata.Parse(text, path);

    var syntaxTree = CSharpSyntaxTree.ParseText(text);
    var root = syntaxTree.GetRoot();
    var methods = root
        .DescendantNodes()
        .OfType<MethodDeclarationSyntax>()
        .Where(HasTestMethodAttribute)
        .ToList();

    if (methods.Count != 1)
    {
        throw new InvalidOperationException(
            $"Expected exactly one [TestMethod] in '{path}', found {methods.Count}.");
    }

    var method = methods[0];
    if (method.Body is null)
    {
        throw new InvalidOperationException($"Method '{method.Identifier.Text}' in '{path}' must use a block body.");
    }

    var body = text[method.Body.OpenBraceToken.Span.End..method.Body.CloseBraceToken.Span.Start];

    return new ExampleDocument(
        metadata.Order,
        metadata.Title,
        metadata.Slug,
        metadata.Description,
        TransformCode(body));
}

static bool HasTestMethodAttribute(MethodDeclarationSyntax method)
{
    return method.AttributeLists
        .SelectMany(x => x.Attributes)
        .Select(x => x.Name.ToString())
        .Any(x =>
            x.EndsWith("TestMethod", StringComparison.Ordinal) ||
            x.EndsWith("TestMethodAttribute", StringComparison.Ordinal));
}

static string TransformCode(string code)
{
    var lines = Deindent(code)
        .Split('\n')
        .Select(line => line.TrimEnd())
        .ToList();

    var output = new List<string>(lines.Count);
    var previousWasBlank = false;

    foreach (var originalLine in lines)
    {
        var line = originalLine
            .Replace("using var client = GetAuthenticatedClient();", "using var client = new ElevenLabsClient(apiKey);")
            .Replace("////", "//");

        var trimmed = line.Trim();
        if (trimmed.Contains(".Should()", StringComparison.Ordinal) ||
            trimmed.Contains(".Should(", StringComparison.Ordinal) ||
            trimmed.StartsWith("Assert.", StringComparison.Ordinal))
        {
            continue;
        }

        if (string.IsNullOrWhiteSpace(line))
        {
            if (previousWasBlank)
            {
                continue;
            }

            previousWasBlank = true;
            output.Add(string.Empty);
            continue;
        }

        previousWasBlank = false;
        output.Add(line);
    }

    return string.Join('\n', output).Trim();
}

static string BuildReadmeExamples(IReadOnlyList<ExampleDocument> examples)
{
    var builder = new StringBuilder();

    for (var index = 0; index < examples.Count; index++)
    {
        var example = examples[index];
        builder.AppendLine($"### {example.Title}");
        builder.AppendLine(example.Description);
        builder.AppendLine();
        builder.AppendLine("```csharp");
        builder.AppendLine(example.Code);
        builder.AppendLine("```");

        if (index < examples.Count - 1)
        {
            builder.AppendLine();
        }
    }

    return builder.ToString().TrimEnd();
}

static string BuildExamplePage(ExampleDocument example)
{
    var builder = new StringBuilder();
    builder.AppendLine($"# {example.Title}");
    builder.AppendLine();
    builder.AppendLine(example.Description);
    builder.AppendLine();
    builder.AppendLine("This example assumes `using ElevenLabs;` is in scope and `apiKey` contains your ElevenLabs API key.");
    builder.AppendLine();
    builder.AppendLine("```csharp");
    builder.AppendLine(example.Code);
    builder.AppendLine("```");
    return builder.ToString().TrimEnd();
}

static string BuildMkDocsExamples(IReadOnlyList<ExampleDocument> examples)
{
    var builder = new StringBuilder();
    builder.AppendLine("- Examples:");

    foreach (var example in examples)
    {
        builder.AppendLine($"  - {example.Title}: examples/{example.Slug}.md");
    }

    return builder.ToString().TrimEnd();
}

static string ReplaceBlock(string content, string startMarker, string endMarker, string replacement)
{
    var start = content.IndexOf(startMarker, StringComparison.Ordinal);
    if (start < 0)
    {
        throw new InvalidOperationException($"Start marker '{startMarker}' was not found.");
    }

    var end = content.IndexOf(endMarker, start + startMarker.Length, StringComparison.Ordinal);
    if (end < 0)
    {
        throw new InvalidOperationException($"End marker '{endMarker}' was not found.");
    }

    var before = content[..(start + startMarker.Length)];
    var after = content[end..];

    return $"{before}\n{replacement}\n{after}";
}

static string Deindent(string text)
{
    var lines = NormalizeNewlines(text).Split('\n').ToList();

    while (lines.Count > 0 && string.IsNullOrWhiteSpace(lines[0]))
    {
        lines.RemoveAt(0);
    }

    while (lines.Count > 0 && string.IsNullOrWhiteSpace(lines[^1]))
    {
        lines.RemoveAt(lines.Count - 1);
    }

    var indent = lines
        .Where(x => !string.IsNullOrWhiteSpace(x))
        .Select(x => x.TakeWhile(char.IsWhiteSpace).Count())
        .DefaultIfEmpty(0)
        .Min();

    return string.Join(
        '\n',
        lines.Select(x => x.Length >= indent ? x[indent..] : x));
}

static string NormalizeNewlines(string text)
{
    return text.Replace("\r\n", "\n");
}

internal sealed record ExampleDocument(int Order, string Title, string Slug, string Description, string Code);

internal sealed record ExampleMetadata(int Order, string Title, string Slug, string Description)
{
    public static ExampleMetadata Parse(string text, string path)
    {
        var match = Regex.Match(text, @"^\s*/\*(.*?)\*/", RegexOptions.Singleline);
        if (!match.Success)
        {
            throw new InvalidOperationException(
                $"Example file '{path}' must start with a block comment containing docs metadata.");
        }

        var lines = match.Groups[1].Value
            .Replace("\r\n", "\n")
            .Trim()
            .Split('\n')
            .Select(x => x.Trim())
            .ToList();

        var values = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        var index = 0;

        for (; index < lines.Count; index++)
        {
            var line = lines[index];
            if (string.IsNullOrWhiteSpace(line))
            {
                index++;
                break;
            }

            var separatorIndex = line.IndexOf(':');
            if (separatorIndex < 0)
            {
                throw new InvalidOperationException(
                    $"Invalid metadata line '{line}' in '{path}'. Expected 'key: value'.");
            }

            var key = line[..separatorIndex].Trim();
            var value = line[(separatorIndex + 1)..].Trim();
            values[key] = value;
        }

        var description = string.Join('\n', lines.Skip(index)).Trim();
        if (!values.TryGetValue("title", out var title) || string.IsNullOrWhiteSpace(title))
        {
            throw new InvalidOperationException($"Example file '{path}' is missing required 'title' metadata.");
        }

        var slug = values.TryGetValue("slug", out var explicitSlug) && !string.IsNullOrWhiteSpace(explicitSlug)
            ? explicitSlug
            : Slugify(title);

        var order = values.TryGetValue("order", out var orderValue) && int.TryParse(orderValue, out var parsedOrder)
            ? parsedOrder
            : 0;

        return new ExampleMetadata(order, title, slug, description);
    }

    private static string Slugify(string value)
    {
        var slug = value.ToLowerInvariant();
        slug = Regex.Replace(slug, @"[^a-z0-9]+", "-");
        return slug.Trim('-');
    }
}
