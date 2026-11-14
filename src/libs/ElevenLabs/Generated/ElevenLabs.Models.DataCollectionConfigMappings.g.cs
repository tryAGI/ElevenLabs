
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Copies data collection results into dynamic variables for later calls: each key is a data collection item ID and its value the variable's name.
    /// </summary>
    public sealed partial class DataCollectionConfigMappings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}