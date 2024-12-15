
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectExtendedResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreateDateUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_title_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultTitleVoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_paragraph_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultParagraphVoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_conversion_date_unix")]
        public int? LastConversionDateUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_be_downloaded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanBeDownloaded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genres")]
        public global::System.Collections.Generic.IList<string>? Genres { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_audience")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudienceJsonConverter))]
        public global::ElevenLabs.ProjectExtendedResponseModelTargetAudience? TargetAudience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_publication_date")]
        public string? OriginalPublicationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mature_content")]
        public bool? MatureContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isbn_number")]
        public string? IsbnNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_normalization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VolumeNormalization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ProjectExtendedResponseModelState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ProjectExtendedResponseModelAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fiction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFictionJsonConverter))]
        public global::ElevenLabs.ProjectExtendedResponseModelFiction? Fiction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_check_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool QualityCheckOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_check_on_when_bulk_convert")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool QualityCheckOnWhenBulkConvert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_meta")]
        public global::ElevenLabs.ProjectCreationMetaResponseModel? CreationMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelQualityPresetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ProjectExtendedResponseModelQualityPreset QualityPreset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ChapterResponseModel> Chapters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionResponseModel> PronunciationDictionaryVersions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_text_normalization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization ApplyTextNormalization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Experimental { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExtendedResponseModel" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="createDateUnix"></param>
        /// <param name="defaultTitleVoiceId"></param>
        /// <param name="defaultParagraphVoiceId"></param>
        /// <param name="defaultModelId"></param>
        /// <param name="lastConversionDateUnix"></param>
        /// <param name="canBeDownloaded"></param>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="description"></param>
        /// <param name="genres"></param>
        /// <param name="coverImageUrl"></param>
        /// <param name="targetAudience"></param>
        /// <param name="language"></param>
        /// <param name="contentType"></param>
        /// <param name="originalPublicationDate"></param>
        /// <param name="matureContent"></param>
        /// <param name="isbnNumber"></param>
        /// <param name="volumeNormalization"></param>
        /// <param name="state"></param>
        /// <param name="accessLevel"></param>
        /// <param name="fiction"></param>
        /// <param name="qualityCheckOn"></param>
        /// <param name="qualityCheckOnWhenBulkConvert"></param>
        /// <param name="creationMeta"></param>
        /// <param name="qualityPreset"></param>
        /// <param name="chapters"></param>
        /// <param name="pronunciationDictionaryVersions"></param>
        /// <param name="applyTextNormalization"></param>
        /// <param name="experimental"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProjectExtendedResponseModel(
            string projectId,
            string name,
            int createDateUnix,
            string defaultTitleVoiceId,
            string defaultParagraphVoiceId,
            string defaultModelId,
            bool canBeDownloaded,
            bool volumeNormalization,
            global::ElevenLabs.ProjectExtendedResponseModelState state,
            global::ElevenLabs.ProjectExtendedResponseModelAccessLevel accessLevel,
            bool qualityCheckOn,
            bool qualityCheckOnWhenBulkConvert,
            global::ElevenLabs.ProjectExtendedResponseModelQualityPreset qualityPreset,
            global::System.Collections.Generic.IList<global::ElevenLabs.ChapterResponseModel> chapters,
            global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionResponseModel> pronunciationDictionaryVersions,
            global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization applyTextNormalization,
            object experimental,
            int? lastConversionDateUnix,
            string? title,
            string? author,
            string? description,
            global::System.Collections.Generic.IList<string>? genres,
            string? coverImageUrl,
            global::ElevenLabs.ProjectExtendedResponseModelTargetAudience? targetAudience,
            string? language,
            string? contentType,
            string? originalPublicationDate,
            bool? matureContent,
            string? isbnNumber,
            global::ElevenLabs.ProjectExtendedResponseModelFiction? fiction,
            global::ElevenLabs.ProjectCreationMetaResponseModel? creationMeta)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreateDateUnix = createDateUnix;
            this.DefaultTitleVoiceId = defaultTitleVoiceId ?? throw new global::System.ArgumentNullException(nameof(defaultTitleVoiceId));
            this.DefaultParagraphVoiceId = defaultParagraphVoiceId ?? throw new global::System.ArgumentNullException(nameof(defaultParagraphVoiceId));
            this.DefaultModelId = defaultModelId ?? throw new global::System.ArgumentNullException(nameof(defaultModelId));
            this.CanBeDownloaded = canBeDownloaded;
            this.VolumeNormalization = volumeNormalization;
            this.State = state;
            this.AccessLevel = accessLevel;
            this.QualityCheckOn = qualityCheckOn;
            this.QualityCheckOnWhenBulkConvert = qualityCheckOnWhenBulkConvert;
            this.QualityPreset = qualityPreset;
            this.Chapters = chapters ?? throw new global::System.ArgumentNullException(nameof(chapters));
            this.PronunciationDictionaryVersions = pronunciationDictionaryVersions ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryVersions));
            this.ApplyTextNormalization = applyTextNormalization;
            this.Experimental = experimental ?? throw new global::System.ArgumentNullException(nameof(experimental));
            this.LastConversionDateUnix = lastConversionDateUnix;
            this.Title = title;
            this.Author = author;
            this.Description = description;
            this.Genres = genres;
            this.CoverImageUrl = coverImageUrl;
            this.TargetAudience = targetAudience;
            this.Language = language;
            this.ContentType = contentType;
            this.OriginalPublicationDate = originalPublicationDate;
            this.MatureContent = matureContent;
            this.IsbnNumber = isbnNumber;
            this.Fiction = fiction;
            this.CreationMeta = creationMeta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExtendedResponseModel" /> class.
        /// </summary>
        public ProjectExtendedResponseModel()
        {
        }
    }
}