
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// In-flight or last refresh state for an externally-synced file. Used by clients to render sync progress and disable re-sync while a refresh is queued or processing.
    /// </summary>
    public sealed partial class GetKnowledgeBaseFileResponseModelRefreshStatus
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}