
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string SourceLanguage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<string> TargetLanguages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.DubbingMediaReference Input { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::ElevenLabs.DubbingMediaReference? Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foreground")]
        public global::ElevenLabs.DubbingMediaReference? Foreground { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_tracks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerTrack> SpeakerTracks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerSegment> SpeakerSegments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.Render> Renders { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingResource" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="sourceLanguage"></param>
        /// <param name="targetLanguages"></param>
        /// <param name="input"></param>
        /// <param name="background"></param>
        /// <param name="foreground"></param>
        /// <param name="speakerTracks"></param>
        /// <param name="speakerSegments"></param>
        /// <param name="renders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingResource(
            string id,
            int version,
            string sourceLanguage,
            global::System.Collections.Generic.IList<string> targetLanguages,
            global::ElevenLabs.DubbingMediaReference input,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerTrack> speakerTracks,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerSegment> speakerSegments,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.Render> renders,
            global::ElevenLabs.DubbingMediaReference? background,
            global::ElevenLabs.DubbingMediaReference? foreground)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.SourceLanguage = sourceLanguage ?? throw new global::System.ArgumentNullException(nameof(sourceLanguage));
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.SpeakerTracks = speakerTracks ?? throw new global::System.ArgumentNullException(nameof(speakerTracks));
            this.SpeakerSegments = speakerSegments ?? throw new global::System.ArgumentNullException(nameof(speakerSegments));
            this.Renders = renders ?? throw new global::System.ArgumentNullException(nameof(renders));
            this.Background = background;
            this.Foreground = foreground;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingResource" /> class.
        /// </summary>
        public DubbingResource()
        {
        }
    }
}