
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyBulkDeleteKnowledgeBaseDocumentsV1ConvaiKnowledgeBaseBulkDeletePost
    {
        /// <summary>
        /// The ids of documents or folders from the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DocumentIds { get; set; }

        /// <summary>
        /// If set to true, documents or folders will be deleted regardless of whether they are used by any agents and will be removed from the dependent agents. For non-empty folders, this will also delete all child documents and folders.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyBulkDeleteKnowledgeBaseDocumentsV1ConvaiKnowledgeBaseBulkDeletePost" /> class.
        /// </summary>
        /// <param name="documentIds">
        /// The ids of documents or folders from the knowledge base.
        /// </param>
        /// <param name="force">
        /// If set to true, documents or folders will be deleted regardless of whether they are used by any agents and will be removed from the dependent agents. For non-empty folders, this will also delete all child documents and folders.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyBulkDeleteKnowledgeBaseDocumentsV1ConvaiKnowledgeBaseBulkDeletePost(
            global::System.Collections.Generic.IList<string> documentIds,
            bool? force)
        {
            this.DocumentIds = documentIds ?? throw new global::System.ArgumentNullException(nameof(documentIds));
            this.Force = force;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyBulkDeleteKnowledgeBaseDocumentsV1ConvaiKnowledgeBaseBulkDeletePost" /> class.
        /// </summary>
        public BodyBulkDeleteKnowledgeBaseDocumentsV1ConvaiKnowledgeBaseBulkDeletePost()
        {
        }

    }
}