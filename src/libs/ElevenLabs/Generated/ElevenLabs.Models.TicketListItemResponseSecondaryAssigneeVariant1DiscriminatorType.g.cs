
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketListItemResponseSecondaryAssigneeVariant1DiscriminatorType
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
    public static class TicketListItemResponseSecondaryAssigneeVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketListItemResponseSecondaryAssigneeVariant1DiscriminatorType value)
        {
            return value switch
            {
                TicketListItemResponseSecondaryAssigneeVariant1DiscriminatorType.AiAgent => "ai_agent",
                TicketListItemResponseSecondaryAssigneeVariant1DiscriminatorType.HumanAgent => "human_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketListItemResponseSecondaryAssigneeVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => TicketListItemResponseSecondaryAssigneeVariant1DiscriminatorType.AiAgent,
                "human_agent" => TicketListItemResponseSecondaryAssigneeVariant1DiscriminatorType.HumanAgent,
                _ => null,
            };
        }
    }
}