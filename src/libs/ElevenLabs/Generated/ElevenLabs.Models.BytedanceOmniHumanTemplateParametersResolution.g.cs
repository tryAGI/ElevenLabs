
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1080p
    /// </summary>
    public enum BytedanceOmniHumanTemplateParametersResolution
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
    public static class BytedanceOmniHumanTemplateParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceOmniHumanTemplateParametersResolution value)
        {
            return value switch
            {
                BytedanceOmniHumanTemplateParametersResolution.x1080p => "1080p",
                BytedanceOmniHumanTemplateParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceOmniHumanTemplateParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => BytedanceOmniHumanTemplateParametersResolution.x1080p,
                "720p" => BytedanceOmniHumanTemplateParametersResolution.x720p,
                _ => null,
            };
        }
    }
}