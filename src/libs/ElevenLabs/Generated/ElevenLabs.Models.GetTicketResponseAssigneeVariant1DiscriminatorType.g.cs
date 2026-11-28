
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTicketResponseAssigneeVariant1DiscriminatorType
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
    public static class GetTicketResponseAssigneeVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTicketResponseAssigneeVariant1DiscriminatorType value)
        {
            return value switch
            {
                GetTicketResponseAssigneeVariant1DiscriminatorType.AiAgent => "ai_agent",
                GetTicketResponseAssigneeVariant1DiscriminatorType.HumanAgent => "human_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTicketResponseAssigneeVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => GetTicketResponseAssigneeVariant1DiscriminatorType.AiAgent,
                "human_agent" => GetTicketResponseAssigneeVariant1DiscriminatorType.HumanAgent,
                _ => null,
            };
        }
    }
}