#nullable enable

namespace ElevenLabs
{
    public partial interface IForcedAlignmentClient
    {
        /// <summary>
        /// Create Forced Alignment<br/>
        /// Force align an audio file to text. Use this endpoint to get the timing information for each character and word in an audio file based on a provided text transcript.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ForcedAlignmentResponseModel> CreateAsync(

            global::ElevenLabs.BodyCreateForcedAlignmentV1ForcedAlignmentPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Forced Alignment<br/>
        /// Force align an audio file to text. Use this endpoint to get the timing information for each character and word in an audio file based on a provided text transcript.
        /// </summary>
        /// <param name="file">
        /// The file to align. All major audio formats are supported. The file size must be less than 1GB.
        /// </param>
        /// <param name="filename">
        /// The file to align. All major audio formats are supported. The file size must be less than 1GB.
        /// </param>
        /// <param name="text">
        /// The text to align with the audio. The input text can be in any format, however diarization is not supported at this time.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ForcedAlignmentResponseModel> CreateAsync(
            byte[] file,
            string filename,
            string text,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}