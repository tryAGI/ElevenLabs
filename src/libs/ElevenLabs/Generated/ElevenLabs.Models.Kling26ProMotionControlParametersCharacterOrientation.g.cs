
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum Kling26ProMotionControlParametersCharacterOrientation
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
    public static class Kling26ProMotionControlParametersCharacterOrientationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Kling26ProMotionControlParametersCharacterOrientation value)
        {
            return value switch
            {
                Kling26ProMotionControlParametersCharacterOrientation.Image => "image",
                Kling26ProMotionControlParametersCharacterOrientation.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Kling26ProMotionControlParametersCharacterOrientation? ToEnum(string value)
        {
            return value switch
            {
                "image" => Kling26ProMotionControlParametersCharacterOrientation.Image,
                "video" => Kling26ProMotionControlParametersCharacterOrientation.Video,
                _ => null,
            };
        }
    }
}