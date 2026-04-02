#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Get Workspace Service Accounts<br/>
        /// List all service accounts in the workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceServiceAccountListResponseModel> List3Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}