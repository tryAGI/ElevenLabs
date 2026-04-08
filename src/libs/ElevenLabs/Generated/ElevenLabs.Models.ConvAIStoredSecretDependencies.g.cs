
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvAIStoredSecretDependencies
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem2> Tools { get; set; }

        /// <summary>
        /// Whether there are more tool dependents beyond the returned preview<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools_has_more")]
        public bool? ToolsHasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem> Agents { get; set; }

        /// <summary>
        /// Whether there are more agent dependents beyond the returned preview<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents_has_more")]
        public bool? AgentsHasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>? PhoneNumbers { get; set; }

        /// <summary>
        /// Whether there are more phone number dependents beyond the returned preview<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers_has_more")]
        public bool? PhoneNumbersHasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem2>? McpServers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("others")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.SecretDependencyType> Others { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIStoredSecretDependencies" /> class.
        /// </summary>
        /// <param name="tools"></param>
        /// <param name="agents"></param>
        /// <param name="others"></param>
        /// <param name="toolsHasMore">
        /// Whether there are more tool dependents beyond the returned preview<br/>
        /// Default Value: false
        /// </param>
        /// <param name="agentsHasMore">
        /// Whether there are more agent dependents beyond the returned preview<br/>
        /// Default Value: false
        /// </param>
        /// <param name="phoneNumbers"></param>
        /// <param name="phoneNumbersHasMore">
        /// Whether there are more phone number dependents beyond the returned preview<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mcpServers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvAIStoredSecretDependencies(
            global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem2> tools,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem> agents,
            global::System.Collections.Generic.IList<global::ElevenLabs.SecretDependencyType> others,
            bool? toolsHasMore,
            bool? agentsHasMore,
            global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>? phoneNumbers,
            bool? phoneNumbersHasMore,
            global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem2>? mcpServers)
        {
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.ToolsHasMore = toolsHasMore;
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.AgentsHasMore = agentsHasMore;
            this.PhoneNumbers = phoneNumbers;
            this.PhoneNumbersHasMore = phoneNumbersHasMore;
            this.McpServers = mcpServers;
            this.Others = others ?? throw new global::System.ArgumentNullException(nameof(others));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIStoredSecretDependencies" /> class.
        /// </summary>
        public ConvAIStoredSecretDependencies()
        {
        }
    }
}