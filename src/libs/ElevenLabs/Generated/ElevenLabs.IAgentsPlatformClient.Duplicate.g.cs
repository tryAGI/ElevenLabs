#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Duplicate Agent<br/>
        /// Create a new agent by duplicating an existing one
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentResponseModel> DuplicateAsync(
            string agentId,

            global::ElevenLabs.BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate Agent<br/>
        /// Create a new agent by duplicating an existing one
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="name">
        /// A name to make the agent easier to find
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentResponseModel> DuplicateAsync(
            string agentId,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}