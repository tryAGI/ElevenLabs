
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

            typeof(global::ElevenLabs.JsonConverters.ASTAdditionOperatorNodeInputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTAdditionOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTAdditionOperatorNodeInputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTAdditionOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTAdditionOperatorNodeOutputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTAdditionOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTAdditionOperatorNodeOutputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTAdditionOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTAndOperatorNodeInputChildrenItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTAndOperatorNodeInputChildrenItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTAndOperatorNodeOutputChildrenItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTAndOperatorNodeOutputChildrenItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTConditionalOperatorNodeInputConditionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTConditionalOperatorNodeInputConditionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTConditionalOperatorNodeOutputConditionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTConditionalOperatorNodeOutputConditionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTDivisionOperatorNodeInputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTDivisionOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTDivisionOperatorNodeInputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTDivisionOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTDivisionOperatorNodeOutputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTDivisionOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTDivisionOperatorNodeOutputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTDivisionOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTEqualsOperatorNodeInputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTEqualsOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTEqualsOperatorNodeInputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTEqualsOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTEqualsOperatorNodeOutputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTEqualsOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTEqualsOperatorNodeOutputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTEqualsOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOperatorNodeInputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOperatorNodeInputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOperatorNodeOutputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOperatorNodeOutputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeInputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOperatorNodeInputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOperatorNodeInputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOperatorNodeOutputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOperatorNodeOutputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTMultiplicationOperatorNodeInputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTMultiplicationOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTMultiplicationOperatorNodeInputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTMultiplicationOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTMultiplicationOperatorNodeOutputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTMultiplicationOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTMultiplicationOperatorNodeOutputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTMultiplicationOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNotEqualsOperatorNodeInputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNotEqualsOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNotEqualsOperatorNodeInputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNotEqualsOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNotEqualsOperatorNodeOutputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTNotEqualsOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTOrOperatorNodeInputChildrenItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTOrOperatorNodeInputChildrenItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTOrOperatorNodeOutputChildrenItemDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTOrOperatorNodeOutputChildrenItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTSubtractionOperatorNodeInputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTSubtractionOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTSubtractionOperatorNodeInputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTSubtractionOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTSubtractionOperatorNodeOutputLeftDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTSubtractionOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTSubtractionOperatorNodeOutputRightDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTSubtractionOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentDefinitionSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTestEntityTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentTestEntityTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AllowedOutputFormatsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AllowedOutputFormatsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthorizationMethodNullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostQualityPresetJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostQualityPresetNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostQualityPresetJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostQualityPresetNullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmNullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.DubbingModelJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DubbingModelNullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.ExtendedSubscriptionResponseModelCurrency2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExtendedSubscriptionResponseModelCurrency2NullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.IntegrationTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.IntegrationTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatus2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeNullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MergingStrategyJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MergingStrategyNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MessageSearchSortByJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MessageSearchSortByNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MetricTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.MetricTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmNullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelQualityPresetJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelQualityPresetNullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResponseFilterModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResponseFilterModeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SafetyRuleJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SafetyRuleNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SampleConfigDBModelParentType2NullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SeatTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SeatTypeNullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.SubscriptionResponseModelCurrency2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SubscriptionResponseModelCurrency2NullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeNullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.WorkflowExpressionConditionModelInputExpressionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowExpressionConditionModelInputExpressionDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowExpressionConditionModelOutputExpressionDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.WorkflowExpressionConditionModelOutputExpressionDiscriminatorTypeNullableJsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.LeftJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RightJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChildrenItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChildrenItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ConditionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TrueExpressionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.FalseExpressionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Condition2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TrueExpression2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.FalseExpression2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left5JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right5JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left6JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right6JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left7JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right7JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left8JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right8JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left9JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right9JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left10JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right10JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ASTLLMNodeInputJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left11JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right11JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left14JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right14JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left15JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right15JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left16JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right16JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left17JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right17JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left18JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right18JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChildrenItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChildrenItem4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left19JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right19JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Left20JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Right20JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.NodesJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Nodes2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SchemaOverridesVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.SchemaOverridesVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.McpServersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TemplateParamsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerActionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerAction2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneCallVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResultVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ResultVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolDetailsVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ToolDetailsVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TriggerAction3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ExportOptionsJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PhoneNumbersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChartsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DocumentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem4JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AgentsItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DataJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AuthConnectionsItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.DependentAgentsItem5JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant1JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant13JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant14JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.InputOverridesVariant15JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.ChartsItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItemJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestinationVariant1JsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.ExpressionJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.Expression2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItem2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestinationJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.PostDialDigitsVariant12JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.CustomSipHeadersItem3JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.TransferDestination2JsonConverter),

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

            typeof(global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponse2JsonConverter),

            typeof(global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseJsonConverter),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAIDynamicVariable>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAIDynamicVariable>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>),

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

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>),

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

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>),

            typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.LiteralOverride, global::ElevenLabs.ObjectOverrideInput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.LiteralOverride, global::ElevenLabs.ObjectOverrideOutput>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>),

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

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest>),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASRConversationalConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASRQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASRProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASRInputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASRConversationalConfigWorkflowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAdditionOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTStringNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNumberNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTBooleanNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLLMNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDynamicVariableNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTOrOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAndOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTSubtractionOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDivisionOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAdditionOperatorNodeInputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAdditionOperatorNodeInputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAdditionOperatorNodeInputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAdditionOperatorNodeInputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAdditionOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTStringNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNumberNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTBooleanNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLLMNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDynamicVariableNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTOrOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAndOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTEqualsOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTSubtractionOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDivisionOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAdditionOperatorNodeOutputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAdditionOperatorNodeOutputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAdditionOperatorNodeOutputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAdditionOperatorNodeOutputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChildrenItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChildrenItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAndOperatorNodeInputChildrenItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAndOperatorNodeInputChildrenItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChildrenItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChildrenItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAndOperatorNodeOutputChildrenItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTAndOperatorNodeOutputChildrenItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Condition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeInputConditionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeInputConditionDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TrueExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeInputTrueExpressionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FalseExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeInputFalseExpressionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Condition2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeOutputConditionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeOutputConditionDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TrueExpression2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeOutputTrueExpressionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FalseExpression2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeOutputFalseExpressionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDivisionOperatorNodeInputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDivisionOperatorNodeInputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDivisionOperatorNodeInputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDivisionOperatorNodeInputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDivisionOperatorNodeOutputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDivisionOperatorNodeOutputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDivisionOperatorNodeOutputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTDivisionOperatorNodeOutputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTEqualsOperatorNodeInputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTEqualsOperatorNodeInputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTEqualsOperatorNodeInputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTEqualsOperatorNodeInputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTEqualsOperatorNodeOutputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTEqualsOperatorNodeOutputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTEqualsOperatorNodeOutputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTEqualsOperatorNodeOutputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMLiteralJsonSchemaProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOperatorNodeInputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOperatorNodeInputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOperatorNodeInputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOperatorNodeInputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOperatorNodeOutputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOperatorNodeOutputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOperatorNodeOutputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOperatorNodeOutputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeInputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeInputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeInputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeInputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeOutputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeOutputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeOutputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChildrenItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChildrenItem3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTOrOperatorNodeInputChildrenItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTOrOperatorNodeInputChildrenItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChildrenItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChildrenItem4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTOrOperatorNodeOutputChildrenItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTOrOperatorNodeOutputChildrenItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTSubtractionOperatorNodeInputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTSubtractionOperatorNodeInputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTSubtractionOperatorNodeInputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTSubtractionOperatorNodeInputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Left20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTSubtractionOperatorNodeOutputLeftDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTSubtractionOperatorNodeOutputLeftDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Right20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTSubtractionOperatorNodeOutputRightDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASTSubtractionOperatorNodeOutputRightDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterWithContentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddKnowledgeBaseResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddVoiceIVCResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddWorkspaceGroupMemberResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddWorkspaceInviteResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AdditionalFormatResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ExportOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationalConfigAPIModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentPlatformSettingsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkflowRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentBranchBasicInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentBranchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BranchProtectionStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResourceAccessInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentVersionMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentVersionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentBranchSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentCallLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigAPIModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariablesConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigAPIModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigAPIModelWorkflowOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariablesConfigWorkflowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigAPIModelWorkflowOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigOverrideConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOverrideConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentDefinitionSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentDeploymentPercentageStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentDeploymentRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentDeploymentRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentDeploymentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentFailureResponseExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EvaluationSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LiteralJsonSchemaProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationClientDataConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkspaceOverridesInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentTestingSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GuardrailsV1Input))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PrivacyConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentPlatformSettingsResponseModel))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentSortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentSuccessfulResponseExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentSummaryBatchSuccessfulResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentSummaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentTestEntityType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentTestFolderPathSegmentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AttachedTestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AttachedTestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentVersionParents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Nodes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowStartNodeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEndNodeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowOverrideAgentNodeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolNodeModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkflowResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Nodes2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowStartNodeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEndNodeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolNodeModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationClientDataWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIWebhooks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AllowedOutputFormats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AllowlistItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuthConnectionStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependencies))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookOverridesInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SchemaOverridesVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConstantSchemaOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariableSchemaOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMSchemaOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LiteralOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.QueryOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ObjectOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAIDynamicVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIDynamicVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResponseFilterMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookOverridesOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SchemaOverridesVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ObjectOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookToolConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariableAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolCallSoundType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolCallSoundBehavior))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolErrorHandlingMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolExecutionMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ArrayJsonSchemaPropertyInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ObjectJsonSchemaPropertyInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ArrayJsonSchemaPropertyOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ObjectJsonSchemaPropertyOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AsyncConversationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AsyncConversationMetadataDeliveryStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioNativeCreateProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioNativeEditContentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioNativeProjectSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioWithTimestampsAndVoiceSegmentsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CharacterAlignmentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VoiceSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioWithTimestampsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableToolIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentUnknownToolIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.McpServersItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentUnknownMCPServerIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentIntegrationConnectionIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentIntegrationConnectionIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AllowlistItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthorizationMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AutoSyncInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackupLLMDefault))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackupLLMDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackupLLMOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.Llm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Llm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BasicAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchCallDetailedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TelephonyProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchCallWhatsAppParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchCallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TelephonyCallConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipientResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OutboundCallRecipientResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchCallRecipientStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchFailureResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BearerAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BillingPeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicV1MusicPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicV1MusicPostModelId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.GetOrCreateRAGIndexRequestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetOrCreateRAGIndexRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateAgentV1ConvaiAgentsCreatePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePvcVoiceV1VoicesPvcPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostQualityPreset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateUrlDocumentV1ConvaiKnowledgeBaseUrlPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoicePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateChapterV1StudioProjectsProjectIdChaptersPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateForcedAlignmentV1ForcedAlignmentPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastConversationMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastBulletinMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastTextSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastURLSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostQualityPreset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditPvcVoiceV1VoicesPvcVoiceIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPostModelId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyHandleAnOutboundCallViaSipTrunkV1ConvaiSipTrunkOutboundCallPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationClientDataRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SeatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyInviteUserV1WorkspaceInvitesAddPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TelephonyDirection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RenderType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TemplateParamsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TemplateParamsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateBodyComponentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateButtonComponentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySetRulesOnThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdSetRulesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceResourceType))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostModelId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, object, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.IList<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamChapterAudioV1StudioProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamComposedMusicV1MusicStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamComposedMusicV1MusicStreamPostModelId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OutboundCallRecipient))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DialogueInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ModelSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTranslatesAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdTranslatePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdatePvcVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateStudioProjectV1StudioProjectsProjectIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUploadFileV1ConvaiConversationsConversationIdFilesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUploadMusicV1MusicUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyVerifyPvcVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyVideoToMusicV1MusicVideoToMusicPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PermissionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueFullWithTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueStreamWithTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechFull))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechFullWithTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechStreamWithTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BreakdownTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BuiltInToolsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SystemToolConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BuiltInToolsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SystemToolConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BuiltInToolsWorkflowOverrideInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BuiltInToolsWorkflowOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CanvasPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleHorizontalPlacementModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelEnterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelExitType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleVerticalPlacementModelAlign))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleWordAnimationModelEnterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleWordAnimationModelExitType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentBlockInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentBlockInputModelSubType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentBlockResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterResponseModelState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterStatisticsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterSnapshotExtendedResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.CharacterAlignmentModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CharacterAlignmentModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterSnapshotResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterSnapshotsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChapterSnapshotResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VoiceStatisticsResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceStatisticsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterWithContentResponseModelState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CharacterRefreshPeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChatSourceMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CheckRentalAvailabilityParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CheckServiceAvailabilityParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClientEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClientToolConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClientToolConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClipAnimation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClipAnimationEnterEffect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClipAnimationExitEffect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CoachedAgentSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CoachingAgentSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConfigEntityType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?, double?, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentThresholdGuardrail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentGuardrailInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GuardrailExecutionMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TriggerAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EndCallTriggerAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RetryTriggerAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentGuardrailOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TriggerAction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContentThresholdGuardrailThreshold))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Contributor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIEnvVarLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIFileUploadResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAISecretLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIStoredSecretDependencies))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableAgentIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentUnknownAgentIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SecretDependencyType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SecretDependencyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentPhoneNumberIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIUserSecretDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WebhookEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationChargingCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMCategoryUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigWorkflowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationDeletionSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationFeedbackRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UserFeedbackScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationFeedbackType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DataCollectionResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DataCollectionResultCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EvaluationSuccessResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryBatchCallModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryElevenAssistantCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryErrorCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryFeedbackCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneCallVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryRagUsageCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FeaturesUsageCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppConversationInfo))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelInputRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UserFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationTurnMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RagRetrievalInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMUsageInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutputRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMUsageOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResultVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolDetailsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolDetailsVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationClientDataInternal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationSourceInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, double?, int?, bool?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationClientDataRequestOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationSignedUrlResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ToolMockConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolMockConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationSummaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationSummaryResponseModelStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationTokenDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationTokenPurpose))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAgentTestResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAssetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateBasicAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateClientAppointmentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateClientParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateCustomHeaderAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2ClientCredsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2JWTRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatePhoneNumberResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatePrivateKeyJWTRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateProductParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatePronunciationDictionaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateRentalBookingParams))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateStaffParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateStringEnvironmentVariableRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateToolCallUnitTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestToolCallEvaluationModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateTwilioPhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RegionConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailsConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailsConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TriggerAction3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.CustomGuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomHeaderAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomLLM))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomLLMAPIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomSIPHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomSIPHeaderWithDynamicVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DashboardCallSuccessChartModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DashboardCriteriaChartModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DashboardDataCollectionChartModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DefaultSharingGroupResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceGroupResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteAssetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteCalendarEventParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteClientParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteDubbingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteHistoryItemResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableAgentIdentifierAccessLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentBranchInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DetailedMusicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SongMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WordTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DetectedEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DialogueInputResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ReadMetadataChapterDBModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReadMetadataChapterDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReadLegalTerms))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.Contributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelPayoutType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PreviewAudioDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SampleConfigDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReviewResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DiscountResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DoDubbingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DocumentUsageModeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DocxExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbedSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SegmentSubtitleFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentSubtitleFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingMediaReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingMediaMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingMetadataPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingMetadataResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingModel))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, double?, int?, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditVoiceSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EmbedVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EmbeddingModelEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EndCallToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentAuthConnectionLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentVariableAuthConnectionValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentVariableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EnvironmentVariableResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExportOptionsDiscriminatorFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExtendedSubscriptionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExtendedSubscriptionResponseModelCurrency2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SubscriptionStatusType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InvoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingSubscriptionSwitchResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingCancellationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FeatureStatusCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowFeaturesUsageCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestsFeatureUsageCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FeedbackResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FineTuningResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.FineTuningResponseModelState2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FineTuningResponseModelState2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VerificationAttemptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VerificationAttemptResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ManualVerificationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FocusGuardrail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ForcedAlignmentCharacterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ForcedAlignmentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentWordResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ForcedAlignmentWordResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerationSourceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenesysRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentEmbedResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetConfigResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentKnowledgebaseSizeResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentLinkResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumbersItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberTwilioResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.GetWhatsAppAccountResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetWhatsAppAccountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentsPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAudioNativeProjectSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetChaptersResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChapterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetClientAppointmentsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetClientByPhoneParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConvAIDashboardSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChartsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConvAISettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LivekitStackType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationResponseModelStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationUsersPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationUserResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationsPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentsItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentBranchInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseFileResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseDocumentMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DocumentUsageModeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseFolderResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseListResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DocumentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DocumentsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAgentsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAgentsItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAgentsItem3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAgentsItem4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseTextResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetKnowledgeBaseURLResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetLibraryVoicesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LibraryVoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LibraryVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetLiveCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberInboundSIPTrunkConfigResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPMediaEncryptionEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberOutboundSIPTrunkConfigResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPTrunkTransportEnum))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetResponseUnitTestResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestFromConversationMetadataOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentsItem3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminatorType))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPTrunkCredentialsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.IntegrationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DiscountResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InvoiceResponseModelPaymentIntentStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseDependentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseDocumentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseSortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseSourceFileUrlResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMDeprecationConfigModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMDeprecationInfoModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMInfoModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LLMReasoningEffort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMReasoningEffort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMInfoModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMInputOutputTokensUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMTokensCategoryUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMListResponseModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LLMInfoModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMListResponseModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LLMInfoModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMLiteralJsonSchemaPropertyType))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LibraryVoiceResponseModelCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VerifiedVoiceLanguageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAssetsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAuthConnectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AuthConnectionsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthConnectionsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2ClientCredsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2JWTResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PrivateKeyJWTResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListCalendarEventsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListClientsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListMCPToolsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListProductsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListRentalServicesParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListResponseAgentBranchSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentBranchSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListServicesParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListStaffParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListTestsByIdsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListWhatsAppAccountsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LiteralJsonSchemaPropertyType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?, double?, bool?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPApprovalPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPApprovalPolicyUpdateRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolApprovalHash>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolApprovalHash))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerTransport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerConfigUpdateRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DependentAgentsItem5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPServersResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.MCPServerResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolAddApprovalRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolApprovalPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InputOverridesVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InputOverridesVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InputOverridesVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideInputOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideInputOverridesDiscriminatorSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideCreateRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InputOverridesVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InputOverridesVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ManualVerificationFileResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ManualVerificationFileResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MatchAnythingParameterEvaluationStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MergingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MessageSearchSortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MessagesSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.MessagesSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MessagesSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MetricType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ModelRatesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ModelResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LanguageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ModerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ThresholdGuardrail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MultiSourceConfigJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SourceConfigJson>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SourceConfigJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MultichannelSpeechToTextResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextChunkResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextChunkResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MultipartMusicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicExploreSongSourceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SongSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SongSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.NoCoachingSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.NonStreamingOutputFormats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OAuth2JWTResponseAlgorithm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RequiredConstraints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralOverride, global::ElevenLabs.ObjectOverrideInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralOverride, global::ElevenLabs.ObjectOverrideOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrbAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchConvAIDashboardSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChartsItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchConvAISettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchWorkspaceSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PatchWorkspaceWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingClipTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingClipTaskType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomSipHeadersItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferDestinationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPUriTransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPUriDynamicVariableTransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferTypeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostDialDigitsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostDialDigitsStatic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostDialDigitsDynamicVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PlayDTMFToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastBulletinModeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastConversationModeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PositionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PositionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostAgentAvatarResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostWorkspaceSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostWorkspaceSecretResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PrivateKeyJWTResponseAlgorithm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProcedureCompilerMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProcedureRefResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProcedureSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectCreationMetaResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectCreationMetaResponseModelStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectCreationMetaResponseModelType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelTargetAudience2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelAccessLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelFiction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelSourceType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.CaptionStyleModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelAspectRatio2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioAgentSettingsModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelQualityPreset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryVersionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryLocatorResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectVideoResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExternalAudioResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectImageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SourceContextVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SongSourceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SfxSourceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectMutedTracksResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelTargetAudience2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelAccessLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelFiction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelSourceType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelAspectRatio2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectSnapshotExtendedResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectSnapshotResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectSnapshotsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ProjectSnapshotResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RagConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackupLlmConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SMBToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackupLlmConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RagConfigWorkflowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsVariant1Item2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryRulesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.QueryParamsJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RAGDocumentIndexResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RAGIndexStatus))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RecordingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioClipReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReferencedToolCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReferencedToolCommonModelType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RegexParameterEvaluationStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TwilioRegionId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TwilioEdgeLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RenderStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RequestPVCManualVerificationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RequiredConstraint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.RequiredConstraint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResourceAccessInfoRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResourceMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ShareOptionResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ShareOptionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResponseFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResponseUnitTestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResubmitTestsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReviewResponseModelReviewStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RunAgentTestsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SingleTestRunRequestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SingleTestRunRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SIPTrunkOutboundCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Params))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SearchClientsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateClientParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateStaffParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAssetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateServiceParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateProductParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateCalendarEventParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SMBToolConfigParamsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SafetyCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SafetyEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SafetyRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SafetyRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SampleConfigDBModelParentType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SampleResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerSeparationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SayNodeLiteralMessageInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SayNodeLiteralMessageOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SayNodePromptMessageInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SayNodePromptMessageOutput))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ShareOptionResponseModelType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SimilarVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SimilarVoicesForSpeakerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SimilarVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SimulationTestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SingleUseTokenResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SingleUseTokenType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SkipTurnToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SoftTimeoutConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SoftTimeoutConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SoftTimeoutConfigOverrideConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SoftTimeoutConfigWorkflowOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SortDirection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SourceRetrievalConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerAudioResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerCreatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.UtteranceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UtteranceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbedSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerUpdatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechHistoryItemResponseModelVoiceCategory2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechHistoryItemResponseModelState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechHistoryItemResponseModelSource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInputResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextCharacterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextWordResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextWordResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AdditionalFormatResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DetectedEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextWordResponseModelType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextCharacterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpellingPatience))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StartPVCVoiceTrainingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StartSpeakerSeparationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StreamingAudioChunkWithTimestampsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.StudioAgentToolSettingsModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioAgentToolSettingsModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioClipReferenceClipType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SubscriptionResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SubscriptionResponseModelCurrency2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SuggestedAudioTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SupportedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSModelFamily))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Params2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToNumberToolConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoicemailDetectionToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SystemToolConfigInputParamsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Params3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToNumberToolConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SystemToolConfigOutputParamsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSConversationalModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SupportedVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SuggestedAudioTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextNormalisationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestConditionRationaleCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestConditionResultCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestRunMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestRunMetadataTestType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestRunStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TokenResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolAnnotations2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolCallUnitTestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolRequestModelToolConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolResponseMockConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestToolCallParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestToolCallParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolResponseMockConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolResponseModelToolConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolUsageStatsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolSortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolTypeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferBranchInfoDefaultingToMain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferBranchInfoTrafficSplit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BranchInfoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnEagerness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TwilioOutboundCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.URLAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestInfoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestWorkflowNodeTransitionEvaluationNodeId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Eval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateEnvironmentVariableRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateResponseUnitTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateSimulationTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateToolCallUnitTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateWhatsAppAccountRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateWorkspaceMemberResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UsageAggregationInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UsageCharactersResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UserResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UsersSortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VerifyPVCVoiceCaptchaResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoAnalysisStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VideoSubject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoSubject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VideoSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VideoKeyMoment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoKeyMoment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VideoTranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoTranscriptionWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceDesignRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceDesignRequestModelModelId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoicePreviewResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoicePreviewsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoicePreviewsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VoicePreviewResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceRemixRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SampleResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelSafetyControl2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceVerificationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSamplePreviewResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSampleVisualWaveformResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingModerationCheckResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ReaderResourceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookAuthMethodType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInputContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutputContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookUsageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppConversationInfoDirection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppOutboundCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppOutboundMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateTextParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateTextParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateDocumentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateDocumentParamDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ParametersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ParametersItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateImageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateLocationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateImageParamDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppTemplateLocationParamDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetExpandable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetFeedbackMode))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetEndFeedbackType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WidgetTermsTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ForwardConditionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowUnconditionalModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowLLMConditionModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowResultConditionModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowExpressionConditionModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackwardConditionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ForwardConditionVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowUnconditionalModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowLLMConditionModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowResultConditionModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowExpressionConditionModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BackwardConditionVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Expression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowExpressionConditionModelInputExpressionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowExpressionConditionModelInputExpressionDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Expression2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowExpressionConditionModelOutputExpressionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowExpressionConditionModelOutputExpressionDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomSipHeadersItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostDialDigitsVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CustomSipHeadersItem3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferDestination2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PostDialDigitsVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolEdgeStepModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkflowToolLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StepsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StepsItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceApiKeyListResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceApiKeyResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceApiKeyResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceBatchCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.BatchCallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceCreateApiKeyResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceCreateWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceGroupByNameResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceGroupPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<int?, string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceServiceAccountListResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceServiceAccountResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceServiceAccountResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceWebhookListResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceWebhookUsageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateEnvironmentVariableRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetSpeechHistorySortDirection2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetSpeechHistorySource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechFullOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechStreamOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsDubbingStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsFilterByCreator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsOrderDirection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataSort2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TestType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListChatResponseTestsRouteSortMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationHistoriesRouteSummaryMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolTypeFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListEnvironmentVariablesType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DownloadSpeechHistoryItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.DubbingTranscriptResponseModel, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ModelResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkspaceGroupResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupByNameResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentSummariesRouteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminatorStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentResponseTestRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAgentResponseTestRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListPhoneNumbersRouteResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdatePhoneNumberRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateDocumentRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateDocumentRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetOrCreateRagIndexesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RefreshUrlDocumentRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChildrenItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChildrenItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChildrenItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChildrenItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ExportOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentVersionMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentDeploymentRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AttachedTestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableAssignment>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TemplateParamsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PromptEvaluationCriteria>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OutboundCallRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DialogueInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.CharacterAlignmentModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterSnapshotResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VoiceStatisticsResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SecretDependencyType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WebhookEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ClientEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DataCollectionResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConfigEntityType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableUpdateCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.EnvironmentVariableResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VerificationAttemptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentWordResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.GetWhatsAppAccountResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SpeechHistoryItemResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TestInvocationSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.UnitTestRunResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.UnitTestSummaryResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DiscountResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LLMReasoningEffort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LLMInfoModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LLMInfoModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AuthConnectionsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentBranchSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.MCPToolApprovalHash>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.MCPServerResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ManualVerificationFileResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.MessagesSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LanguageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SourceConfigJson>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextChunkResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SongSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ProjectVoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ProjectSnapshotResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.UtteranceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DialogueInputResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextWordResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AdditionalFormatResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DetectedEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextCharacterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SupportedVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SuggestedAudioTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.UnitTestToolCallParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumberTransfer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VideoSubject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VideoSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VideoKeyMoment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VideoTranscriptionWord>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceApiKeyResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.BatchCallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceServiceAccountResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TestType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolTypeFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ModelResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupByNameResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}