
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"can_be_downloaded":true,"chapter_id":"aw1NgEzBg83R7vgmiJt6","conversion_progress":0.5,"last_conversion_date_unix":1714204800,"last_conversion_error":"Error message","name":"Chapter 1","state":"converting","statistics":{"characters_converted":500,"characters_unconverted":1000,"paragraphs_converted":20,"paragraphs_unconverted":10,"voice_statistics":[{"characters_converted":300,"characters_unconverted":600,"voice_id":"voice123"},{"characters_converted":200,"characters_unconverted":400,"voice_id":"voice456"}]}}
    /// </summary>
    public sealed partial class ChapterResponseModel
    {
        /// <summary>
        /// The ID of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ChapterId { get; set; } = default!;

        /// <summary>
        /// The name of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The last conversion date of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_conversion_date_unix")]
        public int? LastConversionDateUnix { get; set; }

        /// <summary>
        /// The conversion progress of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversion_progress")]
        public double? ConversionProgress { get; set; }

        /// <summary>
        /// Whether the chapter can be downloaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_be_downloaded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool CanBeDownloaded { get; set; } = default!;

        /// <summary>
        /// The state of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.ChapterResponseModelState State { get; set; } = default!;

        /// <summary>
        /// Whether the chapter has a video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_video")]
        public bool? HasVideo { get; set; }

        /// <summary>
        /// Whether the chapter has any visual content (video, image, or text clips).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_visual_content")]
        public bool? HasVisualContent { get; set; }

        /// <summary>
        /// List of voice ids used by the chapter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_ids")]
        public global::System.Collections.Generic.IList<string>? VoiceIds { get; set; }

        /// <summary>
        /// The statistics of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statistics")]
        public global::ElevenLabs.ChapterStatisticsResponseModel? Statistics { get; set; }

        /// <summary>
        /// The last conversion error of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_conversion_error")]
        public string? LastConversionError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterResponseModel" /> class.
        /// </summary>
        /// <param name="chapterId">
        /// The ID of the chapter.
        /// </param>
        /// <param name="name">
        /// The name of the chapter.
        /// </param>
        /// <param name="lastConversionDateUnix">
        /// The last conversion date of the chapter.
        /// </param>
        /// <param name="conversionProgress">
        /// The conversion progress of the chapter.
        /// </param>
        /// <param name="canBeDownloaded">
        /// Whether the chapter can be downloaded.
        /// </param>
        /// <param name="state">
        /// The state of the chapter.
        /// </param>
        /// <param name="hasVideo">
        /// Whether the chapter has a video.
        /// </param>
        /// <param name="hasVisualContent">
        /// Whether the chapter has any visual content (video, image, or text clips).
        /// </param>
        /// <param name="voiceIds">
        /// List of voice ids used by the chapter
        /// </param>
        /// <param name="statistics">
        /// The statistics of the chapter.
        /// </param>
        /// <param name="lastConversionError">
        /// The last conversion error of the chapter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChapterResponseModel(
            string chapterId,
            string name,
            bool canBeDownloaded,
            global::ElevenLabs.ChapterResponseModelState state,
            int? lastConversionDateUnix,
            double? conversionProgress,
            bool? hasVideo,
            bool? hasVisualContent,
            global::System.Collections.Generic.IList<string>? voiceIds,
            global::ElevenLabs.ChapterStatisticsResponseModel? statistics,
            string? lastConversionError)
        {
            this.ChapterId = chapterId ?? throw new global::System.ArgumentNullException(nameof(chapterId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CanBeDownloaded = canBeDownloaded;
            this.State = state;
            this.LastConversionDateUnix = lastConversionDateUnix;
            this.ConversionProgress = conversionProgress;
            this.HasVideo = hasVideo;
            this.HasVisualContent = hasVisualContent;
            this.VoiceIds = voiceIds;
            this.Statistics = statistics;
            this.LastConversionError = lastConversionError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterResponseModel" /> class.
        /// </summary>
        public ChapterResponseModel()
        {
        }
    }
}