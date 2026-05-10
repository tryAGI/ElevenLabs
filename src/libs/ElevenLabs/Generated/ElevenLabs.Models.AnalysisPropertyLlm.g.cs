
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// LLM model to use for this analysis item. If not set, uses agent's analysis_llm default.
    /// </summary>
    public sealed partial class AnalysisPropertyLlm
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}