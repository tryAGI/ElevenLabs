
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch
    {
        /// <summary>
        /// A custom, human-readable name for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated content for the document. Only supported for text documents, URL documents with auto-sync disabled, and file documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch" /> class.
        /// </summary>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        /// <param name="content">
        /// Updated content for the document. Only supported for text documents, URL documents with auto-sync disabled, and file documents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch(
            string? name,
            string? content)
        {
            this.Name = name;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch" /> class.
        /// </summary>
        public BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch()
        {
        }

    }
}