
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The template a business-initiated conversation opened with, and how far it got.
    /// </summary>
    public sealed partial class WhatsAppOpeningMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wamid")]
        public string? Wamid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sent_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SentAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivered_at_unix")]
        public int? DeliveredAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_at_unix")]
        public int? ReadAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replied_at_unix")]
        public int? RepliedAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at_unix")]
        public int? FailedAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_category")]
        public string? PricingCategory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable")]
        public bool? Billable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppOpeningMessage" /> class.
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="sentAtUnix"></param>
        /// <param name="wamid"></param>
        /// <param name="deliveredAtUnix"></param>
        /// <param name="readAtUnix"></param>
        /// <param name="repliedAtUnix"></param>
        /// <param name="failedAtUnix"></param>
        /// <param name="errorCode"></param>
        /// <param name="pricingCategory"></param>
        /// <param name="billable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppOpeningMessage(
            string templateName,
            int sentAtUnix,
            string? wamid,
            int? deliveredAtUnix,
            int? readAtUnix,
            int? repliedAtUnix,
            int? failedAtUnix,
            string? errorCode,
            string? pricingCategory,
            bool? billable)
        {
            this.TemplateName = templateName ?? throw new global::System.ArgumentNullException(nameof(templateName));
            this.Wamid = wamid;
            this.SentAtUnix = sentAtUnix;
            this.DeliveredAtUnix = deliveredAtUnix;
            this.ReadAtUnix = readAtUnix;
            this.RepliedAtUnix = repliedAtUnix;
            this.FailedAtUnix = failedAtUnix;
            this.ErrorCode = errorCode;
            this.PricingCategory = pricingCategory;
            this.Billable = billable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppOpeningMessage" /> class.
        /// </summary>
        public WhatsAppOpeningMessage()
        {
        }

    }
}