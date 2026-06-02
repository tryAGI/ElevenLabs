
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1080p
    /// </summary>
    public enum Kling3ProParametersResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x4k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Kling3ProParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Kling3ProParametersResolution value)
        {
            return value switch
            {
                Kling3ProParametersResolution.x1080p => "1080p",
                Kling3ProParametersResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Kling3ProParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => Kling3ProParametersResolution.x1080p,
                "4K" => Kling3ProParametersResolution.x4k,
                _ => null,
            };
        }
    }
}