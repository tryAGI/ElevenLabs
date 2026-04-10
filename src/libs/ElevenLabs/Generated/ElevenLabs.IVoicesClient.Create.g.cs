#nullable enable

namespace ElevenLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Add Voice<br/>
        /// Add a new voice to your collection of voices in VoiceLab.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddVoiceIVCResponseModel> CreateAsync(

            global::ElevenLabs.BodyAddVoiceV1VoicesAddPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Voice<br/>
        /// Add a new voice to your collection of voices in VoiceLab.
        /// </summary>
        /// <param name="name">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        /// <param name="files">
        /// A list of file paths to audio recordings intended for voice cloning.
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddVoiceIVCResponseModel> CreateAsync(
            string name,
            global::System.Collections.Generic.IList<byte[]> files,
            bool? removeBackgroundNoise = default,
            string? description = default,
            global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string, object>? labels = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}