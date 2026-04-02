#nullable enable

namespace ElevenLabs
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Create Pvc Voice<br/>
        /// Creates a new PVC voice with metadata but no samples
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddVoiceResponseModel> CreateAsync(

            global::ElevenLabs.BodyCreatePvcVoiceV1VoicesPvcPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Pvc Voice<br/>
        /// Creates a new PVC voice with metadata but no samples
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddVoiceResponseModel> CreateAsync(
            string name,
            string language,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}