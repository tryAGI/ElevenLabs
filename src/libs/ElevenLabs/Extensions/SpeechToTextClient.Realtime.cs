using System.Globalization;
using System.Net.WebSockets;

namespace ElevenLabs;

public sealed partial class SpeechToTextClient
{
    private const string RealtimePath = "/v1/speech-to-text/realtime";

    /// <summary>
    /// Opens a realtime speech-to-text WebSocket session.
    /// </summary>
    /// <param name="options">Options for the realtime session. If null, defaults are used.</param>
    /// <param name="connectTimeout">Connection timeout. Defaults to 30 seconds.</param>
    /// <param name="keepAliveInterval">WebSocket keep-alive interval. Defaults to 20 seconds.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A connected <see cref="RealtimeSpeechToTextSession"/>.</returns>
    public async Task<RealtimeSpeechToTextSession> ConnectRealtimeAsync(
        RealtimeSpeechToTextOptions? options = null,
        TimeSpan? connectTimeout = null,
        TimeSpan? keepAliveInterval = null,
        CancellationToken cancellationToken = default)
    {
        options ??= new RealtimeSpeechToTextOptions();
        var timeout = connectTimeout ?? TimeSpan.FromSeconds(30);
        var keepAlive = keepAliveInterval ?? TimeSpan.FromSeconds(20);

        var apiKey = Authorizations
            .FirstOrDefault(a => a.Name == "xi-api-key")?.Value;

        if (string.IsNullOrWhiteSpace(options.Token) && string.IsNullOrWhiteSpace(apiKey))
        {
            throw new InvalidOperationException(
                "Either an API key (via Authorizations) or a Token (via options) must be provided for realtime sessions.");
        }

        var uri = BuildRealtimeUri(options);

        var webSocket = new ClientWebSocket();
        webSocket.Options.KeepAliveInterval = keepAlive;

        if (string.IsNullOrWhiteSpace(options.Token) && !string.IsNullOrWhiteSpace(apiKey))
        {
            webSocket.Options.SetRequestHeader("xi-api-key", apiKey);
        }

        using var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cts.CancelAfter(timeout);

        await webSocket.ConnectAsync(uri, cts.Token).ConfigureAwait(false);

        return new RealtimeSpeechToTextSession(webSocket);
    }

    private Uri BuildRealtimeUri(RealtimeSpeechToTextOptions options)
    {
        var baseAddress = HttpClient.BaseAddress
            ?? new Uri(DefaultBaseUrl);

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
        AddQuery(query, "token", options.Token);
        AddQuery(query, "audio_format", options.AudioFormat.ToApiValue());
        AddQuery(query, "commit_strategy", options.CommitStrategy.ToApiValue());
        AddQuery(query, "language_code", options.LanguageCode);

        if (options.IncludeTimestamps)
        {
            AddQuery(query, "include_timestamps", "true");
        }

        if (options.IncludeLanguageDetection)
        {
            AddQuery(query, "include_language_detection", "true");
        }

        if (options.VadSilenceThresholdSeconds.HasValue)
        {
            AddQuery(query, "vad_silence_threshold_secs",
                options.VadSilenceThresholdSeconds.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
        }

        if (options.VadThreshold.HasValue)
        {
            AddQuery(query, "vad_threshold",
                options.VadThreshold.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
        }

        if (options.MinSpeechDurationMs.HasValue)
        {
            AddQuery(query, "min_speech_duration_ms",
                options.MinSpeechDurationMs.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (options.MinSilenceDurationMs.HasValue)
        {
            AddQuery(query, "min_silence_duration_ms",
                options.MinSilenceDurationMs.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (options.EnableLogging.HasValue)
        {
            AddQuery(query, "enable_logging", options.EnableLogging.Value ? "true" : "false");
        }

        var path = CombinePaths(baseUri.AbsolutePath, RealtimePath);
        var builder = new UriBuilder(baseUri)
        {
            Path = path,
            Query = string.Join("&", query)
        };

        return builder.Uri;
    }

    private static void AddQuery(List<string> query, string name, string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return;
        }

        query.Add($"{name}={Uri.EscapeDataString(value)}");
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
