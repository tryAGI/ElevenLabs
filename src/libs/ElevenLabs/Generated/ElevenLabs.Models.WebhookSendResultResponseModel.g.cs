
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookSendResultResponseModel
    {
        /// <summary>
        /// The delivery ID, also sent in the ElevenLabs-Webhook-Delivery-Id header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeliveryId { get; set; }

        /// <summary>
        /// What happened to this attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WebhookOutcomeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.WebhookOutcome Outcome { get; set; }

        /// <summary>
        /// The HTTP status your endpoint returned, if it answered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_code")]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// How long your endpoint took to answer, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_ms")]
        public int? LatencyMs { get; set; }

        /// <summary>
        /// The Content-Type your endpoint answered with, if it answered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_content_type")]
        public string? ResponseContentType { get; set; }

        /// <summary>
        /// The size of your endpoint's response body in bytes, if it answered. The body itself is never stored or returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_body_bytes")]
        public long? ResponseBodyBytes { get; set; }

        /// <summary>
        /// Where a failure came from: recipient, configuration, external_transport or timeout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_origin")]
        public string? FailureOrigin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSendResultResponseModel" /> class.
        /// </summary>
        /// <param name="deliveryId">
        /// The delivery ID, also sent in the ElevenLabs-Webhook-Delivery-Id header.
        /// </param>
        /// <param name="outcome">
        /// What happened to this attempt.
        /// </param>
        /// <param name="responseCode">
        /// The HTTP status your endpoint returned, if it answered.
        /// </param>
        /// <param name="latencyMs">
        /// How long your endpoint took to answer, in milliseconds.
        /// </param>
        /// <param name="responseContentType">
        /// The Content-Type your endpoint answered with, if it answered.
        /// </param>
        /// <param name="responseBodyBytes">
        /// The size of your endpoint's response body in bytes, if it answered. The body itself is never stored or returned.
        /// </param>
        /// <param name="failureOrigin">
        /// Where a failure came from: recipient, configuration, external_transport or timeout.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSendResultResponseModel(
            string deliveryId,
            global::ElevenLabs.WebhookOutcome outcome,
            int? responseCode,
            int? latencyMs,
            string? responseContentType,
            long? responseBodyBytes,
            string? failureOrigin)
        {
            this.DeliveryId = deliveryId ?? throw new global::System.ArgumentNullException(nameof(deliveryId));
            this.Outcome = outcome;
            this.ResponseCode = responseCode;
            this.LatencyMs = latencyMs;
            this.ResponseContentType = responseContentType;
            this.ResponseBodyBytes = responseBodyBytes;
            this.FailureOrigin = failureOrigin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSendResultResponseModel" /> class.
        /// </summary>
        public WebhookSendResultResponseModel()
        {
        }

    }
}