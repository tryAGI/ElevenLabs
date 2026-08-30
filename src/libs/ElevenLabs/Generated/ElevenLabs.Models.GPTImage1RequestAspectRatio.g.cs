
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The aspect ratio of the output image.<br/>
    /// Default Value: 1:1
    /// </summary>
    public enum GPTImage1RequestAspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x1_1,
        /// <summary>
        ///
        /// </summary>
        x2_3,
        /// <summary>
        ///
        /// </summary>
        x3_2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPTImage1RequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage1RequestAspectRatio value)
        {
            return value switch
            {
                GPTImage1RequestAspectRatio.x1_1 => "1:1",
                GPTImage1RequestAspectRatio.x2_3 => "2:3",
                GPTImage1RequestAspectRatio.x3_2 => "3:2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage1RequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "1:1" => GPTImage1RequestAspectRatio.x1_1,
                "2:3" => GPTImage1RequestAspectRatio.x2_3,
                "3:2" => GPTImage1RequestAspectRatio.x3_2,
                _ => null,
            };
        }
    }
}