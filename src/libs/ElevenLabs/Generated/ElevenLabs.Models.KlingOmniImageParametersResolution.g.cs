
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1K
    /// </summary>
    public enum KlingOmniImageParametersResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KlingOmniImageParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KlingOmniImageParametersResolution value)
        {
            return value switch
            {
                KlingOmniImageParametersResolution.x1k => "1K",
                KlingOmniImageParametersResolution.x2k => "2K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KlingOmniImageParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => KlingOmniImageParametersResolution.x1k,
                "2K" => KlingOmniImageParametersResolution.x2k,
                _ => null,
            };
        }
    }
}