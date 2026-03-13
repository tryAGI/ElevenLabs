
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationSummaryResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTimeUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_duration_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CallDurationSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationSummaryResponseModelStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_reason")]
        public string? TerminationReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_successful")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.EvaluationSuccessResult CallSuccessful { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_summary")]
        public string? TranscriptSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_summary_title")]
        public string? CallSummaryTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("main_language")]
        public string? MainLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_source")]
        public global::ElevenLabs.ConversationInitiationSource? ConversationInitiationSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_names")]
        public global::System.Collections.Generic.IList<string>? ToolNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        public global::ElevenLabs.ConversationSummaryResponseModelDirection2? Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        public double? Rating { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="branchId"></param>
        /// <param name="versionId"></param>
        /// <param name="agentName"></param>
        /// <param name="conversationId"></param>
        /// <param name="startTimeUnixSecs"></param>
        /// <param name="callDurationSecs"></param>
        /// <param name="messageCount"></param>
        /// <param name="status"></param>
        /// <param name="terminationReason"></param>
        /// <param name="callSuccessful"></param>
        /// <param name="transcriptSummary"></param>
        /// <param name="callSummaryTitle"></param>
        /// <param name="mainLanguage"></param>
        /// <param name="conversationInitiationSource"></param>
        /// <param name="toolNames"></param>
        /// <param name="direction"></param>
        /// <param name="rating"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationSummaryResponseModel(
            string agentId,
            string conversationId,
            int startTimeUnixSecs,
            int callDurationSecs,
            int messageCount,
            global::ElevenLabs.ConversationSummaryResponseModelStatus status,
            global::ElevenLabs.EvaluationSuccessResult callSuccessful,
            string? branchId,
            string? versionId,
            string? agentName,
            string? terminationReason,
            string? transcriptSummary,
            string? callSummaryTitle,
            string? mainLanguage,
            global::ElevenLabs.ConversationInitiationSource? conversationInitiationSource,
            global::System.Collections.Generic.IList<string>? toolNames,
            global::ElevenLabs.ConversationSummaryResponseModelDirection2? direction,
            double? rating)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.StartTimeUnixSecs = startTimeUnixSecs;
            this.CallDurationSecs = callDurationSecs;
            this.MessageCount = messageCount;
            this.Status = status;
            this.CallSuccessful = callSuccessful;
            this.BranchId = branchId;
            this.VersionId = versionId;
            this.AgentName = agentName;
            this.TerminationReason = terminationReason;
            this.TranscriptSummary = transcriptSummary;
            this.CallSummaryTitle = callSummaryTitle;
            this.MainLanguage = mainLanguage;
            this.ConversationInitiationSource = conversationInitiationSource;
            this.ToolNames = toolNames;
            this.Direction = direction;
            this.Rating = rating;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryResponseModel" /> class.
        /// </summary>
        public ConversationSummaryResponseModel()
        {
        }
    }
}