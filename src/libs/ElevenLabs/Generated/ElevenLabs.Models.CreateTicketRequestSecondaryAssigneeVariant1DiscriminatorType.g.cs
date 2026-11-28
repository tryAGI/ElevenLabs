
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTicketRequestSecondaryAssigneeVariant1DiscriminatorType
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
    public static class CreateTicketRequestSecondaryAssigneeVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTicketRequestSecondaryAssigneeVariant1DiscriminatorType value)
        {
            return value switch
            {
                CreateTicketRequestSecondaryAssigneeVariant1DiscriminatorType.AiAgent => "ai_agent",
                CreateTicketRequestSecondaryAssigneeVariant1DiscriminatorType.HumanAgent => "human_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTicketRequestSecondaryAssigneeVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => CreateTicketRequestSecondaryAssigneeVariant1DiscriminatorType.AiAgent,
                "human_agent" => CreateTicketRequestSecondaryAssigneeVariant1DiscriminatorType.HumanAgent,
                _ => null,
            };
        }
    }
}