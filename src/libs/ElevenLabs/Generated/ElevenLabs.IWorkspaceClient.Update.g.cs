#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Edit Service Account Api Key<br/>
        /// Update an existing API key for a service account
        /// </summary>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAsync(
            string serviceAccountUserId,
            string apiKeyId,

            global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Service Account Api Key<br/>
        /// Update an existing API key for a service account
        /// </summary>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="isEnabled">
        /// Whether to enable or disable the API key.
        /// </param>
        /// <param name="name">
        /// The name of the XI API key to use (used for identification purposes only).
        /// </param>
        /// <param name="permissions">
        /// The permissions of the XI API.
        /// </param>
        /// <param name="characterLimit">
        /// The character limit of the XI API key. If provided this will limit the usage of this api key to n characters per month where n is the chosen value. Requests that incur charges will fail after reaching this monthly limit.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAsync(
            string serviceAccountUserId,
            string apiKeyId,
            bool isEnabled,
            string name,
            global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string> permissions,
            int? characterLimit = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}