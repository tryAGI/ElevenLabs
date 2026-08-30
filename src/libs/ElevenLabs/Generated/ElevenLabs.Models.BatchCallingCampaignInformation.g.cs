
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchCallingCampaignInformation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CampaignId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("campaign_lead_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CampaignLeadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallingCampaignInformation" /> class.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="campaignLeadId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchCallingCampaignInformation(
            string campaignId,
            string campaignLeadId)
        {
            this.CampaignId = campaignId ?? throw new global::System.ArgumentNullException(nameof(campaignId));
            this.CampaignLeadId = campaignLeadId ?? throw new global::System.ArgumentNullException(nameof(campaignLeadId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallingCampaignInformation" /> class.
        /// </summary>
        public BatchCallingCampaignInformation()
        {
        }

    }
}