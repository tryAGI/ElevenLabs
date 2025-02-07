
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentCallLimits
    {
        /// <summary>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_concurrency_limit")]
        public int? AgentConcurrencyLimit { get; set; }

        /// <summary>
        /// Default Value: 100000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_limit")]
        public int? DailyLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCallLimits" /> class.
        /// </summary>
        /// <param name="agentConcurrencyLimit">
        /// Default Value: -1
        /// </param>
        /// <param name="dailyLimit">
        /// Default Value: 100000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCallLimits(
            int? agentConcurrencyLimit,
            int? dailyLimit)
        {
            this.AgentConcurrencyLimit = agentConcurrencyLimit;
            this.DailyLimit = dailyLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCallLimits" /> class.
        /// </summary>
        public AgentCallLimits()
        {
        }
    }
}