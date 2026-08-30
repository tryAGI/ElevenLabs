
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlertingIntegrationNotifier
    {
        /// <summary>
        /// Default Value: integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID of the workspace integration connection (e.g. PagerDuty) to deliver alert lifecycle notifications to. The connection's integration must have the monitoring capability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingIntegrationNotifier" /> class.
        /// </summary>
        /// <param name="connectionId">
        /// ID of the workspace integration connection (e.g. PagerDuty) to deliver alert lifecycle notifications to. The connection's integration must have the monitoring capability.
        /// </param>
        /// <param name="type">
        /// Default Value: integration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingIntegrationNotifier(
            string connectionId,
            string? type)
        {
            this.Type = type;
            this.ConnectionId = connectionId ?? throw new global::System.ArgumentNullException(nameof(connectionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingIntegrationNotifier" /> class.
        /// </summary>
        public AlertingIntegrationNotifier()
        {
        }

    }
}