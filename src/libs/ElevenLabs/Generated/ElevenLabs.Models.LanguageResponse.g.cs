
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageResponse
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
        /// Lifecycle status: 'queued' (waiting on the project), 'processing', 'completed', 'stale' (source/transcript changed), or 'failed'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.LanguageResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.LanguageResponseStatus Status { get; set; }

        /// <summary>
        /// Effective dubbing model id (target override or project default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Voice settings applied to the whole language, or null if unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_settings")]
        public global::ElevenLabs.VoiceSettings? VoiceSettings { get; set; }

        /// <summary>
        /// Signed output URLs; null until the target has produced an output (present once 'completed', and kept while 'stale' -- compare `output_revision` against `revision` to tell whether the output is up to date).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::ElevenLabs.LanguageOutputs? Outputs { get; set; }

        /// <summary>
        /// Monotonic counter incremented whenever this target's transcript changes (a source edit affecting it, or an edit to its translation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// The `revision` the current dubbed output was generated from; equal to `revision` when up to date, less than it when 'stale'. Null until a generation has completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_revision")]
        public int? OutputRevision { get; set; }

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
        /// Initializes a new instance of the <see cref="LanguageResponse" /> class.
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
        /// Lifecycle status: 'queued' (waiting on the project), 'processing', 'completed', 'stale' (source/transcript changed), or 'failed'.
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
        /// Effective dubbing model id (target override or project default).
        /// </param>
        /// <param name="voiceSettings">
        /// Voice settings applied to the whole language, or null if unset.
        /// </param>
        /// <param name="outputs">
        /// Signed output URLs; null until the target has produced an output (present once 'completed', and kept while 'stale' -- compare `output_revision` against `revision` to tell whether the output is up to date).
        /// </param>
        /// <param name="outputRevision">
        /// The `revision` the current dubbed output was generated from; equal to `revision` when up to date, less than it when 'stale'. Null until a generation has completed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageResponse(
            string languageId,
            string projectId,
            string targetLanguage,
            global::ElevenLabs.LanguageResponseStatus status,
            int revision,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? modelId,
            global::ElevenLabs.VoiceSettings? voiceSettings,
            global::ElevenLabs.LanguageOutputs? outputs,
            int? outputRevision)
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
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageResponse" /> class.
        /// </summary>
        public LanguageResponse()
        {
        }

    }
}