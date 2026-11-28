
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketSecondaryAssigneeChangedEventResponseAfterVariant1DiscriminatorType
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
    public static class TicketSecondaryAssigneeChangedEventResponseAfterVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketSecondaryAssigneeChangedEventResponseAfterVariant1DiscriminatorType value)
        {
            return value switch
            {
                TicketSecondaryAssigneeChangedEventResponseAfterVariant1DiscriminatorType.AiAgent => "ai_agent",
                TicketSecondaryAssigneeChangedEventResponseAfterVariant1DiscriminatorType.HumanAgent => "human_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketSecondaryAssigneeChangedEventResponseAfterVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketSecondaryAssigneeChangedEventResponseAfterVariant1DiscriminatorType.AiAgent,
                "human_agent" => TicketSecondaryAssigneeChangedEventResponseAfterVariant1DiscriminatorType.HumanAgent,
                _ => null,
            };
        }
    }
}