
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASRConversationalConfig
    {
        /// <summary>
        /// Default Value: high
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ASRQualityJsonConverter))]
        public global::ElevenLabs.ASRQuality? Quality { get; set; }

        /// <summary>
        /// Default Value: elevenlabs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ASRProviderJsonConverter))]
        public global::ElevenLabs.ASRProvider? Provider { get; set; }

        /// <summary>
        /// Default Value: pcm_16000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_input_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ASRInputFormatJsonConverter))]
        public global::ElevenLabs.ASRInputFormat? UserInputAudioFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASRConversationalConfig" /> class.
        /// </summary>
        /// <param name="quality">
        /// Default Value: high
        /// </param>
        /// <param name="provider">
        /// Default Value: elevenlabs
        /// </param>
        /// <param name="userInputAudioFormat">
        /// Default Value: pcm_16000
        /// </param>
        /// <param name="keywords"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ASRConversationalConfig(
            global::ElevenLabs.ASRQuality? quality,
            global::ElevenLabs.ASRProvider? provider,
            global::ElevenLabs.ASRInputFormat? userInputAudioFormat,
            global::System.Collections.Generic.IList<string>? keywords)
        {
            this.Quality = quality;
            this.Provider = provider;
            this.UserInputAudioFormat = userInputAudioFormat;
            this.Keywords = keywords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASRConversationalConfig" /> class.
        /// </summary>
        public ASRConversationalConfig()
        {
        }
    }
}