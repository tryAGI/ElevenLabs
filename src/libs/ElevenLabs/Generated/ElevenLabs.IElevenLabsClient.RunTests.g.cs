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
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTestSuiteInvocationResponseModel> RunTestsAsync(
            string agentId,

            global::ElevenLabs.RunAgentTestsRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Tests On The Agent<br/>
        /// Run selected tests on the agent with provided configuration. If the agent configuration is provided, it will be used to override default agent configuration.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="tests">
        /// List of tests to run on the agent
        /// </param>
        /// <param name="agentConfigOverride">
        /// Configuration overrides to use for testing. If not provided, the agent's default configuration will be used.
        /// </param>
        /// <param name="branchId">
        /// ID of the branch to run the tests on. If not provided, the tests will be run on the agent default configuration.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTestSuiteInvocationResponseModel> RunTestsAsync(
            string agentId,
            global::System.Collections.Generic.IList<global::ElevenLabs.SingleTestRunRequestModel> tests,
            global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? agentConfigOverride = default,
            string? branchId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}