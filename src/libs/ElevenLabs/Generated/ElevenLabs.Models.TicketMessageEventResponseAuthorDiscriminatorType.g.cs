
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketMessageEventResponseAuthorDiscriminatorType
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
    public static class TicketMessageEventResponseAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketMessageEventResponseAuthorDiscriminatorType value)
        {
            return value switch
            {
                TicketMessageEventResponseAuthorDiscriminatorType.AiAgent => "ai_agent",
                TicketMessageEventResponseAuthorDiscriminatorType.HumanAgent => "human_agent",
                TicketMessageEventResponseAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketMessageEventResponseAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketMessageEventResponseAuthorDiscriminatorType.AiAgent,
                "human_agent" => TicketMessageEventResponseAuthorDiscriminatorType.HumanAgent,
                "requester" => TicketMessageEventResponseAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}