
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Identifiers for audio voice filters.
    /// </summary>
    public enum AudioFilterId
    {
        /// <summary>
        /// 
        /// </summary>
        BrightPhone,
        /// <summary>
        /// 
        /// </summary>
        LowQualityPhone,
        /// <summary>
        /// 
        /// </summary>
        Phone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioFilterIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioFilterId value)
        {
            return value switch
            {
                AudioFilterId.BrightPhone => "bright_phone",
                AudioFilterId.LowQualityPhone => "low_quality_phone",
                AudioFilterId.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioFilterId? ToEnum(string value)
        {
            return value switch
            {
                "bright_phone" => AudioFilterId.BrightPhone,
                "low_quality_phone" => AudioFilterId.LowQualityPhone,
                "phone" => AudioFilterId.Phone,
                _ => null,
            };
        }
    }
}