namespace ElevenLabs;

/// <summary>
/// Supported input audio formats for ElevenLabs realtime speech-to-text.
/// </summary>
public enum RealtimeAudioFormat
{
    /// <summary>PCM 8000 Hz.</summary>
    Pcm8000,

    /// <summary>PCM 16000 Hz.</summary>
    Pcm16000,

    /// <summary>PCM 22050 Hz.</summary>
    Pcm22050,

    /// <summary>PCM 24000 Hz.</summary>
    Pcm24000,

    /// <summary>PCM 44100 Hz.</summary>
    Pcm44100,

    /// <summary>PCM 48000 Hz.</summary>
    Pcm48000,

    /// <summary>μ-law 8000 Hz.</summary>
    Ulaw8000
}

internal static class RealtimeAudioFormatExtensions
{
    public static string ToApiValue(this RealtimeAudioFormat format) => format switch
    {
        RealtimeAudioFormat.Pcm8000 => "pcm_8000",
        RealtimeAudioFormat.Pcm16000 => "pcm_16000",
        RealtimeAudioFormat.Pcm22050 => "pcm_22050",
        RealtimeAudioFormat.Pcm24000 => "pcm_24000",
        RealtimeAudioFormat.Pcm44100 => "pcm_44100",
        RealtimeAudioFormat.Pcm48000 => "pcm_48000",
        RealtimeAudioFormat.Ulaw8000 => "ulaw_8000",
        _ => "pcm_16000"
    };

    public static RealtimeAudioFormat? FromApiValue(string? value) => value switch
    {
        "pcm_8000" => RealtimeAudioFormat.Pcm8000,
        "pcm_16000" => RealtimeAudioFormat.Pcm16000,
        "pcm_22050" => RealtimeAudioFormat.Pcm22050,
        "pcm_24000" => RealtimeAudioFormat.Pcm24000,
        "pcm_44100" => RealtimeAudioFormat.Pcm44100,
        "pcm_48000" => RealtimeAudioFormat.Pcm48000,
        "ulaw_8000" => RealtimeAudioFormat.Ulaw8000,
        _ => null
    };
}
