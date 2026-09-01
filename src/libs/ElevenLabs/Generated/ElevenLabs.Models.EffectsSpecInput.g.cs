
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Filter preset, distance (proximity EQ), and environment (convolution reverb).
    /// </summary>
    public sealed partial class EffectsSpecInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_preset_id")]
        public string? FilterPresetId { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public double? Distance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise_id")]
        public string? BackgroundNoiseId { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_level")]
        public double? SendLevel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectsSpecInput" /> class.
        /// </summary>
        /// <param name="filterPresetId"></param>
        /// <param name="distance">
        /// Default Value: 0F
        /// </param>
        /// <param name="environmentId"></param>
        /// <param name="backgroundNoiseId"></param>
        /// <param name="sendLevel">
        /// Default Value: 1F
        /// </param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectsSpecInput(
            string? filterPresetId,
            double? distance,
            string? environmentId,
            string? backgroundNoiseId,
            double? sendLevel,
            int? seed)
        {
            this.FilterPresetId = filterPresetId;
            this.Distance = distance;
            this.EnvironmentId = environmentId;
            this.BackgroundNoiseId = backgroundNoiseId;
            this.SendLevel = sendLevel;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectsSpecInput" /> class.
        /// </summary>
        public EffectsSpecInput()
        {
        }

    }
}