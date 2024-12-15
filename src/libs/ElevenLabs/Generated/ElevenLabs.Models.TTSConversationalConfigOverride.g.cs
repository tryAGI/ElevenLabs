
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSConversationalConfigOverride
    {
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
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOverride" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TTSConversationalConfigOverride(
            string? voiceId)
        {
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOverride" /> class.
        /// </summary>
        public TTSConversationalConfigOverride()
        {
        }
    }
}