
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleWordAnimationModelEnterType
    {
        /// <summary>
        /// 
        /// </summary>
        Fade,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Pop,
        /// <summary>
        /// 
        /// </summary>
        Scale,
        /// <summary>
        /// 
        /// </summary>
        SlideDown,
        /// <summary>
        /// 
        /// </summary>
        SlideUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleWordAnimationModelEnterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleWordAnimationModelEnterType value)
        {
            return value switch
            {
                CaptionStyleWordAnimationModelEnterType.Fade => "fade",
                CaptionStyleWordAnimationModelEnterType.None => "none",
                CaptionStyleWordAnimationModelEnterType.Pop => "pop",
                CaptionStyleWordAnimationModelEnterType.Scale => "scale",
                CaptionStyleWordAnimationModelEnterType.SlideDown => "slide_down",
                CaptionStyleWordAnimationModelEnterType.SlideUp => "slide_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleWordAnimationModelEnterType? ToEnum(string value)
        {
            return value switch
            {
                "fade" => CaptionStyleWordAnimationModelEnterType.Fade,
                "none" => CaptionStyleWordAnimationModelEnterType.None,
                "pop" => CaptionStyleWordAnimationModelEnterType.Pop,
                "scale" => CaptionStyleWordAnimationModelEnterType.Scale,
                "slide_down" => CaptionStyleWordAnimationModelEnterType.SlideDown,
                "slide_up" => CaptionStyleWordAnimationModelEnterType.SlideUp,
                _ => null,
            };
        }
    }
}