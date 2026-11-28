#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete User Memory Fact<br/>
        /// Delete one thing this agent remembers about an end user, e.g. because it is wrong. Earlier and later values of the same fact are kept and listed separately in Export User Memory. The agent still reads the user's recent conversations verbatim, so it can come across it there until those conversations are erased with Erase User Memory or deleted with Delete Conversation.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent.
        /// </param>
        /// <param name="factId">
        /// ID of the fact, as listed by Export User Memory.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete20Async(
            string agentId,
            string factId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete User Memory Fact<br/>
        /// Delete one thing this agent remembers about an end user, e.g. because it is wrong. Earlier and later values of the same fact are kept and listed separately in Export User Memory. The agent still reads the user's recent conversations verbatim, so it can come across it there until those conversations are erased with Erase User Memory or deleted with Delete Conversation.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent.
        /// </param>
        /// <param name="factId">
        /// ID of the fact, as listed by Export User Memory.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse> Delete20AsResponseAsync(
            string agentId,
            string factId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}