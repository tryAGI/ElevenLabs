
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RAGDocumentIndexResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.EmbeddingModelEnum Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RAGIndexStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.RAGIndexStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ProgressPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_model_index_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.RAGDocumentIndexUsage DocumentModelIndexUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGDocumentIndexResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="status"></param>
        /// <param name="progressPercentage"></param>
        /// <param name="documentModelIndexUsage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RAGDocumentIndexResponseModel(
            string id,
            global::ElevenLabs.EmbeddingModelEnum model,
            global::ElevenLabs.RAGIndexStatus status,
            double progressPercentage,
            global::ElevenLabs.RAGDocumentIndexUsage documentModelIndexUsage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model;
            this.Status = status;
            this.ProgressPercentage = progressPercentage;
            this.DocumentModelIndexUsage = documentModelIndexUsage ?? throw new global::System.ArgumentNullException(nameof(documentModelIndexUsage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGDocumentIndexResponseModel" /> class.
        /// </summary>
        public RAGDocumentIndexResponseModel()
        {
        }
    }
}