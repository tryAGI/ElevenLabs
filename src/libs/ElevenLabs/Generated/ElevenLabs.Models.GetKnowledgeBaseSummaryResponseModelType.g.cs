
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseSummaryResponseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKnowledgeBaseSummaryResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseSummaryResponseModelType value)
        {
            return value switch
            {
                GetKnowledgeBaseSummaryResponseModelType.File => "file",
                GetKnowledgeBaseSummaryResponseModelType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseSummaryResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "file" => GetKnowledgeBaseSummaryResponseModelType.File,
                "url" => GetKnowledgeBaseSummaryResponseModelType.Url,
                _ => null,
            };
        }
    }
}