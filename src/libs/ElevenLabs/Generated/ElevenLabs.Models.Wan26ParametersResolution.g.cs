
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum Wan26ParametersResolution
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
    public static class Wan26ParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Wan26ParametersResolution value)
        {
            return value switch
            {
                Wan26ParametersResolution.x1080p => "1080p",
                Wan26ParametersResolution.x480p => "480p",
                Wan26ParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Wan26ParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => Wan26ParametersResolution.x1080p,
                "480p" => Wan26ParametersResolution.x480p,
                "720p" => Wan26ParametersResolution.x720p,
                _ => null,
            };
        }
    }
}