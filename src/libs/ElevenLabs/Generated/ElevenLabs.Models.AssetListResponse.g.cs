
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// One page of the workspace's assets, most recently created first.<br/>
    /// Example: {"assets":[{"asset_id":"5xM2KqOnZyce22SPZ9d4","content_url":"https://.../a1b2c3d4/content?...","created_at_unix":1721520000,"mime_type":"audio/mpeg","name":"podcast-intro.mp3"}],"has_more":true,"next_cursor":"eyJvZmZzZXQiOjEwfQ"}
    /// </summary>
    public sealed partial class AssetListResponse
    {
        /// <summary>
        /// List of Asset objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AssetResponse> Assets { get; set; }

        /// <summary>
        /// Pass as `cursor` to fetch the next page. `null` if there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more results to fetch.<br/>
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
        /// Initializes a new instance of the <see cref="AssetListResponse" /> class.
        /// </summary>
        /// <param name="assets">
        /// List of Asset objects.
        /// </param>
        /// <param name="nextCursor">
        /// Pass as `cursor` to fetch the next page. `null` if there are no more results.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more results to fetch.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetListResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.AssetResponse> assets,
            string? nextCursor,
            bool hasMore = default!)
        {
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetListResponse" /> class.
        /// </summary>
        public AssetListResponse()
        {
        }

    }
}