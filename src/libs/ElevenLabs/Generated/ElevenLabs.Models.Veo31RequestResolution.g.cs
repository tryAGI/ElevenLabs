
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output video.<br/>
    /// Default Value: 720p
    /// </summary>
    public enum Veo31RequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x4k,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Veo31RequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Veo31RequestResolution value)
        {
            return value switch
            {
                Veo31RequestResolution.x1080p => "1080p",
                Veo31RequestResolution.x4k => "4K",
                Veo31RequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Veo31RequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => Veo31RequestResolution.x1080p,
                "4K" => Veo31RequestResolution.x4k,
                "720p" => Veo31RequestResolution.x720p,
                _ => null,
            };
        }
    }
}