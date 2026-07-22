
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPlatformSettingsResponseModel
    {
        /// <summary>
        /// Settings for evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation")]
        public global::ElevenLabs.EvaluationSettingsOutput? Evaluation { get; set; }

        /// <summary>
        /// Configuration for the widget<br/>
        /// Example: {"custom_avatar_path":"https://example.com/avatar.png","language_selector":false}
        /// </summary>
        /// <example>{"custom_avatar_path":"https://example.com/avatar.png","language_selector":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget")]
        public global::ElevenLabs.WidgetConfigOutput? Widget { get; set; }

        /// <summary>
        /// Data collection settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisProperty>? DataCollection { get; set; }

        /// <summary>
        /// Scope per data collection item ID. Missing keys default to conversation scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection_scopes")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisScope>? DataCollectionScopes { get; set; }

        /// <summary>
        /// Evaluation + data-collection items attached by reference. None means the agent has not been migrated onto analysis items yet (distinct from an empty, migrated set); reads fall back to the legacy evaluation/data_collection fields in that case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_items")]
        public global::ElevenLabs.AgentAnalysisItemsOutput? AnalysisItems { get; set; }

        /// <summary>
        /// Additional overrides for the agent during conversation initiation<br/>
        /// Example: {"custom_llm_extra_body":true,"enable_conversation_initiation_client_data_from_webhook":true,"enable_starting_workflow_node_id_from_client":true}
        /// </summary>
        /// <example>{"custom_llm_extra_body":true,"enable_conversation_initiation_client_data_from_webhook":true,"enable_starting_workflow_node_id_from_client":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::ElevenLabs.ConversationInitiationClientDataConfigOutput? Overrides { get; set; }

        /// <summary>
        /// Workspace overrides for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_overrides")]
        public global::ElevenLabs.AgentWorkspaceOverridesOutput? WorkspaceOverrides { get; set; }

        /// <summary>
        /// Testing configuration for the agent<br/>
        /// Example: {"attached_tests":[{"environment":"staging","test_id":"test_123","workflow_node_id":"node_abc"},{"test_id":"test_456"}],"referenced_tests_ids":["test_123","test_456"]}
        /// </summary>
        /// <example>{"attached_tests":[{"environment":"staging","test_id":"test_123","workflow_node_id":"node_abc"},{"test_id":"test_456"}],"referenced_tests_ids":["test_123","test_456"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("testing")]
        public global::ElevenLabs.AgentTestingSettings? Testing { get; set; }

        /// <summary>
        /// Whether the agent is archived<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// Guardrails configuration for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        public global::ElevenLabs.GuardrailsV1Output? Guardrails { get; set; }

        /// <summary>
        /// Language for all conversation analysis outputs (summaries, titles, evaluation rationales, data collection rationales). If not set, the language will be inferred from the conversation. Must be one of the supported conversation languages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_language")]
        public string? SummaryLanguage { get; set; }

        /// <summary>
        /// When enabled, a conversation transcript is automatically translated to the viewer's application language when they open the transcript page. If not set or false, transcripts are shown in their original language unless the viewer manually selects a translation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_translate_transcript_to_app_language")]
        public bool? AutoTranslateTranscriptToAppLanguage { get; set; }

        /// <summary>
        /// Settings for authentication<br/>
        /// Example: {"allowlist":[{"hostname":"https://example.com"}],"enable_auth":true,"require_origin_header":true,"shareable_token":"1234567890"}
        /// </summary>
        /// <example>{"allowlist":[{"hostname":"https://example.com"}],"enable_auth":true,"require_origin_header":true,"shareable_token":"1234567890"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::ElevenLabs.AuthSettings? Auth { get; set; }

        /// <summary>
        /// Call limits for the agent<br/>
        /// Example: {"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}
        /// </summary>
        /// <example>{"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_limits")]
        public global::ElevenLabs.AgentCallLimits? CallLimits { get; set; }

        /// <summary>
        /// Privacy settings for the agent<br/>
        /// Example: {"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}
        /// </summary>
        /// <example>{"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public global::ElevenLabs.PrivacyConfigOutput? Privacy { get; set; }

        /// <summary>
        /// The trust context in which the agent operates.<br/>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trust_context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentTrustContextJsonConverter))]
        public global::ElevenLabs.AgentTrustContext? TrustContext { get; set; }

        /// <summary>
        /// Default LLM model for post-call analysis (evaluation and data collection)<br/>
        /// Default Value: gemini-2.5-flash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_llm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.LlmJsonConverter))]
        public global::ElevenLabs.Llm? AnalysisLlm { get; set; }

        /// <summary>
        /// Per-agent topic discovery configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_discovery")]
        public global::ElevenLabs.TopicDiscoverySettings? TopicDiscovery { get; set; }

        /// <summary>
        /// Per-agent post-call sentiment analysis configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis")]
        public global::ElevenLabs.SentimentAnalysisSettings? SentimentAnalysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety")]
        public global::ElevenLabs.SafetyResponseModel? Safety { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPlatformSettingsResponseModel" /> class.
        /// </summary>
        /// <param name="evaluation">
        /// Settings for evaluation
        /// </param>
        /// <param name="widget">
        /// Configuration for the widget<br/>
        /// Example: {"custom_avatar_path":"https://example.com/avatar.png","language_selector":false}
        /// </param>
        /// <param name="dataCollection">
        /// Data collection settings
        /// </param>
        /// <param name="dataCollectionScopes">
        /// Scope per data collection item ID. Missing keys default to conversation scope.
        /// </param>
        /// <param name="analysisItems">
        /// Evaluation + data-collection items attached by reference. None means the agent has not been migrated onto analysis items yet (distinct from an empty, migrated set); reads fall back to the legacy evaluation/data_collection fields in that case.
        /// </param>
        /// <param name="overrides">
        /// Additional overrides for the agent during conversation initiation<br/>
        /// Example: {"custom_llm_extra_body":true,"enable_conversation_initiation_client_data_from_webhook":true,"enable_starting_workflow_node_id_from_client":true}
        /// </param>
        /// <param name="workspaceOverrides">
        /// Workspace overrides for the agent
        /// </param>
        /// <param name="testing">
        /// Testing configuration for the agent<br/>
        /// Example: {"attached_tests":[{"environment":"staging","test_id":"test_123","workflow_node_id":"node_abc"},{"test_id":"test_456"}],"referenced_tests_ids":["test_123","test_456"]}
        /// </param>
        /// <param name="archived">
        /// Whether the agent is archived<br/>
        /// Default Value: false
        /// </param>
        /// <param name="guardrails">
        /// Guardrails configuration for the agent
        /// </param>
        /// <param name="summaryLanguage">
        /// Language for all conversation analysis outputs (summaries, titles, evaluation rationales, data collection rationales). If not set, the language will be inferred from the conversation. Must be one of the supported conversation languages.
        /// </param>
        /// <param name="autoTranslateTranscriptToAppLanguage">
        /// When enabled, a conversation transcript is automatically translated to the viewer's application language when they open the transcript page. If not set or false, transcripts are shown in their original language unless the viewer manually selects a translation.
        /// </param>
        /// <param name="auth">
        /// Settings for authentication<br/>
        /// Example: {"allowlist":[{"hostname":"https://example.com"}],"enable_auth":true,"require_origin_header":true,"shareable_token":"1234567890"}
        /// </param>
        /// <param name="callLimits">
        /// Call limits for the agent<br/>
        /// Example: {"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}
        /// </param>
        /// <param name="privacy">
        /// Privacy settings for the agent<br/>
        /// Example: {"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}
        /// </param>
        /// <param name="trustContext">
        /// The trust context in which the agent operates.<br/>
        /// Default Value: unknown
        /// </param>
        /// <param name="analysisLlm">
        /// Default LLM model for post-call analysis (evaluation and data collection)<br/>
        /// Default Value: gemini-2.5-flash
        /// </param>
        /// <param name="topicDiscovery">
        /// Per-agent topic discovery configuration
        /// </param>
        /// <param name="sentimentAnalysis">
        /// Per-agent post-call sentiment analysis configuration
        /// </param>
        /// <param name="safety"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPlatformSettingsResponseModel(
            global::ElevenLabs.EvaluationSettingsOutput? evaluation,
            global::ElevenLabs.WidgetConfigOutput? widget,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisProperty>? dataCollection,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisScope>? dataCollectionScopes,
            global::ElevenLabs.AgentAnalysisItemsOutput? analysisItems,
            global::ElevenLabs.ConversationInitiationClientDataConfigOutput? overrides,
            global::ElevenLabs.AgentWorkspaceOverridesOutput? workspaceOverrides,
            global::ElevenLabs.AgentTestingSettings? testing,
            bool? archived,
            global::ElevenLabs.GuardrailsV1Output? guardrails,
            string? summaryLanguage,
            bool? autoTranslateTranscriptToAppLanguage,
            global::ElevenLabs.AuthSettings? auth,
            global::ElevenLabs.AgentCallLimits? callLimits,
            global::ElevenLabs.PrivacyConfigOutput? privacy,
            global::ElevenLabs.AgentTrustContext? trustContext,
            global::ElevenLabs.Llm? analysisLlm,
            global::ElevenLabs.TopicDiscoverySettings? topicDiscovery,
            global::ElevenLabs.SentimentAnalysisSettings? sentimentAnalysis,
            global::ElevenLabs.SafetyResponseModel? safety)
        {
            this.Evaluation = evaluation;
            this.Widget = widget;
            this.DataCollection = dataCollection;
            this.DataCollectionScopes = dataCollectionScopes;
            this.AnalysisItems = analysisItems;
            this.Overrides = overrides;
            this.WorkspaceOverrides = workspaceOverrides;
            this.Testing = testing;
            this.Archived = archived;
            this.Guardrails = guardrails;
            this.SummaryLanguage = summaryLanguage;
            this.AutoTranslateTranscriptToAppLanguage = autoTranslateTranscriptToAppLanguage;
            this.Auth = auth;
            this.CallLimits = callLimits;
            this.Privacy = privacy;
            this.TrustContext = trustContext;
            this.AnalysisLlm = analysisLlm;
            this.TopicDiscovery = topicDiscovery;
            this.SentimentAnalysis = sentimentAnalysis;
            this.Safety = safety;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPlatformSettingsResponseModel" /> class.
        /// </summary>
        public AgentPlatformSettingsResponseModel()
        {
        }

    }
}