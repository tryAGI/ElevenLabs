
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertOrderItemRequest
    {
        /// <summary>
        /// The order item to add or update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInput Item { get; set; }

        /// <summary>
        /// The ID of an existing item to update. Omit to create a new item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertOrderItemRequest" /> class.
        /// </summary>
        /// <param name="item">
        /// The order item to add or update.
        /// </param>
        /// <param name="itemId">
        /// The ID of an existing item to update. Omit to create a new item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertOrderItemRequest(
            global::ElevenLabs.RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInput item,
            string? itemId)
        {
            this.Item = item;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertOrderItemRequest" /> class.
        /// </summary>
        public UpsertOrderItemRequest()
        {
        }

    }
}