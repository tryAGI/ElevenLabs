
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PodcastBulletinModeData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HostVoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastBulletinModeData" /> class.
        /// </summary>
        /// <param name="hostVoiceId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PodcastBulletinModeData(
            string hostVoiceId)
        {
            this.HostVoiceId = hostVoiceId ?? throw new global::System.ArgumentNullException(nameof(hostVoiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastBulletinModeData" /> class.
        /// </summary>
        public PodcastBulletinModeData()
        {
        }
    }
}