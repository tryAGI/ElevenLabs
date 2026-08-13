
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The aspect ratio of the output video.<br/>
    /// Default Value: 16:9
    /// </summary>
    public enum Veo31RequestAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Veo31RequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Veo31RequestAspectRatio value)
        {
            return value switch
            {
                Veo31RequestAspectRatio.x16_9 => "16:9",
                Veo31RequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Veo31RequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Veo31RequestAspectRatio.x16_9,
                "9:16" => Veo31RequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}