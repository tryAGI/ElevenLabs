
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTConditionalOperatorNodeOutput
    {
        /// <summary>
        /// Default Value: conditional_operator
        /// </summary>
        /// <default>"conditional_operator"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "conditional_operator";

        /// <summary>
        /// Condition deciding which expression should be selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Condition2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Condition2 Condition { get; set; }

        /// <summary>
        /// Expression selected if the condition is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trueExpression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TrueExpression2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TrueExpression2 TrueExpression { get; set; }

        /// <summary>
        /// Expression selected if the condition is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("falseExpression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.FalseExpression2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.FalseExpression2 FalseExpression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTConditionalOperatorNodeOutput" /> class.
        /// </summary>
        /// <param name="condition">
        /// Condition deciding which expression should be selected.
        /// </param>
        /// <param name="trueExpression">
        /// Expression selected if the condition is true.
        /// </param>
        /// <param name="falseExpression">
        /// Expression selected if the condition is false.
        /// </param>
        /// <param name="type">
        /// Default Value: conditional_operator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTConditionalOperatorNodeOutput(
            global::ElevenLabs.Condition2 condition,
            global::ElevenLabs.TrueExpression2 trueExpression,
            global::ElevenLabs.FalseExpression2 falseExpression,
            string type = "conditional_operator")
        {
            this.Type = type;
            this.Condition = condition;
            this.TrueExpression = trueExpression;
            this.FalseExpression = falseExpression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTConditionalOperatorNodeOutput" /> class.
        /// </summary>
        public ASTConditionalOperatorNodeOutput()
        {
        }
    }
}