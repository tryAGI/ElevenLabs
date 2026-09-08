
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CaptionStyleModelTextBlendMode
    {
        /// <summary>
        ///
        /// </summary>
        Difference,
        /// <summary>
        ///
        /// </summary>
        Multiply,
        /// <summary>
        ///
        /// </summary>
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleModelTextBlendModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextBlendMode value)
        {
            return value switch
            {
                CaptionStyleModelTextBlendMode.Difference => "difference",
                CaptionStyleModelTextBlendMode.Multiply => "multiply",
                CaptionStyleModelTextBlendMode.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextBlendMode? ToEnum(string value)
        {
            return value switch
            {
                "difference" => CaptionStyleModelTextBlendMode.Difference,
                "multiply" => CaptionStyleModelTextBlendMode.Multiply,
                "normal" => CaptionStyleModelTextBlendMode.Normal,
                _ => null,
            };
        }
    }
}