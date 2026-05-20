
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"created_at":"2025-03-15T10:00:00Z","items":[{"item":{"captions_sdh":false,"destination_languages":["hi","fr-FR","de"],"include_captions":true,"include_source_captions":false,"instructions":"Voices don\u0027t need to match the originals, prioritize native-sounding voices","kind":"dub","media_id":"prodmedia_01jgb2zd68f8f9tfvbb968wb8z","source_language":"en"},"item_id":"proditem_01jgd3qhejfs7rm6swknz2ytjb","quote":{"amount_usd":11.0}}],"name":"Spanish Dubs","order_id":"prodorder_01jgatk6h0fwxrtbjade61yqhx","sandbox":false,"state":"open","total_amount_usd":11.0}
    /// </summary>
    public sealed partial class OrderResponse
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
        /// The list of items in this order with their quotes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.OrderItemInfo> Items { get; set; }

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
        /// The timestamp when the order was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the order was submitted, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        public global::System.DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// The timestamp when payment was received, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paid_at")]
        public global::System.DateTime? PaidAt { get; set; }

        /// <summary>
        /// The timestamp when the order was accepted for production, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_at")]
        public global::System.DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// The timestamp when the order was completed, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderResponse" /> class.
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
        /// <param name="items">
        /// The list of items in this order with their quotes.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the order was created.
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
        /// <param name="paidAt">
        /// The timestamp when payment was received, if applicable.
        /// </param>
        /// <param name="acceptedAt">
        /// The timestamp when the order was accepted for production, if applicable.
        /// </param>
        /// <param name="completedAt">
        /// The timestamp when the order was completed, if applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderResponse(
            string orderId,
            string name,
            global::ElevenLabs.OrderState state,
            global::System.Collections.Generic.IList<global::ElevenLabs.OrderItemInfo> items,
            global::System.DateTime createdAt,
            double? totalAmountUsd,
            bool? sandbox,
            global::System.DateTime? submittedAt,
            global::System.DateTime? paidAt,
            global::System.DateTime? acceptedAt,
            global::System.DateTime? completedAt)
        {
            this.OrderId = orderId ?? throw new global::System.ArgumentNullException(nameof(orderId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.State = state;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.TotalAmountUsd = totalAmountUsd;
            this.Sandbox = sandbox;
            this.CreatedAt = createdAt;
            this.SubmittedAt = submittedAt;
            this.PaidAt = paidAt;
            this.AcceptedAt = acceptedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderResponse" /> class.
        /// </summary>
        public OrderResponse()
        {
        }

    }
}