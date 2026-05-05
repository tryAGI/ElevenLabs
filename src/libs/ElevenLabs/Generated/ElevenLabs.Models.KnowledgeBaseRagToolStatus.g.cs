
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum KnowledgeBaseRagToolStatus
    {
        /// <summary>
        /// 
        /// </summary>
        NoDocuments,
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
    public static class KnowledgeBaseRagToolStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseRagToolStatus value)
        {
            return value switch
            {
                KnowledgeBaseRagToolStatus.NoDocuments => "no_documents",
                KnowledgeBaseRagToolStatus.NoResults => "no_results",
                KnowledgeBaseRagToolStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseRagToolStatus? ToEnum(string value)
        {
            return value switch
            {
                "no_documents" => KnowledgeBaseRagToolStatus.NoDocuments,
                "no_results" => KnowledgeBaseRagToolStatus.NoResults,
                "success" => KnowledgeBaseRagToolStatus.Success,
                _ => null,
            };
        }
    }
}