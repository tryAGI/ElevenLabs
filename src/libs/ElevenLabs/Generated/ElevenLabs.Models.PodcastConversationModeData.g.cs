
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PodcastConversationModeData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HostVoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guest_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GuestVoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastConversationModeData" /> class.
        /// </summary>
        /// <param name="hostVoiceId"></param>
        /// <param name="guestVoiceId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PodcastConversationModeData(
            string hostVoiceId,
            string guestVoiceId)
        {
            this.HostVoiceId = hostVoiceId ?? throw new global::System.ArgumentNullException(nameof(hostVoiceId));
            this.GuestVoiceId = guestVoiceId ?? throw new global::System.ArgumentNullException(nameof(guestVoiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastConversationModeData" /> class.
        /// </summary>
        public PodcastConversationModeData()
        {
        }
    }
}