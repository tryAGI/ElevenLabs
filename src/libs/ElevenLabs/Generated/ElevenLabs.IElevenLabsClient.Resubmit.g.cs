#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Resubmit Tests<br/>
        /// Resubmits specific test runs from a test invocation.
        /// </summary>
        /// <param name="testInvocationId">
        /// The id of a test invocation. This is returned when tests are run.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResubmitAsync(
            string testInvocationId,

            global::ElevenLabs.ResubmitTestsRequestModel request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resubmit Tests<br/>
        /// Resubmits specific test runs from a test invocation.
        /// </summary>
        /// <param name="testInvocationId">
        /// The id of a test invocation. This is returned when tests are run.
        /// </param>
        /// <param name="testRunIds">
        /// List of test run IDs to resubmit
        /// </param>
        /// <param name="agentConfigOverride">
        /// Configuration overrides to use for testing. If not provided, the agent's default configuration will be used.
        /// </param>
        /// <param name="agentId">
        /// Agent ID to resubmit tests for
        /// </param>
        /// <param name="branchId">
        /// ID of the branch to run the tests on. If not provided, the tests will be run on the agent default configuration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ResubmitAsync(
            string testInvocationId,
            global::System.Collections.Generic.IList<string> testRunIds,
            string agentId,
            global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? agentConfigOverride = default,
            string? branchId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}