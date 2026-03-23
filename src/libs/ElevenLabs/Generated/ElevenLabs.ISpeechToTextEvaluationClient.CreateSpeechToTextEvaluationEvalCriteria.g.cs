#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextEvaluationClient
    {
        /// <summary>
        /// Create Evaluation Criterion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EvalCriterionResponse> CreateSpeechToTextEvaluationEvalCriteriaAsync(

            global::ElevenLabs.CreateEvalCriterionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Evaluation Criterion
        /// </summary>
        /// <param name="name"></param>
        /// <param name="criteria"></param>
        /// <param name="dataExtractionConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EvalCriterionResponse> CreateSpeechToTextEvaluationEvalCriteriaAsync(
            string name,
            global::System.Collections.Generic.IList<global::ElevenLabs.CriterionItemRequest> criteria,
            global::ElevenLabs.DataExtractionConfigRequestInput? dataExtractionConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}