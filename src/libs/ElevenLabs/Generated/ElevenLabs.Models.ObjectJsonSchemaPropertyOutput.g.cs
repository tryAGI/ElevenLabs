
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjectJsonSchemaPropertyOutput
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
        /// When set, the entire object uses this constant JSON value at runtime. Mutually exclusive with description (LLM-provided object), dynamic_variable, and is_omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constant_value")]
        public object? ConstantValue { get; set; }

        /// <summary>
        /// If true, this parameter will be completely omitted from the request. Only valid for optional parameters. Mutually exclusive with description, dynamic_variable, and constant_value.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_omitted")]
        public bool? IsOmitted { get; set; }

        /// <summary>
        /// Default Value: object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_constraints")]
        public global::ElevenLabs.RequiredConstraints? RequiredConstraints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectJsonSchemaPropertyOutput" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="dynamicVariable">
        /// When set, the entire parameter is populated from this dynamic variable at runtime. Mutually exclusive with description (LLM-provided value), constant_value, and is_omitted.
        /// </param>
        /// <param name="constantValue">
        /// When set, the entire object uses this constant JSON value at runtime. Mutually exclusive with description (LLM-provided object), dynamic_variable, and is_omitted.
        /// </param>
        /// <param name="isOmitted">
        /// If true, this parameter will be completely omitted from the request. Only valid for optional parameters. Mutually exclusive with description, dynamic_variable, and constant_value.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="type">
        /// Default Value: object
        /// </param>
        /// <param name="required"></param>
        /// <param name="properties"></param>
        /// <param name="requiredConstraints"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjectJsonSchemaPropertyOutput(
            string? description,
            string? dynamicVariable,
            object? constantValue,
            bool? isOmitted,
            string? type,
            global::System.Collections.Generic.IList<string>? required,
            object? properties,
            global::ElevenLabs.RequiredConstraints? requiredConstraints)
        {
            this.Description = description;
            this.DynamicVariable = dynamicVariable;
            this.ConstantValue = constantValue;
            this.IsOmitted = isOmitted;
            this.Type = type;
            this.Required = required;
            this.Properties = properties;
            this.RequiredConstraints = requiredConstraints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectJsonSchemaPropertyOutput" /> class.
        /// </summary>
        public ObjectJsonSchemaPropertyOutput()
        {
        }

    }
}