
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output video.<br/>
    /// Default Value: 720p
    /// </summary>
    public enum Veo31FastRequestResolution
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
    public static class Veo31FastRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Veo31FastRequestResolution value)
        {
            return value switch
            {
                Veo31FastRequestResolution.x1080p => "1080p",
                Veo31FastRequestResolution.x4k => "4K",
                Veo31FastRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Veo31FastRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => Veo31FastRequestResolution.x1080p,
                "4K" => Veo31FastRequestResolution.x4k,
                "720p" => Veo31FastRequestResolution.x720p,
                _ => null,
            };
        }
    }
}