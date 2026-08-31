
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DubbingLanguageResponse
    {
        /// <summary>
        /// Unique identifier of the language target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguageId { get; set; }

        /// <summary>
        /// Identifier of the parent dubbing project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// BCP-47 language tag this target is dubbed into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLanguage { get; set; }

        /// <summary>
        /// Lifecycle status: `queued` (waiting on the project to be ready, or on a worker), `processing` while it is being dubbed, `completed` once its output is available, `stale` when the transcript changed after the output was produced, or `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.DubbingLanguageResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DubbingLanguageResponseStatus Status { get; set; }

        /// <summary>
        /// Dubbing model this target is dubbed with, inherited from the project and not selectable per language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Voice settings applied to every speaker in this language, or null if the defaults apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_settings")]
        public global::ElevenLabs.VoiceSettings? VoiceSettings { get; set; }

        /// <summary>
        /// Signed output URLs; null until the target has produced an output (present once `completed`, and kept while `stale` — compare `output_revision` against `revision` to tell whether the output is up to date).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::ElevenLabs.DubbingLanguageOutputs? Outputs { get; set; }

        /// <summary>
        /// Monotonic counter incremented whenever this target's transcript changes (a source edit affecting it, or an edit to its translation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// The `revision` the current dubbed output was generated from; equal to `revision` when up to date, and lower when `stale`. This is null until a generation has completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_revision")]
        public int? OutputRevision { get; set; }

        /// <summary>
        /// Why this language failed; null unless `status` is `failed`, and also null for the few languages that failed before failure reporting was introduced. A code of `project_failed` means the parent project failed, so read the project for the underlying cause.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::ElevenLabs.DubbingError? Error { get; set; }

        /// <summary>
        /// Non-fatal conditions raised while dubbing this language, empty when there are none. Reflects the latest generation. Conditions raised while preparing the source are reported on the project instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoicesNotPermittedWarning>? Warnings { get; set; }

        /// <summary>
        /// When the language target was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the language target was last updated.
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
        /// Initializes a new instance of the <see cref="DubbingLanguageResponse" /> class.
        /// </summary>
        /// <param name="languageId">
        /// Unique identifier of the language target.
        /// </param>
        /// <param name="projectId">
        /// Identifier of the parent dubbing project.
        /// </param>
        /// <param name="targetLanguage">
        /// BCP-47 language tag this target is dubbed into.
        /// </param>
        /// <param name="status">
        /// Lifecycle status: `queued` (waiting on the project to be ready, or on a worker), `processing` while it is being dubbed, `completed` once its output is available, `stale` when the transcript changed after the output was produced, or `failed`.
        /// </param>
        /// <param name="revision">
        /// Monotonic counter incremented whenever this target's transcript changes (a source edit affecting it, or an edit to its translation).
        /// </param>
        /// <param name="createdAt">
        /// When the language target was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the language target was last updated.
        /// </param>
        /// <param name="modelId">
        /// Dubbing model this target is dubbed with, inherited from the project and not selectable per language.
        /// </param>
        /// <param name="voiceSettings">
        /// Voice settings applied to every speaker in this language, or null if the defaults apply.
        /// </param>
        /// <param name="outputs">
        /// Signed output URLs; null until the target has produced an output (present once `completed`, and kept while `stale` — compare `output_revision` against `revision` to tell whether the output is up to date).
        /// </param>
        /// <param name="outputRevision">
        /// The `revision` the current dubbed output was generated from; equal to `revision` when up to date, and lower when `stale`. This is null until a generation has completed.
        /// </param>
        /// <param name="error">
        /// Why this language failed; null unless `status` is `failed`, and also null for the few languages that failed before failure reporting was introduced. A code of `project_failed` means the parent project failed, so read the project for the underlying cause.
        /// </param>
        /// <param name="warnings">
        /// Non-fatal conditions raised while dubbing this language, empty when there are none. Reflects the latest generation. Conditions raised while preparing the source are reported on the project instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingLanguageResponse(
            string languageId,
            string projectId,
            string targetLanguage,
            global::ElevenLabs.DubbingLanguageResponseStatus status,
            int revision,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? modelId,
            global::ElevenLabs.VoiceSettings? voiceSettings,
            global::ElevenLabs.DubbingLanguageOutputs? outputs,
            int? outputRevision,
            global::ElevenLabs.DubbingError? error,
            global::System.Collections.Generic.IList<global::ElevenLabs.VoicesNotPermittedWarning>? warnings)
        {
            this.LanguageId = languageId ?? throw new global::System.ArgumentNullException(nameof(languageId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.TargetLanguage = targetLanguage ?? throw new global::System.ArgumentNullException(nameof(targetLanguage));
            this.Status = status;
            this.ModelId = modelId;
            this.VoiceSettings = voiceSettings;
            this.Outputs = outputs;
            this.Revision = revision;
            this.OutputRevision = outputRevision;
            this.Error = error;
            this.Warnings = warnings;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingLanguageResponse" /> class.
        /// </summary>
        public DubbingLanguageResponse()
        {
        }

    }
}