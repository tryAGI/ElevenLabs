#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Upload File<br/>
        /// Upload an image or PDF file for a conversation. Returns a unique file ID that can be used to reference the file in the conversation.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConvAIFileUploadResponseModel> Create6Async(
            string conversationId,

            global::ElevenLabs.BodyUploadFileV1ConvaiConversationsConversationIdFilesPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File<br/>
        /// Upload an image or PDF file for a conversation. Returns a unique file ID that can be used to reference the file in the conversation.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="file">
        /// Image or PDF file to upload
        /// </param>
        /// <param name="filename">
        /// Image or PDF file to upload
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConvAIFileUploadResponseModel> Create6Async(
            string conversationId,
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}