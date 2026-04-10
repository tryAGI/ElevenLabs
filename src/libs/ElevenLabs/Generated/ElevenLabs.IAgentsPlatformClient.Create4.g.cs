#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Send Conversation Feedback<br/>
        /// Send the feedback for the given conversation
        /// </summary>
        /// <param name="conversationId">
        /// The id of the conversation you're taking the action on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Create4Async(
            string conversationId,

            global::ElevenLabs.ConversationFeedbackRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send Conversation Feedback<br/>
        /// Send the feedback for the given conversation
        /// </summary>
        /// <param name="conversationId">
        /// The id of the conversation you're taking the action on.
        /// </param>
        /// <param name="feedback">
        /// Either 'like' or 'dislike' to indicate the feedback for the conversation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> Create4Async(
            string conversationId,
            global::ElevenLabs.UserFeedbackScore? feedback = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}