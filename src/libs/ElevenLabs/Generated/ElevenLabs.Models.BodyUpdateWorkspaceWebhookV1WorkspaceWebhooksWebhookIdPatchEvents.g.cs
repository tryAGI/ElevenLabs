
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The complete set of workspace-level events this webhook should be subscribed to. The webhook is added to the events in the list and removed from any not in the list. Omit to leave the current event subscriptions unchanged.
    /// </summary>
    public sealed partial class BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatchEvents
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}