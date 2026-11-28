
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentWorkflowResponseModelNodesDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        End,
        /// <summary>
        ///
        /// </summary>
        OverrideAgent,
        /// <summary>
        ///
        /// </summary>
        PhoneNumber,
        /// <summary>
        ///
        /// </summary>
        Say,
        /// <summary>
        ///
        /// </summary>
        StandaloneAgent,
        /// <summary>
        ///
        /// </summary>
        Start,
        /// <summary>
        ///
        /// </summary>
        StartProcedure,
        /// <summary>
        ///
        /// </summary>
        Tool,
        /// <summary>
        ///
        /// </summary>
        UpdateState,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentWorkflowResponseModelNodesDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentWorkflowResponseModelNodesDiscriminatorType value)
        {
            return value switch
            {
                AgentWorkflowResponseModelNodesDiscriminatorType.End => "end",
                AgentWorkflowResponseModelNodesDiscriminatorType.OverrideAgent => "override_agent",
                AgentWorkflowResponseModelNodesDiscriminatorType.PhoneNumber => "phone_number",
                AgentWorkflowResponseModelNodesDiscriminatorType.Say => "say",
                AgentWorkflowResponseModelNodesDiscriminatorType.StandaloneAgent => "standalone_agent",
                AgentWorkflowResponseModelNodesDiscriminatorType.Start => "start",
                AgentWorkflowResponseModelNodesDiscriminatorType.StartProcedure => "start_procedure",
                AgentWorkflowResponseModelNodesDiscriminatorType.Tool => "tool",
                AgentWorkflowResponseModelNodesDiscriminatorType.UpdateState => "update_state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentWorkflowResponseModelNodesDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "end" => AgentWorkflowResponseModelNodesDiscriminatorType.End,
                "override_agent" => AgentWorkflowResponseModelNodesDiscriminatorType.OverrideAgent,
                "phone_number" => AgentWorkflowResponseModelNodesDiscriminatorType.PhoneNumber,
                "say" => AgentWorkflowResponseModelNodesDiscriminatorType.Say,
                "standalone_agent" => AgentWorkflowResponseModelNodesDiscriminatorType.StandaloneAgent,
                "start" => AgentWorkflowResponseModelNodesDiscriminatorType.Start,
                "start_procedure" => AgentWorkflowResponseModelNodesDiscriminatorType.StartProcedure,
                "tool" => AgentWorkflowResponseModelNodesDiscriminatorType.Tool,
                "update_state" => AgentWorkflowResponseModelNodesDiscriminatorType.UpdateState,
                _ => null,
            };
        }
    }
}