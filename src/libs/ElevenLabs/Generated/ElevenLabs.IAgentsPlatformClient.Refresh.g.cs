#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Refresh Url Document Content<br/>
        /// Manually refresh a URL document by re-fetching its content from the source URL.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RefreshUrlDocumentRouteResponse> RefreshAsync(
            string documentationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}