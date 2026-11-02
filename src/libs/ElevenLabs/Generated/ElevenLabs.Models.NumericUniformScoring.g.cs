
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NumericUniformScoring
    {
        /// <summary>
        /// Default Value: numeric_uniform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxScore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericUniformScoring" /> class.
        /// </summary>
        /// <param name="maxScore"></param>
        /// <param name="mode">
        /// Default Value: numeric_uniform
        /// </param>
        /// <param name="instructions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumericUniformScoring(
            int maxScore,
            string? mode,
            string? instructions)
        {
            this.Mode = mode;
            this.MaxScore = maxScore;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericUniformScoring" /> class.
        /// </summary>
        public NumericUniformScoring()
        {
        }

    }
}