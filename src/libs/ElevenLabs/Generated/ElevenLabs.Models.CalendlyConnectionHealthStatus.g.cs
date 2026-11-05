
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CalendlyConnectionHealthStatus
    {
        /// <summary>
        ///
        /// </summary>
        Healthy,
        /// <summary>
        ///
        /// </summary>
        NeedsReauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CalendlyConnectionHealthStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CalendlyConnectionHealthStatus value)
        {
            return value switch
            {
                CalendlyConnectionHealthStatus.Healthy => "healthy",
                CalendlyConnectionHealthStatus.NeedsReauth => "needs_reauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CalendlyConnectionHealthStatus? ToEnum(string value)
        {
            return value switch
            {
                "healthy" => CalendlyConnectionHealthStatus.Healthy,
                "needs_reauth" => CalendlyConnectionHealthStatus.NeedsReauth,
                _ => null,
            };
        }
    }
}