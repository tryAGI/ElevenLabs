namespace ElevenLabs.TextToDialogueMultiContextRealtime;

public sealed partial class TextToDialogueMultiContextRealtimeClient
{
    /// <summary>The model selected when this connection was opened.</summary>
    public string ConnectedModelId { get; internal set; } = RealtimeTextToDialogueOptions.ElevenV3ConversationalModel;

    internal RealtimeTextToDialogueVoiceSettings? InitialVoiceSettings { get; set; }

    internal IReadOnlyList<RealtimePronunciationDictionaryLocator>? InitialPronunciationDictionaryLocators { get; set; }

    /// <summary>Creates a dialogue context and registers its voices and initial settings.</summary>
    public Task OpenContextAsync(
        string contextId,
        IReadOnlyList<string> voiceIds,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(contextId);
        RealtimeTextToDialogueValidation.ValidateVoiceIds(voiceIds, ConnectedModelId);

        return SendClientMessageMultiAsync(
            new TextToDialogueWebsocketClientMessageMulti
            {
                ContextId = contextId,
                Voices = voiceIds.ToArray(),
                VoiceSettings = InitialVoiceSettings is null
                    ? null
                    : new TextToDialogueWebsocketVoiceSettings
                    {
                        Stability = InitialVoiceSettings.Stability,
                    },
                PronunciationDictionaryLocators = InitialPronunciationDictionaryLocators?
                    .Select(static locator => new PronunciationDictionaryLocator
                    {
                        PronunciationDictionaryId = locator.PronunciationDictionaryId,
                        VersionId = locator.VersionId,
                    })
                    .ToArray(),
            },
            cancellationToken);
    }

    /// <summary>Sends incremental text to a dialogue context.</summary>
    public Task SendTextAsync(
        string contextId,
        string voiceId,
        string text,
        bool newTurn = false,
        bool flush = false,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(contextId);
        ArgumentException.ThrowIfNullOrWhiteSpace(voiceId);
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        return SendClientMessageMultiAsync(
            new TextToDialogueWebsocketClientMessageMulti
            {
                ContextId = contextId,
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

    /// <summary>Forces generation of one context's buffered text.</summary>
    public Task FlushContextAsync(string contextId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(contextId);
        return SendClientMessageMultiAsync(
            new TextToDialogueWebsocketClientMessageMulti
            {
                ContextId = contextId,
                Flush = true,
            },
            cancellationToken);
    }

    /// <summary>Resets one context's 20-second inactivity timeout.</summary>
    public Task KeepContextAliveAsync(string contextId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(contextId);
        return SendClientMessageMultiAsync(
            new TextToDialogueWebsocketClientMessageMulti
            {
                ContextId = contextId,
                KeepAlive = true,
            },
            cancellationToken);
    }

    /// <summary>Flushes and closes one context while leaving other contexts open.</summary>
    public Task CloseContextAsync(string contextId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(contextId);
        return SendClientMessageMultiAsync(
            new TextToDialogueWebsocketClientMessageMulti
            {
                ContextId = contextId,
                CloseContext = true,
            },
            cancellationToken);
    }

    /// <summary>Flushes and closes every context and then closes the WebSocket.</summary>
    public Task CloseSocketAsync(CancellationToken cancellationToken = default)
        => SendClientMessageMultiAsync(
            new TextToDialogueWebsocketClientMessageMulti { CloseSocket = true },
            cancellationToken);
}
