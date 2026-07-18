
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// One segment of a source transcript.
    /// </summary>
    public sealed partial class DubbingTranscriptSegment
    {
        /// <summary>
        /// Stable identifier of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The transcribed text of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscriptSegment" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the segment.
        /// </param>
        /// <param name="text">
        /// The transcribed text of the segment.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingTranscriptSegment(
            string id,
            string text,
            string speakerId,
            double startS,
            double endS)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.SpeakerId = speakerId ?? throw new global::System.ArgumentNullException(nameof(speakerId));
            this.StartS = startS;
            this.EndS = endS;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscriptSegment" /> class.
        /// </summary>
        public DubbingTranscriptSegment()
        {
        }

    }
}