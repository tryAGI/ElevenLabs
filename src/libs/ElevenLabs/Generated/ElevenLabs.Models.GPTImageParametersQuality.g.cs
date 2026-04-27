
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: medium
    /// </summary>
    public enum GPTImageParametersQuality
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
    public static class GPTImageParametersQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImageParametersQuality value)
        {
            return value switch
            {
                GPTImageParametersQuality.High => "high",
                GPTImageParametersQuality.Low => "low",
                GPTImageParametersQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImageParametersQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => GPTImageParametersQuality.High,
                "low" => GPTImageParametersQuality.Low,
                "medium" => GPTImageParametersQuality.Medium,
                _ => null,
            };
        }
    }
}