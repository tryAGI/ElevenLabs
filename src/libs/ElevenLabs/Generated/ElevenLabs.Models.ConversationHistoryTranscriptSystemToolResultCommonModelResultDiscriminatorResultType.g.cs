
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCallSuccess,
        /// <summary>
        /// 
        /// </summary>
        LanguageDetectionSuccess,
        /// <summary>
        /// 
        /// </summary>
        PlayDtmfError,
        /// <summary>
        /// 
        /// </summary>
        PlayDtmfSuccess,
        /// <summary>
        /// 
        /// </summary>
        SkipTurnSuccess,
        /// <summary>
        /// 
        /// </summary>
        TestingToolResult,
        /// <summary>
        /// 
        /// </summary>
        TransferToAgentError,
        /// <summary>
        /// 
        /// </summary>
        TransferToAgentSuccess,
        /// <summary>
        /// 
        /// </summary>
        TransferToNumberError,
        /// <summary>
        /// 
        /// </summary>
        TransferToNumberSipSuccess,
        /// <summary>
        /// 
        /// </summary>
        TransferToNumberTwilioSuccess,
        /// <summary>
        /// 
        /// </summary>
        VoicemailDetectionSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.EndCallSuccess => "end_call_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.LanguageDetectionSuccess => "language_detection_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.PlayDtmfError => "play_dtmf_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.PlayDtmfSuccess => "play_dtmf_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.SkipTurnSuccess => "skip_turn_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TestingToolResult => "testing_tool_result",
                ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToAgentError => "transfer_to_agent_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToAgentSuccess => "transfer_to_agent_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToNumberError => "transfer_to_number_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToNumberSipSuccess => "transfer_to_number_sip_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToNumberTwilioSuccess => "transfer_to_number_twilio_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.VoicemailDetectionSuccess => "voicemail_detection_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType? ToEnum(string value)
        {
            return value switch
            {
                "end_call_success" => ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.EndCallSuccess,
                "language_detection_success" => ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.LanguageDetectionSuccess,
                "play_dtmf_error" => ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.PlayDtmfError,
                "play_dtmf_success" => ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.PlayDtmfSuccess,
                "skip_turn_success" => ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.SkipTurnSuccess,
                "testing_tool_result" => ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TestingToolResult,
                "transfer_to_agent_error" => ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToAgentError,
                "transfer_to_agent_success" => ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToAgentSuccess,
                "transfer_to_number_error" => ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToNumberError,
                "transfer_to_number_sip_success" => ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToNumberSipSuccess,
                "transfer_to_number_twilio_success" => ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToNumberTwilioSuccess,
                "voicemail_detection_success" => ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.VoicemailDetectionSuccess,
                _ => null,
            };
        }
    }
}