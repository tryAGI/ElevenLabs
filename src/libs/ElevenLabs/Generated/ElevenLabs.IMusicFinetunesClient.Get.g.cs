#nullable enable

namespace ElevenLabs
{
    public partial interface IMusicFinetunesClient
    {
        /// <summary>
        /// Get Music Finetune<br/>
        /// Get a music finetune.
        /// </summary>
        /// <param name="finetuneId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicFinetuneResponseModel> GetAsync(
            string finetuneId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Music Finetune<br/>
        /// Get a music finetune.
        /// </summary>
        /// <param name="finetuneId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MusicFinetuneResponseModel>> GetAsResponseAsync(
            string finetuneId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}