
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleModelTextBlendMode2
    {
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Difference,
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleModelTextBlendMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextBlendMode2 value)
        {
            return value switch
            {
                CaptionStyleModelTextBlendMode2.Normal => "normal",
                CaptionStyleModelTextBlendMode2.Difference => "difference",
                CaptionStyleModelTextBlendMode2.Multiply => "multiply",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextBlendMode2? ToEnum(string value)
        {
            return value switch
            {
                "normal" => CaptionStyleModelTextBlendMode2.Normal,
                "difference" => CaptionStyleModelTextBlendMode2.Difference,
                "multiply" => CaptionStyleModelTextBlendMode2.Multiply,
                _ => null,
            };
        }
    }
}