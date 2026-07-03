
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Most recent (in-flight or terminal) external sync job for this folder, if any. Used by clients to render sync progress.
    /// </summary>
    public sealed partial class GetKnowledgeBaseFolderResponseModelActiveSyncJob
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}