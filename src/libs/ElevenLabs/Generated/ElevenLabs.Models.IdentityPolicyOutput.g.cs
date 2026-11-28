
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Which end users an agent feature recognizes. Each feature that acts for an end<br/>
    /// user embeds its own, with its own default.
    /// </summary>
    public sealed partial class IdentityPolicyOutput
    {
        /// <summary>
        /// The end user is recognized when any rule matches. `workspace_asserted`: ids your backend sends through the API, your webhooks or your own app. `challenge_verified`: identities the user proved through a challenge. `provider_asserted`: platform-provided ids, the account a user messages from as the platform (Slack, WhatsApp, Telegram) reports it; ElevenLabs does not verify who uses the account. `unverified`: identities nobody verified, such as a caller's phone number, which can be spoofed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.IdentityPolicyRule> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityPolicyOutput" /> class.
        /// </summary>
        /// <param name="rules">
        /// The end user is recognized when any rule matches. `workspace_asserted`: ids your backend sends through the API, your webhooks or your own app. `challenge_verified`: identities the user proved through a challenge. `provider_asserted`: platform-provided ids, the account a user messages from as the platform (Slack, WhatsApp, Telegram) reports it; ElevenLabs does not verify who uses the account. `unverified`: identities nobody verified, such as a caller's phone number, which can be spoofed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityPolicyOutput(
            global::System.Collections.Generic.IList<global::ElevenLabs.IdentityPolicyRule> rules)
        {
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityPolicyOutput" /> class.
        /// </summary>
        public IdentityPolicyOutput()
        {
        }

    }
}