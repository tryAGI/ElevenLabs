
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleModelTextTransform2
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
    public static class CaptionStyleModelTextTransform2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextTransform2 value)
        {
            return value switch
            {
                CaptionStyleModelTextTransform2.None => "none",
                CaptionStyleModelTextTransform2.Uppercase => "uppercase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextTransform2? ToEnum(string value)
        {
            return value switch
            {
                "none" => CaptionStyleModelTextTransform2.None,
                "uppercase" => CaptionStyleModelTextTransform2.Uppercase,
                _ => null,
            };
        }
    }
}