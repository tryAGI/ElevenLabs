
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioIsolationHistoryItemResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_video_url")]
        public string? SourceVideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsVideo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Processing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_b64")]
        public string? PreviewB64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioIsolationHistoryItemResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="format"></param>
        /// <param name="supportsVideo"></param>
        /// <param name="processing"></param>
        /// <param name="title"></param>
        /// <param name="durationSeconds"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="iconUrl"></param>
        /// <param name="sourceVideoUrl"></param>
        /// <param name="previewB64"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioIsolationHistoryItemResponseModel(
            string id,
            int createdAtUnix,
            string format,
            bool supportsVideo,
            bool processing,
            string? title,
            double? durationSeconds,
            string? downloadUrl,
            string? iconUrl,
            string? sourceVideoUrl,
            string? previewB64)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title;
            this.CreatedAtUnix = createdAtUnix;
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
            this.DurationSeconds = durationSeconds;
            this.DownloadUrl = downloadUrl;
            this.IconUrl = iconUrl;
            this.SourceVideoUrl = sourceVideoUrl;
            this.SupportsVideo = supportsVideo;
            this.Processing = processing;
            this.PreviewB64 = previewB64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioIsolationHistoryItemResponseModel" /> class.
        /// </summary>
        public AudioIsolationHistoryItemResponseModel()
        {
        }
    }
}