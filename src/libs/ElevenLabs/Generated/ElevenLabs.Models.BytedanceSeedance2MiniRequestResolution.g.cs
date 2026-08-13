
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output video.<br/>
    /// Default Value: 720p
    /// </summary>
    public enum BytedanceSeedance2MiniRequestResolution
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
    public static class BytedanceSeedance2MiniRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedance2MiniRequestResolution value)
        {
            return value switch
            {
                BytedanceSeedance2MiniRequestResolution.x480p => "480p",
                BytedanceSeedance2MiniRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedance2MiniRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => BytedanceSeedance2MiniRequestResolution.x480p,
                "720p" => BytedanceSeedance2MiniRequestResolution.x720p,
                _ => null,
            };
        }
    }
}