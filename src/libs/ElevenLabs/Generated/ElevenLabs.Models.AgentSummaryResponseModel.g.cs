
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentSummaryResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentSummaryResponseModelAccessLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentSummaryResponseModelAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSummaryResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="name"></param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="accessLevel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSummaryResponseModel(
            string agentId,
            string name,
            int createdAtUnixSecs,
            global::ElevenLabs.AgentSummaryResponseModelAccessLevel accessLevel)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.AccessLevel = accessLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSummaryResponseModel" /> class.
        /// </summary>
        public AgentSummaryResponseModel()
        {
        }
    }
}