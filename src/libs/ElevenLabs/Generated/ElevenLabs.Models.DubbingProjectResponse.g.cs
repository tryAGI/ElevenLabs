
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DubbingProjectResponse
    {
        /// <summary>
        /// Unique identifier of the dubbing project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Lifecycle status of the project: `queued` before the source is picked up, `preparing` while it is transcribed, `ready` once transcription is done and language targets can start, or `failed`. A project is never reported as `processing` — that value belongs to language targets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.DubbingProjectResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DubbingProjectResponseStatus Status { get; set; }

        /// <summary>
        /// The free-form string you supplied as `reference` when creating the project, or null if you supplied none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// BCP-47 language tag of the source media (null if auto-detected).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        public string? SourceLanguage { get; set; }

        /// <summary>
        /// Dubbing model every language target of this project is dubbed with. Fixed at create time and not selectable per language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Source media metadata, populated once the source has been fetched and decoded (shortly after create, before the project is `ready`); null until then.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        public global::ElevenLabs.DubbingSourceMediaInfo? Media { get; set; }

        /// <summary>
        /// Identifiers of the language targets under this project. Populated when a single project is fetched, and on create when `target_language` creates one. Always empty in list responses — list the project's language targets instead.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_ids")]
        public global::System.Collections.Generic.IList<string>? LanguageIds { get; set; }

        /// <summary>
        /// IDs of the workspace webhooks notified as this project and its languages reach `ready`, `completed`, or `failed`.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_ids")]
        public global::System.Collections.Generic.IList<string>? WebhookIds { get; set; }

        /// <summary>
        /// Monotonic counter incremented whenever the source transcript is edited (segment add/edit/delete).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// Why the project failed; null unless `status` is `failed`. Also null for the few projects that failed before failure reporting was introduced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::ElevenLabs.DubbingError? Error { get; set; }

        /// <summary>
        /// Non-fatal conditions raised while preparing the source, empty when there are none. Reflects the latest preparation. Conditions raised while dubbing a particular language are reported on that language instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoicesNotPermittedWarning>? Warnings { get; set; }

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
        /// Initializes a new instance of the <see cref="DubbingProjectResponse" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier of the dubbing project.
        /// </param>
        /// <param name="status">
        /// Lifecycle status of the project: `queued` before the source is picked up, `preparing` while it is transcribed, `ready` once transcription is done and language targets can start, or `failed`. A project is never reported as `processing` — that value belongs to language targets.
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
        /// The free-form string you supplied as `reference` when creating the project, or null if you supplied none.
        /// </param>
        /// <param name="sourceLanguage">
        /// BCP-47 language tag of the source media (null if auto-detected).
        /// </param>
        /// <param name="modelId">
        /// Dubbing model every language target of this project is dubbed with. Fixed at create time and not selectable per language.
        /// </param>
        /// <param name="media">
        /// Source media metadata, populated once the source has been fetched and decoded (shortly after create, before the project is `ready`); null until then.
        /// </param>
        /// <param name="languageIds">
        /// Identifiers of the language targets under this project. Populated when a single project is fetched, and on create when `target_language` creates one. Always empty in list responses — list the project's language targets instead.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="webhookIds">
        /// IDs of the workspace webhooks notified as this project and its languages reach `ready`, `completed`, or `failed`.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="error">
        /// Why the project failed; null unless `status` is `failed`. Also null for the few projects that failed before failure reporting was introduced.
        /// </param>
        /// <param name="warnings">
        /// Non-fatal conditions raised while preparing the source, empty when there are none. Reflects the latest preparation. Conditions raised while dubbing a particular language are reported on that language instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingProjectResponse(
            string projectId,
            global::ElevenLabs.DubbingProjectResponseStatus status,
            int revision,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? reference,
            string? sourceLanguage,
            string? modelId,
            global::ElevenLabs.DubbingSourceMediaInfo? media,
            global::System.Collections.Generic.IList<string>? languageIds,
            global::System.Collections.Generic.IList<string>? webhookIds,
            global::ElevenLabs.DubbingError? error,
            global::System.Collections.Generic.IList<global::ElevenLabs.VoicesNotPermittedWarning>? warnings)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Status = status;
            this.Reference = reference;
            this.SourceLanguage = sourceLanguage;
            this.ModelId = modelId;
            this.Media = media;
            this.LanguageIds = languageIds;
            this.WebhookIds = webhookIds;
            this.Revision = revision;
            this.Error = error;
            this.Warnings = warnings;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingProjectResponse" /> class.
        /// </summary>
        public DubbingProjectResponse()
        {
        }

    }
}