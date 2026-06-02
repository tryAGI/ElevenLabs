
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1080p
    /// </summary>
    public enum Flux2ProParametersResolution
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
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux2ProParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux2ProParametersResolution value)
        {
            return value switch
            {
                Flux2ProParametersResolution.x1080p => "1080p",
                Flux2ProParametersResolution.x2k => "2K",
                Flux2ProParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux2ProParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => Flux2ProParametersResolution.x1080p,
                "2K" => Flux2ProParametersResolution.x2k,
                "720p" => Flux2ProParametersResolution.x720p,
                _ => null,
            };
        }
    }
}