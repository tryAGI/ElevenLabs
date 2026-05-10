
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Regional processing surcharge details if this model has additional costs in the current deployment region. Null if no surcharge applies.
    /// </summary>
    public sealed partial class LLMInfoModelOutputRegionalProcessingSurcharge
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}