
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NestedCollectionContentItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.NestedCollectionContentItemKindJsonConverter))]
        public global::ElevenLabs.NestedCollectionContentItemKind Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RefId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NestedCollectionContentItem" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="refId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NestedCollectionContentItem(
            global::System.Guid refId,
            global::ElevenLabs.NestedCollectionContentItemKind kind)
        {
            this.RefId = refId;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NestedCollectionContentItem" /> class.
        /// </summary>
        public NestedCollectionContentItem()
        {
        }
    }
}