
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioEffectsFilterPresetResponseModel
    {
        /// <summary>
        /// Value for `audio_effects.filter_preset_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_preset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilterPresetId { get; set; }

        /// <summary>
        /// Display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// What the preset sounds like.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEffectsFilterPresetResponseModel" /> class.
        /// </summary>
        /// <param name="filterPresetId">
        /// Value for `audio_effects.filter_preset_id`.
        /// </param>
        /// <param name="name">
        /// Display name.
        /// </param>
        /// <param name="description">
        /// What the preset sounds like.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioEffectsFilterPresetResponseModel(
            string filterPresetId,
            string name,
            string? description)
        {
            this.FilterPresetId = filterPresetId ?? throw new global::System.ArgumentNullException(nameof(filterPresetId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEffectsFilterPresetResponseModel" /> class.
        /// </summary>
        public AudioEffectsFilterPresetResponseModel()
        {
        }

    }
}