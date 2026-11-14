
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailLLMVerdict
    {
        /// <summary>
        /// Default Value: llm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The LLM's explanation for its decision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rationale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailLLMVerdict" /> class.
        /// </summary>
        /// <param name="rationale">
        /// The LLM's explanation for its decision.
        /// </param>
        /// <param name="type">
        /// Default Value: llm
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailLLMVerdict(
            string rationale,
            string? type)
        {
            this.Type = type;
            this.Rationale = rationale ?? throw new global::System.ArgumentNullException(nameof(rationale));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailLLMVerdict" /> class.
        /// </summary>
        public GuardrailLLMVerdict()
        {
        }

    }
}