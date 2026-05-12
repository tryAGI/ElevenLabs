#nullable enable

namespace ElevenLabs
{
    public partial interface IEnvironmentVariablesClient
    {
        /// <summary>
        /// Get Environment Variable<br/>
        /// Get a specific environment variable by ID
        /// </summary>
        /// <param name="envVarId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EnvironmentVariableResponse> Get25Async(
            string envVarId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Environment Variable<br/>
        /// Get a specific environment variable by ID
        /// </summary>
        /// <param name="envVarId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.EnvironmentVariableResponse>> Get25AsResponseAsync(
            string envVarId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}