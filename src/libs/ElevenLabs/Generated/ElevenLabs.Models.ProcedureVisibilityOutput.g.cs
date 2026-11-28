
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProcedureVisibilityOutput
    {
        /// <summary>
        /// Condition on dynamic variables. The procedure is visible to the agent in its procedure menu only while this evaluates to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ASTNodeOutput Expression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureVisibilityOutput" /> class.
        /// </summary>
        /// <param name="expression">
        /// Condition on dynamic variables. The procedure is visible to the agent in its procedure menu only while this evaluates to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcedureVisibilityOutput(
            global::ElevenLabs.ASTNodeOutput expression)
        {
            this.Expression = expression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcedureVisibilityOutput" /> class.
        /// </summary>
        public ProcedureVisibilityOutput()
        {
        }

    }
}