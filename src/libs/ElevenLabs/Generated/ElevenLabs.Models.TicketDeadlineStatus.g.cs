
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketDeadlineStatus
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
    public static class TicketDeadlineStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketDeadlineStatus value)
        {
            return value switch
            {
                TicketDeadlineStatus.OnTrack => "on_track",
                TicketDeadlineStatus.Overdue => "overdue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketDeadlineStatus? ToEnum(string value)
        {
            return value switch
            {
                "on_track" => TicketDeadlineStatus.OnTrack,
                "overdue" => TicketDeadlineStatus.Overdue,
                _ => null,
            };
        }
    }
}