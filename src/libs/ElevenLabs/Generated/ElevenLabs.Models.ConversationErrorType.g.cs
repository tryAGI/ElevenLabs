
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Stored in conversation history. Never exposed to customers directly.
    /// </summary>
    public enum ConversationErrorType
    {
        /// <summary>
        ///
        /// </summary>
        AgentConfigurationError,
        /// <summary>
        ///
        /// </summary>
        BlockedByUser,
        /// <summary>
        ///
        /// </summary>
        CallInitializationError,
        /// <summary>
        ///
        /// </summary>
        CallRejected,
        /// <summary>
        ///
        /// </summary>
        ClientDisconnected,
        /// <summary>
        ///
        /// </summary>
        DependencyError,
        /// <summary>
        ///
        /// </summary>
        EntitlementExceeded,
        /// <summary>
        ///
        /// </summary>
        GuardrailTriggered,
        /// <summary>
        ///
        /// </summary>
        IntegrationError,
        /// <summary>
        ///
        /// </summary>
        InternalError,
        /// <summary>
        ///
        /// </summary>
        InvalidClientRequest,
        /// <summary>
        ///
        /// </summary>
        LineBusy,
        /// <summary>
        ///
        /// </summary>
        LlmError,
        /// <summary>
        ///
        /// </summary>
        MaxDurationExceeded,
        /// <summary>
        ///
        /// </summary>
        NoAnswer,
        /// <summary>
        ///
        /// </summary>
        PermissionError,
        /// <summary>
        ///
        /// </summary>
        PostProcessingError,
        /// <summary>
        ///
        /// </summary>
        SafetyViolation,
        /// <summary>
        ///
        /// </summary>
        SpeechError,
        /// <summary>
        ///
        /// </summary>
        ToolError,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationErrorType value)
        {
            return value switch
            {
                ConversationErrorType.AgentConfigurationError => "agent_configuration_error",
                ConversationErrorType.BlockedByUser => "blocked_by_user",
                ConversationErrorType.CallInitializationError => "call_initialization_error",
                ConversationErrorType.CallRejected => "call_rejected",
                ConversationErrorType.ClientDisconnected => "client_disconnected",
                ConversationErrorType.DependencyError => "dependency_error",
                ConversationErrorType.EntitlementExceeded => "entitlement_exceeded",
                ConversationErrorType.GuardrailTriggered => "guardrail_triggered",
                ConversationErrorType.IntegrationError => "integration_error",
                ConversationErrorType.InternalError => "internal_error",
                ConversationErrorType.InvalidClientRequest => "invalid_client_request",
                ConversationErrorType.LineBusy => "line_busy",
                ConversationErrorType.LlmError => "llm_error",
                ConversationErrorType.MaxDurationExceeded => "max_duration_exceeded",
                ConversationErrorType.NoAnswer => "no_answer",
                ConversationErrorType.PermissionError => "permission_error",
                ConversationErrorType.PostProcessingError => "post_processing_error",
                ConversationErrorType.SafetyViolation => "safety_violation",
                ConversationErrorType.SpeechError => "speech_error",
                ConversationErrorType.ToolError => "tool_error",
                ConversationErrorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationErrorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_configuration_error" => ConversationErrorType.AgentConfigurationError,
                "blocked_by_user" => ConversationErrorType.BlockedByUser,
                "call_initialization_error" => ConversationErrorType.CallInitializationError,
                "call_rejected" => ConversationErrorType.CallRejected,
                "client_disconnected" => ConversationErrorType.ClientDisconnected,
                "dependency_error" => ConversationErrorType.DependencyError,
                "entitlement_exceeded" => ConversationErrorType.EntitlementExceeded,
                "guardrail_triggered" => ConversationErrorType.GuardrailTriggered,
                "integration_error" => ConversationErrorType.IntegrationError,
                "internal_error" => ConversationErrorType.InternalError,
                "invalid_client_request" => ConversationErrorType.InvalidClientRequest,
                "line_busy" => ConversationErrorType.LineBusy,
                "llm_error" => ConversationErrorType.LlmError,
                "max_duration_exceeded" => ConversationErrorType.MaxDurationExceeded,
                "no_answer" => ConversationErrorType.NoAnswer,
                "permission_error" => ConversationErrorType.PermissionError,
                "post_processing_error" => ConversationErrorType.PostProcessingError,
                "safety_violation" => ConversationErrorType.SafetyViolation,
                "speech_error" => ConversationErrorType.SpeechError,
                "tool_error" => ConversationErrorType.ToolError,
                "unknown" => ConversationErrorType.Unknown,
                _ => null,
            };
        }
    }
}