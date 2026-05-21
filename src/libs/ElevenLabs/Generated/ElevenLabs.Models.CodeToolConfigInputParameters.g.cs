
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Schema for parameters the LLM provides to the code tool via `args`
    /// </summary>
    public sealed partial class CodeToolConfigInputParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}