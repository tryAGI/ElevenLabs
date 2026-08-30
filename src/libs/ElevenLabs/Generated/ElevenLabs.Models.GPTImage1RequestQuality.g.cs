
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The quality of the output image.<br/>
    /// Default Value: medium
    /// </summary>
    public enum GPTImage1RequestQuality
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
    public static class GPTImage1RequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage1RequestQuality value)
        {
            return value switch
            {
                GPTImage1RequestQuality.High => "high",
                GPTImage1RequestQuality.Low => "low",
                GPTImage1RequestQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage1RequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => GPTImage1RequestQuality.High,
                "low" => GPTImage1RequestQuality.Low,
                "medium" => GPTImage1RequestQuality.Medium,
                _ => null,
            };
        }
    }
}