#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextEvaluationClient
    {
        /// <summary>
        /// List Evaluation Criteria
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ElevenLabs.EvalCriterionResponse>> GetSpeechToTextEvaluationEvalCriteriaAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}