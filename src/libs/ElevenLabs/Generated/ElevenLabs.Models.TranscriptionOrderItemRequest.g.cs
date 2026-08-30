
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"instructions":"Use speaker labels where possible.","kind":"transcription","media_ids":["prodmedia_01jgatk6h0fwxrtbjade61yqhx","prodmedia_01jgb2zd68f8f9tfvbb968wb8z"],"source_language":"en","verbatim":false}
    /// </summary>
    public sealed partial class TranscriptionOrderItemRequest
    {
        /// <summary>
        /// The type of order item.<br/>
        /// Default Value: transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The IDs of the uploaded media files to transcribe.
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
        /// Whether to transcribe every word exactly, including filler words.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbatim")]
        public bool? Verbatim { get; set; }

        /// <summary>
        /// Optional free-text instructions for the transcription team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionOrderItemRequest" /> class.
        /// </summary>
        /// <param name="mediaIds">
        /// The IDs of the uploaded media files to transcribe.
        /// </param>
        /// <param name="sourceLanguage">
        /// The language code of the source media (e.g. 'en', 'es').
        /// </param>
        /// <param name="kind">
        /// The type of order item.<br/>
        /// Default Value: transcription
        /// </param>
        /// <param name="verbatim">
        /// Whether to transcribe every word exactly, including filler words.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="instructions">
        /// Optional free-text instructions for the transcription team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionOrderItemRequest(
            global::System.Collections.Generic.IList<string> mediaIds,
            string sourceLanguage,
            string? kind,
            bool? verbatim,
            string? instructions)
        {
            this.Kind = kind;
            this.MediaIds = mediaIds ?? throw new global::System.ArgumentNullException(nameof(mediaIds));
            this.SourceLanguage = sourceLanguage ?? throw new global::System.ArgumentNullException(nameof(sourceLanguage));
            this.Verbatim = verbatim;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionOrderItemRequest" /> class.
        /// </summary>
        public TranscriptionOrderItemRequest()
        {
        }

    }
}