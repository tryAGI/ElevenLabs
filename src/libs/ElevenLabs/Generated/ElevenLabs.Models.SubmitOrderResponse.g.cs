
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"order_id":"prodorder_01jgatk6h0fwxrtbjade61yqhx","state":"submitted","submitted_at":"2025-03-15T10:30:00Z"}
    /// </summary>
    public sealed partial class SubmitOrderResponse
    {
        /// <summary>
        /// The ID of the submitted order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrderId { get; set; }

        /// <summary>
        /// The current state of the order after submission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.OrderStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.OrderState State { get; set; }

        /// <summary>
        /// The timestamp when the order was submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime SubmittedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitOrderResponse" /> class.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the submitted order.
        /// </param>
        /// <param name="state">
        /// The current state of the order after submission.
        /// </param>
        /// <param name="submittedAt">
        /// The timestamp when the order was submitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitOrderResponse(
            string orderId,
            global::ElevenLabs.OrderState state,
            global::System.DateTime submittedAt)
        {
            this.OrderId = orderId ?? throw new global::System.ArgumentNullException(nameof(orderId));
            this.State = state;
            this.SubmittedAt = submittedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitOrderResponse" /> class.
        /// </summary>
        public SubmitOrderResponse()
        {
        }

    }
}