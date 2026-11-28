
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketPriorityChangedEventResponseAuthorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AiAgent,
        /// <summary>
        ///
        /// </summary>
        HumanAgent,
        /// <summary>
        ///
        /// </summary>
        Requester,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TicketPriorityChangedEventResponseAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketPriorityChangedEventResponseAuthorDiscriminatorType value)
        {
            return value switch
            {
                TicketPriorityChangedEventResponseAuthorDiscriminatorType.AiAgent => "ai_agent",
                TicketPriorityChangedEventResponseAuthorDiscriminatorType.HumanAgent => "human_agent",
                TicketPriorityChangedEventResponseAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketPriorityChangedEventResponseAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketPriorityChangedEventResponseAuthorDiscriminatorType.AiAgent,
                "human_agent" => TicketPriorityChangedEventResponseAuthorDiscriminatorType.HumanAgent,
                "requester" => TicketPriorityChangedEventResponseAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}