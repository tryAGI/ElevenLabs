
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubmitCampaignResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("campaign")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CampaignResponse Campaign { get; set; }

        /// <summary>
        /// False when the request repeated an earlier one and returned its campaign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Created { get; set; }

        /// <summary>
        /// Whether calling starts right away rather than at the next calling window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("within_calling_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WithinCallingWindow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCampaignResponse" /> class.
        /// </summary>
        /// <param name="campaign"></param>
        /// <param name="created">
        /// False when the request repeated an earlier one and returned its campaign.
        /// </param>
        /// <param name="withinCallingWindow">
        /// Whether calling starts right away rather than at the next calling window.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitCampaignResponse(
            global::ElevenLabs.CampaignResponse campaign,
            bool created,
            bool withinCallingWindow)
        {
            this.Campaign = campaign ?? throw new global::System.ArgumentNullException(nameof(campaign));
            this.Created = created;
            this.WithinCallingWindow = withinCallingWindow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCampaignResponse" /> class.
        /// </summary>
        public SubmitCampaignResponse()
        {
        }

    }
}