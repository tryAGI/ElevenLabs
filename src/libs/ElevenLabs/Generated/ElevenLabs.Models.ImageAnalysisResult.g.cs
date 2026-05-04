
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageAnalysisResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mood_and_style")]
        public string? MoodAndStyle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_notes")]
        public string? CompositionNotes { get; set; }

        /// <summary>
        /// Readable text overlaid or shown in the image, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visible_text")]
        public string? VisibleText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subjects")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageSubject>? Subjects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAnalysisResult" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="contentType"></param>
        /// <param name="moodAndStyle"></param>
        /// <param name="compositionNotes"></param>
        /// <param name="visibleText">
        /// Readable text overlaid or shown in the image, if any.
        /// </param>
        /// <param name="subjects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageAnalysisResult(
            string title,
            string description,
            string? contentType,
            string? moodAndStyle,
            string? compositionNotes,
            string? visibleText,
            global::System.Collections.Generic.IList<global::ElevenLabs.ImageSubject>? subjects)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ContentType = contentType;
            this.MoodAndStyle = moodAndStyle;
            this.CompositionNotes = compositionNotes;
            this.VisibleText = visibleText;
            this.Subjects = subjects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAnalysisResult" /> class.
        /// </summary>
        public ImageAnalysisResult()
        {
        }
    }
}