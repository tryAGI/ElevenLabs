
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KbExternalSyncJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ExternalSyncProviderJsonConverter))]
        public global::ElevenLabs.ExternalSyncProvider Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FolderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationConnectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggered_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ExternalSyncJobTriggerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ExternalSyncJobTrigger TriggeredBy { get; set; }

        /// <summary>
        /// Default Value: queued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CrawlStatusJsonConverter))]
        public global::ElevenLabs.CrawlStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_type")]
        public global::ElevenLabs.ExternalSyncJobType? SyncType { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items_identified")]
        public int? ItemsIdentified { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items_processed")]
        public int? ItemsProcessed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public int? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public int? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KbExternalSyncJob" /> class.
        /// </summary>
        /// <param name="folderId"></param>
        /// <param name="integrationConnectionId"></param>
        /// <param name="triggeredBy"></param>
        /// <param name="updatedAt"></param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Default Value: queued
        /// </param>
        /// <param name="syncType"></param>
        /// <param name="itemsIdentified">
        /// Default Value: 0
        /// </param>
        /// <param name="itemsProcessed">
        /// Default Value: 0
        /// </param>
        /// <param name="errorMessage"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KbExternalSyncJob(
            string folderId,
            string integrationConnectionId,
            global::ElevenLabs.ExternalSyncJobTrigger triggeredBy,
            int updatedAt,
            string id,
            int createdAt,
            global::ElevenLabs.ExternalSyncProvider type,
            global::ElevenLabs.CrawlStatus? status,
            global::ElevenLabs.ExternalSyncJobType? syncType,
            int? itemsIdentified,
            int? itemsProcessed,
            string? errorMessage,
            int? startedAt,
            int? completedAt)
        {
            this.Type = type;
            this.FolderId = folderId ?? throw new global::System.ArgumentNullException(nameof(folderId));
            this.IntegrationConnectionId = integrationConnectionId ?? throw new global::System.ArgumentNullException(nameof(integrationConnectionId));
            this.TriggeredBy = triggeredBy;
            this.Status = status;
            this.SyncType = syncType;
            this.ItemsIdentified = itemsIdentified;
            this.ItemsProcessed = itemsProcessed;
            this.ErrorMessage = errorMessage;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.UpdatedAt = updatedAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KbExternalSyncJob" /> class.
        /// </summary>
        public KbExternalSyncJob()
        {
        }

    }
}