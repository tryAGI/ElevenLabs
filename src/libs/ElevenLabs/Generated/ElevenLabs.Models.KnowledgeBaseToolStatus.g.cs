
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum KnowledgeBaseToolStatus
    {
        /// <summary>
        /// 
        /// </summary>
        NoMatchingDocuments,
        /// <summary>
        /// 
        /// </summary>
        NoResults,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseToolStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseToolStatus value)
        {
            return value switch
            {
                KnowledgeBaseToolStatus.NoMatchingDocuments => "no_matching_documents",
                KnowledgeBaseToolStatus.NoResults => "no_results",
                KnowledgeBaseToolStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseToolStatus? ToEnum(string value)
        {
            return value switch
            {
                "no_matching_documents" => KnowledgeBaseToolStatus.NoMatchingDocuments,
                "no_results" => KnowledgeBaseToolStatus.NoResults,
                "success" => KnowledgeBaseToolStatus.Success,
                _ => null,
            };
        }
    }
}