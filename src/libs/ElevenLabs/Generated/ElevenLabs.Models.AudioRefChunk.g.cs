
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioRefChunk
    {
        /// <summary>
        /// The ID of the song to source the chunk from. You can find the song ID in the response headers when you generate a song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("song_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SongId { get; set; }

        /// <summary>
        /// The time range to extract from the song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TimeRange Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioRefChunk" /> class.
        /// </summary>
        /// <param name="songId">
        /// The ID of the song to source the chunk from. You can find the song ID in the response headers when you generate a song.
        /// </param>
        /// <param name="range">
        /// The time range to extract from the song.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioRefChunk(
            string songId,
            global::ElevenLabs.TimeRange range)
        {
            this.SongId = songId ?? throw new global::System.ArgumentNullException(nameof(songId));
            this.Range = range ?? throw new global::System.ArgumentNullException(nameof(range));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioRefChunk" /> class.
        /// </summary>
        public AudioRefChunk()
        {
        }

    }
}