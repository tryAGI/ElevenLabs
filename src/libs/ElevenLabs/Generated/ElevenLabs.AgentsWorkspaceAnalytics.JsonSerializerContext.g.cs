
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_c9c7ec7498b2853d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_14e725276612e2f7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>?), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_1fdd3ab2d425e9fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>), TypeInfoPropertyName = "ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput_ab769caeb7eb4850")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ASRConversationalConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentConfigOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PromptAgentAPIModelOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentDefinitionSource), TypeInfoPropertyName = "AgentDefinitionSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseDocumentType), TypeInfoPropertyName = "KnowledgeBaseDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnalysisScope), TypeInfoPropertyName = "AnalysisScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Llm), TypeInfoPropertyName = "Llm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryAnalysisCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AllowedValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnalysisCharging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnalysisRunningTotal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnalysisRunSnapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?, double?, bool?, object>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LiteralJsonSchemaProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AsyncConversationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AsyncConversationMetadataDeliveryStatus), TypeInfoPropertyName = "AsyncConversationMetadataDeliveryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthorizationMethod), TypeInfoPropertyName = "AuthorizationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BatchCallingCampaignInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TelephonyDirection), TypeInfoPropertyName = "TelephonyDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChatSourceMedium), TypeInfoPropertyName = "ChatSourceMedium2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ContextualUpdateInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationASRUsageModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationChargingCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMCategoryUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PlatformUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationTTSUsageModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSConversationalConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationConfigClientOverrideOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationDeletionSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UserFeedbackScore), TypeInfoPropertyName = "UserFeedbackScore2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CriteriaScoringMode), TypeInfoPropertyName = "CriteriaScoringMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryExotelPhoneCallModel))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableUpdateCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DynamicVariableUpdateCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UserFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationTurnMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RagRetrievalInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationReasoningModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationReasoningModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TriggeredGuardrailCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TriggeredGuardrailCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMUsageOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType), TypeInfoPropertyName = "ConversationHistoryTranscriptOtherToolsResultCommonModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole), TypeInfoPropertyName = "ConversationHistoryTranscriptResponseModelRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResultVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EndCallToolResultModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguageDetectionToolResultModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolResultErrorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToNumberResultSipSuccessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToNumberResultExotelSuccessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToNumberResultErrorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SkipTurnToolResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PlayDTMFResultSuccessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PlayDTMFResultErrorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceMailDetectionResultSuccessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestToolResultModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseRagToolResultModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseToolResultModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StartProcedureToolResultSuccessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StartProcedureToolResultErrorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EndProcedureToolResultSuccessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EndProcedureToolResultErrorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DummyToolResultModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ResultVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType), TypeInfoPropertyName = "ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolType), TypeInfoPropertyName = "ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolDetailsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolDetailsVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType), TypeInfoPropertyName = "ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationSourceInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationClientDataRequestOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceUsageModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationVoiceUsageModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.MetricRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MetricRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DocumentUsageModeEnum), TypeInfoPropertyName = "DocumentUsageModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EmbeddingModelEnum), TypeInfoPropertyName = "EmbeddingModelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EndProcedureToolErrorStatus), TypeInfoPropertyName = "EndProcedureToolErrorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FeatureStatusCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowFeaturesUsageCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TestsFeatureUsageCommonModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationResponseModelStatus), TypeInfoPropertyName = "GetConversationResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VisitedAgentRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VisitedAgentRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GuardrailType), TypeInfoPropertyName = "GuardrailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseRagChunkModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseRagToolStatus), TypeInfoPropertyName = "KnowledgeBaseRagToolStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseRagChunkModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseToolStatus), TypeInfoPropertyName = "KnowledgeBaseToolStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMInputOutputTokensUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LLMTokensCategoryUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LLMInputOutputTokensUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfLiteralJsonSchemaPropertyTypeIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LiteralJsonSchemaPropertyType), TypeInfoPropertyName = "LiteralJsonSchemaPropertyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PlatformCategoryUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.PlatformCategoryUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RagChunkMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.RagChunkMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RunConversationEvaluationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SMSConversationInfoDirection), TypeInfoPropertyName = "SMSConversationInfoDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SoftTimeoutConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StartProcedureToolErrorStatus), TypeInfoPropertyName = "StartProcedureToolErrorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SupportedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSModelFamily), TypeInfoPropertyName = "TTSModelFamily2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSConversationalModel), TypeInfoPropertyName = "TTSConversationalModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SupportedVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolCallDetailsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferBranchInfoDefaultingToMain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferBranchInfoTrafficSplit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BranchInfoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BranchInfoVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason), TypeInfoPropertyName = "TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppConversationInfoDirection), TypeInfoPropertyName = "WhatsAppConversationInfoDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolEdgeStepModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StepsItem), TypeInfoPropertyName = "StepsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StepsItem2), TypeInfoPropertyName = "StepsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType), TypeInfoPropertyName = "WorkflowToolResponseModelOutputStepDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AgentDefinitionSource?), TypeInfoPropertyName = "NullableAgentDefinitionSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseDocumentType?), TypeInfoPropertyName = "NullableKnowledgeBaseDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnalysisScope?), TypeInfoPropertyName = "NullableAnalysisScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Llm?), TypeInfoPropertyName = "NullableLlm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AsyncConversationMetadataDeliveryStatus?), TypeInfoPropertyName = "NullableAsyncConversationMetadataDeliveryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AuthorizationMethod?), TypeInfoPropertyName = "NullableAuthorizationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TelephonyDirection?), TypeInfoPropertyName = "NullableTelephonyDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ChatSourceMedium?), TypeInfoPropertyName = "NullableChatSourceMedium2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UserFeedbackScore?), TypeInfoPropertyName = "NullableUserFeedbackScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationFeedbackType?), TypeInfoPropertyName = "NullableConversationFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EvaluationSuccessResult?), TypeInfoPropertyName = "NullableEvaluationSuccessResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CriteriaScoringMode?), TypeInfoPropertyName = "NullableCriteriaScoringMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationInitiationSource?), TypeInfoPropertyName = "NullableConversationInitiationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType?), TypeInfoPropertyName = "NullableConversationHistoryTranscriptOtherToolsResultCommonModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole?), TypeInfoPropertyName = "NullableConversationHistoryTranscriptResponseModelRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType?), TypeInfoPropertyName = "NullableConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolType?), TypeInfoPropertyName = "NullableToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DocumentUsageModeEnum?), TypeInfoPropertyName = "NullableDocumentUsageModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EmbeddingModelEnum?), TypeInfoPropertyName = "NullableEmbeddingModelEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EndProcedureToolErrorStatus?), TypeInfoPropertyName = "NullableEndProcedureToolErrorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetConversationResponseModelStatus?), TypeInfoPropertyName = "NullableGetConversationResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GuardrailType?), TypeInfoPropertyName = "NullableGuardrailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseRagToolStatus?), TypeInfoPropertyName = "NullableKnowledgeBaseRagToolStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.KnowledgeBaseToolStatus?), TypeInfoPropertyName = "NullableKnowledgeBaseToolStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfLiteralJsonSchemaPropertyTypeIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LiteralJsonSchemaPropertyType?), TypeInfoPropertyName = "NullableLiteralJsonSchemaPropertyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SMSConversationInfoDirection?), TypeInfoPropertyName = "NullableSMSConversationInfoDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StartProcedureToolErrorStatus?), TypeInfoPropertyName = "NullableStartProcedureToolErrorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSModelFamily?), TypeInfoPropertyName = "NullableTTSModelFamily2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TTSConversationalModel?), TypeInfoPropertyName = "NullableTTSConversationalModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason?), TypeInfoPropertyName = "NullableTransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WhatsAppConversationInfoDirection?), TypeInfoPropertyName = "NullableWhatsAppConversationInfoDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StepsItem?), TypeInfoPropertyName = "NullableStepsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StepsItem2?), TypeInfoPropertyName = "NullableStepsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType?), TypeInfoPropertyName = "NullableWorkflowToolResponseModelOutputStepDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DataCollectionResultCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ScopedAnalysisResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceRewardModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableUpdateCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationReasoningModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TriggeredGuardrailCommonModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceUsageModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VisitedAgentRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseRagChunkModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.RagChunkMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SupportedVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.StepsItem2>))]
    internal sealed partial class AgentsWorkspaceAnalyticsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentsWorkspaceAnalyticsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentsWorkspaceAnalyticsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentsWorkspaceAnalyticsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneCallVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResultVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResultVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolDetailsVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolDetailsVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolCallDetailsVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BranchInfoVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BranchInfoVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.StepsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.StepsItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<object>, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, bool?, double?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>());
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
                    typeToConvert == typeof(global::ElevenLabs.AgentDefinitionSource)

                    || typeToConvert == typeof(global::ElevenLabs.AgentDefinitionSource?)

                    || typeToConvert == typeof(global::ElevenLabs.AnalysisScope)

                    || typeToConvert == typeof(global::ElevenLabs.AnalysisScope?)

                    || typeToConvert == typeof(global::ElevenLabs.AsyncConversationMetadataDeliveryStatus)

                    || typeToConvert == typeof(global::ElevenLabs.AsyncConversationMetadataDeliveryStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.AuthorizationMethod)

                    || typeToConvert == typeof(global::ElevenLabs.AuthorizationMethod?)

                    || typeToConvert == typeof(global::ElevenLabs.ChatSourceMedium)

                    || typeToConvert == typeof(global::ElevenLabs.ChatSourceMedium?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationFeedbackType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationFeedbackType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationInitiationSource)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationInitiationSource?)

                    || typeToConvert == typeof(global::ElevenLabs.CriteriaScoringMode)

                    || typeToConvert == typeof(global::ElevenLabs.CriteriaScoringMode?)

                    || typeToConvert == typeof(global::ElevenLabs.DocumentUsageModeEnum)

                    || typeToConvert == typeof(global::ElevenLabs.DocumentUsageModeEnum?)

                    || typeToConvert == typeof(global::ElevenLabs.EmbeddingModelEnum)

                    || typeToConvert == typeof(global::ElevenLabs.EmbeddingModelEnum?)

                    || typeToConvert == typeof(global::ElevenLabs.EndProcedureToolErrorStatus)

                    || typeToConvert == typeof(global::ElevenLabs.EndProcedureToolErrorStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.EvaluationSuccessResult)

                    || typeToConvert == typeof(global::ElevenLabs.EvaluationSuccessResult?)

                    || typeToConvert == typeof(global::ElevenLabs.GetConversationResponseModelStatus)

                    || typeToConvert == typeof(global::ElevenLabs.GetConversationResponseModelStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.GuardrailType)

                    || typeToConvert == typeof(global::ElevenLabs.GuardrailType?)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseDocumentType)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseDocumentType?)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseRagToolStatus)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseRagToolStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseToolStatus)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseToolStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.Llm)

                    || typeToConvert == typeof(global::ElevenLabs.Llm?)

                    || typeToConvert == typeof(global::ElevenLabs.LiteralJsonSchemaPropertyType)

                    || typeToConvert == typeof(global::ElevenLabs.LiteralJsonSchemaPropertyType?)

                    || typeToConvert == typeof(global::ElevenLabs.SMSConversationInfoDirection)

                    || typeToConvert == typeof(global::ElevenLabs.SMSConversationInfoDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.StartProcedureToolErrorStatus)

                    || typeToConvert == typeof(global::ElevenLabs.StartProcedureToolErrorStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.TTSConversationalModel)

                    || typeToConvert == typeof(global::ElevenLabs.TTSConversationalModel?)

                    || typeToConvert == typeof(global::ElevenLabs.TTSModelFamily)

                    || typeToConvert == typeof(global::ElevenLabs.TTSModelFamily?)

                    || typeToConvert == typeof(global::ElevenLabs.TelephonyDirection)

                    || typeToConvert == typeof(global::ElevenLabs.TelephonyDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolType)

                    || typeToConvert == typeof(global::ElevenLabs.ToolType?)

                    || typeToConvert == typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason)

                    || typeToConvert == typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason?)

                    || typeToConvert == typeof(global::ElevenLabs.UserFeedbackScore)

                    || typeToConvert == typeof(global::ElevenLabs.UserFeedbackScore?)

                    || typeToConvert == typeof(global::ElevenLabs.WhatsAppConversationInfoDirection)

                    || typeToConvert == typeof(global::ElevenLabs.WhatsAppConversationInfoDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.AgentDefinitionSource))
                {
                    return new global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentDefinitionSource?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentDefinitionSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AnalysisScope))
                {
                    return new global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AnalysisScope?))
                {
                    return new global::ElevenLabs.JsonConverters.AnalysisScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AsyncConversationMetadataDeliveryStatus))
                {
                    return new global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AsyncConversationMetadataDeliveryStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthorizationMethod))
                {
                    return new global::ElevenLabs.JsonConverters.AuthorizationMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthorizationMethod?))
                {
                    return new global::ElevenLabs.JsonConverters.AuthorizationMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ChatSourceMedium))
                {
                    return new global::ElevenLabs.JsonConverters.ChatSourceMediumJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ChatSourceMedium?))
                {
                    return new global::ElevenLabs.JsonConverters.ChatSourceMediumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationFeedbackType))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationFeedbackTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationFeedbackType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationFeedbackTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptResponseModelRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationInitiationSource))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationInitiationSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationInitiationSource?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationInitiationSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CriteriaScoringMode))
                {
                    return new global::ElevenLabs.JsonConverters.CriteriaScoringModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CriteriaScoringMode?))
                {
                    return new global::ElevenLabs.JsonConverters.CriteriaScoringModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DocumentUsageModeEnum))
                {
                    return new global::ElevenLabs.JsonConverters.DocumentUsageModeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DocumentUsageModeEnum?))
                {
                    return new global::ElevenLabs.JsonConverters.DocumentUsageModeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EmbeddingModelEnum))
                {
                    return new global::ElevenLabs.JsonConverters.EmbeddingModelEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EmbeddingModelEnum?))
                {
                    return new global::ElevenLabs.JsonConverters.EmbeddingModelEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EndProcedureToolErrorStatus))
                {
                    return new global::ElevenLabs.JsonConverters.EndProcedureToolErrorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EndProcedureToolErrorStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.EndProcedureToolErrorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EvaluationSuccessResult))
                {
                    return new global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EvaluationSuccessResult?))
                {
                    return new global::ElevenLabs.JsonConverters.EvaluationSuccessResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConversationResponseModelStatus))
                {
                    return new global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConversationResponseModelStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GuardrailType))
                {
                    return new global::ElevenLabs.JsonConverters.GuardrailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GuardrailType?))
                {
                    return new global::ElevenLabs.JsonConverters.GuardrailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseDocumentType))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseDocumentType?))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseDocumentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseRagToolStatus))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseRagToolStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseRagToolStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseToolStatus))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseToolStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseToolStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseToolStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Llm))
                {
                    return new global::ElevenLabs.JsonConverters.LlmJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Llm?))
                {
                    return new global::ElevenLabs.JsonConverters.LlmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LiteralJsonSchemaPropertyType))
                {
                    return new global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LiteralJsonSchemaPropertyType?))
                {
                    return new global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SMSConversationInfoDirection))
                {
                    return new global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SMSConversationInfoDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.StartProcedureToolErrorStatus))
                {
                    return new global::ElevenLabs.JsonConverters.StartProcedureToolErrorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.StartProcedureToolErrorStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.StartProcedureToolErrorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TTSConversationalModel))
                {
                    return new global::ElevenLabs.JsonConverters.TTSConversationalModelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TTSConversationalModel?))
                {
                    return new global::ElevenLabs.JsonConverters.TTSConversationalModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TTSModelFamily))
                {
                    return new global::ElevenLabs.JsonConverters.TTSModelFamilyJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TTSModelFamily?))
                {
                    return new global::ElevenLabs.JsonConverters.TTSModelFamilyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TelephonyDirection))
                {
                    return new global::ElevenLabs.JsonConverters.TelephonyDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TelephonyDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.TelephonyDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolType))
                {
                    return new global::ElevenLabs.JsonConverters.ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolType?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason))
                {
                    return new global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason?))
                {
                    return new global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UserFeedbackScore))
                {
                    return new global::ElevenLabs.JsonConverters.UserFeedbackScoreJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UserFeedbackScore?))
                {
                    return new global::ElevenLabs.JsonConverters.UserFeedbackScoreNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WhatsAppConversationInfoDirection))
                {
                    return new global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WhatsAppConversationInfoDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeNullableJsonConverter();
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
                    0 => new AgentsWorkspaceAnalyticsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}