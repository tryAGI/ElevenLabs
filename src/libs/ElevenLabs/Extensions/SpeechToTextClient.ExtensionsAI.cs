#nullable enable
using Microsoft.Extensions.AI;
using System.Runtime.CompilerServices;

namespace ElevenLabs;

public sealed partial class SpeechToTextClient : Microsoft.Extensions.AI.ISpeechToTextClient
{
    private const string DefaultModelId = "scribe_v1";

    /// <inheritdoc />
    object? Microsoft.Extensions.AI.ISpeechToTextClient.GetService(Type serviceType, object? serviceKey) =>
        serviceType is null ? throw new ArgumentNullException(nameof(serviceType)) :
        serviceKey is not null ? null :
        serviceType.IsInstanceOfType(this) ? this :
        null;

    /// <inheritdoc />
    async Task<SpeechToTextResponse> Microsoft.Extensions.AI.ISpeechToTextClient.GetTextAsync(Stream audioSpeechStream, SpeechToTextOptions? options, CancellationToken cancellationToken)
    {
        _ = audioSpeechStream ?? throw new ArgumentNullException(nameof(audioSpeechStream));

        BodySpeechToTextV1SpeechToTextPost post =
            options?.RawRepresentationFactory?.Invoke(this) as BodySpeechToTextV1SpeechToTextPost ??
            new() { ModelId = options?.ModelId ?? DefaultModelId };

        if (post.File is null)
        {
            MemoryStream? bytes = audioSpeechStream as MemoryStream;
            if (bytes is null || bytes.Position != 0)
            {
                bytes = new();
                await audioSpeechStream.CopyToAsync(bytes, 81920, cancellationToken).ConfigureAwait(false);
            }

            post.File = bytes.TryGetBuffer(out ArraySegment<byte> buffer) && buffer.Array is not null && buffer.Offset == 0 && buffer.Count == bytes.Length ? buffer.Array : bytes.ToArray();
        }

        post.Filename ??= audioSpeechStream is FileStream fileStream ? fileStream.Name : nameof(audioSpeechStream);
        post.LanguageCode ??= options?.SpeechLanguage;
        post.ModelId ??= options?.ModelId ?? DefaultModelId;

        var result = await CreateSpeechToTextAsync(post, cancellationToken: cancellationToken).ConfigureAwait(false);

        return new(result.Text)
        {
            EndTime = result.Words?.Count > 0 && result.Words.Max(w => w.End) is double endTime ? TimeSpan.FromSeconds(endTime) : null,
            ModelId = post.ModelId,
            RawRepresentation = result,
            StartTime = result.Words?.Count > 0 && result.Words.Min(w => w.Start) is double startTime ? TimeSpan.FromSeconds(startTime) : null,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable <SpeechToTextResponseUpdate> Microsoft.Extensions.AI.ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream, SpeechToTextOptions? options, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var response = await ((Microsoft.Extensions.AI.ISpeechToTextClient)this).GetTextAsync(audioSpeechStream, options, cancellationToken).ConfigureAwait(false);
        foreach (var update in response.ToSpeechToTextResponseUpdates())
        {
            yield return update;
        }
    }
}