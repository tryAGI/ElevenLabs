
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum BytedanceSeedance2FastParametersResolution
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
    public static class BytedanceSeedance2FastParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedance2FastParametersResolution value)
        {
            return value switch
            {
                BytedanceSeedance2FastParametersResolution.x1080p => "1080p",
                BytedanceSeedance2FastParametersResolution.x480p => "480p",
                BytedanceSeedance2FastParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedance2FastParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => BytedanceSeedance2FastParametersResolution.x1080p,
                "480p" => BytedanceSeedance2FastParametersResolution.x480p,
                "720p" => BytedanceSeedance2FastParametersResolution.x720p,
                _ => null,
            };
        }
    }
}