
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"bulletin":{"host_voice_id":"aw1NgEzBg83R7vgmiJt6"},"type":"bulletin"}
    /// </summary>
    public sealed partial class PodcastBulletinMode
    {
        /// <summary>
        /// The type of podcast to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PodcastBulletinModeTypeJsonConverter))]
        public global::ElevenLabs.PodcastBulletinModeType Type { get; set; }

        /// <summary>
        /// Example: {"host_voice_id":"aw1NgEzBg83R7vgmiJt6"}
        /// </summary>
        /// <example>{"host_voice_id":"aw1NgEzBg83R7vgmiJt6"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulletin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.PodcastBulletinModeData Bulletin { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastBulletinMode" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of podcast to create.
        /// </param>
        /// <param name="bulletin">
        /// Example: {"host_voice_id":"aw1NgEzBg83R7vgmiJt6"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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