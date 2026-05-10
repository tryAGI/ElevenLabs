
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoAnalysisResult
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
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_pacing")]
        public string? OverallPacing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subjects")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoSubject>? Subjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoSegment>? Segments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_moments")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoKeyMoment>? KeyMoments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAnalysisResult" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="contentType"></param>
        /// <param name="overallPacing"></param>
        /// <param name="subjects"></param>
        /// <param name="segments"></param>
        /// <param name="keyMoments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoAnalysisResult(
            string title,
            string description,
            string? contentType,
            string? overallPacing,
            global::System.Collections.Generic.IList<global::ElevenLabs.VideoSubject>? subjects,
            global::System.Collections.Generic.IList<global::ElevenLabs.VideoSegment>? segments,
            global::System.Collections.Generic.IList<global::ElevenLabs.VideoKeyMoment>? keyMoments)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ContentType = contentType;
            this.OverallPacing = overallPacing;
            this.Subjects = subjects;
            this.Segments = segments;
            this.KeyMoments = keyMoments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAnalysisResult" /> class.
        /// </summary>
        public VideoAnalysisResult()
        {
        }

    }
}