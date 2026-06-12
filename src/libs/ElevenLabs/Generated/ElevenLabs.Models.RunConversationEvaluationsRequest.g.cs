
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunConversationEvaluationsRequest
    {
        /// <summary>
        /// ID of the single evaluation criterion to rerun.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluationId { get; set; }

        /// <summary>
        /// Default Value: conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter))]
        public global::ElevenLabs.AnalysisScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunConversationEvaluationsRequest" /> class.
        /// </summary>
        /// <param name="evaluationId">
        /// ID of the single evaluation criterion to rerun.
        /// </param>
        /// <param name="scope">
        /// Default Value: conversation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunConversationEvaluationsRequest(
            string evaluationId,
            global::ElevenLabs.AnalysisScope? scope)
        {
            this.EvaluationId = evaluationId ?? throw new global::System.ArgumentNullException(nameof(evaluationId));
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunConversationEvaluationsRequest" /> class.
        /// </summary>
        public RunConversationEvaluationsRequest()
        {
        }

    }
}