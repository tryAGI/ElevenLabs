
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// ID of an uploaded asset. For image/video/audio, set exactly one of `content_asset_id` or `generation_id`.
    /// </summary>
    public sealed partial class AddStaticAssetNodeInputContentAssetId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}