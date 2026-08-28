
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response model for music upload endpoint.<br/>
    /// Example: {"song_id":"jR4Xz8kL2mNpQ9wVtY1b"}
    /// </summary>
    public sealed partial class MusicUploadResponse
    {
        /// <summary>
        /// Unique identifier for the uploaded song
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("song_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SongId { get; set; }

        /// <summary>
        /// The composition plan extracted from the uploaded song. Only present if `extract_composition_plan` was provided in the request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan, object>))]
        public global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan, object>? CompositionPlan { get; set; }

        /// <summary>
        /// Word-level timestamps transcribed from the uploaded song. Only present if `with_timestamps` was True in the request body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words_timestamps")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.WordTimestamp>? WordsTimestamps { get; set; }

        /// <summary>
        /// A low-resolution waveform of the uploaded song, for showing a preview of it. Holds 4 values per second of audio, from -1000 to 1000. Stereo is mixed down to a single channel. Only present if `with_waveform_visual` was True in the request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waveform_visual")]
        public global::System.Collections.Generic.IList<int>? WaveformVisual { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicUploadResponse" /> class.
        /// </summary>
        /// <param name="songId">
        /// Unique identifier for the uploaded song
        /// </param>
        /// <param name="compositionPlan">
        /// The composition plan extracted from the uploaded song. Only present if `extract_composition_plan` was provided in the request body.
        /// </param>
        /// <param name="wordsTimestamps">
        /// Word-level timestamps transcribed from the uploaded song. Only present if `with_timestamps` was True in the request body
        /// </param>
        /// <param name="waveformVisual">
        /// A low-resolution waveform of the uploaded song, for showing a preview of it. Holds 4 values per second of audio, from -1000 to 1000. Stereo is mixed down to a single channel. Only present if `with_waveform_visual` was True in the request body.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicUploadResponse(
            string songId,
            global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan, object>? compositionPlan,
            global::System.Collections.Generic.IList<global::ElevenLabs.WordTimestamp>? wordsTimestamps,
            global::System.Collections.Generic.IList<int>? waveformVisual)
        {
            this.SongId = songId ?? throw new global::System.ArgumentNullException(nameof(songId));
            this.CompositionPlan = compositionPlan;
            this.WordsTimestamps = wordsTimestamps;
            this.WaveformVisual = waveformVisual;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicUploadResponse" /> class.
        /// </summary>
        public MusicUploadResponse()
        {
        }

    }
}