
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response model for structured music generation endpoint<br/>
    /// Example: {"composition_plan":{"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]},"song_metadata":{"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"}}
    /// </summary>
    public sealed partial class DetailedMusicResponse
    {
        /// <summary>
        /// Example: {"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]}
        /// </summary>
        /// <example>{"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.MusicPrompt CompositionPlan { get; set; } = default!;

        /// <summary>
        /// Example: {"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"}
        /// </summary>
        /// <example>{"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("song_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.SongMetadata SongMetadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedMusicResponse" /> class.
        /// </summary>
        /// <param name="compositionPlan">
        /// Example: {"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]}
        /// </param>
        /// <param name="songMetadata">
        /// Example: {"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"}
        /// </param>
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