
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentSubagentDependentsResponseModelAgentDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Available,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentSubagentDependentsResponseModelAgentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentSubagentDependentsResponseModelAgentDiscriminatorType value)
        {
            return value switch
            {
                GetAgentSubagentDependentsResponseModelAgentDiscriminatorType.Available => "available",
                GetAgentSubagentDependentsResponseModelAgentDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentSubagentDependentsResponseModelAgentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => GetAgentSubagentDependentsResponseModelAgentDiscriminatorType.Available,
                "unknown" => GetAgentSubagentDependentsResponseModelAgentDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}