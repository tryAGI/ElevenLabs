#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Get Webrtc Token<br/>
        /// Get a WebRTC session token for real-time communication.
        /// </summary>
        /// <param name="agentId">
        /// The id of the agent you're taking the action on.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="participantName">
        /// Optional custom participant name. If not provided, user ID will be used
        /// </param>
        /// <param name="source">
        /// Enum representing the possible sources for conversation initiation.
        /// </param>
        /// <param name="version">
        /// The SDK version number
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TokenResponseModel> GetConvaiConversationTokenAsync(
            string agentId,
            string? participantName = default,
            global::ElevenLabs.ConversationInitiationSource? source = default,
            string? version = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}