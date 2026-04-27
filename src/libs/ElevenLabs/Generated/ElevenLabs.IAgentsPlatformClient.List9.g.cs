#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Convai Workspace Secrets<br/>
        /// Get all workspace secrets for the user
        /// </summary>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100. If not provided, returns all secrets.
        /// </param>
        /// <param name="dependencyLimit">
        /// Maximum number of dependent resources (tools, agents, phone numbers) to return per secret. Can not exceed 100.
        /// </param>
        /// <param name="search">
        /// If specified, returns only secrets whose names start with this string.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetWorkspaceSecretsResponseModel> List9Async(
            int? pageSize = default,
            int? dependencyLimit = default,
            string? search = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}