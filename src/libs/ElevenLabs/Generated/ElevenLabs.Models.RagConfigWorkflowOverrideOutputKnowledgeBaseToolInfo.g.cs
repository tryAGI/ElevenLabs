
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// When set, the agent uses the knowledge_base tool instead of the legacy knowledge_base_rag tool. None means the agent is not opted in.
    /// </summary>
    public sealed partial class RagConfigWorkflowOverrideOutputKnowledgeBaseToolInfo
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}