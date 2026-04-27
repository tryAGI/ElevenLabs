
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum RunwayGen4ImageParametersResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunwayGen4ImageParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunwayGen4ImageParametersResolution value)
        {
            return value switch
            {
                RunwayGen4ImageParametersResolution.x1080p => "1080p",
                RunwayGen4ImageParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunwayGen4ImageParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => RunwayGen4ImageParametersResolution.x1080p,
                "720p" => RunwayGen4ImageParametersResolution.x720p,
                _ => null,
            };
        }
    }
}