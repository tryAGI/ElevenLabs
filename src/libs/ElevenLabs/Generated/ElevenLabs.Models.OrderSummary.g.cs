
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"name":"Spanish Dubs","order_id":"prodorder_01jgatk6h0fwxrtbjade61yqhx","sandbox":false,"state":"submitted","submitted_at":"2025-03-15T10:30:00Z","total_amount_usd":11.0,"updated_at":"2025-03-15T10:30:00Z"}
    /// </summary>
    public sealed partial class OrderSummary
    {
        /// <summary>
        /// The ID of the order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrderId { get; set; }

        /// <summary>
        /// The display name of the order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The current state of the order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.OrderStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.OrderState State { get; set; }

        /// <summary>
        /// The total price for all items in USD. Excluded from response until quotes are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_amount_usd")]
        public double? TotalAmountUsd { get; set; }

        /// <summary>
        /// Whether this is a sandbox order that auto-progresses without producer intervention.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }

        /// <summary>
        /// The timestamp when the order was submitted, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        public global::System.DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// The timestamp when the order was last modified, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSummary" /> class.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the order.
        /// </param>
        /// <param name="name">
        /// The display name of the order.
        /// </param>
        /// <param name="state">
        /// The current state of the order.
        /// </param>
        /// <param name="totalAmountUsd">
        /// The total price for all items in USD. Excluded from response until quotes are available.
        /// </param>
        /// <param name="sandbox">
        /// Whether this is a sandbox order that auto-progresses without producer intervention.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="submittedAt">
        /// The timestamp when the order was submitted, if applicable.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the order was last modified, if applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderSummary(
            string orderId,
            string name,
            global::ElevenLabs.OrderState state,
            double? totalAmountUsd,
            bool? sandbox,
            global::System.DateTime? submittedAt,
            global::System.DateTime? updatedAt)
        {
            this.OrderId = orderId ?? throw new global::System.ArgumentNullException(nameof(orderId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.State = state;
            this.TotalAmountUsd = totalAmountUsd;
            this.Sandbox = sandbox;
            this.SubmittedAt = submittedAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSummary" /> class.
        /// </summary>
        public OrderSummary()
        {
        }

    }
}