#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Update Member Usage Limit<br/>
        /// Sets or clears the monthly credit usage limit of a workspace member or service account. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="userId">
        /// User ID of the target user.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpdateMemberUsageLimitResponseModel> UpdateUsageLimitAsync(
            string userId,

            global::ElevenLabs.UpdateMemberUsageLimitRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Member Usage Limit<br/>
        /// Sets or clears the monthly credit usage limit of a workspace member or service account. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="userId">
        /// User ID of the target user.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.UpdateMemberUsageLimitResponseModel>> UpdateUsageLimitAsResponseAsync(
            string userId,

            global::ElevenLabs.UpdateMemberUsageLimitRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Member Usage Limit<br/>
        /// Sets or clears the monthly credit usage limit of a workspace member or service account. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="userId">
        /// User ID of the target user.
        /// </param>
        /// <param name="usageLimit">
        /// Monthly credit usage limit for the member. Set to null to remove the limit.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpdateMemberUsageLimitResponseModel> UpdateUsageLimitAsync(
            string userId,
            int? usageLimit = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}