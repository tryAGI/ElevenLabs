
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TransferRuleOutput
    {
        /// <summary>
        /// At most one transfer configuration per telephony provider. A provider without an entry cannot use this transfer rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_configs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ProviderConfigsItem2> ProviderConfigs { get; set; }

        /// <summary>
        /// When the agent should pick this transfer. Supports dynamic variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRuleOutput" /> class.
        /// </summary>
        /// <param name="providerConfigs">
        /// At most one transfer configuration per telephony provider. A provider without an entry cannot use this transfer rule.
        /// </param>
        /// <param name="condition">
        /// When the agent should pick this transfer. Supports dynamic variables.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferRuleOutput(
            global::System.Collections.Generic.IList<global::ElevenLabs.ProviderConfigsItem2> providerConfigs,
            string condition)
        {
            this.ProviderConfigs = providerConfigs ?? throw new global::System.ArgumentNullException(nameof(providerConfigs));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRuleOutput" /> class.
        /// </summary>
        public TransferRuleOutput()
        {
        }

    }
}