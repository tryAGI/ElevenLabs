
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 2K
    /// </summary>
    public enum BytedanceSeedream5LiteParametersResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x2k,
        /// <summary>
        /// 
        /// </summary>
        x3k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BytedanceSeedream5LiteParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedream5LiteParametersResolution value)
        {
            return value switch
            {
                BytedanceSeedream5LiteParametersResolution.x2k => "2K",
                BytedanceSeedream5LiteParametersResolution.x3k => "3K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedream5LiteParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "2K" => BytedanceSeedream5LiteParametersResolution.x2k,
                "3K" => BytedanceSeedream5LiteParametersResolution.x3k,
                _ => null,
            };
        }
    }
}