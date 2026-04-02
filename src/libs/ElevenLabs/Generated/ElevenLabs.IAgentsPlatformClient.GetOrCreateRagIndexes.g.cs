#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Compute Rag Indexes In Batch<br/>
        /// Retrieves and/or creates RAG indexes for multiple knowledge base documents in a single request. Maximum 100 items per request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetOrCreateRagIndexesAsync(

            global::ElevenLabs.BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compute Rag Indexes In Batch<br/>
        /// Retrieves and/or creates RAG indexes for multiple knowledge base documents in a single request. Maximum 100 items per request.
        /// </summary>
        /// <param name="items">
        /// List of requested RAG indexes. Minimum 1, maximum 100 items.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetOrCreateRagIndexesAsync(
            global::System.Collections.Generic.IList<global::ElevenLabs.GetOrCreateRAGIndexRequestModel> items,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}