
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAlertingMonitorConfig
    {
        /// <summary>
        /// Failure rate threshold at which this monitor can notify.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentAlertingMonitorConfig" /> class.
        /// </summary>
        /// <param name="threshold">
        /// Failure rate threshold at which this monitor can notify.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="autoResolveAfterInactiveMinutes">
        /// How many minutes an alert can stay inactive before it is auto-resolved.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAlertingMonitorConfig(
            double? threshold,
            int? autoResolveAfterInactiveMinutes)
        {
            this.Threshold = threshold;
            this.AutoResolveAfterInactiveMinutes = autoResolveAfterInactiveMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAlertingMonitorConfig" /> class.
        /// </summary>
        public AgentAlertingMonitorConfig()
        {
        }

    }
}