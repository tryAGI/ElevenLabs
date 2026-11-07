
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentKnowledgeBaseRagDocumentResponseModel
    {
        /// <summary>
        /// ID of the knowledge base document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentId { get; set; }

        /// <summary>
        /// Name of the knowledge base document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentName { get; set; }

        /// <summary>
        /// Tracked source URL for URL documents, or null for other document types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Content the agent would read, cut to the maximum documents length. Empty when the document has no extractable content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Whether the content was cut to the maximum documents length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Truncated { get; set; }

        /// <summary>
        /// Format of the document content.<br/>
        /// Default Value: html
        /// </summary>
        /// <default>global::ElevenLabs.ContentFormat.Html</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ContentFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ContentFormat ContentFormat { get; set; } = global::ElevenLabs.ContentFormat.Html;

        /// <summary>
        /// Type of the knowledge base document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.KnowledgeBaseDocumentType DocumentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagDocumentResponseModel" /> class.
        /// </summary>
        /// <param name="documentId">
        /// ID of the knowledge base document.
        /// </param>
        /// <param name="documentName">
        /// Name of the knowledge base document.
        /// </param>
        /// <param name="content">
        /// Content the agent would read, cut to the maximum documents length. Empty when the document has no extractable content.
        /// </param>
        /// <param name="truncated">
        /// Whether the content was cut to the maximum documents length.
        /// </param>
        /// <param name="contentFormat">
        /// Format of the document content.<br/>
        /// Default Value: html
        /// </param>
        /// <param name="documentType">
        /// Type of the knowledge base document.
        /// </param>
        /// <param name="sourceUrl">
        /// Tracked source URL for URL documents, or null for other document types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentKnowledgeBaseRagDocumentResponseModel(
            string documentId,
            string documentName,
            string content,
            bool truncated,
            global::ElevenLabs.ContentFormat contentFormat,
            global::ElevenLabs.KnowledgeBaseDocumentType documentType,
            string? sourceUrl)
        {
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.DocumentName = documentName ?? throw new global::System.ArgumentNullException(nameof(documentName));
            this.SourceUrl = sourceUrl;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Truncated = truncated;
            this.ContentFormat = contentFormat;
            this.DocumentType = documentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagDocumentResponseModel" /> class.
        /// </summary>
        public AgentKnowledgeBaseRagDocumentResponseModel()
        {
        }

    }
}