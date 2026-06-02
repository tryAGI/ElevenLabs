
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentGenerationPriceResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PriceCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_fiat_currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CostFiatCurrency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGenerationPriceResponseModel" /> class.
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="priceCents"></param>
        /// <param name="costFiatCurrency"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentGenerationPriceResponseModel(
            double credits,
            double priceCents,
            string costFiatCurrency)
        {
            this.Credits = credits;
            this.PriceCents = priceCents;
            this.CostFiatCurrency = costFiatCurrency ?? throw new global::System.ArgumentNullException(nameof(costFiatCurrency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGenerationPriceResponseModel" /> class.
        /// </summary>
        public ContentGenerationPriceResponseModel()
        {
        }

    }
}