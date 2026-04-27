
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Container that anchors all flows-agent tool input/output shapes in OpenAPI.
    /// </summary>
    public sealed partial class FlowsAgentToolCallSchemas
    {
        /// <summary>
        /// Every server-tool name the flows agent can invoke.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_names")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.FlowsAgentToolCallSchemasToolName>? ToolNames { get; set; }

        /// <summary>
        /// Sample list — populated only by the introspection endpoint. The shape is what matters: every member of the union becomes a TypeScript type the frontend can use to render typed tool approval details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_inputs")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.AddNodeInput, global::ElevenLabs.AddStaticAssetNodeInput, global::ElevenLabs.AddEdgesInput, global::ElevenLabs.RemoveElementsInput, global::ElevenLabs.UpdateNodeInput, global::ElevenLabs.AutoLayoutInput, global::ElevenLabs.MoveNodesInput, global::ElevenLabs.SetTrackPropertyInput, global::ElevenLabs.SetClipPropertyInput, global::ElevenLabs.MoveClipInput, global::ElevenLabs.ReorderTracksInput, global::ElevenLabs.DescribeMediaInput, global::ElevenLabs.JudgeGenerationInput, global::ElevenLabs.NodeIdInput, global::ElevenLabs.GetModelGuideInput, global::ElevenLabs.PreviewNodeModelInput, global::ElevenLabs.GetGenerationStatusInput, global::ElevenLabs.GetAvailableVoicesInput, global::ElevenLabs.WaitInput>>? ToolInputs { get; set; }

        /// <summary>
        /// Sample list — populated only by the introspection endpoint. The shape anchors every typed tool result in OpenAPI so the frontend can narrow AgentToolResult.output without hand-writing types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_outputs")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.MutationResult, global::ElevenLabs.FlowStateResult, global::ElevenLabs.NodeConnectionsResult, global::ElevenLabs.NodeGenerationMetadataResult, global::ElevenLabs.GenerationStatusResult>>? ToolOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowsAgentToolCallSchemas" /> class.
        /// </summary>
        /// <param name="toolNames">
        /// Every server-tool name the flows agent can invoke.
        /// </param>
        /// <param name="toolInputs">
        /// Sample list — populated only by the introspection endpoint. The shape is what matters: every member of the union becomes a TypeScript type the frontend can use to render typed tool approval details.
        /// </param>
        /// <param name="toolOutputs">
        /// Sample list — populated only by the introspection endpoint. The shape anchors every typed tool result in OpenAPI so the frontend can narrow AgentToolResult.output without hand-writing types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlowsAgentToolCallSchemas(
            global::System.Collections.Generic.IList<global::ElevenLabs.FlowsAgentToolCallSchemasToolName>? toolNames,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.AddNodeInput, global::ElevenLabs.AddStaticAssetNodeInput, global::ElevenLabs.AddEdgesInput, global::ElevenLabs.RemoveElementsInput, global::ElevenLabs.UpdateNodeInput, global::ElevenLabs.AutoLayoutInput, global::ElevenLabs.MoveNodesInput, global::ElevenLabs.SetTrackPropertyInput, global::ElevenLabs.SetClipPropertyInput, global::ElevenLabs.MoveClipInput, global::ElevenLabs.ReorderTracksInput, global::ElevenLabs.DescribeMediaInput, global::ElevenLabs.JudgeGenerationInput, global::ElevenLabs.NodeIdInput, global::ElevenLabs.GetModelGuideInput, global::ElevenLabs.PreviewNodeModelInput, global::ElevenLabs.GetGenerationStatusInput, global::ElevenLabs.GetAvailableVoicesInput, global::ElevenLabs.WaitInput>>? toolInputs,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.MutationResult, global::ElevenLabs.FlowStateResult, global::ElevenLabs.NodeConnectionsResult, global::ElevenLabs.NodeGenerationMetadataResult, global::ElevenLabs.GenerationStatusResult>>? toolOutputs)
        {
            this.ToolNames = toolNames;
            this.ToolInputs = toolInputs;
            this.ToolOutputs = toolOutputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowsAgentToolCallSchemas" /> class.
        /// </summary>
        public FlowsAgentToolCallSchemas()
        {
        }
    }
}