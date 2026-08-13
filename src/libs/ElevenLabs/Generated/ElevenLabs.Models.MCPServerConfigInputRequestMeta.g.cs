
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Entries sent in the MCP `_meta` field of tools/call requests. Values may be JSON scalars, or references to a workspace secret, dynamic variable, or environment variable resolved per call.
    /// </summary>
    public sealed partial class MCPServerConfigInputRequestMeta
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}