
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Identifies an agent as part of the SMB product.
    /// </summary>
    public sealed partial class AgentSMBMetadata
    {
        /// <summary>
        /// Distinguishes between the customer-facing voice agent and the internal assistant agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SMBAgentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SMBAgentType AgentType { get; set; }

        /// <summary>
        /// True for pre-signup onboarding agents that have not yet been transferred to a user workspace.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_ephemeral")]
        public bool? IsEphemeral { get; set; }

        /// <summary>
        /// Hash of the SMB data+code inputs this agent was last regenerated against; the conversation-start drift gate. None (unstamped) regenerates once on the next conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_fingerprint")]
        public string? SourceFingerprint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSMBMetadata" /> class.
        /// </summary>
        /// <param name="agentType">
        /// Distinguishes between the customer-facing voice agent and the internal assistant agent.
        /// </param>
        /// <param name="isEphemeral">
        /// True for pre-signup onboarding agents that have not yet been transferred to a user workspace.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sourceFingerprint">
        /// Hash of the SMB data+code inputs this agent was last regenerated against; the conversation-start drift gate. None (unstamped) regenerates once on the next conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSMBMetadata(
            global::ElevenLabs.SMBAgentType agentType,
            bool? isEphemeral,
            string? sourceFingerprint)
        {
            this.AgentType = agentType;
            this.IsEphemeral = isEphemeral;
            this.SourceFingerprint = sourceFingerprint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSMBMetadata" /> class.
        /// </summary>
        public AgentSMBMetadata()
        {
        }

    }
}