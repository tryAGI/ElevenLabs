
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response model representing an MCP Server configuration.
    /// </summary>
    public sealed partial class MCPServerResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.MCPServerConfigOutput Config { get; set; } = default!;

        /// <summary>
        /// The access information of the MCP Server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        public global::ElevenLabs.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// List of agents that depend on this MCP Server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependent_agents")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem5>? DependentAgents { get; set; }

        /// <summary>
        /// The metadata of the MCP Server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.MCPServerMetadataResponseModel Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="config"></param>
        /// <param name="accessInfo">
        /// The access information of the MCP Server
        /// </param>
        /// <param name="dependentAgents">
        /// List of agents that depend on this MCP Server.
        /// </param>
        /// <param name="metadata">
        /// The metadata of the MCP Server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerResponseModel(
            string id,
            global::ElevenLabs.MCPServerConfigOutput config,
            global::ElevenLabs.MCPServerMetadataResponseModel metadata,
            global::ElevenLabs.ResourceAccessInfo? accessInfo,
            global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem5>? dependentAgents)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.AccessInfo = accessInfo;
            this.DependentAgents = dependentAgents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerResponseModel" /> class.
        /// </summary>
        public MCPServerResponseModel()
        {
        }
    }
}