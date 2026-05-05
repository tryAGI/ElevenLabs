#nullable enable

namespace ElevenLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Edit Voice<br/>
        /// Edit a voice created by you.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EditVoiceResponseModel> Update2Async(
            string voiceId,

            global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Voice<br/>
        /// Edit a voice created by you.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.EditVoiceResponseModel>> Update2AsResponseAsync(
            string voiceId,

            global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Voice<br/>
        /// Edit a voice created by you.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="name">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        /// <param name="files">
        /// Audio files to add to the voice
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// A description of the voice.
        /// </param>
        /// <param name="labels">
        /// Labels for the voice. Keys can be language, accent, gender, or age.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EditVoiceResponseModel> Update2Async(
            string voiceId,
            string name,
            global::System.Collections.Generic.IList<byte[]>? files = default,
            bool? removeBackgroundNoise = default,
            string? description = default,
            global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string, object>? labels = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Edit Voice<br/>
        /// Edit a voice created by you.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="name">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        /// <param name="files">
        /// Audio files to add to the voice
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// A description of the voice.
        /// </param>
        /// <param name="labels">
        /// Labels for the voice. Keys can be language, accent, gender, or age.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EditVoiceResponseModel> Update2Async(
            string voiceId,
            string name,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? files = default,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            bool? removeBackgroundNoise = default,
            string? description = default,
            global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string, object>? labels = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Voice<br/>
        /// Edit a voice created by you.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="name">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        /// <param name="files">
        /// Audio files to add to the voice
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// A description of the voice.
        /// </param>
        /// <param name="labels">
        /// Labels for the voice. Keys can be language, accent, gender, or age.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.EditVoiceResponseModel>> Update2AsResponseAsync(
            string voiceId,
            string name,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? files = default,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            bool? removeBackgroundNoise = default,
            string? description = default,
            global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string, object>? labels = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}