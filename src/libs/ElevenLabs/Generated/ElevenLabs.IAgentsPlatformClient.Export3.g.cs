#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Export User Memory<br/>
        /// Get a copy of everything this agent remembers about an end user, to answer their request to access or take their data; each agent remembers its users separately. Conversations are not included; use the Get Conversation Details endpoint for those. Someone who reached you under identities that were never linked is a separate user for each.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ExportUserMemoryResponseModel> Export3Async(
            string agentId,

            global::ElevenLabs.ExportUserMemoryRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export User Memory<br/>
        /// Get a copy of everything this agent remembers about an end user, to answer their request to access or take their data; each agent remembers its users separately. Conversations are not included; use the Get Conversation Details endpoint for those. Someone who reached you under identities that were never linked is a separate user for each.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ExportUserMemoryResponseModel>> Export3AsResponseAsync(
            string agentId,

            global::ElevenLabs.ExportUserMemoryRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export User Memory<br/>
        /// Get a copy of everything this agent remembers about an end user, to answer their request to access or take their data; each agent remembers its users separately. Conversations are not included; use the Get Conversation Details endpoint for those. Someone who reached you under identities that were never linked is a separate user for each.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent.
        /// </param>
        /// <param name="userId">
        /// ID of the end user whose memory the agent is to export. Find it from the `user_id` your conversation initiation data sent with Find Agents User By Identity.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ExportUserMemoryResponseModel> Export3Async(
            string agentId,
            string userId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}