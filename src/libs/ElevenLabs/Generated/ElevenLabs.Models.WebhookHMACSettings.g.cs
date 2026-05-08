
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Settings for creating an HMAC-authenticated webhook
    /// </summary>
    public sealed partial class WebhookHMACSettings
    {
        /// <summary>
        /// The authentication type for this webhook
        /// </summary>
        /// <default>"hmac"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public string AuthType { get; set; } = "hmac";

        /// <summary>
        /// The display name for this webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The HTTPS callback URL that will be called when this webhook is triggered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookUrl { get; set; }

        /// <summary>
        /// Optional custom request headers to include with each webhook delivery
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequestHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookHMACSettings" /> class.
        /// </summary>
        /// <param name="name">
        /// The display name for this webhook
        /// </param>
        /// <param name="webhookUrl">
        /// The HTTPS callback URL that will be called when this webhook is triggered
        /// </param>
        /// <param name="requestHeaders">
        /// Optional custom request headers to include with each webhook delivery
        /// </param>
        /// <param name="authType">
        /// The authentication type for this webhook
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookHMACSettings(
            string name,
            string webhookUrl,
            global::System.Collections.Generic.Dictionary<string, string>? requestHeaders,
            string authType = "hmac")
        {
            this.AuthType = authType;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.RequestHeaders = requestHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookHMACSettings" /> class.
        /// </summary>
        public WebhookHMACSettings()
        {
        }
    }
}