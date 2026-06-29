
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleSectionAnimationModelEnterType
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
        ScaleDown,
        /// <summary>
        /// 
        /// </summary>
        Slam,
        /// <summary>
        /// 
        /// </summary>
        SlideDown,
        /// <summary>
        /// 
        /// </summary>
        SlideIn,
        /// <summary>
        /// 
        /// </summary>
        SlideUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleSectionAnimationModelEnterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleSectionAnimationModelEnterType value)
        {
            return value switch
            {
                CaptionStyleSectionAnimationModelEnterType.Fade => "fade",
                CaptionStyleSectionAnimationModelEnterType.None => "none",
                CaptionStyleSectionAnimationModelEnterType.Pop => "pop",
                CaptionStyleSectionAnimationModelEnterType.Scale => "scale",
                CaptionStyleSectionAnimationModelEnterType.ScaleDown => "scale_down",
                CaptionStyleSectionAnimationModelEnterType.Slam => "slam",
                CaptionStyleSectionAnimationModelEnterType.SlideDown => "slide_down",
                CaptionStyleSectionAnimationModelEnterType.SlideIn => "slide_in",
                CaptionStyleSectionAnimationModelEnterType.SlideUp => "slide_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleSectionAnimationModelEnterType? ToEnum(string value)
        {
            return value switch
            {
                "fade" => CaptionStyleSectionAnimationModelEnterType.Fade,
                "none" => CaptionStyleSectionAnimationModelEnterType.None,
                "pop" => CaptionStyleSectionAnimationModelEnterType.Pop,
                "scale" => CaptionStyleSectionAnimationModelEnterType.Scale,
                "scale_down" => CaptionStyleSectionAnimationModelEnterType.ScaleDown,
                "slam" => CaptionStyleSectionAnimationModelEnterType.Slam,
                "slide_down" => CaptionStyleSectionAnimationModelEnterType.SlideDown,
                "slide_in" => CaptionStyleSectionAnimationModelEnterType.SlideIn,
                "slide_up" => CaptionStyleSectionAnimationModelEnterType.SlideUp,
                _ => null,
            };
        }
    }
}