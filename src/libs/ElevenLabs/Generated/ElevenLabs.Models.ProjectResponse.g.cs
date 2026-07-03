
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectResponse
    {
        /// <summary>
        /// Unique identifier of the dubbing project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Lifecycle status of the project: 'preparing'/'processing' while it transcribes, 'ready' once transcription is done, or 'failed'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProjectResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ProjectResponseStatus Status { get; set; }

        /// <summary>
        /// Optional free-form string the customer can provide to identify the project on their end.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// BCP-47 language tag of the source media (null if auto-detected).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        public string? SourceLanguage { get; set; }

        /// <summary>
        /// Default dubbing model id applied to this project's language targets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Source media metadata; null until the project is ready.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        public global::ElevenLabs.MediaInfo? Media { get; set; }

        /// <summary>
        /// Identifiers of the language targets created under this project.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_ids")]
        public global::System.Collections.Generic.IList<string>? LanguageIds { get; set; }

        /// <summary>
        /// Monotonic counter incremented whenever the source transcript is edited (segment add/edit/delete).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// When the project was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the project was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectResponse" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier of the dubbing project.
        /// </param>
        /// <param name="status">
        /// Lifecycle status of the project: 'preparing'/'processing' while it transcribes, 'ready' once transcription is done, or 'failed'.
        /// </param>
        /// <param name="revision">
        /// Monotonic counter incremented whenever the source transcript is edited (segment add/edit/delete).
        /// </param>
        /// <param name="createdAt">
        /// When the project was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the project was last updated.
        /// </param>
        /// <param name="reference">
        /// Optional free-form string the customer can provide to identify the project on their end.
        /// </param>
        /// <param name="sourceLanguage">
        /// BCP-47 language tag of the source media (null if auto-detected).
        /// </param>
        /// <param name="modelId">
        /// Default dubbing model id applied to this project's language targets.
        /// </param>
        /// <param name="media">
        /// Source media metadata; null until the project is ready.
        /// </param>
        /// <param name="languageIds">
        /// Identifiers of the language targets created under this project.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectResponse(
            string projectId,
            global::ElevenLabs.ProjectResponseStatus status,
            int revision,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? reference,
            string? sourceLanguage,
            string? modelId,
            global::ElevenLabs.MediaInfo? media,
            global::System.Collections.Generic.IList<string>? languageIds)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Status = status;
            this.Reference = reference;
            this.SourceLanguage = sourceLanguage;
            this.ModelId = modelId;
            this.Media = media;
            this.LanguageIds = languageIds;
            this.Revision = revision;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectResponse" /> class.
        /// </summary>
        public ProjectResponse()
        {
        }

    }
}