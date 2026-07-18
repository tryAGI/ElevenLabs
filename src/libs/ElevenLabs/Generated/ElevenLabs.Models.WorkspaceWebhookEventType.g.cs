
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkspaceWebhookEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentQa,
        /// <summary>
        /// 
        /// </summary>
        SpeechToText,
        /// <summary>
        /// 
        /// </summary>
        VoiceLibraryRemovalNotice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceWebhookEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceWebhookEventType value)
        {
            return value switch
            {
                WorkspaceWebhookEventType.AgentQa => "agent_qa",
                WorkspaceWebhookEventType.SpeechToText => "speech_to_text",
                WorkspaceWebhookEventType.VoiceLibraryRemovalNotice => "voice_library_removal_notice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceWebhookEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent_qa" => WorkspaceWebhookEventType.AgentQa,
                "speech_to_text" => WorkspaceWebhookEventType.SpeechToText,
                "voice_library_removal_notice" => WorkspaceWebhookEventType.VoiceLibraryRemovalNotice,
                _ => null,
            };
        }
    }
}