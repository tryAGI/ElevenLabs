
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// One segment of a target transcript: a source segment plus its translation.
    /// </summary>
    public sealed partial class DubbingTargetTranscriptSegment
    {
        /// <summary>
        /// Stable identifier of the segment (from the source).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Identifier of the segment's speaker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeakerId { get; set; }

        /// <summary>
        /// Start time of the segment, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_s")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartS { get; set; }

        /// <summary>
        /// End time of the segment, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_s")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndS { get; set; }

        /// <summary>
        /// The source-language text of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceText { get; set; }

        /// <summary>
        /// The translated text, or null if not translated yet (needs translation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation")]
        public string? Translation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTargetTranscriptSegment" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the segment (from the source).
        /// </param>
        /// <param name="speakerId">
        /// Identifier of the segment's speaker.
        /// </param>
        /// <param name="startS">
        /// Start time of the segment, in seconds.
        /// </param>
        /// <param name="endS">
        /// End time of the segment, in seconds.
        /// </param>
        /// <param name="sourceText">
        /// The source-language text of the segment.
        /// </param>
        /// <param name="translation">
        /// The translated text, or null if not translated yet (needs translation).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingTargetTranscriptSegment(
            string id,
            string speakerId,
            double startS,
            double endS,
            string sourceText,
            string? translation)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SpeakerId = speakerId ?? throw new global::System.ArgumentNullException(nameof(speakerId));
            this.StartS = startS;
            this.EndS = endS;
            this.SourceText = sourceText ?? throw new global::System.ArgumentNullException(nameof(sourceText));
            this.Translation = translation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTargetTranscriptSegment" /> class.
        /// </summary>
        public DubbingTargetTranscriptSegment()
        {
        }

    }
}