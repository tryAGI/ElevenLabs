
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Custom hold audio played to queued callers; when unset, callers hear the default hold tone. Set via the hold-audio upload route, not writable through agent PATCH.
    /// </summary>
    public sealed partial class AgentQueueingConfigHoldAudio
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}