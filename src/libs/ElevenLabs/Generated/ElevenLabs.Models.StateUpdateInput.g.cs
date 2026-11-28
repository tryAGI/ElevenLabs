
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StateUpdateInput
    {
        /// <summary>
        /// Default Value: dynamic_variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VariableName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ASTNodeInput Expression { get; set; }

        /// <summary>
        /// When false, the LLM may omit the values this update relies on. The update is then skipped, leaving the existing state untouched.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateUpdateInput" /> class.
        /// </summary>
        /// <param name="variableName"></param>
        /// <param name="expression"></param>
        /// <param name="type">
        /// Default Value: dynamic_variable
        /// </param>
        /// <param name="required">
        /// When false, the LLM may omit the values this update relies on. The update is then skipped, leaving the existing state untouched.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StateUpdateInput(
            string variableName,
            global::ElevenLabs.ASTNodeInput expression,
            string? type,
            bool? required)
        {
            this.Type = type;
            this.VariableName = variableName ?? throw new global::System.ArgumentNullException(nameof(variableName));
            this.Expression = expression;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateUpdateInput" /> class.
        /// </summary>
        public StateUpdateInput()
        {
        }

    }
}