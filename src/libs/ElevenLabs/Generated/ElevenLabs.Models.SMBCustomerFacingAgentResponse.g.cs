
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// API response model that adds the display name from the ConvAI agent doc.
    /// </summary>
    public sealed partial class SMBCustomerFacingAgentResponse
    {
        /// <summary>
        /// ConvAI agent id. Empty string is the placeholder seeded by the legacy API validator when migrating a single-agent payload; the agent-owning service resolves it from the workspace assignment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::ElevenLabs.CustomerFacingConfigOutput? Config { get; set; }

        /// <summary>
        /// Unix timestamp when this receptionist was deactivated. None when active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivated_at_unix")]
        public int? DeactivatedAtUnix { get; set; }

        /// <summary>
        /// Why this receptionist was deactivated. None when active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivation_reason")]
        public global::ElevenLabs.SMBCustomerFacingAgentDeactivationReason? DeactivationReason { get; set; }

        /// <summary>
        /// Display name read from the ConvAI agent document (the single source of truth).<br/>
        /// Default Value: Receptionist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the underlying ConvAI agent document still exists. False when the receptionist references a deleted agent and needs repair.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_exists")]
        public bool? AgentExists { get; set; }

        /// <summary>
        /// Whether this receptionist can configure and use transfer rules.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_transfer_allowed")]
        public bool? IsTransferAllowed { get; set; }

        /// <summary>
        /// How the website widget looks, read from the ConvAI agent's platform settings. Null when the agent document is missing. Unset labels mean the widget follows the agent's own language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget")]
        public global::ElevenLabs.SMBWidgetAppearance? Widget { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool IsActive { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBCustomerFacingAgentResponse" /> class.
        /// </summary>
        /// <param name="agentId">
        /// ConvAI agent id. Empty string is the placeholder seeded by the legacy API validator when migrating a single-agent payload; the agent-owning service resolves it from the workspace assignment.
        /// </param>
        /// <param name="config"></param>
        /// <param name="deactivatedAtUnix">
        /// Unix timestamp when this receptionist was deactivated. None when active.
        /// </param>
        /// <param name="deactivationReason">
        /// Why this receptionist was deactivated. None when active.
        /// </param>
        /// <param name="name">
        /// Display name read from the ConvAI agent document (the single source of truth).<br/>
        /// Default Value: Receptionist
        /// </param>
        /// <param name="agentExists">
        /// Whether the underlying ConvAI agent document still exists. False when the receptionist references a deleted agent and needs repair.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="isTransferAllowed">
        /// Whether this receptionist can configure and use transfer rules.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="widget">
        /// How the website widget looks, read from the ConvAI agent's platform settings. Null when the agent document is missing. Unset labels mean the widget follows the agent's own language.
        /// </param>
        /// <param name="isActive">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBCustomerFacingAgentResponse(
            string? agentId,
            global::ElevenLabs.CustomerFacingConfigOutput? config,
            int? deactivatedAtUnix,
            global::ElevenLabs.SMBCustomerFacingAgentDeactivationReason? deactivationReason,
            string? name,
            bool? agentExists,
            bool? isTransferAllowed,
            global::ElevenLabs.SMBWidgetAppearance? widget,
            bool isActive = default!)
        {
            this.AgentId = agentId;
            this.Config = config;
            this.DeactivatedAtUnix = deactivatedAtUnix;
            this.DeactivationReason = deactivationReason;
            this.Name = name;
            this.AgentExists = agentExists;
            this.IsTransferAllowed = isTransferAllowed;
            this.Widget = widget;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBCustomerFacingAgentResponse" /> class.
        /// </summary>
        public SMBCustomerFacingAgentResponse()
        {
        }

    }
}