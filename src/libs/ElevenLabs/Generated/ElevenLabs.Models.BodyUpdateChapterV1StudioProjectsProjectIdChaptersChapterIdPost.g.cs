
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost
    {
        /// <summary>
        /// The name of the chapter, used for identification only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The chapter content to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::ElevenLabs.ChapterContentInputModel? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the chapter, used for identification only.
        /// </param>
        /// <param name="content">
        /// The chapter content to use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost(
            string? name,
            global::ElevenLabs.ChapterContentInputModel? content)
        {
            this.Name = name;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost" /> class.
        /// </summary>
        public BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost()
        {
        }
    }
}