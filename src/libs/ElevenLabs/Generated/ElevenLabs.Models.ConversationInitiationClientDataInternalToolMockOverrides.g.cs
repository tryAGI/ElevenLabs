
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Per-tool response mock overrides keyed by resolved tool name, applied ahead of the tool's shared mocks. Used for test-specific mocks.
    /// </summary>
    public sealed partial class ConversationInitiationClientDataInternalToolMockOverrides
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}