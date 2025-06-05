
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SupportedVoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_family")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TTSModelFamilyJsonConverter))]
        public global::ElevenLabs.TTSModelFamily? ModelFamily { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedVoice" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="voiceId"></param>
        /// <param name="description"></param>
        /// <param name="language"></param>
        /// <param name="modelFamily"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SupportedVoice(
            string label,
            string voiceId,
            string? description,
            string? language,
            global::ElevenLabs.TTSModelFamily? modelFamily)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Description = description;
            this.Language = language;
            this.ModelFamily = modelFamily;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedVoice" /> class.
        /// </summary>
        public SupportedVoice()
        {
        }
    }
}