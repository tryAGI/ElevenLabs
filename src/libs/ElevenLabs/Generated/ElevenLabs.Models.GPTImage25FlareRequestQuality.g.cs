
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The quality of the output image.<br/>
    /// Default Value: high
    /// </summary>
    public enum GPTImage25FlareRequestQuality
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
        Max,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPTImage25FlareRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage25FlareRequestQuality value)
        {
            return value switch
            {
                GPTImage25FlareRequestQuality.High => "high",
                GPTImage25FlareRequestQuality.Low => "low",
                GPTImage25FlareRequestQuality.Max => "max",
                GPTImage25FlareRequestQuality.Medium => "medium",
                GPTImage25FlareRequestQuality.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage25FlareRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => GPTImage25FlareRequestQuality.High,
                "low" => GPTImage25FlareRequestQuality.Low,
                "max" => GPTImage25FlareRequestQuality.Max,
                "medium" => GPTImage25FlareRequestQuality.Medium,
                "xhigh" => GPTImage25FlareRequestQuality.Xhigh,
                _ => null,
            };
        }
    }
}