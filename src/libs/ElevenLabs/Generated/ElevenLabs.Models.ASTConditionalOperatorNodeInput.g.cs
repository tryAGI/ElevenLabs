
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTConditionalOperatorNodeInput
    {
        /// <summary>
        /// Default Value: conditional_operator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Condition deciding which expression should be selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ASTNodeInput Condition { get; set; }

        /// <summary>
        /// Expression selected if the condition is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trueExpression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ASTNodeInput TrueExpression { get; set; }

        /// <summary>
        /// Expression selected if the condition is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("falseExpression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ASTNodeInput FalseExpression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTConditionalOperatorNodeInput" /> class.
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
        public ASTConditionalOperatorNodeInput(
            global::ElevenLabs.ASTNodeInput condition,
            global::ElevenLabs.ASTNodeInput trueExpression,
            global::ElevenLabs.ASTNodeInput falseExpression,
            string? type)
        {
            this.Type = type;
            this.Condition = condition;
            this.TrueExpression = trueExpression;
            this.FalseExpression = falseExpression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTConditionalOperatorNodeInput" /> class.
        /// </summary>
        public ASTConditionalOperatorNodeInput()
        {
        }

    }
}