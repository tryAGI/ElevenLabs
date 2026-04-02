#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Cancel A Batch Call.<br/>
        /// Cancel a running batch call and set all recipients to cancelled status.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.BatchCallResponse> CancelAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}