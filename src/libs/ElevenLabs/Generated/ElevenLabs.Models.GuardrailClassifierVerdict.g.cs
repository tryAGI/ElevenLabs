
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailClassifierVerdict
    {
        /// <summary>
        /// Default Value: classifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Classifier score for the triggered category, from 0 to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Score at or above which the guardrail triggers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailClassifierVerdict" /> class.
        /// </summary>
        /// <param name="score">
        /// Classifier score for the triggered category, from 0 to 1.
        /// </param>
        /// <param name="threshold">
        /// Score at or above which the guardrail triggers.
        /// </param>
        /// <param name="type">
        /// Default Value: classifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailClassifierVerdict(
            double score,
            double threshold,
            string? type)
        {
            this.Type = type;
            this.Score = score;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailClassifierVerdict" /> class.
        /// </summary>
        public GuardrailClassifierVerdict()
        {
        }

    }
}