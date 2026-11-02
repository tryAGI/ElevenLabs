#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete Analysis Item<br/>
        /// Delete an analysis item and all of its versions from the workspace.
        /// </summary>
        /// <param name="analysisItemId">
        /// ID of the requested analysis item.
        /// </param>
        /// <param name="force">
        /// If set to true, the analysis item will be deleted regardless of whether it is used by any agents and it will be removed from the dependent agents and branches.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Delete10Async(
            string analysisItemId,
            bool? force = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Analysis Item<br/>
        /// Delete an analysis item and all of its versions from the workspace.
        /// </summary>
        /// <param name="analysisItemId">
        /// ID of the requested analysis item.
        /// </param>
        /// <param name="force">
        /// If set to true, the analysis item will be deleted regardless of whether it is used by any agents and it will be removed from the dependent agents and branches.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<string>> Delete10AsResponseAsync(
            string analysisItemId,
            bool? force = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}