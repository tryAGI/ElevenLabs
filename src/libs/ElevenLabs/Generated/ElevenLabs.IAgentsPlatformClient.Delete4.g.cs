#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete File Upload<br/>
        /// Remove a file upload from a conversation. Only possible if the file hasn't already been used in the conversation.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="conversationId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConvAIFileUploadResponseModel> Delete4Async(
            string fileId,
            string conversationId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}