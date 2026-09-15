
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlertingPagerDutyNotifierResponse
    {
        /// <summary>
        /// Default Value: integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: pagerduty
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_type")]
        public string? IntegrationType { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="AlertingPagerDutyNotifierResponse" /> class.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="type">
        /// Default Value: integration
        /// </param>
        /// <param name="integrationType">
        /// Default Value: pagerduty
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingPagerDutyNotifierResponse(
            string connectionId,
            string? type,
            string? integrationType)
        {
            this.Type = type;
            this.IntegrationType = integrationType;
            this.ConnectionId = connectionId ?? throw new global::System.ArgumentNullException(nameof(connectionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingPagerDutyNotifierResponse" /> class.
        /// </summary>
        public AlertingPagerDutyNotifierResponse()
        {
        }

    }
}