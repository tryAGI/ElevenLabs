#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Get Service Account Api Keys Route<br/>
        /// Get all API keys for a service account
        /// </summary>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceApiKeyListResponseModel> ListAsync(
            string serviceAccountUserId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}