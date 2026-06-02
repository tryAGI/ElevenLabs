
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum BytedanceSeedance2FastParametersAspectRatio2
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
    public static class BytedanceSeedance2FastParametersAspectRatio2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedance2FastParametersAspectRatio2 value)
        {
            return value switch
            {
                BytedanceSeedance2FastParametersAspectRatio2.x16_9 => "16:9",
                BytedanceSeedance2FastParametersAspectRatio2.x1_1 => "1:1",
                BytedanceSeedance2FastParametersAspectRatio2.x21_9 => "21:9",
                BytedanceSeedance2FastParametersAspectRatio2.x3_4 => "3:4",
                BytedanceSeedance2FastParametersAspectRatio2.x4_3 => "4:3",
                BytedanceSeedance2FastParametersAspectRatio2.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedance2FastParametersAspectRatio2? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => BytedanceSeedance2FastParametersAspectRatio2.x16_9,
                "1:1" => BytedanceSeedance2FastParametersAspectRatio2.x1_1,
                "21:9" => BytedanceSeedance2FastParametersAspectRatio2.x21_9,
                "3:4" => BytedanceSeedance2FastParametersAspectRatio2.x3_4,
                "4:3" => BytedanceSeedance2FastParametersAspectRatio2.x4_3,
                "9:16" => BytedanceSeedance2FastParametersAspectRatio2.x9_16,
                _ => null,
            };
        }
    }
}