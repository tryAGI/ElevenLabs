
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"item":{"captions_sdh":false,"destination_languages":["hi","fr-FR","de"],"include_captions":true,"include_source_captions":false,"instructions":"Voices don\u0027t need to match the originals, prioritize native-sounding voices","kind":"dub","media_id":"prodmedia_01jgatk6h0fwxrtbjade61yqhx","source_language":"en"},"item_id":"proditem_01jgd3qhejfs7rm6swknz2ytjb","quote":{"amount_usd":11.0}}
    /// </summary>
    public sealed partial class OrderItemInfo
    {
        /// <summary>
        /// The ID of the order item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The item configuration details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindOutputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindOutput Item { get; set; }

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
        /// Initializes a new instance of the <see cref="OrderItemInfo" /> class.
        /// </summary>
        /// <param name="itemId">
        /// The ID of the order item.
        /// </param>
        /// <param name="item">
        /// The item configuration details.
        /// </param>
        /// <param name="quote">
        /// The quoted price for this item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderItemInfo(
            string itemId,
            global::ElevenLabs.RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindOutput item,
            global::ElevenLabs.QuoteInfo? quote)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Item = item;
            this.Quote = quote;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemInfo" /> class.
        /// </summary>
        public OrderItemInfo()
        {
        }

    }
}