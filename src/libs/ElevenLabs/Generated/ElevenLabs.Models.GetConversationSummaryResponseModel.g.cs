
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetConversationSummaryResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GetConversationSummaryResponseModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.GetConversationSummaryResponseModelStatus Status { get; set; }

        /// <summary>
        /// Short generated title for the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_summary_title")]
        public string? CallSummaryTitle { get; set; }

        /// <summary>
        /// Generated natural-language summary of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_summary")]
        public string? TranscriptSummary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_successful")]
        public global::ElevenLabs.EvaluationSuccessResult? CallSuccessful { get; set; }

        /// <summary>
        /// Number of plain chat message turns in the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessageCount { get; set; }

        /// <summary>
        /// The plain chat messages (role and text only). Included only when message_count does not exceed the requested max_messages; otherwise null and messages_omitted is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryMessageModel>? Messages { get; set; }

        /// <summary>
        /// True when the chat messages were omitted because the conversation was too long. Fetch the full transcript for the messages.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages_omitted")]
        public bool? MessagesOmitted { get; set; }

        /// <summary>
        /// Guidance telling the agent how to get the full transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationSummaryResponseModel" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="agentId"></param>
        /// <param name="status"></param>
        /// <param name="messageCount">
        /// Number of plain chat message turns in the conversation.
        /// </param>
        /// <param name="note">
        /// Guidance telling the agent how to get the full transcript.
        /// </param>
        /// <param name="callSummaryTitle">
        /// Short generated title for the conversation.
        /// </param>
        /// <param name="transcriptSummary">
        /// Generated natural-language summary of the call.
        /// </param>
        /// <param name="callSuccessful"></param>
        /// <param name="messages">
        /// The plain chat messages (role and text only). Included only when message_count does not exceed the requested max_messages; otherwise null and messages_omitted is true.
        /// </param>
        /// <param name="messagesOmitted">
        /// True when the chat messages were omitted because the conversation was too long. Fetch the full transcript for the messages.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConversationSummaryResponseModel(
            string conversationId,
            string agentId,
            global::ElevenLabs.GetConversationSummaryResponseModelStatus status,
            int messageCount,
            string note,
            string? callSummaryTitle,
            string? transcriptSummary,
            global::ElevenLabs.EvaluationSuccessResult? callSuccessful,
            global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryMessageModel>? messages,
            bool? messagesOmitted)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Status = status;
            this.CallSummaryTitle = callSummaryTitle;
            this.TranscriptSummary = transcriptSummary;
            this.CallSuccessful = callSuccessful;
            this.MessageCount = messageCount;
            this.Messages = messages;
            this.MessagesOmitted = messagesOmitted;
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationSummaryResponseModel" /> class.
        /// </summary>
        public GetConversationSummaryResponseModel()
        {
        }

    }
}