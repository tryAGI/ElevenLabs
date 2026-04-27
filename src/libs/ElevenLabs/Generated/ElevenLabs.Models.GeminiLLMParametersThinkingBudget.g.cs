
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Thinking token budget. None=automatic, 0=disabled, &gt;0=custom. Not supported on all models (e.g. gemini-2.5-flash-lite-llm).
    /// </summary>
    public sealed partial class GeminiLLMParametersThinkingBudget
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}