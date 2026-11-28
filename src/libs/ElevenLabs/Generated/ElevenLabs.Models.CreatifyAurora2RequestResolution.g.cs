
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output video.<br/>
    /// Default Value: 720p
    /// </summary>
    public enum CreatifyAurora2RequestResolution
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
        x480p,
        /// <summary>
        ///
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatifyAurora2RequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatifyAurora2RequestResolution value)
        {
            return value switch
            {
                CreatifyAurora2RequestResolution.x1080p => "1080p",
                CreatifyAurora2RequestResolution.x2k => "2K",
                CreatifyAurora2RequestResolution.x480p => "480p",
                CreatifyAurora2RequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatifyAurora2RequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => CreatifyAurora2RequestResolution.x1080p,
                "2K" => CreatifyAurora2RequestResolution.x2k,
                "480p" => CreatifyAurora2RequestResolution.x480p,
                "720p" => CreatifyAurora2RequestResolution.x720p,
                _ => null,
            };
        }
    }
}