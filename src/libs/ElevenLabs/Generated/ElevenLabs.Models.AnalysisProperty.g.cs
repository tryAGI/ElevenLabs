
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Data collection property with optional per-item LLM override for post-call analysis.<br/>
    /// TODO: migrate to composition (value_schema: LiteralJsonSchemaProperty + llm) instead of<br/>
    /// inheritance, so this generalizes cleanly to object/array schemas in the future.<br/>
    /// Example: {"constant_value":"","description":"My property","dynamic_variable":"","is_system_provided":false,"type":"string"}
    /// </summary>
    public sealed partial class AnalysisProperty
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnalysisPropertyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnalysisPropertyType Type { get; set; }

        /// <summary>
        /// The description of the property. When set, the LLM will provide the value based on this description. Mutually exclusive with dynamic_variable, is_system_provided, and constant_value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List of allowed string values for string type parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// If true, the value will be populated by the system at runtime. Used by API Integration Webhook tools for templating. Mutually exclusive with description, dynamic_variable, and constant_value.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_system_provided")]
        public bool? IsSystemProvided { get; set; }

        /// <summary>
        /// The name of the dynamic variable to use for this property's value. Mutually exclusive with description, is_system_provided, and constant_value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        public string? DynamicVariable { get; set; }

        /// <summary>
        /// A constant value to use for this property. Mutually exclusive with description, dynamic_variable, and is_system_provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constant_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>))]
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?>? ConstantValue { get; set; }

        /// <summary>
        /// LLM model to use for this analysis item. If not set, uses agent's analysis_llm default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::ElevenLabs.Llm? Llm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisProperty" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="description">
        /// The description of the property. When set, the LLM will provide the value based on this description. Mutually exclusive with dynamic_variable, is_system_provided, and constant_value.
        /// </param>
        /// <param name="enum">
        /// List of allowed string values for string type parameters
        /// </param>
        /// <param name="isSystemProvided">
        /// If true, the value will be populated by the system at runtime. Used by API Integration Webhook tools for templating. Mutually exclusive with description, dynamic_variable, and constant_value.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dynamicVariable">
        /// The name of the dynamic variable to use for this property's value. Mutually exclusive with description, is_system_provided, and constant_value.
        /// </param>
        /// <param name="constantValue">
        /// A constant value to use for this property. Mutually exclusive with description, dynamic_variable, and is_system_provided.
        /// </param>
        /// <param name="llm">
        /// LLM model to use for this analysis item. If not set, uses agent's analysis_llm default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalysisProperty(
            global::ElevenLabs.AnalysisPropertyType type,
            string? description,
            global::System.Collections.Generic.IList<string>? @enum,
            bool? isSystemProvided,
            string? dynamicVariable,
            global::ElevenLabs.AnyOf<string, int?, double?, bool?>? constantValue,
            global::ElevenLabs.Llm? llm)
        {
            this.Type = type;
            this.Description = description;
            this.Enum = @enum;
            this.IsSystemProvided = isSystemProvided;
            this.DynamicVariable = dynamicVariable;
            this.ConstantValue = constantValue;
            this.Llm = llm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisProperty" /> class.
        /// </summary>
        public AnalysisProperty()
        {
        }

    }
}