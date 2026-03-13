using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;

namespace ElevenLabs;

/// <summary>
/// Represents a realtime speech-to-text WebSocket session.
/// </summary>
public class RealtimeSpeechToTextSession : IAsyncDisposable
{
    private readonly ClientWebSocket _webSocket;
    private bool _disposed;
    private bool _sentPreviousText;

    internal RealtimeSpeechToTextSession(ClientWebSocket webSocket)
    {
        _webSocket = webSocket;
    }

    /// <summary>
    /// Protected constructor for testing/mocking.
    /// </summary>
    protected RealtimeSpeechToTextSession()
    {
        _webSocket = null!;
    }

    /// <summary>
    /// Sends a PCM audio chunk as raw bytes.
    /// </summary>
    public virtual Task SendAudioChunkAsync(
        ReadOnlyMemory<byte> audioBytes,
        int sampleRate,
        bool commit,
        string? previousText = null,
        CancellationToken cancellationToken = default)
        => SendAudioChunkInternalAsync(audioBytes, sampleRate, commit, previousText, cancellationToken);

    /// <summary>
    /// Sends a PCM16 audio chunk as sample array.
    /// </summary>
    public Task SendAudioChunkAsync(
        ReadOnlySpan<short> samples,
        int sampleRate,
        bool commit,
        string? previousText = null,
        CancellationToken cancellationToken = default)
    {
        var bytes = MemoryMarshal.AsBytes(samples).ToArray();
        return SendAudioChunkInternalAsync(bytes, sampleRate, commit, previousText, cancellationToken);
    }

    /// <summary>
    /// Reads a single realtime event from the WebSocket.
    /// </summary>
    public async Task<RealtimeSpeechToTextEvent?> ReceiveEventAsync(CancellationToken cancellationToken = default)
    {
        var json = await ReceiveTextMessageAsync(cancellationToken).ConfigureAwait(false);
        if (json == null)
        {
            return null;
        }

        return RealtimeEventParser.Parse(json);
    }

    /// <summary>
    /// Streams realtime events until the WebSocket closes.
    /// </summary>
    public virtual async IAsyncEnumerable<RealtimeSpeechToTextEvent> ReadEventsAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        while (_webSocket.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
        {
            var json = await ReceiveTextMessageAsync(cancellationToken).ConfigureAwait(false);
            if (json == null)
            {
                yield break;
            }

            yield return RealtimeEventParser.Parse(json);
        }
    }

    private async Task SendTextAsync(string json, CancellationToken cancellationToken)
    {
        var payload = Encoding.UTF8.GetBytes(json);
        await _webSocket.SendAsync(
            new ArraySegment<byte>(payload),
            WebSocketMessageType.Text,
            endOfMessage: true,
            cancellationToken).ConfigureAwait(false);
    }

    private async Task SendAudioChunkInternalAsync(
        ReadOnlyMemory<byte> audioBytes,
        int sampleRate,
        bool commit,
        string? previousText,
        CancellationToken cancellationToken)
    {
        if (previousText != null && _sentPreviousText)
        {
            throw new InvalidOperationException("previousText can only be sent with the first audio chunk.");
        }

        var message = new InputAudioChunk
        {
            AudioBase64 = Convert.ToBase64String(audioBytes.Span),
            Commit = commit,
            SampleRate = sampleRate,
            PreviousText = previousText
        };

        var json = JsonSerializer.Serialize(message, RealtimeJsonContext.Default.InputAudioChunk);
        await SendTextAsync(json, cancellationToken).ConfigureAwait(false);

        if (previousText != null)
        {
            _sentPreviousText = true;
        }
    }

    private async Task<string?> ReceiveTextMessageAsync(CancellationToken cancellationToken)
    {
        var buffer = new byte[8192];
        using var ms = new MemoryStream();

        while (true)
        {
            var result = await _webSocket.ReceiveAsync(
                new ArraySegment<byte>(buffer), cancellationToken).ConfigureAwait(false);

            if (result.MessageType == WebSocketMessageType.Close)
            {
                return null;
            }

            if (result.MessageType == WebSocketMessageType.Binary)
            {
                while (!result.EndOfMessage)
                {
                    result = await _webSocket.ReceiveAsync(
                        new ArraySegment<byte>(buffer), cancellationToken).ConfigureAwait(false);
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        return null;
                    }
                }

                continue;
            }

            await ms.WriteAsync(buffer.AsMemory(0, result.Count), cancellationToken).ConfigureAwait(false);

            if (result.EndOfMessage)
            {
                break;
            }
        }

        return Encoding.UTF8.GetString(ms.ToArray());
    }

    /// <inheritdoc/>
    public virtual async ValueTask DisposeAsync()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;

        if (_webSocket.State == WebSocketState.Open)
        {
            try
            {
                await _webSocket.CloseAsync(
                    WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None).ConfigureAwait(false);
            }
            catch (WebSocketException)
            {
                // Swallow close failures during disposal.
            }
        }

        _webSocket.Dispose();
        GC.SuppressFinalize(this);
    }
}
