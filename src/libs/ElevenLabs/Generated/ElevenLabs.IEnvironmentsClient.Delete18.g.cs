#nullable enable

namespace ElevenLabs
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Delete Environment<br/>
        /// Delete a workspace environment and remove its values from all environment variables. 'production' cannot be deleted.
        /// </summary>
        /// <param name="environment">
        /// Name of the environment to delete, e.g. 'staging'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete18Async(
            string environment,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Environment<br/>
        /// Delete a workspace environment and remove its values from all environment variables. 'production' cannot be deleted.
        /// </summary>
        /// <param name="environment">
        /// Name of the environment to delete, e.g. 'staging'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse> Delete18AsResponseAsync(
            string environment,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}