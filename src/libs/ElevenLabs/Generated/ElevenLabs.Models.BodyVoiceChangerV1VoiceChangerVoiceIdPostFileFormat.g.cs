
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat
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
    public static class BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat value)
        {
            return value switch
            {
                BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat.Other => "other",
                BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat.PcmS16le16 => "pcm_s16le_16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat? ToEnum(string value)
        {
            return value switch
            {
                "other" => BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat.Other,
                "pcm_s16le_16" => BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat.PcmS16le16,
                _ => null,
            };
        }
    }
}