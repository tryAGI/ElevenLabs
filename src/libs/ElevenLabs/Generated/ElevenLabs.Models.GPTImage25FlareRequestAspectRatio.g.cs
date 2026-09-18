
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The aspect ratio of the output image. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
    /// Default Value: 16:9
    /// </summary>
    public enum GPTImage25FlareRequestAspectRatio
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
    public static class GPTImage25FlareRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage25FlareRequestAspectRatio value)
        {
            return value switch
            {
                GPTImage25FlareRequestAspectRatio.x16_9 => "16:9",
                GPTImage25FlareRequestAspectRatio.x1_1 => "1:1",
                GPTImage25FlareRequestAspectRatio.x1_2 => "1:2",
                GPTImage25FlareRequestAspectRatio.x1_3 => "1:3",
                GPTImage25FlareRequestAspectRatio.x21_9 => "21:9",
                GPTImage25FlareRequestAspectRatio.x2_1 => "2:1",
                GPTImage25FlareRequestAspectRatio.x2_3 => "2:3",
                GPTImage25FlareRequestAspectRatio.x3_1 => "3:1",
                GPTImage25FlareRequestAspectRatio.x3_2 => "3:2",
                GPTImage25FlareRequestAspectRatio.x3_4 => "3:4",
                GPTImage25FlareRequestAspectRatio.x4_3 => "4:3",
                GPTImage25FlareRequestAspectRatio.x4_5 => "4:5",
                GPTImage25FlareRequestAspectRatio.x5_4 => "5:4",
                GPTImage25FlareRequestAspectRatio.x9_16 => "9:16",
                GPTImage25FlareRequestAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage25FlareRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => GPTImage25FlareRequestAspectRatio.x16_9,
                "1:1" => GPTImage25FlareRequestAspectRatio.x1_1,
                "1:2" => GPTImage25FlareRequestAspectRatio.x1_2,
                "1:3" => GPTImage25FlareRequestAspectRatio.x1_3,
                "21:9" => GPTImage25FlareRequestAspectRatio.x21_9,
                "2:1" => GPTImage25FlareRequestAspectRatio.x2_1,
                "2:3" => GPTImage25FlareRequestAspectRatio.x2_3,
                "3:1" => GPTImage25FlareRequestAspectRatio.x3_1,
                "3:2" => GPTImage25FlareRequestAspectRatio.x3_2,
                "3:4" => GPTImage25FlareRequestAspectRatio.x3_4,
                "4:3" => GPTImage25FlareRequestAspectRatio.x4_3,
                "4:5" => GPTImage25FlareRequestAspectRatio.x4_5,
                "5:4" => GPTImage25FlareRequestAspectRatio.x5_4,
                "9:16" => GPTImage25FlareRequestAspectRatio.x9_16,
                "auto" => GPTImage25FlareRequestAspectRatio.Auto,
                _ => null,
            };
        }
    }
}