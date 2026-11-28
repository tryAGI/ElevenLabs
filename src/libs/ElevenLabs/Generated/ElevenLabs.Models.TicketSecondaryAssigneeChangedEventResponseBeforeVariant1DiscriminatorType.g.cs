
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketSecondaryAssigneeChangedEventResponseBeforeVariant1DiscriminatorType
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
    public static class TicketSecondaryAssigneeChangedEventResponseBeforeVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketSecondaryAssigneeChangedEventResponseBeforeVariant1DiscriminatorType value)
        {
            return value switch
            {
                TicketSecondaryAssigneeChangedEventResponseBeforeVariant1DiscriminatorType.AiAgent => "ai_agent",
                TicketSecondaryAssigneeChangedEventResponseBeforeVariant1DiscriminatorType.HumanAgent => "human_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketSecondaryAssigneeChangedEventResponseBeforeVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketSecondaryAssigneeChangedEventResponseBeforeVariant1DiscriminatorType.AiAgent,
                "human_agent" => TicketSecondaryAssigneeChangedEventResponseBeforeVariant1DiscriminatorType.HumanAgent,
                _ => null,
            };
        }
    }
}