
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateTicketRequestSecondaryAssigneeVariant1DiscriminatorType
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
    public static class UpdateTicketRequestSecondaryAssigneeVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTicketRequestSecondaryAssigneeVariant1DiscriminatorType value)
        {
            return value switch
            {
                UpdateTicketRequestSecondaryAssigneeVariant1DiscriminatorType.AiAgent => "ai_agent",
                UpdateTicketRequestSecondaryAssigneeVariant1DiscriminatorType.HumanAgent => "human_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTicketRequestSecondaryAssigneeVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => UpdateTicketRequestSecondaryAssigneeVariant1DiscriminatorType.AiAgent,
                "human_agent" => UpdateTicketRequestSecondaryAssigneeVariant1DiscriminatorType.HumanAgent,
                _ => null,
            };
        }
    }
}