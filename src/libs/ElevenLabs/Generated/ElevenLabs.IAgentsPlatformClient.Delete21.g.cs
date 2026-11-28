#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete User Memory Entity<br/>
        /// Delete a person, place or thing this agent remembers from an end user's conversations, together with everything it remembers about it. The agent may learn about it again from later conversations. It still reads the user's recent conversations verbatim, so it can come across it there until those conversations are erased with Erase User Memory or deleted with Delete Conversation.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent.
        /// </param>
        /// <param name="entityId">
        /// ID of the entity, as listed by Export User Memory.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete21Async(
            string agentId,
            string entityId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete User Memory Entity<br/>
        /// Delete a person, place or thing this agent remembers from an end user's conversations, together with everything it remembers about it. The agent may learn about it again from later conversations. It still reads the user's recent conversations verbatim, so it can come across it there until those conversations are erased with Erase User Memory or deleted with Delete Conversation.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent.
        /// </param>
        /// <param name="entityId">
        /// ID of the entity, as listed by Export User Memory.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse> Delete21AsResponseAsync(
            string agentId,
            string entityId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}