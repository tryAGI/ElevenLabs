
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPlatformSettingsResponseModel
    {
        /// <summary>
        /// Example: {"allowlist":[{"hostname":"https://example.com"}],"enable_auth":true,"shareable_token":"1234567890"}
        /// </summary>
        /// <example>{"allowlist":[{"hostname":"https://example.com"}],"enable_auth":true,"shareable_token":"1234567890"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::ElevenLabs.AuthSettings? Auth { get; set; }

        /// <summary>
        /// Settings to evaluate an agent's performance.<br/>
        /// Agents are evaluated against a set of criteria, with success being defined as meeting some combination of those criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation")]
        public global::ElevenLabs.EvaluationSettings? Evaluation { get; set; }

        /// <summary>
        /// Example: {"custom_avatar_path":"https://example.com/avatar.png","language_selector":false}
        /// </summary>
        /// <example>{"custom_avatar_path":"https://example.com/avatar.png","language_selector":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget")]
        public global::ElevenLabs.WidgetConfigOutput? Widget { get; set; }

        /// <summary>
        /// Data collection settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? DataCollection { get; set; }

        /// <summary>
        /// Example: {"custom_llm_extra_body":true,"enable_conversation_initiation_client_data_from_webhook":true}
        /// </summary>
        /// <example>{"custom_llm_extra_body":true,"enable_conversation_initiation_client_data_from_webhook":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::ElevenLabs.ConversationInitiationClientDataConfigOutput? Overrides { get; set; }

        /// <summary>
        /// Example: {"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}
        /// </summary>
        /// <example>{"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_limits")]
        public global::ElevenLabs.AgentCallLimits? CallLimits { get; set; }

        /// <summary>
        /// Example: {"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}
        /// </summary>
        /// <example>{"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public global::ElevenLabs.PrivacyConfig? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_overrides")]
        public global::ElevenLabs.AgentWorkspaceOverridesOutput? WorkspaceOverrides { get; set; }

        /// <summary>
        /// Settings for agent testing configuration.<br/>
        /// Example: {"attached_tests":[{"test_id":"test_123"},{"test_id":"test_456"}],"referenced_tests_ids":["test_123","test_456"]}
        /// </summary>
        /// <example>{"attached_tests":[{"test_id":"test_123"},{"test_id":"test_456"}],"referenced_tests_ids":["test_123","test_456"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("testing")]
        public global::ElevenLabs.AgentTestingSettings? Testing { get; set; }

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
        /// <param name="auth">
        /// Example: {"allowlist":[{"hostname":"https://example.com"}],"enable_auth":true,"shareable_token":"1234567890"}
        /// </param>
        /// <param name="evaluation">
        /// Settings to evaluate an agent's performance.<br/>
        /// Agents are evaluated against a set of criteria, with success being defined as meeting some combination of those criteria.
        /// </param>
        /// <param name="widget">
        /// Example: {"custom_avatar_path":"https://example.com/avatar.png","language_selector":false}
        /// </param>
        /// <param name="dataCollection">
        /// Data collection settings
        /// </param>
        /// <param name="overrides">
        /// Example: {"custom_llm_extra_body":true,"enable_conversation_initiation_client_data_from_webhook":true}
        /// </param>
        /// <param name="callLimits">
        /// Example: {"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}
        /// </param>
        /// <param name="privacy">
        /// Example: {"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}
        /// </param>
        /// <param name="workspaceOverrides"></param>
        /// <param name="testing">
        /// Settings for agent testing configuration.<br/>
        /// Example: {"attached_tests":[{"test_id":"test_123"},{"test_id":"test_456"}],"referenced_tests_ids":["test_123","test_456"]}
        /// </param>
        /// <param name="safety"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPlatformSettingsResponseModel(
            global::ElevenLabs.AuthSettings? auth,
            global::ElevenLabs.EvaluationSettings? evaluation,
            global::ElevenLabs.WidgetConfigOutput? widget,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? dataCollection,
            global::ElevenLabs.ConversationInitiationClientDataConfigOutput? overrides,
            global::ElevenLabs.AgentCallLimits? callLimits,
            global::ElevenLabs.PrivacyConfig? privacy,
            global::ElevenLabs.AgentWorkspaceOverridesOutput? workspaceOverrides,
            global::ElevenLabs.AgentTestingSettings? testing,
            global::ElevenLabs.SafetyResponseModel? safety)
        {
            this.Auth = auth;
            this.Evaluation = evaluation;
            this.Widget = widget;
            this.DataCollection = dataCollection;
            this.Overrides = overrides;
            this.CallLimits = callLimits;
            this.Privacy = privacy;
            this.WorkspaceOverrides = workspaceOverrides;
            this.Testing = testing;
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