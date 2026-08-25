namespace ElevenLabs;

/// <summary>
/// Options for Eleven v3 realtime Text to Dialogue WebSocket connections.
/// </summary>
public sealed record RealtimeTextToDialogueOptions
{
    /// <summary>The generally available Eleven v3 Conversational model.</summary>
    public const string ElevenV3ConversationalModel = "eleven_v3_conversational";

    /// <summary>The standard Eleven v3 dialogue model.</summary>
    public const string ElevenV3Model = "eleven_v3";

    /// <summary>Model ID. Text to Dialogue WebSockets require an Eleven v3 model.</summary>
    public string ModelId { get; init; } = ElevenV3ConversationalModel;

    /// <summary>Audio output format, such as <c>mp3_44100_128</c> or <c>pcm_24000</c>.</summary>
    public string OutputFormat { get; init; } = "mp3_44100_128";

    /// <summary>Optional ISO 639-1 language code.</summary>
    public string? LanguageCode { get; init; }

    /// <summary>Include character alignment data on audio events when available.</summary>
    public bool SyncAlignment { get; init; }

    /// <summary>Text normalization behavior.</summary>
    public RealtimeTextNormalization ApplyTextNormalization { get; init; } = RealtimeTextNormalization.Auto;

    /// <summary>Optional deterministic sampling seed.</summary>
    public long? Seed { get; init; }

    /// <summary>
    /// Enables ElevenLabs request logging. Set to <see langword="false"/> for zero-retention mode,
    /// which is restricted to eligible enterprise workspaces.
    /// </summary>
    public bool? EnableLogging { get; init; }

    /// <summary>Optional single-use token for client-side connections.</summary>
    public string? SingleUseToken { get; init; }

    /// <summary>Optional voice settings sent when a session or context is initialized.</summary>
    public RealtimeTextToDialogueVoiceSettings? VoiceSettings { get; init; }

    /// <summary>Optional pronunciation dictionaries sent when a session or context is initialized.</summary>
    public IReadOnlyList<RealtimePronunciationDictionaryLocator>? PronunciationDictionaryLocators { get; init; }
}

/// <summary>Text normalization behavior for realtime Text to Dialogue.</summary>
public enum RealtimeTextNormalization
{
    /// <summary>Let ElevenLabs decide whether to normalize the text.</summary>
    Auto,

    /// <summary>Always normalize the text.</summary>
    On,

    /// <summary>Do not normalize the text.</summary>
    Off
}

/// <summary>Voice settings supported by Eleven v3 dialogue models.</summary>
/// <param name="Stability">
/// Stability from 0 to 1. Lower values allow broader emotional range; higher values are more stable.
/// </param>
public sealed record RealtimeTextToDialogueVoiceSettings(double Stability = 0.5);

/// <summary>Identifies a pronunciation dictionary version.</summary>
/// <param name="PronunciationDictionaryId">Pronunciation dictionary ID.</param>
/// <param name="VersionId">Pronunciation dictionary version ID.</param>
public sealed record RealtimePronunciationDictionaryLocator(
    string PronunciationDictionaryId,
    string VersionId);
