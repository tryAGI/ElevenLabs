
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The background of the output image. With `auto`, the model picks the background that suits the image.<br/>
    /// Default Value: auto
    /// </summary>
    public enum GPTImage1RequestBackground
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Opaque,
        /// <summary>
        /// 
        /// </summary>
        Transparent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPTImage1RequestBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage1RequestBackground value)
        {
            return value switch
            {
                GPTImage1RequestBackground.Auto => "auto",
                GPTImage1RequestBackground.Opaque => "opaque",
                GPTImage1RequestBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage1RequestBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GPTImage1RequestBackground.Auto,
                "opaque" => GPTImage1RequestBackground.Opaque,
                "transparent" => GPTImage1RequestBackground.Transparent,
                _ => null,
            };
        }
    }
}