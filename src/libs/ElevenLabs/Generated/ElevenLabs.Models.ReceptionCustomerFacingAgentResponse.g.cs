
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A receptionist.
    /// </summary>
    public sealed partial class ReceptionCustomerFacingAgentResponse
    {
        /// <summary>
        /// ID of the ElevenLabs agent behind this receptionist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The receptionist's voice, language, greeting, rules and other settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::ElevenLabs.ReceptionCustomerFacingConfigOutput? Config { get; set; }

        /// <summary>
        /// Unix timestamp when this receptionist was deactivated. None when active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivated_at_unix")]
        public int? DeactivatedAtUnix { get; set; }

        /// <summary>
        /// Why this receptionist was deactivated. None when active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivation_reason")]
        public global::ElevenLabs.ReceptionCustomerFacingAgentDeactivationReason? DeactivationReason { get; set; }

        /// <summary>
        /// Display name of the receptionist.<br/>
        /// Default Value: Receptionist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// False when the receptionist's underlying agent was deleted; it cannot take calls until it is set up again.<br/>
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
        /// How the website widget looks. Null when the agent is missing. Unset labels follow the receptionist's language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget")]
        public global::ElevenLabs.ReceptionWidgetAppearance? Widget { get; set; }

        /// <summary>
        /// Whether the receptionist is active. Inactive receptionists take no live calls.<br/>
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
        /// Initializes a new instance of the <see cref="ReceptionCustomerFacingAgentResponse" /> class.
        /// </summary>
        /// <param name="agentId">
        /// ID of the ElevenLabs agent behind this receptionist.
        /// </param>
        /// <param name="config">
        /// The receptionist's voice, language, greeting, rules and other settings.
        /// </param>
        /// <param name="deactivatedAtUnix">
        /// Unix timestamp when this receptionist was deactivated. None when active.
        /// </param>
        /// <param name="deactivationReason">
        /// Why this receptionist was deactivated. None when active.
        /// </param>
        /// <param name="name">
        /// Display name of the receptionist.<br/>
        /// Default Value: Receptionist
        /// </param>
        /// <param name="agentExists">
        /// False when the receptionist's underlying agent was deleted; it cannot take calls until it is set up again.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="isTransferAllowed">
        /// Whether this receptionist can configure and use transfer rules.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="widget">
        /// How the website widget looks. Null when the agent is missing. Unset labels follow the receptionist's language.
        /// </param>
        /// <param name="isActive">
        /// Whether the receptionist is active. Inactive receptionists take no live calls.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionCustomerFacingAgentResponse(
            string? agentId,
            global::ElevenLabs.ReceptionCustomerFacingConfigOutput? config,
            int? deactivatedAtUnix,
            global::ElevenLabs.ReceptionCustomerFacingAgentDeactivationReason? deactivationReason,
            string? name,
            bool? agentExists,
            bool? isTransferAllowed,
            global::ElevenLabs.ReceptionWidgetAppearance? widget,
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
        /// Initializes a new instance of the <see cref="ReceptionCustomerFacingAgentResponse" /> class.
        /// </summary>
        public ReceptionCustomerFacingAgentResponse()
        {
        }

    }
}