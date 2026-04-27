
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum Sora2ProParametersResolution
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
    public static class Sora2ProParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Sora2ProParametersResolution value)
        {
            return value switch
            {
                Sora2ProParametersResolution.x1080p => "1080p",
                Sora2ProParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Sora2ProParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => Sora2ProParametersResolution.x1080p,
                "720p" => Sora2ProParametersResolution.x720p,
                _ => null,
            };
        }
    }
}