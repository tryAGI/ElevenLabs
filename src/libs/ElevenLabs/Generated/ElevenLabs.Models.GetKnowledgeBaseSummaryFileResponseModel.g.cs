
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKnowledgeBaseSummaryFileResponseModel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.KnowledgeBaseDocumentMetadataResponseModel Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_usages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.DocumentUsageModeEnum> SupportedUsages { get; set; }

        /// <summary>
        /// Example: {"access_source":"creator","creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </summary>
        /// <example>{"access_source":"creator","creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ResourceAccessInfo AccessInfo { get; set; }

        /// <summary>
        /// The ID of the parent folder, or null if the document is at the root level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_parent_id")]
        public string? FolderParentId { get; set; }

        /// <summary>
        /// The folder path segments leading to this entity, from root to parent folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_path")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel>? FolderPath { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed in the future, use the separate endpoint to get dependent agents instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependent_agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem> DependentAgents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"file"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "file";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_sync_info")]
        public global::ElevenLabs.ExternalFileSyncInfo? ExternalSyncInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_sync_info")]
        public global::ElevenLabs.AutoSyncInfo? AutoSyncInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_status")]
        public global::ElevenLabs.FileRefreshStatus? RefreshStatus { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_frozen")]
        public bool? IsFrozen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseSummaryFileResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="supportedUsages"></param>
        /// <param name="accessInfo">
        /// Example: {"access_source":"creator","creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </param>
        /// <param name="dependentAgents">
        /// This field is deprecated and will be removed in the future, use the separate endpoint to get dependent agents instead.
        /// </param>
        /// <param name="folderParentId">
        /// The ID of the parent folder, or null if the document is at the root level.
        /// </param>
        /// <param name="folderPath">
        /// The folder path segments leading to this entity, from root to parent folder.
        /// </param>
        /// <param name="externalSyncInfo"></param>
        /// <param name="autoSyncInfo"></param>
        /// <param name="refreshStatus"></param>
        /// <param name="isFrozen">
        /// Default Value: false
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKnowledgeBaseSummaryFileResponseModel(
            string id,
            string name,
            global::ElevenLabs.KnowledgeBaseDocumentMetadataResponseModel metadata,
            global::System.Collections.Generic.IList<global::ElevenLabs.DocumentUsageModeEnum> supportedUsages,
            global::ElevenLabs.ResourceAccessInfo accessInfo,
            global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem> dependentAgents,
            string? folderParentId,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel>? folderPath,
            global::ElevenLabs.ExternalFileSyncInfo? externalSyncInfo,
            global::ElevenLabs.AutoSyncInfo? autoSyncInfo,
            global::ElevenLabs.FileRefreshStatus? refreshStatus,
            bool? isFrozen,
            string type = "file")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.SupportedUsages = supportedUsages ?? throw new global::System.ArgumentNullException(nameof(supportedUsages));
            this.AccessInfo = accessInfo ?? throw new global::System.ArgumentNullException(nameof(accessInfo));
            this.FolderParentId = folderParentId;
            this.FolderPath = folderPath;
            this.DependentAgents = dependentAgents ?? throw new global::System.ArgumentNullException(nameof(dependentAgents));
            this.Type = type;
            this.ExternalSyncInfo = externalSyncInfo;
            this.AutoSyncInfo = autoSyncInfo;
            this.RefreshStatus = refreshStatus;
            this.IsFrozen = isFrozen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseSummaryFileResponseModel" /> class.
        /// </summary>
        public GetKnowledgeBaseSummaryFileResponseModel()
        {
        }

    }
}