
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StopAllCampaignsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopped_campaign_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> StoppedCampaignIds { get; set; }

        /// <summary>
        /// Campaigns whose calls already placed are still finishing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopping_campaign_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> StoppingCampaignIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopAllCampaignsResponse" /> class.
        /// </summary>
        /// <param name="stoppedCampaignIds"></param>
        /// <param name="stoppingCampaignIds">
        /// Campaigns whose calls already placed are still finishing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopAllCampaignsResponse(
            global::System.Collections.Generic.IList<string> stoppedCampaignIds,
            global::System.Collections.Generic.IList<string> stoppingCampaignIds)
        {
            this.StoppedCampaignIds = stoppedCampaignIds ?? throw new global::System.ArgumentNullException(nameof(stoppedCampaignIds));
            this.StoppingCampaignIds = stoppingCampaignIds ?? throw new global::System.ArgumentNullException(nameof(stoppingCampaignIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopAllCampaignsResponse" /> class.
        /// </summary>
        public StopAllCampaignsResponse()
        {
        }

    }
}