#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Run Tests On The Agent<br/>
        /// Run selected tests on the agent with provided configuration. If the agent configuration is provided, it will be used to override default agent configuration.
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTestSuiteInvocationResponseModel> CreateConvaiAgentsByAgentIdRunTestsAsync(
            string agentId,
            global::ElevenLabs.RunAgentTestsRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Run Tests On The Agent<br/>
        /// Run selected tests on the agent with provided configuration. If the agent configuration is provided, it will be used to override default agent configuration.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="tests">
        /// List of tests to run on the agent
        /// </param>
        /// <param name="agentConfigOverride"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTestSuiteInvocationResponseModel> CreateConvaiAgentsByAgentIdRunTestsAsync(
            string agentId,
            global::System.Collections.Generic.IList<global::ElevenLabs.SingleTestRunRequestModel> tests,
            string? xiApiKey = default,
            global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? agentConfigOverride = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}