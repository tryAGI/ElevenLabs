
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAlertingSettings
    {
        /// <summary>
        /// Alerting configuration keyed by monitor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitor_configs")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AgentAlertingMonitorConfig>? MonitorConfigs { get; set; }

        /// <summary>
        /// How many minutes an alert can stay inactive before it is auto-resolved.<br/>
        /// Default Value: 15
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_resolve_after_inactive_minutes")]
        public int? AutoResolveAfterInactiveMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAlertingSettings" /> class.
        /// </summary>
        /// <param name="monitorConfigs">
        /// Alerting configuration keyed by monitor.
        /// </param>
        /// <param name="autoResolveAfterInactiveMinutes">
        /// How many minutes an alert can stay inactive before it is auto-resolved.<br/>
        /// Default Value: 15
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAlertingSettings(
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AgentAlertingMonitorConfig>? monitorConfigs,
            int? autoResolveAfterInactiveMinutes)
        {
            this.MonitorConfigs = monitorConfigs;
            this.AutoResolveAfterInactiveMinutes = autoResolveAfterInactiveMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAlertingSettings" /> class.
        /// </summary>
        public AgentAlertingSettings()
        {
        }

    }
}