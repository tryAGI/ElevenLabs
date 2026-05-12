
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpeechEngineRequest
    {
        /// <summary>
        /// Name of the speech engine<br/>
        /// Default Value: Speech Engine
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Speech engine WebSocket configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_engine")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SpeechEngineConfig SpeechEngine { get; set; }

        /// <summary>
        /// ASR configuration<br/>
        /// Example: {"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"}
        /// </summary>
        /// <example>{"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr")]
        public global::ElevenLabs.ASRConversationalConfig? Asr { get; set; }

        /// <summary>
        /// TTS configuration<br/>
        /// Example: {"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}
        /// </summary>
        /// <example>{"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::ElevenLabs.TTSConversationalConfigInput? Tts { get; set; }

        /// <summary>
        /// Turn detection configuration<br/>
        /// Example: {"interruption_ignore_terms":[],"mode":"turn","retranscribe_on_turn_timeout":false,"silence_end_call_timeout":-1.0,"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0}
        /// </summary>
        /// <example>{"interruption_ignore_terms":[],"mode":"turn","retranscribe_on_turn_timeout":false,"silence_end_call_timeout":-1.0,"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public global::ElevenLabs.BaseTurnConfig? Turn { get; set; }

        /// <summary>
        /// Conversation configuration (client events, etc.)<br/>
        /// Example: {"client_events":["audio","interruption"],"max_duration_seconds":600}
        /// </summary>
        /// <example>{"client_events":["audio","interruption"],"max_duration_seconds":600}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::ElevenLabs.ConversationConfigInput? Conversation { get; set; }

        /// <summary>
        /// Privacy settings (recording, retention, zero retention mode)<br/>
        /// Example: {"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}
        /// </summary>
        /// <example>{"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public global::ElevenLabs.PrivacyConfigInput? Privacy { get; set; }

        /// <summary>
        /// Concurrency and daily conversation limits for this speech engine<br/>
        /// Example: {"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}
        /// </summary>
        /// <example>{"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_limits")]
        public global::ElevenLabs.AgentCallLimits? CallLimits { get; set; }

        /// <summary>
        /// Language for the speech engine<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Tags for categorization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechEngineRequest" /> class.
        /// </summary>
        /// <param name="speechEngine">
        /// Speech engine WebSocket configuration
        /// </param>
        /// <param name="name">
        /// Name of the speech engine<br/>
        /// Default Value: Speech Engine
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpeechEngineRequest(
            global::ElevenLabs.SpeechEngineConfig speechEngine,
            string? name,
            global::ElevenLabs.ASRConversationalConfig? asr,
            global::ElevenLabs.TTSConversationalConfigInput? tts,
            global::ElevenLabs.BaseTurnConfig? turn,
            global::ElevenLabs.ConversationConfigInput? conversation,
            global::ElevenLabs.PrivacyConfigInput? privacy,
            global::ElevenLabs.AgentCallLimits? callLimits,
            string? language,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Name = name;
            this.SpeechEngine = speechEngine ?? throw new global::System.ArgumentNullException(nameof(speechEngine));
            this.Asr = asr;
            this.Tts = tts;
            this.Turn = turn;
            this.Conversation = conversation;
            this.Privacy = privacy;
            this.CallLimits = callLimits;
            this.Language = language;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechEngineRequest" /> class.
        /// </summary>
        public CreateSpeechEngineRequest()
        {
        }

    }
}