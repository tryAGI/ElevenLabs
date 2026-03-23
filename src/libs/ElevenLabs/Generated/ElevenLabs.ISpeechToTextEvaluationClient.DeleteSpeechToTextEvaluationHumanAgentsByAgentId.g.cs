#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextEvaluationClient
    {
        /// <summary>
        /// Delete Human Agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteSpeechToTextEvaluationHumanAgentsByAgentIdAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}