
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
        [global::System.Text.Json.Serialization.JsonPropertyName("call_success_score")]
        public double? CallSuccessScore { get; set; }

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
        public global::ElevenLabs.TelephonyDirection? Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        public double? Rating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis")]
        public global::ElevenLabs.ConversationSentimentAnalysis? SentimentAnalysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection_results")]
        public object? DataCollectionResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_criteria_results")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EvaluationCriteriaSummaryResult>? EvaluationCriteriaResults { get; set; }

        /// <summary>
        /// Conversation tag ids assigned to this conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_ids")]
        public global::System.Collections.Generic.IList<string>? TagIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="conversationId"></param>
        /// <param name="startTimeUnixSecs"></param>
        /// <param name="callDurationSecs"></param>
        /// <param name="messageCount"></param>
        /// <param name="status"></param>
        /// <param name="callSuccessful"></param>
        /// <param name="branchId"></param>
        /// <param name="versionId"></param>
        /// <param name="agentName"></param>
        /// <param name="terminationReason"></param>
        /// <param name="callSuccessScore"></param>
        /// <param name="transcriptSummary"></param>
        /// <param name="callSummaryTitle"></param>
        /// <param name="mainLanguage"></param>
        /// <param name="conversationInitiationSource"></param>
        /// <param name="toolNames"></param>
        /// <param name="direction"></param>
        /// <param name="rating"></param>
        /// <param name="sentimentAnalysis"></param>
        /// <param name="dataCollectionResults"></param>
        /// <param name="evaluationCriteriaResults"></param>
        /// <param name="tagIds">
        /// Conversation tag ids assigned to this conversation.
        /// </param>
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
            double? callSuccessScore,
            string? transcriptSummary,
            string? callSummaryTitle,
            string? mainLanguage,
            global::ElevenLabs.ConversationInitiationSource? conversationInitiationSource,
            global::System.Collections.Generic.IList<string>? toolNames,
            global::ElevenLabs.TelephonyDirection? direction,
            double? rating,
            global::ElevenLabs.ConversationSentimentAnalysis? sentimentAnalysis,
            object? dataCollectionResults,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EvaluationCriteriaSummaryResult>? evaluationCriteriaResults,
            global::System.Collections.Generic.IList<string>? tagIds)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.BranchId = branchId;
            this.VersionId = versionId;
            this.AgentName = agentName;
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.StartTimeUnixSecs = startTimeUnixSecs;
            this.CallDurationSecs = callDurationSecs;
            this.MessageCount = messageCount;
            this.Status = status;
            this.TerminationReason = terminationReason;
            this.CallSuccessful = callSuccessful;
            this.CallSuccessScore = callSuccessScore;
            this.TranscriptSummary = transcriptSummary;
            this.CallSummaryTitle = callSummaryTitle;
            this.MainLanguage = mainLanguage;
            this.ConversationInitiationSource = conversationInitiationSource;
            this.ToolNames = toolNames;
            this.Direction = direction;
            this.Rating = rating;
            this.SentimentAnalysis = sentimentAnalysis;
            this.DataCollectionResults = dataCollectionResults;
            this.EvaluationCriteriaResults = evaluationCriteriaResults;
            this.TagIds = tagIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryResponseModel" /> class.
        /// </summary>
        public ConversationSummaryResponseModel()
        {
        }

    }
}