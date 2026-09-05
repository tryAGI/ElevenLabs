
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Server-side rejection guard for an LLM-provided value: the runtime rejects any value outside the permitted set this object names, and the set is not advertised to the LLM as an enum. Only supported when the value source is `description`; combining it with dynamic_variable, is_system_provided, constant_value, or is_omitted is rejected.
    /// </summary>
    public sealed partial class AnalysisPropertyAllowedValues
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}