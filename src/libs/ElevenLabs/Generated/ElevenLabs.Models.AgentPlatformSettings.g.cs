
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPlatformSettings
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
        public global::ElevenLabs.WidgetConfig? Widget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? DataCollection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::ElevenLabs.ConversationInitiationClientDataConfig? Overrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_limits")]
        public global::ElevenLabs.AgentCallLimits? CallLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ban")]
        public global::ElevenLabs.AgentBan? Ban { get; set; }

        /// <summary>
        /// Safety object that has the information of safety evaluations based on used voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety")]
        public global::ElevenLabs.Safety? Safety { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public global::ElevenLabs.PrivacyConfig? Privacy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPlatformSettings" /> class.
        /// </summary>
        /// <param name="auth"></param>
        /// <param name="evaluation">
        /// Settings to evaluate an agent's performance.<br/>
        /// Agents are evaluated against a set of criteria, with success being defined as meeting some combination of those criteria.
        /// </param>
        /// <param name="widget"></param>
        /// <param name="dataCollection"></param>
        /// <param name="overrides"></param>
        /// <param name="callLimits"></param>
        /// <param name="ban"></param>
        /// <param name="safety">
        /// Safety object that has the information of safety evaluations based on used voice.
        /// </param>
        /// <param name="privacy"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AgentPlatformSettings(
            global::ElevenLabs.AuthSettings? auth,
            global::ElevenLabs.EvaluationSettings? evaluation,
            global::ElevenLabs.WidgetConfig? widget,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? dataCollection,
            global::ElevenLabs.ConversationInitiationClientDataConfig? overrides,
            global::ElevenLabs.AgentCallLimits? callLimits,
            global::ElevenLabs.AgentBan? ban,
            global::ElevenLabs.Safety? safety,
            global::ElevenLabs.PrivacyConfig? privacy)
        {
            this.Auth = auth;
            this.Evaluation = evaluation;
            this.Widget = widget;
            this.DataCollection = dataCollection;
            this.Overrides = overrides;
            this.CallLimits = callLimits;
            this.Ban = ban;
            this.Safety = safety;
            this.Privacy = privacy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPlatformSettings" /> class.
        /// </summary>
        public AgentPlatformSettings()
        {
        }
    }
}