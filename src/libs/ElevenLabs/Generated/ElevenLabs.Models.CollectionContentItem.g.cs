
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionContentItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AddedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AddedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.TaskDescriptionContentItem, global::ElevenLabs.NestedCollectionContentItem>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnyOf<global::ElevenLabs.TaskDescriptionContentItem, global::ElevenLabs.NestedCollectionContentItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionContentItem" /> class.
        /// </summary>
        /// <param name="addedAt"></param>
        /// <param name="addedBy"></param>
        /// <param name="id"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionContentItem(
            global::System.DateTime addedAt,
            string addedBy,
            global::System.Guid id,
            global::ElevenLabs.AnyOf<global::ElevenLabs.TaskDescriptionContentItem, global::ElevenLabs.NestedCollectionContentItem> data)
        {
            this.AddedAt = addedAt;
            this.AddedBy = addedBy ?? throw new global::System.ArgumentNullException(nameof(addedBy));
            this.Id = id;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionContentItem" /> class.
        /// </summary>
        public CollectionContentItem()
        {
        }
    }
}