
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// One page of the templates the caller can run, most recently updated first.<br/>
    /// Example: {"has_more":true,"next_cursor":"cGFnZXwx","templates":[{"description":"Drop in a product photo, get a studio shot.","has_more_versions":false,"id":"tmpl_abc123","name":"Product shot","versions":[{"inputs":[{"content_schema":{"title":"Prompt","type":"string"},"id":"prompt"},{"content_schema":{"description":"A clean product photo on any background.","title":"Product photo","type":"image"},"id":"reference"}],"is_latest":true,"outputs":[{"content_schema":{"title":"Final image","type":"image"},"id":"product_still"}],"published_at_unix":1739721600,"version_id":"ver_01hxyz"}]}]}
    /// </summary>
    public sealed partial class TemplateListResponse
    {
        /// <summary>
        /// The templates on this page, most recently updated first. A page can hold fewer than `page_size` templates, or none at all, because templates you cannot run are filtered out after the page is read — keep paging while `has_more` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TemplateSummary> Templates { get; set; }

        /// <summary>
        /// Pass as `cursor` to fetch the next page. `null` when there is no further page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether more templates exist beyond this page.<br/>
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
        /// Initializes a new instance of the <see cref="TemplateListResponse" /> class.
        /// </summary>
        /// <param name="templates">
        /// The templates on this page, most recently updated first. A page can hold fewer than `page_size` templates, or none at all, because templates you cannot run are filtered out after the page is read — keep paging while `has_more` is true.
        /// </param>
        /// <param name="nextCursor">
        /// Pass as `cursor` to fetch the next page. `null` when there is no further page.
        /// </param>
        /// <param name="hasMore">
        /// Whether more templates exist beyond this page.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateListResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.TemplateSummary> templates,
            string? nextCursor,
            bool hasMore = default!)
        {
            this.Templates = templates ?? throw new global::System.ArgumentNullException(nameof(templates));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponse" /> class.
        /// </summary>
        public TemplateListResponse()
        {
        }

    }
}