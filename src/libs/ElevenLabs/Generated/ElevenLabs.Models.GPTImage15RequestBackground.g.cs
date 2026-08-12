
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The background of the output image. With `auto`, the model picks the background that suits the image.<br/>
    /// Default Value: auto
    /// </summary>
    public enum GPTImage15RequestBackground
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
    public static class GPTImage15RequestBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage15RequestBackground value)
        {
            return value switch
            {
                GPTImage15RequestBackground.Auto => "auto",
                GPTImage15RequestBackground.Opaque => "opaque",
                GPTImage15RequestBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage15RequestBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GPTImage15RequestBackground.Auto,
                "opaque" => GPTImage15RequestBackground.Opaque,
                "transparent" => GPTImage15RequestBackground.Transparent,
                _ => null,
            };
        }
    }
}