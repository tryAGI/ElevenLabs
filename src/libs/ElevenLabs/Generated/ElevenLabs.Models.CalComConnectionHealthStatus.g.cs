
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CalComConnectionHealthStatus
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
    public static class CalComConnectionHealthStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CalComConnectionHealthStatus value)
        {
            return value switch
            {
                CalComConnectionHealthStatus.Healthy => "healthy",
                CalComConnectionHealthStatus.NeedsReauth => "needs_reauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CalComConnectionHealthStatus? ToEnum(string value)
        {
            return value switch
            {
                "healthy" => CalComConnectionHealthStatus.Healthy,
                "needs_reauth" => CalComConnectionHealthStatus.NeedsReauth,
                _ => null,
            };
        }
    }
}