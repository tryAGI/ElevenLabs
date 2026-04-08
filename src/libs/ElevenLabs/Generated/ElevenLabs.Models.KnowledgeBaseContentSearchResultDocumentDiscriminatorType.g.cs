
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeBaseContentSearchResultDocumentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Folder,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseContentSearchResultDocumentDiscriminatorType value)
        {
            return value switch
            {
                KnowledgeBaseContentSearchResultDocumentDiscriminatorType.File => "file",
                KnowledgeBaseContentSearchResultDocumentDiscriminatorType.Folder => "folder",
                KnowledgeBaseContentSearchResultDocumentDiscriminatorType.Text => "text",
                KnowledgeBaseContentSearchResultDocumentDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseContentSearchResultDocumentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => KnowledgeBaseContentSearchResultDocumentDiscriminatorType.File,
                "folder" => KnowledgeBaseContentSearchResultDocumentDiscriminatorType.Folder,
                "text" => KnowledgeBaseContentSearchResultDocumentDiscriminatorType.Text,
                "url" => KnowledgeBaseContentSearchResultDocumentDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}