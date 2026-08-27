
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KnowledgeBaseToolConfig
    {
        /// <summary>
        /// Default Value: knowledge_base
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        public string? SystemToolType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_strategies")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchStrategy>? EnabledStrategies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: knowledge_base
        /// </param>
        /// <param name="enabledStrategies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseToolConfig(
            string? systemToolType,
            global::System.Collections.Generic.IList<global::ElevenLabs.SearchStrategy>? enabledStrategies)
        {
            this.SystemToolType = systemToolType;
            this.EnabledStrategies = enabledStrategies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseToolConfig" /> class.
        /// </summary>
        public KnowledgeBaseToolConfig()
        {
        }

    }
}