
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The quality of the output image.<br/>
    /// Default Value: medium
    /// </summary>
    public enum GPTImage2RequestQuality
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
    public static class GPTImage2RequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage2RequestQuality value)
        {
            return value switch
            {
                GPTImage2RequestQuality.High => "high",
                GPTImage2RequestQuality.Low => "low",
                GPTImage2RequestQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage2RequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => GPTImage2RequestQuality.High,
                "low" => GPTImage2RequestQuality.Low,
                "medium" => GPTImage2RequestQuality.Medium,
                _ => null,
            };
        }
    }
}