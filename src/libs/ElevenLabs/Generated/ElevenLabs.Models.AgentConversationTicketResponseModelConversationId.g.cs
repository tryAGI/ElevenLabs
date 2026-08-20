
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Superseded by conversation_ids, which holds every conversation on the ticket. A clustered ticket leaves this null, so it under-reports. Read conversation_ids instead.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class AgentConversationTicketResponseModelConversationId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}