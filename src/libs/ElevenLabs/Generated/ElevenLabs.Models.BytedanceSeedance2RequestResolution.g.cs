
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output video.<br/>
    /// Default Value: 720p
    /// </summary>
    public enum BytedanceSeedance2RequestResolution
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
        x4k,
        /// <summary>
        ///
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BytedanceSeedance2RequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedance2RequestResolution value)
        {
            return value switch
            {
                BytedanceSeedance2RequestResolution.x1080p => "1080p",
                BytedanceSeedance2RequestResolution.x480p => "480p",
                BytedanceSeedance2RequestResolution.x4k => "4k",
                BytedanceSeedance2RequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedance2RequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => BytedanceSeedance2RequestResolution.x1080p,
                "480p" => BytedanceSeedance2RequestResolution.x480p,
                "4k" => BytedanceSeedance2RequestResolution.x4k,
                "720p" => BytedanceSeedance2RequestResolution.x720p,
                _ => null,
            };
        }
    }
}