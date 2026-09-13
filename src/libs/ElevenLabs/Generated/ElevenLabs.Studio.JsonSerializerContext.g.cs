
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterWithContentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AssetTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AssetTranscriptionStatus), TypeInfoPropertyName = "AssetTranscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AssetTranscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioAnalysisStatus), TypeInfoPropertyName = "AudioAnalysisStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AudioSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AudioKeyMoment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioKeyMoment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.QualityPresetType), TypeInfoPropertyName = "QualityPresetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience), TypeInfoPropertyName = "BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction), TypeInfoPropertyName = "BodyCreateStudioProjectV1StudioProjectsPostFiction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization), TypeInfoPropertyName = "BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType), TypeInfoPropertyName = "BodyCreateStudioProjectV1StudioProjectsPostSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateChapterV1StudioProjectsProjectIdChaptersPost))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization), TypeInfoPropertyName = "BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamChapterAudioV1StudioProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateStudioProjectV1StudioProjectsProjectIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CanvasPlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType), TypeInfoPropertyName = "CaptionStyleCharacterAnimationModelEnterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType), TypeInfoPropertyName = "CaptionStyleCharacterAnimationModelExitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleHorizontalPlacementModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign), TypeInfoPropertyName = "CaptionStyleHorizontalPlacementModelAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleTemplateModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextAlign), TypeInfoPropertyName = "CaptionStyleModelTextAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextStyle), TypeInfoPropertyName = "CaptionStyleModelTextStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextWeight), TypeInfoPropertyName = "CaptionStyleModelTextWeight2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextTransform), TypeInfoPropertyName = "CaptionStyleModelTextTransform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextBlendMode), TypeInfoPropertyName = "CaptionStyleModelTextBlendMode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentBlockInputModelSubType), TypeInfoPropertyName = "ChapterContentBlockInputModelSubType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClipAnimation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClipAnimationEnterEffect), TypeInfoPropertyName = "ClipAnimationEnterEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClipAnimationExitEffect), TypeInfoPropertyName = "ClipAnimationExitEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Contributor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvertChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConvertProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatePronunciationDictionaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ReadMetadataChapterDBModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReadMetadataChapterDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode), TypeInfoPropertyName = "DirectPublishingReadResponseModelDisplayMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item), TypeInfoPropertyName = "DirectPublishingReadResponseModelGenreVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience), TypeInfoPropertyName = "DirectPublishingReadResponseModelTargetAudience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReadLegalTerms))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.Contributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelPayoutType), TypeInfoPropertyName = "DirectPublishingReadResponseModelPayoutType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PreviewAudioDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SampleConfigDBModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReviewResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditChapterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FineTuningResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.FineTuningResponseModelState2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FineTuningResponseModelState2), TypeInfoPropertyName = "FineTuningResponseModelState22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VerificationAttemptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VerificationAttemptResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ManualVerificationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerationSourceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetChaptersResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ChapterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetProjectsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ProjectResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageAnalysisStatus), TypeInfoPropertyName = "ImageAnalysisStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ImageSubject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageSubject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VerifiedVoiceLanguageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ManualVerificationFileResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ManualVerificationFileResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicExploreSongSourceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingBlocksMetadataModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingClipTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingClipTaskType), TypeInfoPropertyName = "PendingClipTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingExternalAudiosMetadataModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastBulletinModeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastConversationModeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PodcastProjectResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectCreationMetaResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectCreationMetaResponseModelStatus), TypeInfoPropertyName = "ProjectCreationMetaResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectCreationMetaType), TypeInfoPropertyName = "ProjectCreationMetaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelTargetAudience), TypeInfoPropertyName = "ProjectExtendedResponseModelTargetAudience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelState), TypeInfoPropertyName = "ProjectExtendedResponseModelState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelAccessLevel), TypeInfoPropertyName = "ProjectExtendedResponseModelAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelFiction), TypeInfoPropertyName = "ProjectExtendedResponseModelFiction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelSourceType), TypeInfoPropertyName = "ProjectExtendedResponseModelSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.CaptionStyleModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelAspectRatio), TypeInfoPropertyName = "ProjectExtendedResponseModelAspectRatio2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelTargetAudience), TypeInfoPropertyName = "ProjectResponseModelTargetAudience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelState), TypeInfoPropertyName = "ProjectResponseModelState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelAccessLevel), TypeInfoPropertyName = "ProjectResponseModelAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelFiction), TypeInfoPropertyName = "ProjectResponseModelFiction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelSourceType), TypeInfoPropertyName = "ProjectResponseModelSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelAspectRatio), TypeInfoPropertyName = "ProjectResponseModelAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectSnapshotExtendedResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectSnapshotResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectSnapshotsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ProjectSnapshotResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource), TypeInfoPropertyName = "PronunciationDictionaryVersionResponseModelPermissionOnResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReaderResourceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType), TypeInfoPropertyName = "ReaderResourceResponseModelResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RecordingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioClipLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReviewResponseModelReviewStatus), TypeInfoPropertyName = "ReviewResponseModelReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item), TypeInfoPropertyName = "ReviewResponseModelRejectReasonsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SampleConfigDBModelParentType), TypeInfoPropertyName = "SampleConfigDBModelParentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SampleResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerSeparationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.UtteranceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UtteranceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus), TypeInfoPropertyName = "SpeakerSeparationResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.StudioAgentToolSettingsModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioAgentToolSettingsModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioClipLocatorClipType), TypeInfoPropertyName = "StudioClipLocatorClipType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoAnalysisStatus), TypeInfoPropertyName = "VideoAnalysisStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VideoSubject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoSubject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VideoSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VideoKeyMoment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoKeyMoment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SampleResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelCategory), TypeInfoPropertyName = "VoiceResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelSafetyControl), TypeInfoPropertyName = "VoiceResponseModelSafetyControl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceVerificationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality), TypeInfoPropertyName = "VoiceResponseModelRecordingQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus), TypeInfoPropertyName = "VoiceResponseModelLabellingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingModerationCheckResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelStatus), TypeInfoPropertyName = "VoiceSharingResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelCategory), TypeInfoPropertyName = "VoiceSharingResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus), TypeInfoPropertyName = "VoiceSharingResponseModelReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ReaderResourceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AssetTranscriptionStatus?), TypeInfoPropertyName = "NullableAssetTranscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioAnalysisStatus?), TypeInfoPropertyName = "NullableAudioAnalysisStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.QualityPresetType?), TypeInfoPropertyName = "NullableQualityPresetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience?), TypeInfoPropertyName = "NullableBodyCreateStudioProjectV1StudioProjectsPostTargetAudience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction?), TypeInfoPropertyName = "NullableBodyCreateStudioProjectV1StudioProjectsPostFiction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization?), TypeInfoPropertyName = "NullableBodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType?), TypeInfoPropertyName = "NullableBodyCreateStudioProjectV1StudioProjectsPostSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>?), TypeInfoPropertyName = "NullableAnyOfPodcastConversationModePodcastBulletinMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>?), TypeInfoPropertyName = "NullableAnyOfPodcastTextSourcePodcastURLSourceIListAnyOfPodcastTextSourcePodcastURLSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>?), TypeInfoPropertyName = "NullableAnyOfPodcastTextSourcePodcastURLSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale?), TypeInfoPropertyName = "NullableBodyCreatePodcastV1StudioPodcastsPostDurationScale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization?), TypeInfoPropertyName = "NullableBodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType?), TypeInfoPropertyName = "NullableCaptionStyleCharacterAnimationModelEnterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType?), TypeInfoPropertyName = "NullableCaptionStyleCharacterAnimationModelExitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign?), TypeInfoPropertyName = "NullableCaptionStyleHorizontalPlacementModelAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextAlign?), TypeInfoPropertyName = "NullableCaptionStyleModelTextAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextStyle?), TypeInfoPropertyName = "NullableCaptionStyleModelTextStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextWeight?), TypeInfoPropertyName = "NullableCaptionStyleModelTextWeight2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextTransform?), TypeInfoPropertyName = "NullableCaptionStyleModelTextTransform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleModelTextBlendMode?), TypeInfoPropertyName = "NullableCaptionStyleModelTextBlendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelEnterType?), TypeInfoPropertyName = "NullableCaptionStyleSectionAnimationModelEnterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelExitType?), TypeInfoPropertyName = "NullableCaptionStyleSectionAnimationModelExitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleVerticalPlacementModelAlign?), TypeInfoPropertyName = "NullableCaptionStyleVerticalPlacementModelAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleWordAnimationModelEnterType?), TypeInfoPropertyName = "NullableCaptionStyleWordAnimationModelEnterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CaptionStyleWordAnimationModelExitType?), TypeInfoPropertyName = "NullableCaptionStyleWordAnimationModelExitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterContentBlockInputModelSubType?), TypeInfoPropertyName = "NullableChapterContentBlockInputModelSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>?), TypeInfoPropertyName = "NullableAnyOfChapterContentBlockTtsNodeResponseModelChapterContentBlockExtendableNodeResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterResponseModelState?), TypeInfoPropertyName = "NullableChapterResponseModelState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChapterWithContentResponseModelState?), TypeInfoPropertyName = "NullableChapterWithContentResponseModelState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClipAnimationEnterEffect?), TypeInfoPropertyName = "NullableClipAnimationEnterEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClipAnimationExitEffect?), TypeInfoPropertyName = "NullableClipAnimationExitEffect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode?), TypeInfoPropertyName = "NullableDirectPublishingReadResponseModelDisplayMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item?), TypeInfoPropertyName = "NullableDirectPublishingReadResponseModelGenreVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience?), TypeInfoPropertyName = "NullableDirectPublishingReadResponseModelTargetAudience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DirectPublishingReadResponseModelPayoutType?), TypeInfoPropertyName = "NullableDirectPublishingReadResponseModelPayoutType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FineTuningResponseModelState2?), TypeInfoPropertyName = "NullableFineTuningResponseModelState22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageAnalysisStatus?), TypeInfoPropertyName = "NullableImageAnalysisStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PendingClipTaskType?), TypeInfoPropertyName = "NullablePendingClipTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectCreationMetaResponseModelStatus?), TypeInfoPropertyName = "NullableProjectCreationMetaResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectCreationMetaType?), TypeInfoPropertyName = "NullableProjectCreationMetaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelTargetAudience?), TypeInfoPropertyName = "NullableProjectExtendedResponseModelTargetAudience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelState?), TypeInfoPropertyName = "NullableProjectExtendedResponseModelState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelAccessLevel?), TypeInfoPropertyName = "NullableProjectExtendedResponseModelAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelFiction?), TypeInfoPropertyName = "NullableProjectExtendedResponseModelFiction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelSourceType?), TypeInfoPropertyName = "NullableProjectExtendedResponseModelSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelAspectRatio?), TypeInfoPropertyName = "NullableProjectExtendedResponseModelAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization?), TypeInfoPropertyName = "NullableProjectExtendedResponseModelApplyTextNormalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>?), TypeInfoPropertyName = "NullableAnyOfProjectVideoResponseModelProjectExternalAudioResponseModelProjectImageResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType?), TypeInfoPropertyName = "NullableProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelTargetAudience?), TypeInfoPropertyName = "NullableProjectResponseModelTargetAudience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelState?), TypeInfoPropertyName = "NullableProjectResponseModelState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelAccessLevel?), TypeInfoPropertyName = "NullableProjectResponseModelAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelFiction?), TypeInfoPropertyName = "NullableProjectResponseModelFiction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelSourceType?), TypeInfoPropertyName = "NullableProjectResponseModelSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ProjectResponseModelAspectRatio?), TypeInfoPropertyName = "NullableProjectResponseModelAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource?), TypeInfoPropertyName = "NullablePronunciationDictionaryVersionResponseModelPermissionOnResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType?), TypeInfoPropertyName = "NullableReaderResourceResponseModelResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReviewResponseModelReviewStatus?), TypeInfoPropertyName = "NullableReviewResponseModelReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item?), TypeInfoPropertyName = "NullableReviewResponseModelRejectReasonsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SampleConfigDBModelParentType?), TypeInfoPropertyName = "NullableSampleConfigDBModelParentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus?), TypeInfoPropertyName = "NullableSpeakerSeparationResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StudioClipLocatorClipType?), TypeInfoPropertyName = "NullableStudioClipLocatorClipType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoAnalysisStatus?), TypeInfoPropertyName = "NullableVideoAnalysisStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelCategory?), TypeInfoPropertyName = "NullableVoiceResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelSafetyControl?), TypeInfoPropertyName = "NullableVoiceResponseModelSafetyControl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality?), TypeInfoPropertyName = "NullableVoiceResponseModelRecordingQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus?), TypeInfoPropertyName = "NullableVoiceResponseModelLabellingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelStatus?), TypeInfoPropertyName = "NullableVoiceSharingResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelCategory?), TypeInfoPropertyName = "NullableVoiceSharingResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus?), TypeInfoPropertyName = "NullableVoiceSharingResponseModelReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AudioSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AudioKeyMoment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.CharacterAlignmentModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterSnapshotResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VoiceStatisticsResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ReadMetadataChapterDBModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.Contributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VerificationAttemptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ChapterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ProjectResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ImageSubject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ManualVerificationFileResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ProjectVoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ProjectSnapshotResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.UtteranceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VideoSubject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VideoSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VideoKeyMoment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SampleResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ReaderResourceResponseModel>))]
    internal sealed partial class StudioSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StudioSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StudioSourceGenerationContext Default { get; } = new(DefaultOptions);

        private StudioSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SourceContextVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<object>, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, bool?, double?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.DateTime?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::ElevenLabs.AssetTranscriptionStatus)

                    || typeToConvert == typeof(global::ElevenLabs.AssetTranscriptionStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.AudioAnalysisStatus)

                    || typeToConvert == typeof(global::ElevenLabs.AudioAnalysisStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextAlign)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextAlign?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextStyle)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextStyle?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextWeight)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextWeight?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextTransform)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextTransform?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextBlendMode)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextBlendMode?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelEnterType)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelEnterType?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelExitType)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelExitType?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleVerticalPlacementModelAlign)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleVerticalPlacementModelAlign?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleWordAnimationModelEnterType)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleWordAnimationModelEnterType?)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleWordAnimationModelExitType)

                    || typeToConvert == typeof(global::ElevenLabs.CaptionStyleWordAnimationModelExitType?)

                    || typeToConvert == typeof(global::ElevenLabs.ChapterContentBlockInputModelSubType)

                    || typeToConvert == typeof(global::ElevenLabs.ChapterContentBlockInputModelSubType?)

                    || typeToConvert == typeof(global::ElevenLabs.ChapterResponseModelState)

                    || typeToConvert == typeof(global::ElevenLabs.ChapterResponseModelState?)

                    || typeToConvert == typeof(global::ElevenLabs.ChapterWithContentResponseModelState)

                    || typeToConvert == typeof(global::ElevenLabs.ChapterWithContentResponseModelState?)

                    || typeToConvert == typeof(global::ElevenLabs.ClipAnimationEnterEffect)

                    || typeToConvert == typeof(global::ElevenLabs.ClipAnimationEnterEffect?)

                    || typeToConvert == typeof(global::ElevenLabs.ClipAnimationExitEffect)

                    || typeToConvert == typeof(global::ElevenLabs.ClipAnimationExitEffect?)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode?)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience?)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelPayoutType)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelPayoutType?)

                    || typeToConvert == typeof(global::ElevenLabs.FineTuningResponseModelState2)

                    || typeToConvert == typeof(global::ElevenLabs.FineTuningResponseModelState2?)

                    || typeToConvert == typeof(global::ElevenLabs.ImageAnalysisStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ImageAnalysisStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.PendingClipTaskType)

                    || typeToConvert == typeof(global::ElevenLabs.PendingClipTaskType?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectCreationMetaResponseModelStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectCreationMetaResponseModelStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectCreationMetaType)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectCreationMetaType?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelTargetAudience)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelTargetAudience?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelState)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelState?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelAccessLevel)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelAccessLevel?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelFiction)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelFiction?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelSourceType)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelSourceType?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelTargetAudience)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelTargetAudience?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelState)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelState?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelAccessLevel)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelAccessLevel?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelFiction)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelFiction?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelSourceType)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelSourceType?)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource)

                    || typeToConvert == typeof(global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource?)

                    || typeToConvert == typeof(global::ElevenLabs.QualityPresetType)

                    || typeToConvert == typeof(global::ElevenLabs.QualityPresetType?)

                    || typeToConvert == typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType)

                    || typeToConvert == typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType?)

                    || typeToConvert == typeof(global::ElevenLabs.ReviewResponseModelReviewStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ReviewResponseModelReviewStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.SampleConfigDBModelParentType)

                    || typeToConvert == typeof(global::ElevenLabs.SampleConfigDBModelParentType?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus)

                    || typeToConvert == typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.StudioClipLocatorClipType)

                    || typeToConvert == typeof(global::ElevenLabs.StudioClipLocatorClipType?)

                    || typeToConvert == typeof(global::ElevenLabs.VideoAnalysisStatus)

                    || typeToConvert == typeof(global::ElevenLabs.VideoAnalysisStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelCategory)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelCategory?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelSafetyControl)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelSafetyControl?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelStatus)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelCategory)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelCategory?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.AssetTranscriptionStatus))
                {
                    return new global::ElevenLabs.JsonConverters.AssetTranscriptionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AssetTranscriptionStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.AssetTranscriptionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AudioAnalysisStatus))
                {
                    return new global::ElevenLabs.JsonConverters.AudioAnalysisStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AudioAnalysisStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.AudioAnalysisStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudienceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFictionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFictionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextAlign))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlignJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextAlign?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlignNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextStyle))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextStyle?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleModelTextStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextWeight))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeightJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextWeight?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleModelTextWeightNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextTransform))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransformJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextTransform?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleModelTextTransformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextBlendMode))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleModelTextBlendMode?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleModelTextBlendModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelEnterType))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelEnterType?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelExitType))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleSectionAnimationModelExitType?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleSectionAnimationModelExitTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleVerticalPlacementModelAlign))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleVerticalPlacementModelAlign?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleVerticalPlacementModelAlignNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleWordAnimationModelEnterType))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleWordAnimationModelEnterType?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelEnterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleWordAnimationModelExitType))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CaptionStyleWordAnimationModelExitType?))
                {
                    return new global::ElevenLabs.JsonConverters.CaptionStyleWordAnimationModelExitTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ChapterContentBlockInputModelSubType))
                {
                    return new global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ChapterContentBlockInputModelSubType?))
                {
                    return new global::ElevenLabs.JsonConverters.ChapterContentBlockInputModelSubTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ChapterResponseModelState))
                {
                    return new global::ElevenLabs.JsonConverters.ChapterResponseModelStateJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ChapterResponseModelState?))
                {
                    return new global::ElevenLabs.JsonConverters.ChapterResponseModelStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ChapterWithContentResponseModelState))
                {
                    return new global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ChapterWithContentResponseModelState?))
                {
                    return new global::ElevenLabs.JsonConverters.ChapterWithContentResponseModelStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ClipAnimationEnterEffect))
                {
                    return new global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ClipAnimationEnterEffect?))
                {
                    return new global::ElevenLabs.JsonConverters.ClipAnimationEnterEffectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ClipAnimationExitEffect))
                {
                    return new global::ElevenLabs.JsonConverters.ClipAnimationExitEffectJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ClipAnimationExitEffect?))
                {
                    return new global::ElevenLabs.JsonConverters.ClipAnimationExitEffectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode))
                {
                    return new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode?))
                {
                    return new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelDisplayModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item))
                {
                    return new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item?))
                {
                    return new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience))
                {
                    return new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudienceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience?))
                {
                    return new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelTargetAudienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelPayoutType))
                {
                    return new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelPayoutType?))
                {
                    return new global::ElevenLabs.JsonConverters.DirectPublishingReadResponseModelPayoutTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.FineTuningResponseModelState2))
                {
                    return new global::ElevenLabs.JsonConverters.FineTuningResponseModelState2JsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.FineTuningResponseModelState2?))
                {
                    return new global::ElevenLabs.JsonConverters.FineTuningResponseModelState2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ImageAnalysisStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ImageAnalysisStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ImageAnalysisStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ImageAnalysisStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PendingClipTaskType))
                {
                    return new global::ElevenLabs.JsonConverters.PendingClipTaskTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PendingClipTaskType?))
                {
                    return new global::ElevenLabs.JsonConverters.PendingClipTaskTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectCreationMetaResponseModelStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectCreationMetaResponseModelStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectCreationMetaResponseModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectCreationMetaType))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectCreationMetaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectCreationMetaType?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectCreationMetaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelTargetAudience))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudienceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelTargetAudience?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelTargetAudienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelState))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelState?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelAccessLevel))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelAccessLevel?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAccessLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelFiction))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFictionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelFiction?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelFictionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelSourceType))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelSourceType?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelTargetAudience))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudienceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelTargetAudience?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectResponseModelTargetAudienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelState))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectResponseModelStateJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelState?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectResponseModelStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelAccessLevel))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelAccessLevel?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectResponseModelAccessLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelFiction))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectResponseModelFictionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelFiction?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectResponseModelFictionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelSourceType))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectResponseModelSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelSourceType?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectResponseModelSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProjectResponseModelAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.ProjectResponseModelAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource))
                {
                    return new global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource?))
                {
                    return new global::ElevenLabs.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.QualityPresetType))
                {
                    return new global::ElevenLabs.JsonConverters.QualityPresetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.QualityPresetType?))
                {
                    return new global::ElevenLabs.JsonConverters.QualityPresetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType))
                {
                    return new global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType?))
                {
                    return new global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ReviewResponseModelReviewStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ReviewResponseModelReviewStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item))
                {
                    return new global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item?))
                {
                    return new global::ElevenLabs.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SampleConfigDBModelParentType))
                {
                    return new global::ElevenLabs.JsonConverters.SampleConfigDBModelParentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SampleConfigDBModelParentType?))
                {
                    return new global::ElevenLabs.JsonConverters.SampleConfigDBModelParentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus))
                {
                    return new global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.StudioClipLocatorClipType))
                {
                    return new global::ElevenLabs.JsonConverters.StudioClipLocatorClipTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.StudioClipLocatorClipType?))
                {
                    return new global::ElevenLabs.JsonConverters.StudioClipLocatorClipTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VideoAnalysisStatus))
                {
                    return new global::ElevenLabs.JsonConverters.VideoAnalysisStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VideoAnalysisStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.VideoAnalysisStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelCategory))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelCategory?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelSafetyControl))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControlJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelSafetyControl?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelStatus))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelCategory))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelCategory?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new StudioSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}