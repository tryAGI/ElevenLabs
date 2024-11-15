
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKnowledgeBaseReponseModel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseReponseModelTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.GetKnowledgeBaseReponseModelType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extracted_inner_html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExtractedInnerHtml { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseReponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="extractedInnerHtml"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetKnowledgeBaseReponseModel(
            string id,
            global::ElevenLabs.GetKnowledgeBaseReponseModelType type,
            string extractedInnerHtml)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.ExtractedInnerHtml = extractedInnerHtml ?? throw new global::System.ArgumentNullException(nameof(extractedInnerHtml));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseReponseModel" /> class.
        /// </summary>
        public GetKnowledgeBaseReponseModel()
        {
        }
    }
}