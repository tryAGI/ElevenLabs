
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Defines the approval model for an MCP tool
    /// </summary>
    public enum MCPApprovalRequiredModel
    {
        /// <summary>
        /// 
        /// </summary>
        UserApprovalAlwaysGiven,
        /// <summary>
        /// 
        /// </summary>
        UserApprovalNeverGiven,
        /// <summary>
        /// 
        /// </summary>
        UserApprovalRequiredPerTool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPApprovalRequiredModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPApprovalRequiredModel value)
        {
            return value switch
            {
                MCPApprovalRequiredModel.UserApprovalAlwaysGiven => "user_approval_always_given",
                MCPApprovalRequiredModel.UserApprovalNeverGiven => "user_approval_never_given",
                MCPApprovalRequiredModel.UserApprovalRequiredPerTool => "user_approval_required_per_tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPApprovalRequiredModel? ToEnum(string value)
        {
            return value switch
            {
                "user_approval_always_given" => MCPApprovalRequiredModel.UserApprovalAlwaysGiven,
                "user_approval_never_given" => MCPApprovalRequiredModel.UserApprovalNeverGiven,
                "user_approval_required_per_tool" => MCPApprovalRequiredModel.UserApprovalRequiredPerTool,
                _ => null,
            };
        }
    }
}