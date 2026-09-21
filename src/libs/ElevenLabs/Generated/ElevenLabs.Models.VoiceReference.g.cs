
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A voice this workspace can use.
    /// </summary>
    public sealed partial class VoiceReference
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"voice"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "voice";

        /// <summary>
        /// The ID of a voice in this workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceReference" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of a voice in this workspace.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceReference(
            string voiceId,
            string type = "voice")
        {
            this.Type = type;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceReference" /> class.
        /// </summary>
        public VoiceReference()
        {
        }

        /// <summary>
        /// Creates a new <see cref="VoiceReference"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static VoiceReference FromVoiceId(string voiceId)
        {
            return new VoiceReference
            {
                VoiceId = voiceId,
            };
        }

    }
}