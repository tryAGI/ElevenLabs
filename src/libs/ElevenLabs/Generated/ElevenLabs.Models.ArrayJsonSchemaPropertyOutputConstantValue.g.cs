
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// When set, the entire array uses this constant value at runtime. Mutually exclusive with description (LLM-provided array) and dynamic_variable.
    /// </summary>
    public sealed partial class ArrayJsonSchemaPropertyOutputConstantValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}