
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Custom prompt for generating the soft timeout filler message when use_llm_generated_message is enabled. Recent conversation context is provided as a separate user message. If not set, the default prompt will be used.
    /// </summary>
    public sealed partial class SoftTimeoutConfigWorkflowOverrideLlmGeneratedMessagePromptOverride
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}