
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LLMInputOutputTokensUsage
    {
        /// <summary>
        /// Input (prompt) tokens not served from the prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::ElevenLabs.LLMTokensCategoryUsage? Input { get; set; }

        /// <summary>
        /// Input tokens read from the prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        public global::ElevenLabs.LLMTokensCategoryUsage? InputCacheRead { get; set; }

        /// <summary>
        /// Input tokens written to the prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write")]
        public global::ElevenLabs.LLMTokensCategoryUsage? InputCacheWrite { get; set; }

        /// <summary>
        /// Output (completion) tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_total")]
        public global::ElevenLabs.LLMTokensCategoryUsage? OutputTotal { get; set; }

        /// <summary>
        /// Subset of `output_total` spent on reasoning, when the provider reports it. Informational; already charged as part of `output_total`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_total_reasoning_portion")]
        public global::ElevenLabs.LLMTokensCategoryUsage? OutputTotalReasoningPortion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMInputOutputTokensUsage" /> class.
        /// </summary>
        /// <param name="input">
        /// Input (prompt) tokens not served from the prompt cache.
        /// </param>
        /// <param name="inputCacheRead">
        /// Input tokens read from the prompt cache.
        /// </param>
        /// <param name="inputCacheWrite">
        /// Input tokens written to the prompt cache.
        /// </param>
        /// <param name="outputTotal">
        /// Output (completion) tokens.
        /// </param>
        /// <param name="outputTotalReasoningPortion">
        /// Subset of `output_total` spent on reasoning, when the provider reports it. Informational; already charged as part of `output_total`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMInputOutputTokensUsage(
            global::ElevenLabs.LLMTokensCategoryUsage? input,
            global::ElevenLabs.LLMTokensCategoryUsage? inputCacheRead,
            global::ElevenLabs.LLMTokensCategoryUsage? inputCacheWrite,
            global::ElevenLabs.LLMTokensCategoryUsage? outputTotal,
            global::ElevenLabs.LLMTokensCategoryUsage? outputTotalReasoningPortion)
        {
            this.Input = input;
            this.InputCacheRead = inputCacheRead;
            this.InputCacheWrite = inputCacheWrite;
            this.OutputTotal = outputTotal;
            this.OutputTotalReasoningPortion = outputTotalReasoningPortion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMInputOutputTokensUsage" /> class.
        /// </summary>
        public LLMInputOutputTokensUsage()
        {
        }

    }
}