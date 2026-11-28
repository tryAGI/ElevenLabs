
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Recognizes an end user the conversation established by `verification_method`.<br/>
    /// Fields a rule gains later narrow what it matches and default to matching<br/>
    /// anything, so a stored rule keeps its meaning.
    /// </summary>
    public sealed partial class IdentityPolicyRule
    {
        /// <summary>
        /// How the conversation established who the end user is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.IdentityVerificationMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.IdentityVerificationMethod VerificationMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityPolicyRule" /> class.
        /// </summary>
        /// <param name="verificationMethod">
        /// How the conversation established who the end user is.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityPolicyRule(
            global::ElevenLabs.IdentityVerificationMethod verificationMethod)
        {
            this.VerificationMethod = verificationMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityPolicyRule" /> class.
        /// </summary>
        public IdentityPolicyRule()
        {
        }

    }
}