
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnitTestGuardrailTriggerEvaluationModel
    {
        /// <summary>
        /// Match any guardrail triggered by the generated turn.<br/>
        /// Default Value: any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestGuardrailTriggerEvaluationModel" /> class.
        /// </summary>
        /// <param name="type">
        /// Match any guardrail triggered by the generated turn.<br/>
        /// Default Value: any
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnitTestGuardrailTriggerEvaluationModel(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestGuardrailTriggerEvaluationModel" /> class.
        /// </summary>
        public UnitTestGuardrailTriggerEvaluationModel()
        {
        }

    }
}