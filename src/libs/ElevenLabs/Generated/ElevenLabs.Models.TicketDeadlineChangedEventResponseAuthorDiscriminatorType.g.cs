
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketDeadlineChangedEventResponseAuthorDiscriminatorType
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
    public static class TicketDeadlineChangedEventResponseAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketDeadlineChangedEventResponseAuthorDiscriminatorType value)
        {
            return value switch
            {
                TicketDeadlineChangedEventResponseAuthorDiscriminatorType.AiAgent => "ai_agent",
                TicketDeadlineChangedEventResponseAuthorDiscriminatorType.HumanAgent => "human_agent",
                TicketDeadlineChangedEventResponseAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketDeadlineChangedEventResponseAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketDeadlineChangedEventResponseAuthorDiscriminatorType.AiAgent,
                "human_agent" => TicketDeadlineChangedEventResponseAuthorDiscriminatorType.HumanAgent,
                "requester" => TicketDeadlineChangedEventResponseAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}