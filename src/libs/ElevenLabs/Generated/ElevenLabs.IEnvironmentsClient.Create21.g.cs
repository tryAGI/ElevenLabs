#nullable enable

namespace ElevenLabs
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Create Environment<br/>
        /// Create a workspace environment. Variables without a value for it fall back to their production value.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EnvironmentResponse> Create21Async(

            global::ElevenLabs.CreateEnvironmentRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Environment<br/>
        /// Create a workspace environment. Variables without a value for it fall back to their production value.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.EnvironmentResponse>> Create21AsResponseAsync(

            global::ElevenLabs.CreateEnvironmentRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Environment<br/>
        /// Create a workspace environment. Variables without a value for it fall back to their production value.
        /// </summary>
        /// <param name="name">
        /// Unique name of the environment, e.g. 'staging'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EnvironmentResponse> Create21Async(
            string name,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}