
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentConversationTicketPriority
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
    public static class AgentConversationTicketPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConversationTicketPriority value)
        {
            return value switch
            {
                AgentConversationTicketPriority.High => "high",
                AgentConversationTicketPriority.Low => "low",
                AgentConversationTicketPriority.Medium => "medium",
                AgentConversationTicketPriority.Urgent => "urgent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConversationTicketPriority? ToEnum(string value)
        {
            return value switch
            {
                "high" => AgentConversationTicketPriority.High,
                "low" => AgentConversationTicketPriority.Low,
                "medium" => AgentConversationTicketPriority.Medium,
                "urgent" => AgentConversationTicketPriority.Urgent,
                _ => null,
            };
        }
    }
}