#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Document Content<br/>
        /// Get the entire content of a document from the knowledge base
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetContentAsync(
            string documentationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}