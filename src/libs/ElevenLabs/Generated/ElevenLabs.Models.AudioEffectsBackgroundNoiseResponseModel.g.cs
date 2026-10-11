
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioEffectsBackgroundNoiseResponseModel
    {
        /// <summary>
        /// Value for `audio_effects.background_noise_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BackgroundNoiseId { get; set; }

        /// <summary>
        /// Display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// What the noise bed sounds like.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEffectsBackgroundNoiseResponseModel" /> class.
        /// </summary>
        /// <param name="backgroundNoiseId">
        /// Value for `audio_effects.background_noise_id`.
        /// </param>
        /// <param name="name">
        /// Display name.
        /// </param>
        /// <param name="description">
        /// What the noise bed sounds like.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioEffectsBackgroundNoiseResponseModel(
            string backgroundNoiseId,
            string name,
            string? description)
        {
            this.BackgroundNoiseId = backgroundNoiseId ?? throw new global::System.ArgumentNullException(nameof(backgroundNoiseId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEffectsBackgroundNoiseResponseModel" /> class.
        /// </summary>
        public AudioEffectsBackgroundNoiseResponseModel()
        {
        }

    }
}