
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertingWebhookNotifierResponse
    {
        /// <summary>
        /// Default Value: webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Default Value: POST
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AlertingWebhookMethodJsonConverter))]
        public global::ElevenLabs.AlertingWebhookMethod? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AlertingWebhookHeaderResponse>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingWebhookNotifierResponse" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="type">
        /// Default Value: webhook
        /// </param>
        /// <param name="method">
        /// Default Value: POST
        /// </param>
        /// <param name="headers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingWebhookNotifierResponse(
            string url,
            string? type,
            global::ElevenLabs.AlertingWebhookMethod? method,
            global::System.Collections.Generic.IList<global::ElevenLabs.AlertingWebhookHeaderResponse>? headers)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingWebhookNotifierResponse" /> class.
        /// </summary>
        public AlertingWebhookNotifierResponse()
        {
        }

    }
}