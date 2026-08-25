using ElevenLabs.TextToDialogueMultiContextRealtime;
using ElevenLabs.TextToDialogueRealtime;

namespace ElevenLabs;

public sealed partial class ElevenLabsClient
{
    /// <summary>Opens and initializes an Eleven v3 realtime Text to Dialogue WebSocket session.</summary>
    public Task<TextToDialogueRealtimeClient> ConnectTextToDialogueRealtimeAsync(
        string voiceId,
        RealtimeTextToDialogueOptions? options = null,
        TimeSpan? connectTimeout = null,
        TimeSpan? keepAliveInterval = null,
        CancellationToken cancellationToken = default)
        => TextToDialogue.ConnectRealtimeAsync(
            voiceId,
            options,
            connectTimeout,
            keepAliveInterval,
            cancellationToken);

    /// <summary>Opens an Eleven v3 multi-context realtime Text to Dialogue WebSocket connection.</summary>
    public Task<TextToDialogueMultiContextRealtimeClient> ConnectTextToDialogueMultiContextRealtimeAsync(
        RealtimeTextToDialogueOptions? options = null,
        TimeSpan? connectTimeout = null,
        TimeSpan? keepAliveInterval = null,
        CancellationToken cancellationToken = default)
        => TextToDialogue.ConnectMultiContextRealtimeAsync(
            options,
            connectTimeout,
            keepAliveInterval,
            cancellationToken);
}
