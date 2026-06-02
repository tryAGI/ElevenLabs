
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum RunwayGen4ImageTurboParametersResolution
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
    public static class RunwayGen4ImageTurboParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunwayGen4ImageTurboParametersResolution value)
        {
            return value switch
            {
                RunwayGen4ImageTurboParametersResolution.x1080p => "1080p",
                RunwayGen4ImageTurboParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunwayGen4ImageTurboParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => RunwayGen4ImageTurboParametersResolution.x1080p,
                "720p" => RunwayGen4ImageTurboParametersResolution.x720p,
                _ => null,
            };
        }
    }
}