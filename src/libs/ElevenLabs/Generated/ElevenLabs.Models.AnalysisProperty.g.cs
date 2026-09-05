
#pragma warning disable CS0618 // Type or member is obsolete

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
        /// The description of the property. When set, the LLM will provide the value based on this description. Mutually exclusive with dynamic_variable, is_system_provided, constant_value, and is_omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List of allowed string values for string type parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// If true, the value will be populated by the system at runtime. Used by API Integration Webhook tools for templating. Mutually exclusive with description, dynamic_variable, constant_value, and is_omitted.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_system_provided")]
        public bool? IsSystemProvided { get; set; }

        /// <summary>
        /// The name of the dynamic variable to use for this property's value. Mutually exclusive with description, is_system_provided, constant_value, and is_omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        public string? DynamicVariable { get; set; }

        /// <summary>
        /// Server-side rejection guard for an LLM-provided value: the runtime rejects any value outside the permitted set this object names, and the set is not advertised to the LLM as an enum. Only supported when the value source is `description`; combining it with dynamic_variable, is_system_provided, constant_value, or is_omitted is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_values")]
        public global::ElevenLabs.AllowedValues? AllowedValues { get; set; }

        /// <summary>
        /// DEPRECATED: use `allowed_values` instead. When set, the LLM provides the value but the runtime rejects any value not present in the list held by this dynamic variable (must be a JSON array such as ["ws_alpha", "ws_beta"]). Use to let the LLM pick from a server-verified set (e.g. the IDs the current user is allowed to access). Requires description; mutually exclusive with dynamic_variable, is_system_provided, constant_value, and is_omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_values_dynamic_variable")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AllowedValuesDynamicVariable { get; set; }

        /// <summary>
        /// A constant value to use for this property. Mutually exclusive with description, dynamic_variable, is_system_provided, and is_omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constant_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>))]
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, object>? ConstantValue { get; set; }

        /// <summary>
        /// If true, this parameter will be completely omitted from the request. Only valid for optional parameters. Mutually exclusive with description, dynamic_variable, is_system_provided, and constant_value.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_omitted")]
        public bool? IsOmitted { get; set; }

        /// <summary>
        /// The name of this data collection item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// The description of the property. When set, the LLM will provide the value based on this description. Mutually exclusive with dynamic_variable, is_system_provided, constant_value, and is_omitted.
        /// </param>
        /// <param name="enum">
        /// List of allowed string values for string type parameters
        /// </param>
        /// <param name="isSystemProvided">
        /// If true, the value will be populated by the system at runtime. Used by API Integration Webhook tools for templating. Mutually exclusive with description, dynamic_variable, constant_value, and is_omitted.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dynamicVariable">
        /// The name of the dynamic variable to use for this property's value. Mutually exclusive with description, is_system_provided, constant_value, and is_omitted.
        /// </param>
        /// <param name="allowedValues">
        /// Server-side rejection guard for an LLM-provided value: the runtime rejects any value outside the permitted set this object names, and the set is not advertised to the LLM as an enum. Only supported when the value source is `description`; combining it with dynamic_variable, is_system_provided, constant_value, or is_omitted is rejected.
        /// </param>
        /// <param name="constantValue">
        /// A constant value to use for this property. Mutually exclusive with description, dynamic_variable, is_system_provided, and is_omitted.
        /// </param>
        /// <param name="isOmitted">
        /// If true, this parameter will be completely omitted from the request. Only valid for optional parameters. Mutually exclusive with description, dynamic_variable, is_system_provided, and constant_value.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="name">
        /// The name of this data collection item.
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
            global::ElevenLabs.AllowedValues? allowedValues,
            global::ElevenLabs.AnyOf<string, int?, double?, bool?, object>? constantValue,
            bool? isOmitted,
            string? name,
            global::ElevenLabs.Llm? llm)
        {
            this.Type = type;
            this.Description = description;
            this.Enum = @enum;
            this.IsSystemProvided = isSystemProvided;
            this.DynamicVariable = dynamicVariable;
            this.AllowedValues = allowedValues;
            this.ConstantValue = constantValue;
            this.IsOmitted = isOmitted;
            this.Name = name;
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