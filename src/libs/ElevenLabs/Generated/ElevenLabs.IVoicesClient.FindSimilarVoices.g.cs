#nullable enable

namespace ElevenLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Similar Library Voices<br/>
        /// Returns a list of shared voices similar to the provided audio sample. If neither similarity_threshold nor top_k is provided, we will apply default values.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetLibraryVoicesResponseModel> FindSimilarVoicesAsync(

            global::ElevenLabs.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Similar Library Voices<br/>
        /// Returns a list of shared voices similar to the provided audio sample. If neither similarity_threshold nor top_k is provided, we will apply default values.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetLibraryVoicesResponseModel>> FindSimilarVoicesAsResponseAsync(

            global::ElevenLabs.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Similar Library Voices<br/>
        /// Returns a list of shared voices similar to the provided audio sample. If neither similarity_threshold nor top_k is provided, we will apply default values.
        /// </summary>
        /// <param name="audioFile"></param>
        /// <param name="audioFilename"></param>
        /// <param name="similarityThreshold">
        /// Threshold for voice similarity between provided sample and library voices. Values range from 0 to 2. The smaller the value the more similar voices will be returned.
        /// </param>
        /// <param name="topK">
        /// Number of most similar voices to return. If similarity_threshold is provided, less than this number of voices may be returned. Values range from 1 to 100.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetLibraryVoicesResponseModel> FindSimilarVoicesAsync(
            byte[]? audioFile = default,
            string? audioFilename = default,
            double? similarityThreshold = default,
            int? topK = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Similar Library Voices<br/>
        /// Returns a list of shared voices similar to the provided audio sample. If neither similarity_threshold nor top_k is provided, we will apply default values.
        /// </summary>
        /// <param name="audioFile">
        /// The stream to send as the multipart 'audio_file' file part.
        /// </param>
        /// <param name="audioFilename"></param>
        /// <param name="similarityThreshold">
        /// Threshold for voice similarity between provided sample and library voices. Values range from 0 to 2. The smaller the value the more similar voices will be returned.
        /// </param>
        /// <param name="topK">
        /// Number of most similar voices to return. If similarity_threshold is provided, less than this number of voices may be returned. Values range from 1 to 100.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetLibraryVoicesResponseModel> FindSimilarVoicesAsync(
            global::System.IO.Stream? audioFile = default,
            string? audioFilename = default,
            double? similarityThreshold = default,
            int? topK = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Similar Library Voices<br/>
        /// Returns a list of shared voices similar to the provided audio sample. If neither similarity_threshold nor top_k is provided, we will apply default values.
        /// </summary>
        /// <param name="audioFile">
        /// The stream to send as the multipart 'audio_file' file part.
        /// </param>
        /// <param name="audioFilename"></param>
        /// <param name="similarityThreshold">
        /// Threshold for voice similarity between provided sample and library voices. Values range from 0 to 2. The smaller the value the more similar voices will be returned.
        /// </param>
        /// <param name="topK">
        /// Number of most similar voices to return. If similarity_threshold is provided, less than this number of voices may be returned. Values range from 1 to 100.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetLibraryVoicesResponseModel>> FindSimilarVoicesAsResponseAsync(
            global::System.IO.Stream? audioFile = default,
            string? audioFilename = default,
            double? similarityThreshold = default,
            int? topK = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}