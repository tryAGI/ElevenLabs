
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output video.<br/>
    /// Default Value: 720p
    /// </summary>
    public enum BytedanceSeedance25RequestResolution
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
    public static class BytedanceSeedance25RequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedance25RequestResolution value)
        {
            return value switch
            {
                BytedanceSeedance25RequestResolution.x1080p => "1080p",
                BytedanceSeedance25RequestResolution.x480p => "480p",
                BytedanceSeedance25RequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedance25RequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => BytedanceSeedance25RequestResolution.x1080p,
                "480p" => BytedanceSeedance25RequestResolution.x480p,
                "720p" => BytedanceSeedance25RequestResolution.x720p,
                _ => null,
            };
        }
    }
}