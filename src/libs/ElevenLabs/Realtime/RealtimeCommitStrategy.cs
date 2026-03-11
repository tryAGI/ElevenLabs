namespace ElevenLabs;

/// <summary>
/// Commit strategy for realtime speech-to-text.
/// </summary>
public enum RealtimeCommitStrategy
{
    /// <summary>Manual commit via the commit flag on audio chunks.</summary>
    Manual,

    /// <summary>Automatic commit based on voice activity detection.</summary>
    Vad
}

internal static class RealtimeCommitStrategyExtensions
{
    public static string ToApiValue(this RealtimeCommitStrategy strategy) => strategy switch
    {
        RealtimeCommitStrategy.Manual => "manual",
        RealtimeCommitStrategy.Vad => "vad",
        _ => "manual"
    };

    public static RealtimeCommitStrategy? FromApiValue(string? value) => value switch
    {
        "manual" => RealtimeCommitStrategy.Manual,
        "vad" => RealtimeCommitStrategy.Vad,
        _ => null
    };
}
