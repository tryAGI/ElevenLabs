
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadAssetV1AssetsPost
    {
        /// <summary>
        /// The file to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Asset { get; set; }

        /// <summary>
        /// The file to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Assetname { get; set; }

        /// <summary>
        /// Display name for the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadAssetV1AssetsPost" /> class.
        /// </summary>
        /// <param name="asset">
        /// The file to upload.
        /// </param>
        /// <param name="assetname">
        /// The file to upload.
        /// </param>
        /// <param name="name">
        /// Display name for the asset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUploadAssetV1AssetsPost(
            byte[] asset,
            string assetname,
            string name)
        {
            this.Asset = asset ?? throw new global::System.ArgumentNullException(nameof(asset));
            this.Assetname = assetname ?? throw new global::System.ArgumentNullException(nameof(assetname));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadAssetV1AssetsPost" /> class.
        /// </summary>
        public BodyUploadAssetV1AssetsPost()
        {
        }

    }
}