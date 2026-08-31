
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Edit several target translations at once, applied atomically (all succeed or none do).
    /// </summary>
    public sealed partial class DubbingBulkTargetSegmentUpdateRequest
    {
        /// <summary>
        /// Map of segment ID to the translation edit to apply to that segment. At least one entry and at most 500.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingTargetSegmentUpdateRequest> Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingBulkTargetSegmentUpdateRequest" /> class.
        /// </summary>
        /// <param name="segments">
        /// Map of segment ID to the translation edit to apply to that segment. At least one entry and at most 500.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingBulkTargetSegmentUpdateRequest(
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingTargetSegmentUpdateRequest> segments)
        {
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingBulkTargetSegmentUpdateRequest" /> class.
        /// </summary>
        public DubbingBulkTargetSegmentUpdateRequest()
        {
        }

    }
}