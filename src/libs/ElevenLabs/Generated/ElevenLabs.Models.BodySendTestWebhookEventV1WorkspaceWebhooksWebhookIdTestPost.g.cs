
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodySendTestWebhookEventV1WorkspaceWebhooksWebhookIdTestPost
    {
        /// <summary>
        /// The event type to send a sample of.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WebhookTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.WebhookTypes WebhookType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySendTestWebhookEventV1WorkspaceWebhooksWebhookIdTestPost" /> class.
        /// </summary>
        /// <param name="webhookType">
        /// The event type to send a sample of.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySendTestWebhookEventV1WorkspaceWebhooksWebhookIdTestPost(
            global::ElevenLabs.WebhookTypes webhookType)
        {
            this.WebhookType = webhookType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySendTestWebhookEventV1WorkspaceWebhooksWebhookIdTestPost" /> class.
        /// </summary>
        public BodySendTestWebhookEventV1WorkspaceWebhooksWebhookIdTestPost()
        {
        }

    }
}