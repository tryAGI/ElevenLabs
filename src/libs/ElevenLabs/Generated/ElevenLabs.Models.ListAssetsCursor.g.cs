
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Token from a previous response's `next_cursor`. Omit to fetch the first page.
    /// </summary>
    public sealed partial class ListAssetsCursor
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}