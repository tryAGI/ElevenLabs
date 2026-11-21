
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FlattenedConfigOverrides
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedConfigOverrides" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="firstMessage"></param>
        /// <param name="prompt"></param>
        /// <param name="voiceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlattenedConfigOverrides(
            string? language,
            string? firstMessage,
            string? prompt,
            string? voiceId)
        {
            this.Language = language;
            this.FirstMessage = firstMessage;
            this.Prompt = prompt;
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedConfigOverrides" /> class.
        /// </summary>
        public FlattenedConfigOverrides()
        {
        }

    }
}