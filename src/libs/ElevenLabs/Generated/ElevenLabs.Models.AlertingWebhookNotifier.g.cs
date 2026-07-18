
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertingWebhookNotifier
    {
        /// <summary>
        /// Default Value: webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID of the workspace webhook to deliver alert lifecycle notifications to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingWebhookNotifier" /> class.
        /// </summary>
        /// <param name="webhookId">
        /// ID of the workspace webhook to deliver alert lifecycle notifications to.
        /// </param>
        /// <param name="type">
        /// Default Value: webhook
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingWebhookNotifier(
            string webhookId,
            string? type)
        {
            this.Type = type;
            this.WebhookId = webhookId ?? throw new global::System.ArgumentNullException(nameof(webhookId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingWebhookNotifier" /> class.
        /// </summary>
        public AlertingWebhookNotifier()
        {
        }

    }
}