
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationalConfigAPIModelInput
    {
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
        public global::ElevenLabs.TTSConversationalConfigInput? Tts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::ElevenLabs.ConversationConfig? Conversation { get; set; }

        /// <summary>
        /// Language presets for conversations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_presets")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetInput>? LanguagePresets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::ElevenLabs.AgentConfigAPIModelInput? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalConfigAPIModelInput" /> class.
        /// </summary>
        /// <param name="asr"></param>
        /// <param name="turn"></param>
        /// <param name="tts"></param>
        /// <param name="conversation"></param>
        /// <param name="languagePresets">
        /// Language presets for conversations
        /// </param>
        /// <param name="agent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationalConfigAPIModelInput(
            global::ElevenLabs.ASRConversationalConfig? asr,
            global::ElevenLabs.TurnConfig? turn,
            global::ElevenLabs.TTSConversationalConfigInput? tts,
            global::ElevenLabs.ConversationConfig? conversation,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetInput>? languagePresets,
            global::ElevenLabs.AgentConfigAPIModelInput? agent)
        {
            this.Asr = asr;
            this.Turn = turn;
            this.Tts = tts;
            this.Conversation = conversation;
            this.LanguagePresets = languagePresets;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalConfigAPIModelInput" /> class.
        /// </summary>
        public ConversationalConfigAPIModelInput()
        {
        }
    }
}