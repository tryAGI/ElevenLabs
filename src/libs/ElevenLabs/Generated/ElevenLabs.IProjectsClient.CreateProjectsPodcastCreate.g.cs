#nullable enable

namespace ElevenLabs
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create Podcast<br/>
        /// Create and auto-convert a podcast project. Currently, the LLM cost is covered by us. In the future, this cost will be passed onto you.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PodcastProjectResponseModel> CreateProjectsPodcastCreateAsync(
            global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Podcast<br/>
        /// Create and auto-convert a podcast project. Currently, the LLM cost is covered by us. In the future, this cost will be passed onto you.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="modelId">
        /// The model_id of the model to be used for this project, you can query GET https://api.elevenlabs.io/v1/models to list all available models.
        /// </param>
        /// <param name="mode">
        /// The type of podcast to generate
        /// </param>
        /// <param name="source">
        /// The source content for the Podcast.
        /// </param>
        /// <param name="qualityPreset">
        /// Output quality of the generated audio. Must be one of:<br/>
        /// standard - standard output format, 128kbps with 44.1kHz sample rate.<br/>
        /// high - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side. Using this setting increases the credit cost by 20%.<br/>
        /// ultra - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side. Using this setting increases the credit cost by 50%.<br/>
        /// ultra lossless - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format. Using this setting increases the credit cost by 100%.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="durationScale">
        /// Duration of the generated podcast. Must be one of:<br/>
        /// short - produces podcasts shorter than 3 minutes.<br/>
        /// default - produces podcasts roughly between 3-7 minutes.<br/>
        /// long - prodces podcasts longer than 7 minutes.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="language">
        /// An optional language of the project. Two-letter language code (ISO 639-1).
        /// </param>
        /// <param name="highlights">
        /// A brief summary or highlights of the project's content, providing key points or themes. This should be between 10 and 70 characters.
        /// </param>
        /// <param name="callbackUrl">
        /// A url that will be called by our service when the project is converted with a json containing the status of the conversion
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PodcastProjectResponseModel> CreateProjectsPodcastCreateAsync(
            string modelId,
            global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode> mode,
            global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource> source,
            string? xiApiKey = default,
            global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset? qualityPreset = default,
            global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale? durationScale = default,
            string? language = default,
            global::System.Collections.Generic.IList<string>? highlights = default,
            string? callbackUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}