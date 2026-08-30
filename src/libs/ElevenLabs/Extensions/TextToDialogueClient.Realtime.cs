using System.Globalization;
using ElevenLabs.TextToDialogueMultiContextRealtime;
using ElevenLabs.TextToDialogueRealtime;

namespace ElevenLabs;

public sealed partial class TextToDialogueClient
{
    private const string RealtimePath = "/v1/text-to-dialogue/stream-input";
    private const string MultiContextRealtimePath = "/v1/text-to-dialogue/multi-stream-input";

    /// <summary>
    /// Opens and initializes an Eleven v3 realtime Text to Dialogue WebSocket session.
    /// </summary>
    public Task<TextToDialogueRealtimeClient> ConnectRealtimeAsync(
        string voiceId,
        RealtimeTextToDialogueOptions? options = null,
        TimeSpan? connectTimeout = null,
        TimeSpan? keepAliveInterval = null,
        CancellationToken cancellationToken = default)
        => ConnectRealtimeAsync(
            [voiceId],
            options,
            connectTimeout,
            keepAliveInterval,
            cancellationToken);

    /// <summary>
    /// Opens and initializes an Eleven v3 realtime Text to Dialogue WebSocket session.
    /// Eleven v3 Conversational accepts exactly one voice; standard Eleven v3 accepts up to ten.
    /// </summary>
    public async Task<TextToDialogueRealtimeClient> ConnectRealtimeAsync(
        IReadOnlyList<string> voiceIds,
        RealtimeTextToDialogueOptions? options = null,
        TimeSpan? connectTimeout = null,
        TimeSpan? keepAliveInterval = null,
        CancellationToken cancellationToken = default)
    {
        options ??= new RealtimeTextToDialogueOptions();
        RealtimeTextToDialogueValidation.ValidateOptions(options);
        RealtimeTextToDialogueValidation.ValidateVoiceIds(voiceIds, options.ModelId);

        var client = new TextToDialogueRealtimeClient
        {
            ConnectedModelId = options.ModelId,
            RegisteredVoiceIds = voiceIds.ToArray(),
        };

        try
        {
            await client.ConnectAsync(
                uri: BuildRealtimeUri(options, multiContext: false),
                additionalHeaders: CreateAuthenticationHeaders(options),
                keepAliveInterval: keepAliveInterval ?? TimeSpan.FromSeconds(20),
                connectTimeout: connectTimeout ?? TimeSpan.FromSeconds(30),
                cancellationToken: cancellationToken).ConfigureAwait(false);

            await client.SendClientMessageAsync(
                new TextToDialogueWebsocketClientMessage
                {
                    Voices = voiceIds.ToArray(),
                    VoiceSettings = options.VoiceSettings is null
                        ? null
                        : new TextToDialogueRealtime.TextToDialogueWebsocketVoiceSettings
                        {
                            Stability = options.VoiceSettings.Stability,
                        },
                    PronunciationDictionaryLocators = options.PronunciationDictionaryLocators?
                        .Select(static locator => new TextToDialogueRealtime.PronunciationDictionaryLocator
                        {
                            PronunciationDictionaryId = locator.PronunciationDictionaryId,
                            VersionId = locator.VersionId,
                        })
                        .ToArray(),
                },
                cancellationToken).ConfigureAwait(false);

            return client;
        }
        catch
        {
            await client.DisposeAsync().ConfigureAwait(false);
            throw;
        }
    }

    /// <summary>
    /// Opens an Eleven v3 multi-context Text to Dialogue WebSocket connection.
    /// Use <see cref="TextToDialogueMultiContextRealtimeClient.OpenContextAsync"/> to initialize each context.
    /// </summary>
    public async Task<TextToDialogueMultiContextRealtimeClient> ConnectMultiContextRealtimeAsync(
        RealtimeTextToDialogueOptions? options = null,
        TimeSpan? connectTimeout = null,
        TimeSpan? keepAliveInterval = null,
        CancellationToken cancellationToken = default)
    {
        options ??= new RealtimeTextToDialogueOptions();
        RealtimeTextToDialogueValidation.ValidateOptions(options);

        var client = new TextToDialogueMultiContextRealtimeClient
        {
            ConnectedModelId = options.ModelId,
            InitialVoiceSettings = options.VoiceSettings,
            InitialPronunciationDictionaryLocators = options.PronunciationDictionaryLocators,
        };

        try
        {
            await client.ConnectAsync(
                uri: BuildRealtimeUri(options, multiContext: true),
                additionalHeaders: CreateAuthenticationHeaders(options),
                keepAliveInterval: keepAliveInterval ?? TimeSpan.FromSeconds(20),
                connectTimeout: connectTimeout ?? TimeSpan.FromSeconds(30),
                cancellationToken: cancellationToken).ConfigureAwait(false);

            return client;
        }
        catch
        {
            await client.DisposeAsync().ConfigureAwait(false);
            throw;
        }
    }

    private Uri BuildRealtimeUri(RealtimeTextToDialogueOptions options, bool multiContext)
    {
        var baseAddress = HttpClient.BaseAddress ?? new Uri(DefaultBaseUrl);
        var baseUrl = baseAddress.ToString();
        if (baseUrl.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
        {
            baseUrl = string.Concat("wss://", baseUrl.AsSpan("https://".Length));
        }
        else if (baseUrl.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
        {
            baseUrl = string.Concat("ws://", baseUrl.AsSpan("http://".Length));
        }

        if (!Uri.TryCreate(baseUrl, UriKind.Absolute, out var baseUri))
        {
            throw new InvalidOperationException($"Invalid base URL: '{baseAddress}'.");
        }

        var query = new List<string>();
        AddQuery(query, "model_id", options.ModelId);
        AddQuery(query, "output_format", options.OutputFormat);
        AddQuery(query, "language_code", options.LanguageCode);
        AddQuery(query, "apply_text_normalization", options.ApplyTextNormalization switch
        {
            RealtimeTextNormalization.Auto => "auto",
            RealtimeTextNormalization.On => "on",
            RealtimeTextNormalization.Off => "off",
            _ => throw new ArgumentOutOfRangeException(nameof(options)),
        });
        AddQuery(query, "single_use_token", options.SingleUseToken);

        if (options.SyncAlignment)
        {
            AddQuery(query, "sync_alignment", "true");
        }

        if (options.Seed.HasValue)
        {
            AddQuery(query, "seed", options.Seed.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (options.EnableLogging.HasValue)
        {
            AddQuery(query, "enable_logging", options.EnableLogging.Value ? "true" : "false");
        }

        var path = CombinePaths(
            baseUri.AbsolutePath,
            multiContext ? MultiContextRealtimePath : RealtimePath);
        return new UriBuilder(baseUri)
        {
            Path = path,
            Query = string.Join("&", query),
        }.Uri;
    }

    private Dictionary<string, string>? CreateAuthenticationHeaders(RealtimeTextToDialogueOptions options)
    {
        var apiKey = Authorizations.FirstOrDefault(static authorization => authorization.Name == "xi-api-key")?.Value;
        if (string.IsNullOrWhiteSpace(options.SingleUseToken) && string.IsNullOrWhiteSpace(apiKey))
        {
            throw new InvalidOperationException(
                "Either an API key (via Authorizations) or a single-use token must be provided for realtime Text to Dialogue.");
        }

        return string.IsNullOrWhiteSpace(options.SingleUseToken)
            ? new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["xi-api-key"] = apiKey!,
            }
            : null;
    }

    private static void AddQuery(List<string> query, string name, string? value)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            query.Add($"{name}={Uri.EscapeDataString(value)}");
        }
    }

    private static string CombinePaths(string basePath, string relativePath)
    {
        if (string.IsNullOrWhiteSpace(basePath) || basePath == "/")
        {
            return relativePath;
        }

        return $"{basePath.TrimEnd('/')}/{relativePath.TrimStart('/')}";
    }
}

internal static class RealtimeTextToDialogueValidation
{
    public static void ValidateOptions(RealtimeTextToDialogueOptions options)
    {
        if (string.IsNullOrWhiteSpace(options.ModelId) ||
            !options.ModelId.StartsWith("eleven_v3", StringComparison.Ordinal))
        {
            throw new ArgumentException(
                "Realtime Text to Dialogue requires a model ID starting with 'eleven_v3'.",
                nameof(options));
        }

        ArgumentException.ThrowIfNullOrWhiteSpace(options.OutputFormat);

        if (options.VoiceSettings is { Stability: < 0 or > 1 })
        {
            throw new ArgumentOutOfRangeException(
                nameof(options),
                "Voice stability must be between 0 and 1.");
        }

        if (options.Seed is < 0 or > uint.MaxValue)
        {
            throw new ArgumentOutOfRangeException(
                nameof(options),
                "Seed must be between 0 and 4294967295.");
        }

        if (options.PronunciationDictionaryLocators is { } locators)
        {
            foreach (var locator in locators)
            {
                ArgumentException.ThrowIfNullOrWhiteSpace(locator.PronunciationDictionaryId);
                ArgumentException.ThrowIfNullOrWhiteSpace(locator.VersionId);
            }
        }
    }

    public static void ValidateVoiceIds(IReadOnlyList<string> voiceIds, string modelId)
    {
        ArgumentNullException.ThrowIfNull(voiceIds);
        if (voiceIds.Count == 0)
        {
            throw new ArgumentException("At least one voice ID is required.", nameof(voiceIds));
        }

        if (voiceIds.Count > 10)
        {
            throw new ArgumentException("At most ten voice IDs may be registered.", nameof(voiceIds));
        }

        if (modelId == RealtimeTextToDialogueOptions.ElevenV3ConversationalModel && voiceIds.Count != 1)
        {
            throw new ArgumentException(
                "Eleven v3 Conversational accepts exactly one registered voice per session or context.",
                nameof(voiceIds));
        }

        var uniqueVoiceIds = new HashSet<string>(StringComparer.Ordinal);
        foreach (var voiceId in voiceIds)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(voiceId);
            if (!uniqueVoiceIds.Add(voiceId))
            {
                throw new ArgumentException("Voice IDs must be unique.", nameof(voiceIds));
            }
        }
    }
}
