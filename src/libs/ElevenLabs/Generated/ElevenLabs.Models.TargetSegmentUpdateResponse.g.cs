
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The result of a target-translation edit: the updated segment and the new revision.
    /// </summary>
    public sealed partial class TargetSegmentUpdateResponse
    {
        /// <summary>
        /// The target segment in its updated state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TargetTranscriptSegment Segment { get; set; }

        /// <summary>
        /// The target's revision after this edit.
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
        /// Initializes a new instance of the <see cref="TargetSegmentUpdateResponse" /> class.
        /// </summary>
        /// <param name="segment">
        /// The target segment in its updated state.
        /// </param>
        /// <param name="revision">
        /// The target's revision after this edit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TargetSegmentUpdateResponse(
            global::ElevenLabs.TargetTranscriptSegment segment,
            int revision)
        {
            this.Segment = segment ?? throw new global::System.ArgumentNullException(nameof(segment));
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetSegmentUpdateResponse" /> class.
        /// </summary>
        public TargetSegmentUpdateResponse()
        {
        }

    }
}