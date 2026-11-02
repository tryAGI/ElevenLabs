
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserEvaluationAnalysisItemScoringDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UserEvaluationAnalysisItemScoringDiscriminatorModeJsonConverter))]
        public global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminatorMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEvaluationAnalysisItemScoringDiscriminator" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEvaluationAnalysisItemScoringDiscriminator(
            global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminatorMode? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEvaluationAnalysisItemScoringDiscriminator" /> class.
        /// </summary>
        public UserEvaluationAnalysisItemScoringDiscriminator()
        {
        }

    }
}