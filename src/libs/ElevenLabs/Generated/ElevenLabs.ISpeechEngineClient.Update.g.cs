#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechEngineClient
    {
        /// <summary>
        /// Update Speech Engine<br/>
        /// Update a Speech Engine resource (partial update)
        /// </summary>
        /// <param name="speechEngineId">
        /// The speech engine ID (accepts seng_ or agent_ prefix)
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SpeechEngineResponse> UpdateAsync(
            string speechEngineId,

            global::ElevenLabs.UpdateSpeechEngineRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Speech Engine<br/>
        /// Update a Speech Engine resource (partial update)
        /// </summary>
        /// <param name="speechEngineId">
        /// The speech engine ID (accepts seng_ or agent_ prefix)
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SpeechEngineResponse>> UpdateAsResponseAsync(
            string speechEngineId,

            global::ElevenLabs.UpdateSpeechEngineRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Speech Engine<br/>
        /// Update a Speech Engine resource (partial update)
        /// </summary>
        /// <param name="speechEngineId">
        /// The speech engine ID (accepts seng_ or agent_ prefix)
        /// </param>
        /// <param name="name"></param>
        /// <param name="speechEngine"></param>
        /// <param name="asr"></param>
        /// <param name="tts"></param>
        /// <param name="turn"></param>
        /// <param name="conversation"></param>
        /// <param name="privacy"></param>
        /// <param name="callLimits"></param>
        /// <param name="language"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SpeechEngineResponse> UpdateAsync(
            string speechEngineId,
            string? name = default,
            global::ElevenLabs.SpeechEngineConfig? speechEngine = default,
            global::ElevenLabs.ASRConversationalConfig? asr = default,
            global::ElevenLabs.TTSConversationalConfigInput? tts = default,
            global::ElevenLabs.BaseTurnConfig? turn = default,
            global::ElevenLabs.ConversationConfigInput? conversation = default,
            global::ElevenLabs.PrivacyConfigInput? privacy = default,
            global::ElevenLabs.AgentCallLimits? callLimits = default,
            string? language = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}