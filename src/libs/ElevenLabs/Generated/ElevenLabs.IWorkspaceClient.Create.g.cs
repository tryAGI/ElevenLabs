#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Create Service Account Api Key<br/>
        /// Create a new API key for a service account
        /// </summary>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceCreateApiKeyResponseModel> CreateAsync(
            string serviceAccountUserId,

            global::ElevenLabs.BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Service Account Api Key<br/>
        /// Create a new API key for a service account
        /// </summary>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="name"></param>
        /// <param name="permissions">
        /// The permissions of the XI API.
        /// </param>
        /// <param name="characterLimit">
        /// The character limit of the XI API key. If provided this will limit the usage of this api key to n characters per month where n is the chosen value. Requests that incur charges will fail after reaching this monthly limit.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceCreateApiKeyResponseModel> CreateAsync(
            string serviceAccountUserId,
            string name,
            global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string> permissions,
            int? characterLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}