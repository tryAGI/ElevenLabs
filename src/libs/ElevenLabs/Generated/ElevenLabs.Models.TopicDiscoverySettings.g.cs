
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Per-agent topic-discovery configuration. Cadence and analysis window are<br/>
    /// managed internally; this only exposes the customer-facing on/off toggle.
    /// </summary>
    public sealed partial class TopicDiscoverySettings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}