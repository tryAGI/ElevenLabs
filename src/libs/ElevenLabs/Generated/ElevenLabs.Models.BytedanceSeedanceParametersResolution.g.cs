
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum BytedanceSeedanceParametersResolution
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
    public static class BytedanceSeedanceParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedanceParametersResolution value)
        {
            return value switch
            {
                BytedanceSeedanceParametersResolution.x1080p => "1080p",
                BytedanceSeedanceParametersResolution.x480p => "480p",
                BytedanceSeedanceParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedanceParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => BytedanceSeedanceParametersResolution.x1080p,
                "480p" => BytedanceSeedanceParametersResolution.x480p,
                "720p" => BytedanceSeedanceParametersResolution.x720p,
                _ => null,
            };
        }
    }
}