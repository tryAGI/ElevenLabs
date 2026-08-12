
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Pagination cursor: the `next_cursor` value of the previous page's response. Omit it for the first page.
    /// </summary>
    public sealed partial class ListImageGenerationsCursor
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}