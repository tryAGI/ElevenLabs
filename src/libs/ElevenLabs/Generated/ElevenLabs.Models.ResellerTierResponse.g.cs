
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A tier as the public API shows it: the offer, not the record derived from it.
    /// </summary>
    public sealed partial class ResellerTierResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TierId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// A tier's prices and quotas, in the fields a tier is created with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_economics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SMBTierEconomics TierEconomics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerTierResponse" /> class.
        /// </summary>
        /// <param name="tierId"></param>
        /// <param name="displayName"></param>
        /// <param name="tierEconomics">
        /// A tier's prices and quotas, in the fields a tier is created with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResellerTierResponse(
            string tierId,
            string displayName,
            global::ElevenLabs.SMBTierEconomics tierEconomics)
        {
            this.TierId = tierId ?? throw new global::System.ArgumentNullException(nameof(tierId));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.TierEconomics = tierEconomics ?? throw new global::System.ArgumentNullException(nameof(tierEconomics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerTierResponse" /> class.
        /// </summary>
        public ResellerTierResponse()
        {
        }

    }
}