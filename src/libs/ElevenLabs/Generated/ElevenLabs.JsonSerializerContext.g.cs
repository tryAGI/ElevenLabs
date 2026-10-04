
#nullable enable

namespace ElevenLabs
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


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
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASTLLMNodeInputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ASTNodeOutputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EvaluationCriteriaItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DataCollectionItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EvaluationCriteriaItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DataCollectionItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OutcomeJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentTransferOpJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.NodesJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.Nodes2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SchemaOverridesVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AudioReferenceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.McpServersItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TemplateParamsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TriggerActionJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TriggerAction2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ContentSchemaJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolsItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.McpServersItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneCallVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResultVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ResultVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolDetailsVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolDetailsVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TriggerAction3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ExportOptionsJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneNumbersItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ChartsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentsItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DocumentsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAgentsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAgentsItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAgentsItem3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAgentsItem4JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneNumbersItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependenciesVariant1ItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependenciesVariant2ItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AgentsItem3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ImageGenerationRequestJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ImageReferenceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DocumentJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DataJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LanguagesResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AuthConnectionsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.DependentAgentsItem5JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InputOverridesVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InputOverridesVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InputOverridesVariant13JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InputOverridesVariant14JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InputOverridesVariant15JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.InputOverridesVariant16JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MediaGenerationResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PhoneNumbersItem3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MusicAllowedOutputFormatsJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MusicOutputFormatJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OrderItemRequestInputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OrderItemRequestOutputJsonConverter());
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
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EditedTranscriptVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.Params2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.Params3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TemplateInputReferenceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TemplateOutputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TemplateRunInputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextToSpeechGenerationRequestJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolCallDetailsVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolConfigJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolConfig2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BranchInfoVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.BranchInfoVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TestInfoVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EvalJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VideoGenerationRequestJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VideoReferenceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookTargetJsonConverter());
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
            options.Converters.Add(new global::ElevenLabs.JsonConverters.SchemaOverridesVariant12JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.StepsItemJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.StepsItem2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UpdateAuthConnectionResponseJsonConverter());
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
            options.Converters.Add(new global::ElevenLabs.JsonConverters.PostKnowledgeBaseBulkDeleteRouteResponse2JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAIDynamicVariable>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, global::ElevenLabs.MusicModelID?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ProcedureVersionRef, global::ElevenLabs.ProcedureDraftRef>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>, global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ToolCallSoundType?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ToolCallSoundType?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ToolCallSoundType?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ToolCallSoundType?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, bool?, double?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ProcedureVersionRef, global::ElevenLabs.ProcedureDraftRef>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.DateTime?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateBearerAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.UpdateOAuth2ClientCredsRequest, global::ElevenLabs.UpdateBasicAuthRequest, global::ElevenLabs.UpdateBearerAuthRequest, global::ElevenLabs.UpdateOAuth2JWTRequest>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateExotelPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.DubbingTranscriptResponseModel, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
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
                    typeToConvert == typeof(global::ElevenLabs.ASRInputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ASRInputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ASRProvider)

                    || typeToConvert == typeof(global::ElevenLabs.ASRProvider?)

                    || typeToConvert == typeof(global::ElevenLabs.ASRQuality)

                    || typeToConvert == typeof(global::ElevenLabs.ASRQuality?)

                    || typeToConvert == typeof(global::ElevenLabs.ASTNodeInputDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ASTNodeInputDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ASTNodeOutputDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ASTNodeOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource)

                    || typeToConvert == typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource)

                    || typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource)

                    || typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource)

                    || typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource)

                    || typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketIssueType)

                    || typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketIssueType?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketPriority)

                    || typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketPriority?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketSortBy)

                    || typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketSortBy?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketSource)

                    || typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketSource?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketStatus)

                    || typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentDefinitionSource)

                    || typeToConvert == typeof(global::ElevenLabs.AgentDefinitionSource?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentDeploymentSource)

                    || typeToConvert == typeof(global::ElevenLabs.AgentDeploymentSource?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus)

                    || typeToConvert == typeof(global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentSortBy)

                    || typeToConvert == typeof(global::ElevenLabs.AgentSortBy?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentTestEntityType)

                    || typeToConvert == typeof(global::ElevenLabs.AgentTestEntityType?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentTransferOpDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.AgentTransferOpDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentTrustContext)

                    || typeToConvert == typeof(global::ElevenLabs.AgentTrustContext?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.AlertingWebhookMethod)

                    || typeToConvert == typeof(global::ElevenLabs.AlertingWebhookMethod?)

                    || typeToConvert == typeof(global::ElevenLabs.AllowedOutputFormats)

                    || typeToConvert == typeof(global::ElevenLabs.AllowedOutputFormats?)

                    || typeToConvert == typeof(global::ElevenLabs.AnalysisPropertyType)

                    || typeToConvert == typeof(global::ElevenLabs.AnalysisPropertyType?)

                    || typeToConvert == typeof(global::ElevenLabs.AnalysisScope)

                    || typeToConvert == typeof(global::ElevenLabs.AnalysisScope?)

                    || typeToConvert == typeof(global::ElevenLabs.AnalysisType)

                    || typeToConvert == typeof(global::ElevenLabs.AnalysisType?)

                    || typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator)

                    || typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator?)

                    || typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator)

                    || typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator?)

                    || typeToConvert == typeof(global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource)

                    || typeToConvert == typeof(global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource?)

                    || typeToConvert == typeof(global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind)

                    || typeToConvert == typeof(global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind?)

                    || typeToConvert == typeof(global::ElevenLabs.AssetTranscriptionStatus)

                    || typeToConvert == typeof(global::ElevenLabs.AssetTranscriptionStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.AsyncConversationMetadataDeliveryStatus)

                    || typeToConvert == typeof(global::ElevenLabs.AsyncConversationMetadataDeliveryStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.AudioAnalysisStatus)

                    || typeToConvert == typeof(global::ElevenLabs.AudioAnalysisStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus)

                    || typeToConvert == typeof(global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.AudioReferenceDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.AudioReferenceDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.AuthConnectionStatus)

                    || typeToConvert == typeof(global::ElevenLabs.AuthConnectionStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.AuthorizationMethod)

                    || typeToConvert == typeof(global::ElevenLabs.AuthorizationMethod?)

                    || typeToConvert == typeof(global::ElevenLabs.BackgroundSoundPresetId)

                    || typeToConvert == typeof(global::ElevenLabs.BackgroundSoundPresetId?)

                    || typeToConvert == typeof(global::ElevenLabs.BackgroundSoundSourceType)

                    || typeToConvert == typeof(global::ElevenLabs.BackgroundSoundSourceType?)

                    || typeToConvert == typeof(global::ElevenLabs.BanReasonType)

                    || typeToConvert == typeof(global::ElevenLabs.BanReasonType?)

                    || typeToConvert == typeof(global::ElevenLabs.BatchCallRecipientStatus)

                    || typeToConvert == typeof(global::ElevenLabs.BatchCallRecipientStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.BatchCallStatus)

                    || typeToConvert == typeof(global::ElevenLabs.BatchCallStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.BillingPeriod)

                    || typeToConvert == typeof(global::ElevenLabs.BillingPeriod?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess)

                    || typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess)

                    || typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat)

                    || typeToConvert == typeof(global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat)

                    || typeToConvert == typeof(global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix)

                    || typeToConvert == typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility?)

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

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode)

                    || typeToConvert == typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort)

                    || typeToConvert == typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort?)

                    || typeToConvert == typeof(global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole)

                    || typeToConvert == typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole?)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity?)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId)

                    || typeToConvert == typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit)

                    || typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization)

                    || typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization?)

                    || typeToConvert == typeof(global::ElevenLabs.BranchProtectionStatus)

                    || typeToConvert == typeof(global::ElevenLabs.BranchProtectionStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.BreakdownTypes)

                    || typeToConvert == typeof(global::ElevenLabs.BreakdownTypes?)

                    || typeToConvert == typeof(global::ElevenLabs.BucketingStatus)

                    || typeToConvert == typeof(global::ElevenLabs.BucketingStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestResolution?)

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

                    || typeToConvert == typeof(global::ElevenLabs.CharacterAge)

                    || typeToConvert == typeof(global::ElevenLabs.CharacterAge?)

                    || typeToConvert == typeof(global::ElevenLabs.CharacterGender)

                    || typeToConvert == typeof(global::ElevenLabs.CharacterGender?)

                    || typeToConvert == typeof(global::ElevenLabs.CharacterRefreshPeriod)

                    || typeToConvert == typeof(global::ElevenLabs.CharacterRefreshPeriod?)

                    || typeToConvert == typeof(global::ElevenLabs.CharacterRole)

                    || typeToConvert == typeof(global::ElevenLabs.CharacterRole?)

                    || typeToConvert == typeof(global::ElevenLabs.ChatSourceMedium)

                    || typeToConvert == typeof(global::ElevenLabs.ChatSourceMedium?)

                    || typeToConvert == typeof(global::ElevenLabs.ClientEvent)

                    || typeToConvert == typeof(global::ElevenLabs.ClientEvent?)

                    || typeToConvert == typeof(global::ElevenLabs.ClipAnimationEnterEffect)

                    || typeToConvert == typeof(global::ElevenLabs.ClipAnimationEnterEffect?)

                    || typeToConvert == typeof(global::ElevenLabs.ClipAnimationExitEffect)

                    || typeToConvert == typeof(global::ElevenLabs.ClipAnimationExitEffect?)

                    || typeToConvert == typeof(global::ElevenLabs.ColumnFilterOperation)

                    || typeToConvert == typeof(global::ElevenLabs.ColumnFilterOperation?)

                    || typeToConvert == typeof(global::ElevenLabs.ColumnUnit)

                    || typeToConvert == typeof(global::ElevenLabs.ColumnUnit?)

                    || typeToConvert == typeof(global::ElevenLabs.ConfigEntityType)

                    || typeToConvert == typeof(global::ElevenLabs.ConfigEntityType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConflictSection)

                    || typeToConvert == typeof(global::ElevenLabs.ConflictSection?)

                    || typeToConvert == typeof(global::ElevenLabs.ContentFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ContentFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ContentSchemaDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ContentSchemaDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ContentThresholdGuardrailThreshold)

                    || typeToConvert == typeof(global::ElevenLabs.ContentThresholdGuardrailThreshold?)

                    || typeToConvert == typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationErrorType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationErrorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationFeedbackType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationFeedbackType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelInputRole)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelInputRole?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutputRole)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutputRole?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationInitiationSource)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationInitiationSource?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationProduct)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationProduct?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationSentimentAnalysisOverallLabel)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationSentimentAnalysisOverallLabel?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationSummaryMessageModelRole)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationSummaryMessageModelRole?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationSummaryResponseModelStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationSummaryResponseModelStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationTokenPurpose)

                    || typeToConvert == typeof(global::ElevenLabs.ConversationTokenPurpose?)

                    || typeToConvert == typeof(global::ElevenLabs.CrawlStatus)

                    || typeToConvert == typeof(global::ElevenLabs.CrawlStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.CrawlType)

                    || typeToConvert == typeof(global::ElevenLabs.CrawlType?)

                    || typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm)

                    || typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm?)

                    || typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField)

                    || typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField?)

                    || typeToConvert == typeof(global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm)

                    || typeToConvert == typeof(global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm?)

                    || typeToConvert == typeof(global::ElevenLabs.CreatifyAuroraRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.CreatifyAuroraRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.CriteriaScoringMode)

                    || typeToConvert == typeof(global::ElevenLabs.CriteriaScoringMode?)

                    || typeToConvert == typeof(global::ElevenLabs.Currency)

                    || typeToConvert == typeof(global::ElevenLabs.Currency?)

                    || typeToConvert == typeof(global::ElevenLabs.CustomGuardrailConfigModel)

                    || typeToConvert == typeof(global::ElevenLabs.CustomGuardrailConfigModel?)

                    || typeToConvert == typeof(global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.CustomLLMAPIType)

                    || typeToConvert == typeof(global::ElevenLabs.CustomLLMAPIType?)

                    || typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel)

                    || typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel?)

                    || typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel)

                    || typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel?)

                    || typeToConvert == typeof(global::ElevenLabs.DependentAvailableAgentIdentifierAccessLevel)

                    || typeToConvert == typeof(global::ElevenLabs.DependentAvailableAgentIdentifierAccessLevel?)

                    || typeToConvert == typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel)

                    || typeToConvert == typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel?)

                    || typeToConvert == typeof(global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel)

                    || typeToConvert == typeof(global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel?)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode?)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience?)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelPayoutType)

                    || typeToConvert == typeof(global::ElevenLabs.DirectPublishingReadResponseModelPayoutType?)

                    || typeToConvert == typeof(global::ElevenLabs.DocumentUsageModeEnum)

                    || typeToConvert == typeof(global::ElevenLabs.DocumentUsageModeEnum?)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingLanguageResponseStatus)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingLanguageResponseStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingProjectResponseStatus)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingProjectResponseStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingReleaseChannel)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingReleaseChannel?)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ElevenFlashV25RequestOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ElevenFlashV25RequestOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ElevenV3RequestOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ElevenV3RequestOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.EmbedVariant)

                    || typeToConvert == typeof(global::ElevenLabs.EmbedVariant?)

                    || typeToConvert == typeof(global::ElevenLabs.EmbeddingModelEnum)

                    || typeToConvert == typeof(global::ElevenLabs.EmbeddingModelEnum?)

                    || typeToConvert == typeof(global::ElevenLabs.EndProcedureToolErrorStatus)

                    || typeToConvert == typeof(global::ElevenLabs.EndProcedureToolErrorStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.EntryBehavior)

                    || typeToConvert == typeof(global::ElevenLabs.EntryBehavior?)

                    || typeToConvert == typeof(global::ElevenLabs.EnvironmentVariableResponseType)

                    || typeToConvert == typeof(global::ElevenLabs.EnvironmentVariableResponseType?)

                    || typeToConvert == typeof(global::ElevenLabs.EvaluationResultFilter)

                    || typeToConvert == typeof(global::ElevenLabs.EvaluationResultFilter?)

                    || typeToConvert == typeof(global::ElevenLabs.EvaluationSuccessResult)

                    || typeToConvert == typeof(global::ElevenLabs.EvaluationSuccessResult?)

                    || typeToConvert == typeof(global::ElevenLabs.ExotelApiSubdomain)

                    || typeToConvert == typeof(global::ElevenLabs.ExotelApiSubdomain?)

                    || typeToConvert == typeof(global::ElevenLabs.ExperimentAssignmentSource)

                    || typeToConvert == typeof(global::ElevenLabs.ExperimentAssignmentSource?)

                    || typeToConvert == typeof(global::ElevenLabs.ExportOptionsDiscriminatorFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ExportOptionsDiscriminatorFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ExternalSyncJobTrigger)

                    || typeToConvert == typeof(global::ElevenLabs.ExternalSyncJobTrigger?)

                    || typeToConvert == typeof(global::ElevenLabs.ExternalSyncJobType)

                    || typeToConvert == typeof(global::ElevenLabs.ExternalSyncJobType?)

                    || typeToConvert == typeof(global::ElevenLabs.ExternalSyncProvider)

                    || typeToConvert == typeof(global::ElevenLabs.ExternalSyncProvider?)

                    || typeToConvert == typeof(global::ElevenLabs.FineTuningResponseModelState2)

                    || typeToConvert == typeof(global::ElevenLabs.FineTuningResponseModelState2?)

                    || typeToConvert == typeof(global::ElevenLabs.FinetuneCreatedBy)

                    || typeToConvert == typeof(global::ElevenLabs.FinetuneCreatedBy?)

                    || typeToConvert == typeof(global::ElevenLabs.FinetuneVisibility)

                    || typeToConvert == typeof(global::ElevenLabs.FinetuneVisibility?)

                    || typeToConvert == typeof(global::ElevenLabs.FrustratedConversationRefOverallLabel)

                    || typeToConvert == typeof(global::ElevenLabs.FrustratedConversationRefOverallLabel?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestQuality)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestQuality?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestBackground)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestBackground?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestQuality)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestQuality?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestBackground)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestBackground?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage25FlareRequestQuality)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage25FlareRequestQuality?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage25FlareRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage25FlareRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage25FlareRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage25FlareRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage25SunburstRequestQuality)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage25SunburstRequestQuality?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage25SunburstRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage25SunburstRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage25SunburstRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage25SunburstRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestQuality)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestQuality?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini25FlashImageRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini25FlashImageRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputContextAdherence)

                    || typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputContextAdherence?)

                    || typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputConditionStrength)

                    || typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputConditionStrength?)

                    || typeToConvert == typeof(global::ElevenLabs.GenerationChunkOutputContextAdherence)

                    || typeToConvert == typeof(global::ElevenLabs.GenerationChunkOutputContextAdherence?)

                    || typeToConvert == typeof(global::ElevenLabs.GenerationChunkOutputConditionStrength)

                    || typeToConvert == typeof(global::ElevenLabs.GenerationChunkOutputConditionStrength?)

                    || typeToConvert == typeof(global::ElevenLabs.GenesysBotOutcome)

                    || typeToConvert == typeof(global::ElevenLabs.GenesysBotOutcome?)

                    || typeToConvert == typeof(global::ElevenLabs.GenesysRegion)

                    || typeToConvert == typeof(global::ElevenLabs.GenesysRegion?)

                    || typeToConvert == typeof(global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider)

                    || typeToConvert == typeof(global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider?)

                    || typeToConvert == typeof(global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetConversationResponseModelStatus)

                    || typeToConvert == typeof(global::ElevenLabs.GetConversationResponseModelStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.GetConversationSummaryResponseModelStatus)

                    || typeToConvert == typeof(global::ElevenLabs.GetConversationSummaryResponseModelStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider)

                    || typeToConvert == typeof(global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider?)

                    || typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource)

                    || typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource?)

                    || typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource)

                    || typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource?)

                    || typeToConvert == typeof(global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GuardrailExecutionMode)

                    || typeToConvert == typeof(global::ElevenLabs.GuardrailExecutionMode?)

                    || typeToConvert == typeof(global::ElevenLabs.GuardrailType)

                    || typeToConvert == typeof(global::ElevenLabs.GuardrailType?)

                    || typeToConvert == typeof(global::ElevenLabs.HidingReason)

                    || typeToConvert == typeof(global::ElevenLabs.HidingReason?)

                    || typeToConvert == typeof(global::ElevenLabs.IconTheme)

                    || typeToConvert == typeof(global::ElevenLabs.IconTheme?)

                    || typeToConvert == typeof(global::ElevenLabs.ImageAnalysisStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ImageAnalysisStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId)

                    || typeToConvert == typeof(global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId?)

                    || typeToConvert == typeof(global::ElevenLabs.ImageReferenceDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ImageReferenceDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.InlineAudioReferenceMimeType)

                    || typeToConvert == typeof(global::ElevenLabs.InlineAudioReferenceMimeType?)

                    || typeToConvert == typeof(global::ElevenLabs.InlineBase64ReferenceMimeType)

                    || typeToConvert == typeof(global::ElevenLabs.InlineBase64ReferenceMimeType?)

                    || typeToConvert == typeof(global::ElevenLabs.InlineImageReferenceMimeType)

                    || typeToConvert == typeof(global::ElevenLabs.InlineImageReferenceMimeType?)

                    || typeToConvert == typeof(global::ElevenLabs.InlineVideoReferenceMimeType)

                    || typeToConvert == typeof(global::ElevenLabs.InlineVideoReferenceMimeType?)

                    || typeToConvert == typeof(global::ElevenLabs.IntegrationType)

                    || typeToConvert == typeof(global::ElevenLabs.IntegrationType?)

                    || typeToConvert == typeof(global::ElevenLabs.InteractionBudget)

                    || typeToConvert == typeof(global::ElevenLabs.InteractionBudget?)

                    || typeToConvert == typeof(global::ElevenLabs.InvoiceResponseModelPaymentIntentStatus)

                    || typeToConvert == typeof(global::ElevenLabs.InvoiceResponseModelPaymentIntentStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse)

                    || typeToConvert == typeof(global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse?)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseDependentType)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseDependentType?)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseDocumentType)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseDocumentType?)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseRagToolStatus)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseRagToolStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseSortBy)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseSortBy?)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseToolStatus)

                    || typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseToolStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.Llm)

                    || typeToConvert == typeof(global::ElevenLabs.Llm?)

                    || typeToConvert == typeof(global::ElevenLabs.LLMLiteralJsonSchemaPropertyType)

                    || typeToConvert == typeof(global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?)

                    || typeToConvert == typeof(global::ElevenLabs.LLMReasoningEffort)

                    || typeToConvert == typeof(global::ElevenLabs.LLMReasoningEffort?)

                    || typeToConvert == typeof(global::ElevenLabs.LanguagesResponseDiscriminatorKind)

                    || typeToConvert == typeof(global::ElevenLabs.LanguagesResponseDiscriminatorKind?)

                    || typeToConvert == typeof(global::ElevenLabs.LibraryVoiceResponseModelCategory)

                    || typeToConvert == typeof(global::ElevenLabs.LibraryVoiceResponseModelCategory?)

                    || typeToConvert == typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType)

                    || typeToConvert == typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType?)

                    || typeToConvert == typeof(global::ElevenLabs.LiteralJsonSchemaPropertyType)

                    || typeToConvert == typeof(global::ElevenLabs.LiteralJsonSchemaPropertyType?)

                    || typeToConvert == typeof(global::ElevenLabs.LivekitStackType)

                    || typeToConvert == typeof(global::ElevenLabs.LivekitStackType?)

                    || typeToConvert == typeof(global::ElevenLabs.LoadMemoryEntryToolErrorStatus)

                    || typeToConvert == typeof(global::ElevenLabs.LoadMemoryEntryToolErrorStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.LockReason)

                    || typeToConvert == typeof(global::ElevenLabs.LockReason?)

                    || typeToConvert == typeof(global::ElevenLabs.MCPApprovalPolicy)

                    || typeToConvert == typeof(global::ElevenLabs.MCPApprovalPolicy?)

                    || typeToConvert == typeof(global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.MCPServerTransport)

                    || typeToConvert == typeof(global::ElevenLabs.MCPServerTransport?)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolApprovalPolicy)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolApprovalPolicy?)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolApprovalState)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolApprovalState?)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource?)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource?)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminatorSource)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminatorSource?)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource?)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource?)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource)

                    || typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource?)

                    || typeToConvert == typeof(global::ElevenLabs.MediaCodec)

                    || typeToConvert == typeof(global::ElevenLabs.MediaCodec?)

                    || typeToConvert == typeof(global::ElevenLabs.MediaGenerationFailedResponseFailureReason)

                    || typeToConvert == typeof(global::ElevenLabs.MediaGenerationFailedResponseFailureReason?)

                    || typeToConvert == typeof(global::ElevenLabs.MediaGenerationInProgressResponseStatus)

                    || typeToConvert == typeof(global::ElevenLabs.MediaGenerationInProgressResponseStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminatorProvider)

                    || typeToConvert == typeof(global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminatorProvider?)

                    || typeToConvert == typeof(global::ElevenLabs.MergeProposalCloseReason)

                    || typeToConvert == typeof(global::ElevenLabs.MergeProposalCloseReason?)

                    || typeToConvert == typeof(global::ElevenLabs.MergeProposalReviewReviewerRole)

                    || typeToConvert == typeof(global::ElevenLabs.MergeProposalReviewReviewerRole?)

                    || typeToConvert == typeof(global::ElevenLabs.MergeProposalReviewState)

                    || typeToConvert == typeof(global::ElevenLabs.MergeProposalReviewState?)

                    || typeToConvert == typeof(global::ElevenLabs.MergeProposalStatus)

                    || typeToConvert == typeof(global::ElevenLabs.MergeProposalStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.MessageSearchSortBy)

                    || typeToConvert == typeof(global::ElevenLabs.MessageSearchSortBy?)

                    || typeToConvert == typeof(global::ElevenLabs.MetricType)

                    || typeToConvert == typeof(global::ElevenLabs.MetricType?)

                    || typeToConvert == typeof(global::ElevenLabs.MockNoMatchBehavior)

                    || typeToConvert == typeof(global::ElevenLabs.MockNoMatchBehavior?)

                    || typeToConvert == typeof(global::ElevenLabs.MockingStrategy)

                    || typeToConvert == typeof(global::ElevenLabs.MockingStrategy?)

                    || typeToConvert == typeof(global::ElevenLabs.ModerationStatusResponseModelSafetyStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ModerationStatusResponseModelSafetyStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ModerationStatusResponseModelWarningStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ModerationStatusResponseModelWarningStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.MusicFinetuneFailureReason)

                    || typeToConvert == typeof(global::ElevenLabs.MusicFinetuneFailureReason?)

                    || typeToConvert == typeof(global::ElevenLabs.MusicFinetuneStatus)

                    || typeToConvert == typeof(global::ElevenLabs.MusicFinetuneStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.MusicGenerationMode)

                    || typeToConvert == typeof(global::ElevenLabs.MusicGenerationMode?)

                    || typeToConvert == typeof(global::ElevenLabs.MusicModelID)

                    || typeToConvert == typeof(global::ElevenLabs.MusicModelID?)

                    || typeToConvert == typeof(global::ElevenLabs.MusicOnlyOutputFormats)

                    || typeToConvert == typeof(global::ElevenLabs.MusicOnlyOutputFormats?)

                    || typeToConvert == typeof(global::ElevenLabs.NonStreamingOutputFormats)

                    || typeToConvert == typeof(global::ElevenLabs.NonStreamingOutputFormats?)

                    || typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseAlgorithm)

                    || typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseAlgorithm?)

                    || typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseTokenResponseField)

                    || typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseTokenResponseField?)

                    || typeToConvert == typeof(global::ElevenLabs.ObjectJsonSchemaPropertyInputPropertyKind)

                    || typeToConvert == typeof(global::ElevenLabs.ObjectJsonSchemaPropertyInputPropertyKind?)

                    || typeToConvert == typeof(global::ElevenLabs.OrderItemKind)

                    || typeToConvert == typeof(global::ElevenLabs.OrderItemKind?)

                    || typeToConvert == typeof(global::ElevenLabs.OrderItemRequestInputDiscriminatorKind)

                    || typeToConvert == typeof(global::ElevenLabs.OrderItemRequestInputDiscriminatorKind?)

                    || typeToConvert == typeof(global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind)

                    || typeToConvert == typeof(global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind?)

                    || typeToConvert == typeof(global::ElevenLabs.OrderState)

                    || typeToConvert == typeof(global::ElevenLabs.OrderState?)

                    || typeToConvert == typeof(global::ElevenLabs.OutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.OutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.PendingClipTaskType)

                    || typeToConvert == typeof(global::ElevenLabs.PendingClipTaskType?)

                    || typeToConvert == typeof(global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier)

                    || typeToConvert == typeof(global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier?)

                    || typeToConvert == typeof(global::ElevenLabs.PermissionType)

                    || typeToConvert == typeof(global::ElevenLabs.PermissionType?)

                    || typeToConvert == typeof(global::ElevenLabs.PhoneNumberSortBy)

                    || typeToConvert == typeof(global::ElevenLabs.PhoneNumberSortBy?)

                    || typeToConvert == typeof(global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.PlatformCategory)

                    || typeToConvert == typeof(global::ElevenLabs.PlatformCategory?)

                    || typeToConvert == typeof(global::ElevenLabs.PreToolSpeechMode)

                    || typeToConvert == typeof(global::ElevenLabs.PreToolSpeechMode?)

                    || typeToConvert == typeof(global::ElevenLabs.PrivateKeyJWTResponseAlgorithm)

                    || typeToConvert == typeof(global::ElevenLabs.PrivateKeyJWTResponseAlgorithm?)

                    || typeToConvert == typeof(global::ElevenLabs.ProcedureType)

                    || typeToConvert == typeof(global::ElevenLabs.ProcedureType?)

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

                    || typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference)

                    || typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference?)

                    || typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference)

                    || typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference?)

                    || typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource)

                    || typeToConvert == typeof(global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource?)

                    || typeToConvert == typeof(global::ElevenLabs.QualityPresetType)

                    || typeToConvert == typeof(global::ElevenLabs.QualityPresetType?)

                    || typeToConvert == typeof(global::ElevenLabs.RAGIndexStatus)

                    || typeToConvert == typeof(global::ElevenLabs.RAGIndexStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType)

                    || typeToConvert == typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType?)

                    || typeToConvert == typeof(global::ElevenLabs.ReferencedToolCommonModelType)

                    || typeToConvert == typeof(global::ElevenLabs.ReferencedToolCommonModelType?)

                    || typeToConvert == typeof(global::ElevenLabs.RenderStatus)

                    || typeToConvert == typeof(global::ElevenLabs.RenderStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.RenderType)

                    || typeToConvert == typeof(global::ElevenLabs.RenderType?)

                    || typeToConvert == typeof(global::ElevenLabs.ResourceAccessInfoRole)

                    || typeToConvert == typeof(global::ElevenLabs.ResourceAccessInfoRole?)

                    || typeToConvert == typeof(global::ElevenLabs.ResourceAccessInfoAnonymousAccessLevelOverride)

                    || typeToConvert == typeof(global::ElevenLabs.ResourceAccessInfoAnonymousAccessLevelOverride?)

                    || typeToConvert == typeof(global::ElevenLabs.ResourceAccessInfoAccessSource)

                    || typeToConvert == typeof(global::ElevenLabs.ResourceAccessInfoAccessSource?)

                    || typeToConvert == typeof(global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride)

                    || typeToConvert == typeof(global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride?)

                    || typeToConvert == typeof(global::ElevenLabs.ResponseConversationErrorType)

                    || typeToConvert == typeof(global::ElevenLabs.ResponseConversationErrorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ResponseFilterMode)

                    || typeToConvert == typeof(global::ElevenLabs.ResponseFilterMode?)

                    || typeToConvert == typeof(global::ElevenLabs.ReviewResponseModelReviewStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ReviewResponseModelReviewStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.SFXModelId)

                    || typeToConvert == typeof(global::ElevenLabs.SFXModelId?)

                    || typeToConvert == typeof(global::ElevenLabs.SIPLogMessageDirection)

                    || typeToConvert == typeof(global::ElevenLabs.SIPLogMessageDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.SIPMediaEncryptionEnum)

                    || typeToConvert == typeof(global::ElevenLabs.SIPMediaEncryptionEnum?)

                    || typeToConvert == typeof(global::ElevenLabs.SIPTrunkTransportEnum)

                    || typeToConvert == typeof(global::ElevenLabs.SIPTrunkTransportEnum?)

                    || typeToConvert == typeof(global::ElevenLabs.SMBAgentType)

                    || typeToConvert == typeof(global::ElevenLabs.SMBAgentType?)

                    || typeToConvert == typeof(global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType)

                    || typeToConvert == typeof(global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType?)

                    || typeToConvert == typeof(global::ElevenLabs.SMSConversationInfoDirection)

                    || typeToConvert == typeof(global::ElevenLabs.SMSConversationInfoDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.SafetyRule)

                    || typeToConvert == typeof(global::ElevenLabs.SafetyRule?)

                    || typeToConvert == typeof(global::ElevenLabs.SampleConfigDBModelParentType)

                    || typeToConvert == typeof(global::ElevenLabs.SampleConfigDBModelParentType?)

                    || typeToConvert == typeof(global::ElevenLabs.SearchStrategy)

                    || typeToConvert == typeof(global::ElevenLabs.SearchStrategy?)

                    || typeToConvert == typeof(global::ElevenLabs.SeatType)

                    || typeToConvert == typeof(global::ElevenLabs.SeatType?)

                    || typeToConvert == typeof(global::ElevenLabs.SecretDependencyResourceType)

                    || typeToConvert == typeof(global::ElevenLabs.SecretDependencyResourceType?)

                    || typeToConvert == typeof(global::ElevenLabs.SecretDependencyType)

                    || typeToConvert == typeof(global::ElevenLabs.SecretDependencyType?)

                    || typeToConvert == typeof(global::ElevenLabs.ShareOptionResponseModelType)

                    || typeToConvert == typeof(global::ElevenLabs.ShareOptionResponseModelType?)

                    || typeToConvert == typeof(global::ElevenLabs.SingleUseTokenType)

                    || typeToConvert == typeof(global::ElevenLabs.SingleUseTokenType?)

                    || typeToConvert == typeof(global::ElevenLabs.SortDirection)

                    || typeToConvert == typeof(global::ElevenLabs.SortDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus)

                    || typeToConvert == typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechHistoryItemResponseModelVoiceCategory)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechHistoryItemResponseModelVoiceCategory?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechHistoryItemResponseModelState)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechHistoryItemResponseModelState?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechHistoryItemResponseModelSource)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechHistoryItemResponseModelSource?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToTextWordResponseModelType)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToTextWordResponseModelType?)

                    || typeToConvert == typeof(global::ElevenLabs.SpellingPatience)

                    || typeToConvert == typeof(global::ElevenLabs.SpellingPatience?)

                    || typeToConvert == typeof(global::ElevenLabs.StartProcedureToolErrorStatus)

                    || typeToConvert == typeof(global::ElevenLabs.StartProcedureToolErrorStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.StudioClipLocatorClipType)

                    || typeToConvert == typeof(global::ElevenLabs.StudioClipLocatorClipType?)

                    || typeToConvert == typeof(global::ElevenLabs.SubscriptionStatusType)

                    || typeToConvert == typeof(global::ElevenLabs.SubscriptionStatusType?)

                    || typeToConvert == typeof(global::ElevenLabs.SystemDataCollectionId)

                    || typeToConvert == typeof(global::ElevenLabs.SystemDataCollectionId?)

                    || typeToConvert == typeof(global::ElevenLabs.SystemEvaluationId)

                    || typeToConvert == typeof(global::ElevenLabs.SystemEvaluationId?)

                    || typeToConvert == typeof(global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType)

                    || typeToConvert == typeof(global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType?)

                    || typeToConvert == typeof(global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType)

                    || typeToConvert == typeof(global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType?)

                    || typeToConvert == typeof(global::ElevenLabs.TTSConversationalModel)

                    || typeToConvert == typeof(global::ElevenLabs.TTSConversationalModel?)

                    || typeToConvert == typeof(global::ElevenLabs.TTSModelFamily)

                    || typeToConvert == typeof(global::ElevenLabs.TTSModelFamily?)

                    || typeToConvert == typeof(global::ElevenLabs.TTSOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.TTSOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.TelephonyDirection)

                    || typeToConvert == typeof(global::ElevenLabs.TelephonyDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.TelephonyProvider)

                    || typeToConvert == typeof(global::ElevenLabs.TelephonyProvider?)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateArrayOutputFailureReason)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateArrayOutputFailureReason?)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateAudioOutputFailureReason)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateAudioOutputFailureReason?)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateBooleanOutputFailureReason)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateBooleanOutputFailureReason?)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateImageOutputFailureReason)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateImageOutputFailureReason?)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateInputReferenceDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateInputReferenceDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateIntegerOutputFailureReason)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateIntegerOutputFailureReason?)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateNumberOutputFailureReason)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateNumberOutputFailureReason?)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateObjectOutputFailureReason)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateObjectOutputFailureReason?)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateOutputDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateRunStatus)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateRunStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateStringOutputFailureReason)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateStringOutputFailureReason?)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateVideoOutputFailureReason)

                    || typeToConvert == typeof(global::ElevenLabs.TemplateVideoOutputFailureReason?)

                    || typeToConvert == typeof(global::ElevenLabs.TestRunMetadataTestType)

                    || typeToConvert == typeof(global::ElevenLabs.TestRunMetadataTestType?)

                    || typeToConvert == typeof(global::ElevenLabs.TestRunStatus)

                    || typeToConvert == typeof(global::ElevenLabs.TestRunStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.TestSharingMode)

                    || typeToConvert == typeof(global::ElevenLabs.TestSharingMode?)

                    || typeToConvert == typeof(global::ElevenLabs.TestType)

                    || typeToConvert == typeof(global::ElevenLabs.TestType?)

                    || typeToConvert == typeof(global::ElevenLabs.TextNormalisationType)

                    || typeToConvert == typeof(global::ElevenLabs.TextNormalisationType?)

                    || typeToConvert == typeof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId)

                    || typeToConvert == typeof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolCallSoundBehavior)

                    || typeToConvert == typeof(global::ElevenLabs.ToolCallSoundBehavior?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolCallSoundType)

                    || typeToConvert == typeof(global::ElevenLabs.ToolCallSoundType?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolErrorHandlingMode)

                    || typeToConvert == typeof(global::ElevenLabs.ToolErrorHandlingMode?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolExecutionTaskSupport)

                    || typeToConvert == typeof(global::ElevenLabs.ToolExecutionTaskSupport?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolExecutionMode)

                    || typeToConvert == typeof(global::ElevenLabs.ToolExecutionMode?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolInterruptionMode)

                    || typeToConvert == typeof(global::ElevenLabs.ToolInterruptionMode?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolSortBy)

                    || typeToConvert == typeof(global::ElevenLabs.ToolSortBy?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolType)

                    || typeToConvert == typeof(global::ElevenLabs.ToolType?)

                    || typeToConvert == typeof(global::ElevenLabs.ToolTypeFilter)

                    || typeToConvert == typeof(global::ElevenLabs.ToolTypeFilter?)

                    || typeToConvert == typeof(global::ElevenLabs.TopicSortBy)

                    || typeToConvert == typeof(global::ElevenLabs.TopicSortBy?)

                    || typeToConvert == typeof(global::ElevenLabs.TranscriptPlatformEvent)

                    || typeToConvert == typeof(global::ElevenLabs.TranscriptPlatformEvent?)

                    || typeToConvert == typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason)

                    || typeToConvert == typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason?)

                    || typeToConvert == typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason)

                    || typeToConvert == typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason?)

                    || typeToConvert == typeof(global::ElevenLabs.TransferTypeEnum)

                    || typeToConvert == typeof(global::ElevenLabs.TransferTypeEnum?)

                    || typeToConvert == typeof(global::ElevenLabs.TurnEagerness)

                    || typeToConvert == typeof(global::ElevenLabs.TurnEagerness?)

                    || typeToConvert == typeof(global::ElevenLabs.TurnMode)

                    || typeToConvert == typeof(global::ElevenLabs.TurnMode?)

                    || typeToConvert == typeof(global::ElevenLabs.TurnModel)

                    || typeToConvert == typeof(global::ElevenLabs.TurnModel?)

                    || typeToConvert == typeof(global::ElevenLabs.TwilioEdgeLocation)

                    || typeToConvert == typeof(global::ElevenLabs.TwilioEdgeLocation?)

                    || typeToConvert == typeof(global::ElevenLabs.TwilioMachineDetectionMode)

                    || typeToConvert == typeof(global::ElevenLabs.TwilioMachineDetectionMode?)

                    || typeToConvert == typeof(global::ElevenLabs.TwilioRegionId)

                    || typeToConvert == typeof(global::ElevenLabs.TwilioRegionId?)

                    || typeToConvert == typeof(global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode)

                    || typeToConvert == typeof(global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode?)

                    || typeToConvert == typeof(global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateMusicFinetuneRequestModelVisibility)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateMusicFinetuneRequestModelVisibility?)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm?)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField?)

                    || typeToConvert == typeof(global::ElevenLabs.UsageAggregationInterval)

                    || typeToConvert == typeof(global::ElevenLabs.UsageAggregationInterval?)

                    || typeToConvert == typeof(global::ElevenLabs.UserFeedbackScore)

                    || typeToConvert == typeof(global::ElevenLabs.UserFeedbackScore?)

                    || typeToConvert == typeof(global::ElevenLabs.UsersSortBy)

                    || typeToConvert == typeof(global::ElevenLabs.UsersSortBy?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceCategory)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceCategory?)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31RequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31RequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31RequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31RequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.VeoImageReferenceRole)

                    || typeToConvert == typeof(global::ElevenLabs.VeoImageReferenceRole?)

                    || typeToConvert == typeof(global::ElevenLabs.Verbosity)

                    || typeToConvert == typeof(global::ElevenLabs.Verbosity?)

                    || typeToConvert == typeof(global::ElevenLabs.VideoAnalysisStatus)

                    || typeToConvert == typeof(global::ElevenLabs.VideoAnalysisStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId)

                    || typeToConvert == typeof(global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId?)

                    || typeToConvert == typeof(global::ElevenLabs.VideoReferenceDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.VideoReferenceDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceDesignRequestModelModelId)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceDesignRequestModelModelId?)

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

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookAuthMethodType)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookAuthMethodType?)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookEventType)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookEventType?)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookTargetDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookTargetDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod?)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInputContentType)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInputContentType?)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod?)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutputContentType)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutputContentType?)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookTranscriptFormat)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookTranscriptFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookUsageType)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookUsageType?)

                    || typeToConvert == typeof(global::ElevenLabs.WhatsAppAccountType)

                    || typeToConvert == typeof(global::ElevenLabs.WhatsAppAccountType?)

                    || typeToConvert == typeof(global::ElevenLabs.WhatsAppConversationInfoDirection)

                    || typeToConvert == typeof(global::ElevenLabs.WhatsAppConversationInfoDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetConfigInputSyntaxHighlightTheme)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetConfigInputSyntaxHighlightTheme?)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetConfigOutputSyntaxHighlightTheme)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetConfigOutputSyntaxHighlightTheme?)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetConfigResponseModelSyntaxHighlightTheme)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetConfigResponseModelSyntaxHighlightTheme?)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetEndFeedbackType)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetEndFeedbackType?)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetExpandable)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetExpandable?)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetFeedbackMode)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetFeedbackMode?)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetPlacement)

                    || typeToConvert == typeof(global::ElevenLabs.WidgetPlacement?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminatorSource)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminatorSource?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceGroupPermission)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceGroupPermission?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceResourceType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceResourceType?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceWebhookEventType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceWebhookEventType?)

                    || typeToConvert == typeof(global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetSpeechHistorySortDirection)

                    || typeToConvert == typeof(global::ElevenLabs.GetSpeechHistorySortDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.GetSpeechHistorySource)

                    || typeToConvert == typeof(global::ElevenLabs.GetSpeechHistorySource?)

                    || typeToConvert == typeof(global::ElevenLabs.TextToSpeechFullOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.TextToSpeechFullOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.TextToSpeechStreamOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.TextToSpeechStreamOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingProjectListSortDirection)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingProjectListSortDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatusesVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatusesVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingModelsVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingModelsVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsCreationSourcesVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsCreationSourcesVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsFilterByCreator)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsFilterByCreator?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsOrderBy)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsOrderBy?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsOrderDirection)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsOrderDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType)

                    || typeToConvert == typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType)

                    || typeToConvert == typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataSort)

                    || typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataSort?)

                    || typeToConvert == typeof(global::ElevenLabs.ListChatResponseTestsRouteSortMode)

                    || typeToConvert == typeof(global::ElevenLabs.ListChatResponseTestsRouteSortMode?)

                    || typeToConvert == typeof(global::ElevenLabs.GetConversationHistoriesRouteSummaryMode)

                    || typeToConvert == typeof(global::ElevenLabs.GetConversationHistoriesRouteSummaryMode?)

                    || typeToConvert == typeof(global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.GetConversationHistoryRouteFormat)

                    || typeToConvert == typeof(global::ElevenLabs.GetConversationHistoryRouteFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode)

                    || typeToConvert == typeof(global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode?)

                    || typeToConvert == typeof(global::ElevenLabs.ListEnvironmentVariablesType)

                    || typeToConvert == typeof(global::ElevenLabs.ListEnvironmentVariablesType?)

                    || typeToConvert == typeof(global::ElevenLabs.GenerateOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.GenerateOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ComposeDetailedOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ComposeDetailedOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ComposeDetailedStreamOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ComposeDetailedStreamOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.StreamComposeOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.StreamComposeOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.GetFinetunesSort)

                    || typeToConvert == typeof(global::ElevenLabs.GetFinetunesSort?)

                    || typeToConvert == typeof(global::ElevenLabs.GetFinetunesSortDirection)

                    || typeToConvert == typeof(global::ElevenLabs.GetFinetunesSortDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.ListVideoGenerationsStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ListVideoGenerationsStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ListImageGenerationsStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ListImageGenerationsStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ListTextToSpeechGenerationsStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ListTextToSpeechGenerationsStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType)

                    || typeToConvert == typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType?)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider)

                    || typeToConvert == typeof(global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider?)

                    || typeToConvert == typeof(global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminatorProvider)

                    || typeToConvert == typeof(global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminatorProvider?)

                    || typeToConvert == typeof(global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminatorProvider)

                    || typeToConvert == typeof(global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminatorProvider?)

                    || typeToConvert == typeof(global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.ASRInputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ASRInputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ASRInputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ASRInputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ASRProvider))
                {
                    return new global::ElevenLabs.JsonConverters.ASRProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ASRProvider?))
                {
                    return new global::ElevenLabs.JsonConverters.ASRProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ASRQuality))
                {
                    return new global::ElevenLabs.JsonConverters.ASRQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ASRQuality?))
                {
                    return new global::ElevenLabs.JsonConverters.ASRQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ASTNodeInputDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ASTNodeInputDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ASTNodeInputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ASTNodeOutputDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ASTNodeOutputDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ASTNodeOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource))
                {
                    return new global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource?))
                {
                    return new global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource))
                {
                    return new global::ElevenLabs.JsonConverters.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource))
                {
                    return new global::ElevenLabs.JsonConverters.AgentAnalysisItemsInputDataCollectionItemDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentAnalysisItemsInputDataCollectionItemDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource))
                {
                    return new global::ElevenLabs.JsonConverters.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource))
                {
                    return new global::ElevenLabs.JsonConverters.AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketIssueType))
                {
                    return new global::ElevenLabs.JsonConverters.AgentConversationTicketIssueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketIssueType?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentConversationTicketIssueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketPriority))
                {
                    return new global::ElevenLabs.JsonConverters.AgentConversationTicketPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketPriority?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentConversationTicketPriorityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketSortBy))
                {
                    return new global::ElevenLabs.JsonConverters.AgentConversationTicketSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketSortBy?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentConversationTicketSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketSource))
                {
                    return new global::ElevenLabs.JsonConverters.AgentConversationTicketSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketSource?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentConversationTicketSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketStatus))
                {
                    return new global::ElevenLabs.JsonConverters.AgentConversationTicketStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentConversationTicketStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentConversationTicketStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentDefinitionSource))
                {
                    return new global::ElevenLabs.JsonConverters.AgentDefinitionSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentDefinitionSource?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentDefinitionSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentDeploymentSource))
                {
                    return new global::ElevenLabs.JsonConverters.AgentDeploymentSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentDeploymentSource?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentDeploymentSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus))
                {
                    return new global::ElevenLabs.JsonConverters.AgentMergeProposalResponseOutcomeDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentMergeProposalResponseOutcomeDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentSortBy))
                {
                    return new global::ElevenLabs.JsonConverters.AgentSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentSortBy?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentTestEntityType))
                {
                    return new global::ElevenLabs.JsonConverters.AgentTestEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentTestEntityType?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentTestEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentTransferOpDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.AgentTransferOpDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentTransferOpDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentTransferOpDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentTrustContext))
                {
                    return new global::ElevenLabs.JsonConverters.AgentTrustContextJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentTrustContext?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentTrustContextNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AlertingWebhookMethod))
                {
                    return new global::ElevenLabs.JsonConverters.AlertingWebhookMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AlertingWebhookMethod?))
                {
                    return new global::ElevenLabs.JsonConverters.AlertingWebhookMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AllowedOutputFormats))
                {
                    return new global::ElevenLabs.JsonConverters.AllowedOutputFormatsJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AllowedOutputFormats?))
                {
                    return new global::ElevenLabs.JsonConverters.AllowedOutputFormatsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AnalysisPropertyType))
                {
                    return new global::ElevenLabs.JsonConverters.AnalysisPropertyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AnalysisPropertyType?))
                {
                    return new global::ElevenLabs.JsonConverters.AnalysisPropertyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AnalysisScope))
                {
                    return new global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AnalysisScope?))
                {
                    return new global::ElevenLabs.JsonConverters.AnalysisScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AnalysisType))
                {
                    return new global::ElevenLabs.JsonConverters.AnalysisTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AnalysisType?))
                {
                    return new global::ElevenLabs.JsonConverters.AnalysisTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator))
                {
                    return new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator?))
                {
                    return new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator))
                {
                    return new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator?))
                {
                    return new global::ElevenLabs.JsonConverters.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource))
                {
                    return new global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource?))
                {
                    return new global::ElevenLabs.JsonConverters.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind))
                {
                    return new global::ElevenLabs.JsonConverters.ArrayJsonSchemaPropertyInputPropertyKindJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind?))
                {
                    return new global::ElevenLabs.JsonConverters.ArrayJsonSchemaPropertyInputPropertyKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AssetTranscriptionStatus))
                {
                    return new global::ElevenLabs.JsonConverters.AssetTranscriptionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AssetTranscriptionStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.AssetTranscriptionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AsyncConversationMetadataDeliveryStatus))
                {
                    return new global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AsyncConversationMetadataDeliveryStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.AsyncConversationMetadataDeliveryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AudioAnalysisStatus))
                {
                    return new global::ElevenLabs.JsonConverters.AudioAnalysisStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AudioAnalysisStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.AudioAnalysisStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus))
                {
                    return new global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AudioReferenceDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.AudioReferenceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AudioReferenceDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.AudioReferenceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.AuthConnectionDependenciesMcpServerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthConnectionStatus))
                {
                    return new global::ElevenLabs.JsonConverters.AuthConnectionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthConnectionStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.AuthConnectionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthorizationMethod))
                {
                    return new global::ElevenLabs.JsonConverters.AuthorizationMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AuthorizationMethod?))
                {
                    return new global::ElevenLabs.JsonConverters.AuthorizationMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BackgroundSoundPresetId))
                {
                    return new global::ElevenLabs.JsonConverters.BackgroundSoundPresetIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BackgroundSoundPresetId?))
                {
                    return new global::ElevenLabs.JsonConverters.BackgroundSoundPresetIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BackgroundSoundSourceType))
                {
                    return new global::ElevenLabs.JsonConverters.BackgroundSoundSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BackgroundSoundSourceType?))
                {
                    return new global::ElevenLabs.JsonConverters.BackgroundSoundSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BanReasonType))
                {
                    return new global::ElevenLabs.JsonConverters.BanReasonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BanReasonType?))
                {
                    return new global::ElevenLabs.JsonConverters.BanReasonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BatchCallRecipientStatus))
                {
                    return new global::ElevenLabs.JsonConverters.BatchCallRecipientStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BatchCallRecipientStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.BatchCallRecipientStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BatchCallStatus))
                {
                    return new global::ElevenLabs.JsonConverters.BatchCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BatchCallStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.BatchCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BillingPeriod))
                {
                    return new global::ElevenLabs.JsonConverters.BillingPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BillingPeriod?))
                {
                    return new global::ElevenLabs.JsonConverters.BillingPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess))
                {
                    return new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess))
                {
                    return new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat))
                {
                    return new global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat))
                {
                    return new global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix))
                {
                    return new global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateDubbingProjectV1DubbingProjectPostModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateDubbingProjectV1DubbingProjectPostModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibilityNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode))
                {
                    return new global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item))
                {
                    return new global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort))
                {
                    return new global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSortJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole))
                {
                    return new global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity?))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle?))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId))
                {
                    return new global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissionsJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIpsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowedJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BranchProtectionStatus))
                {
                    return new global::ElevenLabs.JsonConverters.BranchProtectionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BranchProtectionStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.BranchProtectionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BreakdownTypes))
                {
                    return new global::ElevenLabs.JsonConverters.BreakdownTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BreakdownTypes?))
                {
                    return new global::ElevenLabs.JsonConverters.BreakdownTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BucketingStatus))
                {
                    return new global::ElevenLabs.JsonConverters.BucketingStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BucketingStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.BucketingStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance25RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance25RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance25RequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance25RequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2FastRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2FastRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2FastRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2FastRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2MiniRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2MiniRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2MiniRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2MiniRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2RequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2RequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5LiteRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5LiteRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5LiteRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5LiteRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5ProRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5ProRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5ProRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5ProRequestResolutionNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.CharacterAge))
                {
                    return new global::ElevenLabs.JsonConverters.CharacterAgeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CharacterAge?))
                {
                    return new global::ElevenLabs.JsonConverters.CharacterAgeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CharacterGender))
                {
                    return new global::ElevenLabs.JsonConverters.CharacterGenderJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CharacterGender?))
                {
                    return new global::ElevenLabs.JsonConverters.CharacterGenderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CharacterRefreshPeriod))
                {
                    return new global::ElevenLabs.JsonConverters.CharacterRefreshPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CharacterRefreshPeriod?))
                {
                    return new global::ElevenLabs.JsonConverters.CharacterRefreshPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CharacterRole))
                {
                    return new global::ElevenLabs.JsonConverters.CharacterRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CharacterRole?))
                {
                    return new global::ElevenLabs.JsonConverters.CharacterRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ChatSourceMedium))
                {
                    return new global::ElevenLabs.JsonConverters.ChatSourceMediumJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ChatSourceMedium?))
                {
                    return new global::ElevenLabs.JsonConverters.ChatSourceMediumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ClientEvent))
                {
                    return new global::ElevenLabs.JsonConverters.ClientEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ClientEvent?))
                {
                    return new global::ElevenLabs.JsonConverters.ClientEventNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.ColumnFilterOperation))
                {
                    return new global::ElevenLabs.JsonConverters.ColumnFilterOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ColumnFilterOperation?))
                {
                    return new global::ElevenLabs.JsonConverters.ColumnFilterOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ColumnUnit))
                {
                    return new global::ElevenLabs.JsonConverters.ColumnUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ColumnUnit?))
                {
                    return new global::ElevenLabs.JsonConverters.ColumnUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConfigEntityType))
                {
                    return new global::ElevenLabs.JsonConverters.ConfigEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConfigEntityType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConfigEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConflictSection))
                {
                    return new global::ElevenLabs.JsonConverters.ConflictSectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConflictSection?))
                {
                    return new global::ElevenLabs.JsonConverters.ConflictSectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ContentFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ContentFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ContentFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ContentFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ContentGuardrailInputTriggerActionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ContentGuardrailOutputTriggerActionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ContentSchemaDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ContentSchemaDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ContentSchemaDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ContentSchemaDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ContentThresholdGuardrailThreshold))
                {
                    return new global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ContentThresholdGuardrailThreshold?))
                {
                    return new global::ElevenLabs.JsonConverters.ContentThresholdGuardrailThresholdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConvAIStoredSecretDependenciesMcpServerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationErrorType))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationErrorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationErrorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelInputRole))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelInputRole?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutputRole))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutputRole?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.ConversationProduct))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationProductJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationProduct?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationSentimentAnalysisOverallLabel))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationSentimentAnalysisOverallLabelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationSentimentAnalysisOverallLabel?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationSentimentAnalysisOverallLabelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationSummaryMessageModelRole))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationSummaryMessageModelRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationSummaryMessageModelRole?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationSummaryMessageModelRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationSummaryResponseModelStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationSummaryResponseModelStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationSummaryResponseModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationTokenPurpose))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationTokenPurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ConversationTokenPurpose?))
                {
                    return new global::ElevenLabs.JsonConverters.ConversationTokenPurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CrawlStatus))
                {
                    return new global::ElevenLabs.JsonConverters.CrawlStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CrawlStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.CrawlStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CrawlType))
                {
                    return new global::ElevenLabs.JsonConverters.CrawlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CrawlType?))
                {
                    return new global::ElevenLabs.JsonConverters.CrawlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm))
                {
                    return new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm?))
                {
                    return new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField))
                {
                    return new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField?))
                {
                    return new global::ElevenLabs.JsonConverters.CreateOAuth2JWTRequestTokenResponseFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm))
                {
                    return new global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm?))
                {
                    return new global::ElevenLabs.JsonConverters.CreatePrivateKeyJWTRequestAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreatifyAuroraRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.CreatifyAuroraRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreatifyAuroraRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.CreatifyAuroraRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CriteriaScoringMode))
                {
                    return new global::ElevenLabs.JsonConverters.CriteriaScoringModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CriteriaScoringMode?))
                {
                    return new global::ElevenLabs.JsonConverters.CriteriaScoringModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Currency))
                {
                    return new global::ElevenLabs.JsonConverters.CurrencyJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Currency?))
                {
                    return new global::ElevenLabs.JsonConverters.CurrencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CustomGuardrailConfigModel))
                {
                    return new global::ElevenLabs.JsonConverters.CustomGuardrailConfigModelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CustomGuardrailConfigModel?))
                {
                    return new global::ElevenLabs.JsonConverters.CustomGuardrailConfigModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.CustomGuardrailConfigTriggerActionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CustomLLMAPIType))
                {
                    return new global::ElevenLabs.JsonConverters.CustomLLMAPITypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CustomLLMAPIType?))
                {
                    return new global::ElevenLabs.JsonConverters.CustomLLMAPITypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel))
                {
                    return new global::ElevenLabs.JsonConverters.DefaultSharingGroupConfigPermissionLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel?))
                {
                    return new global::ElevenLabs.JsonConverters.DefaultSharingGroupConfigPermissionLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel))
                {
                    return new global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel?))
                {
                    return new global::ElevenLabs.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DependentAvailableAgentIdentifierAccessLevel))
                {
                    return new global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DependentAvailableAgentIdentifierAccessLevel?))
                {
                    return new global::ElevenLabs.JsonConverters.DependentAvailableAgentIdentifierAccessLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel))
                {
                    return new global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel?))
                {
                    return new global::ElevenLabs.JsonConverters.DependentAvailableMCPServerIdentifierAccessLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel))
                {
                    return new global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel?))
                {
                    return new global::ElevenLabs.JsonConverters.DependentAvailableToolIdentifierAccessLevelNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.DocumentUsageModeEnum))
                {
                    return new global::ElevenLabs.JsonConverters.DocumentUsageModeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DocumentUsageModeEnum?))
                {
                    return new global::ElevenLabs.JsonConverters.DocumentUsageModeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingLanguageResponseStatus))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingLanguageResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingLanguageResponseStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingLanguageResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingProjectResponseStatus))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingProjectResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingProjectResponseStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingProjectResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingReleaseChannel))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingReleaseChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingReleaseChannel?))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingReleaseChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ElevenFlashV25RequestOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ElevenFlashV25RequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ElevenFlashV25RequestOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ElevenFlashV25RequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ElevenMultilingualV2RequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ElevenMultilingualV2RequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ElevenV3RequestOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ElevenV3RequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ElevenV3RequestOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ElevenV3RequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EmbedVariant))
                {
                    return new global::ElevenLabs.JsonConverters.EmbedVariantJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EmbedVariant?))
                {
                    return new global::ElevenLabs.JsonConverters.EmbedVariantNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.EntryBehavior))
                {
                    return new global::ElevenLabs.JsonConverters.EntryBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EntryBehavior?))
                {
                    return new global::ElevenLabs.JsonConverters.EntryBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EnvironmentVariableResponseType))
                {
                    return new global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EnvironmentVariableResponseType?))
                {
                    return new global::ElevenLabs.JsonConverters.EnvironmentVariableResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EvaluationResultFilter))
                {
                    return new global::ElevenLabs.JsonConverters.EvaluationResultFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EvaluationResultFilter?))
                {
                    return new global::ElevenLabs.JsonConverters.EvaluationResultFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EvaluationSuccessResult))
                {
                    return new global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.EvaluationSuccessResult?))
                {
                    return new global::ElevenLabs.JsonConverters.EvaluationSuccessResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExotelApiSubdomain))
                {
                    return new global::ElevenLabs.JsonConverters.ExotelApiSubdomainJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExotelApiSubdomain?))
                {
                    return new global::ElevenLabs.JsonConverters.ExotelApiSubdomainNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExperimentAssignmentSource))
                {
                    return new global::ElevenLabs.JsonConverters.ExperimentAssignmentSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExperimentAssignmentSource?))
                {
                    return new global::ElevenLabs.JsonConverters.ExperimentAssignmentSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExportOptionsDiscriminatorFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExportOptionsDiscriminatorFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExternalSyncJobTrigger))
                {
                    return new global::ElevenLabs.JsonConverters.ExternalSyncJobTriggerJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExternalSyncJobTrigger?))
                {
                    return new global::ElevenLabs.JsonConverters.ExternalSyncJobTriggerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExternalSyncJobType))
                {
                    return new global::ElevenLabs.JsonConverters.ExternalSyncJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExternalSyncJobType?))
                {
                    return new global::ElevenLabs.JsonConverters.ExternalSyncJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExternalSyncProvider))
                {
                    return new global::ElevenLabs.JsonConverters.ExternalSyncProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExternalSyncProvider?))
                {
                    return new global::ElevenLabs.JsonConverters.ExternalSyncProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.FineTuningResponseModelState2))
                {
                    return new global::ElevenLabs.JsonConverters.FineTuningResponseModelState2JsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.FineTuningResponseModelState2?))
                {
                    return new global::ElevenLabs.JsonConverters.FineTuningResponseModelState2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.FinetuneCreatedBy))
                {
                    return new global::ElevenLabs.JsonConverters.FinetuneCreatedByJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.FinetuneCreatedBy?))
                {
                    return new global::ElevenLabs.JsonConverters.FinetuneCreatedByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.FinetuneVisibility))
                {
                    return new global::ElevenLabs.JsonConverters.FinetuneVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.FinetuneVisibility?))
                {
                    return new global::ElevenLabs.JsonConverters.FinetuneVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.FrustratedConversationRefOverallLabel))
                {
                    return new global::ElevenLabs.JsonConverters.FrustratedConversationRefOverallLabelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.FrustratedConversationRefOverallLabel?))
                {
                    return new global::ElevenLabs.JsonConverters.FrustratedConversationRefOverallLabelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestQuality))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage1RequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestQuality?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage1RequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestBackground))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage1RequestBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestBackground?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage1RequestBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage1RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage1RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestQuality))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage15RequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestQuality?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage15RequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestBackground))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage15RequestBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestBackground?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage15RequestBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage15RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage15RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage25FlareRequestQuality))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage25FlareRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage25FlareRequestQuality?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage25FlareRequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage25FlareRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage25FlareRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage25FlareRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage25FlareRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage25FlareRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage25FlareRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage25FlareRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage25FlareRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage25SunburstRequestQuality))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage25SunburstRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage25SunburstRequestQuality?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage25SunburstRequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage25SunburstRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage25SunburstRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage25SunburstRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage25SunburstRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage25SunburstRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage25SunburstRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage25SunburstRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage25SunburstRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestQuality))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage2RequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestQuality?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage2RequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage2RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage2RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage2RequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage2RequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini25FlashImageRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini25FlashImageRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini25FlashImageRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini25FlashImageRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini31FlashImageRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini31FlashImageRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini31FlashImageRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini31FlashImageRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini31FlashLiteImageRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini31FlashLiteImageRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini3ProImageRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini3ProImageRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini3ProImageRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini3ProImageRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputContextAdherence))
                {
                    return new global::ElevenLabs.JsonConverters.GenerationChunkInputContextAdherenceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputContextAdherence?))
                {
                    return new global::ElevenLabs.JsonConverters.GenerationChunkInputContextAdherenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputConditionStrength))
                {
                    return new global::ElevenLabs.JsonConverters.GenerationChunkInputConditionStrengthJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputConditionStrength?))
                {
                    return new global::ElevenLabs.JsonConverters.GenerationChunkInputConditionStrengthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerationChunkOutputContextAdherence))
                {
                    return new global::ElevenLabs.JsonConverters.GenerationChunkOutputContextAdherenceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerationChunkOutputContextAdherence?))
                {
                    return new global::ElevenLabs.JsonConverters.GenerationChunkOutputContextAdherenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerationChunkOutputConditionStrength))
                {
                    return new global::ElevenLabs.JsonConverters.GenerationChunkOutputConditionStrengthJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerationChunkOutputConditionStrength?))
                {
                    return new global::ElevenLabs.JsonConverters.GenerationChunkOutputConditionStrengthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenesysBotOutcome))
                {
                    return new global::ElevenLabs.JsonConverters.GenesysBotOutcomeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenesysBotOutcome?))
                {
                    return new global::ElevenLabs.JsonConverters.GenesysBotOutcomeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenesysRegion))
                {
                    return new global::ElevenLabs.JsonConverters.GenesysRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenesysRegion?))
                {
                    return new global::ElevenLabs.JsonConverters.GenesysRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider))
                {
                    return new global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider?))
                {
                    return new global::ElevenLabs.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConversationResponseModelStatus))
                {
                    return new global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConversationResponseModelStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.GetConversationResponseModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConversationSummaryResponseModelStatus))
                {
                    return new global::ElevenLabs.JsonConverters.GetConversationSummaryResponseModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConversationSummaryResponseModelStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.GetConversationSummaryResponseModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider))
                {
                    return new global::ElevenLabs.JsonConverters.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider?))
                {
                    return new global::ElevenLabs.JsonConverters.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource))
                {
                    return new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource?))
                {
                    return new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource))
                {
                    return new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource?))
                {
                    return new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GuardrailExecutionMode))
                {
                    return new global::ElevenLabs.JsonConverters.GuardrailExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GuardrailExecutionMode?))
                {
                    return new global::ElevenLabs.JsonConverters.GuardrailExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GuardrailType))
                {
                    return new global::ElevenLabs.JsonConverters.GuardrailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GuardrailType?))
                {
                    return new global::ElevenLabs.JsonConverters.GuardrailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.HidingReason))
                {
                    return new global::ElevenLabs.JsonConverters.HidingReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.HidingReason?))
                {
                    return new global::ElevenLabs.JsonConverters.HidingReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.IconTheme))
                {
                    return new global::ElevenLabs.JsonConverters.IconThemeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.IconTheme?))
                {
                    return new global::ElevenLabs.JsonConverters.IconThemeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ImageAnalysisStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ImageAnalysisStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ImageAnalysisStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ImageAnalysisStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId))
                {
                    return new global::ElevenLabs.JsonConverters.ImageGenerationRequestDiscriminatorModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId?))
                {
                    return new global::ElevenLabs.JsonConverters.ImageGenerationRequestDiscriminatorModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ImageReferenceDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ImageReferenceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ImageReferenceDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ImageReferenceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineAudioReferenceMimeType))
                {
                    return new global::ElevenLabs.JsonConverters.InlineAudioReferenceMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineAudioReferenceMimeType?))
                {
                    return new global::ElevenLabs.JsonConverters.InlineAudioReferenceMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineBase64ReferenceMimeType))
                {
                    return new global::ElevenLabs.JsonConverters.InlineBase64ReferenceMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineBase64ReferenceMimeType?))
                {
                    return new global::ElevenLabs.JsonConverters.InlineBase64ReferenceMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineImageReferenceMimeType))
                {
                    return new global::ElevenLabs.JsonConverters.InlineImageReferenceMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineImageReferenceMimeType?))
                {
                    return new global::ElevenLabs.JsonConverters.InlineImageReferenceMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineVideoReferenceMimeType))
                {
                    return new global::ElevenLabs.JsonConverters.InlineVideoReferenceMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineVideoReferenceMimeType?))
                {
                    return new global::ElevenLabs.JsonConverters.InlineVideoReferenceMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.IntegrationType))
                {
                    return new global::ElevenLabs.JsonConverters.IntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.IntegrationType?))
                {
                    return new global::ElevenLabs.JsonConverters.IntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InteractionBudget))
                {
                    return new global::ElevenLabs.JsonConverters.InteractionBudgetJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InteractionBudget?))
                {
                    return new global::ElevenLabs.JsonConverters.InteractionBudgetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InvoiceResponseModelPaymentIntentStatus))
                {
                    return new global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InvoiceResponseModelPaymentIntentStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse))
                {
                    return new global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse?))
                {
                    return new global::ElevenLabs.JsonConverters.InvoiceResponseModelPaymentIntentStatusseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseContentSearchResultDocumentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseDependentType))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseDependentType?))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseDependentTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseSortBy))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseSortBy?))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.LLMLiteralJsonSchemaPropertyType))
                {
                    return new global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?))
                {
                    return new global::ElevenLabs.JsonConverters.LLMLiteralJsonSchemaPropertyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LLMReasoningEffort))
                {
                    return new global::ElevenLabs.JsonConverters.LLMReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LLMReasoningEffort?))
                {
                    return new global::ElevenLabs.JsonConverters.LLMReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LanguagesResponseDiscriminatorKind))
                {
                    return new global::ElevenLabs.JsonConverters.LanguagesResponseDiscriminatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LanguagesResponseDiscriminatorKind?))
                {
                    return new global::ElevenLabs.JsonConverters.LanguagesResponseDiscriminatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LibraryVoiceResponseModelCategory))
                {
                    return new global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LibraryVoiceResponseModelCategory?))
                {
                    return new global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType))
                {
                    return new global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType?))
                {
                    return new global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LiteralJsonSchemaPropertyType))
                {
                    return new global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LiteralJsonSchemaPropertyType?))
                {
                    return new global::ElevenLabs.JsonConverters.LiteralJsonSchemaPropertyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LivekitStackType))
                {
                    return new global::ElevenLabs.JsonConverters.LivekitStackTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LivekitStackType?))
                {
                    return new global::ElevenLabs.JsonConverters.LivekitStackTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LoadMemoryEntryToolErrorStatus))
                {
                    return new global::ElevenLabs.JsonConverters.LoadMemoryEntryToolErrorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LoadMemoryEntryToolErrorStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.LoadMemoryEntryToolErrorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LockReason))
                {
                    return new global::ElevenLabs.JsonConverters.LockReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LockReason?))
                {
                    return new global::ElevenLabs.JsonConverters.LockReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPApprovalPolicy))
                {
                    return new global::ElevenLabs.JsonConverters.MCPApprovalPolicyJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPApprovalPolicy?))
                {
                    return new global::ElevenLabs.JsonConverters.MCPApprovalPolicyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPServerTransport))
                {
                    return new global::ElevenLabs.JsonConverters.MCPServerTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPServerTransport?))
                {
                    return new global::ElevenLabs.JsonConverters.MCPServerTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolApprovalPolicy))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolApprovalPolicy?))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolApprovalPolicyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolApprovalState))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolApprovalStateJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolApprovalState?))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolApprovalStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource?))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource?))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminatorSource))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminatorSource?))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource?))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource?))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource?))
                {
                    return new global::ElevenLabs.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaCodec))
                {
                    return new global::ElevenLabs.JsonConverters.MediaCodecJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaCodec?))
                {
                    return new global::ElevenLabs.JsonConverters.MediaCodecNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaGenerationFailedResponseFailureReason))
                {
                    return new global::ElevenLabs.JsonConverters.MediaGenerationFailedResponseFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaGenerationFailedResponseFailureReason?))
                {
                    return new global::ElevenLabs.JsonConverters.MediaGenerationFailedResponseFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaGenerationInProgressResponseStatus))
                {
                    return new global::ElevenLabs.JsonConverters.MediaGenerationInProgressResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaGenerationInProgressResponseStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.MediaGenerationInProgressResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus))
                {
                    return new global::ElevenLabs.JsonConverters.MediaGenerationResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.MediaGenerationResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminatorProvider))
                {
                    return new global::ElevenLabs.JsonConverters.MergePreviewResponseModelPhoneNumberDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminatorProvider?))
                {
                    return new global::ElevenLabs.JsonConverters.MergePreviewResponseModelPhoneNumberDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MergeProposalCloseReason))
                {
                    return new global::ElevenLabs.JsonConverters.MergeProposalCloseReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MergeProposalCloseReason?))
                {
                    return new global::ElevenLabs.JsonConverters.MergeProposalCloseReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MergeProposalReviewReviewerRole))
                {
                    return new global::ElevenLabs.JsonConverters.MergeProposalReviewReviewerRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MergeProposalReviewReviewerRole?))
                {
                    return new global::ElevenLabs.JsonConverters.MergeProposalReviewReviewerRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MergeProposalReviewState))
                {
                    return new global::ElevenLabs.JsonConverters.MergeProposalReviewStateJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MergeProposalReviewState?))
                {
                    return new global::ElevenLabs.JsonConverters.MergeProposalReviewStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MergeProposalStatus))
                {
                    return new global::ElevenLabs.JsonConverters.MergeProposalStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MergeProposalStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.MergeProposalStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MessageSearchSortBy))
                {
                    return new global::ElevenLabs.JsonConverters.MessageSearchSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MessageSearchSortBy?))
                {
                    return new global::ElevenLabs.JsonConverters.MessageSearchSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MetricType))
                {
                    return new global::ElevenLabs.JsonConverters.MetricTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MetricType?))
                {
                    return new global::ElevenLabs.JsonConverters.MetricTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MockNoMatchBehavior))
                {
                    return new global::ElevenLabs.JsonConverters.MockNoMatchBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MockNoMatchBehavior?))
                {
                    return new global::ElevenLabs.JsonConverters.MockNoMatchBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MockingStrategy))
                {
                    return new global::ElevenLabs.JsonConverters.MockingStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MockingStrategy?))
                {
                    return new global::ElevenLabs.JsonConverters.MockingStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ModerationStatusResponseModelSafetyStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ModerationStatusResponseModelSafetyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ModerationStatusResponseModelSafetyStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ModerationStatusResponseModelSafetyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ModerationStatusResponseModelWarningStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ModerationStatusResponseModelWarningStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ModerationStatusResponseModelWarningStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ModerationStatusResponseModelWarningStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicFinetuneFailureReason))
                {
                    return new global::ElevenLabs.JsonConverters.MusicFinetuneFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicFinetuneFailureReason?))
                {
                    return new global::ElevenLabs.JsonConverters.MusicFinetuneFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicFinetuneStatus))
                {
                    return new global::ElevenLabs.JsonConverters.MusicFinetuneStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicFinetuneStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.MusicFinetuneStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicGenerationMode))
                {
                    return new global::ElevenLabs.JsonConverters.MusicGenerationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicGenerationMode?))
                {
                    return new global::ElevenLabs.JsonConverters.MusicGenerationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicModelID))
                {
                    return new global::ElevenLabs.JsonConverters.MusicModelIDJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicModelID?))
                {
                    return new global::ElevenLabs.JsonConverters.MusicModelIDNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicOnlyOutputFormats))
                {
                    return new global::ElevenLabs.JsonConverters.MusicOnlyOutputFormatsJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicOnlyOutputFormats?))
                {
                    return new global::ElevenLabs.JsonConverters.MusicOnlyOutputFormatsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.NonStreamingOutputFormats))
                {
                    return new global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.NonStreamingOutputFormats?))
                {
                    return new global::ElevenLabs.JsonConverters.NonStreamingOutputFormatsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseAlgorithm))
                {
                    return new global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseAlgorithm?))
                {
                    return new global::ElevenLabs.JsonConverters.OAuth2JWTResponseAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseTokenResponseField))
                {
                    return new global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OAuth2JWTResponseTokenResponseField?))
                {
                    return new global::ElevenLabs.JsonConverters.OAuth2JWTResponseTokenResponseFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ObjectJsonSchemaPropertyInputPropertyKind))
                {
                    return new global::ElevenLabs.JsonConverters.ObjectJsonSchemaPropertyInputPropertyKindJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ObjectJsonSchemaPropertyInputPropertyKind?))
                {
                    return new global::ElevenLabs.JsonConverters.ObjectJsonSchemaPropertyInputPropertyKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderItemKind))
                {
                    return new global::ElevenLabs.JsonConverters.OrderItemKindJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderItemKind?))
                {
                    return new global::ElevenLabs.JsonConverters.OrderItemKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderItemRequestInputDiscriminatorKind))
                {
                    return new global::ElevenLabs.JsonConverters.OrderItemRequestInputDiscriminatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderItemRequestInputDiscriminatorKind?))
                {
                    return new global::ElevenLabs.JsonConverters.OrderItemRequestInputDiscriminatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind))
                {
                    return new global::ElevenLabs.JsonConverters.OrderItemRequestOutputDiscriminatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind?))
                {
                    return new global::ElevenLabs.JsonConverters.OrderItemRequestOutputDiscriminatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderState))
                {
                    return new global::ElevenLabs.JsonConverters.OrderStateJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderState?))
                {
                    return new global::ElevenLabs.JsonConverters.OrderStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.OutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.OutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PendingClipTaskType))
                {
                    return new global::ElevenLabs.JsonConverters.PendingClipTaskTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PendingClipTaskType?))
                {
                    return new global::ElevenLabs.JsonConverters.PendingClipTaskTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier))
                {
                    return new global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier?))
                {
                    return new global::ElevenLabs.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PermissionType))
                {
                    return new global::ElevenLabs.JsonConverters.PermissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PermissionType?))
                {
                    return new global::ElevenLabs.JsonConverters.PermissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PhoneNumberSortBy))
                {
                    return new global::ElevenLabs.JsonConverters.PhoneNumberSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PhoneNumberSortBy?))
                {
                    return new global::ElevenLabs.JsonConverters.PhoneNumberSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.PhoneNumberTransferTransferDestinationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PlatformCategory))
                {
                    return new global::ElevenLabs.JsonConverters.PlatformCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PlatformCategory?))
                {
                    return new global::ElevenLabs.JsonConverters.PlatformCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PreToolSpeechMode))
                {
                    return new global::ElevenLabs.JsonConverters.PreToolSpeechModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PreToolSpeechMode?))
                {
                    return new global::ElevenLabs.JsonConverters.PreToolSpeechModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PrivateKeyJWTResponseAlgorithm))
                {
                    return new global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PrivateKeyJWTResponseAlgorithm?))
                {
                    return new global::ElevenLabs.JsonConverters.PrivateKeyJWTResponseAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProcedureType))
                {
                    return new global::ElevenLabs.JsonConverters.ProcedureTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ProcedureType?))
                {
                    return new global::ElevenLabs.JsonConverters.ProcedureTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference))
                {
                    return new global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference?))
                {
                    return new global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference))
                {
                    return new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference?))
                {
                    return new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.RAGIndexStatus))
                {
                    return new global::ElevenLabs.JsonConverters.RAGIndexStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.RAGIndexStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.RAGIndexStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType))
                {
                    return new global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType?))
                {
                    return new global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ReferencedToolCommonModelType))
                {
                    return new global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ReferencedToolCommonModelType?))
                {
                    return new global::ElevenLabs.JsonConverters.ReferencedToolCommonModelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.RenderStatus))
                {
                    return new global::ElevenLabs.JsonConverters.RenderStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.RenderStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.RenderStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.RenderType))
                {
                    return new global::ElevenLabs.JsonConverters.RenderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.RenderType?))
                {
                    return new global::ElevenLabs.JsonConverters.RenderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResourceAccessInfoRole))
                {
                    return new global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResourceAccessInfoRole?))
                {
                    return new global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResourceAccessInfoAnonymousAccessLevelOverride))
                {
                    return new global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverrideJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResourceAccessInfoAnonymousAccessLevelOverride?))
                {
                    return new global::ElevenLabs.JsonConverters.ResourceAccessInfoAnonymousAccessLevelOverrideNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResourceAccessInfoAccessSource))
                {
                    return new global::ElevenLabs.JsonConverters.ResourceAccessInfoAccessSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResourceAccessInfoAccessSource?))
                {
                    return new global::ElevenLabs.JsonConverters.ResourceAccessInfoAccessSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride))
                {
                    return new global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverrideJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride?))
                {
                    return new global::ElevenLabs.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverrideNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResponseConversationErrorType))
                {
                    return new global::ElevenLabs.JsonConverters.ResponseConversationErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResponseConversationErrorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ResponseConversationErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResponseFilterMode))
                {
                    return new global::ElevenLabs.JsonConverters.ResponseFilterModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ResponseFilterMode?))
                {
                    return new global::ElevenLabs.JsonConverters.ResponseFilterModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.SFXModelId))
                {
                    return new global::ElevenLabs.JsonConverters.SFXModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SFXModelId?))
                {
                    return new global::ElevenLabs.JsonConverters.SFXModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SIPLogMessageDirection))
                {
                    return new global::ElevenLabs.JsonConverters.SIPLogMessageDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SIPLogMessageDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.SIPLogMessageDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SIPMediaEncryptionEnum))
                {
                    return new global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SIPMediaEncryptionEnum?))
                {
                    return new global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SIPTrunkTransportEnum))
                {
                    return new global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SIPTrunkTransportEnum?))
                {
                    return new global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SMBAgentType))
                {
                    return new global::ElevenLabs.JsonConverters.SMBAgentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SMBAgentType?))
                {
                    return new global::ElevenLabs.JsonConverters.SMBAgentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType))
                {
                    return new global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType?))
                {
                    return new global::ElevenLabs.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SMSConversationInfoDirection))
                {
                    return new global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SMSConversationInfoDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SafetyRule))
                {
                    return new global::ElevenLabs.JsonConverters.SafetyRuleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SafetyRule?))
                {
                    return new global::ElevenLabs.JsonConverters.SafetyRuleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SampleConfigDBModelParentType))
                {
                    return new global::ElevenLabs.JsonConverters.SampleConfigDBModelParentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SampleConfigDBModelParentType?))
                {
                    return new global::ElevenLabs.JsonConverters.SampleConfigDBModelParentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SearchStrategy))
                {
                    return new global::ElevenLabs.JsonConverters.SearchStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SearchStrategy?))
                {
                    return new global::ElevenLabs.JsonConverters.SearchStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SeatType))
                {
                    return new global::ElevenLabs.JsonConverters.SeatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SeatType?))
                {
                    return new global::ElevenLabs.JsonConverters.SeatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SecretDependencyResourceType))
                {
                    return new global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SecretDependencyResourceType?))
                {
                    return new global::ElevenLabs.JsonConverters.SecretDependencyResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SecretDependencyType))
                {
                    return new global::ElevenLabs.JsonConverters.SecretDependencyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SecretDependencyType?))
                {
                    return new global::ElevenLabs.JsonConverters.SecretDependencyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ShareOptionResponseModelType))
                {
                    return new global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ShareOptionResponseModelType?))
                {
                    return new global::ElevenLabs.JsonConverters.ShareOptionResponseModelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SingleUseTokenType))
                {
                    return new global::ElevenLabs.JsonConverters.SingleUseTokenTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SingleUseTokenType?))
                {
                    return new global::ElevenLabs.JsonConverters.SingleUseTokenTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SortDirection))
                {
                    return new global::ElevenLabs.JsonConverters.SortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SortDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.SortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus))
                {
                    return new global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechHistoryItemResponseModelVoiceCategory))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechHistoryItemResponseModelVoiceCategory?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelVoiceCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechHistoryItemResponseModelState))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechHistoryItemResponseModelState?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechHistoryItemResponseModelSource))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechHistoryItemResponseModelSource?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechHistoryItemResponseModelSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToTextWordResponseModelType))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToTextWordResponseModelType?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpellingPatience))
                {
                    return new global::ElevenLabs.JsonConverters.SpellingPatienceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpellingPatience?))
                {
                    return new global::ElevenLabs.JsonConverters.SpellingPatienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.StartProcedureToolErrorStatus))
                {
                    return new global::ElevenLabs.JsonConverters.StartProcedureToolErrorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.StartProcedureToolErrorStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.StartProcedureToolErrorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.StudioClipLocatorClipType))
                {
                    return new global::ElevenLabs.JsonConverters.StudioClipLocatorClipTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.StudioClipLocatorClipType?))
                {
                    return new global::ElevenLabs.JsonConverters.StudioClipLocatorClipTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SubscriptionStatusType))
                {
                    return new global::ElevenLabs.JsonConverters.SubscriptionStatusTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SubscriptionStatusType?))
                {
                    return new global::ElevenLabs.JsonConverters.SubscriptionStatusTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SystemDataCollectionId))
                {
                    return new global::ElevenLabs.JsonConverters.SystemDataCollectionIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SystemDataCollectionId?))
                {
                    return new global::ElevenLabs.JsonConverters.SystemDataCollectionIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SystemEvaluationId))
                {
                    return new global::ElevenLabs.JsonConverters.SystemEvaluationIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SystemEvaluationId?))
                {
                    return new global::ElevenLabs.JsonConverters.SystemEvaluationIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType))
                {
                    return new global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType?))
                {
                    return new global::ElevenLabs.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType))
                {
                    return new global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType?))
                {
                    return new global::ElevenLabs.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.TTSOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.TTSOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TTSOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.TTSOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TelephonyDirection))
                {
                    return new global::ElevenLabs.JsonConverters.TelephonyDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TelephonyDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.TelephonyDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TelephonyProvider))
                {
                    return new global::ElevenLabs.JsonConverters.TelephonyProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TelephonyProvider?))
                {
                    return new global::ElevenLabs.JsonConverters.TelephonyProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateArrayOutputFailureReason))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateArrayOutputFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateArrayOutputFailureReason?))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateArrayOutputFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateAudioOutputFailureReason))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateAudioOutputFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateAudioOutputFailureReason?))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateAudioOutputFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateBooleanOutputFailureReason))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateBooleanOutputFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateBooleanOutputFailureReason?))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateBooleanOutputFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateImageOutputFailureReason))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateImageOutputFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateImageOutputFailureReason?))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateImageOutputFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateInputReferenceDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateInputReferenceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateInputReferenceDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateInputReferenceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateIntegerOutputFailureReason))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateIntegerOutputFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateIntegerOutputFailureReason?))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateIntegerOutputFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateNumberOutputFailureReason))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateNumberOutputFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateNumberOutputFailureReason?))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateNumberOutputFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateObjectOutputFailureReason))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateObjectOutputFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateObjectOutputFailureReason?))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateObjectOutputFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateOutputDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateOutputDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateRunStatus))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateRunStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateStringOutputFailureReason))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateStringOutputFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateStringOutputFailureReason?))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateStringOutputFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateVideoOutputFailureReason))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateVideoOutputFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TemplateVideoOutputFailureReason?))
                {
                    return new global::ElevenLabs.JsonConverters.TemplateVideoOutputFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TestRunMetadataTestType))
                {
                    return new global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TestRunMetadataTestType?))
                {
                    return new global::ElevenLabs.JsonConverters.TestRunMetadataTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TestRunStatus))
                {
                    return new global::ElevenLabs.JsonConverters.TestRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TestRunStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.TestRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TestSharingMode))
                {
                    return new global::ElevenLabs.JsonConverters.TestSharingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TestSharingMode?))
                {
                    return new global::ElevenLabs.JsonConverters.TestSharingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TestType))
                {
                    return new global::ElevenLabs.JsonConverters.TestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TestType?))
                {
                    return new global::ElevenLabs.JsonConverters.TestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextNormalisationType))
                {
                    return new global::ElevenLabs.JsonConverters.TextNormalisationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextNormalisationType?))
                {
                    return new global::ElevenLabs.JsonConverters.TextNormalisationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId))
                {
                    return new global::ElevenLabs.JsonConverters.TextToSpeechGenerationRequestDiscriminatorModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId?))
                {
                    return new global::ElevenLabs.JsonConverters.TextToSpeechGenerationRequestDiscriminatorModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolCallSoundBehavior))
                {
                    return new global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolCallSoundBehavior?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolCallSoundType))
                {
                    return new global::ElevenLabs.JsonConverters.ToolCallSoundTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolCallSoundType?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolCallSoundTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolErrorHandlingMode))
                {
                    return new global::ElevenLabs.JsonConverters.ToolErrorHandlingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolErrorHandlingMode?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolErrorHandlingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolExecutionTaskSupport))
                {
                    return new global::ElevenLabs.JsonConverters.ToolExecutionTaskSupportJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolExecutionTaskSupport?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolExecutionTaskSupportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolExecutionMode))
                {
                    return new global::ElevenLabs.JsonConverters.ToolExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolExecutionMode?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolInterruptionMode))
                {
                    return new global::ElevenLabs.JsonConverters.ToolInterruptionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolInterruptionMode?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolInterruptionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolSortBy))
                {
                    return new global::ElevenLabs.JsonConverters.ToolSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolSortBy?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolType))
                {
                    return new global::ElevenLabs.JsonConverters.ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolType?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolTypeFilter))
                {
                    return new global::ElevenLabs.JsonConverters.ToolTypeFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ToolTypeFilter?))
                {
                    return new global::ElevenLabs.JsonConverters.ToolTypeFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TopicSortBy))
                {
                    return new global::ElevenLabs.JsonConverters.TopicSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TopicSortBy?))
                {
                    return new global::ElevenLabs.JsonConverters.TopicSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TranscriptPlatformEvent))
                {
                    return new global::ElevenLabs.JsonConverters.TranscriptPlatformEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TranscriptPlatformEvent?))
                {
                    return new global::ElevenLabs.JsonConverters.TranscriptPlatformEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason))
                {
                    return new global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason?))
                {
                    return new global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason))
                {
                    return new global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason?))
                {
                    return new global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TransferTypeEnum))
                {
                    return new global::ElevenLabs.JsonConverters.TransferTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TransferTypeEnum?))
                {
                    return new global::ElevenLabs.JsonConverters.TransferTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TurnEagerness))
                {
                    return new global::ElevenLabs.JsonConverters.TurnEagernessJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TurnEagerness?))
                {
                    return new global::ElevenLabs.JsonConverters.TurnEagernessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TurnMode))
                {
                    return new global::ElevenLabs.JsonConverters.TurnModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TurnMode?))
                {
                    return new global::ElevenLabs.JsonConverters.TurnModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TurnModel))
                {
                    return new global::ElevenLabs.JsonConverters.TurnModelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TurnModel?))
                {
                    return new global::ElevenLabs.JsonConverters.TurnModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TwilioEdgeLocation))
                {
                    return new global::ElevenLabs.JsonConverters.TwilioEdgeLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TwilioEdgeLocation?))
                {
                    return new global::ElevenLabs.JsonConverters.TwilioEdgeLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TwilioMachineDetectionMode))
                {
                    return new global::ElevenLabs.JsonConverters.TwilioMachineDetectionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TwilioMachineDetectionMode?))
                {
                    return new global::ElevenLabs.JsonConverters.TwilioMachineDetectionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TwilioRegionId))
                {
                    return new global::ElevenLabs.JsonConverters.TwilioRegionIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TwilioRegionId?))
                {
                    return new global::ElevenLabs.JsonConverters.TwilioRegionIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode))
                {
                    return new global::ElevenLabs.JsonConverters.UUITransferConfigProtocolDiscriminatorModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode?))
                {
                    return new global::ElevenLabs.JsonConverters.UUITransferConfigProtocolDiscriminatorModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateMusicFinetuneRequestModelVisibility))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateMusicFinetuneRequestModelVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateMusicFinetuneRequestModelVisibility?))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateMusicFinetuneRequestModelVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateOAuth2JWTRequestAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm?))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateOAuth2JWTRequestAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateOAuth2JWTRequestTokenResponseFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField?))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateOAuth2JWTRequestTokenResponseFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UsageAggregationInterval))
                {
                    return new global::ElevenLabs.JsonConverters.UsageAggregationIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UsageAggregationInterval?))
                {
                    return new global::ElevenLabs.JsonConverters.UsageAggregationIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UserFeedbackScore))
                {
                    return new global::ElevenLabs.JsonConverters.UserFeedbackScoreJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UserFeedbackScore?))
                {
                    return new global::ElevenLabs.JsonConverters.UserFeedbackScoreNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UsersSortBy))
                {
                    return new global::ElevenLabs.JsonConverters.UsersSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UsersSortBy?))
                {
                    return new global::ElevenLabs.JsonConverters.UsersSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceCategory))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceCategory?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31FastRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31FastRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31FastRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31FastRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31RequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31RequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31RequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31RequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31RequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31RequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VeoImageReferenceRole))
                {
                    return new global::ElevenLabs.JsonConverters.VeoImageReferenceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VeoImageReferenceRole?))
                {
                    return new global::ElevenLabs.JsonConverters.VeoImageReferenceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Verbosity))
                {
                    return new global::ElevenLabs.JsonConverters.VerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Verbosity?))
                {
                    return new global::ElevenLabs.JsonConverters.VerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VideoAnalysisStatus))
                {
                    return new global::ElevenLabs.JsonConverters.VideoAnalysisStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VideoAnalysisStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.VideoAnalysisStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId))
                {
                    return new global::ElevenLabs.JsonConverters.VideoGenerationRequestDiscriminatorModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId?))
                {
                    return new global::ElevenLabs.JsonConverters.VideoGenerationRequestDiscriminatorModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VideoReferenceDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.VideoReferenceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VideoReferenceDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.VideoReferenceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceDesignRequestModelModelId))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceDesignRequestModelModelId?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ElevenLabs.WebhookAuthMethodType))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookAuthMethodType?))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookAuthMethodTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookEventType))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookEventType?))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookTargetDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookTargetDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookTargetDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookTargetDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod?))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInputContentType))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigInputContentType?))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod?))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutputContentType))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookToolApiSchemaConfigOutputContentType?))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookTranscriptFormat))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookTranscriptFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookTranscriptFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookTranscriptFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookUsageType))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookUsageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookUsageType?))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookUsageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WhatsAppAccountType))
                {
                    return new global::ElevenLabs.JsonConverters.WhatsAppAccountTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WhatsAppAccountType?))
                {
                    return new global::ElevenLabs.JsonConverters.WhatsAppAccountTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WhatsAppConversationInfoDirection))
                {
                    return new global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WhatsAppConversationInfoDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetConfigInputSyntaxHighlightTheme))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightThemeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetConfigInputSyntaxHighlightTheme?))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetConfigInputSyntaxHighlightThemeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetConfigOutputSyntaxHighlightTheme))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightThemeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetConfigOutputSyntaxHighlightTheme?))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetConfigOutputSyntaxHighlightThemeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetConfigResponseModelSyntaxHighlightTheme))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightThemeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetConfigResponseModelSyntaxHighlightTheme?))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetConfigResponseModelSyntaxHighlightThemeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetEndFeedbackType))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetEndFeedbackType?))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetEndFeedbackTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetExpandable))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetExpandableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetExpandable?))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetExpandableNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetFeedbackMode))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetFeedbackModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetFeedbackMode?))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetFeedbackModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetPlacement))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetPlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WidgetPlacement?))
                {
                    return new global::ElevenLabs.JsonConverters.WidgetPlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminatorSource))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowToolLocatorSchemaOverridesDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminatorSource?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowToolLocatorSchemaOverridesDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceGroupPermission))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceGroupPermission?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceGroupPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceResourceType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceResourceType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceWebhookEventType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceWebhookEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceWebhookEventType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceWebhookEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.CreateEnvironmentVariableRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetSpeechHistorySortDirection))
                {
                    return new global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetSpeechHistorySortDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetSpeechHistorySource))
                {
                    return new global::ElevenLabs.JsonConverters.GetSpeechHistorySourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetSpeechHistorySource?))
                {
                    return new global::ElevenLabs.JsonConverters.GetSpeechHistorySourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextToSpeechFullOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextToSpeechFullOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextToSpeechStreamOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextToSpeechStreamOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingProjectListSortDirection))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingProjectListSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingProjectListSortDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingProjectListSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatusesVariant1Item))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatusesVariant1Item?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingModelsVariant1Item))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsDubbingModelsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingModelsVariant1Item?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsDubbingModelsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsCreationSourcesVariant1Item))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsCreationSourcesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsCreationSourcesVariant1Item?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsCreationSourcesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsFilterByCreator))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsFilterByCreator?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsOrderBy))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsOrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsOrderBy?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsOrderByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsOrderDirection))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsOrderDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType))
                {
                    return new global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType))
                {
                    return new global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataSort))
                {
                    return new global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSortJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataSort?))
                {
                    return new global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListChatResponseTestsRouteSortMode))
                {
                    return new global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListChatResponseTestsRouteSortMode?))
                {
                    return new global::ElevenLabs.JsonConverters.ListChatResponseTestsRouteSortModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConversationHistoriesRouteSummaryMode))
                {
                    return new global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConversationHistoriesRouteSummaryMode?))
                {
                    return new global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteSummaryModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item))
                {
                    return new global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item?))
                {
                    return new global::ElevenLabs.JsonConverters.GetConversationHistoriesRouteExcludeStatusesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConversationHistoryRouteFormat))
                {
                    return new global::ElevenLabs.JsonConverters.GetConversationHistoryRouteFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetConversationHistoryRouteFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.GetConversationHistoryRouteFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item))
                {
                    return new global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteExcludeStatusesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item?))
                {
                    return new global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteExcludeStatusesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode))
                {
                    return new global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode?))
                {
                    return new global::ElevenLabs.JsonConverters.TextSearchConversationMessagesRouteSummaryModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListEnvironmentVariablesType))
                {
                    return new global::ElevenLabs.JsonConverters.ListEnvironmentVariablesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListEnvironmentVariablesType?))
                {
                    return new global::ElevenLabs.JsonConverters.ListEnvironmentVariablesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerateOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.GenerateOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerateOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.GenerateOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ComposeDetailedOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ComposeDetailedOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ComposeDetailedOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ComposeDetailedOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ComposeDetailedStreamOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ComposeDetailedStreamOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ComposeDetailedStreamOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ComposeDetailedStreamOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.StreamComposeOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.StreamComposeOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.StreamComposeOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.StreamComposeOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetFinetunesSort))
                {
                    return new global::ElevenLabs.JsonConverters.GetFinetunesSortJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetFinetunesSort?))
                {
                    return new global::ElevenLabs.JsonConverters.GetFinetunesSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetFinetunesSortDirection))
                {
                    return new global::ElevenLabs.JsonConverters.GetFinetunesSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetFinetunesSortDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.GetFinetunesSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListVideoGenerationsStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ListVideoGenerationsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListVideoGenerationsStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ListVideoGenerationsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListImageGenerationsStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ListImageGenerationsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListImageGenerationsStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ListImageGenerationsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListTextToSpeechGenerationsStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ListTextToSpeechGenerationsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListTextToSpeechGenerationsStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ListTextToSpeechGenerationsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType))
                {
                    return new global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType?))
                {
                    return new global::ElevenLabs.JsonConverters.CreateAuthConnectionResponseDiscriminatorAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateAuthConnectionResponseDiscriminatorAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType?))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateAuthConnectionResponseDiscriminatorAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminatorStatus))
                {
                    return new global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminatorStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider))
                {
                    return new global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider?))
                {
                    return new global::ElevenLabs.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminatorProvider))
                {
                    return new global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminatorProvider?))
                {
                    return new global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminatorProvider))
                {
                    return new global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminatorProvider?))
                {
                    return new global::ElevenLabs.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus))
                {
                    return new global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.UpdateFileDocumentRouteResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus))
                {
                    return new global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus))
                {
                    return new global::ElevenLabs.JsonConverters.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[31];

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
                    0 => global::ElevenLabs.PartitionCoreSourceGenerationContext.TypeInfoResolver,

                    1 => global::ElevenLabs.AccessAllSourceGenerationContext.TypeInfoResolver,

                    2 => global::ElevenLabs.AgentsPlatformSourceGenerationContext.TypeInfoResolver,

                    3 => global::ElevenLabs.AgentsWorkspaceAnalyticsSourceGenerationContext.TypeInfoResolver,

                    4 => global::ElevenLabs.AssetsSourceGenerationContext.TypeInfoResolver,

                    5 => global::ElevenLabs.ConversationalAiSourceGenerationContext.TypeInfoResolver,

                    6 => global::ElevenLabs.DubbingSourceGenerationContext.TypeInfoResolver,

                    7 => global::ElevenLabs.Dubbing2SourceGenerationContext.TypeInfoResolver,

                    8 => global::ElevenLabs.ModelsSourceGenerationContext.TypeInfoResolver,

                    9 => global::ElevenLabs.MusicFinetunesSourceGenerationContext.TypeInfoResolver,

                    10 => global::ElevenLabs.MusicGenerationSourceGenerationContext.TypeInfoResolver,

                    11 => global::ElevenLabs.PartitionOrphan0SourceGenerationContext.TypeInfoResolver,

                    12 => global::ElevenLabs.PartitionOrphan1SourceGenerationContext.TypeInfoResolver,

                    13 => global::ElevenLabs.PartitionOrphan2SourceGenerationContext.TypeInfoResolver,

                    14 => global::ElevenLabs.PartitionOrphan3SourceGenerationContext.TypeInfoResolver,

                    15 => global::ElevenLabs.PartitionOrphan4SourceGenerationContext.TypeInfoResolver,

                    16 => global::ElevenLabs.PartitionOrphan5SourceGenerationContext.TypeInfoResolver,

                    17 => global::ElevenLabs.PartitionOrphan6SourceGenerationContext.TypeInfoResolver,

                    18 => global::ElevenLabs.PartitionOrphan7SourceGenerationContext.TypeInfoResolver,

                    19 => global::ElevenLabs.PartitionOrphan8SourceGenerationContext.TypeInfoResolver,

                    20 => global::ElevenLabs.PartitionOrphan9SourceGenerationContext.TypeInfoResolver,

                    21 => global::ElevenLabs.ProductionsSourceGenerationContext.TypeInfoResolver,

                    22 => global::ElevenLabs.PronunciationDictionarySourceGenerationContext.TypeInfoResolver,

                    23 => global::ElevenLabs.PvcVoicesSourceGenerationContext.TypeInfoResolver,

                    24 => global::ElevenLabs.SamplesSourceGenerationContext.TypeInfoResolver,

                    25 => global::ElevenLabs.SingleUseTokenSourceGenerationContext.TypeInfoResolver,

                    26 => global::ElevenLabs.SpeechToTextSourceGenerationContext.TypeInfoResolver,

                    27 => global::ElevenLabs.StudioSourceGenerationContext.TypeInfoResolver,

                    28 => global::ElevenLabs.TextToVoiceSourceGenerationContext.TypeInfoResolver,

                    29 => global::ElevenLabs.VoicesSourceGenerationContext.TypeInfoResolver,

                    30 => global::ElevenLabs.WorkspaceSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}