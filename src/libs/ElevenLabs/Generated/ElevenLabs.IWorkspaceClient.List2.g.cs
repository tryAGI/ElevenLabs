#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Get Workspace Auth Connections<br/>
        /// Get all auth connections for the workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ListAuthConnectionsResponse> List2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}