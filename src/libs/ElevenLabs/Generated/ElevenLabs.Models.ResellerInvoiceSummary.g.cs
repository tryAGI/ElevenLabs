
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// One charge to the reseller's card, paying for one workspace's invoice.
    /// </summary>
    public sealed partial class ResellerInvoiceSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvoiceId { get; set; }

        /// <summary>
        /// The workspace this charge paid for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceName { get; set; }

        /// <summary>
        /// `open` while the card is still being retried; `void` once retries ran out and the workspace's plan was ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ResellerInvoiceStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ResellerInvoiceStatus Status { get; set; }

        /// <summary>
        /// Invoice total, in the currency's minor unit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AmountCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paid_unix")]
        public int? PaidUnix { get; set; }

        /// <summary>
        /// Stripe's hosted payment page, only while open.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pay_url")]
        public string? PayUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_url")]
        public string? PdfUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerInvoiceSummary" /> class.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="workspaceName"></param>
        /// <param name="status">
        /// `open` while the card is still being retried; `void` once retries ran out and the workspace's plan was ended.
        /// </param>
        /// <param name="amountCents">
        /// Invoice total, in the currency's minor unit.
        /// </param>
        /// <param name="currency"></param>
        /// <param name="createdUnix"></param>
        /// <param name="workspaceId">
        /// The workspace this charge paid for.
        /// </param>
        /// <param name="paidUnix"></param>
        /// <param name="payUrl">
        /// Stripe's hosted payment page, only while open.
        /// </param>
        /// <param name="pdfUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResellerInvoiceSummary(
            string invoiceId,
            string workspaceName,
            global::ElevenLabs.ResellerInvoiceStatus status,
            int amountCents,
            string currency,
            int createdUnix,
            string? workspaceId,
            int? paidUnix,
            string? payUrl,
            string? pdfUrl)
        {
            this.InvoiceId = invoiceId ?? throw new global::System.ArgumentNullException(nameof(invoiceId));
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName ?? throw new global::System.ArgumentNullException(nameof(workspaceName));
            this.Status = status;
            this.AmountCents = amountCents;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.CreatedUnix = createdUnix;
            this.PaidUnix = paidUnix;
            this.PayUrl = payUrl;
            this.PdfUrl = pdfUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerInvoiceSummary" /> class.
        /// </summary>
        public ResellerInvoiceSummary()
        {
        }

    }
}