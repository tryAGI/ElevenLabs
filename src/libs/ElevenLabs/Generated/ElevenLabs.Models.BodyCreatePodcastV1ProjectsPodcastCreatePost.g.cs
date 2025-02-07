
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreatePodcastV1ProjectsPodcastCreatePost
    {
        /// <summary>
        /// The model_id of the model to be used for this project, you can query GET https://api.elevenlabs.io/v1/models to list all available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// The type of podcast to generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode> Mode { get; set; }

        /// <summary>
        /// The source content for the Podcast.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource> Source { get; set; }

        /// <summary>
        /// Output quality of the generated audio. Must be one of:<br/>
        /// standard - standard output format, 128kbps with 44.1kHz sample rate.<br/>
        /// high - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side. Using this setting increases the credit cost by 20%.<br/>
        /// ultra - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side. Using this setting increases the credit cost by 50%.<br/>
        /// ultra lossless - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format. Using this setting increases the credit cost by 100%.<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPresetJsonConverter))]
        public global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset? QualityPreset { get; set; }

        /// <summary>
        /// Duration of the generated podcast. Must be one of:<br/>
        /// short - produces podcasts shorter than 3 minutes.<br/>
        /// default - produces podcasts roughly between 3-7 minutes.<br/>
        /// long - prodces podcasts longer than 7 minutes.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_scale")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScaleJsonConverter))]
        public global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale? DurationScale { get; set; }

        /// <summary>
        /// An optional language of the project. Two-letter language code (ISO 639-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// A brief summary or highlights of the project's content, providing key points or themes. This should be between 10 and 70 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        public global::System.Collections.Generic.IList<string>? Highlights { get; set; }

        /// <summary>
        /// A url that will be called by our service when the project is converted with a json containing the status of the conversion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePodcastV1ProjectsPodcastCreatePost" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreatePodcastV1ProjectsPodcastCreatePost(
            string modelId,
            global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode> mode,
            global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource> source,
            global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset? qualityPreset,
            global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale? durationScale,
            string? language,
            global::System.Collections.Generic.IList<string>? highlights,
            string? callbackUrl)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Mode = mode;
            this.Source = source;
            this.QualityPreset = qualityPreset;
            this.DurationScale = durationScale;
            this.Language = language;
            this.Highlights = highlights;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePodcastV1ProjectsPodcastCreatePost" /> class.
        /// </summary>
        public BodyCreatePodcastV1ProjectsPodcastCreatePost()
        {
        }
    }
}