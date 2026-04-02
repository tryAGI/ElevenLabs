#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Search User Groups<br/>
        /// Searches for user groups in the workspace. Multiple or no groups may be returned.
        /// </summary>
        /// <param name="name">
        /// Name of the target group.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupByNameResponseModel>> SearchAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}