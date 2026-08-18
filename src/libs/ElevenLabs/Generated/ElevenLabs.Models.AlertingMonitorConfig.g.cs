
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertingMonitorConfig
    {
        /// <summary>
        /// Failure rate threshold at which this monitor can notify.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Relative increase over the trailing baseline at which this monitor can notify (0.2 = 20% above baseline).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relative_increase_threshold")]
        public double? RelativeIncreaseThreshold { get; set; }

        /// <summary>
        /// How many suspect buckets within the lookback window are required to promote a suspect to an alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspect_trigger_threshold")]
        public int? SuspectTriggerThreshold { get; set; }

        /// <summary>
        /// How many minutes an alert can stay inactive before it is auto-resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_resolve_after_inactive_minutes")]
        public int? AutoResolveAfterInactiveMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingMonitorConfig" /> class.
        /// </summary>
        /// <param name="threshold">
        /// Failure rate threshold at which this monitor can notify.
        /// </param>
        /// <param name="relativeIncreaseThreshold">
        /// Relative increase over the trailing baseline at which this monitor can notify (0.2 = 20% above baseline).
        /// </param>
        /// <param name="suspectTriggerThreshold">
        /// How many suspect buckets within the lookback window are required to promote a suspect to an alert.
        /// </param>
        /// <param name="autoResolveAfterInactiveMinutes">
        /// How many minutes an alert can stay inactive before it is auto-resolved.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingMonitorConfig(
            double? threshold,
            double? relativeIncreaseThreshold,
            int? suspectTriggerThreshold,
            int? autoResolveAfterInactiveMinutes)
        {
            this.Threshold = threshold;
            this.RelativeIncreaseThreshold = relativeIncreaseThreshold;
            this.SuspectTriggerThreshold = suspectTriggerThreshold;
            this.AutoResolveAfterInactiveMinutes = autoResolveAfterInactiveMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingMonitorConfig" /> class.
        /// </summary>
        public AlertingMonitorConfig()
        {
        }

    }
}