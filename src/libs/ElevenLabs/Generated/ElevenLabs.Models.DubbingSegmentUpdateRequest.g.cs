
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A partial update to a source segment; omitted fields are left unchanged.
    /// </summary>
    public sealed partial class DubbingSegmentUpdateRequest
    {
        /// <summary>
        /// New text for the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// New speaker id for the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        public string? SpeakerId { get; set; }

        /// <summary>
        /// New start time, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_s")]
        public double? StartS { get; set; }

        /// <summary>
        /// New end time, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_s")]
        public double? EndS { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingSegmentUpdateRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// New text for the segment.
        /// </param>
        /// <param name="speakerId">
        /// New speaker id for the segment.
        /// </param>
        /// <param name="startS">
        /// New start time, in seconds.
        /// </param>
        /// <param name="endS">
        /// New end time, in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingSegmentUpdateRequest(
            string? text,
            string? speakerId,
            double? startS,
            double? endS)
        {
            this.Text = text;
            this.SpeakerId = speakerId;
            this.StartS = startS;
            this.EndS = endS;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingSegmentUpdateRequest" /> class.
        /// </summary>
        public DubbingSegmentUpdateRequest()
        {
        }

    }
}