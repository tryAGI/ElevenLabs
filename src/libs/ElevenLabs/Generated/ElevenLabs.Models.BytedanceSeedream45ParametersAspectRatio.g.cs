
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum BytedanceSeedream45ParametersAspectRatio
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
    public static class BytedanceSeedream45ParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedream45ParametersAspectRatio value)
        {
            return value switch
            {
                BytedanceSeedream45ParametersAspectRatio.x16_9 => "16:9",
                BytedanceSeedream45ParametersAspectRatio.x1_1 => "1:1",
                BytedanceSeedream45ParametersAspectRatio.x3_4 => "3:4",
                BytedanceSeedream45ParametersAspectRatio.x4_3 => "4:3",
                BytedanceSeedream45ParametersAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedream45ParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => BytedanceSeedream45ParametersAspectRatio.x16_9,
                "1:1" => BytedanceSeedream45ParametersAspectRatio.x1_1,
                "3:4" => BytedanceSeedream45ParametersAspectRatio.x3_4,
                "4:3" => BytedanceSeedream45ParametersAspectRatio.x4_3,
                "9:16" => BytedanceSeedream45ParametersAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}