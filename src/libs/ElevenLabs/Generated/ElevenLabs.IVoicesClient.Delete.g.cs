#nullable enable

namespace ElevenLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Delete Voice Collection<br/>
        /// Deletes a voice collection. The voices in it are not deleted. Requires admin access to the collection.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DeleteUserVoiceCollectionResponseModel> DeleteAsync(
            string collectionId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Voice Collection<br/>
        /// Deletes a voice collection. The voices in it are not deleted. Requires admin access to the collection.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.DeleteUserVoiceCollectionResponseModel>> DeleteAsResponseAsync(
            string collectionId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}