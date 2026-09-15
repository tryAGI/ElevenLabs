
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlertingSlackNotifier
    {
        /// <summary>
        /// Default Value: integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: slack
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_type")]
        public string? IntegrationType { get; set; }

        /// <summary>
        /// ID of the workspace integration connection to deliver alert lifecycle notifications to. The connection's integration must have the monitoring capability and match ``integration_type``.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionId { get; set; }

        /// <summary>
        /// ID of the Slack channel to post alert notifications to, e.g. ``C0123456789``. The Slack app must be a member of the channel and have the ``chat:write`` scope, or ``chat:write.public`` for public channels it has not joined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChannelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingSlackNotifier" /> class.
        /// </summary>
        /// <param name="connectionId">
        /// ID of the workspace integration connection to deliver alert lifecycle notifications to. The connection's integration must have the monitoring capability and match ``integration_type``.
        /// </param>
        /// <param name="channelId">
        /// ID of the Slack channel to post alert notifications to, e.g. ``C0123456789``. The Slack app must be a member of the channel and have the ``chat:write`` scope, or ``chat:write.public`` for public channels it has not joined.
        /// </param>
        /// <param name="type">
        /// Default Value: integration
        /// </param>
        /// <param name="integrationType">
        /// Default Value: slack
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingSlackNotifier(
            string connectionId,
            string channelId,
            string? type,
            string? integrationType)
        {
            this.Type = type;
            this.IntegrationType = integrationType;
            this.ConnectionId = connectionId ?? throw new global::System.ArgumentNullException(nameof(connectionId));
            this.ChannelId = channelId ?? throw new global::System.ArgumentNullException(nameof(channelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingSlackNotifier" /> class.
        /// </summary>
        public AlertingSlackNotifier()
        {
        }

    }
}