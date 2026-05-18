
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"cue_options":{"max_chars_per_line":42,"max_duration_ms":7000,"max_lines_per_cue":2,"min_duration_ms":1000},"destination_languages":["hi","fr-FR","de"],"instructions":"Keep reading speed moderate; preserve humor in idioms.","kind":"subtitles","media_ids":["prodmedia_01jgatk6h0fwxrtbjade61yqhx","prodmedia_01jgb2zd68f8f9tfvbb968wb8z"],"sdh":false,"source_language":"en"}
    /// </summary>
    public sealed partial class SubtitleOrderItemRequest
    {
        /// <summary>
        /// The type of order item.<br/>
        /// Default Value: subtitles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The IDs of the uploaded media files to generate subtitles for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MediaIds { get; set; }

        /// <summary>
        /// The language code of the source media (e.g. 'en', 'es').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceLanguage { get; set; }

        /// <summary>
        /// List of target language codes. Subtitles will be generated for each media file in each destination language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DestinationLanguages { get; set; }

        /// <summary>
        /// Formatting options for subtitle cues such as duration, line count, and character limits.<br/>
        /// Example: {"max_chars_per_line":42,"max_duration_ms":7000,"max_lines_per_cue":2,"min_duration_ms":1000}
        /// </summary>
        /// <example>{"max_chars_per_line":42,"max_duration_ms":7000,"max_lines_per_cue":2,"min_duration_ms":1000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cue_options")]
        public global::ElevenLabs.CueOptionsRequest? CueOptions { get; set; }

        /// <summary>
        /// Whether subtitles should use SDH format, which includes descriptions for deaf and hard-of-hearing viewers.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdh")]
        public bool? Sdh { get; set; }

        /// <summary>
        /// Optional free-text instructions for the subtitling team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubtitleOrderItemRequest" /> class.
        /// </summary>
        /// <param name="mediaIds">
        /// The IDs of the uploaded media files to generate subtitles for.
        /// </param>
        /// <param name="sourceLanguage">
        /// The language code of the source media (e.g. 'en', 'es').
        /// </param>
        /// <param name="destinationLanguages">
        /// List of target language codes. Subtitles will be generated for each media file in each destination language.
        /// </param>
        /// <param name="kind">
        /// The type of order item.<br/>
        /// Default Value: subtitles
        /// </param>
        /// <param name="cueOptions">
        /// Formatting options for subtitle cues such as duration, line count, and character limits.<br/>
        /// Example: {"max_chars_per_line":42,"max_duration_ms":7000,"max_lines_per_cue":2,"min_duration_ms":1000}
        /// </param>
        /// <param name="sdh">
        /// Whether subtitles should use SDH format, which includes descriptions for deaf and hard-of-hearing viewers.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="instructions">
        /// Optional free-text instructions for the subtitling team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubtitleOrderItemRequest(
            global::System.Collections.Generic.IList<string> mediaIds,
            string sourceLanguage,
            global::System.Collections.Generic.IList<string> destinationLanguages,
            string? kind,
            global::ElevenLabs.CueOptionsRequest? cueOptions,
            bool? sdh,
            string? instructions)
        {
            this.Kind = kind;
            this.MediaIds = mediaIds ?? throw new global::System.ArgumentNullException(nameof(mediaIds));
            this.SourceLanguage = sourceLanguage ?? throw new global::System.ArgumentNullException(nameof(sourceLanguage));
            this.DestinationLanguages = destinationLanguages ?? throw new global::System.ArgumentNullException(nameof(destinationLanguages));
            this.CueOptions = cueOptions;
            this.Sdh = sdh;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubtitleOrderItemRequest" /> class.
        /// </summary>
        public SubtitleOrderItemRequest()
        {
        }

    }
}