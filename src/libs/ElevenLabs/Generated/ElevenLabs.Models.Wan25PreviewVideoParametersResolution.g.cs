
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum Wan25PreviewVideoParametersResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x480p,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Wan25PreviewVideoParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Wan25PreviewVideoParametersResolution value)
        {
            return value switch
            {
                Wan25PreviewVideoParametersResolution.x1080p => "1080p",
                Wan25PreviewVideoParametersResolution.x480p => "480p",
                Wan25PreviewVideoParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Wan25PreviewVideoParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => Wan25PreviewVideoParametersResolution.x1080p,
                "480p" => Wan25PreviewVideoParametersResolution.x480p,
                "720p" => Wan25PreviewVideoParametersResolution.x720p,
                _ => null,
            };
        }
    }
}