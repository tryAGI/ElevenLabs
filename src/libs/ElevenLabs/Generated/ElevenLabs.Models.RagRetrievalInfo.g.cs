
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RagRetrievalInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.RagChunkMetadata> Chunks { get; set; }

        /// <summary>
        /// Default Value: e5_mistral_7b_instruct
        /// </summary>
        /// <default>global::ElevenLabs.EmbeddingModelEnum.E5Mistral7bInstruct</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.EmbeddingModelEnum EmbeddingModel { get; set; } = global::ElevenLabs.EmbeddingModelEnum.E5Mistral7bInstruct;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RetrievalQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_latency_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RagLatencySecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_chunk_ids")]
        public global::System.Collections.Generic.IList<string>? UsedChunkIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RagRetrievalInfo" /> class.
        /// </summary>
        /// <param name="chunks"></param>
        /// <param name="embeddingModel">
        /// Default Value: e5_mistral_7b_instruct
        /// </param>
        /// <param name="retrievalQuery"></param>
        /// <param name="ragLatencySecs"></param>
        /// <param name="usedChunkIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RagRetrievalInfo(
            global::System.Collections.Generic.IList<global::ElevenLabs.RagChunkMetadata> chunks,
            global::ElevenLabs.EmbeddingModelEnum embeddingModel,
            string retrievalQuery,
            double ragLatencySecs,
            global::System.Collections.Generic.IList<string>? usedChunkIds)
        {
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
            this.EmbeddingModel = embeddingModel;
            this.RetrievalQuery = retrievalQuery ?? throw new global::System.ArgumentNullException(nameof(retrievalQuery));
            this.RagLatencySecs = ragLatencySecs;
            this.UsedChunkIds = usedChunkIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RagRetrievalInfo" /> class.
        /// </summary>
        public RagRetrievalInfo()
        {
        }
    }
}