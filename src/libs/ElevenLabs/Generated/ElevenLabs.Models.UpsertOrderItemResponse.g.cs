
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"item_id":"proditem_01jgd3qhejfs7rm6swknz2ytjb","quote":{"amount_usd":11.0}}
    /// </summary>
    public sealed partial class UpsertOrderItemResponse
    {
        /// <summary>
        /// The ID of the upserted order item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The quoted price for this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quote")]
        public global::ElevenLabs.QuoteInfo? Quote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertOrderItemResponse" /> class.
        /// </summary>
        /// <param name="itemId">
        /// The ID of the upserted order item.
        /// </param>
        /// <param name="quote">
        /// The quoted price for this item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertOrderItemResponse(
            string itemId,
            global::ElevenLabs.QuoteInfo? quote)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Quote = quote;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertOrderItemResponse" /> class.
        /// </summary>
        public UpsertOrderItemResponse()
        {
        }

    }
}