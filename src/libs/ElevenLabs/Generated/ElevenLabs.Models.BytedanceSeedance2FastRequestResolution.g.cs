
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output video.<br/>
    /// Default Value: 720p
    /// </summary>
    public enum BytedanceSeedance2FastRequestResolution
    {
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
    public static class BytedanceSeedance2FastRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedance2FastRequestResolution value)
        {
            return value switch
            {
                BytedanceSeedance2FastRequestResolution.x480p => "480p",
                BytedanceSeedance2FastRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedance2FastRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => BytedanceSeedance2FastRequestResolution.x480p,
                "720p" => BytedanceSeedance2FastRequestResolution.x720p,
                _ => null,
            };
        }
    }
}