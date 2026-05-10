
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Paginated workspace audit log response.
    /// </summary>
    public sealed partial class WorkspaceAuditLogsPageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAuditLogEntryResponse> Entries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceAuditLogsPageResponse" /> class.
        /// </summary>
        /// <param name="entries"></param>
        /// <param name="hasMore"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceAuditLogsPageResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAuditLogEntryResponse> entries,
            bool hasMore,
            string? nextCursor)
        {
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceAuditLogsPageResponse" /> class.
        /// </summary>
        public WorkspaceAuditLogsPageResponse()
        {
        }

    }
}