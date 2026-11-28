
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketCreatedEventResponseAuthorDiscriminatorType
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
    public static class TicketCreatedEventResponseAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketCreatedEventResponseAuthorDiscriminatorType value)
        {
            return value switch
            {
                TicketCreatedEventResponseAuthorDiscriminatorType.AiAgent => "ai_agent",
                TicketCreatedEventResponseAuthorDiscriminatorType.HumanAgent => "human_agent",
                TicketCreatedEventResponseAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketCreatedEventResponseAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketCreatedEventResponseAuthorDiscriminatorType.AiAgent,
                "human_agent" => TicketCreatedEventResponseAuthorDiscriminatorType.HumanAgent,
                "requester" => TicketCreatedEventResponseAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}