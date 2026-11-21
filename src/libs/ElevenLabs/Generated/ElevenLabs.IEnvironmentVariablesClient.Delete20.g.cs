#nullable enable

namespace ElevenLabs
{
    public partial interface IEnvironmentVariablesClient
    {
        /// <summary>
        /// Delete Environment Variable<br/>
        /// Delete an environment variable and its values in all environments. The delete is rejected while the latest version of an unarchived agent branch, a tool, an MCP server or the workspace conversation initiation webhook uses the variable. Archived branches and earlier versions are not checked.
        /// </summary>
        /// <param name="envVarId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete20Async(
            string envVarId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Environment Variable<br/>
        /// Delete an environment variable and its values in all environments. The delete is rejected while the latest version of an unarchived agent branch, a tool, an MCP server or the workspace conversation initiation webhook uses the variable. Archived branches and earlier versions are not checked.
        /// </summary>
        /// <param name="envVarId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse> Delete20AsResponseAsync(
            string envVarId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}