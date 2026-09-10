#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Post Agent Hold Audio<br/>
        /// Sets the custom hold audio played on loop to callers waiting in the agent's concurrency wait queue. Replaces any previously uploaded clip.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PostAgentHoldAudioResponseModel> Create3Async(
            string agentId,

            global::ElevenLabs.BodyPostAgentHoldAudioV1ConvaiAgentsAgentIdHoldAudioPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post Agent Hold Audio<br/>
        /// Sets the custom hold audio played on loop to callers waiting in the agent's concurrency wait queue. Replaces any previously uploaded clip.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PostAgentHoldAudioResponseModel>> Create3AsResponseAsync(
            string agentId,

            global::ElevenLabs.BodyPostAgentHoldAudioV1ConvaiAgentsAgentIdHoldAudioPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post Agent Hold Audio<br/>
        /// Sets the custom hold audio played on loop to callers waiting in the agent's concurrency wait queue. Replaces any previously uploaded clip.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="holdAudioFile">
        /// An MP3 or WAV file played on loop to callers waiting in the agent's concurrency wait queue. Maximum size 40 MB, maximum duration 180 seconds.
        /// </param>
        /// <param name="holdAudioFilename">
        /// An MP3 or WAV file played on loop to callers waiting in the agent's concurrency wait queue. Maximum size 40 MB, maximum duration 180 seconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PostAgentHoldAudioResponseModel> Create3Async(
            string agentId,
            byte[] holdAudioFile,
            string holdAudioFilename,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Post Agent Hold Audio<br/>
        /// Sets the custom hold audio played on loop to callers waiting in the agent's concurrency wait queue. Replaces any previously uploaded clip.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="holdAudioFile">
        /// An MP3 or WAV file played on loop to callers waiting in the agent's concurrency wait queue. Maximum size 40 MB, maximum duration 180 seconds.
        /// </param>
        /// <param name="holdAudioFilename">
        /// An MP3 or WAV file played on loop to callers waiting in the agent's concurrency wait queue. Maximum size 40 MB, maximum duration 180 seconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PostAgentHoldAudioResponseModel> Create3Async(
            string agentId,
            global::System.IO.Stream holdAudioFile,
            string holdAudioFilename,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post Agent Hold Audio<br/>
        /// Sets the custom hold audio played on loop to callers waiting in the agent's concurrency wait queue. Replaces any previously uploaded clip.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="holdAudioFile">
        /// An MP3 or WAV file played on loop to callers waiting in the agent's concurrency wait queue. Maximum size 40 MB, maximum duration 180 seconds.
        /// </param>
        /// <param name="holdAudioFilename">
        /// An MP3 or WAV file played on loop to callers waiting in the agent's concurrency wait queue. Maximum size 40 MB, maximum duration 180 seconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PostAgentHoldAudioResponseModel>> Create3AsResponseAsync(
            string agentId,
            global::System.IO.Stream holdAudioFile,
            string holdAudioFilename,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}