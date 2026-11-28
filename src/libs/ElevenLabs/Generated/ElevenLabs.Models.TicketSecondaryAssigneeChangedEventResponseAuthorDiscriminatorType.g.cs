
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketSecondaryAssigneeChangedEventResponseAuthorDiscriminatorType
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
    public static class TicketSecondaryAssigneeChangedEventResponseAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketSecondaryAssigneeChangedEventResponseAuthorDiscriminatorType value)
        {
            return value switch
            {
                TicketSecondaryAssigneeChangedEventResponseAuthorDiscriminatorType.AiAgent => "ai_agent",
                TicketSecondaryAssigneeChangedEventResponseAuthorDiscriminatorType.HumanAgent => "human_agent",
                TicketSecondaryAssigneeChangedEventResponseAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketSecondaryAssigneeChangedEventResponseAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketSecondaryAssigneeChangedEventResponseAuthorDiscriminatorType.AiAgent,
                "human_agent" => TicketSecondaryAssigneeChangedEventResponseAuthorDiscriminatorType.HumanAgent,
                "requester" => TicketSecondaryAssigneeChangedEventResponseAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}