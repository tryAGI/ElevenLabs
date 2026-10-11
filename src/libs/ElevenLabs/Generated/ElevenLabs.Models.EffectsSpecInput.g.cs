
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Audio effects applied to generated speech: a filter preset, perceived distance, a reverb<br/>
    /// environment, a background noise bed, and stereo panning. Leave every field at its default<br/>
    /// to get unprocessed audio.
    /// </summary>
    public sealed partial class EffectsSpecInput
    {
        /// <summary>
        /// ID of a filter preset that colors the voice, such as `phone` or `old_radio`. List valid IDs with `GET /v1/audio-effects/catalog`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_preset_id")]
        public string? FilterPresetId { get; set; }

        /// <summary>
        /// How far the speaker sounds from the microphone, from 0 (close, unchanged) to 1 (far). Higher values roll off low and high frequencies and, when an environment is set, shift the balance from the dry voice toward the reverb.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public double? Distance { get; set; }

        /// <summary>
        /// ID of a reverb environment that places the voice in a space, such as `small_room` or `hall`. List valid IDs with `GET /v1/audio-effects/catalog`. Reverb is rendered in stereo and adds a tail of up to several seconds after the speech ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// ID of a background noise bed looped under the voice, such as `cafe` or `keyboard`. List valid IDs with `GET /v1/audio-effects/catalog`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise_id")]
        public string? BackgroundNoiseId { get; set; }

        /// <summary>
        /// How much of the voice feeds the reverb, from 0 (none) to 1 (full). Only applies when `environment_id` is set; 0 turns the reverb off.<br/>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_level")]
        public double? SendLevel { get; set; }

        /// <summary>
        /// Stereo position of the voice, from -1 (hard left) through 0 (center) to 1 (hard right). Only the voice is panned; reverb and background noise stay centered.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pan")]
        public double? Pan { get; set; }

        /// <summary>
        /// Has no effect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectsSpecInput" /> class.
        /// </summary>
        /// <param name="filterPresetId">
        /// ID of a filter preset that colors the voice, such as `phone` or `old_radio`. List valid IDs with `GET /v1/audio-effects/catalog`.
        /// </param>
        /// <param name="distance">
        /// How far the speaker sounds from the microphone, from 0 (close, unchanged) to 1 (far). Higher values roll off low and high frequencies and, when an environment is set, shift the balance from the dry voice toward the reverb.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="environmentId">
        /// ID of a reverb environment that places the voice in a space, such as `small_room` or `hall`. List valid IDs with `GET /v1/audio-effects/catalog`. Reverb is rendered in stereo and adds a tail of up to several seconds after the speech ends.
        /// </param>
        /// <param name="backgroundNoiseId">
        /// ID of a background noise bed looped under the voice, such as `cafe` or `keyboard`. List valid IDs with `GET /v1/audio-effects/catalog`.
        /// </param>
        /// <param name="sendLevel">
        /// How much of the voice feeds the reverb, from 0 (none) to 1 (full). Only applies when `environment_id` is set; 0 turns the reverb off.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="pan">
        /// Stereo position of the voice, from -1 (hard left) through 0 (center) to 1 (hard right). Only the voice is panned; reverb and background noise stay centered.<br/>
        /// Default Value: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectsSpecInput(
            string? filterPresetId,
            double? distance,
            string? environmentId,
            string? backgroundNoiseId,
            double? sendLevel,
            double? pan)
        {
            this.FilterPresetId = filterPresetId;
            this.Distance = distance;
            this.EnvironmentId = environmentId;
            this.BackgroundNoiseId = backgroundNoiseId;
            this.SendLevel = sendLevel;
            this.Pan = pan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectsSpecInput" /> class.
        /// </summary>
        public EffectsSpecInput()
        {
        }

    }
}