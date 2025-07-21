
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteVoiceRemixingSessionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_remixing_session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceRemixingSessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVoiceRemixingSessionResponseModel" /> class.
        /// </summary>
        /// <param name="voiceRemixingSessionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteVoiceRemixingSessionResponseModel(
            string voiceRemixingSessionId)
        {
            this.VoiceRemixingSessionId = voiceRemixingSessionId ?? throw new global::System.ArgumentNullException(nameof(voiceRemixingSessionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVoiceRemixingSessionResponseModel" /> class.
        /// </summary>
        public DeleteVoiceRemixingSessionResponseModel()
        {
        }
    }
}