
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// One page of the caller's generations, newest first.<br/>
    /// Example: {"generations":[{"content_mime_type":"video/mp4","content_url":"https://storage.googleapis.com/generations/JWr5N6X9ZTqf8jD2LmQb","id":"JWr5N6X9ZTqf8jD2LmQb","status":"completed"},{"id":"Kx2mP7Y4WVrg9kE3NnRc","status":"generating"}],"has_more":true,"next_cursor":"MjAyNi0wNy0xN1QxMjowMDowMHxLeDJtUDdZNFdWcmc5a0UzTm5SYw"}
    /// </summary>
    public sealed partial class MediaGenerationListResponse
    {
        /// <summary>
        /// The generations on this page, newest first. Each item has the same shape as the corresponding GET endpoint's response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.MediaGenerationResponse> Generations { get; set; }

        /// <summary>
        /// Pass as `cursor` to fetch the next page. `null` when there is no further page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether more generations exist beyond this page.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaGenerationListResponse" /> class.
        /// </summary>
        /// <param name="generations">
        /// The generations on this page, newest first. Each item has the same shape as the corresponding GET endpoint's response.
        /// </param>
        /// <param name="nextCursor">
        /// Pass as `cursor` to fetch the next page. `null` when there is no further page.
        /// </param>
        /// <param name="hasMore">
        /// Whether more generations exist beyond this page.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaGenerationListResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.MediaGenerationResponse> generations,
            string? nextCursor,
            bool hasMore = default!)
        {
            this.Generations = generations ?? throw new global::System.ArgumentNullException(nameof(generations));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaGenerationListResponse" /> class.
        /// </summary>
        public MediaGenerationListResponse()
        {
        }

    }
}