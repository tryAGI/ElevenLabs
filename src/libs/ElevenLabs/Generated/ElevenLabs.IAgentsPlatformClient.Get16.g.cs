#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get A Batch Call By Id.<br/>
        /// Get detailed information about a batch call including all recipients.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.BatchCallDetailedResponse> Get16Async(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}