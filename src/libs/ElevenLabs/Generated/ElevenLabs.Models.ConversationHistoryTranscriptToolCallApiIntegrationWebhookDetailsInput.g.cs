
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput
    {
        /// <summary>
        /// Default Value: api_integration_webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_id")]
        public string? IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_connection_id")]
        public string? IntegrationConnectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails WebhookDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: api_integration_webhook
        /// </param>
        /// <param name="integrationId"></param>
        /// <param name="credentialId"></param>
        /// <param name="integrationConnectionId"></param>
        /// <param name="webhookDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput(
            global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails webhookDetails,
            string? type,
            string? integrationId,
            string? credentialId,
            string? integrationConnectionId)
        {
            this.WebhookDetails = webhookDetails ?? throw new global::System.ArgumentNullException(nameof(webhookDetails));
            this.Type = type;
            this.IntegrationId = integrationId;
            this.CredentialId = credentialId;
            this.IntegrationConnectionId = integrationConnectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput" /> class.
        /// </summary>
        public ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput()
        {
        }
    }
}