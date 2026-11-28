
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketSubjectChangedEventResponseAuthorDiscriminatorType
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
    public static class TicketSubjectChangedEventResponseAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketSubjectChangedEventResponseAuthorDiscriminatorType value)
        {
            return value switch
            {
                TicketSubjectChangedEventResponseAuthorDiscriminatorType.AiAgent => "ai_agent",
                TicketSubjectChangedEventResponseAuthorDiscriminatorType.HumanAgent => "human_agent",
                TicketSubjectChangedEventResponseAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketSubjectChangedEventResponseAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketSubjectChangedEventResponseAuthorDiscriminatorType.AiAgent,
                "human_agent" => TicketSubjectChangedEventResponseAuthorDiscriminatorType.HumanAgent,
                "requester" => TicketSubjectChangedEventResponseAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}