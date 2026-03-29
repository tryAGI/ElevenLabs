
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryMetadataCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTimeUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_time_unix_secs")]
        public int? AcceptedTimeUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_duration_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CallDurationSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public int? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletion_settings")]
        public global::ElevenLabs.ConversationDeletionSettings? DeletionSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public global::ElevenLabs.ConversationHistoryFeedbackCommonModel? Feedback { get; set; }

        /// <summary>
        /// Default Value: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodJsonConverter))]
        public global::ElevenLabs.AuthorizationMethod? AuthorizationMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charging")]
        public global::ElevenLabs.ConversationChargingCommonModel? Charging { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_call")]
        public global::ElevenLabs.PhoneCallVariant1? PhoneCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_call")]
        public global::ElevenLabs.ConversationHistoryBatchCallModel? BatchCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_reason")]
        public string? TerminationReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::ElevenLabs.ConversationHistoryErrorCommonModel? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<string>? Warnings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("main_language")]
        public string? MainLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_usage")]
        public global::ElevenLabs.ConversationHistoryRagUsageCommonModel? RagUsage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_only")]
        public bool? TextOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features_usage")]
        public global::ElevenLabs.FeaturesUsageCommonModel? FeaturesUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eleven_assistant")]
        public global::ElevenLabs.ConversationHistoryElevenAssistantCommonModel? ElevenAssistant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initiator_id")]
        public string? InitiatorId { get; set; }

        /// <summary>
        /// Enum representing the possible sources for conversation initiation.<br/>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ConversationInitiationSourceJsonConverter))]
        public global::ElevenLabs.ConversationInitiationSource? ConversationInitiationSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_source_version")]
        public string? ConversationInitiationSourceVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async_metadata")]
        public global::ElevenLabs.AsyncConversationMetadata? AsyncMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp")]
        public global::ElevenLabs.WhatsAppConversationInfo? Whatsapp { get; set; }

        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_created_from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter))]
        public global::ElevenLabs.AgentDefinitionSource? AgentCreatedFrom { get; set; }

        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_last_updated_from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter))]
        public global::ElevenLabs.AgentDefinitionSource? AgentLastUpdatedFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMetadataCommonModel" /> class.
        /// </summary>
        /// <param name="startTimeUnixSecs"></param>
        /// <param name="callDurationSecs"></param>
        /// <param name="acceptedTimeUnixSecs"></param>
        /// <param name="cost"></param>
        /// <param name="deletionSettings"></param>
        /// <param name="feedback"></param>
        /// <param name="authorizationMethod">
        /// Default Value: public
        /// </param>
        /// <param name="charging"></param>
        /// <param name="phoneCall"></param>
        /// <param name="batchCall"></param>
        /// <param name="terminationReason"></param>
        /// <param name="error"></param>
        /// <param name="warnings"></param>
        /// <param name="mainLanguage"></param>
        /// <param name="ragUsage"></param>
        /// <param name="textOnly">
        /// Default Value: false
        /// </param>
        /// <param name="featuresUsage"></param>
        /// <param name="elevenAssistant"></param>
        /// <param name="initiatorId"></param>
        /// <param name="conversationInitiationSource">
        /// Enum representing the possible sources for conversation initiation.<br/>
        /// Default Value: unknown
        /// </param>
        /// <param name="conversationInitiationSourceVersion"></param>
        /// <param name="timezone"></param>
        /// <param name="asyncMetadata"></param>
        /// <param name="whatsapp"></param>
        /// <param name="agentCreatedFrom">
        /// Default Value: unknown
        /// </param>
        /// <param name="agentLastUpdatedFrom">
        /// Default Value: unknown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryMetadataCommonModel(
            int startTimeUnixSecs,
            int callDurationSecs,
            int? acceptedTimeUnixSecs,
            int? cost,
            global::ElevenLabs.ConversationDeletionSettings? deletionSettings,
            global::ElevenLabs.ConversationHistoryFeedbackCommonModel? feedback,
            global::ElevenLabs.AuthorizationMethod? authorizationMethod,
            global::ElevenLabs.ConversationChargingCommonModel? charging,
            global::ElevenLabs.PhoneCallVariant1? phoneCall,
            global::ElevenLabs.ConversationHistoryBatchCallModel? batchCall,
            string? terminationReason,
            global::ElevenLabs.ConversationHistoryErrorCommonModel? error,
            global::System.Collections.Generic.IList<string>? warnings,
            string? mainLanguage,
            global::ElevenLabs.ConversationHistoryRagUsageCommonModel? ragUsage,
            bool? textOnly,
            global::ElevenLabs.FeaturesUsageCommonModel? featuresUsage,
            global::ElevenLabs.ConversationHistoryElevenAssistantCommonModel? elevenAssistant,
            string? initiatorId,
            global::ElevenLabs.ConversationInitiationSource? conversationInitiationSource,
            string? conversationInitiationSourceVersion,
            string? timezone,
            global::ElevenLabs.AsyncConversationMetadata? asyncMetadata,
            global::ElevenLabs.WhatsAppConversationInfo? whatsapp,
            global::ElevenLabs.AgentDefinitionSource? agentCreatedFrom,
            global::ElevenLabs.AgentDefinitionSource? agentLastUpdatedFrom)
        {
            this.StartTimeUnixSecs = startTimeUnixSecs;
            this.AcceptedTimeUnixSecs = acceptedTimeUnixSecs;
            this.CallDurationSecs = callDurationSecs;
            this.Cost = cost;
            this.DeletionSettings = deletionSettings;
            this.Feedback = feedback;
            this.AuthorizationMethod = authorizationMethod;
            this.Charging = charging;
            this.PhoneCall = phoneCall;
            this.BatchCall = batchCall;
            this.TerminationReason = terminationReason;
            this.Error = error;
            this.Warnings = warnings;
            this.MainLanguage = mainLanguage;
            this.RagUsage = ragUsage;
            this.TextOnly = textOnly;
            this.FeaturesUsage = featuresUsage;
            this.ElevenAssistant = elevenAssistant;
            this.InitiatorId = initiatorId;
            this.ConversationInitiationSource = conversationInitiationSource;
            this.ConversationInitiationSourceVersion = conversationInitiationSourceVersion;
            this.Timezone = timezone;
            this.AsyncMetadata = asyncMetadata;
            this.Whatsapp = whatsapp;
            this.AgentCreatedFrom = agentCreatedFrom;
            this.AgentLastUpdatedFrom = agentLastUpdatedFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMetadataCommonModel" /> class.
        /// </summary>
        public ConversationHistoryMetadataCommonModel()
        {
        }
    }
}