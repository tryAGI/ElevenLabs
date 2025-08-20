
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response model for structured music generation endpoint
    /// </summary>
    public sealed partial class DetailedMusicResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.MusicPrompt CompositionPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("song_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SongMetadata SongMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedMusicResponse" /> class.
        /// </summary>
        /// <param name="compositionPlan"></param>
        /// <param name="songMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetailedMusicResponse(
            global::ElevenLabs.MusicPrompt compositionPlan,
            global::ElevenLabs.SongMetadata songMetadata)
        {
            this.CompositionPlan = compositionPlan ?? throw new global::System.ArgumentNullException(nameof(compositionPlan));
            this.SongMetadata = songMetadata ?? throw new global::System.ArgumentNullException(nameof(songMetadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedMusicResponse" /> class.
        /// </summary>
        public DetailedMusicResponse()
        {
        }
    }
}