
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorTypeJsonConverter))]
        public global::ElevenLabs.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminator(
            global::ElevenLabs.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminator" /> class.
        /// </summary>
        public UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminator()
        {
        }
    }
}