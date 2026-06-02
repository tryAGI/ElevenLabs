
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum BytedanceSeedance15ProParametersAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x21_9,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BytedanceSeedance15ProParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedance15ProParametersAspectRatio value)
        {
            return value switch
            {
                BytedanceSeedance15ProParametersAspectRatio.x16_9 => "16:9",
                BytedanceSeedance15ProParametersAspectRatio.x1_1 => "1:1",
                BytedanceSeedance15ProParametersAspectRatio.x21_9 => "21:9",
                BytedanceSeedance15ProParametersAspectRatio.x3_4 => "3:4",
                BytedanceSeedance15ProParametersAspectRatio.x4_3 => "4:3",
                BytedanceSeedance15ProParametersAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedance15ProParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => BytedanceSeedance15ProParametersAspectRatio.x16_9,
                "1:1" => BytedanceSeedance15ProParametersAspectRatio.x1_1,
                "21:9" => BytedanceSeedance15ProParametersAspectRatio.x21_9,
                "3:4" => BytedanceSeedance15ProParametersAspectRatio.x3_4,
                "4:3" => BytedanceSeedance15ProParametersAspectRatio.x4_3,
                "9:16" => BytedanceSeedance15ProParametersAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}