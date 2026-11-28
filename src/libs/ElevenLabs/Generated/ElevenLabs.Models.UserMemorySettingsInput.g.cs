
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Whether an agent remembers its end users, and how much of it it carries.
    /// </summary>
    public sealed partial class UserMemorySettingsInput
    {
        /// <summary>
        /// Whether this agent reads and writes what it remembers about its users. User memories are for business or professional use only, and their use is covered by the ElevenLabs Data Processing Addendum. Each agent remembers its users apart: no agent reads what another learned. Memories are built from the agent's stored conversations, so a value its conversation history redaction removes is never remembered. Keeping special category data in memories requires a lawful basis and the notices and consents the DPA and the ElevenAgent Terms require; health data also requires a HIPAA BAA that permits processing it. Tell end users that the agent remembers them across conversations and give them a way to opt out; erase a user's memories with the Erase User Memory endpoint.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// How much of the user's history the agent carries into the prompt: remembered facts plus verbatim transcript from earlier conversations. `minimal` keeps the facts and a short window of recent conversation, for high-volume short conversations. `balanced` suits most agents. `maximum` carries as much recent conversation as fits. Larger scales cost more prompt tokens per turn, but tend to remember intricate details better.<br/>
        /// Default Value: balanced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UserMemoryScaleJsonConverter))]
        public global::ElevenLabs.UserMemoryScale? Scale { get; set; }

        /// <summary>
        /// Which end users memories recognize. By default only ids your backend sends; `provider_asserted` (platform-provided ids, matched only within the workspace) can be added. `unverified` and `challenge_verified` are not accepted. Whoever is recognized as a user hears what the agent remembers about them, so check identity as strongly as those memories require.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_policy")]
        public global::ElevenLabs.IdentityPolicyInput? IdentityPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMemorySettingsInput" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether this agent reads and writes what it remembers about its users. User memories are for business or professional use only, and their use is covered by the ElevenLabs Data Processing Addendum. Each agent remembers its users apart: no agent reads what another learned. Memories are built from the agent's stored conversations, so a value its conversation history redaction removes is never remembered. Keeping special category data in memories requires a lawful basis and the notices and consents the DPA and the ElevenAgent Terms require; health data also requires a HIPAA BAA that permits processing it. Tell end users that the agent remembers them across conversations and give them a way to opt out; erase a user's memories with the Erase User Memory endpoint.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="scale">
        /// How much of the user's history the agent carries into the prompt: remembered facts plus verbatim transcript from earlier conversations. `minimal` keeps the facts and a short window of recent conversation, for high-volume short conversations. `balanced` suits most agents. `maximum` carries as much recent conversation as fits. Larger scales cost more prompt tokens per turn, but tend to remember intricate details better.<br/>
        /// Default Value: balanced
        /// </param>
        /// <param name="identityPolicy">
        /// Which end users memories recognize. By default only ids your backend sends; `provider_asserted` (platform-provided ids, matched only within the workspace) can be added. `unverified` and `challenge_verified` are not accepted. Whoever is recognized as a user hears what the agent remembers about them, so check identity as strongly as those memories require.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMemorySettingsInput(
            bool? enabled,
            global::ElevenLabs.UserMemoryScale? scale,
            global::ElevenLabs.IdentityPolicyInput? identityPolicy)
        {
            this.Enabled = enabled;
            this.Scale = scale;
            this.IdentityPolicy = identityPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMemorySettingsInput" /> class.
        /// </summary>
        public UserMemorySettingsInput()
        {
        }

    }
}