
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketAssigneeChangedEventResponseBeforeVariant1DiscriminatorType
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
    public static class TicketAssigneeChangedEventResponseBeforeVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketAssigneeChangedEventResponseBeforeVariant1DiscriminatorType value)
        {
            return value switch
            {
                TicketAssigneeChangedEventResponseBeforeVariant1DiscriminatorType.AiAgent => "ai_agent",
                TicketAssigneeChangedEventResponseBeforeVariant1DiscriminatorType.HumanAgent => "human_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketAssigneeChangedEventResponseBeforeVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketAssigneeChangedEventResponseBeforeVariant1DiscriminatorType.AiAgent,
                "human_agent" => TicketAssigneeChangedEventResponseBeforeVariant1DiscriminatorType.HumanAgent,
                _ => null,
            };
        }
    }
}