
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
        /// 
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PhoneCallJsonConverter))]
        public global::ElevenLabs.PhoneCall? PhoneCall { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMetadataCommonModel" /> class.
        /// </summary>
        /// <param name="startTimeUnixSecs"></param>
        /// <param name="acceptedTimeUnixSecs"></param>
        /// <param name="callDurationSecs"></param>
        /// <param name="cost"></param>
        /// <param name="deletionSettings"></param>
        /// <param name="feedback"></param>
        /// <param name="authorizationMethod"></param>
        /// <param name="charging"></param>
        /// <param name="phoneCall"></param>
        /// <param name="batchCall"></param>
        /// <param name="terminationReason"></param>
        /// <param name="error"></param>
        /// <param name="mainLanguage"></param>
        /// <param name="ragUsage"></param>
        /// <param name="textOnly">
        /// Default Value: false
        /// </param>
        /// <param name="featuresUsage"></param>
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
            global::ElevenLabs.PhoneCall? phoneCall,
            global::ElevenLabs.ConversationHistoryBatchCallModel? batchCall,
            string? terminationReason,
            global::ElevenLabs.ConversationHistoryErrorCommonModel? error,
            string? mainLanguage,
            global::ElevenLabs.ConversationHistoryRagUsageCommonModel? ragUsage,
            bool? textOnly,
            global::ElevenLabs.FeaturesUsageCommonModel? featuresUsage)
        {
            this.StartTimeUnixSecs = startTimeUnixSecs;
            this.CallDurationSecs = callDurationSecs;
            this.AcceptedTimeUnixSecs = acceptedTimeUnixSecs;
            this.Cost = cost;
            this.DeletionSettings = deletionSettings;
            this.Feedback = feedback;
            this.AuthorizationMethod = authorizationMethod;
            this.Charging = charging;
            this.PhoneCall = phoneCall;
            this.BatchCall = batchCall;
            this.TerminationReason = terminationReason;
            this.Error = error;
            this.MainLanguage = mainLanguage;
            this.RagUsage = ragUsage;
            this.TextOnly = textOnly;
            this.FeaturesUsage = featuresUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMetadataCommonModel" /> class.
        /// </summary>
        public ConversationHistoryMetadataCommonModel()
        {
        }
    }
}