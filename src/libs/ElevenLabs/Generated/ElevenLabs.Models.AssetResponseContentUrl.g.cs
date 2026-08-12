
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Signed URL to fetch the asset's content. May be `null` if the asset has not finished processing. Do not rely on it being valid for more than 1 hour; fetch the asset again for a fresh URL.
    /// </summary>
    public sealed partial class AssetResponseContentUrl
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}