#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Revoke Api Key<br/>
        /// Revoke the API key used to authenticate this request. Requires the query parameter `api_key_name=self` as an explicit confirmation. This endpoint requires additional permissions and is not enabled by default. Reach out to your ElevenLabs contact to request access.
        /// </summary>
        /// <param name="apiKeyName">
        /// Must be set to `self` to revoke the API key used to authenticate this request. Required as an explicit confirmation to avoid accidental revocation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RevokeAsync(
            string apiKeyName,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke Api Key<br/>
        /// Revoke the API key used to authenticate this request. Requires the query parameter `api_key_name=self` as an explicit confirmation. This endpoint requires additional permissions and is not enabled by default. Reach out to your ElevenLabs contact to request access.
        /// </summary>
        /// <param name="apiKeyName">
        /// Must be set to `self` to revoke the API key used to authenticate this request. Required as an explicit confirmation to avoid accidental revocation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<string>> RevokeAsResponseAsync(
            string apiKeyName,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}