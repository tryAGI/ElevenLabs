#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create File Document<br/>
        /// Create a knowledge base document generated form the uploaded file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddKnowledgeBaseResponseModel> CreateFromFileAsync(

            global::ElevenLabs.BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create File Document<br/>
        /// Create a knowledge base document generated form the uploaded file.
        /// </summary>
        /// <param name="file">
        /// Documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="filename">
        /// Documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        /// <param name="parentFolderId">
        /// If set, the created document or folder will be placed inside the given folder.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddKnowledgeBaseResponseModel> CreateFromFileAsync(
            byte[] file,
            string filename,
            string? name = default,
            string? parentFolderId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}