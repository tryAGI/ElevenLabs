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
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateConvaiTestInvocationsByTestInvocationIdResubmitAsync(
            string testInvocationId,
            global::ElevenLabs.ResubmitTestsRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Resubmit Tests<br/>
        /// Resubmits specific test runs from a test invocation.
        /// </summary>
        /// <param name="testInvocationId">
        /// The id of a test invocation. This is returned when tests are run.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="testRunIds">
        /// List of test run IDs to resubmit
        /// </param>
        /// <param name="agentConfigOverride"></param>
        /// <param name="agentId">
        /// Agent ID to resubmit tests for
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateConvaiTestInvocationsByTestInvocationIdResubmitAsync(
            string testInvocationId,
            global::System.Collections.Generic.IList<string> testRunIds,
            string agentId,
            string? xiApiKey = default,
            global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? agentConfigOverride = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}