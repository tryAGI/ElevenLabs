
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArrayJsonSchemaPropertyOutput
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
        /// Default Value: {"type":"string","description":"Array element","is_system_provided":false,"dynamic_variable":"","allowed_values_dynamic_variable":"","constant_value":"","is_omitted":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>))]
        public global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>? Items { get; set; }

        /// <summary>
        /// When set, the entire array is populated from this dynamic variable at runtime. Mutually exclusive with description (LLM-provided array), constant_value, and is_omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        public string? DynamicVariable { get; set; }

        /// <summary>
        /// When set, the entire array uses this constant value at runtime. Mutually exclusive with description (LLM-provided array), dynamic_variable, and is_omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constant_value")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?>>? ConstantValue { get; set; }

        /// <summary>
        /// If true, this array parameter will be completely omitted from the request. Only valid for optional parameters. Mutually exclusive with description, dynamic_variable, and constant_value.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_omitted")]
        public bool? IsOmitted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayJsonSchemaPropertyOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: array
        /// </param>
        /// <param name="description"></param>
        /// <param name="items">
        /// Schema for array elements.<br/>
        /// Default Value: {"type":"string","description":"Array element","is_system_provided":false,"dynamic_variable":"","allowed_values_dynamic_variable":"","constant_value":"","is_omitted":false}
        /// </param>
        /// <param name="dynamicVariable">
        /// When set, the entire array is populated from this dynamic variable at runtime. Mutually exclusive with description (LLM-provided array), constant_value, and is_omitted.
        /// </param>
        /// <param name="constantValue">
        /// When set, the entire array uses this constant value at runtime. Mutually exclusive with description (LLM-provided array), dynamic_variable, and is_omitted.
        /// </param>
        /// <param name="isOmitted">
        /// If true, this array parameter will be completely omitted from the request. Only valid for optional parameters. Mutually exclusive with description, dynamic_variable, and constant_value.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArrayJsonSchemaPropertyOutput(
            string? type,
            string? description,
            global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>? items,
            string? dynamicVariable,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?>>? constantValue,
            bool? isOmitted)
        {
            this.Type = type;
            this.Description = description;
            this.Items = items;
            this.DynamicVariable = dynamicVariable;
            this.ConstantValue = constantValue;
            this.IsOmitted = isOmitted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayJsonSchemaPropertyOutput" /> class.
        /// </summary>
        public ArrayJsonSchemaPropertyOutput()
        {
        }

    }
}