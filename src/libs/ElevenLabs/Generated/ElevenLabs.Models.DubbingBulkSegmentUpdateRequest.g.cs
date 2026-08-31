
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Edit several source segments at once, applied atomically (all succeed or none do).
    /// </summary>
    public sealed partial class DubbingBulkSegmentUpdateRequest
    {
        /// <summary>
        /// Map of segment ID to the partial update to apply to that segment. At least one entry and at most 500.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingSegmentUpdateRequest> Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingBulkSegmentUpdateRequest" /> class.
        /// </summary>
        /// <param name="segments">
        /// Map of segment ID to the partial update to apply to that segment. At least one entry and at most 500.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingBulkSegmentUpdateRequest(
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingSegmentUpdateRequest> segments)
        {
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingBulkSegmentUpdateRequest" /> class.
        /// </summary>
        public DubbingBulkSegmentUpdateRequest()
        {
        }

    }
}