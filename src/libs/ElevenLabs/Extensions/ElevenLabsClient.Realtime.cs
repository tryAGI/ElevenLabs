namespace ElevenLabs;

public sealed partial class ElevenLabsClient
{
    /// <summary>
    /// Opens a realtime speech-to-text WebSocket session.
    /// Convenience method that delegates to <see cref="SpeechToTextClient.ConnectRealtimeAsync"/>.
    /// </summary>
    /// <param name="options">Options for the realtime session. If null, defaults are used.</param>
    /// <param name="connectTimeout">Connection timeout. Defaults to 30 seconds.</param>
    /// <param name="keepAliveInterval">WebSocket keep-alive interval. Defaults to 20 seconds.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A connected <see cref="RealtimeSpeechToTextSession"/>.</returns>
    public Task<RealtimeSpeechToTextSession> ConnectRealtimeAsync(
        RealtimeSpeechToTextOptions? options = null,
        TimeSpan? connectTimeout = null,
        TimeSpan? keepAliveInterval = null,
        CancellationToken cancellationToken = default)
        => SpeechToText.ConnectRealtimeAsync(options, connectTimeout, keepAliveInterval, cancellationToken);
}
