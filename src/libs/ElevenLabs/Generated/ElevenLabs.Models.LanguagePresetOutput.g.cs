
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguagePresetOutput
    {
        /// <summary>
        /// Example: {"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}},"tts":{"voice_id":"cjVigY5qzO86Huf0OWal"}}
        /// </summary>
        /// <example>{"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}},"tts":{"voice_id":"cjVigY5qzO86Huf0OWal"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.ConversationConfigClientOverrideOutput Overrides { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_translation")]
        public global::ElevenLabs.LanguagePresetTranslation? FirstMessageTranslation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePresetOutput" /> class.
        /// </summary>
        /// <param name="overrides">
        /// Example: {"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}},"tts":{"voice_id":"cjVigY5qzO86Huf0OWal"}}
        /// </param>
        /// <param name="firstMessageTranslation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguagePresetOutput(
            global::ElevenLabs.ConversationConfigClientOverrideOutput overrides,
            global::ElevenLabs.LanguagePresetTranslation? firstMessageTranslation)
        {
            this.Overrides = overrides ?? throw new global::System.ArgumentNullException(nameof(overrides));
            this.FirstMessageTranslation = firstMessageTranslation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePresetOutput" /> class.
        /// </summary>
        public LanguagePresetOutput()
        {
        }
    }
}