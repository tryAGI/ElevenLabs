
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchConvAISettingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_client_data_webhook")]
        public global::ElevenLabs.ConversationInitiationClientDataWebhook? ConversationInitiationClientDataWebhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::ElevenLabs.ConvAIWebhooks? Webhooks { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_retention_period_days")]
        public int? RagRetentionPeriodDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConvAISettingsRequest" /> class.
        /// </summary>
        /// <param name="conversationInitiationClientDataWebhook"></param>
        /// <param name="webhooks"></param>
        /// <param name="ragRetentionPeriodDays">
        /// Default Value: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConvAISettingsRequest(
            global::ElevenLabs.ConversationInitiationClientDataWebhook? conversationInitiationClientDataWebhook,
            global::ElevenLabs.ConvAIWebhooks? webhooks,
            int? ragRetentionPeriodDays)
        {
            this.ConversationInitiationClientDataWebhook = conversationInitiationClientDataWebhook;
            this.Webhooks = webhooks;
            this.RagRetentionPeriodDays = ragRetentionPeriodDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConvAISettingsRequest" /> class.
        /// </summary>
        public PatchConvAISettingsRequest()
        {
        }
    }
}