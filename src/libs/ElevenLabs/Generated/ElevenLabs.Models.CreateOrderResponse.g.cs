
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"order_id":"prodorder_01jgatk6h0fwxrtbjade61yqhx"}
    /// </summary>
    public sealed partial class CreateOrderResponse
    {
        /// <summary>
        /// The ID of the newly created order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderResponse" /> class.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the newly created order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrderResponse(
            string orderId)
        {
            this.OrderId = orderId ?? throw new global::System.ArgumentNullException(nameof(orderId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderResponse" /> class.
        /// </summary>
        public CreateOrderResponse()
        {
        }

    }
}