
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowFeaturesUsageCommonModel
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_node")]
        public global::ElevenLabs.FeatureStatusCommonModel? ToolNode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowFeaturesUsageCommonModel" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
        /// <param name="toolNode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowFeaturesUsageCommonModel(
            bool? enabled,
            global::ElevenLabs.FeatureStatusCommonModel? toolNode)
        {
            this.Enabled = enabled;
            this.ToolNode = toolNode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowFeaturesUsageCommonModel" /> class.
        /// </summary>
        public WorkflowFeaturesUsageCommonModel()
        {
        }
    }
}