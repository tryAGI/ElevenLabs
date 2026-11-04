
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"requires_verification":false,"voice_id":"c38kUX8pkfYO2kHyqfFy"}
    /// </summary>
    public sealed partial class AddVoiceIVCResponseModel
    {
        /// <summary>
        /// The ID of the newly created voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Whether the voice requires verification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequiresVerification { get; set; }

        /// <summary>
        /// Set when the samples match a protected voice that is available in the Voice Library. The new voice requires verification before use; adding the library voice is the alternative.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("library_voice_match")]
        public global::ElevenLabs.LibraryVoiceMatchResponseModel? LibraryVoiceMatch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceIVCResponseModel" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the newly created voice.
        /// </param>
        /// <param name="requiresVerification">
        /// Whether the voice requires verification
        /// </param>
        /// <param name="libraryVoiceMatch">
        /// Set when the samples match a protected voice that is available in the Voice Library. The new voice requires verification before use; adding the library voice is the alternative.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddVoiceIVCResponseModel(
            string voiceId,
            bool requiresVerification,
            global::ElevenLabs.LibraryVoiceMatchResponseModel? libraryVoiceMatch)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.RequiresVerification = requiresVerification;
            this.LibraryVoiceMatch = libraryVoiceMatch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceIVCResponseModel" /> class.
        /// </summary>
        public AddVoiceIVCResponseModel()
        {
        }

    }
}