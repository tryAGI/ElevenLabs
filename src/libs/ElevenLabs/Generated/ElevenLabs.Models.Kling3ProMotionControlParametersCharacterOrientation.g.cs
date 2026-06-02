
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum Kling3ProMotionControlParametersCharacterOrientation
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Kling3ProMotionControlParametersCharacterOrientationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Kling3ProMotionControlParametersCharacterOrientation value)
        {
            return value switch
            {
                Kling3ProMotionControlParametersCharacterOrientation.Image => "image",
                Kling3ProMotionControlParametersCharacterOrientation.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Kling3ProMotionControlParametersCharacterOrientation? ToEnum(string value)
        {
            return value switch
            {
                "image" => Kling3ProMotionControlParametersCharacterOrientation.Image,
                "video" => Kling3ProMotionControlParametersCharacterOrientation.Video,
                _ => null,
            };
        }
    }
}