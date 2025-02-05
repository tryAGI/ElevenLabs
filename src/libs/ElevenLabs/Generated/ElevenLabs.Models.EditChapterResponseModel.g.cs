
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditChapterResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ChapterWithContentResponseModel Chapter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditChapterResponseModel" /> class.
        /// </summary>
        /// <param name="chapter"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EditChapterResponseModel(
            global::ElevenLabs.ChapterWithContentResponseModel chapter)
        {
            this.Chapter = chapter ?? throw new global::System.ArgumentNullException(nameof(chapter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditChapterResponseModel" /> class.
        /// </summary>
        public EditChapterResponseModel()
        {
        }
    }
}