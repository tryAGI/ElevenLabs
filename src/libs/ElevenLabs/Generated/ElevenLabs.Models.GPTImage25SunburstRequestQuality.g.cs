
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The quality of the output image.<br/>
    /// Default Value: high
    /// </summary>
    public enum GPTImage25SunburstRequestQuality
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
    public static class GPTImage25SunburstRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage25SunburstRequestQuality value)
        {
            return value switch
            {
                GPTImage25SunburstRequestQuality.High => "high",
                GPTImage25SunburstRequestQuality.Low => "low",
                GPTImage25SunburstRequestQuality.Max => "max",
                GPTImage25SunburstRequestQuality.Medium => "medium",
                GPTImage25SunburstRequestQuality.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage25SunburstRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => GPTImage25SunburstRequestQuality.High,
                "low" => GPTImage25SunburstRequestQuality.Low,
                "max" => GPTImage25SunburstRequestQuality.Max,
                "medium" => GPTImage25SunburstRequestQuality.Medium,
                "xhigh" => GPTImage25SunburstRequestQuality.Xhigh,
                _ => null,
            };
        }
    }
}