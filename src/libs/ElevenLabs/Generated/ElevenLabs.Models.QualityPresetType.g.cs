
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: standard
    /// </summary>
    public enum QualityPresetType
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Ultra,
        /// <summary>
        /// 
        /// </summary>
        UltraLossless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityPresetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityPresetType value)
        {
            return value switch
            {
                QualityPresetType.High => "high",
                QualityPresetType.Standard => "standard",
                QualityPresetType.Ultra => "ultra",
                QualityPresetType.UltraLossless => "ultra_lossless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityPresetType? ToEnum(string value)
        {
            return value switch
            {
                "high" => QualityPresetType.High,
                "standard" => QualityPresetType.Standard,
                "ultra" => QualityPresetType.Ultra,
                "ultra_lossless" => QualityPresetType.UltraLossless,
                _ => null,
            };
        }
    }
}