
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketSLAStatus
    {
        /// <summary>
        ///
        /// </summary>
        OnTrack,
        /// <summary>
        ///
        /// </summary>
        Overdue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TicketSLAStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketSLAStatus value)
        {
            return value switch
            {
                TicketSLAStatus.OnTrack => "on_track",
                TicketSLAStatus.Overdue => "overdue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketSLAStatus? ToEnum(string value)
        {
            return value switch
            {
                "on_track" => TicketSLAStatus.OnTrack,
                "overdue" => TicketSLAStatus.Overdue,
                _ => null,
            };
        }
    }
}