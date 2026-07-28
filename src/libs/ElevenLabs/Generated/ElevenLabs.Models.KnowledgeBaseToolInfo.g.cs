
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseToolInfo
    {
        /// <summary>
        /// Search strategies exposed to the model. Must be non-empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_strategies")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchStrategy>? EnabledStrategies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseToolInfo" /> class.
        /// </summary>
        /// <param name="enabledStrategies">
        /// Search strategies exposed to the model. Must be non-empty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseToolInfo(
            global::System.Collections.Generic.IList<global::ElevenLabs.SearchStrategy>? enabledStrategies)
        {
            this.EnabledStrategies = enabledStrategies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseToolInfo" /> class.
        /// </summary>
        public KnowledgeBaseToolInfo()
        {
        }

    }
}