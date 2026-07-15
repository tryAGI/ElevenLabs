
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The workspace-level events this webhook is currently subscribed to. Only populated when usages are requested.
    /// </summary>
    public sealed partial class WorkspaceWebhookResponseModelEvents
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}