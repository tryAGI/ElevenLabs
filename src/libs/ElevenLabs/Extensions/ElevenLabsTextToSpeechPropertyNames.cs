#nullable enable

namespace ElevenLabs;

/// <summary>
/// ElevenLabs-specific <see cref="Microsoft.Extensions.AI.TextToSpeechOptions.AdditionalProperties" /> keys.
/// </summary>
public static class ElevenLabsTextToSpeechPropertyNames
{
    /// <summary>Controls ElevenLabs request logging and history retention when supported by the account.</summary>
    public const string EnableLogging = "elevenlabs:enable_logging";

    /// <summary>Exact ElevenLabs output format id, such as <c>mp3_22050_32</c> or <c>pcm_24000</c>.</summary>
    public const string OutputFormat = "elevenlabs:output_format";

    /// <summary>Latency optimization level from 0 to 4.</summary>
    public const string OptimizeStreamingLatency = "elevenlabs:optimize_streaming_latency";

    /// <summary>Previous text used to improve speech continuity.</summary>
    public const string PreviousText = "elevenlabs:previous_text";

    /// <summary>Next text used to improve speech continuity.</summary>
    public const string NextText = "elevenlabs:next_text";

    /// <summary>Deterministic sampling seed.</summary>
    public const string Seed = "elevenlabs:seed";

    /// <summary>Voice setting for similarity boost.</summary>
    public const string SimilarityBoost = "elevenlabs:similarity_boost";

    /// <summary>Voice setting for stability.</summary>
    public const string Stability = "elevenlabs:stability";

    /// <summary>Voice setting for style exaggeration.</summary>
    public const string Style = "elevenlabs:style";

    /// <summary>Voice setting for speaker boost.</summary>
    public const string UseSpeakerBoost = "elevenlabs:use_speaker_boost";

    /// <summary>Text normalization mode: <c>auto</c>, <c>on</c>, or <c>off</c>.</summary>
    public const string ApplyTextNormalization = "elevenlabs:apply_text_normalization";
}
