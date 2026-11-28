
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SLAMetric
    {
        /// <summary>
        ///
        /// </summary>
        FirstResponse,
        /// <summary>
        ///
        /// </summary>
        NextResponse,
        /// <summary>
        ///
        /// </summary>
        Resolution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SLAMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SLAMetric value)
        {
            return value switch
            {
                SLAMetric.FirstResponse => "first_response",
                SLAMetric.NextResponse => "next_response",
                SLAMetric.Resolution => "resolution",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SLAMetric? ToEnum(string value)
        {
            return value switch
            {
                "first_response" => SLAMetric.FirstResponse,
                "next_response" => SLAMetric.NextResponse,
                "resolution" => SLAMetric.Resolution,
                _ => null,
            };
        }
    }
}