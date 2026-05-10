
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standalone_agent_node")]
        public global::ElevenLabs.FeatureStatusCommonModel? StandaloneAgentNode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_node")]
        public global::ElevenLabs.FeatureStatusCommonModel? PhoneNumberNode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_node")]
        public global::ElevenLabs.FeatureStatusCommonModel? EndNode { get; set; }

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
        /// <param name="standaloneAgentNode"></param>
        /// <param name="phoneNumberNode"></param>
        /// <param name="endNode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowFeaturesUsageCommonModel(
            bool? enabled,
            global::ElevenLabs.FeatureStatusCommonModel? toolNode,
            global::ElevenLabs.FeatureStatusCommonModel? standaloneAgentNode,
            global::ElevenLabs.FeatureStatusCommonModel? phoneNumberNode,
            global::ElevenLabs.FeatureStatusCommonModel? endNode)
        {
            this.Enabled = enabled;
            this.ToolNode = toolNode;
            this.StandaloneAgentNode = standaloneAgentNode;
            this.PhoneNumberNode = phoneNumberNode;
            this.EndNode = endNode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowFeaturesUsageCommonModel" /> class.
        /// </summary>
        public WorkflowFeaturesUsageCommonModel()
        {
        }

    }
}