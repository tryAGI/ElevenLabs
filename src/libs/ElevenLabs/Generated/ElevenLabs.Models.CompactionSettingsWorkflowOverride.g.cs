
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompactionSettingsWorkflowOverride
    {
        /// <summary>
        /// Whether context compaction is enabled for this agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Context window fraction at which compaction is triggered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_trigger_fraction")]
        public double? SoftTriggerFraction { get; set; }

        /// <summary>
        /// Number of recent messages kept verbatim after compaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tail_size")]
        public int? TailSize { get; set; }

        /// <summary>
        /// Minimum number of tokens that compaction must reclaim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_reclaimable_tokens")]
        public int? MinReclaimableTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionSettingsWorkflowOverride" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether context compaction is enabled for this agent.
        /// </param>
        /// <param name="softTriggerFraction">
        /// Context window fraction at which compaction is triggered.
        /// </param>
        /// <param name="tailSize">
        /// Number of recent messages kept verbatim after compaction.
        /// </param>
        /// <param name="minReclaimableTokens">
        /// Minimum number of tokens that compaction must reclaim.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionSettingsWorkflowOverride(
            bool? enabled,
            double? softTriggerFraction,
            int? tailSize,
            int? minReclaimableTokens)
        {
            this.Enabled = enabled;
            this.SoftTriggerFraction = softTriggerFraction;
            this.TailSize = tailSize;
            this.MinReclaimableTokens = minReclaimableTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionSettingsWorkflowOverride" /> class.
        /// </summary>
        public CompactionSettingsWorkflowOverride()
        {
        }

    }
}