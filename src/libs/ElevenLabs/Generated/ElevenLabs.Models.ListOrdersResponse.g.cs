
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"orders":[{"name":"Spanish Dubs","order_id":"prodorder_01jgatk6h0fwxrtbjade61yqhx","state":"submitted","submitted_at":"2025-03-15T10:30:00Z","total_amount_usd":11.0,"updated_at":"2025-03-15T10:30:00Z"}]}
    /// </summary>
    public sealed partial class ListOrdersResponse
    {
        /// <summary>
        /// The list of orders matching the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.OrderSummary> Orders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrdersResponse" /> class.
        /// </summary>
        /// <param name="orders">
        /// The list of orders matching the query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOrdersResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.OrderSummary> orders)
        {
            this.Orders = orders ?? throw new global::System.ArgumentNullException(nameof(orders));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrdersResponse" /> class.
        /// </summary>
        public ListOrdersResponse()
        {
        }

    }
}