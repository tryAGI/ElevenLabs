
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentKnowledgeBaseRagListingEntryResponseModel
    {
        /// <summary>
        /// ID of the document or folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the document or folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the entry is a folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_folder")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFolder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagListingEntryResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the document or folder.
        /// </param>
        /// <param name="name">
        /// Name of the document or folder.
        /// </param>
        /// <param name="isFolder">
        /// Whether the entry is a folder.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentKnowledgeBaseRagListingEntryResponseModel(
            string id,
            string name,
            bool isFolder)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsFolder = isFolder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagListingEntryResponseModel" /> class.
        /// </summary>
        public AgentKnowledgeBaseRagListingEntryResponseModel()
        {
        }

    }
}