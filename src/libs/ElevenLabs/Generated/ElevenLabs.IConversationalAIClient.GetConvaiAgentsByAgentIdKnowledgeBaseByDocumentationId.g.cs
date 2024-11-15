#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Get Documentation From Agent'S Knowledge Base<br/>
        /// Get details about a specific documentation making up the agent's knowledge base
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="documentationId">
        /// The id of a document from the agent's knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetKnowledgeBaseReponseModel> GetConvaiAgentsByAgentIdKnowledgeBaseByDocumentationIdAsync(
            string agentId,
            string documentationId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}