
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageListResponse
    {
        /// <summary>
        /// The page of language targets for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.LanguageResponse> Languages { get; set; }

        /// <summary>
        /// Cursor for the next page, or null when there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageListResponse" /> class.
        /// </summary>
        /// <param name="languages">
        /// The page of language targets for the project.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page, or null when there are no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageListResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.LanguageResponse> languages,
            string? nextCursor)
        {
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageListResponse" /> class.
        /// </summary>
        public LanguageListResponse()
        {
        }

    }
}