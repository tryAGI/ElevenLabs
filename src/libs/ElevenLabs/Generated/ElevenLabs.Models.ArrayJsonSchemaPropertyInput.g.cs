
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArrayJsonSchemaPropertyInput
    {
        /// <summary>
        /// Default Value: array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Schema for array elements.<br/>
        /// Default Value: {"type":"string","description":"Array element","is_system_provided":false,"dynamic_variable":"","constant_value":""}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>))]
        public global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>? Items { get; set; }

        /// <summary>
        /// When set, the entire array is populated from this dynamic variable at runtime. Mutually exclusive with description (LLM-provided array) and constant_value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        public string? DynamicVariable { get; set; }

        /// <summary>
        /// When set, the entire array uses this constant value at runtime. Mutually exclusive with description (LLM-provided array) and dynamic_variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constant_value")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?>>? ConstantValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayJsonSchemaPropertyInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: array
        /// </param>
        /// <param name="description"></param>
        /// <param name="items">
        /// Schema for array elements.<br/>
        /// Default Value: {"type":"string","description":"Array element","is_system_provided":false,"dynamic_variable":"","constant_value":""}
        /// </param>
        /// <param name="dynamicVariable">
        /// When set, the entire array is populated from this dynamic variable at runtime. Mutually exclusive with description (LLM-provided array) and constant_value.
        /// </param>
        /// <param name="constantValue">
        /// When set, the entire array uses this constant value at runtime. Mutually exclusive with description (LLM-provided array) and dynamic_variable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArrayJsonSchemaPropertyInput(
            string? type,
            string? description,
            global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>? items,
            string? dynamicVariable,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?>>? constantValue)
        {
            this.Type = type;
            this.Description = description;
            this.Items = items;
            this.DynamicVariable = dynamicVariable;
            this.ConstantValue = constantValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayJsonSchemaPropertyInput" /> class.
        /// </summary>
        public ArrayJsonSchemaPropertyInput()
        {
        }
    }
}