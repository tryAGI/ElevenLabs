
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat
    {
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        PcmS16le16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat value)
        {
            return value switch
            {
                BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat.Other => "other",
                BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat.PcmS16le16 => "pcm_s16le_16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat? ToEnum(string value)
        {
            return value switch
            {
                "other" => BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat.Other,
                "pcm_s16le_16" => BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat.PcmS16le16,
                _ => null,
            };
        }
    }
}