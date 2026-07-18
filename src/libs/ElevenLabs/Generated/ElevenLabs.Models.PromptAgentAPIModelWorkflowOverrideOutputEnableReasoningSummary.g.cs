
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Enable model reasoning summaries. When disabled, we do not request summaries from provider if possible for faster TTFB. Not ZRM compatible.
    /// </summary>
    public sealed partial class PromptAgentAPIModelWorkflowOverrideOutputEnableReasoningSummary
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}