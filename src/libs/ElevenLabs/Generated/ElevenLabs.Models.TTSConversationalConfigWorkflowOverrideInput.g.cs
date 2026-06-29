
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}
    /// </summary>
    public sealed partial class TTSConversationalConfigWorkflowOverrideInput
    {
        /// <summary>
        /// The model to use for TTS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public global::ElevenLabs.TTSConversationalModel? ModelId { get; set; }

        /// <summary>
        /// The voice ID to use for TTS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional supported voices for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_voices")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SupportedVoice>? SupportedVoices { get; set; }

        /// <summary>
        /// When enabled, applies expressive audio tags prompt. Automatically disabled for non-v3 models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expressive_mode")]
        public bool? ExpressiveMode { get; set; }

        /// <summary>
        /// Suggested audio tags to boost expressive speech (for eleven_v3 and eleven_v3_conversational models). The agent can still use other tags not listed here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggested_audio_tags")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SuggestedAudioTag>? SuggestedAudioTags { get; set; }

        /// <summary>
        /// The audio format to use for TTS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_output_audio_format")]
        public global::ElevenLabs.TTSOutputFormat? AgentOutputAudioFormat { get; set; }

        /// <summary>
        /// The optimization for streaming latency
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimize_streaming_latency")]
        public int? OptimizeStreamingLatency { get; set; }

        /// <summary>
        /// The stability of generated speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// The speed of generated speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// The similarity boost for generated speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_boost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// Method for converting numbers to words before converting text to speech. If set to SYSTEM_PROMPT, the system prompt will be updated to include normalization instructions. If set to ELEVENLABS, the text will be normalized after generation, incurring slight additional latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_normalisation_type")]
        public global::ElevenLabs.TextNormalisationType? TextNormalisationType { get; set; }

        /// <summary>
        /// The pronunciation dictionary locators
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_locators")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// Opt-in to SSML phoneme tag handling for V3 models. When enabled, phoneme tags (inline and from pronunciation dictionaries) are parsed into inline IPA before being sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_phoneme_tags")]
        public bool? EnablePhonemeTags { get; set; }

        /// <summary>
        /// An optional filter applied to the audio output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_filter")]
        public global::ElevenLabs.AudioFilterId? AudioFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigWorkflowOverrideInput" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The model to use for TTS
        /// </param>
        /// <param name="voiceId">
        /// The voice ID to use for TTS
        /// </param>
        /// <param name="supportedVoices">
        /// Additional supported voices for the agent
        /// </param>
        /// <param name="expressiveMode">
        /// When enabled, applies expressive audio tags prompt. Automatically disabled for non-v3 models.
        /// </param>
        /// <param name="suggestedAudioTags">
        /// Suggested audio tags to boost expressive speech (for eleven_v3 and eleven_v3_conversational models). The agent can still use other tags not listed here.
        /// </param>
        /// <param name="agentOutputAudioFormat">
        /// The audio format to use for TTS
        /// </param>
        /// <param name="optimizeStreamingLatency">
        /// The optimization for streaming latency
        /// </param>
        /// <param name="stability">
        /// The stability of generated speech
        /// </param>
        /// <param name="speed">
        /// The speed of generated speech
        /// </param>
        /// <param name="similarityBoost">
        /// The similarity boost for generated speech
        /// </param>
        /// <param name="textNormalisationType">
        /// Method for converting numbers to words before converting text to speech. If set to SYSTEM_PROMPT, the system prompt will be updated to include normalization instructions. If set to ELEVENLABS, the text will be normalized after generation, incurring slight additional latency.
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// The pronunciation dictionary locators
        /// </param>
        /// <param name="enablePhonemeTags">
        /// Opt-in to SSML phoneme tag handling for V3 models. When enabled, phoneme tags (inline and from pronunciation dictionaries) are parsed into inline IPA before being sent to the model.
        /// </param>
        /// <param name="audioFilter">
        /// An optional filter applied to the audio output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSConversationalConfigWorkflowOverrideInput(
            global::ElevenLabs.TTSConversationalModel? modelId,
            string? voiceId,
            global::System.Collections.Generic.IList<global::ElevenLabs.SupportedVoice>? supportedVoices,
            bool? expressiveMode,
            global::System.Collections.Generic.IList<global::ElevenLabs.SuggestedAudioTag>? suggestedAudioTags,
            global::ElevenLabs.TTSOutputFormat? agentOutputAudioFormat,
            int? optimizeStreamingLatency,
            double? stability,
            double? speed,
            double? similarityBoost,
            global::ElevenLabs.TextNormalisationType? textNormalisationType,
            global::System.Collections.Generic.IList<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? pronunciationDictionaryLocators,
            bool? enablePhonemeTags,
            global::ElevenLabs.AudioFilterId? audioFilter)
        {
            this.ModelId = modelId;
            this.VoiceId = voiceId;
            this.SupportedVoices = supportedVoices;
            this.ExpressiveMode = expressiveMode;
            this.SuggestedAudioTags = suggestedAudioTags;
            this.AgentOutputAudioFormat = agentOutputAudioFormat;
            this.OptimizeStreamingLatency = optimizeStreamingLatency;
            this.Stability = stability;
            this.Speed = speed;
            this.SimilarityBoost = similarityBoost;
            this.TextNormalisationType = textNormalisationType;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
            this.EnablePhonemeTags = enablePhonemeTags;
            this.AudioFilter = audioFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigWorkflowOverrideInput" /> class.
        /// </summary>
        public TTSConversationalConfigWorkflowOverrideInput()
        {
        }

    }
}