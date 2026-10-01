
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentDeploymentHistoryItem
    {
        /// <summary>
        /// ID of the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Map of branch IDs to traffic percentages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_percentage_branch_id_map")]
        public global::System.Collections.Generic.Dictionary<string, double>? TrafficPercentageBranchIdMap { get; set; }

        /// <summary>
        /// Unix timestamp of when the traffic split was applied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployed_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset DeployedAtUnixSecs { get; set; }

        /// <summary>
        /// Whether this is the live traffic split
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// What caused this traffic split change. Null for deployments created before this was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::ElevenLabs.AgentDeploymentSource? Source { get; set; }

        /// <summary>
        /// Access information for the deployment, including who created it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        public global::ElevenLabs.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeploymentHistoryItem" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the deployment
        /// </param>
        /// <param name="deployedAtUnixSecs">
        /// Unix timestamp of when the traffic split was applied
        /// </param>
        /// <param name="isActive">
        /// Whether this is the live traffic split
        /// </param>
        /// <param name="trafficPercentageBranchIdMap">
        /// Map of branch IDs to traffic percentages
        /// </param>
        /// <param name="source">
        /// What caused this traffic split change. Null for deployments created before this was recorded.
        /// </param>
        /// <param name="accessInfo">
        /// Access information for the deployment, including who created it
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentDeploymentHistoryItem(
            string id,
            global::System.DateTimeOffset deployedAtUnixSecs,
            bool isActive,
            global::System.Collections.Generic.Dictionary<string, double>? trafficPercentageBranchIdMap,
            global::ElevenLabs.AgentDeploymentSource? source,
            global::ElevenLabs.ResourceAccessInfo? accessInfo)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TrafficPercentageBranchIdMap = trafficPercentageBranchIdMap;
            this.DeployedAtUnixSecs = deployedAtUnixSecs;
            this.IsActive = isActive;
            this.Source = source;
            this.AccessInfo = accessInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeploymentHistoryItem" /> class.
        /// </summary>
        public AgentDeploymentHistoryItem()
        {
        }

    }
}