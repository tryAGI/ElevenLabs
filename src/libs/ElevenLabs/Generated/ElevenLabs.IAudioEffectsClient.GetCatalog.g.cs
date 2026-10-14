#nullable enable

namespace ElevenLabs
{
    public partial interface IAudioEffectsClient
    {
        /// <summary>
        /// Get Audio Effects Catalog<br/>
        /// Lists the filter presets, reverb environments, and background noises that `audio_effects` can reference in Text to Speech, Text to Dialogue, and agent configurations.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AudioEffectsCatalogResponseModel> GetCatalogAsync(
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Audio Effects Catalog<br/>
        /// Lists the filter presets, reverb environments, and background noises that `audio_effects` can reference in Text to Speech, Text to Dialogue, and agent configurations.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AudioEffectsCatalogResponseModel>> GetCatalogAsResponseAsync(
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}