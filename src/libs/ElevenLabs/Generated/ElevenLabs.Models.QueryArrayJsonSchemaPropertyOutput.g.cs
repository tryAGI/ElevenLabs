
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A query param holding several literals, sent as a repeated key (?a=x&amp;a=y).
    /// </summary>
    public sealed partial class QueryArrayJsonSchemaPropertyOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// When set, the entire parameter is populated from this dynamic variable at runtime. Mutually exclusive with description (LLM-provided value), constant_value, and is_omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        public string? DynamicVariable { get; set; }

        /// <summary>
        /// When set, the entire array uses this constant value at runtime. Mutually exclusive with description (LLM-provided array), dynamic_variable, and is_omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constant_value")]
        public global::System.Collections.Generic.IList<object>? ConstantValue { get; set; }

        /// <summary>
        /// If true, this parameter will be completely omitted from the request. Only valid for optional parameters. Mutually exclusive with description, dynamic_variable, and constant_value.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_omitted")]
        public bool? IsOmitted { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"array"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "array";

        /// <summary>
        /// Schema for each value; must be a string, number or boolean.<br/>
        /// Default Value: {"type":"string","description":"Array element","is_system_provided":false,"dynamic_variable":"","allowed_values_dynamic_variable":"","constant_value":"","is_omitted":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput, global::ElevenLabs.AnyOfJsonSchemaPropertyOutput>))]
        public global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput, global::ElevenLabs.AnyOfJsonSchemaPropertyOutput>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryArrayJsonSchemaPropertyOutput" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="dynamicVariable">
        /// When set, the entire parameter is populated from this dynamic variable at runtime. Mutually exclusive with description (LLM-provided value), constant_value, and is_omitted.
        /// </param>
        /// <param name="constantValue">
        /// When set, the entire array uses this constant value at runtime. Mutually exclusive with description (LLM-provided array), dynamic_variable, and is_omitted.
        /// </param>
        /// <param name="isOmitted">
        /// If true, this parameter will be completely omitted from the request. Only valid for optional parameters. Mutually exclusive with description, dynamic_variable, and constant_value.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="items">
        /// Schema for each value; must be a string, number or boolean.<br/>
        /// Default Value: {"type":"string","description":"Array element","is_system_provided":false,"dynamic_variable":"","allowed_values_dynamic_variable":"","constant_value":"","is_omitted":false}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryArrayJsonSchemaPropertyOutput(
            string? description,
            string? dynamicVariable,
            global::System.Collections.Generic.IList<object>? constantValue,
            bool? isOmitted,
            global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput, global::ElevenLabs.AnyOfJsonSchemaPropertyOutput>? items,
            string type = "array")
        {
            this.Description = description;
            this.DynamicVariable = dynamicVariable;
            this.ConstantValue = constantValue;
            this.IsOmitted = isOmitted;
            this.Type = type;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryArrayJsonSchemaPropertyOutput" /> class.
        /// </summary>
        public QueryArrayJsonSchemaPropertyOutput()
        {
        }

    }
}