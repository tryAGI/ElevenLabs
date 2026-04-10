
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"character_cost_multiplier":1.0,"cost_discount_multiplier":1.0}
    /// </summary>
    public sealed partial class ModelRatesResponseModel
    {
        /// <summary>
        /// The cost multiplier for characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_cost_multiplier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CharacterCostMultiplier { get; set; }

        /// <summary>
        /// Discount multiplier applied to cost estimates. Defaults to 1.0 (no discount).<br/>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_discount_multiplier")]
        public double? CostDiscountMultiplier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRatesResponseModel" /> class.
        /// </summary>
        /// <param name="characterCostMultiplier">
        /// The cost multiplier for characters.
        /// </param>
        /// <param name="costDiscountMultiplier">
        /// Discount multiplier applied to cost estimates. Defaults to 1.0 (no discount).<br/>
        /// Default Value: 1F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelRatesResponseModel(
            double characterCostMultiplier,
            double? costDiscountMultiplier)
        {
            this.CharacterCostMultiplier = characterCostMultiplier;
            this.CostDiscountMultiplier = costDiscountMultiplier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRatesResponseModel" /> class.
        /// </summary>
        public ModelRatesResponseModel()
        {
        }
    }
}