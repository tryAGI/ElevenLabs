
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The aspect ratio of the output image. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
    /// Default Value: 16:9
    /// </summary>
    public enum Gemini25FlashImageRequestAspectRatio
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
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Gemini25FlashImageRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Gemini25FlashImageRequestAspectRatio value)
        {
            return value switch
            {
                Gemini25FlashImageRequestAspectRatio.x16_9 => "16:9",
                Gemini25FlashImageRequestAspectRatio.x1_1 => "1:1",
                Gemini25FlashImageRequestAspectRatio.x21_9 => "21:9",
                Gemini25FlashImageRequestAspectRatio.x2_3 => "2:3",
                Gemini25FlashImageRequestAspectRatio.x3_2 => "3:2",
                Gemini25FlashImageRequestAspectRatio.x3_4 => "3:4",
                Gemini25FlashImageRequestAspectRatio.x4_3 => "4:3",
                Gemini25FlashImageRequestAspectRatio.x4_5 => "4:5",
                Gemini25FlashImageRequestAspectRatio.x5_4 => "5:4",
                Gemini25FlashImageRequestAspectRatio.x9_16 => "9:16",
                Gemini25FlashImageRequestAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Gemini25FlashImageRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Gemini25FlashImageRequestAspectRatio.x16_9,
                "1:1" => Gemini25FlashImageRequestAspectRatio.x1_1,
                "21:9" => Gemini25FlashImageRequestAspectRatio.x21_9,
                "2:3" => Gemini25FlashImageRequestAspectRatio.x2_3,
                "3:2" => Gemini25FlashImageRequestAspectRatio.x3_2,
                "3:4" => Gemini25FlashImageRequestAspectRatio.x3_4,
                "4:3" => Gemini25FlashImageRequestAspectRatio.x4_3,
                "4:5" => Gemini25FlashImageRequestAspectRatio.x4_5,
                "5:4" => Gemini25FlashImageRequestAspectRatio.x5_4,
                "9:16" => Gemini25FlashImageRequestAspectRatio.x9_16,
                "auto" => Gemini25FlashImageRequestAspectRatio.Auto,
                _ => null,
            };
        }
    }
}