#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Knowledge Base Summaries By Ids<br/>
        /// Gets multiple knowledge base document summaries by their IDs.
        /// </summary>
        /// <param name="documentIds">
        /// The ids of knowledge base documents.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Get10Async(
            global::System.Collections.Generic.IList<string> documentIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}