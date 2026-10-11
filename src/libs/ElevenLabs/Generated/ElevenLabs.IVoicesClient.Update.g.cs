#nullable enable

namespace ElevenLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Update Voice Collection<br/>
        /// Updates the title and icon of a voice collection. Fields that are omitted are left unchanged. Requires editor access to the collection.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UserVoiceCollectionResponseModel> UpdateAsync(
            string collectionId,

            global::ElevenLabs.BodyUpdateVoiceCollectionV1VoicesCollectionsCollectionIdPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Voice Collection<br/>
        /// Updates the title and icon of a voice collection. Fields that are omitted are left unchanged. Requires editor access to the collection.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.UserVoiceCollectionResponseModel>> UpdateAsResponseAsync(
            string collectionId,

            global::ElevenLabs.BodyUpdateVoiceCollectionV1VoicesCollectionsCollectionIdPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Voice Collection<br/>
        /// Updates the title and icon of a voice collection. Fields that are omitted are left unchanged. Requires editor access to the collection.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID.
        /// </param>
        /// <param name="title">
        /// Title of the collection to create/update.
        /// </param>
        /// <param name="icon">
        /// Icon of the collection to create/update.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UserVoiceCollectionResponseModel> UpdateAsync(
            string collectionId,
            string? title = default,
            string? icon = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}