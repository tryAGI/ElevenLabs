
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSpeechEngineRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_engine")]
        public global::ElevenLabs.SpeechEngineConfig? SpeechEngine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr")]
        public global::ElevenLabs.ASRConversationalConfig? Asr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::ElevenLabs.TTSConversationalConfigInput? Tts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public global::ElevenLabs.BaseTurnConfig? Turn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::ElevenLabs.ConversationConfigInput? Conversation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public global::ElevenLabs.PrivacyConfigInput? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_limits")]
        public global::ElevenLabs.AgentCallLimits? CallLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSpeechEngineRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSpeechEngineRequest(
            string? name,
            global::ElevenLabs.SpeechEngineConfig? speechEngine,
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
            this.SpeechEngine = speechEngine;
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
        /// Initializes a new instance of the <see cref="UpdateSpeechEngineRequest" /> class.
        /// </summary>
        public UpdateSpeechEngineRequest()
        {
        }

    }
}