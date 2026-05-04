
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundMusicConfig
    {
        /// <summary>
        /// The type of background music source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public global::ElevenLabs.BackgroundMusicSourceType? SourceType { get; set; }

        /// <summary>
        /// Identifier for the music source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        public global::ElevenLabs.BackgroundMusicPresetId? SourceId { get; set; }

        /// <summary>
        /// Volume level for background music (0.01 to 1.0).<br/>
        /// Default Value: 0.6F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Apply a crossfade at the loop boundary to avoid audible pops when the music loops.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crossfade_loop")]
        public bool? CrossfadeLoop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundMusicConfig" /> class.
        /// </summary>
        /// <param name="sourceType">
        /// The type of background music source.
        /// </param>
        /// <param name="sourceId">
        /// Identifier for the music source.
        /// </param>
        /// <param name="volume">
        /// Volume level for background music (0.01 to 1.0).<br/>
        /// Default Value: 0.6F
        /// </param>
        /// <param name="crossfadeLoop">
        /// Apply a crossfade at the loop boundary to avoid audible pops when the music loops.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundMusicConfig(
            global::ElevenLabs.BackgroundMusicSourceType? sourceType,
            global::ElevenLabs.BackgroundMusicPresetId? sourceId,
            double? volume,
            bool? crossfadeLoop)
        {
            this.SourceType = sourceType;
            this.SourceId = sourceId;
            this.Volume = volume;
            this.CrossfadeLoop = crossfadeLoop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundMusicConfig" /> class.
        /// </summary>
        public BackgroundMusicConfig()
        {
        }
    }
}