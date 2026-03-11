
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConversationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.GetConversationResponseModelStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// The ID of the agent version used for this conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.ConversationHistoryMetadataCommonModel Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        public global::ElevenLabs.ConversationHistoryAnalysisCommonModel? Analysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_client_data")]
        public global::ElevenLabs.ConversationInitiationClientDataRequestOutput? ConversationInitiationClientData { get; set; }

        /// <summary>
        /// Default Value: production
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ConversationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool HasAudio { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_user_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool HasUserAudio { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_response_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool HasResponseAudio { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptResponseModel> Transcript { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentName"></param>
        /// <param name="status"></param>
        /// <param name="userId"></param>
        /// <param name="branchId"></param>
        /// <param name="versionId">
        /// The ID of the agent version used for this conversation
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="analysis"></param>
        /// <param name="conversationInitiationClientData"></param>
        /// <param name="environment">
        /// Default Value: production
        /// </param>
        /// <param name="conversationId"></param>
        /// <param name="hasAudio"></param>
        /// <param name="hasUserAudio"></param>
        /// <param name="hasResponseAudio"></param>
        /// <param name="transcript"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConversationResponseModel(
            string agentId,
            global::ElevenLabs.GetConversationResponseModelStatus status,
            global::ElevenLabs.ConversationHistoryMetadataCommonModel metadata,
            string conversationId,
            bool hasAudio,
            bool hasUserAudio,
            bool hasResponseAudio,
            global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptResponseModel> transcript,
            string? agentName,
            string? userId,
            string? branchId,
            string? versionId,
            global::ElevenLabs.ConversationHistoryAnalysisCommonModel? analysis,
            global::ElevenLabs.ConversationInitiationClientDataRequestOutput? conversationInitiationClientData,
            string? environment)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Status = status;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.HasAudio = hasAudio;
            this.HasUserAudio = hasUserAudio;
            this.HasResponseAudio = hasResponseAudio;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.AgentName = agentName;
            this.UserId = userId;
            this.BranchId = branchId;
            this.VersionId = versionId;
            this.Analysis = analysis;
            this.ConversationInitiationClientData = conversationInitiationClientData;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationResponseModel" /> class.
        /// </summary>
        public GetConversationResponseModel()
        {
        }
    }
}