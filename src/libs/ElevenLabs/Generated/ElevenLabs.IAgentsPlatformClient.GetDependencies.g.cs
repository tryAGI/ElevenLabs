#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Secret Dependencies By Type<br/>
        /// Get paginated list of resources that depend on a specific secret, filtered by resource type.
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="resourceType"></param>
        /// <param name="pageSize">
        /// How many dependency items to return per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetSecretDependenciesResponseModel> GetDependenciesAsync(
            string secretId,
            global::ElevenLabs.SecretDependencyResourceType resourceType,
            int? pageSize = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}