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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConvAIFileUploadResponseModel> Delete6Async(
            string fileId,
            string conversationId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete File Upload<br/>
        /// Remove a file upload from a conversation. Only possible if the file hasn't already been used in the conversation.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="conversationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ConvAIFileUploadResponseModel>> Delete6AsResponseAsync(
            string fileId,
            string conversationId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}