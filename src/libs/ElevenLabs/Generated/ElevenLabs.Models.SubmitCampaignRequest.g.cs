
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubmitCampaignRequest
    {
        /// <summary>
        /// The campaign's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallName { get; set; }

        /// <summary>
        /// The agent that places the calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Who to call. Each recipient becomes a lead of the campaign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.SubmitCampaignRecipient> Recipients { get; set; }

        /// <summary>
        /// When to start calling; omit to start now. Calls still wait for the next calling window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_time_unix")]
        public int? ScheduledTimeUnix { get; set; }

        /// <summary>
        /// IANA timezone to read the calling windows in, overriding the policy's.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// The agent branch to call with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// The environment to resolve the agent's environment variables in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// The most calls to place at once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_concurrency_limit")]
        public int? TargetConcurrencyLimit { get; set; }

        /// <summary>
        /// Makes the request safe to retry: a repeat with the same key returns the campaign it created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idempotency_key")]
        public string? IdempotencyKey { get; set; }

        /// <summary>
        /// Policy to snapshot onto the campaign. When set, it wins over the workspace default and any per-agent override; when omitted, the workspace configuration must exist and supplies the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        public global::ElevenLabs.PolicyConfigInput? Policy { get; set; }

        /// <summary>
        /// `simple` runs one attempt per recipient with always-on calling windows and nothing collected, and cannot be combined with `policy`. `advanced` uses `policy` or the workspace configuration, and is the default for phone campaigns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        public global::ElevenLabs.CampaignVariant? Variant { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ChannelConfig2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ChannelConfig2 ChannelConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCampaignRequest" /> class.
        /// </summary>
        /// <param name="callName">
        /// The campaign's name.
        /// </param>
        /// <param name="agentId">
        /// The agent that places the calls.
        /// </param>
        /// <param name="recipients">
        /// Who to call. Each recipient becomes a lead of the campaign.
        /// </param>
        /// <param name="channelConfig"></param>
        /// <param name="scheduledTimeUnix">
        /// When to start calling; omit to start now. Calls still wait for the next calling window.
        /// </param>
        /// <param name="timezone">
        /// IANA timezone to read the calling windows in, overriding the policy's.
        /// </param>
        /// <param name="branchId">
        /// The agent branch to call with.
        /// </param>
        /// <param name="environment">
        /// The environment to resolve the agent's environment variables in.
        /// </param>
        /// <param name="targetConcurrencyLimit">
        /// The most calls to place at once.
        /// </param>
        /// <param name="idempotencyKey">
        /// Makes the request safe to retry: a repeat with the same key returns the campaign it created.
        /// </param>
        /// <param name="policy">
        /// Policy to snapshot onto the campaign. When set, it wins over the workspace default and any per-agent override; when omitted, the workspace configuration must exist and supplies the policy.
        /// </param>
        /// <param name="variant">
        /// `simple` runs one attempt per recipient with always-on calling windows and nothing collected, and cannot be combined with `policy`. `advanced` uses `policy` or the workspace configuration, and is the default for phone campaigns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitCampaignRequest(
            string callName,
            string agentId,
            global::System.Collections.Generic.IList<global::ElevenLabs.SubmitCampaignRecipient> recipients,
            global::ElevenLabs.ChannelConfig2 channelConfig,
            int? scheduledTimeUnix,
            string? timezone,
            string? branchId,
            string? environment,
            int? targetConcurrencyLimit,
            string? idempotencyKey,
            global::ElevenLabs.PolicyConfigInput? policy,
            global::ElevenLabs.CampaignVariant? variant)
        {
            this.CallName = callName ?? throw new global::System.ArgumentNullException(nameof(callName));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
            this.ScheduledTimeUnix = scheduledTimeUnix;
            this.Timezone = timezone;
            this.BranchId = branchId;
            this.Environment = environment;
            this.TargetConcurrencyLimit = targetConcurrencyLimit;
            this.IdempotencyKey = idempotencyKey;
            this.Policy = policy;
            this.Variant = variant;
            this.ChannelConfig = channelConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCampaignRequest" /> class.
        /// </summary>
        public SubmitCampaignRequest()
        {
        }

    }
}