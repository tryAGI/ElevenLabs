
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Sort criteria. Must be one of: created_date, usage_character_count_1y, trending, cloned_by_count.<br/>
    /// Default Value: created_date
    /// </summary>
    public sealed partial class GetLibraryVoicesSort
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}