
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MusicFinetuneResponseModel
    {
        /// <summary>
        /// Unique identifier of the finetune.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the finetune.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tags associated with the finetune.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Primary musical genre of the finetune.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_genre")]
        public string? PrimaryGenre { get; set; }

        /// <summary>
        /// The base music model the finetune was trained on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// When the finetune was created (UTC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Who can access this finetune: `private` (only you), `workspace` (members of your workspace), `public` (ElevenLabs-curated, available to everyone).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.FinetuneVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.FinetuneVisibility Visibility { get; set; }

        /// <summary>
        /// Who created the finetune: `self`, `workspace`, or `elevenlabs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.FinetuneCreatedByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.FinetuneCreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Training lifecycle status: pending, in_progress, completed, failed, and blocked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MusicFinetuneStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.MusicFinetuneStatus Status { get; set; }

        /// <summary>
        /// Training progress from 0.0 to 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TrainingProgress { get; set; }

        /// <summary>
        /// Reason the finetune failed or was blocked, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public global::ElevenLabs.MusicFinetuneFailureReason? FailureReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicFinetuneResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the finetune.
        /// </param>
        /// <param name="name">
        /// Name of the finetune.
        /// </param>
        /// <param name="tags">
        /// Tags associated with the finetune.
        /// </param>
        /// <param name="modelId">
        /// The base music model the finetune was trained on.
        /// </param>
        /// <param name="createdAt">
        /// When the finetune was created (UTC).
        /// </param>
        /// <param name="visibility">
        /// Who can access this finetune: `private` (only you), `workspace` (members of your workspace), `public` (ElevenLabs-curated, available to everyone).
        /// </param>
        /// <param name="createdBy">
        /// Who created the finetune: `self`, `workspace`, or `elevenlabs`.
        /// </param>
        /// <param name="status">
        /// Training lifecycle status: pending, in_progress, completed, failed, and blocked.
        /// </param>
        /// <param name="trainingProgress">
        /// Training progress from 0.0 to 1.0.
        /// </param>
        /// <param name="primaryGenre">
        /// Primary musical genre of the finetune.
        /// </param>
        /// <param name="failureReason">
        /// Reason the finetune failed or was blocked, if applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicFinetuneResponseModel(
            string id,
            string name,
            global::System.Collections.Generic.IList<string> tags,
            string modelId,
            global::System.DateTime createdAt,
            global::ElevenLabs.FinetuneVisibility visibility,
            global::ElevenLabs.FinetuneCreatedBy createdBy,
            global::ElevenLabs.MusicFinetuneStatus status,
            double trainingProgress,
            string? primaryGenre,
            global::ElevenLabs.MusicFinetuneFailureReason? failureReason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.PrimaryGenre = primaryGenre;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.CreatedAt = createdAt;
            this.Visibility = visibility;
            this.CreatedBy = createdBy;
            this.Status = status;
            this.TrainingProgress = trainingProgress;
            this.FailureReason = failureReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicFinetuneResponseModel" /> class.
        /// </summary>
        public MusicFinetuneResponseModel()
        {
        }

    }
}