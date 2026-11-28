
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketPriority
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
        /// <summary>
        ///
        /// </summary>
        Urgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TicketPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketPriority value)
        {
            return value switch
            {
                TicketPriority.High => "high",
                TicketPriority.Low => "low",
                TicketPriority.Medium => "medium",
                TicketPriority.Urgent => "urgent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketPriority? ToEnum(string value)
        {
            return value switch
            {
                "high" => TicketPriority.High,
                "low" => TicketPriority.Low,
                "medium" => TicketPriority.Medium,
                "urgent" => TicketPriority.Urgent,
                _ => null,
            };
        }
    }
}