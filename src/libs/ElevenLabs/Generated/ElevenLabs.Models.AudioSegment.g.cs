
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioSegment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_type")]
        public string? SegmentType { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_speech")]
        public bool? HasSpeech { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_music")]
        public bool? HasMusic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pacing")]
        public string? Pacing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSegment" /> class.
        /// </summary>
        /// <param name="startMs"></param>
        /// <param name="endMs"></param>
        /// <param name="description"></param>
        /// <param name="segmentType"></param>
        /// <param name="hasSpeech">
        /// Default Value: false
        /// </param>
        /// <param name="hasMusic">
        /// Default Value: false
        /// </param>
        /// <param name="pacing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioSegment(
            int startMs,
            int endMs,
            string description,
            string? segmentType,
            bool? hasSpeech,
            bool? hasMusic,
            string? pacing)
        {
            this.StartMs = startMs;
            this.EndMs = endMs;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.SegmentType = segmentType;
            this.HasSpeech = hasSpeech;
            this.HasMusic = hasMusic;
            this.Pacing = pacing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSegment" /> class.
        /// </summary>
        public AudioSegment()
        {
        }
    }
}