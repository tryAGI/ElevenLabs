
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketStatusChangedEventResponseAuthorDiscriminatorType
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
    public static class TicketStatusChangedEventResponseAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketStatusChangedEventResponseAuthorDiscriminatorType value)
        {
            return value switch
            {
                TicketStatusChangedEventResponseAuthorDiscriminatorType.AiAgent => "ai_agent",
                TicketStatusChangedEventResponseAuthorDiscriminatorType.HumanAgent => "human_agent",
                TicketStatusChangedEventResponseAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketStatusChangedEventResponseAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketStatusChangedEventResponseAuthorDiscriminatorType.AiAgent,
                "human_agent" => TicketStatusChangedEventResponseAuthorDiscriminatorType.HumanAgent,
                "requester" => TicketStatusChangedEventResponseAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}