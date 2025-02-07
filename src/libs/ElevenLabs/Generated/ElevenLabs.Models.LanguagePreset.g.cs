
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguagePreset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationConfigClientOverride Overrides { get; set; }

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
        /// Initializes a new instance of the <see cref="LanguagePreset" /> class.
        /// </summary>
        /// <param name="overrides"></param>
        /// <param name="firstMessageTranslation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguagePreset(
            global::ElevenLabs.ConversationConfigClientOverride overrides,
            global::ElevenLabs.LanguagePresetTranslation? firstMessageTranslation)
        {
            this.Overrides = overrides ?? throw new global::System.ArgumentNullException(nameof(overrides));
            this.FirstMessageTranslation = firstMessageTranslation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePreset" /> class.
        /// </summary>
        public LanguagePreset()
        {
        }
    }
}