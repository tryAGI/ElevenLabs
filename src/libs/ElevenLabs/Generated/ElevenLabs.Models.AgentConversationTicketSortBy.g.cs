
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentConversationTicketSortBy
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConversationTicketSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConversationTicketSortBy value)
        {
            return value switch
            {
                AgentConversationTicketSortBy.CreatedAt => "created_at",
                AgentConversationTicketSortBy.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConversationTicketSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => AgentConversationTicketSortBy.CreatedAt,
                "priority" => AgentConversationTicketSortBy.Priority,
                _ => null,
            };
        }
    }
}