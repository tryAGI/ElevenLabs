
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Alerting configuration used at both per-agent and per-workspace level.<br/>
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
        /// Delivery channels for alert lifecycle notifications. Stacked with other layers and deduped by ``webhook_id``, PagerDuty ``connection_id``, or Slack ``(connection_id, channel_id)``.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifiers")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>>? Notifiers { get; set; }

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
        /// <param name="notifiers">
        /// Delivery channels for alert lifecycle notifications. Stacked with other layers and deduped by ``webhook_id``, PagerDuty ``connection_id``, or Slack ``(connection_id, channel_id)``.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingSettings(
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AlertingMonitorConfig>? monitorConfigs,
            int? autoResolveAfterInactiveMinutes,
            global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>>? notifiers)
        {
            this.MonitorConfigs = monitorConfigs;
            this.AutoResolveAfterInactiveMinutes = autoResolveAfterInactiveMinutes;
            this.Notifiers = notifiers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingSettings" /> class.
        /// </summary>
        public AlertingSettings()
        {
        }

    }
}