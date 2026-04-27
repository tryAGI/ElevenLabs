
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum GeminiImageParametersAspectRatio
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
        x2_3,
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
    public static class GeminiImageParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeminiImageParametersAspectRatio value)
        {
            return value switch
            {
                GeminiImageParametersAspectRatio.x16_9 => "16:9",
                GeminiImageParametersAspectRatio.x1_1 => "1:1",
                GeminiImageParametersAspectRatio.x21_9 => "21:9",
                GeminiImageParametersAspectRatio.x2_3 => "2:3",
                GeminiImageParametersAspectRatio.x3_2 => "3:2",
                GeminiImageParametersAspectRatio.x3_4 => "3:4",
                GeminiImageParametersAspectRatio.x4_3 => "4:3",
                GeminiImageParametersAspectRatio.x4_5 => "4:5",
                GeminiImageParametersAspectRatio.x5_4 => "5:4",
                GeminiImageParametersAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeminiImageParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => GeminiImageParametersAspectRatio.x16_9,
                "1:1" => GeminiImageParametersAspectRatio.x1_1,
                "21:9" => GeminiImageParametersAspectRatio.x21_9,
                "2:3" => GeminiImageParametersAspectRatio.x2_3,
                "3:2" => GeminiImageParametersAspectRatio.x3_2,
                "3:4" => GeminiImageParametersAspectRatio.x3_4,
                "4:3" => GeminiImageParametersAspectRatio.x4_3,
                "4:5" => GeminiImageParametersAspectRatio.x4_5,
                "5:4" => GeminiImageParametersAspectRatio.x5_4,
                "9:16" => GeminiImageParametersAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}