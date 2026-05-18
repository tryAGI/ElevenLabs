
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"amount_usd":11.0}
    /// </summary>
    public sealed partial class QuoteInfo
    {
        /// <summary>
        /// The quoted price for this item in USD. Use the order's total_amount_usd for the combined order total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AmountUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteInfo" /> class.
        /// </summary>
        /// <param name="amountUsd">
        /// The quoted price for this item in USD. Use the order's total_amount_usd for the combined order total.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuoteInfo(
            double amountUsd)
        {
            this.AmountUsd = amountUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteInfo" /> class.
        /// </summary>
        public QuoteInfo()
        {
        }

    }
}