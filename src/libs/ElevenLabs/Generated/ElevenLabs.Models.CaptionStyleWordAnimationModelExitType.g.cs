
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleWordAnimationModelExitType
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
    public static class CaptionStyleWordAnimationModelExitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleWordAnimationModelExitType value)
        {
            return value switch
            {
                CaptionStyleWordAnimationModelExitType.Fade => "fade",
                CaptionStyleWordAnimationModelExitType.None => "none",
                CaptionStyleWordAnimationModelExitType.Pop => "pop",
                CaptionStyleWordAnimationModelExitType.Scale => "scale",
                CaptionStyleWordAnimationModelExitType.SlideDown => "slide_down",
                CaptionStyleWordAnimationModelExitType.SlideUp => "slide_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleWordAnimationModelExitType? ToEnum(string value)
        {
            return value switch
            {
                "fade" => CaptionStyleWordAnimationModelExitType.Fade,
                "none" => CaptionStyleWordAnimationModelExitType.None,
                "pop" => CaptionStyleWordAnimationModelExitType.Pop,
                "scale" => CaptionStyleWordAnimationModelExitType.Scale,
                "slide_down" => CaptionStyleWordAnimationModelExitType.SlideDown,
                "slide_up" => CaptionStyleWordAnimationModelExitType.SlideUp,
                _ => null,
            };
        }
    }
}