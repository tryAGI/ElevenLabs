
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnitTestToolCallEvaluationModelInput
    {
        /// <summary>
        /// Parameters to evaluate for the agent's tool call. If empty, the tool call parameters are not evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestToolCallParameter>? Parameters { get; set; }

        /// <summary>
        /// Reference to a tool for unit test evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenced_tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferencedToolCommonModel ReferencedTool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestToolCallEvaluationModelInput" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Parameters to evaluate for the agent's tool call. If empty, the tool call parameters are not evaluated.
        /// </param>
        /// <param name="referencedTool">
        /// Reference to a tool for unit test evaluation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnitTestToolCallEvaluationModelInput(
            global::ElevenLabs.ReferencedToolCommonModel referencedTool,
            global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestToolCallParameter>? parameters)
        {
            this.ReferencedTool = referencedTool ?? throw new global::System.ArgumentNullException(nameof(referencedTool));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestToolCallEvaluationModelInput" /> class.
        /// </summary>
        public UnitTestToolCallEvaluationModelInput()
        {
        }
    }
}