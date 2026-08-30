
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An asset uploaded via the assets API.
    /// </summary>
    public sealed partial class StaticAssetReference
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"asset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "asset";

        /// <summary>
        /// The ID of an asset uploaded via the assets API (`POST /v1/assets`), as returned in that response's `asset_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticAssetReference" /> class.
        /// </summary>
        /// <param name="assetId">
        /// The ID of an asset uploaded via the assets API (`POST /v1/assets`), as returned in that response's `asset_id`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StaticAssetReference(
            string assetId,
            string type = "asset")
        {
            this.Type = type;
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticAssetReference" /> class.
        /// </summary>
        public StaticAssetReference()
        {
        }

        /// <summary>
        /// Creates a new <see cref="StaticAssetReference"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static StaticAssetReference FromAssetId(string assetId)
        {
            return new StaticAssetReference
            {
                AssetId = assetId,
            };
        }

    }
}