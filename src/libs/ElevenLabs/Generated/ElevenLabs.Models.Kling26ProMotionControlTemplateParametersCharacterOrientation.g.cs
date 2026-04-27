
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum Kling26ProMotionControlTemplateParametersCharacterOrientation
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
    public static class Kling26ProMotionControlTemplateParametersCharacterOrientationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Kling26ProMotionControlTemplateParametersCharacterOrientation value)
        {
            return value switch
            {
                Kling26ProMotionControlTemplateParametersCharacterOrientation.Image => "image",
                Kling26ProMotionControlTemplateParametersCharacterOrientation.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Kling26ProMotionControlTemplateParametersCharacterOrientation? ToEnum(string value)
        {
            return value switch
            {
                "image" => Kling26ProMotionControlTemplateParametersCharacterOrientation.Image,
                "video" => Kling26ProMotionControlTemplateParametersCharacterOrientation.Video,
                _ => null,
            };
        }
    }
}