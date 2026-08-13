
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// In-flight/last refresh state for an externally-synced KB file.
    /// </summary>
    public sealed partial class FileRefreshStatus
    {
        /// <summary>
        /// Default Value: queued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CrawlStatusJsonConverter))]
        public global::ElevenLabs.CrawlStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enqueued_at")]
        public int? EnqueuedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("last_synced_at")]
        public int? LastSyncedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileRefreshStatus" /> class.
        /// </summary>
        /// <param name="status">
        /// Default Value: queued
        /// </param>
        /// <param name="enqueuedAt"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="lastSyncedAt"></param>
        /// <param name="errorMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileRefreshStatus(
            global::ElevenLabs.CrawlStatus? status,
            int? enqueuedAt,
            int? startedAt,
            int? completedAt,
            int? lastSyncedAt,
            string? errorMessage)
        {
            this.Status = status;
            this.EnqueuedAt = enqueuedAt;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.LastSyncedAt = lastSyncedAt;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileRefreshStatus" /> class.
        /// </summary>
        public FileRefreshStatus()
        {
        }

    }
}