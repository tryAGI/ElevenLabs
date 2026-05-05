#nullable enable

namespace ElevenLabs
{
    public partial interface IMusicGenerationClient
    {
        /// <summary>
        /// Generate Composition Plan<br/>
        /// Generate a composition plan from a prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicPrompt> CreateAsync(

            global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Composition Plan<br/>
        /// Generate a composition plan from a prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MusicPrompt>> CreateAsResponseAsync(

            global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Composition Plan<br/>
        /// Generate a composition plan from a prompt.
        /// </summary>
        /// <param name="prompt">
        /// A simple text prompt to compose a plan from.
        /// </param>
        /// <param name="musicLengthMs">
        /// The length of the composition plan to generate in milliseconds. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </param>
        /// <param name="sourceCompositionPlan">
        /// An optional composition plan to use as a source for the new composition plan.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicPrompt> CreateAsync(
            string prompt,
            int? musicLengthMs = default,
            global::ElevenLabs.MusicPrompt? sourceCompositionPlan = default,
            global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPostModelId? modelId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}