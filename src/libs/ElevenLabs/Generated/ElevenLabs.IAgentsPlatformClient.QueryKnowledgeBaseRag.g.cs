#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Query Agent Knowledge Base Rag<br/>
        /// Run one of the agent's exact knowledge base retrieval strategies for an ad-hoc request and return what the agent would retrieve: ranked chunks for semantic or keyword search, a document's content for cat, or the entries of a folder for ls. Read-only: no conversation is created. The response reflects current retrieval internals and may evolve.
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
        /// Run one of the agent's exact knowledge base retrieval strategies for an ad-hoc request and return what the agent would retrieve: ranked chunks for semantic or keyword search, a document's content for cat, or the entries of a folder for ls. Read-only: no conversation is created. The response reflects current retrieval internals and may evolve.
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
        /// Run one of the agent's exact knowledge base retrieval strategies for an ad-hoc request and return what the agent would retrieve: ranked chunks for semantic or keyword search, a document's content for cat, or the entries of a folder for ls. Read-only: no conversation is created. The response reflects current retrieval internals and may evolve.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch to use
        /// </param>
        /// <param name="strategy">
        /// Retrieval strategy to run, as in the agent's knowledge_base tool: semantic or keyword search for a query, cat to read one document in full, or ls to list the entries of a folder. Any strategy runs, whether or not the agent has it enabled.<br/>
        /// Default Value: semantic
        /// </param>
        /// <param name="query">
        /// Query to search the knowledge base for. Required for the semantic and keyword strategies.
        /// </param>
        /// <param name="documents">
        /// IDs or names of knowledge base documents or folders. Semantic and keyword search only search these entries; cat reads the single document given; ls lists the single folder given, or the top level of the knowledge base when omitted.
        /// </param>
        /// <param name="useAgentDefaults">
        /// When true (the default), retrieval uses the agent's own RAG settings, reproducing exactly what the agent would retrieve. Set to false to retrieve with neutral default RAG settings instead (the agent's embedding model is always kept, since it determines which vector index exists). Useful for auditing the knowledge base independently of how a particular agent is tuned.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="maxDocumentsLength">
        /// Optional maximum total character length of document chunks returned. Overrides the selected RAG settings for this query only.
        /// </param>
        /// <param name="maxRetrievedRagChunksCount">
        /// Optional maximum number of document chunks retrieved. Overrides the selected RAG settings for this query only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentKnowledgeBaseRagQueryResponseModel> QueryKnowledgeBaseRagAsync(
            string agentId,
            string? branchId = default,
            global::ElevenLabs.SearchStrategy? strategy = default,
            string? query = default,
            global::System.Collections.Generic.IList<string>? documents = default,
            bool? useAgentDefaults = default,
            int? maxDocumentsLength = default,
            int? maxRetrievedRagChunksCount = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}