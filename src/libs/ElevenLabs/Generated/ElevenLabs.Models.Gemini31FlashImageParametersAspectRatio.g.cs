
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum Gemini31FlashImageParametersAspectRatio
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
        x1_4,
        /// <summary>
        /// 
        /// </summary>
        x1_8,
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
        x4_1,
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
        x8_1,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Gemini31FlashImageParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Gemini31FlashImageParametersAspectRatio value)
        {
            return value switch
            {
                Gemini31FlashImageParametersAspectRatio.x16_9 => "16:9",
                Gemini31FlashImageParametersAspectRatio.x1_1 => "1:1",
                Gemini31FlashImageParametersAspectRatio.x1_4 => "1:4",
                Gemini31FlashImageParametersAspectRatio.x1_8 => "1:8",
                Gemini31FlashImageParametersAspectRatio.x21_9 => "21:9",
                Gemini31FlashImageParametersAspectRatio.x2_3 => "2:3",
                Gemini31FlashImageParametersAspectRatio.x3_2 => "3:2",
                Gemini31FlashImageParametersAspectRatio.x3_4 => "3:4",
                Gemini31FlashImageParametersAspectRatio.x4_1 => "4:1",
                Gemini31FlashImageParametersAspectRatio.x4_3 => "4:3",
                Gemini31FlashImageParametersAspectRatio.x4_5 => "4:5",
                Gemini31FlashImageParametersAspectRatio.x5_4 => "5:4",
                Gemini31FlashImageParametersAspectRatio.x8_1 => "8:1",
                Gemini31FlashImageParametersAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Gemini31FlashImageParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Gemini31FlashImageParametersAspectRatio.x16_9,
                "1:1" => Gemini31FlashImageParametersAspectRatio.x1_1,
                "1:4" => Gemini31FlashImageParametersAspectRatio.x1_4,
                "1:8" => Gemini31FlashImageParametersAspectRatio.x1_8,
                "21:9" => Gemini31FlashImageParametersAspectRatio.x21_9,
                "2:3" => Gemini31FlashImageParametersAspectRatio.x2_3,
                "3:2" => Gemini31FlashImageParametersAspectRatio.x3_2,
                "3:4" => Gemini31FlashImageParametersAspectRatio.x3_4,
                "4:1" => Gemini31FlashImageParametersAspectRatio.x4_1,
                "4:3" => Gemini31FlashImageParametersAspectRatio.x4_3,
                "4:5" => Gemini31FlashImageParametersAspectRatio.x4_5,
                "5:4" => Gemini31FlashImageParametersAspectRatio.x5_4,
                "8:1" => Gemini31FlashImageParametersAspectRatio.x8_1,
                "9:16" => Gemini31FlashImageParametersAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}