
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The aspect ratio of the output image. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
    /// Default Value: 16:9
    /// </summary>
    public enum GPTImage25SunburstRequestAspectRatio
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
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPTImage25SunburstRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage25SunburstRequestAspectRatio value)
        {
            return value switch
            {
                GPTImage25SunburstRequestAspectRatio.x16_9 => "16:9",
                GPTImage25SunburstRequestAspectRatio.x1_1 => "1:1",
                GPTImage25SunburstRequestAspectRatio.x1_2 => "1:2",
                GPTImage25SunburstRequestAspectRatio.x1_3 => "1:3",
                GPTImage25SunburstRequestAspectRatio.x21_9 => "21:9",
                GPTImage25SunburstRequestAspectRatio.x2_1 => "2:1",
                GPTImage25SunburstRequestAspectRatio.x2_3 => "2:3",
                GPTImage25SunburstRequestAspectRatio.x3_1 => "3:1",
                GPTImage25SunburstRequestAspectRatio.x3_2 => "3:2",
                GPTImage25SunburstRequestAspectRatio.x3_4 => "3:4",
                GPTImage25SunburstRequestAspectRatio.x4_3 => "4:3",
                GPTImage25SunburstRequestAspectRatio.x4_5 => "4:5",
                GPTImage25SunburstRequestAspectRatio.x5_4 => "5:4",
                GPTImage25SunburstRequestAspectRatio.x9_16 => "9:16",
                GPTImage25SunburstRequestAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage25SunburstRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => GPTImage25SunburstRequestAspectRatio.x16_9,
                "1:1" => GPTImage25SunburstRequestAspectRatio.x1_1,
                "1:2" => GPTImage25SunburstRequestAspectRatio.x1_2,
                "1:3" => GPTImage25SunburstRequestAspectRatio.x1_3,
                "21:9" => GPTImage25SunburstRequestAspectRatio.x21_9,
                "2:1" => GPTImage25SunburstRequestAspectRatio.x2_1,
                "2:3" => GPTImage25SunburstRequestAspectRatio.x2_3,
                "3:1" => GPTImage25SunburstRequestAspectRatio.x3_1,
                "3:2" => GPTImage25SunburstRequestAspectRatio.x3_2,
                "3:4" => GPTImage25SunburstRequestAspectRatio.x3_4,
                "4:3" => GPTImage25SunburstRequestAspectRatio.x4_3,
                "4:5" => GPTImage25SunburstRequestAspectRatio.x4_5,
                "5:4" => GPTImage25SunburstRequestAspectRatio.x5_4,
                "9:16" => GPTImage25SunburstRequestAspectRatio.x9_16,
                "auto" => GPTImage25SunburstRequestAspectRatio.Auto,
                _ => null,
            };
        }
    }
}