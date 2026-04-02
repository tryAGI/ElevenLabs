#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Get All Groups<br/>
        /// Get all groups in the workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkspaceGroupResponseModel>> List4Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}