
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RAGIndexOverviewEmbeddingModelResponseModel
    {
        /// <summary>
        /// Default Value: e5_mistral_7b_instruct
        /// </summary>
        /// <default>global::ElevenLabs.EmbeddingModelEnum.E5Mistral7bInstruct</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.EmbeddingModelEnum Model { get; set; } = global::ElevenLabs.EmbeddingModelEnum.E5Mistral7bInstruct;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UsedBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexOverviewEmbeddingModelResponseModel" /> class.
        /// </summary>
        /// <param name="model">
        /// Default Value: e5_mistral_7b_instruct
        /// </param>
        /// <param name="usedBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RAGIndexOverviewEmbeddingModelResponseModel(
            global::ElevenLabs.EmbeddingModelEnum model,
            long usedBytes)
        {
            this.Model = model;
            this.UsedBytes = usedBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexOverviewEmbeddingModelResponseModel" /> class.
        /// </summary>
        public RAGIndexOverviewEmbeddingModelResponseModel()
        {
        }

    }
}