
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum BytedanceSeedanceParametersAspectRatio
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
    public static class BytedanceSeedanceParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedanceParametersAspectRatio value)
        {
            return value switch
            {
                BytedanceSeedanceParametersAspectRatio.x16_9 => "16:9",
                BytedanceSeedanceParametersAspectRatio.x1_1 => "1:1",
                BytedanceSeedanceParametersAspectRatio.x21_9 => "21:9",
                BytedanceSeedanceParametersAspectRatio.x3_4 => "3:4",
                BytedanceSeedanceParametersAspectRatio.x4_3 => "4:3",
                BytedanceSeedanceParametersAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedanceParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => BytedanceSeedanceParametersAspectRatio.x16_9,
                "1:1" => BytedanceSeedanceParametersAspectRatio.x1_1,
                "21:9" => BytedanceSeedanceParametersAspectRatio.x21_9,
                "3:4" => BytedanceSeedanceParametersAspectRatio.x3_4,
                "4:3" => BytedanceSeedanceParametersAspectRatio.x4_3,
                "9:16" => BytedanceSeedanceParametersAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}