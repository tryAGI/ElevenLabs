#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextEvaluationClient
    {
        /// <summary>
        /// Get Evaluation
        /// </summary>
        /// <param name="evaluationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EvaluationResponse> GetSpeechToTextEvaluationEvaluationsByEvaluationIdAsync(
            string evaluationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}