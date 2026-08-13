
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Pass as `cursor` to fetch the next page. `null` if there are no more results.
    /// </summary>
    public sealed partial class AssetListResponseNextCursor
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}