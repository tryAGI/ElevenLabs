
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPlatformSettingsRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::ElevenLabs.AuthSettings? Auth { get; set; }

        /// <summary>
        /// Settings to evaluate an agent's performance.<br/>
        /// Agents are evaluated against a set of criteria, with success being defined as meeting some combination of those criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation")]
        public global::ElevenLabs.EvaluationSettings? Evaluation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget")]
        public global::ElevenLabs.WidgetConfigInput? Widget { get; set; }

        /// <summary>
        /// Data collection settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? DataCollection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::ElevenLabs.ConversationInitiationClientDataConfigInput? Overrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_limits")]
        public global::ElevenLabs.AgentCallLimits? CallLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public global::ElevenLabs.PrivacyConfig? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_overrides")]
        public global::ElevenLabs.AgentWorkspaceOverridesInput? WorkspaceOverrides { get; set; }

        /// <summary>
        /// Settings for agent testing configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testing")]
        public global::ElevenLabs.AgentTestingSettings? Testing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPlatformSettingsRequestModel" /> class.
        /// </summary>
        /// <param name="auth"></param>
        /// <param name="evaluation">
        /// Settings to evaluate an agent's performance.<br/>
        /// Agents are evaluated against a set of criteria, with success being defined as meeting some combination of those criteria.
        /// </param>
        /// <param name="widget"></param>
        /// <param name="dataCollection">
        /// Data collection settings
        /// </param>
        /// <param name="overrides"></param>
        /// <param name="callLimits"></param>
        /// <param name="privacy"></param>
        /// <param name="workspaceOverrides"></param>
        /// <param name="testing">
        /// Settings for agent testing configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPlatformSettingsRequestModel(
            global::ElevenLabs.AuthSettings? auth,
            global::ElevenLabs.EvaluationSettings? evaluation,
            global::ElevenLabs.WidgetConfigInput? widget,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? dataCollection,
            global::ElevenLabs.ConversationInitiationClientDataConfigInput? overrides,
            global::ElevenLabs.AgentCallLimits? callLimits,
            global::ElevenLabs.PrivacyConfig? privacy,
            global::ElevenLabs.AgentWorkspaceOverridesInput? workspaceOverrides,
            global::ElevenLabs.AgentTestingSettings? testing)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPlatformSettingsRequestModel" /> class.
        /// </summary>
        public AgentPlatformSettingsRequestModel()
        {
        }
    }
}