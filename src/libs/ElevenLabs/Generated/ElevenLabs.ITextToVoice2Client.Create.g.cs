#nullable enable

namespace ElevenLabs
{
    public partial interface ITextToVoice2Client
    {
        /// <summary>
        /// Create A New Voice From Voice Preview<br/>
        /// Create a voice from previously generated voice preview. This endpoint should be called after you fetched a generated_voice_id using POST /v1/text-to-voice/design or POST /v1/text-to-voice/:voice_id/remix.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VoiceResponseModel> CreateAsync(

            global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoicePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create A New Voice From Voice Preview<br/>
        /// Create a voice from previously generated voice preview. This endpoint should be called after you fetched a generated_voice_id using POST /v1/text-to-voice/design or POST /v1/text-to-voice/:voice_id/remix.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.VoiceResponseModel>> CreateAsResponseAsync(

            global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoicePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create A New Voice From Voice Preview<br/>
        /// Create a voice from previously generated voice preview. This endpoint should be called after you fetched a generated_voice_id using POST /v1/text-to-voice/design or POST /v1/text-to-voice/:voice_id/remix.
        /// </summary>
        /// <param name="voiceName">
        /// Name to use for the created voice.
        /// </param>
        /// <param name="voiceDescription">
        /// Description to use for the created voice.
        /// </param>
        /// <param name="generatedVoiceId">
        /// The generated_voice_id to create; obtain it from POST /v1/text-to-voice/design, POST /v1/text-to-voice/:voice_id/remix, or the response headers when generating previews.
        /// </param>
        /// <param name="labels">
        /// Optional, metadata to add to the created voice. Defaults to None.
        /// </param>
        /// <param name="playedNotSelectedVoiceIds">
        /// List of voice ids that the user has played but not selected. Used for RLHF.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VoiceResponseModel> CreateAsync(
            string voiceName,
            string voiceDescription,
            string generatedVoiceId,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::System.Collections.Generic.IList<string>? playedNotSelectedVoiceIds = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}