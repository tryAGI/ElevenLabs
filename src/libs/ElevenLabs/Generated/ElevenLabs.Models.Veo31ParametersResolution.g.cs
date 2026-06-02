
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum Veo31ParametersResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
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
    public static class Veo31ParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Veo31ParametersResolution value)
        {
            return value switch
            {
                Veo31ParametersResolution.x1080p => "1080p",
                Veo31ParametersResolution.x4k => "4K",
                Veo31ParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Veo31ParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => Veo31ParametersResolution.x1080p,
                "4K" => Veo31ParametersResolution.x4k,
                "720p" => Veo31ParametersResolution.x720p,
                _ => null,
            };
        }
    }
}