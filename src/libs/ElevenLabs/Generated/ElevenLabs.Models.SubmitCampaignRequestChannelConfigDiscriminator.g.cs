
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubmitCampaignRequestChannelConfigDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SubmitCampaignRequestChannelConfigDiscriminatorChannelJsonConverter))]
        public global::ElevenLabs.SubmitCampaignRequestChannelConfigDiscriminatorChannel? Channel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCampaignRequestChannelConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="channel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitCampaignRequestChannelConfigDiscriminator(
            global::ElevenLabs.SubmitCampaignRequestChannelConfigDiscriminatorChannel? channel)
        {
            this.Channel = channel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCampaignRequestChannelConfigDiscriminator" /> class.
        /// </summary>
        public SubmitCampaignRequestChannelConfigDiscriminator()
        {
        }

    }
}