
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAlertingWebhookNotifier
    {
        /// <summary>
        /// Default Value: webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The URL to send alert lifecycle notifications to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Optional static request headers sent with each alert webhook call, for example to authenticate with the receiving endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequestHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAlertingWebhookNotifier" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to send alert lifecycle notifications to.
        /// </param>
        /// <param name="type">
        /// Default Value: webhook
        /// </param>
        /// <param name="requestHeaders">
        /// Optional static request headers sent with each alert webhook call, for example to authenticate with the receiving endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAlertingWebhookNotifier(
            string url,
            string? type,
            global::System.Collections.Generic.Dictionary<string, string>? requestHeaders)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.RequestHeaders = requestHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAlertingWebhookNotifier" /> class.
        /// </summary>
        public AgentAlertingWebhookNotifier()
        {
        }

    }
}