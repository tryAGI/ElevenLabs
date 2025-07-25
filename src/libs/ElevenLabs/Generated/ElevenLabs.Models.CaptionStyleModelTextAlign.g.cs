
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleModelTextAlign
    {
        /// <summary>
        /// 
        /// </summary>
        Start,
        /// <summary>
        /// 
        /// </summary>
        Center,
        /// <summary>
        /// 
        /// </summary>
        End,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleModelTextAlignExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextAlign value)
        {
            return value switch
            {
                CaptionStyleModelTextAlign.Start => "start",
                CaptionStyleModelTextAlign.Center => "center",
                CaptionStyleModelTextAlign.End => "end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextAlign? ToEnum(string value)
        {
            return value switch
            {
                "start" => CaptionStyleModelTextAlign.Start,
                "center" => CaptionStyleModelTextAlign.Center,
                "end" => CaptionStyleModelTextAlign.End,
                _ => null,
            };
        }
    }
}