#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Get Share Options<br/>
        /// Get the share options for a workspace.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ElevenLabs.ShareOptionResponseModel>> GetWorkspaceShareOptionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}