
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Tracks the link back to the original file in an external source.
    /// </summary>
    public sealed partial class ExternalFileSyncInfo
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
        /// Folder ID in the external system this file was synced from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_parent_entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceParentEntityId { get; set; }

        /// <summary>
        /// Original MIME type in the external system
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceMimeType { get; set; }

        /// <summary>
        /// Last modified time from the external system
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_modified_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime SourceModifiedTime { get; set; }

        /// <summary>
        /// KB folder ID of the sync root, used to query all entities under a sync tree
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_folder_id")]
        public string? RootFolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalFileSyncInfo" /> class.
        /// </summary>
        /// <param name="sourceEntityId">
        /// Entity ID in the external system
        /// </param>
        /// <param name="integrationConnectionId">
        /// Integration connection instance ID
        /// </param>
        /// <param name="sourceParentEntityId">
        /// Folder ID in the external system this file was synced from
        /// </param>
        /// <param name="sourceMimeType">
        /// Original MIME type in the external system
        /// </param>
        /// <param name="sourceModifiedTime">
        /// Last modified time from the external system
        /// </param>
        /// <param name="type">
        /// Provider identifier
        /// </param>
        /// <param name="rootFolderId">
        /// KB folder ID of the sync root, used to query all entities under a sync tree
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalFileSyncInfo(
            string sourceEntityId,
            string integrationConnectionId,
            string sourceParentEntityId,
            string sourceMimeType,
            global::System.DateTime sourceModifiedTime,
            global::ElevenLabs.ExternalSyncType type,
            string? rootFolderId)
        {
            this.Type = type;
            this.SourceEntityId = sourceEntityId ?? throw new global::System.ArgumentNullException(nameof(sourceEntityId));
            this.IntegrationConnectionId = integrationConnectionId ?? throw new global::System.ArgumentNullException(nameof(integrationConnectionId));
            this.SourceParentEntityId = sourceParentEntityId ?? throw new global::System.ArgumentNullException(nameof(sourceParentEntityId));
            this.SourceMimeType = sourceMimeType ?? throw new global::System.ArgumentNullException(nameof(sourceMimeType));
            this.SourceModifiedTime = sourceModifiedTime;
            this.RootFolderId = rootFolderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalFileSyncInfo" /> class.
        /// </summary>
        public ExternalFileSyncInfo()
        {
        }

    }
}