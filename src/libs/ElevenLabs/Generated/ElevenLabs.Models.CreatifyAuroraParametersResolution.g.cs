
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum CreatifyAuroraParametersResolution
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
    public static class CreatifyAuroraParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatifyAuroraParametersResolution value)
        {
            return value switch
            {
                CreatifyAuroraParametersResolution.x480p => "480p",
                CreatifyAuroraParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatifyAuroraParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => CreatifyAuroraParametersResolution.x480p,
                "720p" => CreatifyAuroraParametersResolution.x720p,
                _ => null,
            };
        }
    }
}