#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Duplicate Agent<br/>
        /// Create a new agent by duplicating an existing one
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentResponseModel> CreateConvaiAgentsByAgentIdDuplicateAsync(
            string agentId,
            global::ElevenLabs.BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Duplicate Agent<br/>
        /// Create a new agent by duplicating an existing one
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// A name to make the agent easier to find<br/>
        /// Example: My agent
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentResponseModel> CreateConvaiAgentsByAgentIdDuplicateAsync(
            string agentId,
            string? xiApiKey = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}