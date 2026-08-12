
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The public Asset object.<br/>
    /// Example: {"asset_id":"5xM2KqOnZyce22SPZ9d4","content_url":"https://.../a1b2c3d4/content?...","created_at_unix":1721520000,"mime_type":"audio/mpeg","name":"podcast-intro.mp3"}
    /// </summary>
    public sealed partial class AssetResponse
    {
        /// <summary>
        /// Unique identifier for the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetId { get; set; }

        /// <summary>
        /// Display name of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// MIME type of the uploaded file (e.g. `audio/mpeg`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) the asset was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAtUnix { get; set; }

        /// <summary>
        /// Signed URL to fetch the asset's content. May be `null` if the asset has not finished processing. Do not rely on it being valid for more than 1 hour; fetch the asset again for a fresh URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_url")]
        public string? ContentUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponse" /> class.
        /// </summary>
        /// <param name="assetId">
        /// Unique identifier for the asset.
        /// </param>
        /// <param name="name">
        /// Display name of the asset.
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the uploaded file (e.g. `audio/mpeg`).
        /// </param>
        /// <param name="createdAtUnix">
        /// Unix timestamp (seconds) the asset was created.
        /// </param>
        /// <param name="contentUrl">
        /// Signed URL to fetch the asset's content. May be `null` if the asset has not finished processing. Do not rely on it being valid for more than 1 hour; fetch the asset again for a fresh URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetResponse(
            string assetId,
            string name,
            string mimeType,
            global::System.DateTimeOffset createdAtUnix,
            string? contentUrl)
        {
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.CreatedAtUnix = createdAtUnix;
            this.ContentUrl = contentUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponse" /> class.
        /// </summary>
        public AssetResponse()
        {
        }

    }
}