
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CaptionStyleModelTextTransform
    {
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Uppercase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleModelTextTransformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextTransform value)
        {
            return value switch
            {
                CaptionStyleModelTextTransform.None => "none",
                CaptionStyleModelTextTransform.Uppercase => "uppercase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextTransform? ToEnum(string value)
        {
            return value switch
            {
                "none" => CaptionStyleModelTextTransform.None,
                "uppercase" => CaptionStyleModelTextTransform.Uppercase,
                _ => null,
            };
        }
    }
}