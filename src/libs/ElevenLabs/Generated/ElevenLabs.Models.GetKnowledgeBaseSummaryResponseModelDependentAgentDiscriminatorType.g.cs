
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseSummaryResponseModelDependentAgentDiscriminatorType
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
    public static class GetKnowledgeBaseSummaryResponseModelDependentAgentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseSummaryResponseModelDependentAgentDiscriminatorType value)
        {
            return value switch
            {
                GetKnowledgeBaseSummaryResponseModelDependentAgentDiscriminatorType.Available => "available",
                GetKnowledgeBaseSummaryResponseModelDependentAgentDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseSummaryResponseModelDependentAgentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => GetKnowledgeBaseSummaryResponseModelDependentAgentDiscriminatorType.Available,
                "unknown" => GetKnowledgeBaseSummaryResponseModelDependentAgentDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}