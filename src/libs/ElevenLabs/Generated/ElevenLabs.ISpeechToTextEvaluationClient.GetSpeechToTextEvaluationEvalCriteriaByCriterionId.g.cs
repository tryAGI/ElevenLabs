#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextEvaluationClient
    {
        /// <summary>
        /// Get Evaluation Criterion
        /// </summary>
        /// <param name="criterionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EvalCriterionResponse> GetSpeechToTextEvaluationEvalCriteriaByCriterionIdAsync(
            string criterionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}