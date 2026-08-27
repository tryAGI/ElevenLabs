
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentConversationTicketSource
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Manual,
        /// <summary>
        ///
        /// </summary>
        Qa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConversationTicketSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConversationTicketSource value)
        {
            return value switch
            {
                AgentConversationTicketSource.Agent => "agent",
                AgentConversationTicketSource.Manual => "manual",
                AgentConversationTicketSource.Qa => "qa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConversationTicketSource? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AgentConversationTicketSource.Agent,
                "manual" => AgentConversationTicketSource.Manual,
                "qa" => AgentConversationTicketSource.Qa,
                _ => null,
            };
        }
    }
}