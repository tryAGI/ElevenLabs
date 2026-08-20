
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentConversationTicketIssueType
    {
        /// <summary>
        /// 
        /// </summary>
        KnowledgeGap,
        /// <summary>
        /// 
        /// </summary>
        MissingTool,
        /// <summary>
        /// 
        /// </summary>
        ProductFeedback,
        /// <summary>
        /// 
        /// </summary>
        ToolIssue,
        /// <summary>
        /// 
        /// </summary>
        UnnecessaryEscalation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConversationTicketIssueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConversationTicketIssueType value)
        {
            return value switch
            {
                AgentConversationTicketIssueType.KnowledgeGap => "knowledge_gap",
                AgentConversationTicketIssueType.MissingTool => "missing_tool",
                AgentConversationTicketIssueType.ProductFeedback => "product_feedback",
                AgentConversationTicketIssueType.ToolIssue => "tool_issue",
                AgentConversationTicketIssueType.UnnecessaryEscalation => "unnecessary_escalation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConversationTicketIssueType? ToEnum(string value)
        {
            return value switch
            {
                "knowledge_gap" => AgentConversationTicketIssueType.KnowledgeGap,
                "missing_tool" => AgentConversationTicketIssueType.MissingTool,
                "product_feedback" => AgentConversationTicketIssueType.ProductFeedback,
                "tool_issue" => AgentConversationTicketIssueType.ToolIssue,
                "unnecessary_escalation" => AgentConversationTicketIssueType.UnnecessaryEscalation,
                _ => null,
            };
        }
    }
}