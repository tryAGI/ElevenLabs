
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum BytedanceSeedream4ParametersAspectRatio
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
    public static class BytedanceSeedream4ParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedream4ParametersAspectRatio value)
        {
            return value switch
            {
                BytedanceSeedream4ParametersAspectRatio.x16_9 => "16:9",
                BytedanceSeedream4ParametersAspectRatio.x1_1 => "1:1",
                BytedanceSeedream4ParametersAspectRatio.x3_4 => "3:4",
                BytedanceSeedream4ParametersAspectRatio.x4_3 => "4:3",
                BytedanceSeedream4ParametersAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedream4ParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => BytedanceSeedream4ParametersAspectRatio.x16_9,
                "1:1" => BytedanceSeedream4ParametersAspectRatio.x1_1,
                "3:4" => BytedanceSeedream4ParametersAspectRatio.x3_4,
                "4:3" => BytedanceSeedream4ParametersAspectRatio.x4_3,
                "9:16" => BytedanceSeedream4ParametersAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}