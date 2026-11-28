
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentKnowledgeBaseRagListingResponseModel
    {
        /// <summary>
        /// Entries the agent would be shown, folders first and then by name. Large folders are cut to the number of entries the agent is shown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagListingEntryResponseModel> Entries { get; set; }

        /// <summary>
        /// Number of entries in the listed folder, including any not returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagListingResponseModel" /> class.
        /// </summary>
        /// <param name="entries">
        /// Entries the agent would be shown, folders first and then by name. Large folders are cut to the number of entries the agent is shown.
        /// </param>
        /// <param name="totalCount">
        /// Number of entries in the listed folder, including any not returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentKnowledgeBaseRagListingResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagListingEntryResponseModel> entries,
            int totalCount)
        {
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagListingResponseModel" /> class.
        /// </summary>
        public AgentKnowledgeBaseRagListingResponseModel()
        {
        }

    }
}