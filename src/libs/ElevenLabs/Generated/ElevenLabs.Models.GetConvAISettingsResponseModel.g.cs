
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConvAISettingsResponseModel
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
        /// Whether the workspace can use MCP servers<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_mcp_servers")]
        public bool? CanUseMcpServers { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_retention_period_days")]
        public int? RagRetentionPeriodDays { get; set; }

        /// <summary>
        /// Days to retain conversation embeddings. None means use the system default (30 days).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_embedding_retention_days")]
        public int? ConversationEmbeddingRetentionDays { get; set; }

        /// <summary>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_livekit_stack")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.LivekitStackTypeJsonConverter))]
        public global::ElevenLabs.LivekitStackType? DefaultLivekitStack { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConvAISettingsResponseModel" /> class.
        /// </summary>
        /// <param name="conversationInitiationClientDataWebhook"></param>
        /// <param name="webhooks"></param>
        /// <param name="canUseMcpServers">
        /// Whether the workspace can use MCP servers<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ragRetentionPeriodDays">
        /// Default Value: 10
        /// </param>
        /// <param name="conversationEmbeddingRetentionDays">
        /// Days to retain conversation embeddings. None means use the system default (30 days).
        /// </param>
        /// <param name="defaultLivekitStack">
        /// Default Value: standard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConvAISettingsResponseModel(
            global::ElevenLabs.ConversationInitiationClientDataWebhook? conversationInitiationClientDataWebhook,
            global::ElevenLabs.ConvAIWebhooks? webhooks,
            bool? canUseMcpServers,
            int? ragRetentionPeriodDays,
            int? conversationEmbeddingRetentionDays,
            global::ElevenLabs.LivekitStackType? defaultLivekitStack)
        {
            this.ConversationInitiationClientDataWebhook = conversationInitiationClientDataWebhook;
            this.Webhooks = webhooks;
            this.CanUseMcpServers = canUseMcpServers;
            this.RagRetentionPeriodDays = ragRetentionPeriodDays;
            this.ConversationEmbeddingRetentionDays = conversationEmbeddingRetentionDays;
            this.DefaultLivekitStack = defaultLivekitStack;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConvAISettingsResponseModel" /> class.
        /// </summary>
        public GetConvAISettingsResponseModel()
        {
        }
    }
}