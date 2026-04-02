#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create Or Update Deployments<br/>
        /// Create a new deployment for an agent
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentDeploymentResponse> Create13Async(
            string agentId,

            global::ElevenLabs.BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Or Update Deployments<br/>
        /// Create a new deployment for an agent
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="deploymentRequest">
        /// Request to create a new deployment
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentDeploymentResponse> Create13Async(
            string agentId,
            global::ElevenLabs.AgentDeploymentRequest deploymentRequest,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}