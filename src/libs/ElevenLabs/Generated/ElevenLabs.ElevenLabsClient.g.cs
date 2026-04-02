
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// This is the documentation for the ElevenLabs API. You can use this API to use our service programmatically, this is done by using your API key. You can find your API key in the dashboard at https://elevenlabs.io/app/settings/api-keys.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class ElevenLabsClient : global::ElevenLabs.IElevenLabsClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.elevenlabs.io";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::ElevenLabs.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::ElevenLabs.JsonConverters.ASRInputFormatJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ASRInputFormatNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ASRProviderJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ASRProviderNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ASRQualityJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ASRQualityNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentDefinitionSourceNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentSortByJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentSortByNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentTestEntityTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentTestEntityTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AllowedOutputFormatsJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AllowedOutputFormatsNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AnalysisScopeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AudioAnalysisStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AudioAnalysisStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AuthorizationMethodJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AuthorizationMethodNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BatchCallRecipientStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BatchCallRecipientStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BatchCallStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BatchCallStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BillingPeriodJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BillingPeriodNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostQualityPresetJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostQualityPresetNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostQualityPresetJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostQualityPresetNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BranchProtectionStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BranchProtectionStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BreakdownTypesJsonConverter(),
                    new global::ElevenLabs.JsonConverters.BreakdownTypesNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ChapterResponseModelStateJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ChapterResponseModelStateNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CharacterRefreshPeriodJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CharacterRefreshPeriodNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ChatSourceMediumJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ChatSourceMediumNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ClientEventJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ClientEventNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ClipAnimationExitEffectJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ClipAnimationExitEffectNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConfigEntityTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConfigEntityTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationFeedbackTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationFeedbackTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationInitiationSourceJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationInitiationSourceNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationTokenPurposeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ConversationTokenPurposeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CustomLLMAPITypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CustomLLMAPITypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DocumentUsageModeEnumJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DocumentUsageModeEnumNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DubbingModelJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DubbingModelNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.EmbedVariantJsonConverter(),
                    new global::ElevenLabs.JsonConverters.EmbedVariantNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.EmbeddingModelEnumJsonConverter(),
                    new global::ElevenLabs.JsonConverters.EmbeddingModelEnumNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter(),
                    new global::ElevenLabs.JsonConverters.EvaluationSuccessResultNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ExtendedSubscriptionResponseModelCurrency2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ExtendedSubscriptionResponseModelCurrency2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.FineTuningResponseModelState2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.FineTuningResponseModelState2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GenesysRegionJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GenesysRegionNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GuardrailExecutionModeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GuardrailExecutionModeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.IntegrationTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.IntegrationTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseJsonConverter(),
                    new global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.KnowledgeBaseSortByJsonConverter(),
                    new global::ElevenLabs.JsonConverters.KnowledgeBaseSortByNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.LlmJsonConverter(),
                    new global::ElevenLabs.JsonConverters.LlmNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.LLMReasoningEffortJsonConverter(),
                    new global::ElevenLabs.JsonConverters.LLMReasoningEffortNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter(),
                    new global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.LivekitStackTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.LivekitStackTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPApprovalPolicyJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPApprovalPolicyNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPServerTransportJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPServerTransportNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputOverridesDiscriminatorSourceJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MergingStrategyJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MergingStrategyNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MessageSearchSortByJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MessageSearchSortByNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MetricTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MetricTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MockNoMatchBehaviorJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MockNoMatchBehaviorNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MockingStrategyJsonConverter(),
                    new global::ElevenLabs.JsonConverters.MockingStrategyNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsJsonConverter(),
                    new global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmJsonConverter(),
                    new global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.OAuthConnectionStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.OAuthConnectionStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PendingClipTaskTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PendingClipTaskTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PermissionTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PermissionTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationVariant1DiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProcedureCompilerModeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProcedureCompilerModeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelQualityPresetJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelQualityPresetNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectResponseModelStateJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectResponseModelStateNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.RAGIndexStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.RAGIndexStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.RenderStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.RenderStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.RenderType2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.RenderType2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ResponseFilterModeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ResponseFilterModeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SafetyRuleJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SafetyRuleNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SeatTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SeatTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SecretDependencyTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SecretDependencyTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SingleUseTokenTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SingleUseTokenTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SortDirectionJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SortDirectionNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpellingPatienceJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpellingPatienceNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SubscriptionResponseModelCurrency2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.SubscriptionResponseModelCurrency2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SubscriptionStatusTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SubscriptionStatusTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TTSConversationalModelJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TTSConversationalModelNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TTSModelFamilyJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TTSModelFamilyNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TTSOutputFormatJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TTSOutputFormatNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TelephonyDirectionJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TelephonyDirectionNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TelephonyProviderJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TelephonyProviderNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TestRunStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TestRunStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TestTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TestTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TextNormalisationTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TextNormalisationTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolCallSoundTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolCallSoundTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolErrorHandlingModeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolErrorHandlingModeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolExecutionModeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolExecutionModeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolSortByJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolSortByNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolTypeFilterJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolTypeFilterNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TransferTypeEnumJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TransferTypeEnumNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TurnEagernessJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TurnEagernessNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TurnModeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TurnModeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TurnModelJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TurnModelNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TwilioEdgeLocationJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TwilioEdgeLocationNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TwilioRegionIdJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TwilioRegionIdNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UsageAggregationIntervalJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UsageAggregationIntervalNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UserFeedbackScoreJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UserFeedbackScoreNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UsersSortByJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UsersSortByNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceCategoryJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceCategoryNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VideoAnalysisStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VideoAnalysisStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookEventTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookEventTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookUsageTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WebhookUsageTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetExpandableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetExpandableNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetFeedbackModeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetFeedbackModeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetPlacementJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WidgetPlacementNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkspaceResourceTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.WorkspaceResourceTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetSpeechHistorySource2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetSpeechHistorySource2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatJsonConverter(),
                    new global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListDubsOrderDirectionJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListDubsOrderDirectionNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2NullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeJsonConverter(),
                    new global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ASTLLMNodeInputJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ASTNodeOutputJsonConverter(),
                    new global::ElevenLabs.JsonConverters.NodesJsonConverter(),
                    new global::ElevenLabs.JsonConverters.Nodes2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.SchemaOverridesVariant1JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolsItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.McpServersItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TemplateParamsItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TriggerActionJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TriggerAction2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolsItem2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentsItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PhoneCallVariant1JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ResultVariant1JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ResultVariant12JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolDetailsVariant1JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolDetailsVariant12JsonConverter(),
                    new global::ElevenLabs.JsonConverters.TriggerAction3JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ExportOptionsJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PhoneNumbersItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ChartsItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentsItem2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.DocumentsItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DependentAgentsItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DependentAgentsItem2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.DependentAgentsItem3JsonConverter(),
                    new global::ElevenLabs.JsonConverters.DependentAgentsItem4JsonConverter(),
                    new global::ElevenLabs.JsonConverters.AgentsItem3JsonConverter(),
                    new global::ElevenLabs.JsonConverters.DataJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AuthConnectionsItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.DependentAgentsItem5JsonConverter(),
                    new global::ElevenLabs.JsonConverters.InputOverridesVariant1JsonConverter(),
                    new global::ElevenLabs.JsonConverters.InputOverridesVariant12JsonConverter(),
                    new global::ElevenLabs.JsonConverters.InputOverridesVariant13JsonConverter(),
                    new global::ElevenLabs.JsonConverters.InputOverridesVariant14JsonConverter(),
                    new global::ElevenLabs.JsonConverters.InputOverridesVariant15JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ChartsItem2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.CustomSipHeadersItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.TransferDestinationVariant1JsonConverter(),
                    new global::ElevenLabs.JsonConverters.PostDialDigitsVariant1JsonConverter(),
                    new global::ElevenLabs.JsonConverters.SourceContextVariant1JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BackupLlmConfigJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolsItem3JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BackupLlmConfig2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolsItem4JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolsVariant1ItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolsVariant1Item2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ParamsJsonConverter(),
                    new global::ElevenLabs.JsonConverters.Params2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.Params3JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolConfigJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ToolConfig2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BranchInfoVariant1JsonConverter(),
                    new global::ElevenLabs.JsonConverters.TestInfoVariant1JsonConverter(),
                    new global::ElevenLabs.JsonConverters.EvalJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ParametersItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ForwardConditionVariant1JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BackwardConditionVariant1JsonConverter(),
                    new global::ElevenLabs.JsonConverters.ForwardConditionVariant12JsonConverter(),
                    new global::ElevenLabs.JsonConverters.BackwardConditionVariant12JsonConverter(),
                    new global::ElevenLabs.JsonConverters.CustomSipHeadersItem2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.TransferDestinationJsonConverter(),
                    new global::ElevenLabs.JsonConverters.PostDialDigitsVariant12JsonConverter(),
                    new global::ElevenLabs.JsonConverters.CustomSipHeadersItem3JsonConverter(),
                    new global::ElevenLabs.JsonConverters.TransferDestination2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.PostDialDigitsVariant13JsonConverter(),
                    new global::ElevenLabs.JsonConverters.StepsItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.StepsItem2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestJsonConverter(),
                    new global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponse2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseJsonConverter(),
                    new global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseJsonConverter(),
                    new global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponse2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseJsonConverter(),
                    new global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponse2JsonConverter(),
                    new global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseJsonConverter(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAIDynamicVariable>(),
                    new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>(),
                    new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>(),
                    new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>(),
                    new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>(),
                    new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>(),
                    new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>(),
                    new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>(),
                    new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>(),
                    new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.DubbingTranscriptResponseModel, string>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>(),
                    new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>(),
                    new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AgentsPlatformClient AgentsPlatform => new AgentsPlatformClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AgentsWorkspaceAnalyticsClient AgentsWorkspaceAnalytics => new AgentsWorkspaceAnalyticsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AudioIsolationClient AudioIsolation => new AudioIsolationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AudioNativeClient AudioNative => new AudioNativeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ConversationalAiClient ConversationalAi => new ConversationalAiClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ConversationalAi2Client ConversationalAi2 => new ConversationalAi2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DubbingClient Dubbing => new DubbingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentVariablesClient EnvironmentVariables => new EnvironmentVariablesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ForcedAlignmentClient ForcedAlignment => new ForcedAlignmentClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public HistoryClient History => new HistoryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Access the different models of the platform.
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MusicClient Music => new MusicClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MusicGenerationClient MusicGeneration => new MusicGenerationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PronunciationDictionariesClient PronunciationDictionaries => new PronunciationDictionariesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PronunciationDictionaryClient PronunciationDictionary => new PronunciationDictionaryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PvcVoicesClient PvcVoices => new PvcVoicesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Access to your samples. A sample is any audio file you attached to a voice. A voice can have one or more samples.
        /// </summary>
        public SamplesClient Samples => new SamplesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SingleUseTokenClient SingleUseToken => new SingleUseTokenClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SpeechToSpeechClient SpeechToSpeech => new SpeechToSpeechClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Transcribe your audio files with detailed speaker annotations and precise timestamps using our cutting-edge model.
        /// </summary>
        public SpeechToTextClient SpeechToText => new SpeechToTextClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SpeechToText2Client SpeechToText2 => new SpeechToText2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StudioClient Studio => new StudioClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToDialogueClient TextToDialogue => new TextToDialogueClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToSoundEffectsClient TextToSoundEffects => new TextToSoundEffectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechClient TextToSpeech => new TextToSpeechClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToVoiceClient TextToVoice => new TextToVoiceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToVoice2Client TextToVoice2 => new TextToVoice2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsageClient Usage => new UsageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UserClient User => new UserClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Access to voices created either by you or ElevenLabs.
        /// </summary>
        public VoicesClient Voices => new VoicesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks => new WebhooksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Access to workspace related endpoints.
        /// </summary>
        public WorkspaceClient Workspace => new WorkspaceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the ElevenLabsClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public ElevenLabsClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::ElevenLabs.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::ElevenLabs.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}