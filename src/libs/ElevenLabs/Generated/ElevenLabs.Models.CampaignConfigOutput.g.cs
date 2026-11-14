
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CampaignConfigOutput
    {
        /// <summary>
        /// The policy campaigns take unless they set their own.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        public global::ElevenLabs.PolicyConfigOutput? Policy { get; set; }

        /// <summary>
        /// Overrides of `policy`, keyed by agent ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_policies")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AgentPolicyOverrideOutput>? AgentPolicies { get; set; }

        /// <summary>
        /// Overrides for WhatsApp voice campaigns, layered between the workspace policy and an agent's overrides. Sections left out follow WhatsApp voice's built-in defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_voice_policy")]
        public global::ElevenLabs.AgentPolicyOverrideOutput? WhatsappVoicePolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignConfigOutput" /> class.
        /// </summary>
        /// <param name="policy">
        /// The policy campaigns take unless they set their own.
        /// </param>
        /// <param name="agentPolicies">
        /// Overrides of `policy`, keyed by agent ID.
        /// </param>
        /// <param name="whatsappVoicePolicy">
        /// Overrides for WhatsApp voice campaigns, layered between the workspace policy and an agent's overrides. Sections left out follow WhatsApp voice's built-in defaults.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignConfigOutput(
            global::ElevenLabs.PolicyConfigOutput? policy,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AgentPolicyOverrideOutput>? agentPolicies,
            global::ElevenLabs.AgentPolicyOverrideOutput? whatsappVoicePolicy)
        {
            this.Policy = policy;
            this.AgentPolicies = agentPolicies;
            this.WhatsappVoicePolicy = whatsappVoicePolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignConfigOutput" /> class.
        /// </summary>
        public CampaignConfigOutput()
        {
        }

    }
}