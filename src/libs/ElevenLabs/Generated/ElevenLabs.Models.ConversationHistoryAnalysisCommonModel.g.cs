
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryAnalysisCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_criteria_results")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? EvaluationCriteriaResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection_results")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DataCollectionResultCommonModel>? DataCollectionResults { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_successful")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.EvaluationSuccessResult CallSuccessful { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TranscriptSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryAnalysisCommonModel" /> class.
        /// </summary>
        /// <param name="evaluationCriteriaResults"></param>
        /// <param name="dataCollectionResults"></param>
        /// <param name="callSuccessful">
        /// An enumeration.
        /// </param>
        /// <param name="transcriptSummary"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ConversationHistoryAnalysisCommonModel(
            global::ElevenLabs.EvaluationSuccessResult callSuccessful,
            string transcriptSummary,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? evaluationCriteriaResults,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DataCollectionResultCommonModel>? dataCollectionResults)
        {
            this.CallSuccessful = callSuccessful;
            this.TranscriptSummary = transcriptSummary ?? throw new global::System.ArgumentNullException(nameof(transcriptSummary));
            this.EvaluationCriteriaResults = evaluationCriteriaResults;
            this.DataCollectionResults = dataCollectionResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryAnalysisCommonModel" /> class.
        /// </summary>
        public ConversationHistoryAnalysisCommonModel()
        {
        }
    }
}