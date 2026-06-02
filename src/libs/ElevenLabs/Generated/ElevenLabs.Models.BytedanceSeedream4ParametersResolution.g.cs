
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1080p
    /// </summary>
    public enum BytedanceSeedream4ParametersResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x2k,
        /// <summary>
        /// 
        /// </summary>
        x4k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BytedanceSeedream4ParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedream4ParametersResolution value)
        {
            return value switch
            {
                BytedanceSeedream4ParametersResolution.x1080p => "1080p",
                BytedanceSeedream4ParametersResolution.x2k => "2K",
                BytedanceSeedream4ParametersResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedream4ParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => BytedanceSeedream4ParametersResolution.x1080p,
                "2K" => BytedanceSeedream4ParametersResolution.x2k,
                "4K" => BytedanceSeedream4ParametersResolution.x4k,
                _ => null,
            };
        }
    }
}