
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// One line of the workspace's invoice; an `adjustment` line covers any remainder, so lines sum to the charge.
    /// </summary>
    public sealed partial class ResellerInvoiceLine
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ResellerInvoiceLineKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ResellerInvoiceLineKind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Negative for a proration credit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AmountCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_start_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeriodStartUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_end_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeriodEndUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerInvoiceLine" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="description"></param>
        /// <param name="amountCents">
        /// Negative for a proration credit.
        /// </param>
        /// <param name="periodStartUnix"></param>
        /// <param name="periodEndUnix"></param>
        /// <param name="quantity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResellerInvoiceLine(
            global::ElevenLabs.ResellerInvoiceLineKind kind,
            string description,
            int amountCents,
            int periodStartUnix,
            int periodEndUnix,
            int? quantity)
        {
            this.Kind = kind;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Quantity = quantity;
            this.AmountCents = amountCents;
            this.PeriodStartUnix = periodStartUnix;
            this.PeriodEndUnix = periodEndUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerInvoiceLine" /> class.
        /// </summary>
        public ResellerInvoiceLine()
        {
        }

    }
}