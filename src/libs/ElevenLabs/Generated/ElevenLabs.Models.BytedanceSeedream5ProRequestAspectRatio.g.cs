
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The aspect ratio of the output image. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
    /// Default Value: 16:9
    /// </summary>
    public enum BytedanceSeedream5ProRequestAspectRatio
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
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BytedanceSeedream5ProRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedream5ProRequestAspectRatio value)
        {
            return value switch
            {
                BytedanceSeedream5ProRequestAspectRatio.x16_9 => "16:9",
                BytedanceSeedream5ProRequestAspectRatio.x1_1 => "1:1",
                BytedanceSeedream5ProRequestAspectRatio.x3_4 => "3:4",
                BytedanceSeedream5ProRequestAspectRatio.x4_3 => "4:3",
                BytedanceSeedream5ProRequestAspectRatio.x9_16 => "9:16",
                BytedanceSeedream5ProRequestAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedream5ProRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => BytedanceSeedream5ProRequestAspectRatio.x16_9,
                "1:1" => BytedanceSeedream5ProRequestAspectRatio.x1_1,
                "3:4" => BytedanceSeedream5ProRequestAspectRatio.x3_4,
                "4:3" => BytedanceSeedream5ProRequestAspectRatio.x4_3,
                "9:16" => BytedanceSeedream5ProRequestAspectRatio.x9_16,
                "auto" => BytedanceSeedream5ProRequestAspectRatio.Auto,
                _ => null,
            };
        }
    }
}