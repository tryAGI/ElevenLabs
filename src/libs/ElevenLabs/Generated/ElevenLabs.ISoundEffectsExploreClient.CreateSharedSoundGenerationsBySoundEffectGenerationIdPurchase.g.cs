#nullable enable

namespace ElevenLabs
{
    public partial interface ISoundEffectsExploreClient
    {
        /// <summary>
        /// Purchases Shared Sound Effect<br/>
        /// Purchases shared sound effect and charges user for the purchase.
        /// </summary>
        /// <param name="soundEffectGenerationId">
        /// sound_effect_generation_id to be used, you can use GET https://api.elevenlabs.io/v1/sound-effects-history to receive a list of history items and their sound_effect_generation_ids.<br/>
        /// Example: VW7YKqPnjY4h39yTbx2L
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateSharedSoundGenerationsBySoundEffectGenerationIdPurchaseAsync(
            string soundEffectGenerationId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}