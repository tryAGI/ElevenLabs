
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentQueueingConfig
    {
        /// <summary>
        /// Hold callers in a wait queue when the agent is at its concurrency limit, instead of rejecting them immediately<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Maximum time a caller can wait in the queue before being rejected<br/>
        /// Default Value: 180
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_timeout_seconds")]
        public int? WaitTimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentQueueingConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Hold callers in a wait queue when the agent is at its concurrency limit, instead of rejecting them immediately<br/>
        /// Default Value: false
        /// </param>
        /// <param name="waitTimeoutSeconds">
        /// Maximum time a caller can wait in the queue before being rejected<br/>
        /// Default Value: 180
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentQueueingConfig(
            bool? enabled,
            int? waitTimeoutSeconds)
        {
            this.Enabled = enabled;
            this.WaitTimeoutSeconds = waitTimeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentQueueingConfig" /> class.
        /// </summary>
        public AgentQueueingConfig()
        {
        }

    }
}