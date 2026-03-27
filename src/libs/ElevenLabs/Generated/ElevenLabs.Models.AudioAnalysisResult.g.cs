
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioAnalysisResult
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
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioSegment>? Segments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_moments")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioKeyMoment>? KeyMoments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::ElevenLabs.AssetTranscription? Transcription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAnalysisResult" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="contentType"></param>
        /// <param name="overallPacing"></param>
        /// <param name="segments"></param>
        /// <param name="keyMoments"></param>
        /// <param name="transcription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioAnalysisResult(
            string title,
            string description,
            string? contentType,
            string? overallPacing,
            global::System.Collections.Generic.IList<global::ElevenLabs.AudioSegment>? segments,
            global::System.Collections.Generic.IList<global::ElevenLabs.AudioKeyMoment>? keyMoments,
            global::ElevenLabs.AssetTranscription? transcription)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ContentType = contentType;
            this.OverallPacing = overallPacing;
            this.Segments = segments;
            this.KeyMoments = keyMoments;
            this.Transcription = transcription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAnalysisResult" /> class.
        /// </summary>
        public AudioAnalysisResult()
        {
        }
    }
}