
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSConversationalConfigOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelJsonConverter))]
        public global::ElevenLabs.TTSConversationalModel? ModelId { get; set; }

        /// <summary>
        /// The voice ID to use for TTS<br/>
        /// Default Value: cjVigY5qzO86Huf0OWal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional supported voices for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_voices")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SupportedVoice>? SupportedVoices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatJsonConverter))]
        public global::ElevenLabs.TTSOutputFormat? AgentOutputAudioFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimize_streaming_latency")]
        public int? OptimizeStreamingLatency { get; set; }

        /// <summary>
        /// The stability of generated speech<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// The speed of generated speech<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// The similarity boost for generated speech<br/>
        /// Default Value: 0.8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_boost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// The pronunciation dictionary locators
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_locators")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOutput" /> class.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="voiceId">
        /// The voice ID to use for TTS<br/>
        /// Default Value: cjVigY5qzO86Huf0OWal
        /// </param>
        /// <param name="supportedVoices">
        /// Additional supported voices for the agent
        /// </param>
        /// <param name="agentOutputAudioFormat"></param>
        /// <param name="optimizeStreamingLatency"></param>
        /// <param name="stability">
        /// The stability of generated speech<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="speed">
        /// The speed of generated speech<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="similarityBoost">
        /// The similarity boost for generated speech<br/>
        /// Default Value: 0.8
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// The pronunciation dictionary locators
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSConversationalConfigOutput(
            global::ElevenLabs.TTSConversationalModel? modelId,
            string? voiceId,
            global::System.Collections.Generic.IList<global::ElevenLabs.SupportedVoice>? supportedVoices,
            global::ElevenLabs.TTSOutputFormat? agentOutputAudioFormat,
            int? optimizeStreamingLatency,
            double? stability,
            double? speed,
            double? similarityBoost,
            global::System.Collections.Generic.IList<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? pronunciationDictionaryLocators)
        {
            this.ModelId = modelId;
            this.VoiceId = voiceId;
            this.SupportedVoices = supportedVoices;
            this.AgentOutputAudioFormat = agentOutputAudioFormat;
            this.OptimizeStreamingLatency = optimizeStreamingLatency;
            this.Stability = stability;
            this.Speed = speed;
            this.SimilarityBoost = similarityBoost;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOutput" /> class.
        /// </summary>
        public TTSConversationalConfigOutput()
        {
        }
    }
}