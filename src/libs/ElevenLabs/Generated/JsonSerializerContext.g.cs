
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
            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseReponseModelTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseReponseModelTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelRoleJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelRoleNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.JsonLiteralTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.JsonLiteralTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ServerEventJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ServerEventNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ObjectJsonSchemaPropertyTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ObjectJsonSchemaPropertyTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.JsonSchemaPropertyTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.JsonSchemaPropertyTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.EmbedVariantJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.EmbedVariantNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.OrbAvatarTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.OrbAvatarTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.URLAvatarTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.URLAvatarTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ImageAvatarTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ImageAvatarTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.LLMJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.LLMNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.PromptAgentToolConfigTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.PromptAgentToolConfigTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ToolWebhookConfigMethodJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ToolWebhookConfigMethodNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseLocatorTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.KnowledgeBaseLocatorTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ASRQualityJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ASRQualityNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ASRProviderJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ASRProviderNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ASRInputFormatJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ASRInputFormatNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.TTSConversationalModelNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.TTSOutputFormatNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ClientEventJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ClientEventNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.PromptEvaluationCriteriaTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.PromptEvaluationCriteriaTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudienceJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudienceNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccessJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccessNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyAddProjectV1ProjectsAddPostTargetAudienceJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyAddProjectV1ProjectsAddPostTargetAudienceNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryAliasRuleRequestModelTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryAliasRuleRequestModelTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryPhonemeRuleRequestModelTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryPhonemeRuleRequestModelTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGenderJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGenderNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAgeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAgeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalizationJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalizationNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostApplyTextNormalizationJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostApplyTextNormalizationNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalizationJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalizationNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalizationJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalizationNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BreakdownTypesJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BreakdownTypesNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ExtendedSubscriptionResponseModelCurrencyJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ExtendedSubscriptionResponseModelCurrencyNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ExtendedSubscriptionResponseModelStatusJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ExtendedSubscriptionResponseModelStatusNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ExtendedSubscriptionResponseModelBillingPeriodJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ExtendedSubscriptionResponseModelBillingPeriodNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ExtendedSubscriptionResponseModelCharacterRefreshPeriodJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ExtendedSubscriptionResponseModelCharacterRefreshPeriodNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.FineTuningResponseModelState2JsonConverter),
            typeof(global::ElevenLabs.JsonConverters.FineTuningResponseModelState2NullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategoryJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategoryNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSourceJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSourceNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControlJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControlNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ModelResponseModelConcurrencyGroupJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ModelResponseModelConcurrencyGroupNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudienceJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudienceNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelQualityPresetJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelQualityPresetNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectSnapshotUploadResponseModelStatusJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectSnapshotUploadResponseModelStatusNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SsoProviderResponseModelProviderTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SsoProviderResponseModelProviderTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SubscriptionResponseModelCurrencyJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SubscriptionResponseModelCurrencyNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SubscriptionResponseModelStatusJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SubscriptionResponseModelStatusNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SubscriptionResponseModelBillingPeriodJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SubscriptionResponseModelBillingPeriodNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SubscriptionResponseModelCharacterRefreshPeriodJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.SubscriptionResponseModelCharacterRefreshPeriodNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.VoicePreviewResponseModelMediaTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.VoicePreviewResponseModelMediaTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.JsonLiteralType?, global::ElevenLabs.JsonSchemaPropertyType?>),
            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>),
            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>),
            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>),
            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>),
            typeof(global::ElevenLabs.JsonConverters.AllOfJsonConverter<global::ElevenLabs.VoiceSettingsResponseModel>),
            typeof(global::ElevenLabs.JsonConverters.AllOfJsonConverter<global::ElevenLabs.EvaluationSuccessResult?>),
            typeof(global::ElevenLabs.JsonConverters.AllOfJsonConverter<global::ElevenLabs.BreakdownTypes?>),
            typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}