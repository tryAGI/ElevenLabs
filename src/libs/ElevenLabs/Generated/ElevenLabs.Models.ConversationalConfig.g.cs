
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationalConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::ElevenLabs.AgentConfig? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr")]
        public global::ElevenLabs.ASRConversationalConfig? Asr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public global::ElevenLabs.TurnConfig? Turn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::ElevenLabs.TTSConversationalConfig? Tts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::ElevenLabs.ConversationConfig? Conversation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_presets")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePreset>? LanguagePresets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalConfig" /> class.
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="asr"></param>
        /// <param name="turn"></param>
        /// <param name="tts"></param>
        /// <param name="conversation"></param>
        /// <param name="languagePresets"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ConversationalConfig(
            global::ElevenLabs.AgentConfig? agent,
            global::ElevenLabs.ASRConversationalConfig? asr,
            global::ElevenLabs.TurnConfig? turn,
            global::ElevenLabs.TTSConversationalConfig? tts,
            global::ElevenLabs.ConversationConfig? conversation,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePreset>? languagePresets)
        {
            this.Agent = agent;
            this.Asr = asr;
            this.Turn = turn;
            this.Tts = tts;
            this.Conversation = conversation;
            this.LanguagePresets = languagePresets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalConfig" /> class.
        /// </summary>
        public ConversationalConfig()
        {
        }
    }
}