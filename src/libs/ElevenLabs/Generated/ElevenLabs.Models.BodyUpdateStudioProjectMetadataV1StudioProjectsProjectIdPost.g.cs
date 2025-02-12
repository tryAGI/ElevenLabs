
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateStudioProjectMetadataV1StudioProjectsProjectIdPost
    {
        /// <summary>
        /// The name of the Studio project, used for identification only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The voice_id that corresponds to the default voice used for new titles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_title_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultTitleVoiceId { get; set; }

        /// <summary>
        /// The voice_id that corresponds to the default voice used for new paragraphs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_paragraph_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultParagraphVoiceId { get; set; }

        /// <summary>
        /// An optional name of the author of the Studio project, this will be added as metadata to the mp3 file on Studio project or chapter download.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// An optional name of the author of the Studio project, this will be added as metadata to the mp3 file on Studio project or chapter download.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// An optional ISBN number of the Studio project you want to create, this will be added as metadata to the mp3 file on Studio project or chapter download.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isbn_number")]
        public string? IsbnNumber { get; set; }

        /// <summary>
        /// When the Studio project is downloaded, should the returned audio have postprocessing in order to make it compliant with audiobook normalized volume requirements<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_normalization")]
        public bool? VolumeNormalization { get; set; }

        /// <summary>
        /// [Depracated] Whether to run quality check on the generated audio and regenerate if needed. Applies to individual block conversion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_check_on")]
        public bool? QualityCheckOn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateStudioProjectMetadataV1StudioProjectsProjectIdPost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the Studio project, used for identification only.
        /// </param>
        /// <param name="defaultTitleVoiceId">
        /// The voice_id that corresponds to the default voice used for new titles.
        /// </param>
        /// <param name="defaultParagraphVoiceId">
        /// The voice_id that corresponds to the default voice used for new paragraphs.
        /// </param>
        /// <param name="title">
        /// An optional name of the author of the Studio project, this will be added as metadata to the mp3 file on Studio project or chapter download.
        /// </param>
        /// <param name="author">
        /// An optional name of the author of the Studio project, this will be added as metadata to the mp3 file on Studio project or chapter download.
        /// </param>
        /// <param name="isbnNumber">
        /// An optional ISBN number of the Studio project you want to create, this will be added as metadata to the mp3 file on Studio project or chapter download.
        /// </param>
        /// <param name="volumeNormalization">
        /// When the Studio project is downloaded, should the returned audio have postprocessing in order to make it compliant with audiobook normalized volume requirements<br/>
        /// Default Value: false
        /// </param>
        /// <param name="qualityCheckOn">
        /// [Depracated] Whether to run quality check on the generated audio and regenerate if needed. Applies to individual block conversion.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateStudioProjectMetadataV1StudioProjectsProjectIdPost(
            string name,
            string defaultTitleVoiceId,
            string defaultParagraphVoiceId,
            string? title,
            string? author,
            string? isbnNumber,
            bool? volumeNormalization,
            bool? qualityCheckOn)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DefaultTitleVoiceId = defaultTitleVoiceId ?? throw new global::System.ArgumentNullException(nameof(defaultTitleVoiceId));
            this.DefaultParagraphVoiceId = defaultParagraphVoiceId ?? throw new global::System.ArgumentNullException(nameof(defaultParagraphVoiceId));
            this.Title = title;
            this.Author = author;
            this.IsbnNumber = isbnNumber;
            this.VolumeNormalization = volumeNormalization;
            this.QualityCheckOn = qualityCheckOn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateStudioProjectMetadataV1StudioProjectsProjectIdPost" /> class.
        /// </summary>
        public BodyUpdateStudioProjectMetadataV1StudioProjectsProjectIdPost()
        {
        }
    }
}