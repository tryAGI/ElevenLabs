
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CampaignResponseChannelConfigDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CampaignResponseChannelConfigDiscriminatorChannelJsonConverter))]
        public global::ElevenLabs.CampaignResponseChannelConfigDiscriminatorChannel? Channel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignResponseChannelConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="channel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignResponseChannelConfigDiscriminator(
            global::ElevenLabs.CampaignResponseChannelConfigDiscriminatorChannel? channel)
        {
            this.Channel = channel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignResponseChannelConfigDiscriminator" /> class.
        /// </summary>
        public CampaignResponseChannelConfigDiscriminator()
        {
        }

    }
}