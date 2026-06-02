
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1080p
    /// </summary>
    public enum LTXV2ParametersResolution
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
        x4k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LTXV2ParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LTXV2ParametersResolution value)
        {
            return value switch
            {
                LTXV2ParametersResolution.x1080p => "1080p",
                LTXV2ParametersResolution.x2k => "2K",
                LTXV2ParametersResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LTXV2ParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => LTXV2ParametersResolution.x1080p,
                "2K" => LTXV2ParametersResolution.x2k,
                "4K" => LTXV2ParametersResolution.x4k,
                _ => null,
            };
        }
    }
}