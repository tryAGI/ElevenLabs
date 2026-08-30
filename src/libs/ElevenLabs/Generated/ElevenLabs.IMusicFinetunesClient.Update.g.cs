#nullable enable

namespace ElevenLabs
{
    public partial interface IMusicFinetunesClient
    {
        /// <summary>
        /// Update Music Finetune<br/>
        /// Update a music finetune.
        /// </summary>
        /// <param name="finetuneId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicFinetuneResponseModel> UpdateAsync(
            string finetuneId,

            global::ElevenLabs.UpdateMusicFinetuneRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Music Finetune<br/>
        /// Update a music finetune.
        /// </summary>
        /// <param name="finetuneId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MusicFinetuneResponseModel>> UpdateAsResponseAsync(
            string finetuneId,

            global::ElevenLabs.UpdateMusicFinetuneRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Music Finetune<br/>
        /// Update a music finetune.
        /// </summary>
        /// <param name="finetuneId"></param>
        /// <param name="name">
        /// Updated name for the finetune.
        /// </param>
        /// <param name="tags">
        /// Replacement set of tags.
        /// </param>
        /// <param name="primaryGenre">
        /// Updated primary musical genre.
        /// </param>
        /// <param name="visibility">
        /// Finetune visibility. Only 'private' and 'workspace' can be set.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicFinetuneResponseModel> UpdateAsync(
            string finetuneId,
            string? name = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? primaryGenre = default,
            global::ElevenLabs.UpdateMusicFinetuneRequestModelVisibility2? visibility = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}