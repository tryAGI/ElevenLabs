#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAi2Client
    {
        /// <summary>
        /// Get Rag Index Overview.<br/>
        /// Provides total size and other information of RAG indexes used by knowledgebase documents
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RAGIndexOverviewResponseModel> RagIndexOverviewAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}