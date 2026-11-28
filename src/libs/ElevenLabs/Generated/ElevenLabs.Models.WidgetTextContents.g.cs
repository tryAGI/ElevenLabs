
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WidgetTextContents
    {
        /// <summary>
        /// Call to action displayed inside the compact and full variants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("main_label")]
        public string? MainLabel { get; set; }

        /// <summary>
        /// Text and ARIA label for the start call button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_call")]
        public string? StartCall { get; set; }

        /// <summary>
        /// Text and ARIA label for the start chat button (text only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_chat")]
        public string? StartChat { get; set; }

        /// <summary>
        /// Text and ARIA label for the new call button. Displayed when the caller already finished at least one call in order ot start the next one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_call")]
        public string? NewCall { get; set; }

        /// <summary>
        /// Text and ARIA label for the button that resumes the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resume_call")]
        public string? ResumeCall { get; set; }

        /// <summary>
        /// Text and ARIA label for the end call button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call")]
        public string? EndCall { get; set; }

        /// <summary>
        /// Text and ARIA label for the end chat button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_chat")]
        public string? EndChat { get; set; }

        /// <summary>
        /// ARIA label for the mute microphone button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mute_microphone")]
        public string? MuteMicrophone { get; set; }

        /// <summary>
        /// ARIA label for the change language dropdown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("change_language")]
        public string? ChangeLanguage { get; set; }

        /// <summary>
        /// ARIA label for the collapse button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collapse")]
        public string? Collapse { get; set; }

        /// <summary>
        /// ARIA label for the expand button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// ARIA label for the header button that expands the widget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_widget")]
        public string? ExpandWidget { get; set; }

        /// <summary>
        /// ARIA label for the header button that collapses the widget back to its compact size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collapse_widget")]
        public string? CollapseWidget { get; set; }

        /// <summary>
        /// ARIA label for the button that hides a dismissible widget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismiss")]
        public string? Dismiss { get; set; }

        /// <summary>
        /// ARIA label for the launcher button that reopens a dismissed widget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_chat")]
        public string? OpenChat { get; set; }

        /// <summary>
        /// Text displayed when the user copies a value using the copy button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copied")]
        public string? Copied { get; set; }

        /// <summary>
        /// Text and ARIA label for the accept terms button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accept_terms")]
        public string? AcceptTerms { get; set; }

        /// <summary>
        /// Text and ARIA label for the cancel terms button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismiss_terms")]
        public string? DismissTerms { get; set; }

        /// <summary>
        /// Title displayed in the confirmation dialog before ending a chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_chat_confirmation_title")]
        public string? EndChatConfirmationTitle { get; set; }

        /// <summary>
        /// Description displayed in the confirmation dialog before ending a chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_chat_confirmation_description")]
        public string? EndChatConfirmationDescription { get; set; }

        /// <summary>
        /// Title displayed in the confirmation dialog before ending a call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call_confirmation_title")]
        public string? EndCallConfirmationTitle { get; set; }

        /// <summary>
        /// Description displayed in the confirmation dialog before ending a call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call_confirmation_description")]
        public string? EndCallConfirmationDescription { get; set; }

        /// <summary>
        /// Text and ARIA label for the button that confirms ending a call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call_confirm")]
        public string? EndCallConfirm { get; set; }

        /// <summary>
        /// Text and ARIA label for the button that cancels ending a chat or call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_end_confirmation")]
        public string? CancelEndConfirmation { get; set; }

        /// <summary>
        /// Status displayed when the agent is listening.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listening_status")]
        public string? ListeningStatus { get; set; }

        /// <summary>
        /// Status displayed when the agent is speaking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaking_status")]
        public string? SpeakingStatus { get; set; }

        /// <summary>
        /// Status displayed when the agent is connecting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connecting_status")]
        public string? ConnectingStatus { get; set; }

        /// <summary>
        /// Status displayed when the agent is reconnecting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reconnecting_status")]
        public string? ReconnectingStatus { get; set; }

        /// <summary>
        /// Status displayed when the agent is chatting (text only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatting_status")]
        public string? ChattingStatus { get; set; }

        /// <summary>
        /// Status displayed while waiting in the queue for an available agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_waiting_status")]
        public string? QueueWaitingStatus { get; set; }

        /// <summary>
        /// Short status displayed while waiting for an available agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_waiting_status_short")]
        public string? QueueWaitingStatusShort { get; set; }

        /// <summary>
        /// ARIA label for the text message input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_label")]
        public string? InputLabel { get; set; }

        /// <summary>
        /// Placeholder text for the text message input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_placeholder")]
        public string? InputPlaceholder { get; set; }

        /// <summary>
        /// Placeholder text for the text message input (text only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_placeholder_text_only")]
        public string? InputPlaceholderTextOnly { get; set; }

        /// <summary>
        /// Placeholder text for the text message input when starting a new conversation (text only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_placeholder_new_conversation")]
        public string? InputPlaceholderNewConversation { get; set; }

        /// <summary>
        /// Information message displayed when the user ends the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ended_conversation")]
        public string? UserEndedConversation { get; set; }

        /// <summary>
        /// Information message displayed when the agent ends the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ended_conversation")]
        public string? AgentEndedConversation { get; set; }

        /// <summary>
        /// Text label used next to the conversation ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Text label used when an error occurs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_occurred")]
        public string? ErrorOccurred { get; set; }

        /// <summary>
        /// Error message displayed when the queue wait times out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_timed_out")]
        public string? QueueTimedOut { get; set; }

        /// <summary>
        /// Text and ARIA label used for the copy ID button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copy_id")]
        public string? CopyId { get; set; }

        /// <summary>
        /// Text displayed to prompt the user for feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initiate_feedback")]
        public string? InitiateFeedback { get; set; }

        /// <summary>
        /// Text displayed to request additional feedback details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_follow_up_feedback")]
        public string? RequestFollowUpFeedback { get; set; }

        /// <summary>
        /// Text displayed to thank the user for providing feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thanks_for_feedback")]
        public string? ThanksForFeedback { get; set; }

        /// <summary>
        /// Additional text displayed explaining the value of user feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thanks_for_feedback_details")]
        public string? ThanksForFeedbackDetails { get; set; }

        /// <summary>
        /// Placeholder text for the follow-up feedback input field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follow_up_feedback_placeholder")]
        public string? FollowUpFeedbackPlaceholder { get; set; }

        /// <summary>
        /// Text and ARIA label for the submit button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submit")]
        public string? Submit { get; set; }

        /// <summary>
        /// Text and ARIA label for the go back button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("go_back")]
        public string? GoBack { get; set; }

        /// <summary>
        /// Text and ARIA label for the send message button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_message")]
        public string? SendMessage { get; set; }

        /// <summary>
        /// Text and ARIA label for the switch to text mode button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_mode")]
        public string? TextMode { get; set; }

        /// <summary>
        /// Text and ARIA label for the switch to voice mode button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_mode")]
        public string? VoiceMode { get; set; }

        /// <summary>
        /// Label for the voice option in the conversation mode toggle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_mode_label")]
        public string? VoiceModeLabel { get; set; }

        /// <summary>
        /// Label for the text option in the conversation mode toggle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_mode_label")]
        public string? TextModeLabel { get; set; }

        /// <summary>
        /// Toast notification displayed when switching to text mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("switched_to_text_mode")]
        public string? SwitchedToTextMode { get; set; }

        /// <summary>
        /// Toast notification displayed when switching to voice mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("switched_to_voice_mode")]
        public string? SwitchedToVoiceMode { get; set; }

        /// <summary>
        /// Text and ARIA label for the copy button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copy")]
        public string? Copy { get; set; }

        /// <summary>
        /// Text and ARIA label for the download button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download")]
        public string? Download { get; set; }

        /// <summary>
        /// Text and ARIA label for the wrap toggle button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wrap")]
        public string? Wrap { get; set; }

        /// <summary>
        /// Status text displayed when the agent is processing a tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_working")]
        public string? AgentWorking { get; set; }

        /// <summary>
        /// Status text displayed when the agent finishes processing a tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_done")]
        public string? AgentDone { get; set; }

        /// <summary>
        /// Status text displayed when the agent encounters an error during a tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_error")]
        public string? AgentError { get; set; }

        /// <summary>
        /// Text and ARIA label for the attach file button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attach_file")]
        public string? AttachFile { get; set; }

        /// <summary>
        /// ARIA label for the remove file button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_file")]
        public string? RemoveFile { get; set; }

        /// <summary>
        /// Error message displayed when a file fails to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_upload_error")]
        public string? FileUploadError { get; set; }

        /// <summary>
        /// Error message displayed when an unsupported file type is selected. Followed by the list of accepted types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type_unsupported")]
        public string? FileTypeUnsupported { get; set; }

        /// <summary>
        /// Error message displayed when a file exceeds the maximum size limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_too_large")]
        public string? FileTooLarge { get; set; }

        /// <summary>
        /// Error message displayed when the maximum number of files for a conversation is reached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_limit_reached")]
        public string? FileLimitReached { get; set; }

        /// <summary>
        /// Status text displayed while the agent is typing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typing_indicator")]
        public string? TypingIndicator { get; set; }

        /// <summary>
        /// Status text displayed while the agent is thinking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_status")]
        public string? ThinkingStatus { get; set; }

        /// <summary>
        /// Fallback message displayed when rich content cannot be rendered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rich_content_unavailable")]
        public string? RichContentUnavailable { get; set; }

        /// <summary>
        /// ARIA label for the previous button in a rich content carousel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("carousel_previous")]
        public string? CarouselPrevious { get; set; }

        /// <summary>
        /// ARIA label for the next button in a rich content carousel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("carousel_next")]
        public string? CarouselNext { get; set; }

        /// <summary>
        /// Label for the button that scrolls to one new message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_message")]
        public string? NewMessage { get; set; }

        /// <summary>
        /// Label for the button that scrolls to new messages. Keep the count placeholder from the default, which is replaced with the number of messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_messages")]
        public string? NewMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetTextContents" /> class.
        /// </summary>
        /// <param name="mainLabel">
        /// Call to action displayed inside the compact and full variants.
        /// </param>
        /// <param name="startCall">
        /// Text and ARIA label for the start call button.
        /// </param>
        /// <param name="startChat">
        /// Text and ARIA label for the start chat button (text only)
        /// </param>
        /// <param name="newCall">
        /// Text and ARIA label for the new call button. Displayed when the caller already finished at least one call in order ot start the next one.
        /// </param>
        /// <param name="resumeCall">
        /// Text and ARIA label for the button that resumes the conversation.
        /// </param>
        /// <param name="endCall">
        /// Text and ARIA label for the end call button.
        /// </param>
        /// <param name="endChat">
        /// Text and ARIA label for the end chat button.
        /// </param>
        /// <param name="muteMicrophone">
        /// ARIA label for the mute microphone button.
        /// </param>
        /// <param name="changeLanguage">
        /// ARIA label for the change language dropdown.
        /// </param>
        /// <param name="collapse">
        /// ARIA label for the collapse button.
        /// </param>
        /// <param name="expand">
        /// ARIA label for the expand button.
        /// </param>
        /// <param name="expandWidget">
        /// ARIA label for the header button that expands the widget.
        /// </param>
        /// <param name="collapseWidget">
        /// ARIA label for the header button that collapses the widget back to its compact size.
        /// </param>
        /// <param name="dismiss">
        /// ARIA label for the button that hides a dismissible widget.
        /// </param>
        /// <param name="openChat">
        /// ARIA label for the launcher button that reopens a dismissed widget.
        /// </param>
        /// <param name="copied">
        /// Text displayed when the user copies a value using the copy button.
        /// </param>
        /// <param name="acceptTerms">
        /// Text and ARIA label for the accept terms button.
        /// </param>
        /// <param name="dismissTerms">
        /// Text and ARIA label for the cancel terms button.
        /// </param>
        /// <param name="endChatConfirmationTitle">
        /// Title displayed in the confirmation dialog before ending a chat.
        /// </param>
        /// <param name="endChatConfirmationDescription">
        /// Description displayed in the confirmation dialog before ending a chat.
        /// </param>
        /// <param name="endCallConfirmationTitle">
        /// Title displayed in the confirmation dialog before ending a call.
        /// </param>
        /// <param name="endCallConfirmationDescription">
        /// Description displayed in the confirmation dialog before ending a call.
        /// </param>
        /// <param name="endCallConfirm">
        /// Text and ARIA label for the button that confirms ending a call.
        /// </param>
        /// <param name="cancelEndConfirmation">
        /// Text and ARIA label for the button that cancels ending a chat or call.
        /// </param>
        /// <param name="listeningStatus">
        /// Status displayed when the agent is listening.
        /// </param>
        /// <param name="speakingStatus">
        /// Status displayed when the agent is speaking.
        /// </param>
        /// <param name="connectingStatus">
        /// Status displayed when the agent is connecting.
        /// </param>
        /// <param name="reconnectingStatus">
        /// Status displayed when the agent is reconnecting.
        /// </param>
        /// <param name="chattingStatus">
        /// Status displayed when the agent is chatting (text only)
        /// </param>
        /// <param name="queueWaitingStatus">
        /// Status displayed while waiting in the queue for an available agent.
        /// </param>
        /// <param name="queueWaitingStatusShort">
        /// Short status displayed while waiting for an available agent.
        /// </param>
        /// <param name="inputLabel">
        /// ARIA label for the text message input.
        /// </param>
        /// <param name="inputPlaceholder">
        /// Placeholder text for the text message input.
        /// </param>
        /// <param name="inputPlaceholderTextOnly">
        /// Placeholder text for the text message input (text only)
        /// </param>
        /// <param name="inputPlaceholderNewConversation">
        /// Placeholder text for the text message input when starting a new conversation (text only)
        /// </param>
        /// <param name="userEndedConversation">
        /// Information message displayed when the user ends the conversation.
        /// </param>
        /// <param name="agentEndedConversation">
        /// Information message displayed when the agent ends the conversation.
        /// </param>
        /// <param name="conversationId">
        /// Text label used next to the conversation ID.
        /// </param>
        /// <param name="errorOccurred">
        /// Text label used when an error occurs.
        /// </param>
        /// <param name="queueTimedOut">
        /// Error message displayed when the queue wait times out.
        /// </param>
        /// <param name="copyId">
        /// Text and ARIA label used for the copy ID button.
        /// </param>
        /// <param name="initiateFeedback">
        /// Text displayed to prompt the user for feedback.
        /// </param>
        /// <param name="requestFollowUpFeedback">
        /// Text displayed to request additional feedback details.
        /// </param>
        /// <param name="thanksForFeedback">
        /// Text displayed to thank the user for providing feedback.
        /// </param>
        /// <param name="thanksForFeedbackDetails">
        /// Additional text displayed explaining the value of user feedback.
        /// </param>
        /// <param name="followUpFeedbackPlaceholder">
        /// Placeholder text for the follow-up feedback input field.
        /// </param>
        /// <param name="submit">
        /// Text and ARIA label for the submit button.
        /// </param>
        /// <param name="goBack">
        /// Text and ARIA label for the go back button.
        /// </param>
        /// <param name="sendMessage">
        /// Text and ARIA label for the send message button.
        /// </param>
        /// <param name="textMode">
        /// Text and ARIA label for the switch to text mode button.
        /// </param>
        /// <param name="voiceMode">
        /// Text and ARIA label for the switch to voice mode button.
        /// </param>
        /// <param name="voiceModeLabel">
        /// Label for the voice option in the conversation mode toggle.
        /// </param>
        /// <param name="textModeLabel">
        /// Label for the text option in the conversation mode toggle.
        /// </param>
        /// <param name="switchedToTextMode">
        /// Toast notification displayed when switching to text mode.
        /// </param>
        /// <param name="switchedToVoiceMode">
        /// Toast notification displayed when switching to voice mode.
        /// </param>
        /// <param name="copy">
        /// Text and ARIA label for the copy button.
        /// </param>
        /// <param name="download">
        /// Text and ARIA label for the download button.
        /// </param>
        /// <param name="wrap">
        /// Text and ARIA label for the wrap toggle button.
        /// </param>
        /// <param name="agentWorking">
        /// Status text displayed when the agent is processing a tool call.
        /// </param>
        /// <param name="agentDone">
        /// Status text displayed when the agent finishes processing a tool call.
        /// </param>
        /// <param name="agentError">
        /// Status text displayed when the agent encounters an error during a tool call.
        /// </param>
        /// <param name="attachFile">
        /// Text and ARIA label for the attach file button.
        /// </param>
        /// <param name="removeFile">
        /// ARIA label for the remove file button.
        /// </param>
        /// <param name="fileUploadError">
        /// Error message displayed when a file fails to upload.
        /// </param>
        /// <param name="fileTypeUnsupported">
        /// Error message displayed when an unsupported file type is selected. Followed by the list of accepted types.
        /// </param>
        /// <param name="fileTooLarge">
        /// Error message displayed when a file exceeds the maximum size limit.
        /// </param>
        /// <param name="fileLimitReached">
        /// Error message displayed when the maximum number of files for a conversation is reached.
        /// </param>
        /// <param name="typingIndicator">
        /// Status text displayed while the agent is typing.
        /// </param>
        /// <param name="thinkingStatus">
        /// Status text displayed while the agent is thinking.
        /// </param>
        /// <param name="richContentUnavailable">
        /// Fallback message displayed when rich content cannot be rendered.
        /// </param>
        /// <param name="carouselPrevious">
        /// ARIA label for the previous button in a rich content carousel.
        /// </param>
        /// <param name="carouselNext">
        /// ARIA label for the next button in a rich content carousel.
        /// </param>
        /// <param name="newMessage">
        /// Label for the button that scrolls to one new message.
        /// </param>
        /// <param name="newMessages">
        /// Label for the button that scrolls to new messages. Keep the count placeholder from the default, which is replaced with the number of messages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetTextContents(
            string? mainLabel,
            string? startCall,
            string? startChat,
            string? newCall,
            string? resumeCall,
            string? endCall,
            string? endChat,
            string? muteMicrophone,
            string? changeLanguage,
            string? collapse,
            string? expand,
            string? expandWidget,
            string? collapseWidget,
            string? dismiss,
            string? openChat,
            string? copied,
            string? acceptTerms,
            string? dismissTerms,
            string? endChatConfirmationTitle,
            string? endChatConfirmationDescription,
            string? endCallConfirmationTitle,
            string? endCallConfirmationDescription,
            string? endCallConfirm,
            string? cancelEndConfirmation,
            string? listeningStatus,
            string? speakingStatus,
            string? connectingStatus,
            string? reconnectingStatus,
            string? chattingStatus,
            string? queueWaitingStatus,
            string? queueWaitingStatusShort,
            string? inputLabel,
            string? inputPlaceholder,
            string? inputPlaceholderTextOnly,
            string? inputPlaceholderNewConversation,
            string? userEndedConversation,
            string? agentEndedConversation,
            string? conversationId,
            string? errorOccurred,
            string? queueTimedOut,
            string? copyId,
            string? initiateFeedback,
            string? requestFollowUpFeedback,
            string? thanksForFeedback,
            string? thanksForFeedbackDetails,
            string? followUpFeedbackPlaceholder,
            string? submit,
            string? goBack,
            string? sendMessage,
            string? textMode,
            string? voiceMode,
            string? voiceModeLabel,
            string? textModeLabel,
            string? switchedToTextMode,
            string? switchedToVoiceMode,
            string? copy,
            string? download,
            string? wrap,
            string? agentWorking,
            string? agentDone,
            string? agentError,
            string? attachFile,
            string? removeFile,
            string? fileUploadError,
            string? fileTypeUnsupported,
            string? fileTooLarge,
            string? fileLimitReached,
            string? typingIndicator,
            string? thinkingStatus,
            string? richContentUnavailable,
            string? carouselPrevious,
            string? carouselNext,
            string? newMessage,
            string? newMessages)
        {
            this.MainLabel = mainLabel;
            this.StartCall = startCall;
            this.StartChat = startChat;
            this.NewCall = newCall;
            this.ResumeCall = resumeCall;
            this.EndCall = endCall;
            this.EndChat = endChat;
            this.MuteMicrophone = muteMicrophone;
            this.ChangeLanguage = changeLanguage;
            this.Collapse = collapse;
            this.Expand = expand;
            this.ExpandWidget = expandWidget;
            this.CollapseWidget = collapseWidget;
            this.Dismiss = dismiss;
            this.OpenChat = openChat;
            this.Copied = copied;
            this.AcceptTerms = acceptTerms;
            this.DismissTerms = dismissTerms;
            this.EndChatConfirmationTitle = endChatConfirmationTitle;
            this.EndChatConfirmationDescription = endChatConfirmationDescription;
            this.EndCallConfirmationTitle = endCallConfirmationTitle;
            this.EndCallConfirmationDescription = endCallConfirmationDescription;
            this.EndCallConfirm = endCallConfirm;
            this.CancelEndConfirmation = cancelEndConfirmation;
            this.ListeningStatus = listeningStatus;
            this.SpeakingStatus = speakingStatus;
            this.ConnectingStatus = connectingStatus;
            this.ReconnectingStatus = reconnectingStatus;
            this.ChattingStatus = chattingStatus;
            this.QueueWaitingStatus = queueWaitingStatus;
            this.QueueWaitingStatusShort = queueWaitingStatusShort;
            this.InputLabel = inputLabel;
            this.InputPlaceholder = inputPlaceholder;
            this.InputPlaceholderTextOnly = inputPlaceholderTextOnly;
            this.InputPlaceholderNewConversation = inputPlaceholderNewConversation;
            this.UserEndedConversation = userEndedConversation;
            this.AgentEndedConversation = agentEndedConversation;
            this.ConversationId = conversationId;
            this.ErrorOccurred = errorOccurred;
            this.QueueTimedOut = queueTimedOut;
            this.CopyId = copyId;
            this.InitiateFeedback = initiateFeedback;
            this.RequestFollowUpFeedback = requestFollowUpFeedback;
            this.ThanksForFeedback = thanksForFeedback;
            this.ThanksForFeedbackDetails = thanksForFeedbackDetails;
            this.FollowUpFeedbackPlaceholder = followUpFeedbackPlaceholder;
            this.Submit = submit;
            this.GoBack = goBack;
            this.SendMessage = sendMessage;
            this.TextMode = textMode;
            this.VoiceMode = voiceMode;
            this.VoiceModeLabel = voiceModeLabel;
            this.TextModeLabel = textModeLabel;
            this.SwitchedToTextMode = switchedToTextMode;
            this.SwitchedToVoiceMode = switchedToVoiceMode;
            this.Copy = copy;
            this.Download = download;
            this.Wrap = wrap;
            this.AgentWorking = agentWorking;
            this.AgentDone = agentDone;
            this.AgentError = agentError;
            this.AttachFile = attachFile;
            this.RemoveFile = removeFile;
            this.FileUploadError = fileUploadError;
            this.FileTypeUnsupported = fileTypeUnsupported;
            this.FileTooLarge = fileTooLarge;
            this.FileLimitReached = fileLimitReached;
            this.TypingIndicator = typingIndicator;
            this.ThinkingStatus = thinkingStatus;
            this.RichContentUnavailable = richContentUnavailable;
            this.CarouselPrevious = carouselPrevious;
            this.CarouselNext = carouselNext;
            this.NewMessage = newMessage;
            this.NewMessages = newMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetTextContents" /> class.
        /// </summary>
        public WidgetTextContents()
        {
        }

    }
}