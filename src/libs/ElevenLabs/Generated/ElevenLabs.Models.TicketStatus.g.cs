
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketStatus
    {
        /// <summary>
        ///
        /// </summary>
        Open,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Resolved,
        /// <summary>
        ///
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TicketStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketStatus value)
        {
            return value switch
            {
                TicketStatus.Open => "open",
                TicketStatus.Pending => "pending",
                TicketStatus.Resolved => "resolved",
                TicketStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketStatus? ToEnum(string value)
        {
            return value switch
            {
                "open" => TicketStatus.Open,
                "pending" => TicketStatus.Pending,
                "resolved" => TicketStatus.Resolved,
                "waiting" => TicketStatus.Waiting,
                _ => null,
            };
        }
    }
}