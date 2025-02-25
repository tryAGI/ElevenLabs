
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConvaiSettingsResponseModel
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig> Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConvaiSettingsResponseModel" /> class.
        /// </summary>
        /// <param name="conversationInitiationClientDataWebhook"></param>
        /// <param name="webhooks"></param>
        /// <param name="secrets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConvaiSettingsResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig> secrets,
            global::ElevenLabs.ConversationInitiationClientDataWebhook? conversationInitiationClientDataWebhook,
            global::ElevenLabs.ConvAIWebhooks? webhooks)
        {
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.ConversationInitiationClientDataWebhook = conversationInitiationClientDataWebhook;
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConvaiSettingsResponseModel" /> class.
        /// </summary>
        public GetConvaiSettingsResponseModel()
        {
        }
    }
}