#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Delete Workspace Auth Connection<br/>
        /// Delete an auth connection
        /// </summary>
        /// <param name="authConnectionId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteWorkspaceAuthConnectionsByAuthConnectionIdAsync(
            string authConnectionId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}