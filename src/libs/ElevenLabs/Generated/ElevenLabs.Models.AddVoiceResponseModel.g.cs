
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddVoiceResponseModel
    {
        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="AddVoiceResponseModel" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AddVoiceResponseModel(
            string voiceId)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceResponseModel" /> class.
        /// </summary>
        public AddVoiceResponseModel()
        {
        }
    }
}