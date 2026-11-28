
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Replaces the workspace's whole metadata map; send `{}` to clear it. Omitted leaves it unchanged.
    /// </summary>
    public sealed partial class UpdateResellerWorkspaceRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}