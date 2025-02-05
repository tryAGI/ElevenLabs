
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PodcastBulletinMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PodcastBulletinModeTypeJsonConverter))]
        public global::ElevenLabs.PodcastBulletinModeType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulletin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.PodcastBulletinModeData Bulletin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastBulletinMode" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="bulletin"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PodcastBulletinMode(
            global::ElevenLabs.PodcastBulletinModeData bulletin,
            global::ElevenLabs.PodcastBulletinModeType type)
        {
            this.Bulletin = bulletin ?? throw new global::System.ArgumentNullException(nameof(bulletin));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastBulletinMode" /> class.
        /// </summary>
        public PodcastBulletinMode()
        {
        }
    }
}