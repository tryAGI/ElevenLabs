#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Conversation Details<br/>
        /// Get the details of a particular conversation
        /// </summary>
        /// <param name="conversationId">
        /// The id of the conversation you're taking the action on.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConversationResponseModel> Get5Async(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}