
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Filter tools by creator user ID. When set, only tools created by this user are returned. Takes precedence over show_only_owned_documents. Use '@me' to refer to the authenticated user.
    /// </summary>
    public sealed partial class GetToolsRouteCreatedByUserId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}