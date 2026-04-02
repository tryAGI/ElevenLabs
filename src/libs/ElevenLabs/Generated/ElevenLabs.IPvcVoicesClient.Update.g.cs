#nullable enable

namespace ElevenLabs
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Edit Pvc Voice<br/>
        /// Edit PVC voice metadata
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddVoiceResponseModel> UpdateAsync(
            string voiceId,

            global::ElevenLabs.BodyEditPvcVoiceV1VoicesPvcVoiceIdPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Pvc Voice<br/>
        /// Edit PVC voice metadata
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="name">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        /// <param name="language">
        /// Language used in the samples.
        /// </param>
        /// <param name="description">
        /// Description to use for the created voice.
        /// </param>
        /// <param name="labels">
        /// Labels for the voice. Keys can be language, accent, gender, or age.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddVoiceResponseModel> UpdateAsync(
            string voiceId,
            string? name = default,
            string? language = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}