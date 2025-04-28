
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMInputOutputTokensUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::ElevenLabs.LLMTokensCategoryUsage? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        public global::ElevenLabs.LLMTokensCategoryUsage? InputCacheRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write")]
        public global::ElevenLabs.LLMTokensCategoryUsage? InputCacheWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_total")]
        public global::ElevenLabs.LLMTokensCategoryUsage? OutputTotal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMInputOutputTokensUsage" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="inputCacheRead"></param>
        /// <param name="inputCacheWrite"></param>
        /// <param name="outputTotal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMInputOutputTokensUsage(
            global::ElevenLabs.LLMTokensCategoryUsage? input,
            global::ElevenLabs.LLMTokensCategoryUsage? inputCacheRead,
            global::ElevenLabs.LLMTokensCategoryUsage? inputCacheWrite,
            global::ElevenLabs.LLMTokensCategoryUsage? outputTotal)
        {
            this.Input = input;
            this.InputCacheRead = inputCacheRead;
            this.InputCacheWrite = inputCacheWrite;
            this.OutputTotal = outputTotal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMInputOutputTokensUsage" /> class.
        /// </summary>
        public LLMInputOutputTokensUsage()
        {
        }
    }
}