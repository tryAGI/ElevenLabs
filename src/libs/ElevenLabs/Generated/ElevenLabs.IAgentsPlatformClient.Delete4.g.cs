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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConvAIFileUploadResponseModel> Delete4Async(
            string fileId,
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}