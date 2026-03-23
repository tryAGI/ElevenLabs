#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextEvaluationClient
    {
        /// <summary>
        /// Trigger Evaluation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EvaluationResponse> CreateSpeechToTextEvaluationEvaluationsAsync(

            global::ElevenLabs.TriggerEvaluationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Evaluation
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="agentId"></param>
        /// <param name="evalCriterionId"></param>
        /// <param name="labels"></param>
        /// <param name="agentName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EvaluationResponse> CreateSpeechToTextEvaluationEvaluationsAsync(
            string transcriptId,
            string agentId,
            string evalCriterionId,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            string? agentName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}