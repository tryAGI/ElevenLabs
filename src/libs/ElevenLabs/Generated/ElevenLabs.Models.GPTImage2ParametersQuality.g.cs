
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: medium
    /// </summary>
    public enum GPTImage2ParametersQuality
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPTImage2ParametersQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage2ParametersQuality value)
        {
            return value switch
            {
                GPTImage2ParametersQuality.High => "high",
                GPTImage2ParametersQuality.Low => "low",
                GPTImage2ParametersQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage2ParametersQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => GPTImage2ParametersQuality.High,
                "low" => GPTImage2ParametersQuality.Low,
                "medium" => GPTImage2ParametersQuality.Medium,
                _ => null,
            };
        }
    }
}