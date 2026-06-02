
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum BytedanceSeedance2ParametersResolution
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
    public static class BytedanceSeedance2ParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedance2ParametersResolution value)
        {
            return value switch
            {
                BytedanceSeedance2ParametersResolution.x1080p => "1080p",
                BytedanceSeedance2ParametersResolution.x480p => "480p",
                BytedanceSeedance2ParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedance2ParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => BytedanceSeedance2ParametersResolution.x1080p,
                "480p" => BytedanceSeedance2ParametersResolution.x480p,
                "720p" => BytedanceSeedance2ParametersResolution.x720p,
                _ => null,
            };
        }
    }
}