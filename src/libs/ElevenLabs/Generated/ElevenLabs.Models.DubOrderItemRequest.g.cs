
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"captions_sdh":false,"destination_languages":["hi","fr-FR","de"],"include_captions":true,"include_source_captions":false,"instructions":"Voices don\u0027t need to match the originals, prioritize native-sounding voices","kind":"dub","media_id":"prodmedia_01jgatk6h0fwxrtbjade61yqhx","source_language":"en"}
    /// </summary>
    public sealed partial class DubOrderItemRequest
    {
        /// <summary>
        /// The type of order item.<br/>
        /// Default Value: dub
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The ID of the uploaded media file to dub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaId { get; set; }

        /// <summary>
        /// The language code of the source media (e.g. 'en', 'es').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceLanguage { get; set; }

        /// <summary>
        /// List of target language codes to dub the media into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DestinationLanguages { get; set; }

        /// <summary>
        /// Whether to generate captions for the dubbed outputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_captions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeCaptions { get; set; }

        /// <summary>
        /// Whether to generate captions for the source language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_source_captions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeSourceCaptions { get; set; }

        /// <summary>
        /// Optional free-text instructions for the dubbing team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Whether captions should use SDH format, which includes descriptions for deaf and hard-of-hearing viewers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("captions_sdh")]
        public bool? CaptionsSdh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubOrderItemRequest" /> class.
        /// </summary>
        /// <param name="mediaId">
        /// The ID of the uploaded media file to dub.
        /// </param>
        /// <param name="sourceLanguage">
        /// The language code of the source media (e.g. 'en', 'es').
        /// </param>
        /// <param name="destinationLanguages">
        /// List of target language codes to dub the media into.
        /// </param>
        /// <param name="includeCaptions">
        /// Whether to generate captions for the dubbed outputs.
        /// </param>
        /// <param name="includeSourceCaptions">
        /// Whether to generate captions for the source language.
        /// </param>
        /// <param name="kind">
        /// The type of order item.<br/>
        /// Default Value: dub
        /// </param>
        /// <param name="instructions">
        /// Optional free-text instructions for the dubbing team.
        /// </param>
        /// <param name="captionsSdh">
        /// Whether captions should use SDH format, which includes descriptions for deaf and hard-of-hearing viewers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubOrderItemRequest(
            string mediaId,
            string sourceLanguage,
            global::System.Collections.Generic.IList<string> destinationLanguages,
            bool includeCaptions,
            bool includeSourceCaptions,
            string? kind,
            string? instructions,
            bool? captionsSdh)
        {
            this.Kind = kind;
            this.MediaId = mediaId ?? throw new global::System.ArgumentNullException(nameof(mediaId));
            this.SourceLanguage = sourceLanguage ?? throw new global::System.ArgumentNullException(nameof(sourceLanguage));
            this.DestinationLanguages = destinationLanguages ?? throw new global::System.ArgumentNullException(nameof(destinationLanguages));
            this.IncludeCaptions = includeCaptions;
            this.IncludeSourceCaptions = includeSourceCaptions;
            this.Instructions = instructions;
            this.CaptionsSdh = captionsSdh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubOrderItemRequest" /> class.
        /// </summary>
        public DubOrderItemRequest()
        {
        }

    }
}