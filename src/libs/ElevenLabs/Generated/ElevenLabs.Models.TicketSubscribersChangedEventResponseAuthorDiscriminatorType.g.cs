
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketSubscribersChangedEventResponseAuthorDiscriminatorType
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
    public static class TicketSubscribersChangedEventResponseAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketSubscribersChangedEventResponseAuthorDiscriminatorType value)
        {
            return value switch
            {
                TicketSubscribersChangedEventResponseAuthorDiscriminatorType.AiAgent => "ai_agent",
                TicketSubscribersChangedEventResponseAuthorDiscriminatorType.HumanAgent => "human_agent",
                TicketSubscribersChangedEventResponseAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketSubscribersChangedEventResponseAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketSubscribersChangedEventResponseAuthorDiscriminatorType.AiAgent,
                "human_agent" => TicketSubscribersChangedEventResponseAuthorDiscriminatorType.HumanAgent,
                "requester" => TicketSubscribersChangedEventResponseAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}