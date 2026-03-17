#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Environment Variables<br/>
        /// List all environment variables for the workspace with optional filtering
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor from previous response
        /// </param>
        /// <param name="pageSize">
        /// Number of items to return (1-100)<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="label">
        /// Filter by exact label match
        /// </param>
        /// <param name="environment">
        /// Filter to only return variables that have this environment. When specified, the values dict in the response will only contain this environment.
        /// </param>
        /// <param name="type">
        /// Filter by variable type
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EnvironmentVariablesListResponse> GetConvaiEnvironmentVariablesAsync(
            string? cursor = default,
            int? pageSize = default,
            string? label = default,
            string? environment = default,
            global::ElevenLabs.ListEnvironmentVariablesType2? type = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}