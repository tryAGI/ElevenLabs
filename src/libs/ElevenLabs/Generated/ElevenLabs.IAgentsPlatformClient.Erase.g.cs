#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Erase User Memory<br/>
        /// Erase what this agent remembers about an end user: it stops drawing on their earlier conversations, and what it learned from them is deleted. With `opt_out`, it also stops remembering them in future ones. Other agents' memories of the user are kept. The conversations themselves are not deleted; use the Delete Conversation endpoint for that.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EraseUserMemoryResponseModel> EraseAsync(
            string agentId,

            global::ElevenLabs.EraseUserMemoryRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Erase User Memory<br/>
        /// Erase what this agent remembers about an end user: it stops drawing on their earlier conversations, and what it learned from them is deleted. With `opt_out`, it also stops remembering them in future ones. Other agents' memories of the user are kept. The conversations themselves are not deleted; use the Delete Conversation endpoint for that.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.EraseUserMemoryResponseModel>> EraseAsResponseAsync(
            string agentId,

            global::ElevenLabs.EraseUserMemoryRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Erase User Memory<br/>
        /// Erase what this agent remembers about an end user: it stops drawing on their earlier conversations, and what it learned from them is deleted. With `opt_out`, it also stops remembering them in future ones. Other agents' memories of the user are kept. The conversations themselves are not deleted; use the Delete Conversation endpoint for that.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent.
        /// </param>
        /// <param name="userId">
        /// ID of the end user whose memory the agent is to erase. Find it from the `user_id` your conversation initiation data sent with Find Agents User By Identity.
        /// </param>
        /// <param name="optOut">
        /// True turns the agent's memory off for this user in future conversations, false turns it back on. Left out, the user's current setting is kept.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EraseUserMemoryResponseModel> EraseAsync(
            string agentId,
            string userId,
            bool? optOut = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}