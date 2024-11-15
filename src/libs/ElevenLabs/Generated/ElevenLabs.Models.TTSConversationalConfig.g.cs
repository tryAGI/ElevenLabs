
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSConversationalConfig
    {
        /// <summary>
        /// Default Value: eleven_turbo_v2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelJsonConverter))]
        public global::ElevenLabs.TTSConversationalModel? ModelId { get; set; }

        /// <summary>
        /// Default Value: bYTqZQo3Jz7LQtmGTgwi
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Default Value: pcm_16000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatJsonConverter))]
        public global::ElevenLabs.TTSOutputFormat? AgentOutputAudioFormat { get; set; }

        /// <summary>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimize_streaming_latency")]
        public int? OptimizeStreamingLatency { get; set; }

        /// <summary>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// Default Value: 0.8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_boost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfig" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Default Value: eleven_turbo_v2
        /// </param>
        /// <param name="voiceId">
        /// Default Value: bYTqZQo3Jz7LQtmGTgwi
        /// </param>
        /// <param name="agentOutputAudioFormat">
        /// Default Value: pcm_16000
        /// </param>
        /// <param name="optimizeStreamingLatency">
        /// Default Value: 3
        /// </param>
        /// <param name="stability">
        /// Default Value: 0.5
        /// </param>
        /// <param name="similarityBoost">
        /// Default Value: 0.8
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TTSConversationalConfig(
            global::ElevenLabs.TTSConversationalModel? modelId,
            string? voiceId,
            global::ElevenLabs.TTSOutputFormat? agentOutputAudioFormat,
            int? optimizeStreamingLatency,
            double? stability,
            double? similarityBoost)
        {
            this.ModelId = modelId;
            this.VoiceId = voiceId;
            this.AgentOutputAudioFormat = agentOutputAudioFormat;
            this.OptimizeStreamingLatency = optimizeStreamingLatency;
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfig" /> class.
        /// </summary>
        public TTSConversationalConfig()
        {
        }
    }
}