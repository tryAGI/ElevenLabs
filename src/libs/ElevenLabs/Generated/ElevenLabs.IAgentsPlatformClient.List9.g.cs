#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get All Batch Calls For A Workspace.<br/>
        /// Get all batch calls for the current workspace.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="lastDoc"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceBatchCallsResponse> List9Async(
            int? limit = default,
            string? lastDoc = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}