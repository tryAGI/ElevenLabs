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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Delete2Async(
            string authConnectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}