
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 2K
    /// </summary>
    public enum BytedanceSeedream45ParametersResolution
    {
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
    public static class BytedanceSeedream45ParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedream45ParametersResolution value)
        {
            return value switch
            {
                BytedanceSeedream45ParametersResolution.x2k => "2K",
                BytedanceSeedream45ParametersResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedream45ParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "2K" => BytedanceSeedream45ParametersResolution.x2k,
                "4K" => BytedanceSeedream45ParametersResolution.x4k,
                _ => null,
            };
        }
    }
}