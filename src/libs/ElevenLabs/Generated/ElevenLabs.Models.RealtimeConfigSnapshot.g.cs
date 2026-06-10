
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConfigSnapshot
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seq_no")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SeqNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_in_call_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimeInCallSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_committed_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimeCommittedSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_event_id")]
        public int? SourceEventId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.RealtimeConfigSnapshotParents Parents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.OpenAISessionConfig SessionConfig { get; set; }

        /// <summary>
        /// Safety object that has the information of safety evaluations based on used voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SafetyCommonModelOutput Safety { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed_paths")]
        public global::System.Collections.Generic.IList<string>? ChangedPaths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConfigSnapshot" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workspaceId"></param>
        /// <param name="conversationId"></param>
        /// <param name="seqNo"></param>
        /// <param name="timeInCallSecs"></param>
        /// <param name="timeCommittedSecs"></param>
        /// <param name="parents"></param>
        /// <param name="sessionConfig"></param>
        /// <param name="safety">
        /// Safety object that has the information of safety evaluations based on used voice.
        /// </param>
        /// <param name="sourceEventId"></param>
        /// <param name="changedPaths"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConfigSnapshot(
            string id,
            string workspaceId,
            string conversationId,
            int seqNo,
            int timeInCallSecs,
            int timeCommittedSecs,
            global::ElevenLabs.RealtimeConfigSnapshotParents parents,
            global::ElevenLabs.OpenAISessionConfig sessionConfig,
            global::ElevenLabs.SafetyCommonModelOutput safety,
            int? sourceEventId,
            global::System.Collections.Generic.IList<string>? changedPaths)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.SeqNo = seqNo;
            this.TimeInCallSecs = timeInCallSecs;
            this.TimeCommittedSecs = timeCommittedSecs;
            this.SourceEventId = sourceEventId;
            this.Parents = parents ?? throw new global::System.ArgumentNullException(nameof(parents));
            this.SessionConfig = sessionConfig ?? throw new global::System.ArgumentNullException(nameof(sessionConfig));
            this.Safety = safety ?? throw new global::System.ArgumentNullException(nameof(safety));
            this.ChangedPaths = changedPaths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConfigSnapshot" /> class.
        /// </summary>
        public RealtimeConfigSnapshot()
        {
        }

    }
}