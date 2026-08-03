
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Cumulative LLM cost of running post-call analysis on this conversation.
    /// </summary>
    public sealed partial class AnalysisRunningTotal
    {
        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charge")]
        public int? Charge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_per_feature")]
        public global::System.Collections.Generic.Dictionary<string, double>? PricePerFeature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charge_per_feature")]
        public global::System.Collections.Generic.Dictionary<string, int>? ChargePerFeature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisRunningTotal" /> class.
        /// </summary>
        /// <param name="price">
        /// Default Value: 0F
        /// </param>
        /// <param name="charge">
        /// Default Value: 0
        /// </param>
        /// <param name="pricePerFeature"></param>
        /// <param name="chargePerFeature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalysisRunningTotal(
            double? price,
            int? charge,
            global::System.Collections.Generic.Dictionary<string, double>? pricePerFeature,
            global::System.Collections.Generic.Dictionary<string, int>? chargePerFeature)
        {
            this.Price = price;
            this.Charge = charge;
            this.PricePerFeature = pricePerFeature;
            this.ChargePerFeature = chargePerFeature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisRunningTotal" /> class.
        /// </summary>
        public AnalysisRunningTotal()
        {
        }

    }
}