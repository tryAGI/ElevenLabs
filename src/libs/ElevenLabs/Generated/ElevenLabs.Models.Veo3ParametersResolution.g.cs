
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum Veo3ParametersResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Veo3ParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Veo3ParametersResolution value)
        {
            return value switch
            {
                Veo3ParametersResolution.x1080p => "1080p",
                Veo3ParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Veo3ParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => Veo3ParametersResolution.x1080p,
                "720p" => Veo3ParametersResolution.x720p,
                _ => null,
            };
        }
    }
}