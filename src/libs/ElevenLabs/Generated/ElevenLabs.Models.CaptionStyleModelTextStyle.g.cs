
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleModelTextStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Italic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleModelTextStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextStyle value)
        {
            return value switch
            {
                CaptionStyleModelTextStyle.Normal => "normal",
                CaptionStyleModelTextStyle.Italic => "italic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextStyle? ToEnum(string value)
        {
            return value switch
            {
                "normal" => CaptionStyleModelTextStyle.Normal,
                "italic" => CaptionStyleModelTextStyle.Italic,
                _ => null,
            };
        }
    }
}