
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_metadata")]
        public global::ElevenLabs.AgentMetadata? AgentMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multivoice_message")]
        public global::ElevenLabs.ConversationHistoryMultivoiceMessageModel? MultivoiceMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_results")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>? ToolResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public global::ElevenLabs.UserFeedback? Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_override")]
        public string? LlmOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_in_call_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimeInCallSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_turn_metrics")]
        public global::ElevenLabs.ConversationTurnMetrics? ConversationTurnMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_retrieval_info")]
        public global::ElevenLabs.RagRetrievalInfo? RagRetrievalInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_usage")]
        public global::ElevenLabs.LLMUsageOutput? LlmUsage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupted")]
        public bool? Interrupted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_message")]
        public string? OriginalMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_medium")]
        public global::ElevenLabs.ChatSourceMedium? SourceMedium { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_input")]
        public global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel? FileInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptResponseModel" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="agentMetadata"></param>
        /// <param name="message"></param>
        /// <param name="multivoiceMessage"></param>
        /// <param name="toolCalls"></param>
        /// <param name="toolResults"></param>
        /// <param name="feedback"></param>
        /// <param name="llmOverride"></param>
        /// <param name="timeInCallSecs"></param>
        /// <param name="conversationTurnMetrics"></param>
        /// <param name="ragRetrievalInfo"></param>
        /// <param name="llmUsage"></param>
        /// <param name="interrupted">
        /// Default Value: false
        /// </param>
        /// <param name="originalMessage"></param>
        /// <param name="sourceMedium"></param>
        /// <param name="fileInput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryTranscriptResponseModel(
            global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole role,
            int timeInCallSecs,
            global::ElevenLabs.AgentMetadata? agentMetadata,
            string? message,
            global::ElevenLabs.ConversationHistoryMultivoiceMessageModel? multivoiceMessage,
            global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>? toolCalls,
            global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>? toolResults,
            global::ElevenLabs.UserFeedback? feedback,
            string? llmOverride,
            global::ElevenLabs.ConversationTurnMetrics? conversationTurnMetrics,
            global::ElevenLabs.RagRetrievalInfo? ragRetrievalInfo,
            global::ElevenLabs.LLMUsageOutput? llmUsage,
            bool? interrupted,
            string? originalMessage,
            global::ElevenLabs.ChatSourceMedium? sourceMedium,
            global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel? fileInput)
        {
            this.Role = role;
            this.TimeInCallSecs = timeInCallSecs;
            this.AgentMetadata = agentMetadata;
            this.Message = message;
            this.MultivoiceMessage = multivoiceMessage;
            this.ToolCalls = toolCalls;
            this.ToolResults = toolResults;
            this.Feedback = feedback;
            this.LlmOverride = llmOverride;
            this.ConversationTurnMetrics = conversationTurnMetrics;
            this.RagRetrievalInfo = ragRetrievalInfo;
            this.LlmUsage = llmUsage;
            this.Interrupted = interrupted;
            this.OriginalMessage = originalMessage;
            this.SourceMedium = sourceMedium;
            this.FileInput = fileInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptResponseModel" /> class.
        /// </summary>
        public ConversationHistoryTranscriptResponseModel()
        {
        }
    }
}