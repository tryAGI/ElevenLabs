
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentConversationTicketStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Merged,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Resolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConversationTicketStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConversationTicketStatus value)
        {
            return value switch
            {
                AgentConversationTicketStatus.InProgress => "in_progress",
                AgentConversationTicketStatus.Merged => "merged",
                AgentConversationTicketStatus.Open => "open",
                AgentConversationTicketStatus.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConversationTicketStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => AgentConversationTicketStatus.InProgress,
                "merged" => AgentConversationTicketStatus.Merged,
                "open" => AgentConversationTicketStatus.Open,
                "resolved" => AgentConversationTicketStatus.Resolved,
                _ => null,
            };
        }
    }
}