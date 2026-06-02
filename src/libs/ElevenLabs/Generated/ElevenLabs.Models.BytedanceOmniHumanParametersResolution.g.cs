
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1080p
    /// </summary>
    public enum BytedanceOmniHumanParametersResolution
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
    public static class BytedanceOmniHumanParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceOmniHumanParametersResolution value)
        {
            return value switch
            {
                BytedanceOmniHumanParametersResolution.x1080p => "1080p",
                BytedanceOmniHumanParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceOmniHumanParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => BytedanceOmniHumanParametersResolution.x1080p,
                "720p" => BytedanceOmniHumanParametersResolution.x720p,
                _ => null,
            };
        }
    }
}