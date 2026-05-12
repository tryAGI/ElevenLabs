
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechEngineResponse
    {
        /// <summary>
        /// The speech engine resource ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_engine_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeechEngineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_engine")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SpeechEngineConfig SpeechEngine { get; set; }

        /// <summary>
        /// Example: {"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"}
        /// </summary>
        /// <example>{"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ASRConversationalConfig Asr { get; set; }

        /// <summary>
        /// Example: {"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}
        /// </summary>
        /// <example>{"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TTSConversationalConfigOutput Tts { get; set; }

        /// <summary>
        /// Example: {"interruption_ignore_terms":[],"mode":"turn","retranscribe_on_turn_timeout":false,"silence_end_call_timeout":-1.0,"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0}
        /// </summary>
        /// <example>{"interruption_ignore_terms":[],"mode":"turn","retranscribe_on_turn_timeout":false,"silence_end_call_timeout":-1.0,"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.BaseTurnConfig Turn { get; set; }

        /// <summary>
        /// Example: {"client_events":["audio","interruption"],"max_duration_seconds":600}
        /// </summary>
        /// <example>{"client_events":["audio","interruption"],"max_duration_seconds":600}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationConfigOutput Conversation { get; set; }

        /// <summary>
        /// Example: {"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}
        /// </summary>
        /// <example>{"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.PrivacyConfigOutput Privacy { get; set; }

        /// <summary>
        /// Example: {"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}
        /// </summary>
        /// <example>{"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentCallLimits CallLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentMetadataDBModel Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechEngineResponse" /> class.
        /// </summary>
        /// <param name="speechEngineId">
        /// The speech engine resource ID
        /// </param>
        /// <param name="name"></param>
        /// <param name="speechEngine"></param>
        /// <param name="asr">
        /// Example: {"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"}
        /// </param>
        /// <param name="tts">
        /// Example: {"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}
        /// </param>
        /// <param name="turn">
        /// Example: {"interruption_ignore_terms":[],"mode":"turn","retranscribe_on_turn_timeout":false,"silence_end_call_timeout":-1.0,"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0}
        /// </param>
        /// <param name="conversation">
        /// Example: {"client_events":["audio","interruption"],"max_duration_seconds":600}
        /// </param>
        /// <param name="privacy">
        /// Example: {"apply_to_existing_conversations":false,"delete_audio":false,"delete_transcript_and_pii":false,"record_voice":true,"retention_days":-1,"zero_retention_mode":false}
        /// </param>
        /// <param name="callLimits">
        /// Example: {"agent_concurrency_limit":-1,"bursting_enabled":true,"daily_limit":100000}
        /// </param>
        /// <param name="language"></param>
        /// <param name="tags"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechEngineResponse(
            string speechEngineId,
            string name,
            global::ElevenLabs.SpeechEngineConfig speechEngine,
            global::ElevenLabs.ASRConversationalConfig asr,
            global::ElevenLabs.TTSConversationalConfigOutput tts,
            global::ElevenLabs.BaseTurnConfig turn,
            global::ElevenLabs.ConversationConfigOutput conversation,
            global::ElevenLabs.PrivacyConfigOutput privacy,
            global::ElevenLabs.AgentCallLimits callLimits,
            string language,
            global::System.Collections.Generic.IList<string> tags,
            global::ElevenLabs.AgentMetadataDBModel metadata)
        {
            this.SpeechEngineId = speechEngineId ?? throw new global::System.ArgumentNullException(nameof(speechEngineId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SpeechEngine = speechEngine ?? throw new global::System.ArgumentNullException(nameof(speechEngine));
            this.Asr = asr ?? throw new global::System.ArgumentNullException(nameof(asr));
            this.Tts = tts ?? throw new global::System.ArgumentNullException(nameof(tts));
            this.Turn = turn ?? throw new global::System.ArgumentNullException(nameof(turn));
            this.Conversation = conversation ?? throw new global::System.ArgumentNullException(nameof(conversation));
            this.Privacy = privacy ?? throw new global::System.ArgumentNullException(nameof(privacy));
            this.CallLimits = callLimits ?? throw new global::System.ArgumentNullException(nameof(callLimits));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechEngineResponse" /> class.
        /// </summary>
        public SpeechEngineResponse()
        {
        }

    }
}