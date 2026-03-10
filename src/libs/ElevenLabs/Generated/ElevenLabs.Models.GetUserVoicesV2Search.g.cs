
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Search term to filter voices by. Searches in name, description, labels, category.
    /// </summary>
    public sealed partial class GetUserVoicesV2Search
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}