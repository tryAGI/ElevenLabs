
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
        DocumentationGap,
        /// <summary>
        ///
        /// </summary>
        IncorrectInformation,
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
        PlatformBug,
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
        /// <summary>
        ///
        /// </summary>
        WrongAction,
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
                AgentConversationTicketIssueType.DocumentationGap => "documentation_gap",
                AgentConversationTicketIssueType.IncorrectInformation => "incorrect_information",
                AgentConversationTicketIssueType.KnowledgeGap => "knowledge_gap",
                AgentConversationTicketIssueType.MissingTool => "missing_tool",
                AgentConversationTicketIssueType.PlatformBug => "platform_bug",
                AgentConversationTicketIssueType.ProductFeedback => "product_feedback",
                AgentConversationTicketIssueType.ToolIssue => "tool_issue",
                AgentConversationTicketIssueType.UnnecessaryEscalation => "unnecessary_escalation",
                AgentConversationTicketIssueType.WrongAction => "wrong_action",
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
                "documentation_gap" => AgentConversationTicketIssueType.DocumentationGap,
                "incorrect_information" => AgentConversationTicketIssueType.IncorrectInformation,
                "knowledge_gap" => AgentConversationTicketIssueType.KnowledgeGap,
                "missing_tool" => AgentConversationTicketIssueType.MissingTool,
                "platform_bug" => AgentConversationTicketIssueType.PlatformBug,
                "product_feedback" => AgentConversationTicketIssueType.ProductFeedback,
                "tool_issue" => AgentConversationTicketIssueType.ToolIssue,
                "unnecessary_escalation" => AgentConversationTicketIssueType.UnnecessaryEscalation,
                "wrong_action" => AgentConversationTicketIssueType.WrongAction,
                _ => null,
            };
        }
    }
}