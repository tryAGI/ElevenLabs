
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketDeletedEventResponseAuthorDiscriminatorType
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
    public static class TicketDeletedEventResponseAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketDeletedEventResponseAuthorDiscriminatorType value)
        {
            return value switch
            {
                TicketDeletedEventResponseAuthorDiscriminatorType.AiAgent => "ai_agent",
                TicketDeletedEventResponseAuthorDiscriminatorType.HumanAgent => "human_agent",
                TicketDeletedEventResponseAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketDeletedEventResponseAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketDeletedEventResponseAuthorDiscriminatorType.AiAgent,
                "human_agent" => TicketDeletedEventResponseAuthorDiscriminatorType.HumanAgent,
                "requester" => TicketDeletedEventResponseAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}