
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A new source segment; its id and word-level alignment are assigned by the server.
    /// </summary>
    public sealed partial class DubbingSegmentCreateRequest
    {
        /// <summary>
        /// The text of the new segment.
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
        /// Initializes a new instance of the <see cref="DubbingSegmentCreateRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the new segment.
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
        public DubbingSegmentCreateRequest(
            string text,
            string speakerId,
            double startS,
            double endS)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.SpeakerId = speakerId ?? throw new global::System.ArgumentNullException(nameof(speakerId));
            this.StartS = startS;
            this.EndS = endS;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingSegmentCreateRequest" /> class.
        /// </summary>
        public DubbingSegmentCreateRequest()
        {
        }

    }
}