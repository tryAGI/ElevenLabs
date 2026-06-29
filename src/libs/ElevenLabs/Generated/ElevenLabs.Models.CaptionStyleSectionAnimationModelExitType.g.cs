
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleSectionAnimationModelExitType
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
    public static class CaptionStyleSectionAnimationModelExitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleSectionAnimationModelExitType value)
        {
            return value switch
            {
                CaptionStyleSectionAnimationModelExitType.Fade => "fade",
                CaptionStyleSectionAnimationModelExitType.None => "none",
                CaptionStyleSectionAnimationModelExitType.Pop => "pop",
                CaptionStyleSectionAnimationModelExitType.Scale => "scale",
                CaptionStyleSectionAnimationModelExitType.ScaleDown => "scale_down",
                CaptionStyleSectionAnimationModelExitType.Slam => "slam",
                CaptionStyleSectionAnimationModelExitType.SlideDown => "slide_down",
                CaptionStyleSectionAnimationModelExitType.SlideIn => "slide_in",
                CaptionStyleSectionAnimationModelExitType.SlideUp => "slide_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleSectionAnimationModelExitType? ToEnum(string value)
        {
            return value switch
            {
                "fade" => CaptionStyleSectionAnimationModelExitType.Fade,
                "none" => CaptionStyleSectionAnimationModelExitType.None,
                "pop" => CaptionStyleSectionAnimationModelExitType.Pop,
                "scale" => CaptionStyleSectionAnimationModelExitType.Scale,
                "scale_down" => CaptionStyleSectionAnimationModelExitType.ScaleDown,
                "slam" => CaptionStyleSectionAnimationModelExitType.Slam,
                "slide_down" => CaptionStyleSectionAnimationModelExitType.SlideDown,
                "slide_in" => CaptionStyleSectionAnimationModelExitType.SlideIn,
                "slide_up" => CaptionStyleSectionAnimationModelExitType.SlideUp,
                _ => null,
            };
        }
    }
}