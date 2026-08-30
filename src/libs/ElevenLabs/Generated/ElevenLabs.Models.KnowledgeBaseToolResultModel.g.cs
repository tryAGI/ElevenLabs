
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KnowledgeBaseToolResultModel
    {
        /// <summary>
        /// Default Value: knowledge_base_success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        public string? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseToolStatusJsonConverter))]
        public global::ElevenLabs.KnowledgeBaseToolStatus? Status { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_count")]
        public int? ChunkCount { get; set; }

        /// <summary>
        /// Default Value: Referenced knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseToolResultModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: knowledge_base_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="chunkCount">
        /// Default Value: 0
        /// </param>
        /// <param name="message">
        /// Default Value: Referenced knowledge base.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseToolResultModel(
            string? resultType,
            global::ElevenLabs.KnowledgeBaseToolStatus? status,
            int? chunkCount,
            string? message)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.ChunkCount = chunkCount;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseToolResultModel" /> class.
        /// </summary>
        public KnowledgeBaseToolResultModel()
        {
        }

    }
}