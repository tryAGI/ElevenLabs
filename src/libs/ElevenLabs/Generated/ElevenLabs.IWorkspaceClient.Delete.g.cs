#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Delete Service Account Api Key<br/>
        /// Delete an existing API key for a service account
        /// </summary>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string serviceAccountUserId,
            string apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}