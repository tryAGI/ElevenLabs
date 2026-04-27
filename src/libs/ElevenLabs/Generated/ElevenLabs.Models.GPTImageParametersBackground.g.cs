
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum GPTImageParametersBackground
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
    public static class GPTImageParametersBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImageParametersBackground value)
        {
            return value switch
            {
                GPTImageParametersBackground.Auto => "auto",
                GPTImageParametersBackground.Opaque => "opaque",
                GPTImageParametersBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImageParametersBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GPTImageParametersBackground.Auto,
                "opaque" => GPTImageParametersBackground.Opaque,
                "transparent" => GPTImageParametersBackground.Transparent,
                _ => null,
            };
        }
    }
}