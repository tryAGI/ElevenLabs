
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Metadata for a KB folder that mirrors an external source folder.
    /// </summary>
    public sealed partial class ExternalFolderSyncInfo
    {
        /// <summary>
        /// Provider identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ExternalSyncTypeJsonConverter))]
        public global::ElevenLabs.ExternalSyncType Type { get; set; }

        /// <summary>
        /// Entity ID in the external system
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceEntityId { get; set; }

        /// <summary>
        /// Integration connection instance ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationConnectionId { get; set; }

        /// <summary>
        /// KB folder ID of the sync root. None means this folder is the root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_folder_id")]
        public string? RootFolderId { get; set; }

        /// <summary>
        /// Opaque cursor for incremental sync, interpreted by the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_cursor")]
        public string? SyncCursor { get; set; }

        /// <summary>
        /// Unix timestamp of last completed sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_at")]
        public int? LastSyncAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalFolderSyncInfo" /> class.
        /// </summary>
        /// <param name="sourceEntityId">
        /// Entity ID in the external system
        /// </param>
        /// <param name="integrationConnectionId">
        /// Integration connection instance ID
        /// </param>
        /// <param name="type">
        /// Provider identifier
        /// </param>
        /// <param name="rootFolderId">
        /// KB folder ID of the sync root. None means this folder is the root.
        /// </param>
        /// <param name="syncCursor">
        /// Opaque cursor for incremental sync, interpreted by the provider
        /// </param>
        /// <param name="lastSyncAt">
        /// Unix timestamp of last completed sync
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalFolderSyncInfo(
            string sourceEntityId,
            string integrationConnectionId,
            global::ElevenLabs.ExternalSyncType type,
            string? rootFolderId,
            string? syncCursor,
            int? lastSyncAt)
        {
            this.Type = type;
            this.SourceEntityId = sourceEntityId ?? throw new global::System.ArgumentNullException(nameof(sourceEntityId));
            this.IntegrationConnectionId = integrationConnectionId ?? throw new global::System.ArgumentNullException(nameof(integrationConnectionId));
            this.RootFolderId = rootFolderId;
            this.SyncCursor = syncCursor;
            this.LastSyncAt = lastSyncAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalFolderSyncInfo" /> class.
        /// </summary>
        public ExternalFolderSyncInfo()
        {
        }

    }
}