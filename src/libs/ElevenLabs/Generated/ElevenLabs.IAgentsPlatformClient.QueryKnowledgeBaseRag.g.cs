#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Query Agent Knowledge Base Rag<br/>
        /// Run the agent's exact RAG retrieval for an ad-hoc query and return the ranked chunks the agent would retrieve. Read-only: no conversation is created. The response reflects current retrieval internals and may evolve.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch to use
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentKnowledgeBaseRagQueryResponseModel> QueryKnowledgeBaseRagAsync(
            string agentId,

            global::ElevenLabs.AgentKnowledgeBaseRagQueryRequestModel request,
            string? branchId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Agent Knowledge Base Rag<br/>
        /// Run the agent's exact RAG retrieval for an ad-hoc query and return the ranked chunks the agent would retrieve. Read-only: no conversation is created. The response reflects current retrieval internals and may evolve.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch to use
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AgentKnowledgeBaseRagQueryResponseModel>> QueryKnowledgeBaseRagAsResponseAsync(
            string agentId,

            global::ElevenLabs.AgentKnowledgeBaseRagQueryRequestModel request,
            string? branchId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Agent Knowledge Base Rag<br/>
        /// Run the agent's exact RAG retrieval for an ad-hoc query and return the ranked chunks the agent would retrieve. Read-only: no conversation is created. The response reflects current retrieval internals and may evolve.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch to use
        /// </param>
        /// <param name="query">
        /// Query to run against the agent's knowledge base RAG index.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentKnowledgeBaseRagQueryResponseModel> QueryKnowledgeBaseRagAsync(
            string agentId,
            string query,
            string? branchId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}