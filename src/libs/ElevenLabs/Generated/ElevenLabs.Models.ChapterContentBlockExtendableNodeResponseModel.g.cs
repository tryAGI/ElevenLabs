
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Not used. Make sure you anticipate new types in the future.
    /// </summary>
    public sealed partial class ChapterContentBlockExtendableNodeResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ChapterContentBlockExtendableNodeResponseModelTypeJsonConverter))]
        public global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModelType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockExtendableNodeResponseModel" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChapterContentBlockExtendableNodeResponseModel(
            global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModelType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockExtendableNodeResponseModel" /> class.
        /// </summary>
        public ChapterContentBlockExtendableNodeResponseModel()
        {
        }
    }
}