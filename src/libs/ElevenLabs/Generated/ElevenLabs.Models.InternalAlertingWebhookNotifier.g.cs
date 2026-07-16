
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InternalAlertingWebhookNotifier
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
        /// HTTP method used when calling the webhook URL.<br/>
        /// Default Value: POST
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AlertingWebhookMethodJsonConverter))]
        public global::ElevenLabs.AlertingWebhookMethod? Method { get; set; }

        /// <summary>
        /// Custom request headers sent with every notification. Secret header values are encrypted at rest and never returned by the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AlertingWebhookHeader>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalAlertingWebhookNotifier" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to send alert lifecycle notifications to.
        /// </param>
        /// <param name="type">
        /// Default Value: webhook
        /// </param>
        /// <param name="method">
        /// HTTP method used when calling the webhook URL.<br/>
        /// Default Value: POST
        /// </param>
        /// <param name="headers">
        /// Custom request headers sent with every notification. Secret header values are encrypted at rest and never returned by the API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalAlertingWebhookNotifier(
            string url,
            string? type,
            global::ElevenLabs.AlertingWebhookMethod? method,
            global::System.Collections.Generic.IList<global::ElevenLabs.AlertingWebhookHeader>? headers)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalAlertingWebhookNotifier" /> class.
        /// </summary>
        public InternalAlertingWebhookNotifier()
        {
        }

    }
}