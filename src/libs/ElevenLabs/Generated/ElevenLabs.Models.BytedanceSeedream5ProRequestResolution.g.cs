
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output image.<br/>
    /// Default Value: 2K
    /// </summary>
    public enum BytedanceSeedream5ProRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BytedanceSeedream5ProRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedream5ProRequestResolution value)
        {
            return value switch
            {
                BytedanceSeedream5ProRequestResolution.x1k => "1K",
                BytedanceSeedream5ProRequestResolution.x2k => "2K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedream5ProRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => BytedanceSeedream5ProRequestResolution.x1k,
                "2K" => BytedanceSeedream5ProRequestResolution.x2k,
                _ => null,
            };
        }
    }
}