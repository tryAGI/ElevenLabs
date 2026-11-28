
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketAssigneeChangedEventResponseAfterVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AiAgent,
        /// <summary>
        ///
        /// </summary>
        HumanAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TicketAssigneeChangedEventResponseAfterVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketAssigneeChangedEventResponseAfterVariant1DiscriminatorType value)
        {
            return value switch
            {
                TicketAssigneeChangedEventResponseAfterVariant1DiscriminatorType.AiAgent => "ai_agent",
                TicketAssigneeChangedEventResponseAfterVariant1DiscriminatorType.HumanAgent => "human_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketAssigneeChangedEventResponseAfterVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketAssigneeChangedEventResponseAfterVariant1DiscriminatorType.AiAgent,
                "human_agent" => TicketAssigneeChangedEventResponseAfterVariant1DiscriminatorType.HumanAgent,
                _ => null,
            };
        }
    }
}