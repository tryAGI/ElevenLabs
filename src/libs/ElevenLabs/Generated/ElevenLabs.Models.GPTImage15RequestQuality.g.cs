
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The quality of the output image.<br/>
    /// Default Value: medium
    /// </summary>
    public enum GPTImage15RequestQuality
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
    public static class GPTImage15RequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage15RequestQuality value)
        {
            return value switch
            {
                GPTImage15RequestQuality.High => "high",
                GPTImage15RequestQuality.Low => "low",
                GPTImage15RequestQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage15RequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => GPTImage15RequestQuality.High,
                "low" => GPTImage15RequestQuality.Low,
                "medium" => GPTImage15RequestQuality.Medium,
                _ => null,
            };
        }
    }
}