
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTicketResponseSecondaryAssigneeVariant1DiscriminatorType
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
    public static class GetTicketResponseSecondaryAssigneeVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTicketResponseSecondaryAssigneeVariant1DiscriminatorType value)
        {
            return value switch
            {
                GetTicketResponseSecondaryAssigneeVariant1DiscriminatorType.AiAgent => "ai_agent",
                GetTicketResponseSecondaryAssigneeVariant1DiscriminatorType.HumanAgent => "human_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTicketResponseSecondaryAssigneeVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => GetTicketResponseSecondaryAssigneeVariant1DiscriminatorType.AiAgent,
                "human_agent" => GetTicketResponseSecondaryAssigneeVariant1DiscriminatorType.HumanAgent,
                _ => null,
            };
        }
    }
}