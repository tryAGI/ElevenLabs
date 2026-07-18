
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The result of a source-segment add or edit: the segment and the new revision.
    /// </summary>
    public sealed partial class DubbingSourceSegmentUpdateResponse
    {
        /// <summary>
        /// The segment in its updated state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DubbingTranscriptSegment Segment { get; set; }

        /// <summary>
        /// The project's source-transcript revision after this edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingSourceSegmentUpdateResponse" /> class.
        /// </summary>
        /// <param name="segment">
        /// The segment in its updated state.
        /// </param>
        /// <param name="revision">
        /// The project's source-transcript revision after this edit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingSourceSegmentUpdateResponse(
            global::ElevenLabs.DubbingTranscriptSegment segment,
            int revision)
        {
            this.Segment = segment ?? throw new global::System.ArgumentNullException(nameof(segment));
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingSourceSegmentUpdateResponse" /> class.
        /// </summary>
        public DubbingSourceSegmentUpdateResponse()
        {
        }

    }
}