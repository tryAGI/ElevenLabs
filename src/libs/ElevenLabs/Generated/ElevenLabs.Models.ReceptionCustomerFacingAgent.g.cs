
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A single customer-facing receptionist agent.<br/>
    /// A workspace can have multiple of these. Each entry owns its own ConvAI<br/>
    /// agent id and full ``CustomerFacingConfig`` (voice, language, first message,<br/>
    /// system tool toggles, agent rules, transfer rules).
    /// </summary>
    public sealed partial class ReceptionCustomerFacingAgent
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
        public global::ElevenLabs.ReceptionCustomerFacingConfigInput? Config { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionCustomerFacingAgent" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionCustomerFacingAgent(
            string? agentId,
            global::ElevenLabs.ReceptionCustomerFacingConfigInput? config,
            int? deactivatedAtUnix,
            global::ElevenLabs.ReceptionCustomerFacingAgentDeactivationReason? deactivationReason)
        {
            this.AgentId = agentId;
            this.Config = config;
            this.DeactivatedAtUnix = deactivatedAtUnix;
            this.DeactivationReason = deactivationReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionCustomerFacingAgent" /> class.
        /// </summary>
        public ReceptionCustomerFacingAgent()
        {
        }

    }
}