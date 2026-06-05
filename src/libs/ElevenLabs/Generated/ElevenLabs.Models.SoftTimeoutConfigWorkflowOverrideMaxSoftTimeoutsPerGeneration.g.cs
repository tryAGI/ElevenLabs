
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Maximum filler messages while waiting for a single LLM response. Fires every timeout_seconds until the LLM streams content or this limit is reached.
    /// </summary>
    public sealed partial class SoftTimeoutConfigWorkflowOverrideMaxSoftTimeoutsPerGeneration
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}