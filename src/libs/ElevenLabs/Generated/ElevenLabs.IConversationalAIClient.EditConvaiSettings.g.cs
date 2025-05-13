#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Update Convai Settings<br/>
        /// Update Convai settings for the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConvAISettingsResponseModel> EditConvaiSettingsAsync(
            global::ElevenLabs.PatchConvAISettingsRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Convai Settings<br/>
        /// Update Convai settings for the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="conversationInitiationClientDataWebhook"></param>
        /// <param name="webhooks"></param>
        /// <param name="ragRetentionPeriodDays">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConvAISettingsResponseModel> EditConvaiSettingsAsync(
            string? xiApiKey = default,
            global::ElevenLabs.ConversationInitiationClientDataWebhook? conversationInitiationClientDataWebhook = default,
            global::ElevenLabs.ConvAIWebhooks? webhooks = default,
            int? ragRetentionPeriodDays = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}