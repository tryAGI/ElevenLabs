#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Get Resource<br/>
        /// Gets the metadata of a resource by ID.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the target resource.
        /// </param>
        /// <param name="resourceType">
        /// Resource type of the target resource.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ResourceMetadataResponseModel> GetAsync(
            string resourceId,
            global::ElevenLabs.WorkspaceResourceType resourceType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}