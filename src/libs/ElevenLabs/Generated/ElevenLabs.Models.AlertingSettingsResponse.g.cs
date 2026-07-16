
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Customer-facing view of alerting settings. Unlike AdminAlertingSettingsResponse,<br/>
    /// it has no internal_notifiers field: those are ElevenLabs-internal delivery<br/>
    /// channels whose URLs must never be returned outside the admin API.
    /// </summary>
    public sealed partial class AlertingSettingsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitor_configs")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AlertingMonitorConfig>? MonitorConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_resolve_after_inactive_minutes")]
        public int? AutoResolveAfterInactiveMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifiers")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AlertingWebhookNotifierResponse>? Notifiers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingSettingsResponse" /> class.
        /// </summary>
        /// <param name="monitorConfigs"></param>
        /// <param name="autoResolveAfterInactiveMinutes"></param>
        /// <param name="notifiers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingSettingsResponse(
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AlertingMonitorConfig>? monitorConfigs,
            int? autoResolveAfterInactiveMinutes,
            global::System.Collections.Generic.IList<global::ElevenLabs.AlertingWebhookNotifierResponse>? notifiers)
        {
            this.MonitorConfigs = monitorConfigs;
            this.AutoResolveAfterInactiveMinutes = autoResolveAfterInactiveMinutes;
            this.Notifiers = notifiers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingSettingsResponse" /> class.
        /// </summary>
        public AlertingSettingsResponse()
        {
        }

    }
}