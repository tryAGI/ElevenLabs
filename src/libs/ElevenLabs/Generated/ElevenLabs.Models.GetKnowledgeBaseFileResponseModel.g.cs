
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKnowledgeBaseFileResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.KnowledgeBaseDocumentMetadataResponseModel Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_usages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::ElevenLabs.DocumentUsageModeEnum> SupportedUsages { get; set; } = default!;

        /// <summary>
        /// Example: {"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </summary>
        /// <example>{"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.ResourceAccessInfo AccessInfo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extracted_inner_html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ExtractedInnerHtml { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseFileResponseModelTypeJsonConverter))]
        public global::ElevenLabs.GetKnowledgeBaseFileResponseModelType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseFileResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="supportedUsages"></param>
        /// <param name="accessInfo">
        /// Example: {"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </param>
        /// <param name="extractedInnerHtml"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKnowledgeBaseFileResponseModel(
            string id,
            string name,
            global::ElevenLabs.KnowledgeBaseDocumentMetadataResponseModel metadata,
            global::System.Collections.Generic.IList<global::ElevenLabs.DocumentUsageModeEnum> supportedUsages,
            global::ElevenLabs.ResourceAccessInfo accessInfo,
            string extractedInnerHtml,
            global::ElevenLabs.GetKnowledgeBaseFileResponseModelType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.SupportedUsages = supportedUsages ?? throw new global::System.ArgumentNullException(nameof(supportedUsages));
            this.AccessInfo = accessInfo ?? throw new global::System.ArgumentNullException(nameof(accessInfo));
            this.ExtractedInnerHtml = extractedInnerHtml ?? throw new global::System.ArgumentNullException(nameof(extractedInnerHtml));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseFileResponseModel" /> class.
        /// </summary>
        public GetKnowledgeBaseFileResponseModel()
        {
        }
    }
}