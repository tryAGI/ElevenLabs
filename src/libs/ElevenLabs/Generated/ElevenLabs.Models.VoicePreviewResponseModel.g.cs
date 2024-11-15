
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicePreviewResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base_64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioBase64 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GeneratedVoiceId { get; set; }

        /// <summary>
        /// Default Value: audio/mpeg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.VoicePreviewResponseModelMediaTypeJsonConverter))]
        public global::ElevenLabs.VoicePreviewResponseModelMediaType? MediaType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePreviewResponseModel" /> class.
        /// </summary>
        /// <param name="audioBase64"></param>
        /// <param name="generatedVoiceId"></param>
        /// <param name="mediaType">
        /// Default Value: audio/mpeg
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public VoicePreviewResponseModel(
            string audioBase64,
            string generatedVoiceId,
            global::ElevenLabs.VoicePreviewResponseModelMediaType? mediaType)
        {
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.GeneratedVoiceId = generatedVoiceId ?? throw new global::System.ArgumentNullException(nameof(generatedVoiceId));
            this.MediaType = mediaType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePreviewResponseModel" /> class.
        /// </summary>
        public VoicePreviewResponseModel()
        {
        }
    }
}