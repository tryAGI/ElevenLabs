
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Exclude conversations with the given statuses. Useful for hiding in-progress / processing conversations from list views.
    /// </summary>
    public sealed partial class GetConversationHistoriesRouteExcludeStatuses
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}