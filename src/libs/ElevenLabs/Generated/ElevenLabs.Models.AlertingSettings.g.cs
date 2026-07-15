
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Alerting configuration used at both per-agent and per-workspace level.<br/>
    /// All fields are optional overrides; the cascade resolver fills in defaults<br/>
    /// when they are unset. Notifiers stack and dedupe (by URL) across the<br/>
    /// workspace and agent layers rather than overriding each other.<br/>
    /// Cascade order for per-monitor threshold and auto-resolve: agent → workspace →<br/>
    /// system default.
    /// </summary>
    public sealed partial class AlertingSettings
    {
        /// <summary>
        /// Alerting configuration keyed by monitor name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitor_configs")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AlertingMonitorConfig>? MonitorConfigs { get; set; }

        /// <summary>
        /// How many minutes an alert can stay inactive before it is auto-resolved. Unset values fall through to the next layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_resolve_after_inactive_minutes")]
        public int? AutoResolveAfterInactiveMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingSettings" /> class.
        /// </summary>
        /// <param name="monitorConfigs">
        /// Alerting configuration keyed by monitor name.
        /// </param>
        /// <param name="autoResolveAfterInactiveMinutes">
        /// How many minutes an alert can stay inactive before it is auto-resolved. Unset values fall through to the next layer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingSettings(
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AlertingMonitorConfig>? monitorConfigs,
            int? autoResolveAfterInactiveMinutes)
        {
            this.MonitorConfigs = monitorConfigs;
            this.AutoResolveAfterInactiveMinutes = autoResolveAfterInactiveMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingSettings" /> class.
        /// </summary>
        public AlertingSettings()
        {
        }

    }
}