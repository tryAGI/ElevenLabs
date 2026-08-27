
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output video.<br/>
    /// Default Value: 720p
    /// </summary>
    public enum CreatifyAuroraRequestResolution
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
    public static class CreatifyAuroraRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatifyAuroraRequestResolution value)
        {
            return value switch
            {
                CreatifyAuroraRequestResolution.x480p => "480p",
                CreatifyAuroraRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatifyAuroraRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => CreatifyAuroraRequestResolution.x480p,
                "720p" => CreatifyAuroraRequestResolution.x720p,
                _ => null,
            };
        }
    }
}