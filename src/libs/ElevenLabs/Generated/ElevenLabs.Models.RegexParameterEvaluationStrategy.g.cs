
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegexParameterEvaluationStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RegexParameterEvaluationStrategyTypeJsonConverter))]
        public global::ElevenLabs.RegexParameterEvaluationStrategyType Type { get; set; }

        /// <summary>
        /// A regex pattern to match the agent's response against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexParameterEvaluationStrategy" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pattern">
        /// A regex pattern to match the agent's response against.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegexParameterEvaluationStrategy(
            string pattern,
            global::ElevenLabs.RegexParameterEvaluationStrategyType type)
        {
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexParameterEvaluationStrategy" /> class.
        /// </summary>
        public RegexParameterEvaluationStrategy()
        {
        }
    }
}