
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMParameterEvaluationStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.LLMParameterEvaluationStrategyTypeJsonConverter))]
        public global::ElevenLabs.LLMParameterEvaluationStrategyType Type { get; set; }

        /// <summary>
        /// A description of the evaluation strategy to use for the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMParameterEvaluationStrategy" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="description">
        /// A description of the evaluation strategy to use for the test.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMParameterEvaluationStrategy(
            string description,
            global::ElevenLabs.LLMParameterEvaluationStrategyType type)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMParameterEvaluationStrategy" /> class.
        /// </summary>
        public LLMParameterEvaluationStrategy()
        {
        }
    }
}