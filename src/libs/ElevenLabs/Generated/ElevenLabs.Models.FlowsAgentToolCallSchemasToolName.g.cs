
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlowsAgentToolCallSchemasToolName
    {
        /// <summary>
        /// 
        /// </summary>
        AddEdges,
        /// <summary>
        /// 
        /// </summary>
        AddNode,
        /// <summary>
        /// 
        /// </summary>
        AddStaticAssetNode,
        /// <summary>
        /// 
        /// </summary>
        AutoLayout,
        /// <summary>
        /// 
        /// </summary>
        CheckNodeConnections,
        /// <summary>
        /// 
        /// </summary>
        DescribeMedia,
        /// <summary>
        /// 
        /// </summary>
        GetAvailableVoices,
        /// <summary>
        /// 
        /// </summary>
        GetFlowState,
        /// <summary>
        /// 
        /// </summary>
        GetGenerationStatus,
        /// <summary>
        /// 
        /// </summary>
        GetModelGuide,
        /// <summary>
        /// 
        /// </summary>
        GetModelSchema,
        /// <summary>
        /// 
        /// </summary>
        GetNodeGenerationMetadata,
        /// <summary>
        /// 
        /// </summary>
        GetNodeTypeRegistry,
        /// <summary>
        /// 
        /// </summary>
        InspectNode,
        /// <summary>
        /// 
        /// </summary>
        JudgeGeneration,
        /// <summary>
        /// 
        /// </summary>
        MoveClip,
        /// <summary>
        /// 
        /// </summary>
        MoveNodes,
        /// <summary>
        /// 
        /// </summary>
        RemoveElements,
        /// <summary>
        /// 
        /// </summary>
        ReorderTracks,
        /// <summary>
        /// 
        /// </summary>
        RunNode,
        /// <summary>
        /// 
        /// </summary>
        SetClipProperty,
        /// <summary>
        /// 
        /// </summary>
        SetTrackProperty,
        /// <summary>
        /// 
        /// </summary>
        UpdateNode,
        /// <summary>
        /// 
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlowsAgentToolCallSchemasToolNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlowsAgentToolCallSchemasToolName value)
        {
            return value switch
            {
                FlowsAgentToolCallSchemasToolName.AddEdges => "add_edges",
                FlowsAgentToolCallSchemasToolName.AddNode => "add_node",
                FlowsAgentToolCallSchemasToolName.AddStaticAssetNode => "add_static_asset_node",
                FlowsAgentToolCallSchemasToolName.AutoLayout => "auto_layout",
                FlowsAgentToolCallSchemasToolName.CheckNodeConnections => "check_node_connections",
                FlowsAgentToolCallSchemasToolName.DescribeMedia => "describe_media",
                FlowsAgentToolCallSchemasToolName.GetAvailableVoices => "get_available_voices",
                FlowsAgentToolCallSchemasToolName.GetFlowState => "get_flow_state",
                FlowsAgentToolCallSchemasToolName.GetGenerationStatus => "get_generation_status",
                FlowsAgentToolCallSchemasToolName.GetModelGuide => "get_model_guide",
                FlowsAgentToolCallSchemasToolName.GetModelSchema => "get_model_schema",
                FlowsAgentToolCallSchemasToolName.GetNodeGenerationMetadata => "get_node_generation_metadata",
                FlowsAgentToolCallSchemasToolName.GetNodeTypeRegistry => "get_node_type_registry",
                FlowsAgentToolCallSchemasToolName.InspectNode => "inspect_node",
                FlowsAgentToolCallSchemasToolName.JudgeGeneration => "judge_generation",
                FlowsAgentToolCallSchemasToolName.MoveClip => "move_clip",
                FlowsAgentToolCallSchemasToolName.MoveNodes => "move_nodes",
                FlowsAgentToolCallSchemasToolName.RemoveElements => "remove_elements",
                FlowsAgentToolCallSchemasToolName.ReorderTracks => "reorder_tracks",
                FlowsAgentToolCallSchemasToolName.RunNode => "run_node",
                FlowsAgentToolCallSchemasToolName.SetClipProperty => "set_clip_property",
                FlowsAgentToolCallSchemasToolName.SetTrackProperty => "set_track_property",
                FlowsAgentToolCallSchemasToolName.UpdateNode => "update_node",
                FlowsAgentToolCallSchemasToolName.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlowsAgentToolCallSchemasToolName? ToEnum(string value)
        {
            return value switch
            {
                "add_edges" => FlowsAgentToolCallSchemasToolName.AddEdges,
                "add_node" => FlowsAgentToolCallSchemasToolName.AddNode,
                "add_static_asset_node" => FlowsAgentToolCallSchemasToolName.AddStaticAssetNode,
                "auto_layout" => FlowsAgentToolCallSchemasToolName.AutoLayout,
                "check_node_connections" => FlowsAgentToolCallSchemasToolName.CheckNodeConnections,
                "describe_media" => FlowsAgentToolCallSchemasToolName.DescribeMedia,
                "get_available_voices" => FlowsAgentToolCallSchemasToolName.GetAvailableVoices,
                "get_flow_state" => FlowsAgentToolCallSchemasToolName.GetFlowState,
                "get_generation_status" => FlowsAgentToolCallSchemasToolName.GetGenerationStatus,
                "get_model_guide" => FlowsAgentToolCallSchemasToolName.GetModelGuide,
                "get_model_schema" => FlowsAgentToolCallSchemasToolName.GetModelSchema,
                "get_node_generation_metadata" => FlowsAgentToolCallSchemasToolName.GetNodeGenerationMetadata,
                "get_node_type_registry" => FlowsAgentToolCallSchemasToolName.GetNodeTypeRegistry,
                "inspect_node" => FlowsAgentToolCallSchemasToolName.InspectNode,
                "judge_generation" => FlowsAgentToolCallSchemasToolName.JudgeGeneration,
                "move_clip" => FlowsAgentToolCallSchemasToolName.MoveClip,
                "move_nodes" => FlowsAgentToolCallSchemasToolName.MoveNodes,
                "remove_elements" => FlowsAgentToolCallSchemasToolName.RemoveElements,
                "reorder_tracks" => FlowsAgentToolCallSchemasToolName.ReorderTracks,
                "run_node" => FlowsAgentToolCallSchemasToolName.RunNode,
                "set_clip_property" => FlowsAgentToolCallSchemasToolName.SetClipProperty,
                "set_track_property" => FlowsAgentToolCallSchemasToolName.SetTrackProperty,
                "update_node" => FlowsAgentToolCallSchemasToolName.UpdateNode,
                "wait" => FlowsAgentToolCallSchemasToolName.Wait,
                _ => null,
            };
        }
    }
}