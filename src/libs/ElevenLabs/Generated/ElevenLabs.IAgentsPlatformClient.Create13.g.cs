#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create A New Branch<br/>
        /// Create a new branch from a given version of any branch
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentBranchResponseModel> Create13Async(
            string agentId,

            global::ElevenLabs.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create A New Branch<br/>
        /// Create a new branch from a given version of any branch
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="parentVersionId">
        /// ID of the version to branch from
        /// </param>
        /// <param name="name">
        /// Name of the branch. It is unique within the agent.
        /// </param>
        /// <param name="description">
        /// Description for the branch
        /// </param>
        /// <param name="conversationConfig">
        /// Changes to apply to conversation config
        /// </param>
        /// <param name="platformSettings">
        /// Changes to apply to platform settings
        /// </param>
        /// <param name="workflow">
        /// Updated workflow definition
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentBranchResponseModel> Create13Async(
            string agentId,
            string parentVersionId,
            string name,
            string description,
            object? conversationConfig = default,
            object? platformSettings = default,
            global::ElevenLabs.AgentWorkflowRequestModel? workflow = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}