
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType
    {
        /// <summary>
        ///
        /// </summary>
        Dummy,
        /// <summary>
        ///
        /// </summary>
        EndCallSuccess,
        /// <summary>
        ///
        /// </summary>
        EndProcedureError,
        /// <summary>
        ///
        /// </summary>
        EndProcedureSuccess,
        /// <summary>
        ///
        /// </summary>
        KnowledgeBaseRagSuccess,
        /// <summary>
        ///
        /// </summary>
        KnowledgeBaseSuccess,
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
        StartProcedureError,
        /// <summary>
        ///
        /// </summary>
        StartProcedureSuccess,
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
        TransferToNumberExotelSuccess,
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
    public static class ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.Dummy => "dummy",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.EndCallSuccess => "end_call_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.EndProcedureError => "end_procedure_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.EndProcedureSuccess => "end_procedure_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.KnowledgeBaseRagSuccess => "knowledge_base_rag_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.KnowledgeBaseSuccess => "knowledge_base_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.LanguageDetectionSuccess => "language_detection_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.PlayDtmfError => "play_dtmf_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.PlayDtmfSuccess => "play_dtmf_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.SkipTurnSuccess => "skip_turn_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.StartProcedureError => "start_procedure_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.StartProcedureSuccess => "start_procedure_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TestingToolResult => "testing_tool_result",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToAgentError => "transfer_to_agent_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToAgentSuccess => "transfer_to_agent_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberError => "transfer_to_number_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberExotelSuccess => "transfer_to_number_exotel_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberSipSuccess => "transfer_to_number_sip_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberTwilioSuccess => "transfer_to_number_twilio_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.VoicemailDetectionSuccess => "voicemail_detection_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType? ToEnum(string value)
        {
            return value switch
            {
                "dummy" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.Dummy,
                "end_call_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.EndCallSuccess,
                "end_procedure_error" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.EndProcedureError,
                "end_procedure_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.EndProcedureSuccess,
                "knowledge_base_rag_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.KnowledgeBaseRagSuccess,
                "knowledge_base_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.KnowledgeBaseSuccess,
                "language_detection_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.LanguageDetectionSuccess,
                "play_dtmf_error" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.PlayDtmfError,
                "play_dtmf_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.PlayDtmfSuccess,
                "skip_turn_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.SkipTurnSuccess,
                "start_procedure_error" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.StartProcedureError,
                "start_procedure_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.StartProcedureSuccess,
                "testing_tool_result" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TestingToolResult,
                "transfer_to_agent_error" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToAgentError,
                "transfer_to_agent_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToAgentSuccess,
                "transfer_to_number_error" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberError,
                "transfer_to_number_exotel_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberExotelSuccess,
                "transfer_to_number_sip_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberSipSuccess,
                "transfer_to_number_twilio_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberTwilioSuccess,
                "voicemail_detection_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.VoicemailDetectionSuccess,
                _ => null,
            };
        }
    }
}