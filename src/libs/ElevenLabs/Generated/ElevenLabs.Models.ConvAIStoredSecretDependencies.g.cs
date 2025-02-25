
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
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem> Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem> Agents { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvAIStoredSecretDependencies(
            global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem> tools,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem> agents,
            global::System.Collections.Generic.IList<global::ElevenLabs.SecretDependencyType> others)
        {
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
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