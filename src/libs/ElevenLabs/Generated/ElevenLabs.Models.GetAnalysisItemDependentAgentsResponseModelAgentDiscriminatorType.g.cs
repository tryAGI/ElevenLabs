
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorType
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
    public static class GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorType value)
        {
            return value switch
            {
                GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorType.Available => "available",
                GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorType.Available,
                "unknown" => GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}