#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs
{
    public partial interface IMusicClient
    {
        /// <summary>
        /// Compose Music<br/>
        /// Compose a song from a prompt or a composition plan.
        /// </summary>
        /// <param name="outputFormat">
        /// Default Value: auto
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ComposeAsync(

            global::ElevenLabs.BodyComposeMusicV1MusicPost request,
            global::ElevenLabs.GenerateOutputFormat? outputFormat = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compose Music<br/>
        /// Compose a song from a prompt or a composition plan.
        /// </summary>
        /// <param name="outputFormat">
        /// Default Value: auto
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ComposeAsStreamAsync(

            global::ElevenLabs.BodyComposeMusicV1MusicPost request,
            global::ElevenLabs.GenerateOutputFormat? outputFormat = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compose Music<br/>
        /// Compose a song from a prompt or a composition plan.
        /// </summary>
        /// <param name="outputFormat">
        /// Default Value: auto
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<byte[]>> ComposeAsResponseAsync(

            global::ElevenLabs.BodyComposeMusicV1MusicPost request,
            global::ElevenLabs.GenerateOutputFormat? outputFormat = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compose Music<br/>
        /// Compose a song from a prompt or a composition plan.
        /// </summary>
        /// <param name="outputFormat">
        /// Default Value: auto
        /// </param>
        /// <param name="prompt">
        /// A simple text prompt to generate a song from. Cannot be used in conjunction with `composition_plan`.
        /// </param>
        /// <param name="generationMode">
        /// Optional generation mode hint for prompt-based music generation. Can only be used with `prompt`.
        /// </param>
        /// <param name="lyricsText">
        /// The lyrics text to use for the generation.
        /// </param>
        /// <param name="compositionPlan">
        /// A detailed composition plan to guide music generation. Cannot be used in conjunction with `prompt`.
        /// </param>
        /// <param name="musicLengthMs">
        /// The length of the song to generate in milliseconds. Used only in conjunction with `prompt`. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </param>
        /// <param name="seed">
        /// Random seed to initialize the music generation process. Providing the same seed with the same parameters can help achieve more consistent results, but exact reproducibility is not guaranteed and outputs may change across system updates. Cannot be used in conjunction with prompt.
        /// </param>
        /// <param name="forceInstrumental">
        /// If true, guarantees that the generated song will be instrumental. If false, the song may or may not be instrumental depending on the `prompt`. Can only be used with `prompt`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="finetuneId">
        /// The ID of the finetune to use for the generation
        /// </param>
        /// <param name="finetuneStrength">
        /// How strongly the finetune influences the generation. Defaults to 1.0 (full strength). Lower values soften the influence of the finetune, leaving more room for prompt-level steering. Only meaningful when `finetune_id` is also provided.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="usePhoneticNames">
        /// If true, proper names in the prompt will be phonetically spelled in the lyrics for better pronunciation by the music model. The original names will be restored in word timestamps.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="respectSectionsDurations">
        /// Controls how strictly section durations in the `composition_plan` are enforced. Only used with `composition_plan` and only applies to `music_v1`; for `music_v2` section durations are always enforced and this is ignored. When false for `music_v1`, the model may adjust individual section durations for better quality and latency, while preserving the total song duration from the plan.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="storeForInpainting">
        /// Whether to store the generated song for inpainting.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="signWithC2pa">
        /// Whether to sign the generated song with C2PA. Applicable only for mp3 files.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ComposeAsync(
            global::ElevenLabs.GenerateOutputFormat? outputFormat = default,
            string? prompt = default,
            global::ElevenLabs.MusicGenerationMode? generationMode = default,
            string? lyricsText = default,
            global::ElevenLabs.OneOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? compositionPlan = default,
            int? musicLengthMs = default,
            global::ElevenLabs.BodyComposeMusicV1MusicPostModelId? modelId = default,
            int? seed = default,
            bool? forceInstrumental = default,
            string? finetuneId = default,
            double? finetuneStrength = default,
            bool? usePhoneticNames = default,
            bool? respectSectionsDurations = default,
            bool? storeForInpainting = default,
            bool? signWithC2pa = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}