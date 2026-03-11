
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request model for creating/updating an MCP Server configuration.
    /// </summary>
    public sealed partial class MCPServerRequestModel
    {
        /// <summary>
        /// Configuration details for the MCP Server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.MCPServerConfigInput Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerRequestModel" /> class.
        /// </summary>
        /// <param name="config">
        /// Configuration details for the MCP Server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerRequestModel(
            global::ElevenLabs.MCPServerConfigInput config)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerRequestModel" /> class.
        /// </summary>
        public MCPServerRequestModel()
        {
        }
    }
}