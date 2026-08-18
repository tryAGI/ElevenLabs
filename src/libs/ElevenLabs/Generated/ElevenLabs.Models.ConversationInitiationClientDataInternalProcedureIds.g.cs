
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// If set, only these procedures are available to the starting agent. Each ID must be attached to that agent; unknown IDs fail conversation start. An empty list disables all of that agent's procedures. Not applied after an agent transfer. Requires enable_procedure_ids_from_client.
    /// </summary>
    public sealed partial class ConversationInitiationClientDataInternalProcedureIds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}