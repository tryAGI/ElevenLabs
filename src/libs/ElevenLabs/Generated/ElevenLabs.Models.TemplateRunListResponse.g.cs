
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// One page of the caller's public-API template runs, newest first.<br/>
    /// Example: {"has_more":true,"next_cursor":"MjAyNi0wNy0xN1QxMjowMDowMHxLeDJtUDdZNFdWcmc5a0UzTm5SYw","runs":[{"id":"sess_JWr5N6X9ZTqf8jD2LmQb","outputs":{"marketing_title":{"content":"Ride the wave.","id":"Kx2mP7Y4WVrg9kE3NnRc","status":"completed","type":"string"},"product_demo":{"id":"QWr5N6X9ZTqf8jD2La3B","status":"generating","type":"video"},"product_still":{"content_mime_type":"image/png","content_url":"https://storage.googleapis.com/generations/JWr5N6X9ZTqf8jD2LmQb","id":"JWr5N6X9ZTqf8jD2LmQb","status":"completed","type":"image"}},"status":"generating","template_id":"tmpl_abc123","version_id":"ver_01hxyz"}]}
    /// </summary>
    public sealed partial class TemplateRunListResponse
    {
        /// <summary>
        /// The runs on this page, newest first. Each item has the same shape as `GET /v1/flows/templates/{template_id}/runs/{run_id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunResponse> Runs { get; set; }

        /// <summary>
        /// Pass as `cursor` to fetch the next page. `null` when there is no further page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether more runs exist beyond this page.<br/>
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
        /// Initializes a new instance of the <see cref="TemplateRunListResponse" /> class.
        /// </summary>
        /// <param name="runs">
        /// The runs on this page, newest first. Each item has the same shape as `GET /v1/flows/templates/{template_id}/runs/{run_id}`.
        /// </param>
        /// <param name="nextCursor">
        /// Pass as `cursor` to fetch the next page. `null` when there is no further page.
        /// </param>
        /// <param name="hasMore">
        /// Whether more runs exist beyond this page.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateRunListResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunResponse> runs,
            string? nextCursor,
            bool hasMore = default!)
        {
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunListResponse" /> class.
        /// </summary>
        public TemplateRunListResponse()
        {
        }

    }
}