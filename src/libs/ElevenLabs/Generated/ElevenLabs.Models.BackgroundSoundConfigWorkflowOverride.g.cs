
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundSoundConfigWorkflowOverride
    {
        /// <summary>
        /// The type of background sound source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public global::ElevenLabs.BackgroundSoundSourceType? SourceType { get; set; }

        /// <summary>
        /// Identifier for the sound source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        public global::ElevenLabs.BackgroundSoundPresetId? SourceId { get; set; }

        /// <summary>
        /// Volume level for background sound (0.01 to 1.0).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Apply a crossfade at the loop boundary to avoid audible pops when the sound loops.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crossfade_loop")]
        public bool? CrossfadeLoop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundSoundConfigWorkflowOverride" /> class.
        /// </summary>
        /// <param name="sourceType">
        /// The type of background sound source.
        /// </param>
        /// <param name="sourceId">
        /// Identifier for the sound source.
        /// </param>
        /// <param name="volume">
        /// Volume level for background sound (0.01 to 1.0).
        /// </param>
        /// <param name="crossfadeLoop">
        /// Apply a crossfade at the loop boundary to avoid audible pops when the sound loops.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundSoundConfigWorkflowOverride(
            global::ElevenLabs.BackgroundSoundSourceType? sourceType,
            global::ElevenLabs.BackgroundSoundPresetId? sourceId,
            double? volume,
            bool? crossfadeLoop)
        {
            this.SourceType = sourceType;
            this.SourceId = sourceId;
            this.Volume = volume;
            this.CrossfadeLoop = crossfadeLoop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundSoundConfigWorkflowOverride" /> class.
        /// </summary>
        public BackgroundSoundConfigWorkflowOverride()
        {
        }

    }
}