
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1K
    /// </summary>
    public enum GPTImage2ParametersResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
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
    public static class GPTImage2ParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage2ParametersResolution value)
        {
            return value switch
            {
                GPTImage2ParametersResolution.x1k => "1K",
                GPTImage2ParametersResolution.x2k => "2K",
                GPTImage2ParametersResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage2ParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => GPTImage2ParametersResolution.x1k,
                "2K" => GPTImage2ParametersResolution.x2k,
                "4K" => GPTImage2ParametersResolution.x4k,
                _ => null,
            };
        }
    }
}