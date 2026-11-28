
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A tier you can sell.
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
        /// What the prices are in. The same for every tier on a ladder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ResellerTierResponseCurrencyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ResellerTierResponseCurrency Currency { get; set; }

        /// <summary>
        /// A tier's prices and the limits shown on its tier card.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_economics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ResellerTierEconomics TierEconomics { get; set; }

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
        /// <param name="currency">
        /// What the prices are in. The same for every tier on a ladder.
        /// </param>
        /// <param name="tierEconomics">
        /// A tier's prices and the limits shown on its tier card.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResellerTierResponse(
            string tierId,
            string displayName,
            global::ElevenLabs.ResellerTierResponseCurrency currency,
            global::ElevenLabs.ResellerTierEconomics tierEconomics)
        {
            this.TierId = tierId ?? throw new global::System.ArgumentNullException(nameof(tierId));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Currency = currency;
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