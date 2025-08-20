
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Multipart response structure with JSON metadata and binary audio
    /// </summary>
    public sealed partial class MultipartMusicResponse
    {
        /// <summary>
        /// Response model for structured music generation endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DetailedMusicResponse Metadata { get; set; }

        /// <summary>
        /// Binary audio data in the requested format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// Binary audio data in the requested format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartMusicResponse" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Response model for structured music generation endpoint
        /// </param>
        /// <param name="audio">
        /// Binary audio data in the requested format
        /// </param>
        /// <param name="audioname">
        /// Binary audio data in the requested format
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultipartMusicResponse(
            global::ElevenLabs.DetailedMusicResponse metadata,
            byte[] audio,
            string audioname)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartMusicResponse" /> class.
        /// </summary>
        public MultipartMusicResponse()
        {
        }
    }
}