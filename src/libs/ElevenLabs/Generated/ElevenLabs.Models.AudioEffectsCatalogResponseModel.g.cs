
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioEffectsCatalogResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_presets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsFilterPresetResponseModel> FilterPresets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsEnvironmentResponseModel> Environments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noises")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel> BackgroundNoises { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEffectsCatalogResponseModel" /> class.
        /// </summary>
        /// <param name="filterPresets"></param>
        /// <param name="environments"></param>
        /// <param name="backgroundNoises"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioEffectsCatalogResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsFilterPresetResponseModel> filterPresets,
            global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsEnvironmentResponseModel> environments,
            global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel> backgroundNoises)
        {
            this.FilterPresets = filterPresets ?? throw new global::System.ArgumentNullException(nameof(filterPresets));
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.BackgroundNoises = backgroundNoises ?? throw new global::System.ArgumentNullException(nameof(backgroundNoises));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEffectsCatalogResponseModel" /> class.
        /// </summary>
        public AudioEffectsCatalogResponseModel()
        {
        }

    }
}