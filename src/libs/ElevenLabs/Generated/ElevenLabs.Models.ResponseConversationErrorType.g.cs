
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// User-facing error types exposed on the public API.
    /// </summary>
    public enum ResponseConversationErrorType
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
        SystemError,
        /// <summary>
        ///
        /// </summary>
        ToolError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseConversationErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseConversationErrorType value)
        {
            return value switch
            {
                ResponseConversationErrorType.AgentConfigurationError => "agent_configuration_error",
                ResponseConversationErrorType.BlockedByUser => "blocked_by_user",
                ResponseConversationErrorType.CallInitializationError => "call_initialization_error",
                ResponseConversationErrorType.CallRejected => "call_rejected",
                ResponseConversationErrorType.ClientDisconnected => "client_disconnected",
                ResponseConversationErrorType.EntitlementExceeded => "entitlement_exceeded",
                ResponseConversationErrorType.GuardrailTriggered => "guardrail_triggered",
                ResponseConversationErrorType.IntegrationError => "integration_error",
                ResponseConversationErrorType.InvalidClientRequest => "invalid_client_request",
                ResponseConversationErrorType.LineBusy => "line_busy",
                ResponseConversationErrorType.LlmError => "llm_error",
                ResponseConversationErrorType.MaxDurationExceeded => "max_duration_exceeded",
                ResponseConversationErrorType.NoAnswer => "no_answer",
                ResponseConversationErrorType.PermissionError => "permission_error",
                ResponseConversationErrorType.PostProcessingError => "post_processing_error",
                ResponseConversationErrorType.SafetyViolation => "safety_violation",
                ResponseConversationErrorType.SpeechError => "speech_error",
                ResponseConversationErrorType.SystemError => "system_error",
                ResponseConversationErrorType.ToolError => "tool_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseConversationErrorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_configuration_error" => ResponseConversationErrorType.AgentConfigurationError,
                "blocked_by_user" => ResponseConversationErrorType.BlockedByUser,
                "call_initialization_error" => ResponseConversationErrorType.CallInitializationError,
                "call_rejected" => ResponseConversationErrorType.CallRejected,
                "client_disconnected" => ResponseConversationErrorType.ClientDisconnected,
                "entitlement_exceeded" => ResponseConversationErrorType.EntitlementExceeded,
                "guardrail_triggered" => ResponseConversationErrorType.GuardrailTriggered,
                "integration_error" => ResponseConversationErrorType.IntegrationError,
                "invalid_client_request" => ResponseConversationErrorType.InvalidClientRequest,
                "line_busy" => ResponseConversationErrorType.LineBusy,
                "llm_error" => ResponseConversationErrorType.LlmError,
                "max_duration_exceeded" => ResponseConversationErrorType.MaxDurationExceeded,
                "no_answer" => ResponseConversationErrorType.NoAnswer,
                "permission_error" => ResponseConversationErrorType.PermissionError,
                "post_processing_error" => ResponseConversationErrorType.PostProcessingError,
                "safety_violation" => ResponseConversationErrorType.SafetyViolation,
                "speech_error" => ResponseConversationErrorType.SpeechError,
                "system_error" => ResponseConversationErrorType.SystemError,
                "tool_error" => ResponseConversationErrorType.ToolError,
                _ => null,
            };
        }
    }
}