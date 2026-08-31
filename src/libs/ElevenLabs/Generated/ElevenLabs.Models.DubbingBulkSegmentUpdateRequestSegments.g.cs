
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Map of segment ID to the partial update to apply to that segment. At least one entry and at most 500.
    /// </summary>
    public sealed partial class DubbingBulkSegmentUpdateRequestSegments
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}