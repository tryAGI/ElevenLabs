
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum GPTImage2ParametersAspectRatio
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
        x1_2,
        /// <summary>
        /// 
        /// </summary>
        x1_3,
        /// <summary>
        /// 
        /// </summary>
        x21_9,
        /// <summary>
        /// 
        /// </summary>
        x2_1,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x3_1,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
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
        x4_5,
        /// <summary>
        /// 
        /// </summary>
        x5_4,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPTImage2ParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage2ParametersAspectRatio value)
        {
            return value switch
            {
                GPTImage2ParametersAspectRatio.x16_9 => "16:9",
                GPTImage2ParametersAspectRatio.x1_1 => "1:1",
                GPTImage2ParametersAspectRatio.x1_2 => "1:2",
                GPTImage2ParametersAspectRatio.x1_3 => "1:3",
                GPTImage2ParametersAspectRatio.x21_9 => "21:9",
                GPTImage2ParametersAspectRatio.x2_1 => "2:1",
                GPTImage2ParametersAspectRatio.x2_3 => "2:3",
                GPTImage2ParametersAspectRatio.x3_1 => "3:1",
                GPTImage2ParametersAspectRatio.x3_2 => "3:2",
                GPTImage2ParametersAspectRatio.x3_4 => "3:4",
                GPTImage2ParametersAspectRatio.x4_3 => "4:3",
                GPTImage2ParametersAspectRatio.x4_5 => "4:5",
                GPTImage2ParametersAspectRatio.x5_4 => "5:4",
                GPTImage2ParametersAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage2ParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => GPTImage2ParametersAspectRatio.x16_9,
                "1:1" => GPTImage2ParametersAspectRatio.x1_1,
                "1:2" => GPTImage2ParametersAspectRatio.x1_2,
                "1:3" => GPTImage2ParametersAspectRatio.x1_3,
                "21:9" => GPTImage2ParametersAspectRatio.x21_9,
                "2:1" => GPTImage2ParametersAspectRatio.x2_1,
                "2:3" => GPTImage2ParametersAspectRatio.x2_3,
                "3:1" => GPTImage2ParametersAspectRatio.x3_1,
                "3:2" => GPTImage2ParametersAspectRatio.x3_2,
                "3:4" => GPTImage2ParametersAspectRatio.x3_4,
                "4:3" => GPTImage2ParametersAspectRatio.x4_3,
                "4:5" => GPTImage2ParametersAspectRatio.x4_5,
                "5:4" => GPTImage2ParametersAspectRatio.x5_4,
                "9:16" => GPTImage2ParametersAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}