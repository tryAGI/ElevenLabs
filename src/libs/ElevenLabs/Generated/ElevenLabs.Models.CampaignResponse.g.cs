
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CampaignResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CampaignId { get; set; }

        /// <summary>
        /// The campaign's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ChannelConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ChannelConfig ChannelConfig { get; set; }

        /// <summary>
        /// `attention` means an open attention item holds back some of the campaign's calls while the rest go ahead. `stopping` means queued calls are cancelled and calls already placed are finishing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CampaignStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CampaignStatus Status { get; set; }

        /// <summary>
        /// The policy the campaign took when it was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CampaignPolicySnapshot Policy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CampaignVariantJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CampaignVariant Variant { get; set; }

        /// <summary>
        /// Whether the campaign was created in the app or through the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::ElevenLabs.CampaignSource? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnix { get; set; }

        /// <summary>
        /// When the campaign starts calling; unset to start once created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_time_unix")]
        public int? ScheduledTimeUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAtUnix { get; set; }

        /// <summary>
        /// The agent branch the campaign calls with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// The environment the agent's environment variables resolve in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// The most calls the campaign places at once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_concurrency_limit")]
        public int? TargetConcurrencyLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.OutboundChannelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.OutboundChannel Channel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.OutboundModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.OutboundMode Mode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CampaignSummaryCounts Counts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignResponse" /> class.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="callName">
        /// The campaign's name.
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="channelConfig"></param>
        /// <param name="status">
        /// `attention` means an open attention item holds back some of the campaign's calls while the rest go ahead. `stopping` means queued calls are cancelled and calls already placed are finishing.
        /// </param>
        /// <param name="policy">
        /// The policy the campaign took when it was created.
        /// </param>
        /// <param name="variant"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="updatedAtUnix"></param>
        /// <param name="channel"></param>
        /// <param name="mode"></param>
        /// <param name="counts"></param>
        /// <param name="agentName"></param>
        /// <param name="source">
        /// Whether the campaign was created in the app or through the API.
        /// </param>
        /// <param name="scheduledTimeUnix">
        /// When the campaign starts calling; unset to start once created.
        /// </param>
        /// <param name="branchId">
        /// The agent branch the campaign calls with.
        /// </param>
        /// <param name="environment">
        /// The environment the agent's environment variables resolve in.
        /// </param>
        /// <param name="targetConcurrencyLimit">
        /// The most calls the campaign places at once.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignResponse(
            string campaignId,
            string callName,
            string agentId,
            global::ElevenLabs.ChannelConfig channelConfig,
            global::ElevenLabs.CampaignStatus status,
            global::ElevenLabs.CampaignPolicySnapshot policy,
            global::ElevenLabs.CampaignVariant variant,
            int createdAtUnix,
            int updatedAtUnix,
            global::ElevenLabs.OutboundChannel channel,
            global::ElevenLabs.OutboundMode mode,
            global::ElevenLabs.CampaignSummaryCounts counts,
            string agentName,
            global::ElevenLabs.CampaignSource? source,
            int? scheduledTimeUnix,
            string? branchId,
            string? environment,
            int? targetConcurrencyLimit)
        {
            this.CampaignId = campaignId ?? throw new global::System.ArgumentNullException(nameof(campaignId));
            this.CallName = callName ?? throw new global::System.ArgumentNullException(nameof(callName));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ChannelConfig = channelConfig;
            this.Status = status;
            this.Policy = policy ?? throw new global::System.ArgumentNullException(nameof(policy));
            this.Variant = variant;
            this.Source = source;
            this.CreatedAtUnix = createdAtUnix;
            this.ScheduledTimeUnix = scheduledTimeUnix;
            this.UpdatedAtUnix = updatedAtUnix;
            this.BranchId = branchId;
            this.Environment = environment;
            this.TargetConcurrencyLimit = targetConcurrencyLimit;
            this.Channel = channel;
            this.Mode = mode;
            this.Counts = counts ?? throw new global::System.ArgumentNullException(nameof(counts));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignResponse" /> class.
        /// </summary>
        public CampaignResponse()
        {
        }

    }
}