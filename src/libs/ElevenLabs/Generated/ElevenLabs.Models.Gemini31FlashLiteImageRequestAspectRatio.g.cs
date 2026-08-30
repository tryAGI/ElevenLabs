
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The aspect ratio of the output image. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
    /// Default Value: 16:9
    /// </summary>
    public enum Gemini31FlashLiteImageRequestAspectRatio
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
    public static class Gemini31FlashLiteImageRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Gemini31FlashLiteImageRequestAspectRatio value)
        {
            return value switch
            {
                Gemini31FlashLiteImageRequestAspectRatio.x16_9 => "16:9",
                Gemini31FlashLiteImageRequestAspectRatio.x1_1 => "1:1",
                Gemini31FlashLiteImageRequestAspectRatio.x21_9 => "21:9",
                Gemini31FlashLiteImageRequestAspectRatio.x2_3 => "2:3",
                Gemini31FlashLiteImageRequestAspectRatio.x3_2 => "3:2",
                Gemini31FlashLiteImageRequestAspectRatio.x3_4 => "3:4",
                Gemini31FlashLiteImageRequestAspectRatio.x4_3 => "4:3",
                Gemini31FlashLiteImageRequestAspectRatio.x4_5 => "4:5",
                Gemini31FlashLiteImageRequestAspectRatio.x5_4 => "5:4",
                Gemini31FlashLiteImageRequestAspectRatio.x9_16 => "9:16",
                Gemini31FlashLiteImageRequestAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Gemini31FlashLiteImageRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Gemini31FlashLiteImageRequestAspectRatio.x16_9,
                "1:1" => Gemini31FlashLiteImageRequestAspectRatio.x1_1,
                "21:9" => Gemini31FlashLiteImageRequestAspectRatio.x21_9,
                "2:3" => Gemini31FlashLiteImageRequestAspectRatio.x2_3,
                "3:2" => Gemini31FlashLiteImageRequestAspectRatio.x3_2,
                "3:4" => Gemini31FlashLiteImageRequestAspectRatio.x3_4,
                "4:3" => Gemini31FlashLiteImageRequestAspectRatio.x4_3,
                "4:5" => Gemini31FlashLiteImageRequestAspectRatio.x4_5,
                "5:4" => Gemini31FlashLiteImageRequestAspectRatio.x5_4,
                "9:16" => Gemini31FlashLiteImageRequestAspectRatio.x9_16,
                "auto" => Gemini31FlashLiteImageRequestAspectRatio.Auto,
                _ => null,
            };
        }
    }
}