#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create Text Document<br/>
        /// Create a knowledge base document containing the provided text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddKnowledgeBaseResponseModel> CreateFromTextAsync(

            global::ElevenLabs.BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Text Document<br/>
        /// Create a knowledge base document containing the provided text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AddKnowledgeBaseResponseModel>> CreateFromTextAsResponseAsync(

            global::ElevenLabs.BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Text Document<br/>
        /// Create a knowledge base document containing the provided text.
        /// </summary>
        /// <param name="text">
        /// Text content to be added to the knowledge base.
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddKnowledgeBaseResponseModel> CreateFromTextAsync(
            string text,
            string? name = default,
            string? parentFolderId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}