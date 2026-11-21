
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TriggeredGuardrailCommonModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GuardrailTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.GuardrailType GuardrailType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_name")]
        public string? GuardrailName { get; set; }

        /// <summary>
        /// `blocking` if the agent's response waited for the guardrail, `streaming` if the guardrail ran while the response was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        public global::ElevenLabs.GuardrailExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// Why the guardrail triggered: the LLM's rationale for custom guardrails, or the score and threshold for moderation and content guardrails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_details")]
        public global::ElevenLabs.OneOf<global::ElevenLabs.GuardrailLLMVerdict, global::ElevenLabs.GuardrailClassifierVerdict, global::ElevenLabs.GuardrailUnknownVerdict>? GuardrailDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggeredGuardrailCommonModel" /> class.
        /// </summary>
        /// <param name="guardrailType"></param>
        /// <param name="guardrailName"></param>
        /// <param name="executionMode">
        /// `blocking` if the agent's response waited for the guardrail, `streaming` if the guardrail ran while the response was sent.
        /// </param>
        /// <param name="guardrailDetails">
        /// Why the guardrail triggered: the LLM's rationale for custom guardrails, or the score and threshold for moderation and content guardrails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggeredGuardrailCommonModel(
            global::ElevenLabs.GuardrailType guardrailType,
            string? guardrailName,
            global::ElevenLabs.GuardrailExecutionMode? executionMode,
            global::ElevenLabs.OneOf<global::ElevenLabs.GuardrailLLMVerdict, global::ElevenLabs.GuardrailClassifierVerdict, global::ElevenLabs.GuardrailUnknownVerdict>? guardrailDetails)
        {
            this.GuardrailType = guardrailType;
            this.GuardrailName = guardrailName;
            this.ExecutionMode = executionMode;
            this.GuardrailDetails = guardrailDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggeredGuardrailCommonModel" /> class.
        /// </summary>
        public TriggeredGuardrailCommonModel()
        {
        }

    }
}