
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The result of a bulk source edit: the updated segments and the new revision.
    /// </summary>
    public sealed partial class DubbingBulkSourceSegmentUpdateResponse
    {
        /// <summary>
        /// The edited segments in their updated state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptSegment> Segments { get; set; }

        /// <summary>
        /// The project's source-transcript revision after the edits.
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
        /// Initializes a new instance of the <see cref="DubbingBulkSourceSegmentUpdateResponse" /> class.
        /// </summary>
        /// <param name="segments">
        /// The edited segments in their updated state.
        /// </param>
        /// <param name="revision">
        /// The project's source-transcript revision after the edits.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingBulkSourceSegmentUpdateResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptSegment> segments,
            int revision)
        {
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingBulkSourceSegmentUpdateResponse" /> class.
        /// </summary>
        public DubbingBulkSourceSegmentUpdateResponse()
        {
        }

    }
}