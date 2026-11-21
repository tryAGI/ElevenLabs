
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookTypes
    {
        /// <summary>
        ///
        /// </summary>
        AgentQaEvaluationCompleted,
        /// <summary>
        ///
        /// </summary>
        AnsweringMachineDetection,
        /// <summary>
        ///
        /// </summary>
        CallInitiationFailure,
        /// <summary>
        ///
        /// </summary>
        ChapterConversionStatus,
        /// <summary>
        ///
        /// </summary>
        ConvaiAlertingNotification,
        /// <summary>
        ///
        /// </summary>
        ConversationInitiationClientData,
        /// <summary>
        ///
        /// </summary>
        DubbingLanguageCompleted,
        /// <summary>
        ///
        /// </summary>
        DubbingLanguageFailed,
        /// <summary>
        ///
        /// </summary>
        DubbingProjectFailed,
        /// <summary>
        ///
        /// </summary>
        DubbingProjectReady,
        /// <summary>
        ///
        /// </summary>
        FlowsGeneration,
        /// <summary>
        ///
        /// </summary>
        FlowsTemplateRun,
        /// <summary>
        ///
        /// </summary>
        PostCallAnalysis,
        /// <summary>
        ///
        /// </summary>
        PostCallAudio,
        /// <summary>
        ///
        /// </summary>
        PostCallTranscription,
        /// <summary>
        ///
        /// </summary>
        PostCallTranscriptionOtel,
        /// <summary>
        ///
        /// </summary>
        PostCallUnredactedAudio,
        /// <summary>
        ///
        /// </summary>
        PostCallUnredactedTranscription,
        /// <summary>
        ///
        /// </summary>
        PostCallUnredactedTranscriptionOtel,
        /// <summary>
        ///
        /// </summary>
        ProjectConversionStatus,
        /// <summary>
        ///
        /// </summary>
        SpeechToTextBatch,
        /// <summary>
        ///
        /// </summary>
        SpeechToTextTranscription,
        /// <summary>
        ///
        /// </summary>
        SupportTicketMessageAdded,
        /// <summary>
        ///
        /// </summary>
        VoiceRemovalNotice,
        /// <summary>
        ///
        /// </summary>
        VoiceRemovalNoticeWithdrawn,
        /// <summary>
        ///
        /// </summary>
        VoiceRemoved,
        /// <summary>
        ///
        /// </summary>
        WebhookError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTypes value)
        {
            return value switch
            {
                WebhookTypes.AgentQaEvaluationCompleted => "agent_qa_evaluation_completed",
                WebhookTypes.AnsweringMachineDetection => "answering_machine_detection",
                WebhookTypes.CallInitiationFailure => "call_initiation_failure",
                WebhookTypes.ChapterConversionStatus => "chapter_conversion_status",
                WebhookTypes.ConvaiAlertingNotification => "convai_alerting_notification",
                WebhookTypes.ConversationInitiationClientData => "conversation_initiation_client_data",
                WebhookTypes.DubbingLanguageCompleted => "dubbing_language_completed",
                WebhookTypes.DubbingLanguageFailed => "dubbing_language_failed",
                WebhookTypes.DubbingProjectFailed => "dubbing_project_failed",
                WebhookTypes.DubbingProjectReady => "dubbing_project_ready",
                WebhookTypes.FlowsGeneration => "flows_generation",
                WebhookTypes.FlowsTemplateRun => "flows_template_run",
                WebhookTypes.PostCallAnalysis => "post_call_analysis",
                WebhookTypes.PostCallAudio => "post_call_audio",
                WebhookTypes.PostCallTranscription => "post_call_transcription",
                WebhookTypes.PostCallTranscriptionOtel => "post_call_transcription_otel",
                WebhookTypes.PostCallUnredactedAudio => "post_call_unredacted_audio",
                WebhookTypes.PostCallUnredactedTranscription => "post_call_unredacted_transcription",
                WebhookTypes.PostCallUnredactedTranscriptionOtel => "post_call_unredacted_transcription_otel",
                WebhookTypes.ProjectConversionStatus => "project_conversion_status",
                WebhookTypes.SpeechToTextBatch => "speech_to_text_batch",
                WebhookTypes.SpeechToTextTranscription => "speech_to_text_transcription",
                WebhookTypes.SupportTicketMessageAdded => "support_ticket_message_added",
                WebhookTypes.VoiceRemovalNotice => "voice_removal_notice",
                WebhookTypes.VoiceRemovalNoticeWithdrawn => "voice_removal_notice_withdrawn",
                WebhookTypes.VoiceRemoved => "voice_removed",
                WebhookTypes.WebhookError => "webhook_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTypes? ToEnum(string value)
        {
            return value switch
            {
                "agent_qa_evaluation_completed" => WebhookTypes.AgentQaEvaluationCompleted,
                "answering_machine_detection" => WebhookTypes.AnsweringMachineDetection,
                "call_initiation_failure" => WebhookTypes.CallInitiationFailure,
                "chapter_conversion_status" => WebhookTypes.ChapterConversionStatus,
                "convai_alerting_notification" => WebhookTypes.ConvaiAlertingNotification,
                "conversation_initiation_client_data" => WebhookTypes.ConversationInitiationClientData,
                "dubbing_language_completed" => WebhookTypes.DubbingLanguageCompleted,
                "dubbing_language_failed" => WebhookTypes.DubbingLanguageFailed,
                "dubbing_project_failed" => WebhookTypes.DubbingProjectFailed,
                "dubbing_project_ready" => WebhookTypes.DubbingProjectReady,
                "flows_generation" => WebhookTypes.FlowsGeneration,
                "flows_template_run" => WebhookTypes.FlowsTemplateRun,
                "post_call_analysis" => WebhookTypes.PostCallAnalysis,
                "post_call_audio" => WebhookTypes.PostCallAudio,
                "post_call_transcription" => WebhookTypes.PostCallTranscription,
                "post_call_transcription_otel" => WebhookTypes.PostCallTranscriptionOtel,
                "post_call_unredacted_audio" => WebhookTypes.PostCallUnredactedAudio,
                "post_call_unredacted_transcription" => WebhookTypes.PostCallUnredactedTranscription,
                "post_call_unredacted_transcription_otel" => WebhookTypes.PostCallUnredactedTranscriptionOtel,
                "project_conversion_status" => WebhookTypes.ProjectConversionStatus,
                "speech_to_text_batch" => WebhookTypes.SpeechToTextBatch,
                "speech_to_text_transcription" => WebhookTypes.SpeechToTextTranscription,
                "support_ticket_message_added" => WebhookTypes.SupportTicketMessageAdded,
                "voice_removal_notice" => WebhookTypes.VoiceRemovalNotice,
                "voice_removal_notice_withdrawn" => WebhookTypes.VoiceRemovalNoticeWithdrawn,
                "voice_removed" => WebhookTypes.VoiceRemoved,
                "webhook_error" => WebhookTypes.WebhookError,
                _ => null,
            };
        }
    }
}