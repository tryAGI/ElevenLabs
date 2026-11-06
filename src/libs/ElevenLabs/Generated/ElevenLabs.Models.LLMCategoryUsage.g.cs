
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// LLM usage of a conversation, split by whether the generated response reached the user.
    /// </summary>
    public sealed partial class LLMCategoryUsage
    {
        /// <summary>
        /// Subset of `initiated_generation`: usage of agent turns whose audio had started playing to the user, whether the turn then completed or was interrupted. A turn the user interrupted while the LLM was still generating, or that was cut off by the call ending, can be missing here even if part of it was heard. Informational; LLM charges are based on `initiated_generation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("irreversible_generation")]
        public global::ElevenLabs.LLMUsageOutput? IrreversibleGeneration { get; set; }

        /// <summary>
        /// Usage of every LLM call made during the conversation: turns the user heard, turns the user interrupted, and speculative turns that were started and dropped before any audio was sent. LLM charges are based on this block; its prices sum to `llm_price`. Always greater than or equal to `irreversible_generation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initiated_generation")]
        public global::ElevenLabs.LLMUsageOutput? InitiatedGeneration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMCategoryUsage" /> class.
        /// </summary>
        /// <param name="irreversibleGeneration">
        /// Subset of `initiated_generation`: usage of agent turns whose audio had started playing to the user, whether the turn then completed or was interrupted. A turn the user interrupted while the LLM was still generating, or that was cut off by the call ending, can be missing here even if part of it was heard. Informational; LLM charges are based on `initiated_generation`.
        /// </param>
        /// <param name="initiatedGeneration">
        /// Usage of every LLM call made during the conversation: turns the user heard, turns the user interrupted, and speculative turns that were started and dropped before any audio was sent. LLM charges are based on this block; its prices sum to `llm_price`. Always greater than or equal to `irreversible_generation`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMCategoryUsage(
            global::ElevenLabs.LLMUsageOutput? irreversibleGeneration,
            global::ElevenLabs.LLMUsageOutput? initiatedGeneration)
        {
            this.IrreversibleGeneration = irreversibleGeneration;
            this.InitiatedGeneration = initiatedGeneration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMCategoryUsage" /> class.
        /// </summary>
        public LLMCategoryUsage()
        {
        }

    }
}