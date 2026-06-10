
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: audio/pcm
    /// </summary>
    public enum AudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        AudioPcm,
        /// <summary>
        /// 
        /// </summary>
        AudioPcma,
        /// <summary>
        /// 
        /// </summary>
        AudioPcmu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioFormat value)
        {
            return value switch
            {
                AudioFormat.AudioPcm => "audio/pcm",
                AudioFormat.AudioPcma => "audio/pcma",
                AudioFormat.AudioPcmu => "audio/pcmu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "audio/pcm" => AudioFormat.AudioPcm,
                "audio/pcma" => AudioFormat.AudioPcma,
                "audio/pcmu" => AudioFormat.AudioPcmu,
                _ => null,
            };
        }
    }
}