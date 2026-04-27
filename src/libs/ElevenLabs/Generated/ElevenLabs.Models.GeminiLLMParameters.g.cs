
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Parameters for Gemini LLM text generation. Provider/model info is on ModelRegistryEntry.
    /// </summary>
    public sealed partial class GeminiLLMParameters
    {
        /// <summary>
        /// System-level instruction that guides the model's behavior and output style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_instruction")]
        public string? SystemInstruction { get; set; }

        /// <summary>
        /// Controls randomness: 0.0 is deterministic, 2.0 is maximum randomness.<br/>
        /// Default Value: 0.7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Thinking token budget. None=automatic, 0=disabled, &gt;0=custom. Not supported on all models (e.g. gemini-2.5-flash-lite-llm).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_budget")]
        public int? ThinkingBudget { get; set; }

        /// <summary>
        /// Maximum tokens in the response. None for model default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Multipart prompt combining text and image/text references for richer context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_parts")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.PromptPartsItem>? PromptParts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiLLMParameters" /> class.
        /// </summary>
        /// <param name="systemInstruction">
        /// System-level instruction that guides the model's behavior and output style.
        /// </param>
        /// <param name="temperature">
        /// Controls randomness: 0.0 is deterministic, 2.0 is maximum randomness.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="thinkingBudget">
        /// Thinking token budget. None=automatic, 0=disabled, &gt;0=custom. Not supported on all models (e.g. gemini-2.5-flash-lite-llm).
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum tokens in the response. None for model default.
        /// </param>
        /// <param name="promptParts">
        /// Multipart prompt combining text and image/text references for richer context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeminiLLMParameters(
            string? systemInstruction,
            double? temperature,
            int? thinkingBudget,
            int? maxOutputTokens,
            global::System.Collections.Generic.IList<global::ElevenLabs.PromptPartsItem>? promptParts)
        {
            this.SystemInstruction = systemInstruction;
            this.Temperature = temperature;
            this.ThinkingBudget = thinkingBudget;
            this.MaxOutputTokens = maxOutputTokens;
            this.PromptParts = promptParts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiLLMParameters" /> class.
        /// </summary>
        public GeminiLLMParameters()
        {
        }
    }
}