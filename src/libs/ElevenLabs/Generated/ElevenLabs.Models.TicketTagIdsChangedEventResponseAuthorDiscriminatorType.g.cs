
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketTagIdsChangedEventResponseAuthorDiscriminatorType
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
    public static class TicketTagIdsChangedEventResponseAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketTagIdsChangedEventResponseAuthorDiscriminatorType value)
        {
            return value switch
            {
                TicketTagIdsChangedEventResponseAuthorDiscriminatorType.AiAgent => "ai_agent",
                TicketTagIdsChangedEventResponseAuthorDiscriminatorType.HumanAgent => "human_agent",
                TicketTagIdsChangedEventResponseAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketTagIdsChangedEventResponseAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketTagIdsChangedEventResponseAuthorDiscriminatorType.AiAgent,
                "human_agent" => TicketTagIdsChangedEventResponseAuthorDiscriminatorType.HumanAgent,
                "requester" => TicketTagIdsChangedEventResponseAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}