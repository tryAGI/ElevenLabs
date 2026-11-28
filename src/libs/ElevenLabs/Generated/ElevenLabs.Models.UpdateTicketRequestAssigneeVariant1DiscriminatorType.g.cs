
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateTicketRequestAssigneeVariant1DiscriminatorType
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
    public static class UpdateTicketRequestAssigneeVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTicketRequestAssigneeVariant1DiscriminatorType value)
        {
            return value switch
            {
                UpdateTicketRequestAssigneeVariant1DiscriminatorType.AiAgent => "ai_agent",
                UpdateTicketRequestAssigneeVariant1DiscriminatorType.HumanAgent => "human_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTicketRequestAssigneeVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => UpdateTicketRequestAssigneeVariant1DiscriminatorType.AiAgent,
                "human_agent" => UpdateTicketRequestAssigneeVariant1DiscriminatorType.HumanAgent,
                _ => null,
            };
        }
    }
}