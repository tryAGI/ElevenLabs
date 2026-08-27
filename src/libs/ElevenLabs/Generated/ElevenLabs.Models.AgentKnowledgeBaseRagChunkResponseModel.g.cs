
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentKnowledgeBaseRagChunkResponseModel
    {
        /// <summary>
        /// ID of the source knowledge base document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentId { get; set; }

        /// <summary>
        /// Name of the source knowledge base document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentName { get; set; }

        /// <summary>
        /// ID of the retrieved chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChunkId { get; set; }

        /// <summary>
        /// Text content of the retrieved chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Similarity distance when exposed by the retrieval strategy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_distance")]
        public double? VectorDistance { get; set; }

        /// <summary>
        /// Format of the chunk text. Markdown chunks contain raw markdown; HTML chunks contain HTML.<br/>
        /// Default Value: html
        /// </summary>
        /// <default>global::ElevenLabs.ContentFormat.Html</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ContentFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ContentFormat ContentFormat { get; set; } = global::ElevenLabs.ContentFormat.Html;

        /// <summary>
        /// Type of the source knowledge base document.
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
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagChunkResponseModel" /> class.
        /// </summary>
        /// <param name="documentId">
        /// ID of the source knowledge base document.
        /// </param>
        /// <param name="documentName">
        /// Name of the source knowledge base document.
        /// </param>
        /// <param name="chunkId">
        /// ID of the retrieved chunk.
        /// </param>
        /// <param name="text">
        /// Text content of the retrieved chunk.
        /// </param>
        /// <param name="contentFormat">
        /// Format of the chunk text. Markdown chunks contain raw markdown; HTML chunks contain HTML.<br/>
        /// Default Value: html
        /// </param>
        /// <param name="documentType">
        /// Type of the source knowledge base document.
        /// </param>
        /// <param name="vectorDistance">
        /// Similarity distance when exposed by the retrieval strategy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentKnowledgeBaseRagChunkResponseModel(
            string documentId,
            string documentName,
            string chunkId,
            string text,
            global::ElevenLabs.ContentFormat contentFormat,
            global::ElevenLabs.KnowledgeBaseDocumentType documentType,
            double? vectorDistance)
        {
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.DocumentName = documentName ?? throw new global::System.ArgumentNullException(nameof(documentName));
            this.ChunkId = chunkId ?? throw new global::System.ArgumentNullException(nameof(chunkId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.VectorDistance = vectorDistance;
            this.ContentFormat = contentFormat;
            this.DocumentType = documentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagChunkResponseModel" /> class.
        /// </summary>
        public AgentKnowledgeBaseRagChunkResponseModel()
        {
        }

    }
}