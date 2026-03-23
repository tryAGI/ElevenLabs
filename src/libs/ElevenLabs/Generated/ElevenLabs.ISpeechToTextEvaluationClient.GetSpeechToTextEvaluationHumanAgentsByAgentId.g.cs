#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextEvaluationClient
    {
        /// <summary>
        /// Get Human Agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.HumanAgentResponse> GetSpeechToTextEvaluationHumanAgentsByAgentIdAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}