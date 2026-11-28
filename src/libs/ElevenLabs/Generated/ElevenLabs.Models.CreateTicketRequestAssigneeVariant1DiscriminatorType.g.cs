
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTicketRequestAssigneeVariant1DiscriminatorType
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
    public static class CreateTicketRequestAssigneeVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTicketRequestAssigneeVariant1DiscriminatorType value)
        {
            return value switch
            {
                CreateTicketRequestAssigneeVariant1DiscriminatorType.AiAgent => "ai_agent",
                CreateTicketRequestAssigneeVariant1DiscriminatorType.HumanAgent => "human_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTicketRequestAssigneeVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => CreateTicketRequestAssigneeVariant1DiscriminatorType.AiAgent,
                "human_agent" => CreateTicketRequestAssigneeVariant1DiscriminatorType.HumanAgent,
                _ => null,
            };
        }
    }
}