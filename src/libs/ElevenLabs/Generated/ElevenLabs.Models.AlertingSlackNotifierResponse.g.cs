
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlertingSlackNotifierResponse
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionId { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="AlertingSlackNotifierResponse" /> class.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="channelId"></param>
        /// <param name="type">
        /// Default Value: integration
        /// </param>
        /// <param name="integrationType">
        /// Default Value: slack
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingSlackNotifierResponse(
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
        /// Initializes a new instance of the <see cref="AlertingSlackNotifierResponse" /> class.
        /// </summary>
        public AlertingSlackNotifierResponse()
        {
        }

    }
}