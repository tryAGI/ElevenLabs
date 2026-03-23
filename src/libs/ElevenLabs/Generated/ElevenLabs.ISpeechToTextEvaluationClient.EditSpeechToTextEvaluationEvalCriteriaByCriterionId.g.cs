#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextEvaluationClient
    {
        /// <summary>
        /// Update Evaluation Criterion
        /// </summary>
        /// <param name="criterionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EvalCriterionResponse> EditSpeechToTextEvaluationEvalCriteriaByCriterionIdAsync(
            string criterionId,

            global::ElevenLabs.UpdateEvalCriterionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Evaluation Criterion
        /// </summary>
        /// <param name="criterionId"></param>
        /// <param name="name"></param>
        /// <param name="criteria"></param>
        /// <param name="dataExtractionConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EvalCriterionResponse> EditSpeechToTextEvaluationEvalCriteriaByCriterionIdAsync(
            string criterionId,
            string? name = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.CriterionItemRequest>? criteria = default,
            global::ElevenLabs.DataExtractionConfigRequestInput? dataExtractionConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}