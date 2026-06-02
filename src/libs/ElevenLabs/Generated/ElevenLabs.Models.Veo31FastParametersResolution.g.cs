
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum Veo31FastParametersResolution
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
    public static class Veo31FastParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Veo31FastParametersResolution value)
        {
            return value switch
            {
                Veo31FastParametersResolution.x1080p => "1080p",
                Veo31FastParametersResolution.x4k => "4K",
                Veo31FastParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Veo31FastParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => Veo31FastParametersResolution.x1080p,
                "4K" => Veo31FastParametersResolution.x4k,
                "720p" => Veo31FastParametersResolution.x720p,
                _ => null,
            };
        }
    }
}