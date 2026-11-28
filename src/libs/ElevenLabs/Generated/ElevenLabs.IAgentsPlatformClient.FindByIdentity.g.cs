#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Find Agents User By Identity<br/>
        /// The end user an active identity belongs to in the caller's workspace, e.g. the `user_id` your conversation initiation data sent for them. Use the returned `user_id` with Erase User Memory or Export User Memory. Never creates a user or identity.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.FindAgentsUserByIdentityResponseModel> FindByIdentityAsync(

            global::ElevenLabs.FindAgentsUserByIdentityRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find Agents User By Identity<br/>
        /// The end user an active identity belongs to in the caller's workspace, e.g. the `user_id` your conversation initiation data sent for them. Use the returned `user_id` with Erase User Memory or Export User Memory. Never creates a user or identity.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.FindAgentsUserByIdentityResponseModel>> FindByIdentityAsResponseAsync(

            global::ElevenLabs.FindAgentsUserByIdentityRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find Agents User By Identity<br/>
        /// The end user an active identity belongs to in the caller's workspace, e.g. the `user_id` your conversation initiation data sent for them. Use the returned `user_id` with Erase User Memory or Export User Memory. Never creates a user or identity.
        /// </summary>
        /// <param name="namespace">
        /// Namespace of the identity, e.g. `external` for the `user_id` a conversation initiation webhook or API request gave, or `email`.<br/>
        /// Default Value: external
        /// </param>
        /// <param name="value">
        /// Value of the identity.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.FindAgentsUserByIdentityResponseModel> FindByIdentityAsync(
            string value,
            string? @namespace = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}