#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechEngineClient
    {
        /// <summary>
        /// Create Speech Engine<br/>
        /// Create a new Speech Engine resource
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateSpeechEngineResponse> CreateAsync(

            global::ElevenLabs.CreateSpeechEngineRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Speech Engine<br/>
        /// Create a new Speech Engine resource
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.CreateSpeechEngineResponse>> CreateAsResponseAsync(

            global::ElevenLabs.CreateSpeechEngineRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Speech Engine<br/>
        /// Create a new Speech Engine resource
        /// </summary>
        /// <param name="name">
        /// Name of the speech engine<br/>
        /// Default Value: Speech Engine
        /// </param>
        /// <param name="speechEngine">
        /// Speech engine WebSocket configuration
        /// </param>
        /// <param name="asr">
        /// ASR configuration<br/>
        /// Example: {"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"}
        /// </param>
        /// <param name="tts">
        /// TTS configuration<br/>
        /// Example: {"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}
        /// </param>
        /// <param name="turn">
        /// Turn detection configuration<br/>
        /// Example: {"interruption_ignore_terms":[],"mode":"turn","retranscribe_on_turn_timeout":false,"silence_end_call_timeout":-1.0,"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0}
        /// </param>
        /// <param name="conversation">
        /// Conversation configuration (client events, etc.)<br/>
        /// Example: {"client_events":["audio","interruption"],"max_duration_seconds":600}
        /// </param>
        /// <param name="privacy">
        /// Privacy settings (recording, retention, zero retention mode)<br/>
        /// Example: {"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}
        /// </param>
        /// <param name="callLimits">
        /// Concurrency and daily conversation limits for this speech engine<br/>
        /// Example: {"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}
        /// </param>
        /// <param name="language">
        /// Language for the speech engine<br/>
        /// Default Value: en
        /// </param>
        /// <param name="tags">
        /// Tags for categorization
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateSpeechEngineResponse> CreateAsync(
            global::ElevenLabs.SpeechEngineConfig speechEngine,
            string? name = default,
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