
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Dependencies that use an auth connection
    /// </summary>
    public sealed partial class AuthConnectionDependencies
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem>? Tools { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem>? McpServers { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_connections")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentIntegrationConnectionIdentifier>? IntegrationConnections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthConnectionDependencies" /> class.
        /// </summary>
        /// <param name="tools">
        /// Default Value: []
        /// </param>
        /// <param name="mcpServers">
        /// Default Value: []
        /// </param>
        /// <param name="integrationConnections">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthConnectionDependencies(
            global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem>? tools,
            global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem>? mcpServers,
            global::System.Collections.Generic.IList<global::ElevenLabs.DependentIntegrationConnectionIdentifier>? integrationConnections)
        {
            this.Tools = tools;
            this.McpServers = mcpServers;
            this.IntegrationConnections = integrationConnections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthConnectionDependencies" /> class.
        /// </summary>
        public AuthConnectionDependencies()
        {
        }

    }
}