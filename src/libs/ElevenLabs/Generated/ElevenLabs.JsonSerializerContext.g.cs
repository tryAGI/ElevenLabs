
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ElevenLabs.JsonConverters.ASRInputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRInputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRQualityJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRQualityNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTestEntityTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTestEntityTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTrustContextJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTrustContextNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AllowedOutputFormatsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AllowedOutputFormatsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisScopeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AssetTranscriptionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AssetTranscriptionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicPresetIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicPresetIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicSourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicSourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallRecipientStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallRecipientStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BillingPeriodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BillingPeriodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchProtectionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchProtectionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BreakdownTypesJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BreakdownTypesNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CharacterRefreshPeriodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CharacterRefreshPeriodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChatSourceMediumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChatSourceMediumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClientEventJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClientEventNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationExitEffectJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationExitEffectNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnFilterOperationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnFilterOperationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnUnitJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnUnitNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConfigEntityTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConfigEntityTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationFeedbackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationFeedbackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationInitiationSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationInitiationSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationTokenPurposeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationTokenPurposeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CurrencyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CurrencyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomLLMAPITypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomLLMAPITypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentUsageModeEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentUsageModeEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbedVariantJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbedVariantNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.FineTuningResponseModelState2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.FineTuningResponseModelState2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GenesysRegionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GenesysRegionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ImageAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ImageAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.IntegrationTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.IntegrationTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LlmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LlmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMReasoningEffortJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMReasoningEffortNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LivekitStackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LivekitStackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPApprovalPolicyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPApprovalPolicyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerTransportJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerTransportNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MessageSearchSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MessageSearchSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MetricTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MetricTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockNoMatchBehaviorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockNoMatchBehaviorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockingStrategyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockingStrategyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MonitorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MonitorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuthConnectionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuthConnectionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingClipTaskTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingClipTaskTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PermissionTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PermissionTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PreToolSpeechModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PreToolSpeechModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProcedureCompilerModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProcedureCompilerModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.QualityPresetTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.QualityPresetTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RAGIndexStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RAGIndexStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverride2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverride2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResponseFilterModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResponseFilterModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPLogMessageDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPLogMessageDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SafetyRuleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SafetyRuleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SeatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SeatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SingleUseTokenTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SingleUseTokenTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SortDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SortDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpellingPatienceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpellingPatienceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SubscriptionStatusTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SubscriptionStatusTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSModelFamilyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSModelFamilyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestSharingModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestSharingModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextNormalisationTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextNormalisationTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolErrorHandlingModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolErrorHandlingModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionTaskSupport2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionTaskSupport2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeFilterJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeFilterNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferTypeEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferTypeEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnEagernessJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnEagernessNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioEdgeLocationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioEdgeLocationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioRegionIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioRegionIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsageAggregationIntervalJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsageAggregationIntervalNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UserFeedbackScoreJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UserFeedbackScoreNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsersSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsersSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VideoAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VideoAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookEventTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookEventTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookTranscriptFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookTranscriptFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookUsageTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookUsageTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetExpandableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetExpandableNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetFeedbackModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetFeedbackModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetPlacementJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetPlacementNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsDubbingStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsDubbingStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsOrderDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsOrderDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLLMNodeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NodesJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Nodes2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SchemaOverridesVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.McpServersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TemplateParamsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerActionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerAction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.McpServersItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneCallVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResultVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResultVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolDetailsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolDetailsVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerAction3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableNestedValueTypeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableNestedValueTypeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableValueTypeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableValueTypeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumbersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChartsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependenciesVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependenciesVariant2ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DataJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem5JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant14JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant15JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant16JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChartsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestinationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SourceContextVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackupLlmConfigJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackupLlmConfig2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsVariant1Item2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ParamsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Params2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Params3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallDetailsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolConfigJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolConfig2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchInfoVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestInfoVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvalJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ParametersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ForwardConditionVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackwardConditionVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ForwardConditionVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackwardConditionVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestination2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestination3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StepsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StepsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAIDynamicVariable>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource, object>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.DateTime?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.DubbingTranscriptResponseModel, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_d0a2296ac97d65c5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_ceb57c07b09954cf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_c9c7ec7498b2853d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_14e725276612e2f7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>), TypeInfoPropertyName = "EnvironmentVariableAuthConnectionValue_064ccc3b9640bdb2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>), TypeInfoPropertyName = "CreateMTLSAuthRequest_51566c61e55005f5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>?), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_ecbe3cafa4c6d279")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>?), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_1fdd3ab2d425e9fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>?), TypeInfoPropertyName = "EnvironmentVariableAuthConnectionValue_a6ccb8fc0ba4a327")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>?), TypeInfoPropertyName = "CreateMTLSAuthRequest_82674d0f616c655b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_1fb871508f067193")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_ab769caeb7eb4850")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASRConversationalConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASRQuality), TypeInfoPropertyName = "ASRQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASRProvider), TypeInfoPropertyName = "ASRProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASRInputFormat), TypeInfoPropertyName = "ASRInputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASRConversationalConfigWorkflowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAdditionOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNodeInput), TypeInfoPropertyName = "ASTNodeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAdditionOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNodeOutput), TypeInfoPropertyName = "ASTNodeOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAndOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ASTNodeInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAndOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ASTNodeOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTBooleanNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTBooleanNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDivisionOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDivisionOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDynamicVariableNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDynamicVariableNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTEqualsOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLLMNodeInput), TypeInfoPropertyName = "ASTLLMNodeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMLiteralJsonSchemaProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLLMNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTStringNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNumberNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNullNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTOrOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTSubtractionOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNodeInputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNodeInputDiscriminatorType), TypeInfoPropertyName = "ASTNodeInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTStringNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNumberNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNullNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTOrOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTSubtractionOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNodeOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNodeOutputDiscriminatorType), TypeInfoPropertyName = "ASTNodeOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ActorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UserModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterWithContentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddKnowledgeBaseResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddVoiceIVCResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddWorkspaceGroupMemberResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddWorkspaceInviteResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AdditionalFormatResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ExportOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExportOptions), TypeInfoPropertyName = "ExportOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationalConfigAPIModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentPlatformSettingsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkflowRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentAlertingMonitorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentAlertingSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AgentAlertingMonitorConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentBranchBasicInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentBranchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BranchProtectionStatus), TypeInfoPropertyName = "BranchProtectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResourceAccessInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentVersionMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentVersionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentBranchSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentCallLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigAPIModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariablesConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigAPIModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariablesConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigAPIModelWorkflowOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariablesConfigWorkflowOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigAPIModelWorkflowOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariablesConfigWorkflowOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigOverrideConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOverrideConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentDefinitionSource), TypeInfoPropertyName = "AgentDefinitionSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentDeploymentPercentageStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentDeploymentRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentDeploymentRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentDeploymentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentFailureResponseExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentMetadataDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EvaluationSettingsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnalysisProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnalysisScope), TypeInfoPropertyName = "AnalysisScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationClientDataConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkspaceOverridesInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentTestingSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GuardrailsV1Input))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PrivacyConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentTrustContext), TypeInfoPropertyName = "AgentTrustContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Llm), TypeInfoPropertyName = "Llm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentPlatformSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EvaluationSettingsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationClientDataConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkspaceOverridesOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GuardrailsV1Output))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PrivacyConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SafetyResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentSimulatedChatTestResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryAnalysisCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentSortBy), TypeInfoPropertyName = "AgentSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentSuccessfulResponseExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentSummaryBatchSuccessfulResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentSummaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentTestEntityType), TypeInfoPropertyName = "AgentTestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentTestFolderPathSegmentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AttachedTestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AttachedTestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentTopicResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentVersionParents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Nodes), TypeInfoPropertyName = "Nodes2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowStartNodeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEndNodeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowOverrideAgentNodeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolNodeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType), TypeInfoPropertyName = "AgentWorkflowRequestModelNodesDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkflowResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Nodes2), TypeInfoPropertyName = "Nodes22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowStartNodeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEndNodeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolNodeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType), TypeInfoPropertyName = "AgentWorkflowResponseModelNodesDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationClientDataWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIWebhooks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AllowedOutputFormats), TypeInfoPropertyName = "AllowedOutputFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AllowlistItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnalysisPropertyType), TypeInfoPropertyName = "AnalysisPropertyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?, double?, bool?>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationDocResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator), TypeInfoPropertyName = "ApiIntegrationOAuth2AuthCodeResponseScopeSeparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuthConnectionStatus), TypeInfoPropertyName = "OAuthConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependencies))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator), TypeInfoPropertyName = "ApiIntegrationOAuth2CustomAppResponseScopeSeparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SchemaOverridesVariant1), TypeInfoPropertyName = "SchemaOverridesVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConstantSchemaOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariableSchemaOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMSchemaOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource), TypeInfoPropertyName = "ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAIDynamicVariable>), TypeInfoPropertyName = "AnyOfStringConvAIDynamicVariable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIDynamicVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResponseFilterMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookToolConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PreToolSpeechMode), TypeInfoPropertyName = "PreToolSpeechMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariableAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolCallSoundType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolCallSoundBehavior), TypeInfoPropertyName = "ToolCallSoundBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolErrorHandlingMode), TypeInfoPropertyName = "ToolErrorHandlingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolExecutionMode), TypeInfoPropertyName = "ToolExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ArrayJsonSchemaPropertyInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>), TypeInfoPropertyName = "OneOfLiteralJsonSchemaPropertyObjectJsonSchemaPropertyInputArrayJsonSchemaPropertyInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LiteralJsonSchemaProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ObjectJsonSchemaPropertyInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ArrayJsonSchemaPropertyOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>), TypeInfoPropertyName = "OneOfLiteralJsonSchemaPropertyObjectJsonSchemaPropertyOutputArrayJsonSchemaPropertyOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ObjectJsonSchemaPropertyOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AssetTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AssetTranscriptionStatus), TypeInfoPropertyName = "AssetTranscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AssetTranscriptionData2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AssignConversationTagsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AsyncConversationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AsyncConversationMetadataDeliveryStatus), TypeInfoPropertyName = "AsyncConversationMetadataDeliveryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioAnalysisStatus), TypeInfoPropertyName = "AudioAnalysisStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AudioSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AudioKeyMoment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioKeyMoment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioIsolationHistoryItemResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioNativeCreateProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioNativeEditContentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioNativeProjectSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus), TypeInfoPropertyName = "AudioNativeProjectSettingsResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioWithTimestampsAndVoiceSegmentsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CharacterAlignmentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VoiceSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioWithTimestampsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem), TypeInfoPropertyName = "ToolsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableToolIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentUnknownToolIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType), TypeInfoPropertyName = "AuthConnectionDependenciesToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.McpServersItem), TypeInfoPropertyName = "McpServersItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentUnknownMCPServerIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType), TypeInfoPropertyName = "AuthConnectionDependenciesMcpServerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentIntegrationConnectionIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentIntegrationConnectionIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AllowlistItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthorizationMethod), TypeInfoPropertyName = "AuthorizationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AutoSyncInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackgroundMusicConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackgroundMusicSourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackgroundMusicPresetId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackgroundMusicConfigWorkflowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackupLLMDefault))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackupLLMDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackupLLMOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.Llm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BaseTurnConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnMode), TypeInfoPropertyName = "TurnMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnEagerness), TypeInfoPropertyName = "TurnEagerness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpellingPatience), TypeInfoPropertyName = "SpellingPatience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BasicAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchCallDetailedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TelephonyProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchCallWhatsAppParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchCallStatus), TypeInfoPropertyName = "BatchCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TelephonyCallConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipientResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OutboundCallRecipientResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchCallRecipientStatus), TypeInfoPropertyName = "BatchCallRecipientStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchFailureResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BearerAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BillingPeriod), TypeInfoPropertyName = "BillingPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>), TypeInfoPropertyName = "AnyOfPronunciationDictionaryAliasRuleRequestModelPronunciationDictionaryPhonemeRuleRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddSamplesToPvcVoiceV1VoicesPvcVoiceIdSamplesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddVoiceV1VoicesAddPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string, object>), TypeInfoPropertyName = "AnyOfDictionaryStringStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyBulkMoveTestsToFolderV1ConvaiAgentTestingBulkMovePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId), TypeInfoPropertyName = "BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix), TypeInfoPropertyName = "BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicV1MusicPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicV1MusicPostModelId), TypeInfoPropertyName = "BodyComposeMusicV1MusicPostModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.GetOrCreateRAGIndexRequestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetOrCreateRAGIndexRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateAgentV1ConvaiAgentsCreatePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePvcVoiceV1VoicesPvcPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.QualityPresetType), TypeInfoPropertyName = "QualityPresetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateUrlDocumentV1ConvaiKnowledgeBaseUrlPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoicePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateAgentTestFolderV1ConvaiAgentTestingFoldersPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateChapterV1StudioProjectsProjectIdChaptersPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateForcedAlignmentV1ForcedAlignmentPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>), TypeInfoPropertyName = "AnyOfPodcastConversationModePodcastBulletinMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastConversationMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastBulletinMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>), TypeInfoPropertyName = "AnyOfPodcastTextSourcePodcastURLSourceIListAnyOfPodcastTextSourcePodcastURLSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastTextSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastURLSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>), TypeInfoPropertyName = "AnyOfPodcastTextSourcePodcastURLSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale), TypeInfoPropertyName = "BodyCreatePodcastV1StudioPodcastsPostDurationScale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookHMACSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDeleteExistingInvitationV1WorkspaceInvitesDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDownloadHistoryItemsV1HistoryDownloadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode), TypeInfoPropertyName = "BodyDubAVideoOrAnAudioFileV1DubbingPostMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditPvcVoiceV1VoicesPvcVoiceIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPostModelId), TypeInfoPropertyName = "BodyGenerateCompositionPlanV1MusicPlanPostModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item), TypeInfoPropertyName = "BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ColumnFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyHandleAnOutboundCallViaSipTrunkV1ConvaiSipTrunkOutboundCallPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationClientDataRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SeatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyInviteUserV1WorkspaceInvitesAddPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TelephonyDirection), TypeInfoPropertyName = "TelephonyDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RenderType2), TypeInfoPropertyName = "RenderType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TemplateParamsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TemplateParamsItem), TypeInfoPropertyName = "TemplateParamsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateBodyComponentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateButtonComponentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType), TypeInfoPropertyName = "BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySetRulesOnThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdSetRulesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole), TypeInfoPropertyName = "BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceResourceType), TypeInfoPropertyName = "WorkspaceResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationSimulationSpecification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PromptEvaluationCriteria>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptEvaluationCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySoundGenerationV1SoundGenerationPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostModelId), TypeInfoPropertyName = "BodySpeechToTextV1SpeechToTextPostModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity), TypeInfoPropertyName = "BodySpeechToTextV1SpeechToTextPostTimestampsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat), TypeInfoPropertyName = "BodySpeechToTextV1SpeechToTextPostFileFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, object, object>), TypeInfoPropertyName = "AnyOfStringObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId), TypeInfoPropertyName = "BodyStemSeparationV1MusicStemSeparationPostStemVariationId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamChapterAudioV1StudioProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamComposedMusicV1MusicStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamComposedMusicV1MusicStreamPostModelId), TypeInfoPropertyName = "BodyStreamComposedMusicV1MusicStreamPostModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OutboundCallRecipient))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DialogueInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ModelSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization), TypeInfoPropertyName = "BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization), TypeInfoPropertyName = "BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTranslatesAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdTranslatePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdatePvcVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateStudioProjectV1StudioProjectsProjectIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateAgentTestFolderV1ConvaiAgentTestingFoldersFolderIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateFileDocumentV1ConvaiKnowledgeBaseDocumentationIdUpdateFilePatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUploadFileV1ConvaiConversationsConversationIdFilesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUploadMusicV1MusicUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyVerifyPvcVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyVideoToMusicV1MusicVideoToMusicPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>), TypeInfoPropertyName = "AnyOfIListPermissionTypeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PermissionType), TypeInfoPropertyName = "PermissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>), TypeInfoPropertyName = "AnyOfIListStringBodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps), TypeInfoPropertyName = "BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueFullWithTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization), TypeInfoPropertyName = "BodyTextToDialogueFullWithTimestampsApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueStreamWithTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization), TypeInfoPropertyName = "BodyTextToDialogueStreamWithTimestampsApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechFull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization), TypeInfoPropertyName = "BodyTextToSpeechFullApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechFullWithTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization), TypeInfoPropertyName = "BodyTextToSpeechFullWithTimestampsApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization), TypeInfoPropertyName = "BodyTextToSpeechStreamApplyTextNormalization2")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ElevenLabs.JsonConverters.ASRInputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRInputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRQualityJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRQualityNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTestEntityTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTestEntityTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTrustContextJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTrustContextNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AllowedOutputFormatsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AllowedOutputFormatsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisScopeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AssetTranscriptionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AssetTranscriptionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicPresetIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicPresetIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicSourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicSourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallRecipientStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallRecipientStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BillingPeriodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BillingPeriodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchProtectionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchProtectionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BreakdownTypesJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BreakdownTypesNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CharacterRefreshPeriodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CharacterRefreshPeriodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChatSourceMediumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChatSourceMediumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClientEventJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClientEventNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationExitEffectJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationExitEffectNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnFilterOperationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnFilterOperationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnUnitJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnUnitNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConfigEntityTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConfigEntityTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationFeedbackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationFeedbackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationInitiationSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationInitiationSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationTokenPurposeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationTokenPurposeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CurrencyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CurrencyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomLLMAPITypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomLLMAPITypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentUsageModeEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentUsageModeEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbedVariantJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbedVariantNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.FineTuningResponseModelState2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.FineTuningResponseModelState2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GenesysRegionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GenesysRegionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ImageAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ImageAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.IntegrationTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.IntegrationTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LlmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LlmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMReasoningEffortJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMReasoningEffortNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LivekitStackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LivekitStackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPApprovalPolicyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPApprovalPolicyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerTransportJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerTransportNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MessageSearchSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MessageSearchSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MetricTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MetricTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockNoMatchBehaviorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockNoMatchBehaviorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockingStrategyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockingStrategyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MonitorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MonitorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuthConnectionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuthConnectionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingClipTaskTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingClipTaskTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PermissionTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PermissionTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PreToolSpeechModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PreToolSpeechModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProcedureCompilerModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProcedureCompilerModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.QualityPresetTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.QualityPresetTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RAGIndexStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RAGIndexStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverride2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverride2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResponseFilterModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResponseFilterModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPLogMessageDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPLogMessageDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SafetyRuleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SafetyRuleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SeatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SeatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SingleUseTokenTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SingleUseTokenTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SortDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SortDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpellingPatienceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpellingPatienceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SubscriptionStatusTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SubscriptionStatusTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSModelFamilyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSModelFamilyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestSharingModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestSharingModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextNormalisationTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextNormalisationTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolErrorHandlingModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolErrorHandlingModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionTaskSupport2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionTaskSupport2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeFilterJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeFilterNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferTypeEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferTypeEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnEagernessJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnEagernessNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioEdgeLocationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioEdgeLocationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioRegionIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioRegionIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsageAggregationIntervalJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsageAggregationIntervalNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UserFeedbackScoreJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UserFeedbackScoreNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsersSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsersSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VideoAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VideoAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookEventTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookEventTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookTranscriptFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookTranscriptFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookUsageTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookUsageTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetExpandableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetExpandableNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetFeedbackModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetFeedbackModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetPlacementJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetPlacementNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsDubbingStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsDubbingStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsOrderDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsOrderDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLLMNodeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NodesJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Nodes2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SchemaOverridesVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.McpServersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TemplateParamsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerActionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerAction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.McpServersItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneCallVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResultVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResultVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolDetailsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolDetailsVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerAction3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableNestedValueTypeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableNestedValueTypeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableValueTypeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableValueTypeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumbersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChartsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependenciesVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependenciesVariant2ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DataJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem5JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant14JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant15JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant16JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChartsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestinationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SourceContextVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackupLlmConfigJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackupLlmConfig2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsVariant1Item2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ParamsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Params2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Params3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallDetailsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolConfigJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolConfig2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchInfoVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestInfoVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvalJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ParametersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ForwardConditionVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackwardConditionVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ForwardConditionVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackwardConditionVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestination2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestination3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StepsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StepsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAIDynamicVariable>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource, object>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.DateTime?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.DubbingTranscriptResponseModel, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_d0a2296ac97d65c5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_ceb57c07b09954cf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_c9c7ec7498b2853d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_14e725276612e2f7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>), TypeInfoPropertyName = "EnvironmentVariableAuthConnectionValue_064ccc3b9640bdb2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>), TypeInfoPropertyName = "CreateMTLSAuthRequest_51566c61e55005f5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>?), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_ecbe3cafa4c6d279")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>?), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_1fdd3ab2d425e9fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>?), TypeInfoPropertyName = "EnvironmentVariableAuthConnectionValue_a6ccb8fc0ba4a327")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>?), TypeInfoPropertyName = "CreateMTLSAuthRequest_82674d0f616c655b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_1fb871508f067193")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_ab769caeb7eb4850")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechStreamWithTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization), TypeInfoPropertyName = "BodyTextToSpeechStreamWithTimestampsApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BreakdownTypes), TypeInfoPropertyName = "BreakdownTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BuiltInToolsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SystemToolConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BuiltInToolsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SystemToolConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BuiltInToolsWorkflowOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BuiltInToolsWorkflowOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CancelCalendarEventParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CancelGroupSessionForAllParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CancelGroupSessionRegistrationParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CanvasPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType), TypeInfoPropertyName = "CaptionStyleCharacterAnimationModelEnterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType), TypeInfoPropertyName = "CaptionStyleCharacterAnimationModelExitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleHorizontalPlacementModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign), TypeInfoPropertyName = "CaptionStyleHorizontalPlacementModelAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleTemplateModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextAlign2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextStyle2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextWeight2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextTransform2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextBlendMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioTextStyleShadowModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioTextStyleOutlineModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleSectionAnimationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleWordAnimationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleVerticalPlacementModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelEnterType), TypeInfoPropertyName = "CaptionStyleSectionAnimationModelEnterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelExitType), TypeInfoPropertyName = "CaptionStyleSectionAnimationModelExitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleVerticalPlacementModelAlign), TypeInfoPropertyName = "CaptionStyleVerticalPlacementModelAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleWordAnimationModelEnterType), TypeInfoPropertyName = "CaptionStyleWordAnimationModelEnterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleWordAnimationModelExitType), TypeInfoPropertyName = "CaptionStyleWordAnimationModelExitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentBlockInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentBlockInputModelSubType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentBlockResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>), TypeInfoPropertyName = "AnyOfChapterContentBlockTtsNodeResponseModelChapterContentBlockExtendableNodeResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterResponseModelState), TypeInfoPropertyName = "ChapterResponseModelState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterStatisticsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterSnapshotExtendedResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.CharacterAlignmentModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CharacterAlignmentModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterSnapshotResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterSnapshotsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChapterSnapshotResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VoiceStatisticsResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceStatisticsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterWithContentResponseModelState), TypeInfoPropertyName = "ChapterWithContentResponseModelState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CharacterRefreshPeriod), TypeInfoPropertyName = "CharacterRefreshPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChatSourceMedium), TypeInfoPropertyName = "ChatSourceMedium2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CheckServiceAvailabilityParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClientEvent), TypeInfoPropertyName = "ClientEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClientToolConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClientToolConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClipAnimation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClipAnimationEnterEffect), TypeInfoPropertyName = "ClipAnimationEnterEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClipAnimationExitEffect), TypeInfoPropertyName = "ClipAnimationExitEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CoachedAgentSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CoachingAgentSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CodeToolAllowedDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ColumnFilterOperation), TypeInfoPropertyName = "ColumnFilterOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?, object>), TypeInfoPropertyName = "AnyOfStringInt32DoubleDateTimeBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ColumnUnit), TypeInfoPropertyName = "ColumnUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConfigEntityType), TypeInfoPropertyName = "ConfigEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentThresholdGuardrail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentGuardrailInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GuardrailExecutionMode), TypeInfoPropertyName = "GuardrailExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TriggerAction), TypeInfoPropertyName = "TriggerAction2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EndCallTriggerAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RetryTriggerAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType), TypeInfoPropertyName = "ContentGuardrailInputTriggerActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentGuardrailOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TriggerAction2), TypeInfoPropertyName = "TriggerAction22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType), TypeInfoPropertyName = "ContentGuardrailOutputTriggerActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>), TypeInfoPropertyName = "AnyOfDoubleContentThresholdGuardrailThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentThresholdGuardrailThreshold), TypeInfoPropertyName = "ContentThresholdGuardrailThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContextualUpdateInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Contributor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIEnvVarLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIFileUploadResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAISecretLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIStoredSecretDependencies))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem2), TypeInfoPropertyName = "ToolsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminatorType), TypeInfoPropertyName = "ConvAIStoredSecretDependenciesToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentsItem), TypeInfoPropertyName = "AgentsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableAgentIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentUnknownAgentIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminatorType), TypeInfoPropertyName = "ConvAIStoredSecretDependenciesAgentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentPhoneNumberIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.McpServersItem2), TypeInfoPropertyName = "McpServersItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminatorType), TypeInfoPropertyName = "ConvAIStoredSecretDependenciesMcpServerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SecretDependencyType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SecretDependencyType), TypeInfoPropertyName = "SecretDependencyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIUserSecretDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WebhookEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookEventType), TypeInfoPropertyName = "WebhookEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookTranscriptFormat), TypeInfoPropertyName = "WebhookTranscriptFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationASRUsageModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationChargingCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMCategoryUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationTTSUsageModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FileInputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigClientOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSConversationalConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigClientOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigClientOverrideConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnConfigOverrideConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSConversationalConfigOverrideConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigOverrideConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigClientOverrideConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigWorkflowOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FileInputConfigWorkflowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigWorkflowOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationDeletionSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationFeedbackRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UserFeedbackScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationFeedbackType), TypeInfoPropertyName = "ConversationFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DataCollectionResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DataCollectionResultCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EvaluationSuccessResult), TypeInfoPropertyName = "EvaluationSuccessResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ScopedAnalysisResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ScopedAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryBatchCallModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryElevenAssistantCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryErrorCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryFeedbackCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneCallVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType), TypeInfoPropertyName = "ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryRagUsageCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FeaturesUsageCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationSource), TypeInfoPropertyName = "ConversationInitiationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppConversationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SMSConversationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceRewardModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationVoiceRewardModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryMultivoiceMessageModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryRedactionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConfigEntityType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableUpdateCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariableUpdateCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelInputRole), TypeInfoPropertyName = "ConversationHistoryTranscriptCommonModelInputRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UserFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationTurnMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RagRetrievalInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMUsageInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutputRole), TypeInfoPropertyName = "ConversationHistoryTranscriptCommonModelOutputRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMUsageOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole), TypeInfoPropertyName = "ConversationHistoryTranscriptResponseModelRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResultVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EndCallToolResultModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguageDetectionToolResultModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolResultErrorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToNumberResultSipSuccessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToNumberResultErrorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SkipTurnToolResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PlayDTMFResultSuccessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PlayDTMFResultErrorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceMailDetectionResultSuccessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestToolResultModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseRagToolResultModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType), TypeInfoPropertyName = "ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResultVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType), TypeInfoPropertyName = "ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolDetailsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType), TypeInfoPropertyName = "ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolDetailsVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType), TypeInfoPropertyName = "ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationClientDataInternal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationSourceInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariableValueTypeOutput), TypeInfoPropertyName = "DynamicVariableValueTypeOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrchestratorToolMockBehaviorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariableValueTypeInput), TypeInfoPropertyName = "DynamicVariableValueTypeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationClientDataRequestOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator>), TypeInfoPropertyName = "AnyOfStringConvAISecretLocator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationSignedUrlResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ToolMockConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolMockConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationSummaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationSummaryResponseModelStatus), TypeInfoPropertyName = "ConversationSummaryResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceUsageModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationVoiceUsageModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationTagResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationTokenPurpose), TypeInfoPropertyName = "ConversationTokenPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationTokenResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.MetricRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MetricRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationUserResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSConversationalConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguagePresetInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VADConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationalConfigAPIModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSConversationalConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguagePresetOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnConfigWorkflowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSConversationalConfigWorkflowOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VADConfigWorkflowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSConversationalConfigWorkflowOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvertChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvertProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAgentBranchResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAgentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAgentRuleParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAgentTestFolderResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAgentTestResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAssetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateBasicAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateClientAppointmentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateClientInteractionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateClientParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateConversationTagRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateCustomHeaderAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateHolidayParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateLocationParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateMTLSAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2ClientCredsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2JWTRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm), TypeInfoPropertyName = "CreateOAuth2JWTRequestAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField), TypeInfoPropertyName = "CreateOAuth2JWTRequestTokenResponseField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatePhoneNumberResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatePrivateKeyJWTRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm), TypeInfoPropertyName = "CreatePrivateKeyJWTRequestAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateProductParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatePronunciationDictionaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateResponseUnitTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestFromConversationMetadataInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentSuccessfulResponseExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentFailureResponseExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InboundSIPTrunkConfigRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OutboundSIPTrunkConfigRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateSecretEnvironmentVariableRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentVariableSecretValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateServiceParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateSimulationTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SimulationToolMockBehaviorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateSpeechEngineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechEngineConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateSpeechEngineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateStaffParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateStringEnvironmentVariableRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateToolCallUnitTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestToolCallEvaluationModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateTwilioPhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RegionConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Currency), TypeInfoPropertyName = "Currency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailsConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailsConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TriggerAction3), TypeInfoPropertyName = "TriggerAction32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType), TypeInfoPropertyName = "CustomGuardrailConfigTriggerActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.CustomGuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomHeaderAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomLLM))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator, object>), TypeInfoPropertyName = "AnyOfConvAISecretLocatorConvAIEnvVarLocatorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>), TypeInfoPropertyName = "AnyOfStringConvAISecretLocatorConvAIDynamicVariableConvAIEnvVarLocator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomLLMAPIType), TypeInfoPropertyName = "CustomLLMAPIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomSIPHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomSIPHeaderWithDynamicVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DTMFInputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DashboardCallSuccessChartModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DashboardCriteriaChartModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DashboardDataCollectionChartModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DefaultSharingGroupResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceGroupResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel), TypeInfoPropertyName = "DefaultSharingGroupResponseModelPermissionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteAgentRuleParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteAssetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteCalendarEventParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteClientInteractionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteClientParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteDubbingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteGroupSessionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteHistoryItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteHolidayParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteLocationParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteProductParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteSampleResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteServiceParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteStaffParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteVoiceSampleResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteWorkspaceGroupMemberResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteWorkspaceInviteResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteWorkspaceWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableAgentIdentifierAccessLevel), TypeInfoPropertyName = "DependentAvailableAgentIdentifierAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel), TypeInfoPropertyName = "DependentAvailableMCPServerIdentifierAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel), TypeInfoPropertyName = "DependentAvailableToolIdentifierAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentBranchInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DetailedMusicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SongMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WordTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DetectedEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeviceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DialogueInputResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ReadMetadataChapterDBModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReadMetadataChapterDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item), TypeInfoPropertyName = "DirectPublishingReadResponseModelGenreVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReadLegalTerms))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.Contributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelPayoutType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PreviewAudioDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SampleConfigDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReviewResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DiscountResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DoDubbingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DocumentUsageModeEnum), TypeInfoPropertyName = "DocumentUsageModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DocxExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbedSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SegmentSubtitleFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentSubtitleFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingMediaReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingMediaMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingMetadataPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingMetadataResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingRenderResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.Render>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Render))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptCharacter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptCharacter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat), TypeInfoPropertyName = "DubbingTranscriptsResponseModelTranscriptFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariableNestedValueTypeInput), TypeInfoPropertyName = "DynamicVariableNestedValueTypeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariableNestedValueTypeOutput), TypeInfoPropertyName = "DynamicVariableNestedValueTypeOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditVoiceSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EmbedVariant), TypeInfoPropertyName = "EmbedVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EmbeddingModelEnum), TypeInfoPropertyName = "EmbeddingModelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EndCallToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentAuthConnectionLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentVariableAuthConnectionValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentVariableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentVariableResponseType), TypeInfoPropertyName = "EnvironmentVariableResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentVariableSecretValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentVariablesListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentVariableResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExactParameterEvaluationStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentedJsonExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PdfExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TxtExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HtmlExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SrtExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExportOptionsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExportOptionsDiscriminatorFormat), TypeInfoPropertyName = "ExportOptionsDiscriminatorFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExtendedSubscriptionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, string>), TypeInfoPropertyName = "AnyOfInt32String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Price))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SubscriptionStatusType), TypeInfoPropertyName = "SubscriptionStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InvoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel, object>), TypeInfoPropertyName = "AnyOfPendingSubscriptionSwitchResponseModelPendingCancellationResponseModelObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingSubscriptionSwitchResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingCancellationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FeatureStatusCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowFeaturesUsageCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestsFeatureUsageCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FeedbackResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FineTuningResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.FineTuningResponseModelState2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FineTuningResponseModelState2), TypeInfoPropertyName = "FineTuningResponseModelState22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VerificationAttemptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VerificationAttemptResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ManualVerificationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FocusGuardrail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ForcedAlignmentCharacterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ForcedAlignmentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentWordResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ForcedAlignmentWordResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerationSourceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenesysRegion), TypeInfoPropertyName = "GenesysRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentEmbedResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetConfigResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentKnowledgebaseSizeResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentLinkResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumbersItem), TypeInfoPropertyName = "PhoneNumbersItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberTwilioResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ElevenLabs.JsonConverters.ASRInputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRInputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRQualityJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRQualityNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTestEntityTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTestEntityTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTrustContextJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTrustContextNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AllowedOutputFormatsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AllowedOutputFormatsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisScopeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AssetTranscriptionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AssetTranscriptionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicPresetIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicPresetIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicSourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicSourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallRecipientStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallRecipientStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BillingPeriodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BillingPeriodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchProtectionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchProtectionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BreakdownTypesJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BreakdownTypesNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CharacterRefreshPeriodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CharacterRefreshPeriodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChatSourceMediumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChatSourceMediumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClientEventJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClientEventNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationExitEffectJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationExitEffectNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnFilterOperationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnFilterOperationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnUnitJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnUnitNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConfigEntityTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConfigEntityTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationFeedbackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationFeedbackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationInitiationSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationInitiationSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationTokenPurposeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationTokenPurposeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CurrencyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CurrencyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomLLMAPITypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomLLMAPITypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentUsageModeEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentUsageModeEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbedVariantJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbedVariantNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.FineTuningResponseModelState2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.FineTuningResponseModelState2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GenesysRegionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GenesysRegionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ImageAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ImageAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.IntegrationTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.IntegrationTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LlmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LlmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMReasoningEffortJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMReasoningEffortNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LivekitStackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LivekitStackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPApprovalPolicyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPApprovalPolicyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerTransportJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerTransportNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MessageSearchSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MessageSearchSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MetricTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MetricTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockNoMatchBehaviorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockNoMatchBehaviorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockingStrategyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockingStrategyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MonitorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MonitorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuthConnectionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuthConnectionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingClipTaskTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingClipTaskTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PermissionTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PermissionTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PreToolSpeechModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PreToolSpeechModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProcedureCompilerModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProcedureCompilerModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.QualityPresetTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.QualityPresetTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RAGIndexStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RAGIndexStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverride2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverride2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResponseFilterModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResponseFilterModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPLogMessageDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPLogMessageDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SafetyRuleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SafetyRuleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SeatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SeatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SingleUseTokenTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SingleUseTokenTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SortDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SortDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpellingPatienceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpellingPatienceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SubscriptionStatusTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SubscriptionStatusTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSModelFamilyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSModelFamilyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestSharingModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestSharingModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextNormalisationTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextNormalisationTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolErrorHandlingModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolErrorHandlingModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionTaskSupport2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionTaskSupport2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeFilterJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeFilterNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferTypeEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferTypeEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnEagernessJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnEagernessNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioEdgeLocationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioEdgeLocationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioRegionIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioRegionIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsageAggregationIntervalJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsageAggregationIntervalNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UserFeedbackScoreJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UserFeedbackScoreNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsersSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsersSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VideoAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VideoAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookEventTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookEventTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookTranscriptFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookTranscriptFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookUsageTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookUsageTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetExpandableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetExpandableNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetFeedbackModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetFeedbackModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetPlacementJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetPlacementNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsDubbingStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsDubbingStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsOrderDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsOrderDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLLMNodeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NodesJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Nodes2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SchemaOverridesVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.McpServersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TemplateParamsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerActionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerAction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.McpServersItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneCallVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResultVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResultVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolDetailsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolDetailsVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerAction3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableNestedValueTypeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableNestedValueTypeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableValueTypeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableValueTypeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumbersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChartsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependenciesVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependenciesVariant2ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DataJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem5JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant14JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant15JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant16JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChartsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestinationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SourceContextVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackupLlmConfigJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackupLlmConfig2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsVariant1Item2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ParamsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Params2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Params3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallDetailsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolConfigJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolConfig2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchInfoVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestInfoVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvalJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ParametersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ForwardConditionVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackwardConditionVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ForwardConditionVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackwardConditionVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestination2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestination3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StepsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StepsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAIDynamicVariable>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource, object>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.DateTime?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.DubbingTranscriptResponseModel, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_d0a2296ac97d65c5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_ceb57c07b09954cf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_c9c7ec7498b2853d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_14e725276612e2f7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>), TypeInfoPropertyName = "EnvironmentVariableAuthConnectionValue_064ccc3b9640bdb2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>), TypeInfoPropertyName = "CreateMTLSAuthRequest_51566c61e55005f5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>?), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_ecbe3cafa4c6d279")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>?), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_1fdd3ab2d425e9fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>?), TypeInfoPropertyName = "EnvironmentVariableAuthConnectionValue_a6ccb8fc0ba4a327")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>?), TypeInfoPropertyName = "CreateMTLSAuthRequest_82674d0f616c655b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_1fb871508f067193")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_ab769caeb7eb4850")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider), TypeInfoPropertyName = "GetAgentResponseModelPhoneNumberDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.GetWhatsAppAccountResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetWhatsAppAccountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentTestFolderResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentTopicsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentTopicResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentsPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAnalyticsSummaryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAppointmentByConfirmationNumberParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAudioIsolationHistoryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AudioIsolationHistoryItemResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAudioNativeProjectSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetBookingPageSettingsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetBookingSlugStatusParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetChaptersResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChapterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetClientAppointmentsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetClientByPhoneParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConvAIDashboardSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChartsItem), TypeInfoPropertyName = "ChartsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType), TypeInfoPropertyName = "GetConvAIDashboardSettingsResponseModelChartDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConvAISettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LivekitStackType), TypeInfoPropertyName = "LivekitStackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationResponseModelStatus), TypeInfoPropertyName = "GetConversationResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VisitedAgentRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VisitedAgentRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationTagsPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationTagResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationUsersPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationUserResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationsPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentsItem2), TypeInfoPropertyName = "AgentsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType), TypeInfoPropertyName = "GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentBranchInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseFileResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseDocumentMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DocumentUsageModeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseFolderResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseListResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DocumentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DocumentsItem), TypeInfoPropertyName = "DocumentsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType), TypeInfoPropertyName = "GetKnowledgeBaseListResponseModelDocumentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAgentsItem), TypeInfoPropertyName = "DependentAgentsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType), TypeInfoPropertyName = "GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAgentsItem2), TypeInfoPropertyName = "DependentAgentsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType), TypeInfoPropertyName = "GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAgentsItem3), TypeInfoPropertyName = "DependentAgentsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType), TypeInfoPropertyName = "GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAgentsItem4), TypeInfoPropertyName = "DependentAgentsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType), TypeInfoPropertyName = "GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseTextResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseURLResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetLibraryVoicesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LibraryVoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LibraryVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetLiveCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberInboundSIPTrunkConfigResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPMediaEncryptionEnum), TypeInfoPropertyName = "SIPMediaEncryptionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberOutboundSIPTrunkConfigResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPTrunkTransportEnum), TypeInfoPropertyName = "SIPTrunkTransportEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberAgentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetProjectsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ProjectResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>), TypeInfoPropertyName = "AnyOfPronunciationDictionaryAliasRuleResponseModelPronunciationDictionaryPhonemeRuleResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetResponseUnitTestResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestFromConversationMetadataOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetSIPLogMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SIPLogMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPLogMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetScheduleParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetSecretDependenciesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>), TypeInfoPropertyName = "AnyOfIListDependenciesVariant1ItemIListDependenciesVariant2ItemIListDependentPhoneNumberIdentifier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependenciesVariant1Item), TypeInfoPropertyName = "DependenciesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType), TypeInfoPropertyName = "GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependenciesVariant2Item), TypeInfoPropertyName = "DependenciesVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType), TypeInfoPropertyName = "GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetSimulationTestResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetSpeechHistoryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SpeechHistoryItemResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechHistoryItemResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetTestInvocationsPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListResponseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TestInvocationSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestInvocationSummaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetTestSuiteInvocationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestRunResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestRunResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetTestsPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestSummaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetTestsSummariesByIdsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.UnitTestSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetToolCallUnitTestResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestToolCallEvaluationModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetToolDependentAgentsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentsItem3), TypeInfoPropertyName = "AgentsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminatorType), TypeInfoPropertyName = "GetToolDependentAgentsResponseModelAgentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetToolExecutionsPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolExecutionResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolExecutionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetVoicesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetVoicesV2ResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetWorkspaceSecretsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptInjectionGuardrail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ModerationGuardrailInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ModerationGuardrailOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HistoryAlignmentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HistoryAlignmentsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HttpRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UrlModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Icon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageAnalysisStatus), TypeInfoPropertyName = "ImageAnalysisStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ImageSubject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageSubject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPTrunkCredentialsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.IntegrationType), TypeInfoPropertyName = "IntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DiscountResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InvoiceResponseModelPaymentIntentStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse), TypeInfoPropertyName = "InvoiceResponseModelPaymentIntentStatusse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseContentSearchResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseContentSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseContentSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Document), TypeInfoPropertyName = "Document2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminatorType), TypeInfoPropertyName = "KnowledgeBaseContentSearchResultDocumentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SearchHighlightSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SearchHighlightSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseDependentType), TypeInfoPropertyName = "KnowledgeBaseDependentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseDocumentChunksResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseDocumentType), TypeInfoPropertyName = "KnowledgeBaseDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseRagToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseRagToolStatus), TypeInfoPropertyName = "KnowledgeBaseRagToolStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseSortBy), TypeInfoPropertyName = "KnowledgeBaseSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseSourceFileUrlResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Data), TypeInfoPropertyName = "Data2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType), TypeInfoPropertyName = "KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMDeprecationConfigModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMDeprecationInfoModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMInfoModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LLMReasoningEffort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMReasoningEffort), TypeInfoPropertyName = "LLMReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RegionalProcessingSurchargeInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMInfoModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMInputOutputTokensUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMTokensCategoryUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMListResponseModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LLMInfoModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMListResponseModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LLMInfoModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMLiteralJsonSchemaPropertyType), TypeInfoPropertyName = "LLMLiteralJsonSchemaPropertyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMParameterEvaluationStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LLMInputOutputTokensUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMUsageCalculatorLLMResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMUsageCalculatorPublicRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMUsageCalculatorRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMUsageCalculatorResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguageAddedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguageDetectionToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguagePresetTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LeaveMessageParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LibraryVoiceResponseModelCategory), TypeInfoPropertyName = "LibraryVoiceResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VerifiedVoiceLanguageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAgentRulesParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAssetsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAuthConnectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AuthConnectionsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionsItem), TypeInfoPropertyName = "AuthConnectionsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2ClientCredsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2JWTResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PrivateKeyJWTResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MTLSAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType), TypeInfoPropertyName = "ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListCalendarEventsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListClientInteractionsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListClientsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListGroupSessionsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListHolidaysParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListLocationsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListMCPToolsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListProductsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListResponseAgentBranchSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentBranchSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListResponseApiIntegrationDocResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ApiIntegrationDocResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListServicesParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListSpeechEnginesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SpeechEngineSummaryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechEngineSummaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListStaffParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListTestsByIdsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListWhatsAppAccountsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LiteralJsonSchemaPropertyType), TypeInfoPropertyName = "LiteralJsonSchemaPropertyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPApprovalPolicy), TypeInfoPropertyName = "MCPApprovalPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPApprovalPolicyUpdateRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolApprovalHash>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolApprovalHash))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerTransport), TypeInfoPropertyName = "MCPServerTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>), TypeInfoPropertyName = "AnyOfConvAISecretLocatorConvAIUserSecretDBModelObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>), TypeInfoPropertyName = "AnyOfAuthConnectionLocatorEnvironmentAuthConnectionLocatorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverrideInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverrideOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerConfigUpdateRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAgentsItem5), TypeInfoPropertyName = "DependentAgentsItem52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminatorType), TypeInfoPropertyName = "MCPServerResponseModelDependentAgentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServersResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.MCPServerResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolAddApprovalRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolApprovalPolicy), TypeInfoPropertyName = "MCPToolApprovalPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InputOverridesVariant1), TypeInfoPropertyName = "InputOverridesVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource), TypeInfoPropertyName = "MCPToolConfigInputInputOverridesDiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InputOverridesVariant12), TypeInfoPropertyName = "InputOverridesVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource), TypeInfoPropertyName = "MCPToolConfigOutputInputOverridesDiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InputOverridesVariant13), TypeInfoPropertyName = "InputOverridesVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminatorSource), TypeInfoPropertyName = "MCPToolConfigOverrideInputInputOverridesDiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolResponseMockConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InputOverridesVariant14), TypeInfoPropertyName = "InputOverridesVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource), TypeInfoPropertyName = "MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolResponseMockConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideCreateRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InputOverridesVariant15), TypeInfoPropertyName = "InputOverridesVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource), TypeInfoPropertyName = "MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InputOverridesVariant16), TypeInfoPropertyName = "InputOverridesVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource), TypeInfoPropertyName = "MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ManualSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ManualVerificationFileResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ManualVerificationFileResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MatchAnythingParameterEvaluationStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MemoryEntrySearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource, object>), TypeInfoPropertyName = "AnyOfConversationSourceManualSourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MessageSearchSortBy), TypeInfoPropertyName = "MessageSearchSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MessagesSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.MessagesSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MessagesSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MetricType), TypeInfoPropertyName = "MetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MockNoMatchBehavior), TypeInfoPropertyName = "MockNoMatchBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MockingStrategy), TypeInfoPropertyName = "MockingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ModelRatesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ModelResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LanguageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ModerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ThresholdGuardrail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Monitor), TypeInfoPropertyName = "Monitor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MultichannelSpeechToTextResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextChunkResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextChunkResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MultipartMusicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicExploreSongSourceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SongSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SongSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.NoCoachingSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.NonStreamingOutputFormats), TypeInfoPropertyName = "NonStreamingOutputFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2JWTResponseAlgorithm), TypeInfoPropertyName = "OAuth2JWTResponseAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2JWTResponseTokenResponseField), TypeInfoPropertyName = "OAuth2JWTResponseTokenResponseField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RequiredConstraints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrbAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchConvAIDashboardSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChartsItem2), TypeInfoPropertyName = "ChartsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType), TypeInfoPropertyName = "PatchConvAIDashboardSettingsRequestChartDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchConvAISettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchConversationTagRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchWorkspaceSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchWorkspaceWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingBlocksMetadataModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingClipTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingClipTaskType), TypeInfoPropertyName = "PendingClipTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingExternalAudiosMetadataModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier), TypeInfoPropertyName = "PendingSubscriptionSwitchResponseModelNextTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomSipHeadersItem), TypeInfoPropertyName = "CustomSipHeadersItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType), TypeInfoPropertyName = "PhoneNumberTransferCustomSipHeaderDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferDestination), TypeInfoPropertyName = "TransferDestination2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPUriTransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPUriDynamicVariableTransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminatorType), TypeInfoPropertyName = "PhoneNumberTransferTransferDestinationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferTypeEnum), TypeInfoPropertyName = "TransferTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostDialDigitsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostDialDigitsStatic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostDialDigitsDynamicVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType), TypeInfoPropertyName = "PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PlayDTMFToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastBulletinModeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastConversationModeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PositionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PositionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostAgentAvatarResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostWorkspaceSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostWorkspaceSecretResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PrivateKeyJWTResponseAlgorithm), TypeInfoPropertyName = "PrivateKeyJWTResponseAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProcedureCompilerMode), TypeInfoPropertyName = "ProcedureCompilerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProcedureRefResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProcedureSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectCreationMetaResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectCreationMetaResponseModelStatus), TypeInfoPropertyName = "ProjectCreationMetaResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectCreationMetaResponseModelType), TypeInfoPropertyName = "ProjectCreationMetaResponseModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelTargetAudience2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelState), TypeInfoPropertyName = "ProjectExtendedResponseModelState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelAccessLevel), TypeInfoPropertyName = "ProjectExtendedResponseModelAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelFiction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelSourceType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.CaptionStyleModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelAspectRatio2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioAgentSettingsModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryVersionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryLocatorResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization), TypeInfoPropertyName = "ProjectExtendedResponseModelApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>), TypeInfoPropertyName = "AnyOfProjectVideoResponseModelProjectExternalAudioResponseModelProjectImageResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectVideoResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExternalAudioResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectImageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SourceContextVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SongSourceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SfxSourceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType), TypeInfoPropertyName = "ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectMutedTracksResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelTargetAudience2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelState), TypeInfoPropertyName = "ProjectResponseModelState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelAccessLevel), TypeInfoPropertyName = "ProjectResponseModelAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelFiction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelSourceType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelAspectRatio2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectSnapshotExtendedResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectSnapshotResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectSnapshotsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ProjectSnapshotResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RagConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackupLlmConfig), TypeInfoPropertyName = "BackupLlmConfig2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference), TypeInfoPropertyName = "PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem3), TypeInfoPropertyName = "ToolsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SMBToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminatorType), TypeInfoPropertyName = "PromptAgentAPIModelInputToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackupLlmConfig2), TypeInfoPropertyName = "BackupLlmConfig22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference), TypeInfoPropertyName = "PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem4), TypeInfoPropertyName = "ToolsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType), TypeInfoPropertyName = "PromptAgentAPIModelOutputToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RagConfigWorkflowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>), TypeInfoPropertyName = "AnyOfBackupLLMDefaultBackupLLMDisabledBackupLLMOverrideObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsVariant1Item), TypeInfoPropertyName = "ToolsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsVariant1Item2), TypeInfoPropertyName = "ToolsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryRulesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.QueryParamsJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RAGDocumentIndexResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RAGIndexStatus), TypeInfoPropertyName = "RAGIndexStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RAGDocumentIndexUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RAGDocumentIndexesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.RAGDocumentIndexResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RAGIndexBatchSuccessfulResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RAGIndexOverviewResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RAGIndexRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RagChunkMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.RagChunkMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReaderResourceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType), TypeInfoPropertyName = "ReaderResourceResponseModelResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RecordingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioClipReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReferencedToolCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReferencedToolCommonModelType), TypeInfoPropertyName = "ReferencedToolCommonModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RegexParameterEvaluationStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TwilioRegionId), TypeInfoPropertyName = "TwilioRegionId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TwilioEdgeLocation), TypeInfoPropertyName = "TwilioEdgeLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RegisterForGroupSessionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RenderStatus), TypeInfoPropertyName = "RenderStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReportKnowledgeGapParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RequestPVCManualVerificationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RequiredConstraint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.RequiredConstraint>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ElevenLabs.JsonConverters.ASRInputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRInputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRQualityJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRQualityNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTestEntityTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTestEntityTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTrustContextJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTrustContextNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AllowedOutputFormatsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AllowedOutputFormatsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisScopeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AssetTranscriptionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AssetTranscriptionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicPresetIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicPresetIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicSourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicSourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallRecipientStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallRecipientStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BillingPeriodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BillingPeriodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchProtectionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchProtectionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BreakdownTypesJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BreakdownTypesNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CharacterRefreshPeriodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CharacterRefreshPeriodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChatSourceMediumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChatSourceMediumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClientEventJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClientEventNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationExitEffectJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationExitEffectNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnFilterOperationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnFilterOperationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnUnitJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnUnitNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConfigEntityTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConfigEntityTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationFeedbackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationFeedbackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationInitiationSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationInitiationSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationTokenPurposeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationTokenPurposeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CurrencyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CurrencyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomLLMAPITypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomLLMAPITypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentUsageModeEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentUsageModeEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbedVariantJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbedVariantNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.FineTuningResponseModelState2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.FineTuningResponseModelState2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GenesysRegionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GenesysRegionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ImageAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ImageAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.IntegrationTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.IntegrationTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LlmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LlmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMReasoningEffortJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMReasoningEffortNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LivekitStackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LivekitStackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPApprovalPolicyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPApprovalPolicyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerTransportJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerTransportNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MessageSearchSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MessageSearchSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MetricTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MetricTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockNoMatchBehaviorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockNoMatchBehaviorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockingStrategyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockingStrategyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MonitorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MonitorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuthConnectionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuthConnectionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingClipTaskTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingClipTaskTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PermissionTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PermissionTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PreToolSpeechModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PreToolSpeechModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProcedureCompilerModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProcedureCompilerModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.QualityPresetTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.QualityPresetTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RAGIndexStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RAGIndexStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverride2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverride2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResponseFilterModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResponseFilterModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPLogMessageDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPLogMessageDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SafetyRuleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SafetyRuleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SeatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SeatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SingleUseTokenTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SingleUseTokenTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SortDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SortDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpellingPatienceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpellingPatienceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SubscriptionStatusTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SubscriptionStatusTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSModelFamilyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSModelFamilyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestSharingModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestSharingModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextNormalisationTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextNormalisationTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolErrorHandlingModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolErrorHandlingModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionTaskSupport2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionTaskSupport2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeFilterJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeFilterNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferTypeEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferTypeEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnEagernessJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnEagernessNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioEdgeLocationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioEdgeLocationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioRegionIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioRegionIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsageAggregationIntervalJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsageAggregationIntervalNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UserFeedbackScoreJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UserFeedbackScoreNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsersSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsersSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VideoAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VideoAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookEventTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookEventTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookTranscriptFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookTranscriptFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookUsageTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookUsageTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetExpandableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetExpandableNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetFeedbackModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetFeedbackModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetPlacementJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetPlacementNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsDubbingStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsDubbingStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsOrderDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsOrderDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLLMNodeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NodesJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Nodes2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SchemaOverridesVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.McpServersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TemplateParamsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerActionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerAction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.McpServersItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneCallVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResultVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResultVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolDetailsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolDetailsVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerAction3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableNestedValueTypeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableNestedValueTypeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableValueTypeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableValueTypeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumbersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChartsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependenciesVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependenciesVariant2ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DataJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem5JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant14JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant15JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant16JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChartsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestinationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SourceContextVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackupLlmConfigJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackupLlmConfig2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsVariant1Item2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ParamsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Params2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Params3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallDetailsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolConfigJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolConfig2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchInfoVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestInfoVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvalJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ParametersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ForwardConditionVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackwardConditionVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ForwardConditionVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackwardConditionVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestination2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestination3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StepsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StepsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAIDynamicVariable>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource, object>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.DateTime?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.DubbingTranscriptResponseModel, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_d0a2296ac97d65c5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_ceb57c07b09954cf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_c9c7ec7498b2853d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_14e725276612e2f7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>), TypeInfoPropertyName = "EnvironmentVariableAuthConnectionValue_064ccc3b9640bdb2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>), TypeInfoPropertyName = "CreateMTLSAuthRequest_51566c61e55005f5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>?), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_ecbe3cafa4c6d279")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>?), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_1fdd3ab2d425e9fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>?), TypeInfoPropertyName = "EnvironmentVariableAuthConnectionValue_a6ccb8fc0ba4a327")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>?), TypeInfoPropertyName = "CreateMTLSAuthRequest_82674d0f616c655b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_1fb871508f067193")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_ab769caeb7eb4850")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResourceAccessInfoRole), TypeInfoPropertyName = "ResourceAccessInfoRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResourceAccessInfoAnonymousAccessLevelOverride2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResourceMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ShareOptionResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ShareOptionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResponseFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResponseUnitTestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResubmitTestsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReviewResponseModelReviewStatus), TypeInfoPropertyName = "ReviewResponseModelReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item), TypeInfoPropertyName = "ReviewResponseModelRejectReasonsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RunAgentTestsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SingleTestRunRequestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SingleTestRunRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPLogMessageDirection), TypeInfoPropertyName = "SIPLogMessageDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPTrunkOutboundCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Params), TypeInfoPropertyName = "Params2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SearchClientsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateClientParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateStaffParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAssetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateServiceParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateProductParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ScheduleGroupSessionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateGroupSessionSeatsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateCalendarEventParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAgentRuleParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateHolidayParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateBusinessInfoParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateCustomerFacingConfigParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateBookingPageSettingsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SetBookingSlugParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateLocationParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SMBToolConfigParamsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType), TypeInfoPropertyName = "SMBToolConfigParamsDiscriminatorSmbToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SMSConversationInfoDirection), TypeInfoPropertyName = "SMSConversationInfoDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SafetyCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SafetyEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SafetyRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SafetyRule), TypeInfoPropertyName = "SafetyRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SampleConfigDBModelParentType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SampleResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerSeparationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SayNodeLiteralMessageInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SayNodeLiteralMessageOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SayNodePromptMessageInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SayNodePromptMessageOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SecretDependencyResourceType), TypeInfoPropertyName = "SecretDependencyResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SectionSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TimeRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentDubResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentMigrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentTranscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentTranslationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ShareOptionResponseModelType), TypeInfoPropertyName = "ShareOptionResponseModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SimilarVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceCategory), TypeInfoPropertyName = "VoiceCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SimilarVoicesForSpeakerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SimilarVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SimulationTestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SingleUseTokenResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SingleUseTokenType), TypeInfoPropertyName = "SingleUseTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SkipTurnToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SoftTimeoutConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SoftTimeoutConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SoftTimeoutConfigOverrideConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SoftTimeoutConfigWorkflowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SortDirection), TypeInfoPropertyName = "SortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerAudioResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerCreatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.UtteranceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UtteranceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbedSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus), TypeInfoPropertyName = "SpeakerSeparationResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerUpdatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>), TypeInfoPropertyName = "AnyOfStringConvAISecretLocatorConvAIDynamicVariable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechEngineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechHistoryItemResponseModelVoiceCategory2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechHistoryItemResponseModelState), TypeInfoPropertyName = "SpeechHistoryItemResponseModelState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechHistoryItemResponseModelSource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInputResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextCharacterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextWordResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextWordResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AdditionalFormatResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DetectedEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextWordResponseModelType), TypeInfoPropertyName = "SpeechToTextWordResponseModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextCharacterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StartPVCVoiceTrainingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StartSpeakerSeparationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StreamingAudioChunkWithTimestampsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.StudioAgentToolSettingsModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioAgentToolSettingsModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioClipReferenceClipType), TypeInfoPropertyName = "StudioClipReferenceClipType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SubscriptionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SuggestedAudioTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SupportedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSModelFamily))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Params2), TypeInfoPropertyName = "Params22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToNumberToolConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoicemailDetectionToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SystemToolConfigInputParamsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType), TypeInfoPropertyName = "SystemToolConfigInputParamsDiscriminatorSystemToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Params3), TypeInfoPropertyName = "Params32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToNumberToolConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SystemToolConfigOutputParamsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType), TypeInfoPropertyName = "SystemToolConfigOutputParamsDiscriminatorSystemToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSConversationalModel), TypeInfoPropertyName = "TTSConversationalModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SupportedVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SuggestedAudioTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSOutputFormat), TypeInfoPropertyName = "TTSOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextNormalisationType), TypeInfoPropertyName = "TextNormalisationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestConditionRationaleCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestConditionResultCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestRunMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestRunMetadataTestType), TypeInfoPropertyName = "TestRunMetadataTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestRunStatus), TypeInfoPropertyName = "TestRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestSharingMode), TypeInfoPropertyName = "TestSharingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestType), TypeInfoPropertyName = "TestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToDialogueSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TokenResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.Icon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolAnnotations2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolExecution2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolCallUnitTestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolExecutionTaskSupport2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolCallDetailsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType), TypeInfoPropertyName = "ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolConfig), TypeInfoPropertyName = "ToolConfig2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolRequestModelToolConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType), TypeInfoPropertyName = "ToolRequestModelToolConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestToolCallParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestToolCallParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolConfig2), TypeInfoPropertyName = "ToolConfig22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolResponseModelToolConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType), TypeInfoPropertyName = "ToolResponseModelToolConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolUsageStatsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolSortBy), TypeInfoPropertyName = "ToolSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolTypeFilter), TypeInfoPropertyName = "ToolTypeFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferBranchInfoDefaultingToMain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferBranchInfoTrafficSplit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BranchInfoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason), TypeInfoPropertyName = "TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnModel), TypeInfoPropertyName = "TurnModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TwilioOutboundCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.URLAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestInfoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType), TypeInfoPropertyName = "UnitTestRunResponseModelTestInfoVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestWorkflowNodeTransitionEvaluationNodeId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Eval), TypeInfoPropertyName = "Eval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType), TypeInfoPropertyName = "UnitTestToolCallParameterEvalDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateEnvironmentVariableRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest, object>), TypeInfoPropertyName = "AnyOfStringEnvironmentVariableSecretValueRequestEnvironmentVariableAuthConnectionValueRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateResponseUnitTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateSimulationTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateSpeechEngineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateToolCallUnitTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateWhatsAppAccountRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateWorkspaceMemberResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UsageAggregationInterval), TypeInfoPropertyName = "UsageAggregationInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UsageCharactersResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UserResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UsersSortBy), TypeInfoPropertyName = "UsersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VerifyPVCVoiceCaptchaResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoAnalysisStatus), TypeInfoPropertyName = "VideoAnalysisStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VideoSubject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoSubject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VideoSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VideoKeyMoment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoKeyMoment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceDesignRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceDesignRequestModelModelId), TypeInfoPropertyName = "VoiceDesignRequestModelModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoicePreviewResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoicePreviewsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoicePreviewsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VoicePreviewResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceRemixRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SampleResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelCategory), TypeInfoPropertyName = "VoiceResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelSafetyControl2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceVerificationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSamplePreviewResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSampleVisualWaveformResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingModerationCheckResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelStatus), TypeInfoPropertyName = "VoiceSharingResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelCategory), TypeInfoPropertyName = "VoiceSharingResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus), TypeInfoPropertyName = "VoiceSharingResponseModelReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ReaderResourceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookAuthMethodType), TypeInfoPropertyName = "WebhookAuthMethodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod), TypeInfoPropertyName = "WebhookToolApiSchemaConfigInputMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInputContentType), TypeInfoPropertyName = "WebhookToolApiSchemaConfigInputContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod), TypeInfoPropertyName = "WebhookToolApiSchemaConfigOutputMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutputContentType), TypeInfoPropertyName = "WebhookToolApiSchemaConfigOutputContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookUsageType), TypeInfoPropertyName = "WebhookUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppConversationInfoDirection), TypeInfoPropertyName = "WhatsAppConversationInfoDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppOutboundCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppOutboundMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateTextParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateTextParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateDocumentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateDocumentParamDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ParametersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ParametersItem), TypeInfoPropertyName = "ParametersItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateImageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateLocationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType), TypeInfoPropertyName = "WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateImageParamDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateLocationParamDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetPlacement), TypeInfoPropertyName = "WidgetPlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetExpandable), TypeInfoPropertyName = "WidgetExpandable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>), TypeInfoPropertyName = "AnyOfOrbAvatarURLAvatarImageAvatar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetFeedbackMode), TypeInfoPropertyName = "WidgetFeedbackMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetEndFeedbackConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetConfigInputSyntaxHighlightTheme2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetTextContents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetStyles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WidgetLanguagePreset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetLanguagePreset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetConfigOutputSyntaxHighlightTheme2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetConfigResponseModelSyntaxHighlightTheme2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WidgetLanguagePresetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetLanguagePresetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetEndFeedbackType), TypeInfoPropertyName = "WidgetEndFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetTermsTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ForwardConditionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowUnconditionalModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowLLMConditionModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowResultConditionModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowExpressionConditionModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType), TypeInfoPropertyName = "WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackwardConditionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType), TypeInfoPropertyName = "WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ForwardConditionVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowUnconditionalModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowLLMConditionModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowResultConditionModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowExpressionConditionModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType), TypeInfoPropertyName = "WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackwardConditionVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType), TypeInfoPropertyName = "WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomSipHeadersItem2), TypeInfoPropertyName = "CustomSipHeadersItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType), TypeInfoPropertyName = "WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferDestination2), TypeInfoPropertyName = "TransferDestination22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType), TypeInfoPropertyName = "WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostDialDigitsVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType), TypeInfoPropertyName = "WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomSipHeadersItem3), TypeInfoPropertyName = "CustomSipHeadersItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType), TypeInfoPropertyName = "WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferDestination3), TypeInfoPropertyName = "TransferDestination32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType), TypeInfoPropertyName = "WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostDialDigitsVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType), TypeInfoPropertyName = "WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolEdgeStepModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkflowToolLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StepsItem), TypeInfoPropertyName = "StepsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType), TypeInfoPropertyName = "WorkflowToolResponseModelInputStepDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StepsItem2), TypeInfoPropertyName = "StepsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType), TypeInfoPropertyName = "WorkflowToolResponseModelOutputStepDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType), TypeInfoPropertyName = "WorkspaceAnalyticsQueryResponseModelColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?, object>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBooleanDateTimeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ColumnUnit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceApiKeyListResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceApiKeyResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceApiKeyResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceAuditLogEntryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceAuditLogsPageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAuditLogEntryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceBatchCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.BatchCallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceCreateApiKeyResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceCreateWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceGroupByNameResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceGroupPermission), TypeInfoPropertyName = "WorkspaceGroupPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, string, object>), TypeInfoPropertyName = "AnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceServiceAccountListResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceServiceAccountResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceServiceAccountResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceWebhookListResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceWebhookUsageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerationNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>), TypeInfoPropertyName = "AnyOfCreateResponseUnitTestRequestCreateToolCallUnitTestRequestCreateSimulationTestRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>), TypeInfoPropertyName = "AnyOfUpdateResponseUnitTestRequestUpdateToolCallUnitTestRequestUpdateSimulationTestRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>), TypeInfoPropertyName = "AnyOfCreateTwilioPhoneNumberRequestCreateSIPTrunkPhoneNumberRequestV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateEnvironmentVariableRequest), TypeInfoPropertyName = "CreateEnvironmentVariableRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType), TypeInfoPropertyName = "CreateEnvironmentVariableRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetSpeechHistorySortDirection2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetSpeechHistorySource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechFullOutputFormat), TypeInfoPropertyName = "TextToSpeechFullOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat), TypeInfoPropertyName = "TextToSpeechFullWithTimestampsOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechStreamOutputFormat), TypeInfoPropertyName = "TextToSpeechStreamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat), TypeInfoPropertyName = "TextToSpeechStreamWithTimestampsOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>), TypeInfoPropertyName = "AnyOfNonStreamingOutputFormatsAllowedOutputFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat), TypeInfoPropertyName = "SpeechToSpeechFullOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat), TypeInfoPropertyName = "SpeechToSpeechStreamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsDubbingStatus), TypeInfoPropertyName = "ListDubsDubbingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsFilterByCreator), TypeInfoPropertyName = "ListDubsFilterByCreator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsOrderDirection), TypeInfoPropertyName = "ListDubsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType), TypeInfoPropertyName = "GetDubbedTranscriptFileFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType), TypeInfoPropertyName = "GetDubbingTranscriptsFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataSort2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TestType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListChatResponseTestsRouteSortMode), TypeInfoPropertyName = "ListChatResponseTestsRouteSortMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationHistoriesRouteSummaryMode), TypeInfoPropertyName = "GetConversationHistoriesRouteSummaryMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item), TypeInfoPropertyName = "GetConversationHistoriesRouteExcludeStatusesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode), TypeInfoPropertyName = "TextSearchConversationMessagesRouteSummaryMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolTypeFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListEnvironmentVariablesType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DownloadSpeechHistoryItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.DubbingTranscriptResponseModel, string>), TypeInfoPropertyName = "AnyOfDubbingTranscriptResponseModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ModelResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionResponse), TypeInfoPropertyName = "CreateAuthConnectionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType), TypeInfoPropertyName = "CreateAuthConnectionResponseDiscriminatorAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkspaceGroupResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupByNameResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>), TypeInfoPropertyName = "AnyOfSpeechToTextChunkResponseModelMultichannelSpeechToTextResponseModelSpeechToTextWebhookResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>), TypeInfoPropertyName = "AnyOfSpeechToTextChunkResponseModelMultichannelSpeechToTextResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentSummariesRouteResponse2), TypeInfoPropertyName = "GetAgentSummariesRouteResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminatorStatus), TypeInfoPropertyName = "GetAgentSummariesRouteResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentResponseTestRouteResponse), TypeInfoPropertyName = "GetAgentResponseTestRouteResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType), TypeInfoPropertyName = "GetAgentResponseTestRouteResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAgentResponseTestRouteResponse), TypeInfoPropertyName = "UpdateAgentResponseTestRouteResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType), TypeInfoPropertyName = "UpdateAgentResponseTestRouteResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListPhoneNumbersRouteResponseItem), TypeInfoPropertyName = "ListPhoneNumbersRouteResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider), TypeInfoPropertyName = "ListPhoneNumbersRouteResponseItemDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberRouteResponse), TypeInfoPropertyName = "GetPhoneNumberRouteResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminatorProvider), TypeInfoPropertyName = "GetPhoneNumberRouteResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdatePhoneNumberRouteResponse), TypeInfoPropertyName = "UpdatePhoneNumberRouteResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminatorProvider), TypeInfoPropertyName = "UpdatePhoneNumberRouteResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponse2), TypeInfoPropertyName = "GetAgentKnowledgeBaseSummariesRouteResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus), TypeInfoPropertyName = "GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateDocumentRouteResponse), TypeInfoPropertyName = "UpdateDocumentRouteResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateDocumentRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType), TypeInfoPropertyName = "UpdateDocumentRouteResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponse), TypeInfoPropertyName = "GetDocumentationFromKnowledgeBaseResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType), TypeInfoPropertyName = "GetDocumentationFromKnowledgeBaseResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateFileDocumentRouteResponse), TypeInfoPropertyName = "UpdateFileDocumentRouteResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminatorType), TypeInfoPropertyName = "UpdateFileDocumentRouteResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetOrCreateRagIndexesResponse2), TypeInfoPropertyName = "GetOrCreateRagIndexesResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus), TypeInfoPropertyName = "GetOrCreateRagIndexesResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RefreshUrlDocumentRouteResponse), TypeInfoPropertyName = "RefreshUrlDocumentRouteResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType), TypeInfoPropertyName = "RefreshUrlDocumentRouteResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ASTNodeInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ASTNodeOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ExportOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentVersionMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentDeploymentRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AttachedTestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AudioSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AudioKeyMoment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VoiceSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.McpServersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependentIntegrationConnectionIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AllowlistItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.Llm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OutboundCallRecipientResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.GetOrCreateRAGIndexRequestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ColumnFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TemplateParamsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PromptEvaluationCriteria>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OutboundCallRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DialogueInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.CharacterAlignmentModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterSnapshotResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VoiceStatisticsResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.McpServersItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SecretDependencyType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WebhookEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ClientEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DataCollectionResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ScopedAnalysisResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceRewardModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConfigEntityType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableUpdateCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceUsageModel>))]
    internal sealed partial class SourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ElevenLabs.JsonConverters.ASRInputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRInputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRQualityJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASRQualityNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTestEntityTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTestEntityTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTrustContextJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTrustContextNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AllowedOutputFormatsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AllowedOutputFormatsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnalysisScopeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AssetTranscriptionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AssetTranscriptionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicPresetIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicPresetIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicSourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackgroundMusicSourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallRecipientStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallRecipientStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BatchCallStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BillingPeriodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BillingPeriodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchProtectionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchProtectionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BreakdownTypesJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BreakdownTypesNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CharacterRefreshPeriodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CharacterRefreshPeriodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChatSourceMediumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChatSourceMediumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClientEventJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClientEventNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationExitEffectJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ClipAnimationExitEffectNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnFilterOperationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnFilterOperationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnUnitJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ColumnUnitNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConfigEntityTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConfigEntityTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationFeedbackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationFeedbackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationInitiationSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationInitiationSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationTokenPurposeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConversationTokenPurposeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CurrencyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CurrencyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomLLMAPITypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomLLMAPITypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentUsageModeEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentUsageModeEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbedVariantJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbedVariantNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EmbeddingModelEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.FineTuningResponseModelState2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.FineTuningResponseModelState2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GenesysRegionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GenesysRegionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ImageAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ImageAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.IntegrationTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.IntegrationTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LlmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LlmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMReasoningEffortJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LLMReasoningEffortNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LivekitStackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LivekitStackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPApprovalPolicyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPApprovalPolicyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerTransportJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPServerTransportNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MessageSearchSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MessageSearchSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MetricTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MetricTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockNoMatchBehaviorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockNoMatchBehaviorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockingStrategyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MockingStrategyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MonitorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MonitorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuthConnectionStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuthConnectionStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingClipTaskTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingClipTaskTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PermissionTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PermissionTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PreToolSpeechModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PreToolSpeechModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProcedureCompilerModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProcedureCompilerModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.QualityPresetTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.QualityPresetTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RAGIndexStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RAGIndexStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RenderType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverride2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverride2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResponseFilterModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResponseFilterModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPLogMessageDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPLogMessageDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SafetyRuleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SafetyRuleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SeatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SeatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SecretDependencyTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SingleUseTokenTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SingleUseTokenTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SortDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SortDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpellingPatienceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpellingPatienceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SubscriptionStatusTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SubscriptionStatusTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSModelFamilyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSModelFamilyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TelephonyProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestRunStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestSharingModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestSharingModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextNormalisationTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextNormalisationTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallSoundTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolErrorHandlingModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolErrorHandlingModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionTaskSupport2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionTaskSupport2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeFilterJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolTypeFilterNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferTypeEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferTypeEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnEagernessJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnEagernessNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TurnModelNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioEdgeLocationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioEdgeLocationNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioRegionIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TwilioRegionIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsageAggregationIntervalJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsageAggregationIntervalNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UserFeedbackScoreJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UserFeedbackScoreNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsersSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UsersSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VideoAnalysisStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VideoAnalysisStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookEventTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookEventTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookTranscriptFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookTranscriptFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookUsageTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WebhookUsageTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetExpandableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetExpandableNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetFeedbackModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetFeedbackModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetPlacementJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WidgetPlacementNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkspaceResourceTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetSpeechHistorySource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsDubbingStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsDubbingStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsOrderDirectionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListDubsOrderDirectionNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLLMNodeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNodeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NodesJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Nodes2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SchemaOverridesVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.McpServersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TemplateParamsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerActionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerAction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.McpServersItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneCallVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResultVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResultVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolDetailsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolDetailsVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerAction3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableNestedValueTypeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableNestedValueTypeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableValueTypeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DynamicVariableValueTypeOutputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumbersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChartsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependenciesVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependenciesVariant2ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DataJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem5JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant14JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant15JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant16JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChartsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestinationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SourceContextVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackupLlmConfigJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackupLlmConfig2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsVariant1Item2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ParamsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Params2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Params3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolCallDetailsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolConfigJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolConfig2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BranchInfoVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TestInfoVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.EvalJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ParametersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ForwardConditionVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackwardConditionVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ForwardConditionVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BackwardConditionVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestination2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestination3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StepsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.StepsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAIDynamicVariable>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource, object>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.DateTime?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.DubbingTranscriptResponseModel, string>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_d0a2296ac97d65c5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_ceb57c07b09954cf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_c9c7ec7498b2853d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_14e725276612e2f7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>), TypeInfoPropertyName = "EnvironmentVariableAuthConnectionValue_064ccc3b9640bdb2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>), TypeInfoPropertyName = "CreateMTLSAuthRequest_51566c61e55005f5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>?), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_ecbe3cafa4c6d279")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>?), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_1fdd3ab2d425e9fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>?), TypeInfoPropertyName = "EnvironmentVariableAuthConnectionValue_a6ccb8fc0ba4a327")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>?), TypeInfoPropertyName = "CreateMTLSAuthRequest_82674d0f616c655b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput_1fb871508f067193")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_ab769caeb7eb4850")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentSuccessfulResponseExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentFailureResponseExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.CustomGuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ReadMetadataChapterDBModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.Contributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SegmentSubtitleFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DubbingMetadataResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptCharacter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableNestedValueTypeInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.EnvironmentVariableResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VerificationAttemptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentWordResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.GetWhatsAppAccountResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentTopicResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AudioIsolationHistoryItemResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VisitedAgentRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationTagResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationUserResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependentBranchInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DocumentUsageModeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DocumentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LibraryVoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ProjectResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SIPLogMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SpeechHistoryItemResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TestInvocationSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.UnitTestRunResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.UnitTestSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolExecutionResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ImageSubject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DiscountResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseContentSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SearchHighlightSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LLMReasoningEffort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LLMInfoModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LLMInfoModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AuthConnectionsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentBranchSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ApiIntegrationDocResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SpeechEngineSummaryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.MCPToolApprovalHash>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverrideInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverrideOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.MCPServerResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ManualVerificationFileResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.MessagesSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LanguageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextChunkResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SongSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ProjectVoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ProjectSnapshotResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.RAGDocumentIndexResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.RagChunkMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.RequiredConstraint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ShareOptionResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SingleTestRunRequestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SafetyRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TimeRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SimilarVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.UtteranceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DialogueInputResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextWordResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AdditionalFormatResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DetectedEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextCharacterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SupportedVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SuggestedAudioTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.Icon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.UnitTestToolCallParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VideoSubject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VideoSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VideoKeyMoment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VoicePreviewResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SampleResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ReaderResourceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WhatsAppTemplateTextParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ParametersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkflowToolLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.StepsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.StepsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ColumnUnit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceApiKeyResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAuditLogEntryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.BatchCallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceServiceAccountResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TestType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolTypeFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ModelResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupByNameResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>))]
    internal sealed partial class SourceGenerationContextChunk4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default,

            SourceGenerationContextChunk2.Default,

            SourceGenerationContextChunk3.Default,

            SourceGenerationContextChunk4.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASRInputFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASRInputFormatNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASRProviderJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASRProviderNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASRQualityJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASRQualityNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentDefinitionSourceNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentSortByJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentSortByNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentTestEntityTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentTestEntityTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentTrustContextJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentTrustContextNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AllowedOutputFormatsJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AllowedOutputFormatsNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnalysisPropertyTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnalysisPropertyTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnalysisScopeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AssetTranscriptionStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AssetTranscriptionStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AudioAnalysisStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AudioAnalysisStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AuthorizationMethodJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AuthorizationMethodNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BackgroundMusicPresetIdJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BackgroundMusicPresetIdNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BackgroundMusicSourceTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BackgroundMusicSourceTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BatchCallRecipientStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BatchCallRecipientStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BatchCallStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BatchCallStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BillingPeriodJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BillingPeriodNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BranchProtectionStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BranchProtectionStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BreakdownTypesJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BreakdownTypesNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlign2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyle2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeight2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransform2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendMode2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubType2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ChapterResponseModelStateJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ChapterResponseModelStateNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CharacterRefreshPeriodJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CharacterRefreshPeriodNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ChatSourceMediumJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ChatSourceMediumNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ClientEventJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ClientEventNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ClipAnimationExitEffectJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ClipAnimationExitEffectNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ColumnFilterOperationJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ColumnFilterOperationNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ColumnUnitJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ColumnUnitNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConfigEntityTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConfigEntityTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationFeedbackTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationFeedbackTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationInitiationSourceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationInitiationSourceNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationTokenPurposeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ConversationTokenPurposeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CurrencyJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CurrencyNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CustomLLMAPITypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CustomLLMAPITypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayMode2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudience2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutType2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DocumentUsageModeEnumJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DocumentUsageModeEnumNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EmbedVariantJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EmbedVariantNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EmbeddingModelEnumJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EmbeddingModelEnumNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EvaluationSuccessResultNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.FineTuningResponseModelState2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.FineTuningResponseModelState2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GenesysRegionJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GenesysRegionNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GuardrailExecutionModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GuardrailExecutionModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ImageAnalysisStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ImageAnalysisStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.IntegrationTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.IntegrationTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.KnowledgeBaseSortByJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.KnowledgeBaseSortByNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LlmJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LlmNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LLMReasoningEffortJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LLMReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LivekitStackTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LivekitStackTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPApprovalPolicyJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPApprovalPolicyNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPServerTransportJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPServerTransportNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MessageSearchSortByJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MessageSearchSortByNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MetricTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MetricTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MockNoMatchBehaviorJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MockNoMatchBehaviorNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MockingStrategyJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MockingStrategyNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MonitorJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MonitorNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OAuthConnectionStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OAuthConnectionStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PendingClipTaskTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PendingClipTaskTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PermissionTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PermissionTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PreToolSpeechModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PreToolSpeechModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProcedureCompilerModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProcedureCompilerModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudience2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFiction2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceType2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatio2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudience2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectResponseModelStateJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectResponseModelStateNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectResponseModelFiction2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectResponseModelSourceType2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatio2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.QualityPresetTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.QualityPresetTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.RAGIndexStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.RAGIndexStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.RenderStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.RenderStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.RenderType2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.RenderType2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverride2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverride2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResponseFilterModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResponseFilterModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SIPLogMessageDirectionJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SIPLogMessageDirectionNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SafetyRuleJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SafetyRuleNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SeatTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SeatTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SecretDependencyTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SecretDependencyTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SingleUseTokenTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SingleUseTokenTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SortDirectionJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SortDirectionNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSource2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpellingPatienceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpellingPatienceNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.StudioClipReferenceClipTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SubscriptionStatusTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SubscriptionStatusTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TTSConversationalModelJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TTSConversationalModelNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TTSModelFamilyJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TTSModelFamilyNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TTSOutputFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TTSOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TelephonyDirectionJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TelephonyDirectionNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TelephonyProviderJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TelephonyProviderNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TestRunStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TestRunStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TestSharingModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TestSharingModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TestTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TestTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextNormalisationTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextNormalisationTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolCallSoundTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolCallSoundTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolErrorHandlingModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolErrorHandlingModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolExecutionTaskSupport2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolExecutionTaskSupport2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolExecutionModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolExecutionModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolSortByJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolSortByNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolTypeFilterJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolTypeFilterNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TransferTypeEnumJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TransferTypeEnumNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TurnEagernessJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TurnEagernessNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TurnModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TurnModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TurnModelJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TurnModelNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TwilioEdgeLocationJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TwilioEdgeLocationNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TwilioRegionIdJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TwilioRegionIdNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UsageAggregationIntervalJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UsageAggregationIntervalNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UserFeedbackScoreJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UserFeedbackScoreNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UsersSortByJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UsersSortByNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceCategoryJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceCategoryNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VideoAnalysisStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VideoAnalysisStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControl2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQuality2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatus2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookEventTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookEventTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookTranscriptFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookTranscriptFormatNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookUsageTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookUsageTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetExpandableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetExpandableNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetFeedbackModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetFeedbackModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetPlacementJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WidgetPlacementNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkspaceResourceTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WorkspaceResourceTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirection2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetSpeechHistorySource2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetSpeechHistorySource2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListDubsOrderDirectionJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListDubsOrderDirectionNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSort2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListEnvironmentVariablesType2NullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASTLLMNodeInputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASTNodeOutputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.NodesJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.Nodes2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SchemaOverridesVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.McpServersItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TemplateParamsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TriggerActionJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TriggerAction2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolsItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.McpServersItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneCallVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResultVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResultVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolDetailsVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolDetailsVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TriggerAction3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DynamicVariableNestedValueTypeInputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DynamicVariableNestedValueTypeOutputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DynamicVariableValueTypeInputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DynamicVariableValueTypeOutputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ExportOptionsJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneNumbersItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ChartsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentsItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DocumentsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAgentsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAgentsItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAgentsItem3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAgentsItem4JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependenciesVariant1ItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependenciesVariant2ItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentsItem3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DocumentJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DataJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AuthConnectionsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAgentsItem5JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InputOverridesVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InputOverridesVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InputOverridesVariant13JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InputOverridesVariant14JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InputOverridesVariant15JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InputOverridesVariant16JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ChartsItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CustomSipHeadersItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TransferDestinationJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PostDialDigitsVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SourceContextVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BackupLlmConfigJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolsItem3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BackupLlmConfig2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolsItem4JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolsVariant1ItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolsVariant1Item2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ParamsJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.Params2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.Params3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolCallDetailsVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolConfigJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolConfig2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BranchInfoVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TestInfoVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EvalJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ParametersItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ForwardConditionVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BackwardConditionVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ForwardConditionVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BackwardConditionVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CustomSipHeadersItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TransferDestination2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PostDialDigitsVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CustomSipHeadersItem3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TransferDestination3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PostDialDigitsVariant13JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.StepsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.StepsItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponse2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponse2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponse2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAIDynamicVariable>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.DateTime?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.DubbingTranscriptResponseModel, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}