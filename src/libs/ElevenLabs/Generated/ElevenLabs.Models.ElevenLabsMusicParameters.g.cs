
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Parameters for ElevenLabs Music generation in Flows.
    /// </summary>
    public sealed partial class ElevenLabsMusicParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Generate instrumental music without vocals.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instrumental")]
        public bool? Instrumental { get; set; }

        /// <summary>
        /// How lyrics are handled: auto-generated, custom-provided, or instrumental only.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ElevenLabsMusicParametersLyricsTypeJsonConverter))]
        public global::ElevenLabs.ElevenLabsMusicParametersLyricsType? LyricsType { get; set; }

        /// <summary>
        /// Custom lyrics text or a reference to a text node's output. Ignored when lyrics_type is 'instrumental'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ReferenceText, object>))]
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? Lyrics { get; set; }

        /// <summary>
        /// Reference audio track to use as a style or melody guide.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::ElevenLabs.ReferenceAudio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsMusicParameters" /> class.
        /// </summary>
        /// <param name="durationSeconds"></param>
        /// <param name="instrumental">
        /// Generate instrumental music without vocals.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="lyricsType">
        /// How lyrics are handled: auto-generated, custom-provided, or instrumental only.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="lyrics">
        /// Custom lyrics text or a reference to a text node's output. Ignored when lyrics_type is 'instrumental'.
        /// </param>
        /// <param name="audio">
        /// Reference audio track to use as a style or melody guide.
        /// </param>
        /// <param name="chatId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsMusicParameters(
            double? durationSeconds,
            bool? instrumental,
            global::ElevenLabs.ElevenLabsMusicParametersLyricsType? lyricsType,
            global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? lyrics,
            global::ElevenLabs.ReferenceAudio? audio,
            string? chatId)
        {
            this.DurationSeconds = durationSeconds;
            this.Instrumental = instrumental;
            this.LyricsType = lyricsType;
            this.Lyrics = lyrics;
            this.Audio = audio;
            this.ChatId = chatId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsMusicParameters" /> class.
        /// </summary>
        public ElevenLabsMusicParameters()
        {
        }
    }
}