
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum RunwayGen4ImageTurboTemplateParametersResolution
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
    public static class RunwayGen4ImageTurboTemplateParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunwayGen4ImageTurboTemplateParametersResolution value)
        {
            return value switch
            {
                RunwayGen4ImageTurboTemplateParametersResolution.x1080p => "1080p",
                RunwayGen4ImageTurboTemplateParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunwayGen4ImageTurboTemplateParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => RunwayGen4ImageTurboTemplateParametersResolution.x1080p,
                "720p" => RunwayGen4ImageTurboTemplateParametersResolution.x720p,
                _ => null,
            };
        }
    }
}