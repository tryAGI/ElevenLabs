namespace ElevenLabs.TextToDialogueRealtime;

public sealed partial class TextToDialogueRealtimeClient
{
    /// <summary>The model selected when this connection was opened.</summary>
    public string ConnectedModelId { get; internal set; } = RealtimeTextToDialogueOptions.ElevenV3ConversationalModel;

    /// <summary>The voice IDs registered by the session initialization message.</summary>
    public IReadOnlyList<string> RegisteredVoiceIds { get; internal set; } = [];

    /// <summary>Sends incremental text for a registered voice.</summary>
    public Task SendTextAsync(
        string voiceId,
        string text,
        bool newTurn = false,
        bool flush = false,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(voiceId);
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        if (!RegisteredVoiceIds.Contains(voiceId, StringComparer.Ordinal))
        {
            throw new ArgumentException("The voice ID was not registered for this session.", nameof(voiceId));
        }

        return SendClientMessageAsync(
            new TextToDialogueWebsocketClientMessage
            {
                Inputs =
                [
                    new TextToDialogueWebsocketVoiceInput
                    {
                        Text = text,
                        VoiceId = voiceId,
                        NewTurn = newTurn ? true : null,
                    },
                ],
                Flush = flush ? true : null,
            },
            cancellationToken);
    }

    /// <summary>Forces generation of buffered text without closing the session.</summary>
    public Task FlushAsync(CancellationToken cancellationToken = default)
        => SendClientMessageAsync(
            new TextToDialogueWebsocketClientMessage { Flush = true },
            cancellationToken);

    /// <summary>Resets the server's 20-second receive timeout without synthesizing audio.</summary>
    public Task KeepAliveAsync(CancellationToken cancellationToken = default)
        => SendClientMessageAsync(
            new TextToDialogueWebsocketClientMessage { KeepAlive = true },
            cancellationToken);

    /// <summary>Flushes remaining audio and asks the server to close the session.</summary>
    public Task CloseSocketAsync(CancellationToken cancellationToken = default)
        => SendClientMessageAsync(
            new TextToDialogueWebsocketClientMessage { CloseSocket = true },
            cancellationToken);
}
