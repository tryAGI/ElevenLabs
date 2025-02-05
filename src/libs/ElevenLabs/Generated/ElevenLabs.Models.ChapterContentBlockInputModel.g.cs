
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterContentBlockInputModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_id")]
        public string? BlockId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel> Nodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockInputModel" /> class.
        /// </summary>
        /// <param name="blockId"></param>
        /// <param name="nodes"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChapterContentBlockInputModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel> nodes,
            string? blockId)
        {
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.BlockId = blockId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockInputModel" /> class.
        /// </summary>
        public ChapterContentBlockInputModel()
        {
        }
    }
}