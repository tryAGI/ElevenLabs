
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Resource types that can be shared in the workspace. The name always need to match the collection names
    /// </summary>
    public enum WorkspaceResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Voice,
        /// <summary>
        /// 
        /// </summary>
        VoiceCollection,
        /// <summary>
        /// 
        /// </summary>
        PronunciationDictionary,
        /// <summary>
        /// 
        /// </summary>
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgents,
        /// <summary>
        /// 
        /// </summary>
        ConvaiKnowledgeBaseDocuments,
        /// <summary>
        /// 
        /// </summary>
        ConvaiTools,
        /// <summary>
        /// 
        /// </summary>
        ConvaiSettings,
        /// <summary>
        /// 
        /// </summary>
        ConvaiSecrets,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceAuthConnections,
        /// <summary>
        /// 
        /// </summary>
        ConvaiPhoneNumbers,
        /// <summary>
        /// 
        /// </summary>
        ConvaiMcpServers,
        /// <summary>
        /// 
        /// </summary>
        ConvaiBatchCalls,
        /// <summary>
        /// 
        /// </summary>
        ConvaiAgentResponseTests,
        /// <summary>
        /// 
        /// </summary>
        ConvaiTestSuiteInvocations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceResourceType value)
        {
            return value switch
            {
                WorkspaceResourceType.Voice => "voice",
                WorkspaceResourceType.VoiceCollection => "voice_collection",
                WorkspaceResourceType.PronunciationDictionary => "pronunciation_dictionary",
                WorkspaceResourceType.Dubbing => "dubbing",
                WorkspaceResourceType.Project => "project",
                WorkspaceResourceType.ConvaiAgents => "convai_agents",
                WorkspaceResourceType.ConvaiKnowledgeBaseDocuments => "convai_knowledge_base_documents",
                WorkspaceResourceType.ConvaiTools => "convai_tools",
                WorkspaceResourceType.ConvaiSettings => "convai_settings",
                WorkspaceResourceType.ConvaiSecrets => "convai_secrets",
                WorkspaceResourceType.WorkspaceAuthConnections => "workspace_auth_connections",
                WorkspaceResourceType.ConvaiPhoneNumbers => "convai_phone_numbers",
                WorkspaceResourceType.ConvaiMcpServers => "convai_mcp_servers",
                WorkspaceResourceType.ConvaiBatchCalls => "convai_batch_calls",
                WorkspaceResourceType.ConvaiAgentResponseTests => "convai_agent_response_tests",
                WorkspaceResourceType.ConvaiTestSuiteInvocations => "convai_test_suite_invocations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceResourceType? ToEnum(string value)
        {
            return value switch
            {
                "voice" => WorkspaceResourceType.Voice,
                "voice_collection" => WorkspaceResourceType.VoiceCollection,
                "pronunciation_dictionary" => WorkspaceResourceType.PronunciationDictionary,
                "dubbing" => WorkspaceResourceType.Dubbing,
                "project" => WorkspaceResourceType.Project,
                "convai_agents" => WorkspaceResourceType.ConvaiAgents,
                "convai_knowledge_base_documents" => WorkspaceResourceType.ConvaiKnowledgeBaseDocuments,
                "convai_tools" => WorkspaceResourceType.ConvaiTools,
                "convai_settings" => WorkspaceResourceType.ConvaiSettings,
                "convai_secrets" => WorkspaceResourceType.ConvaiSecrets,
                "workspace_auth_connections" => WorkspaceResourceType.WorkspaceAuthConnections,
                "convai_phone_numbers" => WorkspaceResourceType.ConvaiPhoneNumbers,
                "convai_mcp_servers" => WorkspaceResourceType.ConvaiMcpServers,
                "convai_batch_calls" => WorkspaceResourceType.ConvaiBatchCalls,
                "convai_agent_response_tests" => WorkspaceResourceType.ConvaiAgentResponseTests,
                "convai_test_suite_invocations" => WorkspaceResourceType.ConvaiTestSuiteInvocations,
                _ => null,
            };
        }
    }
}