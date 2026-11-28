
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketAssigneeChangedEventResponseAuthorDiscriminatorType
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
    public static class TicketAssigneeChangedEventResponseAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketAssigneeChangedEventResponseAuthorDiscriminatorType value)
        {
            return value switch
            {
                TicketAssigneeChangedEventResponseAuthorDiscriminatorType.AiAgent => "ai_agent",
                TicketAssigneeChangedEventResponseAuthorDiscriminatorType.HumanAgent => "human_agent",
                TicketAssigneeChangedEventResponseAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketAssigneeChangedEventResponseAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketAssigneeChangedEventResponseAuthorDiscriminatorType.AiAgent,
                "human_agent" => TicketAssigneeChangedEventResponseAuthorDiscriminatorType.HumanAgent,
                "requester" => TicketAssigneeChangedEventResponseAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}