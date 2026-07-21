#nullable enable

namespace ElevenLabs
{
    public partial interface IMusicFinetunesClient
    {
        /// <summary>
        /// Create Music Finetune<br/>
        /// Create a new music finetune
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicFinetuneResponseModel> CreateAsync(

            global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Music Finetune<br/>
        /// Create a new music finetune
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MusicFinetuneResponseModel>> CreateAsResponseAsync(

            global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Music Finetune<br/>
        /// Create a new music finetune
        /// </summary>
        /// <param name="name">
        /// Name for the finetune (5-200 characters).
        /// </param>
        /// <param name="primaryGenre">
        /// Primary musical genre of the finetune.
        /// </param>
        /// <param name="files">
        /// Audio files to train on.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="tags">
        /// Tags to associate with the finetune.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="visibility">
        /// Finetune visibility. Only 'private' and 'workspace' can be set.
        /// </param>
        /// <param name="modelId">
        /// The model to create a finetune for.<br/>
        /// Default Value: music_v1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicFinetuneResponseModel> CreateAsync(
            string name,
            string primaryGenre,
            global::System.Collections.Generic.IList<byte[]>? files = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility2? visibility = default,
            global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostModelId? modelId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}