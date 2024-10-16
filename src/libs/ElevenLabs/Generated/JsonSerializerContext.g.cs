
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
            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ChapterResponseModelStateNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudienceJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudienceNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectResponseModelStateNullableJsonConverter),
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
            typeof(global::ElevenLabs.JsonConverters.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleNullableJsonConverter),
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
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelQualityPresetJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelQualityPresetNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudienceJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudienceNullableJsonConverter),
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
            typeof(global::ElevenLabs.JsonConverters.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownTypeJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownTypeNullableJsonConverter),
            typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverterFactory2),
            typeof(global::ElevenLabs.JsonConverters.AllOfJsonConverterFactory1),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}