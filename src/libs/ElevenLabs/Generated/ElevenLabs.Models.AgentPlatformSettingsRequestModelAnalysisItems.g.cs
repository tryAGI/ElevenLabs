
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Evaluation + data-collection items attached by reference. None means the agent has not been migrated onto analysis items yet (distinct from an empty, migrated set); reads fall back to the legacy evaluation/data_collection fields in that case.
    /// </summary>
    public sealed partial class AgentPlatformSettingsRequestModelAnalysisItems
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}