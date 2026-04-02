#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Dependent Agents List<br/>
        /// Get a list of agents depending on this knowledge base document
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="dependentType">
        /// Type of dependent agents to return.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModel> GetAgentsAsync(
            string documentationId,
            global::ElevenLabs.KnowledgeBaseDependentType? dependentType = default,
            int? pageSize = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}