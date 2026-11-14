
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CampaignSummaryCounts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Leads { get; set; }

        /// <summary>
        /// Leads that won't be called again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminal_leads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TerminalLeads { get; set; }

        /// <summary>
        /// Attention items not yet resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_attention")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OpenAttention { get; set; }

        /// <summary>
        /// How many messages reached each stage; set when getting one message campaign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        public global::ElevenLabs.RecipientDeliveryCounts? Delivery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSummaryCounts" /> class.
        /// </summary>
        /// <param name="leads"></param>
        /// <param name="terminalLeads">
        /// Leads that won't be called again.
        /// </param>
        /// <param name="openAttention">
        /// Attention items not yet resolved.
        /// </param>
        /// <param name="delivery">
        /// How many messages reached each stage; set when getting one message campaign.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignSummaryCounts(
            int leads,
            int terminalLeads,
            int openAttention,
            global::ElevenLabs.RecipientDeliveryCounts? delivery)
        {
            this.Leads = leads;
            this.TerminalLeads = terminalLeads;
            this.OpenAttention = openAttention;
            this.Delivery = delivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSummaryCounts" /> class.
        /// </summary>
        public CampaignSummaryCounts()
        {
        }

    }
}