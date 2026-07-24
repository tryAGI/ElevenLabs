
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookUsageType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentQaEvaluations,
        /// <summary>
        /// 
        /// </summary>
        ConvAIAgentSettings,
        /// <summary>
        /// 
        /// </summary>
        ConvAIAlerting,
        /// <summary>
        /// 
        /// </summary>
        ConvAISettings,
        /// <summary>
        /// 
        /// </summary>
        Flows,
        /// <summary>
        /// 
        /// </summary>
        SpeechToText,
        /// <summary>
        /// 
        /// </summary>
        VoiceLibraryRemovalNotices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookUsageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookUsageType value)
        {
            return value switch
            {
                WebhookUsageType.AgentQaEvaluations => "Agent QA Evaluations",
                WebhookUsageType.ConvAIAgentSettings => "ConvAI Agent Settings",
                WebhookUsageType.ConvAIAlerting => "ConvAI Alerting",
                WebhookUsageType.ConvAISettings => "ConvAI Settings",
                WebhookUsageType.Flows => "Flows",
                WebhookUsageType.SpeechToText => "Speech to Text",
                WebhookUsageType.VoiceLibraryRemovalNotices => "Voice Library Removal Notices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookUsageType? ToEnum(string value)
        {
            return value switch
            {
                "Agent QA Evaluations" => WebhookUsageType.AgentQaEvaluations,
                "ConvAI Agent Settings" => WebhookUsageType.ConvAIAgentSettings,
                "ConvAI Alerting" => WebhookUsageType.ConvAIAlerting,
                "ConvAI Settings" => WebhookUsageType.ConvAISettings,
                "Flows" => WebhookUsageType.Flows,
                "Speech to Text" => WebhookUsageType.SpeechToText,
                "Voice Library Removal Notices" => WebhookUsageType.VoiceLibraryRemovalNotices,
                _ => null,
            };
        }
    }
}