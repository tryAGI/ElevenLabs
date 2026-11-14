
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SuppressLeadResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("lead_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LeadId { get; set; }

        /// <summary>
        /// Whether a call already handed off for dialing may still go through.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_calls_in_flight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasCallsInFlight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuppressLeadResponse" /> class.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="leadId"></param>
        /// <param name="hasCallsInFlight">
        /// Whether a call already handed off for dialing may still go through.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuppressLeadResponse(
            string campaignId,
            string leadId,
            bool hasCallsInFlight)
        {
            this.CampaignId = campaignId ?? throw new global::System.ArgumentNullException(nameof(campaignId));
            this.LeadId = leadId ?? throw new global::System.ArgumentNullException(nameof(leadId));
            this.HasCallsInFlight = hasCallsInFlight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuppressLeadResponse" /> class.
        /// </summary>
        public SuppressLeadResponse()
        {
        }

    }
}