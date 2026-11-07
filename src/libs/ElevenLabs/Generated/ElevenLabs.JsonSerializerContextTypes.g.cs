
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASRConversationalConfig? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASRQuality? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASRProvider? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASRInputFormat? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASRConversationalConfigOverride? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASRConversationalConfigOverrideConfig? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASRConversationalConfigWorkflowOverride? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTAdditionOperatorNodeInput? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTNodeInput? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTAdditionOperatorNodeOutput? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTNodeOutput? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTAndOperatorNodeInput? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ASTNodeInput>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTAndOperatorNodeOutput? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ASTNodeOutput>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTBooleanNodeInput? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTBooleanNodeOutput? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTConditionalOperatorNodeInput? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTConditionalOperatorNodeOutput? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTDivisionOperatorNodeInput? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTDivisionOperatorNodeOutput? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTDynamicVariableNodeInput? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTDynamicVariableNodeOutput? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTEqualsOperatorNodeInput? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTEqualsOperatorNodeOutput? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTGreaterThanOperatorNodeInput? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTGreaterThanOperatorNodeOutput? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTLLMNodeInput? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTLLMNodeInputASTLLMNode? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMLiteralJsonSchemaProperty? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTLLMNodeInputASTLLMNode2? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTLLMNodeOutput? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTLessThanOperatorNodeInput? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTLessThanOperatorNodeOutput? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTMultiplicationOperatorNodeInput? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTMultiplicationOperatorNodeOutput? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTStringNodeInput? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTNumberNodeInput? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTNullNodeInput? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTOrOperatorNodeInput? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTNotEqualsOperatorNodeInput? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTSubtractionOperatorNodeInput? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTNodeInputDiscriminator? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTNodeInputDiscriminatorType? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTStringNodeOutput? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTNumberNodeOutput? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTNullNodeOutput? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTOrOperatorNodeOutput? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTNotEqualsOperatorNodeOutput? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTSubtractionOperatorNodeOutput? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTNodeOutputDiscriminator? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ASTNodeOutputDiscriminatorType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<double?, int?>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ActorModel? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserModel? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddChapterResponseModel? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterWithContentResponseModel? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddKnowledgeBaseResponseModel? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddProjectResponseModel? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModel? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddPronunciationDictionaryResponseModel? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddTicketCommentRequestModel? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddTurnCommentRequestModel? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddUrlRequest? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddVoiceIVCResponseModel? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceMatchResponseModel? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddVoiceResponseModel? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddVoiceToUserVoiceCollectionResponseModel? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddWorkspaceGroupMemberResponseModel? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddWorkspaceInviteResponseModel? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AdditionalFormatResponseModel? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ExportOptions>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptions? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelInput? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentPlatformSettingsRequestModel? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModel? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInput? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EvaluationCriteriaItem>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationCriteriaItem? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedUserEvaluationRef? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedSystemEvaluationRef? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminator? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionItem>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionItem? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedUserDataCollectionRef? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedSystemDataCollectionRef? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminator? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutput? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EvaluationCriteriaItem2>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationCriteriaItem2? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminator? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionItem2>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionItem2? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputDataCollectionItemDiscriminator? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentBan? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BanReasonType? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentBranchBasicInfo? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentBranchResponse? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchProtectionStatus? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchSyncStatus? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfo? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentVersionMetadata>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentVersionMetadata? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentBranchSummary? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentCallLimits? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelInput? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariablesConfig? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.BehaviorOverride>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BehaviorOverride? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInput? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelOutput? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutput? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelWorkflowOverrideInput? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariablesConfigWorkflowOverride? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInput? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelWorkflowOverrideOutput? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutput? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigOverrideInput? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOverrideInput? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigOverrideOutput? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOverrideOutput? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigOverrideConfig? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOverrideConfig? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketIssueType? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketPriority? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketResponseModel? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketCommentResponseModel>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketCommentResponseModel? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentResponseModel>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnCommentResponseModel? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketStatus? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriorityChangeResponseModel>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketPriorityChangeResponseModel? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatusChangeResponseModel>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketStatusChangeResponseModel? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketSource? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSearchMatchResponseModel? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketSortBy? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDefinitionSource? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentHistoryItem? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentSource? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentPercentageStrategy? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentRequest? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentDeploymentRequestItem>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentRequestItem? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentFailureResponseExample? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentHoldAudioConfig? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentFormat? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentType? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagDocumentResponseModel? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagListingEntryResponseModel? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagListingResponseModel? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagListingEntryResponseModel>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagQueryRequestModel? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchStrategy? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagQueryResponseModel? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponse? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalReview>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReview? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalComment>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalComment? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Outcome? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenOutcome? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergedOutcome? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClosedOutcome? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminator? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadata? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadataDBModel? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadataResponseModel? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSettingsInput? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigInput? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisProperty>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisProperty? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisScope>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisScope? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataConfigInput? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkspaceOverridesInput? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestingSettings? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsV1Input? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthSettings? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentQueueingConfig? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivacyConfigInput? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTrustContext? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Llm? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicDiscoverySettings? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SentimentAnalysisSettings? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSettings? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentPlatformSettingsResponseModel? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSettingsOutput? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigOutput? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataConfigOutput? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkspaceOverridesOutput? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsV1Output? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivacyConfigOutput? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSettingsResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyResponseModel? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentRule? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RulePriority? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSMBMetadata? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAgentType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSimulatedChatTestResponseModel? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptResponseModel? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryAnalysisCommonModel? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSortBy? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSuccessfulResponseExample? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSummaryBatchSuccessfulResponseModel? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSummaryResponseModel? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestEntityType? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestFolderPathSegmentResponseModel? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AttachedTestModel>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedTestModel? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTopicResponseModel? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicMetricsAggregate? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferInput? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOutput? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOp? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpReplace? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpPush? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpPop? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpDiscriminator? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpDiscriminatorType? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentVersionParents? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResourceAccessInfo>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelInput>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInput? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Nodes? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartNodeModelInput? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeModelInput? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInput? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelInput? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNodeModelInput? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminator? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModel? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelOutput>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutput? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Nodes2? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartNodeModelOutput? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeModelOutput? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNodeModelOutput? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminator? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataWebhook? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIWebhooks? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingMonitorConfig? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingPagerDutyNotifier? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingPagerDutyNotifierResponse? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AlertingMonitorConfig>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookNotifier? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSlackNotifier? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookNotifierResponse? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSlackNotifierResponse? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookHeader? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookMethod? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookSecretHeaderValue? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowedOutputFormats? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowedValues? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowlistItem? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisCharging? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisRunningTotal? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisRunSnapshot? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentAction? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentDestination? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentResultData? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemKind? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModel? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Definition? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItem? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserDataCollectionAnalysisItemOutput? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModelDefinitionDiscriminator? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModelDefinitionDiscriminatorKind? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemSource? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModel? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Definition2? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminator? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminatorKind? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionsResponseModel? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemVersionResponseModel>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemsResponseModel? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemResponseModel>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisPropertyType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependencies? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionStatus? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverrides? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SchemaOverridesVariant1? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConstantSchemaOverride? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableSchemaOverride? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMSchemaOverride? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OmitSchemaOverride? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminator? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseFilterMode? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAIDynamicVariable>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIDynamicVariable? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigInput? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolInterruptionMode? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PreToolSpeechMode? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableAssignment? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallSoundType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallSoundBehavior? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolErrorHandlingMode? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionMode? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApplicationNumberType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AppointmentReminderMode? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArchitectDispatchResponseModel? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyInput? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LiteralJsonSchemaProperty? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyInput? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyOutput? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyOutput? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArraySchema? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchema? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetListResponse? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AssetResponse>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetResponse? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscription? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscriptionStatus? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscriptionData? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignConversationTagsRequestModel? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignResellerTierRequest? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignResellerTierRequestBillingPeriod? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignableUserResponseModel? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadata? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadataDeliveryStatus? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformMetadataVariant1? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlainPlatformMetadata? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ZendeskPlatformMetadata? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1Discriminator? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemDataCollectionId? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemEvaluationId? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysis? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysisStatus? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysisResult? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioSegment>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioSegment? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioKeyMoment>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioKeyMoment? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsCatalogResponseModel? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsFilterPresetResponseModel>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsFilterPresetResponseModel? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsEnvironmentResponseModel>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsEnvironmentResponseModel? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioFormat? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioInputPacing? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioIsolationHistoryItemResponseModel? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeCreateProjectResponseModel? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeEditContentResponseModel? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeProjectSettingsResponseModel? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioRefChunk? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeRange? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReference? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationReference? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StaticAssetReference? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineAudioReference? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReferenceDiscriminator? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReferenceDiscriminatorType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioSchema? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioWithTimestampsAndVoiceSegmentsResponseModel? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAlignmentResponseModel? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceSegment>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSegment? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioWithTimestampsResponseModel? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuditActivityName? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuditClassName? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem>? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableToolIdentifier? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownToolIdentifier? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesToolDiscriminator? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.McpServersItem? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableMCPServerIdentifier? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownMCPServerIdentifier? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminator? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentIntegrationConnectionIdentifier>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentIntegrationConnectionIdentifier? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionLocator? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AllowlistItem>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthorizationMethod? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoGenerationMetadata? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoRebaseAttempt? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoRebaseOutcome? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoSyncInfo? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AvatarContextResponseModel? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundConfig? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundSourceType? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundPresetId? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundConfigWorkflowOverride? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMDefault? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMDisabled? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMOverride? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Llm>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BaseTurnConfig? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnMode? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnEagerness? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpellingPatience? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnModel? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BasicAuthResponse? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallDetailedResponse? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyProvider? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallWhatsAppParams? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallStatus? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyCallConfigOutput? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipientResponseModel>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundCallRecipientResponseModel? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallRecipientStatus? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallResponse? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallingCampaignInformation? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignConversationType? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchFailureResponseModel? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchSuccessResponseModelAnalysisItemAttachmentResultData? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BearerAuthResponse? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Verbosity? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutputFormat? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InteractionBudget? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BillingPeriod? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BinaryScoring? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddSamplesToPvcVoiceV1VoicesPvcVoiceIdSamplesPost? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddVoiceV1VoicesAddPost? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string>? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPost? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPost? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkDeleteKnowledgeBaseDocumentsV1ConvaiKnowledgeBaseBulkDeletePost? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkMoveTestsToFolderV1ConvaiAgentTestingBulkMovePost? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCommentOnAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdCommentsPost? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPost? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicGenerationMode? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicPrompt? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompositionPlan? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicModelID? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicV1MusicPost? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetOrCreateRAGIndexRequestModel>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRAGIndexRequestModel? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentV1ConvaiAgentsCreatePost? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSettings? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPost? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePvcVoiceV1VoicesPvcPost? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPost? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QualityPresetType? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateUrlDocumentV1ConvaiKnowledgeBaseUrlPost? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoicePost? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentTestFolderV1ConvaiAgentTestingFoldersPost? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateChapterV1StudioProjectsProjectIdChaptersPost? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateCrawlJobV1ConvaiKnowledgeBaseCrawlPost? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateForcedAlignmentV1ForcedAlignmentPost? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPost? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastConversationMode? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastBulletinMode? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastTextSource? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastURLSource? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateVoiceCollectionV1VoicesCollectionsPost? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookHMACSettings? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDeleteExistingInvitationV1WorkspaceInvitesDelete? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDownloadHistoryItemsV1HistoryDownloadPost? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPost? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditPvcVoiceV1VoicesPvcVoiceIdPost? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPost? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePost? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MetronomeUsageColumnFilter>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetronomeUsageColumnFilter? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnFilter? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetDependentAgentsForMultipleDocumentsV1ConvaiKnowledgeBaseDependentAgentsPost? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaExotelV1ConvaiExotelOutboundCallPost? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataRequestInput? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyCallConfigInput? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaSipTrunkV1ConvaiSipTrunkOutboundCallPost? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SeatType? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyInviteUserV1WorkspaceInvitesAddPost? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMergeAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdMergePost? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ProcedureVersionRef>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureVersionRef? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPostAgentHoldAudioV1ConvaiAgentsAgentIdHoldAudioPost? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRebaseABranchOntoMainV1ConvaiAgentsAgentIdBranchesBranchIdRebasePost? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyDirection? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRegisterMediaV1ProductionsOrdersOrderIdMediaPost? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RenderType? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyReviewAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdReviewsPost? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReviewState? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateParamsItem>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateParamsItem? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParams? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateBodyComponentParams? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateButtonComponentParams? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySetRulesOnThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdSetRulesPost? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySetWorkspaceThirdPartyDisablingPolicyV1WorkspacesApiKeysThirdPartyDisablingPost? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceResourceType? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSimulationSpecification? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PromptEvaluationCriteria>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptEvaluationCriteria? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySoundGenerationV1SoundGenerationPost? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SFXModelId? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, object>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPost? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamChapterAudioV1StudioProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamComposedMusicV1MusicStreamPost? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPost? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipient>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundCallRecipient? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPost? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInput>? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DialogueInput? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToDialogueSettingsResponseModel? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EffectsSpecInput? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePost? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTranslatesAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdTranslatePost? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdatePvcVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateStudioProjectV1StudioProjectsProjectIdPost? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdPatch? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAgentTestFolderV1ConvaiAgentTestingFoldersFolderIdPatch? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentInputModel? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateFileDocumentV1ConvaiKnowledgeBaseDocumentationIdUpdateFilePatch? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPost? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateOrderV1ProductionsOrdersOrderIdPatch? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderRequest? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateVoiceCollectionV1VoicesCollectionsCollectionIdPatch? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookEventType>? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookEventType? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadAssetV1AssetsPost? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadFileV1ConvaiConversationsConversationIdFilesPost? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadMusicV1MusicUploadPost? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<bool?, global::ElevenLabs.MusicModelID?>? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpsertOrderItemV1ProductionsOrdersOrderIdItemsPost? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpsertOrderItemRequest? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVerifyPvcVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVideoToMusicV1MusicVideoToMusicPost? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPost? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerV1VoiceChangerVoiceIdPost? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PermissionType? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateServiceAccountV1ServiceAccountsPost? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupConfig>? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupConfig? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<bool?, string>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchExpiresAtUnix?>? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchExpiresAtUnix? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbCancelTeamInvite? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbUpdateTeamMemberRole? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbUpdateTeamMemberRoleRole? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbUploadKnowledgeSource? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueFullWithTimestamps? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueStreamWithTimestamps? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFull? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSettingsResponseModel? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullWithTimestamps? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStream? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamWithTimestamps? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BooleanSchema? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BreakdownTypes? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BucketingStatus? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsInput? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInput? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsOutput? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutput? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsWorkflowOverrideInput? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsWorkflowOverrideOutput? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25Request? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTarget? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25RequestAspectRatio? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25RequestResolution? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReference? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoReference>? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReference? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioReference>? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequest? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequestResolution? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequest? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequestResolution? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2Request? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2RequestAspectRatio? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2RequestResolution? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequest? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequestResolution? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequest? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequestResolution? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CalComConnectionHealthStatus? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CalendlyConnectionHealthStatus? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallResult? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelCalendarEventParams? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelGroupSessionForAllParams? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelGroupSessionRegistrationParams? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelOrderParams? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CanvasPlacement? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModel? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleHorizontalPlacementModel? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModel? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleTemplateModel? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextAlign? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextStyle? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextWeight? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextTransform? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextBlendMode? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioTextStyleShadowModel? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioTextStyleOutlineModel? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModel? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModel? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleVerticalPlacementModel? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModelEnterType? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModelExitType? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleVerticalPlacementModelAlign? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModelEnterType? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModelExitType? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChangeResellerTierRequest? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChangeResellerTierRequestBillingPeriod? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockInputModel? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockInputModelSubType? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockResponseModel? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockInputModel>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentResponseModel? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockResponseModel>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterResponseModel? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterResponseModelState? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterStatisticsResponseModel? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotExtendedResponseModel? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CharacterAlignmentModel>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAlignmentModel? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotResponseModel? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotsResponseModel? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterSnapshotResponseModel>? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceStatisticsResponseModel>? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceStatisticsResponseModel? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterWithContentResponseModelState? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAge? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterGender? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterMetadataResponseModel? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterRole? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterRefreshPeriod? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterResponseModel? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChatSourceMedium? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CheckServiceAvailabilityParams? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientEvent? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientSecretResponse? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutput? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolConfigInput? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolConfigOutput? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimation? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimationEnterEffect? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimationExitEffect? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalCloseReason? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnFilterOperation? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>?>? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnUnit? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompactionSettingsWorkflowOverride? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompileProceduresResponseModel? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompileProceduresValidationErrorResponseModel? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureValidationError>>? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureValidationError>? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureValidationError? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>>? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkInput? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComputedUsagePlatformLimit? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConditionStrength? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConfigEntityType? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConflictSection? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.IList<object>, object>? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentConfig? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentThresholdGuardrail? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInput? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailExecutionMode? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallTriggerAction? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RetryTriggerAction? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminator? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutput? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction2? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminator? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StringSchema? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumberSchema? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntegerSchema? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageSchema? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSchema? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSchema? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectSchema? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchemaDiscriminator? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchemaDiscriminatorType? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentThresholdGuardrailThreshold? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContextualUpdateInfo? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Contributor? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIEnvVarLocator? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIFileUploadResponseModel? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAISecretLocator? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependencies? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem2>? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem2? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminator? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminatorType? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem>? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableAgentIdentifier? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownAgentIdentifier? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminator? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminatorType? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentPhoneNumberIdentifier? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem2>? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.McpServersItem2? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminator? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminatorType? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SecretDependencyType>? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecretDependencyType? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIUserSecretDBModel? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WebhookEventType>? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookEventType? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTranscriptFormat? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationASRUsageModel? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationChargingCommonModel? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMCategoryUsage? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformUsage? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTTSUsageModel? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigInput? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileInputConfig? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DTMFInputConfig? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOutput? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideInput? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigOverride? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOverride? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOverride? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideOutput? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideConfigInput? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigOverrideConfig? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOverrideConfig? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOverrideConfig? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideConfigOutput? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigWorkflowOverrideInput? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileInputConfigWorkflowOverride? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigWorkflowOverrideOutput? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationDeletionSettings? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationErrorType? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationFeedbackRequestModel? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserFeedbackScore? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationFeedbackType? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DataCollectionResultCommonModel>? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionResultCommonModel? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionResultCommonModel>? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSuccessResult? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ScopedAnalysisResult>? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScopedAnalysisResult? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryBatchCallModel? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryElevenAssistantCommonModel? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryErrorCommonModel? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CriteriaScoringMode? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryExotelPhoneCallModel? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryFeedbackCommonModel? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModel? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneCallVariant1? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1Discriminator? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryRagUsageCommonModel? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FeaturesUsageCommonModel? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationSource? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppConversationInfo? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMSConversationInfo? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceRewardModel>? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationVoiceRewardModel? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMultivoiceMessageModel? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryRedactionConfig? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConfigEntityType>? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableUpdateCommonModel>? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableUpdateCommonModel? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelInputRole? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserFeedback? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTurnMetrics? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagRetrievalInfo? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageInput? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptPlatformEvent? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationReasoningModel>? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationReasoningModel? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TriggeredGuardrailCommonModel>? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggeredGuardrailCommonModel? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutputRole? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageOutput? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel>? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultVariant1? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallToolResultModel? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageDetectionToolResultModel? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInput? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultErrorModel? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultSipSuccessModel? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultExotelSuccessModel? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultAmazonConnectSuccessModel? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultErrorModel? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SkipTurnToolResponseModel? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFResultSuccessModel? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFResultErrorModel? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceMailDetectionResultSuccessModel? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestToolResultModel? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolResultModel? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolResultModel? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolResultSuccessModel? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolResultErrorModel? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolResultSuccessModel? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolResultErrorModel? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DummyToolResultModel? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultVariant12? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutput? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolType? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolDetailsVariant1? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolDetailsVariant12? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1Discriminator? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInput? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutput? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataInternal? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationSourceInfo? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableInternalValueType? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrchestratorToolMockBehaviorConfig? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigOutput>>? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigOutput>? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseMockConfigOutput? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataRequestOutput? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator>? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationProduct? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSentimentAnalysis? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSentimentAnalysisOverallLabel? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSignedUrlResponseModel? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ToolMockConfig>? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolMockConfig? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSource? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryMessageModel? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryMessageModelRole? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryResponseModel? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryResponseModelStatus? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EvaluationCriteriaSummaryResult>? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationCriteriaSummaryResult? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceUsageModel>? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationVoiceUsageModel? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTagResponseModel? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTokenPurpose? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTokenResponseModel? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.MetricRecord>? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetricRecord? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationUserResponseModel? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SentimentAggregate? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.FrustratedConversationRef>? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FrustratedConversationRef? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfig? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigInput? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetInput>? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetInput? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VADConfig? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelOutput? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOutput? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetOutput>? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetOutput? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideInput? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigWorkflowOverride? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigWorkflowOverrideInput? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VADConfigWorkflowOverride? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideOutput? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigWorkflowOverrideOutput? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvertChapterResponseModel? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvertProjectResponseModel? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CrawlStatus? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CrawlType? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentBranchResponseModel? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentConversationTicketRequestModel? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentRequestModel>? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnCommentRequestModel? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentMergeProposalResponseModel? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentProcedureParams? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentResponseModel? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentRuleParams? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentTestFolderResponseModel? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentTestResponseModel? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAssetParams? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateBasicAuthRequest? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateBearerAuthRequest? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientAppointmentParams? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientInteractionParams? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientParams? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientSecretRequest? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInput? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExpiresAfter? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateConversationTagRequestModel? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateCrawlJobResponseModel? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateCustomHeaderAuthRequest? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentRequest? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateExotelPhoneNumberRequest? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelApiSubdomain? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateHolidayParams? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateLocationParams? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateMTLSAuthRequest? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateManualTicketRequestModel? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2ClientCredsRequest? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequest? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestJwtUsage? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderParams? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderRequest? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderResponse? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePhoneAssignmentRequest? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePhoneNumberResponseModel? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePrivateKeyJWTRequest? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProcedureRequestModel? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureType? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProcedureResponseModel? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProductParams? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProductQuoteRequestParams? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePronunciationDictionaryResponseModel? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateRealtimeConversationGroupRequestModel? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateResponseUnitTestRequest? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestFromConversationMetadataInput? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentSuccessfulResponseExample>? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentFailureResponseExample>? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InboundSIPTrunkConfigRequestModel? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundSIPTrunkConfigRequestModel? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSecretEnvironmentVariableRequest? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest>? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableSecretValueRequest? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateServiceParams? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateServiceQuoteRequestParams? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSimulationTestRequest? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationToolMockBehaviorConfig? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>>? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseMockConfigInput? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSpeechEngineRequest? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineConfig? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineAuthConfig? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineConversationInitiationClientDataConfig? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateStaffParams? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateStringEnvironmentVariableRequest? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTeamInviteRequest? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTeamInviteRequestRole? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateToolCallUnitTestRequest? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallEvaluationModelInput? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTransferRuleParams? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTwilioPhoneNumberRequest? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegionConfigRequest? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatifyAuroraRequest? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatifyAuroraRequestResolution? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CueOptionsRequest? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Currency? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailInput? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailsConfigInput? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailOutput? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailsConfigOutput? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfig? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigModel? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction3? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminator? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomGuardrailConfig>? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomHeaderAuthResponse? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomLLM? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator>? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator>? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentAuthConnectionLocator? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomLLMAPIType? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSIPHeader? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomerFacingConfigInput? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMReasoningEffort? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBTurnEagerness? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentRule>? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBTransferRule>? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBTransferRule? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBProcedure>? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBProcedure? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomerFacingConfigOutput? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomerFacingConfigPatch? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardCallSuccessChartModel? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardCriteriaChartModel? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardDataCollectionChartModel? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionValueSchema? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DataCollectionValueSchemaType?, global::System.Collections.Generic.IList<string>>? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionValueSchemaType? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DateModel? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupResponseModel? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupResponseModel? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentHoldAudioResponseModel? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentProcedureParams? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentRuleParams? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAssetParams? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteCalendarEventParams? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteChapterResponseModel? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteClientInteractionParams? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteClientParams? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteDubbingResponseModel? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteGroupSessionParams? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteHistoryItemResponse? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteHolidayParams? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteLocationParams? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteProductParams? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteProjectResponseModel? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteSampleResponseModel? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteServiceParams? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteStaffParams? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteTransferRuleParams? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteUserVoiceCollectionResponseModel? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteVoiceResponseModel? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteVoiceSampleResponseModel? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceGroupMemberResponseModel? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceInviteResponseModel? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceWebhookResponseModel? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeliverableInfo? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableAgentIdentifierAccessLevel? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentBranchInfo? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DetailedMusicResponse? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongMetadata? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WordTimestamp>? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WordTimestamp? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DetectedEntity? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeviceModel? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DialogueInputResponseModel? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModel? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReadMetadataChapterDBModel>? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReadMetadataChapterDBModel? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReadLegalTerms? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Contributor>? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelPayoutType? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PreviewAudioDBModel? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleConfigDBModel? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModel? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DiscountResponseModel? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DoDubbingResponseModel? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocumentUsageModeEnum? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocxExportOptions? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubOrderItemRequest? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbedSegment? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SegmentSubtitleFrame>? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentSubtitleFrame? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMediaReference? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkSegmentUpdateRequest? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingSegmentUpdateRequest>? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSegmentUpdateRequest? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkSourceSegmentUpdateResponse? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptSegment>? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptSegment? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkTargetSegmentUpdateRequest? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingTargetSegmentUpdateRequest>? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetSegmentUpdateRequest? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkTargetSegmentUpdateResponse? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTargetTranscriptSegment>? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetTranscriptSegment? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingError? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageListResponse? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingLanguageResponse>? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageResponse? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageOutputs? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageResponseStatus? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoicesNotPermittedWarning>? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicesNotPermittedWarning? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMediaMetadata? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMetadataPageResponseModel? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingMetadataResponse>? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMetadataResponse? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectListResponse? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingProjectResponse>? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectResponse? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectResponseStatus? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceMediaInfo? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingRegenerateResponse? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingReleaseChannel? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingRenderResponseModel? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingResource? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerTrack>? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerTrack? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerSegment>? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSegment? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.Render>? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Render? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSegmentCreateRequest? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceSegmentUpdateResponse? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceTranscriptResponse? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetSegmentUpdateResponse? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetTranscriptResponse? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscript? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptUtterance>? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptUtterance? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptCharacter? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptResponseModel? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptRevisionResponse? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptWord>? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptWord? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptCharacter>? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptsResponseModel? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DuplicateSpeechEngineRequest? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Eagerness? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditChapterResponseModel? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditProjectResponseModel? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditVoiceResponseModel? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditVoiceSettingsResponseModel? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditedTranscript? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EffectsSpecOutput? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25Request? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25RequestOutputFormat? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocator>? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocator? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25VoiceSettings? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenMultilingualV2Request? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TtsVoiceSettings? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3Request? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3RequestOutputFormat? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3VoiceSettings? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EmbedVariant? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EmbeddingModelEnum? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallToolConfig? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolConfig? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ProcedureVersionRef, global::ElevenLabs.ProcedureDraftRef>? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureDraftRef? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolErrorStatus? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EntryBehavior? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentResponse? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableAuthConnectionValue? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableResponse? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableResponseType? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableSecretValue? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariablesListResponse? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentVariableResponse>? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentsListResponse? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentResponse>? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationResultFilter? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExactParameterEvaluationStrategy? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelOutboundCallResponse? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExperimentAssignment? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExperimentAssignmentSource? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentedJsonExportOptions? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PdfExportOptions? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TxtExportOptions? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HtmlExportOptions? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SrtExportOptions? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptionsDiscriminator? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptionsDiscriminatorFormat? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExtendedSubscriptionResponseModel? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, string>? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Price? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionStatusType? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModel? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModel>? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel>? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingSubscriptionSwitchResponseModel? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingCancellationResponseModel? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalFileSyncInfo? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncProvider? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalFolderSyncInfo? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncJobTrigger? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncJobType? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FeatureStatusCommonModel? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowFeaturesUsageCommonModel? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestsFeatureUsageCommonModel? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FieldConflict? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileRefreshStatus? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FineTuningResponseModel? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.FineTuningResponseModelState2>? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FineTuningResponseModelState2? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VerificationAttemptResponseModel>? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerificationAttemptResponseModel? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualVerificationResponseModel? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FinetuneCreatedBy? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FinetuneVisibility? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FocusGuardrail? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentCharacterResponseModel? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentResponseModel? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentWordResponseModel>? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentWordResponseModel? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FrustratedConversationRefOverallLabel? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1Request? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestQuality? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestBackground? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestAspectRatio? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15Request? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestQuality? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestBackground? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestAspectRatio? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequest? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestQuality? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestAspectRatio? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestResolution? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequest? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestQuality? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestAspectRatio? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestResolution? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2Request? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestQuality? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestAspectRatio? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestResolution? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini25FlashImageRequest? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini25FlashImageRequestAspectRatio? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequest? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequestAspectRatio? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequestResolution? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashLiteImageRequest? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequest? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequestAspectRatio? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequestResolution? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkInputContextAdherence? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkOutput? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkOutputContextAdherence? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationSourceContext? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferenceVideo? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenesysBotOutcome? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenesysRegion? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentConfigParams? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentConversationTicketsPageResponseModel? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketResponseModel>? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentEmbedResponseModel? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigResponseModel? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgebaseSizeResponseModel? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentLinkResponseModel? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModel? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem>? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberTwilioResponseModel? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberExotelResponseModel? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminator? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetWhatsAppAccountResponse>? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWhatsAppAccountResponse? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ProcedureRefResponseModel>? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureRefResponseModel? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentTestFolderResponseModel? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentTopicsResponseModel? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTopicResponseModel>? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentsPageResponseModel? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentSummaryResponseModel>? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModel? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem2>? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem2? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModelAgentDiscriminator? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorType? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentBranchInfo>? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalyticsSummaryParams? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAppointmentByConfirmationNumberParams? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAudioIsolationHistoryResponseModel? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioIsolationHistoryItemResponseModel>? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAudioNativeProjectSettingsResponseModel? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetBookingPageSettingsParams? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetBookingSlugStatusParams? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetChaptersResponseModel? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterResponseModel>? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientAppointmentsParams? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientByPhoneParams? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientOrdersParams? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModel? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem>? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChartsItem? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminator? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAISettingsResponseModel? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LivekitStackType? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationResponseModel? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationResponseModelStatus? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VisitedAgentRef>? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VisitedAgentRef? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationSummaryResponseModel? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationSummaryResponseModelStatus? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryMessageModel>? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationTagsPageResponseModel? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationTagResponseModel>? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationUsersPageResponseModel? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationUserResponseModel>? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationsPageResponseModel? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryResponseModel>? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetCrawlJobResponseModel? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModel? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem3>? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem3? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseFileResponseModel? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentMetadataResponseModel? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DocumentUsageModeEnum>? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KbExternalSyncJob? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModel? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DocumentsItem>? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocumentsItem? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminator? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem>? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminator? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem2>? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem2? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminator? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem3>? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem3? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminator? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem4>? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem4? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminator? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseTextResponseModel? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseURLResponseModel? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetLibraryVoicesResponseModel? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LibraryVoiceResponseModel>? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceResponseModel? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetLiveCountResponse? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrderByConfirmationNumberParams? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberAgentInfo? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberInboundSIPTrunkConfigResponseModel? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPMediaEncryptionEnum? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberOutboundSIPTrunkConfigResponseModel? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkTransportEnum? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MediaCodec>? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaCodec? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModel? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem2>? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem2? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminator? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetProjectsResponseModel? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectResponseModel>? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionariesMetadataResponseModel? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModel? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetResponseUnitTestResponseModel? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestFromConversationMetadataOutput? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSIPLogMessagesResponse? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SIPLogMessage>? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPLogMessage? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetScheduleParams? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModel? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependenciesVariant1Item? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminator? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependenciesVariant2Item? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminator? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSimulationTestResponseModel? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistoryResponseModel? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechHistoryItemResponseModel>? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModel? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestInvocationsPageResponseModel? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseMeta? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestInvocationSummaryResponseModel>? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestInvocationSummaryResponseModel? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestSuiteInvocationResponseModel? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestRunResultSummary>? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunResultSummary? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestRunResponseModel>? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModel? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestsPageResponseModel? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestSummaryResponseModel>? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestSummaryResponseModel? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestsSummariesByIdsResponseModel? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.UnitTestSummaryResponseModel>? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolCallUnitTestResponseModel? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallEvaluationModelOutput? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModel? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem4>? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem4? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminator? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminatorType? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolExecutionsPageResponseModel? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolExecutionResponseModel>? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModel? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetUserVoiceCollectionsResponseModel? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UserVoiceCollectionResponseModel>? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserVoiceCollectionResponseModel? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoiceAccentsResponseModel? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceAccentResponseModel>? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceAccentResponseModel? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoicesResponseModel? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceResponseModel>? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModel? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoicesV2ResponseModel? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppAccountType? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWorkspacePlanParams? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWorkspaceSecretsResponseModel? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailType? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsResult? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptInjectionGuardrail? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationGuardrailInput? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationGuardrailOutput? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HTTPValidationError? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ValidationError>? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ValidationError? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HidingReason? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HistoryAlignmentResponseModel? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HistoryAlignmentsResponseModel? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HolidayResponseModel? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HolidayType? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeRangeModel? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeOffType? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HttpRequestModel? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UrlModel? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Icon? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IconTheme? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysis? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysisStatus? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysisResult? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageSubject>? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageSubject? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAvatar? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequest? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequestDiscriminator? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineImageReference? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReferenceDiscriminator? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReferenceDiscriminatorType? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkCredentialsRequestModel? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IngestFailure? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineAudioReferenceMimeType? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineBase64Reference? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineBase64ReferenceMimeType? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineImageReferenceMimeType? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineVideoReference? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineVideoReferenceMimeType? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntakeQuestionKind? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntegrationType? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InternalAlertingWebhookNotifier? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AlertingWebhookHeader>? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InternalKBCrawlPageTiming? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InternalSamplingConfigResponseModel? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DiscountResponseModel>? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModelPaymentIntentStatus? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDeletedResponseModel? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResponseModel? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseContentSearchResult>? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResult? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Document? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminator? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminatorType? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchHighlightSegment>? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchHighlightSegment? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDependentType? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentChunksResponseModel? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel>? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseLocator? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagChunkModel? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolConfig? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolStatus? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseRagChunkModel>? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSortBy? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSourceFileUrlResponseModel? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Data? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminator? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolConfig? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchStrategy>? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolInfo? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolStatus? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeSourceStatus? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeSourceType? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMAnyOfJsonSchemaPropertyInput? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMObjectJsonSchemaPropertyInput>? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMObjectJsonSchemaPropertyInput? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMAnyOfJsonSchemaPropertyOutput? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMArrayJsonSchemaPropertyInput? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMArrayJsonSchemaPropertyOutput? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMObjectJsonSchemaPropertyOutput? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMDeprecationConfigModel? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMDeprecationInfoModel? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMInfoModel? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMReasoningEffort>? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMServiceTier>? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMServiceTier? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegionalProcessingSurchargeInfo? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMInputOutputTokensUsage? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMTokensCategoryUsage? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMListResponseModel? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMInfoModel>? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMLiteralJsonSchemaPropertyType? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMParameterEvaluationStrategy? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LLMInputOutputTokensUsage>? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorLLMResponseModel? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorPublicRequestModel? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorRequestModel? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorResponseModel? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageAddedResponse? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageDetectionToolConfig? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageInfo? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePairInfo? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguageInfo>? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetTranslation? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageResponseModel? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponse? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PairedLanguagesResponse? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleLanguagesResponse? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponseDiscriminator? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponseDiscriminatorKind? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeaveMessageParams? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LenientCurrencyEnum? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBVertical? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceResponseModelCategory? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerifiedVoiceLanguageResponseModel? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentProceduresParams? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentReferencesParams? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentRulesParams? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAssetsParams? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponse? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AuthConnectionsItem>? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionsItem? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2ClientCredsResponse? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshTokenAuthResponse? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponse? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivateKeyJWTResponse? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MTLSAuthResponse? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppAuthResponse? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SlackBotAuthResponse? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UrlSecretAuthResponse? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminator? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCalendarEventsParams? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListClientInteractionsParams? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListClientsParams? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCrawlJobsResponseModel? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetCrawlJobResponseModel>? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCustomerFacingAgentsParams? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListGroupSessionsParams? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListHolidaysParams? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListLocationsParams? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListMCPToolsResponseModel? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Tool>? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Tool? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolApprovalStatus>? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalStatus? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListOrdersResponse? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderSummary>? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderSummary? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListProceduresResponseModel? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureListItemResponseModel>? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureListItemResponseModel? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListProductsParams? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseAgentBranchSummary? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentBranchSummary>? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseAgentDeploymentHistoryItem? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentDeploymentHistoryItem>? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListServicesParams? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListSpeechEnginesResponse? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechEngineSummaryResponse>? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineSummaryResponse? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListStaffParams? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTestsByIdsRequestModel? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTransferRulesParams? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListWhatsAppAccountsResponse? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LiteralJsonSchemaPropertyType? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LoadMemoryEntryToolErrorStatus? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LoadableMemoryEntry? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LocationResponse? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkingHours? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBLocationDeactivationReason? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LockReason? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovalPolicy? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovalPolicyUpdateRequestModel? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovedToolDefinition? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigInput? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolApprovalHash>? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalHash? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerTransport? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator>? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel>? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverrideInput>? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInput? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigOutput? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverrideOutput>? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutput? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigUpdateRequestModel? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerMetadataResponseModel? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerRequestModel? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModel? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem5>? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem5? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminator? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminatorType? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServersResponseModel? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPServerResponseModel>? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolAddApprovalRequestModel? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalPolicy? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalState? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInput? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant1? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminator? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutput? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant12? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminator? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ToolCallSoundType?, string>? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant13? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminator? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminatorSource? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant14? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminator? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModel? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant15? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModel? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant16? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPTransport? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualSource? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualVerificationFileResponseModel? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ManualVerificationFileResponseModel>? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MatchAnythingParameterEvaluationStrategy? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationCompletedResponse? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationCreateResponse? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationFailedResponse? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationFailedResponseFailureReason? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationInProgressResponse? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationInProgressResponseStatus? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationListResponse? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MediaGenerationResponse>? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponse? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponseDiscriminator? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MemoryEntrySearchResult? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource>? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeAgentConversationTicketsRequestModel? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModel? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem3>? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem3? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminator? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminatorProvider? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.FieldConflict>? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReviewReviewerRole? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalStatus? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessageSearchSortBy? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessagesSearchResponse? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MessagesSearchResult>? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessagesSearchResult? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetricType? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetronomeUsageColumnFilterColumn? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetronomeUsageColumnFilterOperation? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MockNoMatchBehavior? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MockingStrategy? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModelRatesResponseModel? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModelResponseModel? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguageResponseModel>? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationConfig? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ThresholdGuardrail? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModel? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModelSafetyStatus? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModelWarningStatus? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MultichannelSpeechToTextResponseModel? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextChunkResponseModel>? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModel? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MultipartMusicResponse? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicAllowedOutputFormats? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicOnlyOutputFormats? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicExploreSongSourceContext? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneFailureReason? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetunePageResponseModel? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MusicFinetuneResponseModel>? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneResponseModel? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneStatus? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicOutputFormat? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SongSection>? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongSection? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicUploadResponse? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NonStreamingOutputFormats? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumericDistributionAggregate? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumericUniformScoring? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseAlgorithm? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseTokenResponseField? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseJwtUsage? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelAttribute? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, bool?, double?>? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelResource? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelAttribute>? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelResourceSpans? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelScopeSpans>? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelScopeSpans? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelScope? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelSpan>? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelSpan? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelStatus? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelTracePayload? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelResourceSpans>? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyInputPropertyKind? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequiredConstraints? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ContentSchema>? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioConfigInput? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputConfigInput? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputConfigInput? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioConfigOutput? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputConfigOutput? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputConfigOutput? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputFormat? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputTranscription? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAITurnDetection? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputFormat? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIFunctionTool? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIMCPTool? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIMCPToolRequireApproval? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeModel? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem3>? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem3? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInputToolDiscriminator? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInputToolDiscriminatorType? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.OpenAIToolChoiceFunction>? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIToolChoiceFunction? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.OpenAITurnDetection, string>? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<string, global::ElevenLabs.OpenAITracingConfiguration>? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAITracingConfiguration? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem4>? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem4? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminator? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminatorType? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIToolChoiceFunctionInner? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnDetectionType? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenerConfig? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OptInSmsReminderParams? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OptOutSmsReminderParams? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OptionValue? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrbAvatar? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderDeliverablesResponse? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DeliverableInfo>? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderFulfillmentType? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemInfo? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutput? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QuoteInfo? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemKind? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInput? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubtitleOrderItemRequest? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptionOrderItemRequest? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInputDiscriminator? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInputDiscriminatorKind? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutputDiscriminator? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderMediaResponse? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderResponse? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderState? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderItemInfo>? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerGetClientAppointmentsParams? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListAssetsParams? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListLocationsParams? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListProductsParams? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListServicesParams? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListStaffParams? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PaginatedResultAgentMergeProposalResponse? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentMergeProposalResponse>? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguagePairInfo>? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchAgentConversationTicketRequestModel? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequest? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem2>? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChartsItem2? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminator? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAISettingsRequest? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConversationTagRequestModel? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchWorkspaceSecretRequest? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchWorkspaceWebhookResponseModel? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingBlocksMetadataModel? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingClipTask? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingClipTaskType? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingExternalAudiosMetadataModel? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberSortBy? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransfer? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem>? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminator? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferDestination? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPUriTransferDestination? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPUriDynamicVariableTransferDestination? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminator? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminatorType? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferTypeEnum? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UUITransferConfig? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant1? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsStatic? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsDynamicVariable? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1Discriminator? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformCategory? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformCategoryUsage? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformLimits? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StoredUsagePlatformLimit? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.PlatformCategoryUsage>? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFToolConfig? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastBulletinModeData? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastConversationModeData? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastProjectResponseModel? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PositionInput? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PositionOutput? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostAgentAvatarResponseModel? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostAgentHoldAudioResponseModel? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostWorkspaceSecretRequest? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostWorkspaceSecretResponseModel? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PricingMode? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivateKeyJWTResponseAlgorithm? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureAtVersionResponseModel? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureDraftResponseModel? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcessingProgress? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaResponseModel? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaResponseModelStatus? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaType? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModel? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelTargetAudience? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelState? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelAccessLevel? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelFiction? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelSourceType? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.CaptionStyleModel>? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelAspectRatio? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioAgentSettingsModel? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionResponseModel? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryLocatorResponseModel? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVideoResponseModel? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModel? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectImageResponseModel? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVoiceResponseModel>? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVoiceResponseModel? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SourceContextVariant1? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongSourceContext? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SfxSourceContext? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectMutedTracksResponseModel? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelTargetAudience? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelState? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelAccessLevel? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelFiction? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelSourceType? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelAspectRatio? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotExtendedResponseModel? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotResponseModel? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotsResponseModel? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectSnapshotResponseModel>? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysis? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromotionTarget? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigInput? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLlmConfig? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminator? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem5>? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem5? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolConfigInput? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfig? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminator? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminatorType? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigOutput? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLlmConfig2? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem6>? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem6? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolConfigOutput? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminator? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigWorkflowOverrideInput? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride>? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item>? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsVariant1Item? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminator? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigWorkflowOverrideOutput? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item2>? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsVariant1Item2? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryRulesResponseModel? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceRequest? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceSubscription? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteRequest>? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteRequest? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceResponse? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSubscription? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteResult>? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteResult? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriod? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryParamsJsonSchemaInput? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryParamsJsonSchemaOutput? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexResponseModel? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexStatus? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexUsage? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexesResponseModel? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RAGDocumentIndexResponseModel>? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexBatchSuccessfulResponseModel? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexOverviewResponseModel? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel>? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexRequestModel? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagChunkMetadata? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RagChunkMetadata>? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RawBusinessInfo? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RawLocationInfo>? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RawLocationInfo? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RawItem? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReaderResourceResponseModel? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReaderResourceResponseModelResourceType? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupResponseModel? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupSharingSummary? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupSharingSummaryEveryoneRole? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupsResponseModel? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RealtimeConversationGroupResponseModel>? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReassignPhoneRequest? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RecordingResponseModel? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioClipLocator? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferencedToolCommonModel? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferencedToolCommonModelType? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegexParameterEvaluationStrategy? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioRegionId? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioEdgeLocation? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegisterForGroupSessionParams? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegisterMediaResponse? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RemoveOrderItemResponse? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RemoveVoiceFromUserVoiceCollectionResponseModel? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RenderStatus? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReplicateVoiceToIsolatedEnvironmentRequestModel? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReplicateVoiceToIsolatedEnvironmentResponseModel? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReportKnowledgeGapParams? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequestPVCManualVerificationResponseModel? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequiredConstraint? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RequiredConstraint>? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceDetail? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceStatus? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerInvoiceLine>? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceLine? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceLineKind? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceSummary? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoicesResponse? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerInvoiceSummary>? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerTierResponse? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBTierEconomics? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerUpcomingPayment? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerUpcomingPaymentsResponse? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerUpcomingPayment>? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceOnboardingResponse? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSubscriptionBillingPeriod? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSummary? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspacesResponse? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerWorkspaceSummary>? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoRole? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoAnonymousAccessLevelOverride? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoAccessSource? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceMetadataResponseModel? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ShareOptionResponseModel>? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ShareOptionResponseModel? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseConversationErrorType? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseFilter? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseUnitTestModel? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RestoreCalendarEventParams? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResubmitTestsRequestModel? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModelReviewStatus? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RunAgentTestsRequestModel? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SingleTestRunRequestModel>? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleTestRunRequestModel? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RunConversationEvaluationsRequest? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPLogMessageDirection? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkOutboundCallResponse? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAddOn? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAdjustProductStockRequest? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAgentInfoResponse? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAgentInfoResponseCurrency? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceNow? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAgentTarget? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAssetResourceDBModel? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBGroupMembership>? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBGroupMembership? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAssetScrapable? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBClientAccessConfig? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBConfirmServiceUpdateRequest? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBIntakeQuestion>? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBIntakeQuestion? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBServiceVariant>? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBServiceVariant? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBServiceKind? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ServiceLocationType? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBAddOn>? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBServicePromotion>? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBServicePromotion? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateAgentRuleRequest? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateAssetRequest? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateHolidayRequest? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateProcedureRequest? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateProductRequest? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderFulfillmentType>? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateServiceRequest? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateStaffRequest? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateTransferRuleRequest? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCustomerFacingAgent? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCustomerFacingAgentDeactivationReason? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCustomerFacingAgentResponse? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBWidgetAppearance? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBIdentityVerificationConfig? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBNotificationChannel>? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBNotificationChannel? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBKnowledgeSourceDBModel? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBLocationInput? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBLocationOutput? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBLocationRequest? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBLocationRequestPatch? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBPhoneAssignmentDBModel? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBPhoneProvider? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBPhoneAssignmentDeactivationReason? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBPhoneRegulatoryStatus? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBProcedureResponse? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBProductDBModel? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBProductScrapable? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBScrapingMode? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBServiceDBModel? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBServiceScrapable? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBStaffResourceDBModel? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBStaffScrapable? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBTeamInviteResponse? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBTeamMemberResponse? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchClientsParams? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendCustomEmailParams? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateClientParams? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateStaffParams? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAssetParams? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateServiceParams? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateProductParams? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderParams? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScheduleGroupSessionParams? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateGroupSessionSeatsParams? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateCalendarEventParams? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentRuleParams? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTransferRuleParams? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentProcedureParams? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateHolidayParams? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitBusinessInfoParams? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBusinessInfoParams? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentConfigParams? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBookingPageSettingsParams? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBookingPageAppearanceParams? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SetBookingSlugParams? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateLocationParams? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerUserVerificationParams? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ValidateUserVerificationCodeParams? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfigParamsDiscriminator? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateAgentInfoRequest? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateAgentInfoRequestCurrency? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateAgentRuleRequest? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateAssetRequestPatch? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateCustomerFacingAgentRequest? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateHolidayRequestPatch? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateProcedureRequest? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateProductRequestPatch? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateProductStockRequest? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateServiceRequestPatch? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateStaffRequestPatch? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateTransferRuleRequest? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBWidgetAppearanceVariant? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBWidgetAppearancePlacement? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMSConversationInfoDirection? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyCommonModelInput? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyEvaluation? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyCommonModelOutput? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SafetyRule>? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyRule? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleConfigDBModelParentType? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleResponseModel? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSeparationResponseModel? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodeLiteralMessageInput? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TranslatedString>? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranslatedString? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodeLiteralMessageOutput? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodePromptMessageInput? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodePromptMessageOutput? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScimGroupResponseModel? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecretDependencyResourceType? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SectionSource? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TimeRange>? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentCreatePayload? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentCreateResponse? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentDeleteResponse? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentDubResponse? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentMigrationResponse? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentTranscriptionResponse? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentTranslationResponse? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentUpdatePayload? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentUpdateResponse? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ServiceUpdateResponse? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SetConversationGroupRequestModel? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ShareOptionResponseModelType? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimilarVoice? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceCategory? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimilarVoicesForSpeakerResponse? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SimilarVoice>? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationLibrarySettings? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationTestModel? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleUseTokenResponseModel? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleUseTokenType? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SkipTurnToolConfig? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SmbSipMediaEncryption? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SmbSipTransport? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SmsTemplateStyle? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfig? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigOverride? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigOverrideConfig? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigWorkflowOverride? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SortDirection? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerAudioResponseModel? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerCreatedResponse? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerResponseModel? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UtteranceResponseModel>? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UtteranceResponseModel? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbedSegment>? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSeparationResponseModelStatus? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerResponseModel>? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerUpdatedResponse? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineResponse? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelVoiceCategory? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelState? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelSource? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInputResponseModel>? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextCharacterResponseModel? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextWordResponseModel>? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWordResponseModel? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AdditionalFormatResponseModel?>? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DetectedEntity>? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditedTranscriptVariant1? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptEditError? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1Discriminator? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWebhookResponseModel? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWordResponseModelType? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextCharacterResponseModel>? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartPVCVoiceTrainingResponseModel? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolConfig? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolErrorStatus? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartSpeakerSeparationResponseModel? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamingAudioChunkWithTimestampsResponseModel? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.StudioAgentToolSettingsModel>? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioAgentToolSettingsModel? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioClipLocatorClipType? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitOrderResponse? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionExtrasResponseModel? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionUsageResponseModel? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionResponseModel? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SuggestedAudioTag? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SupportedVoice? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSModelFamily? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemEvaluationCriteria? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params2? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolConfigInput? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberToolConfigInput? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicemailDetectionToolConfig? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInputParamsDiscriminator? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params3? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolConfigOutput? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberToolConfigOutput? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutputParamsDiscriminator? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalModel? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SupportedVoice>? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SuggestedAudioTag>? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSOutputFormat? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextNormalisationType? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteOutcome? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteRequestRole? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionConfig? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateArrayOutput? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunStatus? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateArrayOutputFailureReason? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateOutput>? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutput? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateAudioOutput? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateAudioOutputFailureReason? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateBooleanOutput? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateBooleanOutputFailureReason? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateImageOutput? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateImageOutputFailureReason? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReference? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceReference? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReferenceDiscriminator? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReferenceDiscriminatorType? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateIntegerOutput? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateIntegerOutputFailureReason? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateListResponse? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateSummary>? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateSummary? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateNumberOutput? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateNumberOutputFailureReason? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateObjectOutput? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateObjectOutputFailureReason? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateOutput>? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVideoOutput? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateStringOutput? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutputDiscriminator? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutputDiscriminatorType? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplatePort? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunCreateRequest? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateRunInput>? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunInput? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunListResponse? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunResponse>? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunResponse? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateStringOutputFailureReason? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateVersion>? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVersion? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplatePort>? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVideoOutputFailureReason? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestConditionRationaleCommonModel? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestConditionResultCommonModel? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunMetadata? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunMetadataTestType? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunResultBucket? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunStatus? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestRunResultBucket>? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestSharingMode? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestType? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequest? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequestDiscriminator? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketMergeProposalLinkResponseModel? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSearchMatchField? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TokenResponseModel? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecution? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Icon>? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolAnnotations? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallUnitTestModel? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionTaskSupport? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallDetailsVariant1? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1Discriminator? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModel? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolConfig? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModelToolConfigDiscriminator? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestToolCallParameter>? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameter? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModel? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolConfig2? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModelToolConfigDiscriminator? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolUsageStatsResponseModel? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolSortBy? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolTypeFilter? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsResponseModel? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseModel>? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicEvaluationCriteriaAggregate? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicSentimentAggregate? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TopicEvaluationCriteriaAggregate>? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicSortBy? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoConfigured? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoDefaultingToMain? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoTrafficSplit? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTransferInput>? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTransferOutput>? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchInfoVariant1? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1Discriminator? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchInfoVariant12? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1Discriminator? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumberTransfer>? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioAnsweredBy? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionAction? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionMode? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TwilioMachineDetectionRule>? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionRule? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TwilioAnsweredBy>? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioOutboundCallResponse? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.URLAvatar? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestGuardrailTriggerEvaluationModel? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestInfoVariant1? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1Discriminator? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestWorkflowNodeTransitionEvaluationNodeId? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Eval? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminator? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsRequestModel? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemAttachmentDestination>? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModel? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResultsItem>? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultsItem? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminator? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBasicAuthRequest? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBearerAuthRequest? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateEnvironmentVariableRequest? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMemberUsageLimitRequestModel? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMemberUsageLimitResponseModel? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMusicFinetuneRequestModel? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMusicFinetuneRequestModelVisibility? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2ClientCredsRequest? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequest? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestJwtUsage? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderResponse? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRequest? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateProcedureDraftRequestModel? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateRealtimeConversationGroupRequestModel? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateResponseUnitTestRequest? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateSimulationTestRequest? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateSpeechEngineRequest? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTestSuiteInvocationRequestModel? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateToolCallUnitTestRequest? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateWhatsAppAccountRequest? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateWorkspaceMemberResponseModel? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpsertOrderItemResponse? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsageAggregationInterval? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsageCharactersResponseModel? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserDataCollectionAnalysisItemInput? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Scoring? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminator? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminatorMode? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserResponseModel? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserVoiceCollectionResponseModelPermissionOnResource? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsersSortBy? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?>? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequest? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequestAspectRatio? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequestResolution? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VeoImageReference>? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VeoImageReference? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31Request? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31RequestAspectRatio? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31RequestResolution? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VeoImageReferenceRole? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerifyPVCVoiceCaptchaResponseModel? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysisStatus? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysisResult? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoSubject>? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSubject? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoSegment>? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSegment? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoKeyMoment>? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoKeyMoment? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequest? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequestDiscriminator? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReferenceDiscriminator? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReferenceDiscriminatorType? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceDesignRequestModel? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceDesignRequestModelModelId? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewResponseModel? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewsRequestModel? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewsResponseModel? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoicePreviewResponseModel>? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceRemixRequestModel? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SampleResponseModel>? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelCategory? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModel? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelSafetyControl? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceVerificationResponseModel? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelRecordingQuality? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelLabellingStatus? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSamplePreviewResponseModel? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSampleVisualWaveformResponseModel? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingModerationCheckResponseModel? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelStatus? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelCategory? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelReviewStatus? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReaderResourceResponseModel>? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookAuthMethodType? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookHttpMethod? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetAll? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetIds? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetDiscriminator? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetDiscriminatorType? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInput? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInputContentType? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutput? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutputContentType? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookUsageType? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppCallPermissionRequest? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppCallPermissionRequestState? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppConversationInfoDirection? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppRecipient? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOpeningMessage? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOutboundCallResponse? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOutboundMessageResponse? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateTextParam>? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateTextParam? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateDocumentParam? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateDocumentParamDetails? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ParametersItem>? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ParametersItem? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateImageParam? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateLocationParam? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminator? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateImageParamDetails? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateLocationParamDetails? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetPlacement? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetExpandable? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetFeedbackMode? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetEndFeedbackConfig? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigInputSyntaxHighlightTheme? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTextContents? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetStyles? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WidgetLanguagePreset>? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetLanguagePreset? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigOutputSyntaxHighlightTheme? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigResponseModelSyntaxHighlightTheme? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WidgetLanguagePresetResponse>? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetLanguagePresetResponse? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetEndFeedbackType? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTextContentsTranslation? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTermsTranslation? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForwardConditionVariant1? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUnconditionalModelInput? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowLLMConditionModelInput? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowResultConditionModelInput? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowExpressionConditionModelInput? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1Discriminator? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackwardConditionVariant1? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PositionInput>? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForwardConditionVariant12? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUnconditionalModelOutput? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowLLMConditionModelOutput? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowResultConditionModelOutput? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowExpressionConditionModelOutput? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackwardConditionVariant12? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1Discriminator? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PositionOutput>? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeOutcome? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem2>? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem2? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminator? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination2? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminator? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant12? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1Discriminator? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem3>? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem3? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination3? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminator? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant13? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolEdgeStepModel? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocator? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SchemaOverridesVariant12? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminator? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminatorSource? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNestedToolsStepModelInput? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkflowToolLocator>? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem>? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StepsItem? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminator? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem2>? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StepsItem2? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminator? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>>? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>>? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ColumnUnit?>? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceApiKeyListResponseModel? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceApiKeyResponseModel>? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceApiKeyResponseModel? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAuditLogEntryResponse? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAuditLogsPageResponse? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAuditLogEntryResponse>? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceBatchCallsResponse? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BatchCallResponse>? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateApiKeyResponseModel? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateServiceAccountResponseModel? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateWebhookResponseModel? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupByNameResponseModel? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupPermission? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupPermission>? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceMemberResponseModel? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceServiceAccountListResponseModel? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceServiceAccountResponseModel>? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceServiceAccountResponseModel? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupResponseModel>? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookListResponseModel? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookResponseModel>? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookResponseModel? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookUsageResponseModel? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationNode? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateOAuth2ClientCredsRequest, global::ElevenLabs.UpdateBasicAuthRequest, global::ElevenLabs.UpdateBearerAuthRequest, global::ElevenLabs.UpdateOAuth2JWTRequest>? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateExotelPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UserEvaluationAnalysisItem, global::ElevenLabs.UserDataCollectionAnalysisItemInput>? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequest? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminator? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistorySortDirection? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistorySource? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechFullOutputFormat? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechStreamOutputFormat? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToSpeechFullOutputFormat? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToSpeechStreamOutputFormat? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectListSortDirection? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingStatus? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingStatusesVariant1Item? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingModelsVariant1Item? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsCreationSourcesVariant1Item? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsFilterByCreator? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsOrderBy? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsOrderDirection? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDubbedTranscriptFileFormatType? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDubbingTranscriptsFormatType? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionariesMetadataSort? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestType>? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListChatResponseTestsRouteSortMode? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoriesRouteSummaryMode? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item>? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GuardrailType>? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoryRouteFormat? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item>? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketSource>? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketPriority>? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolTypeFilter>? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListEnvironmentVariablesType? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerateOutputFormat? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComposeDetailedOutputFormat? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComposeDetailedStreamOutputFormat? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamComposeOutputFormat? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetFinetunesSort? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetFinetunesSortDirection? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderState>? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListVideoGenerationsStatus? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListImageGenerationsStatus? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTextToSpeechGenerationsStatus? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DownloadSpeechHistoryItemsResponse? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DubbingTranscriptResponseModel, string>? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ModelResponseModel>? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponse? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponseDiscriminator? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponse? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponseDiscriminator? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkspaceGroupResponseModel>? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupByNameResponseModel>? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceMemberResponseModel>? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponse2? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminator? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminatorStatus? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponse? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminator? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponse? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminator? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AssignableUserResponseModel>? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItem? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminator? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponse? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminator? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminatorProvider? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponse? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminator? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminatorProvider? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponse2? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponse? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponseDiscriminator? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponse? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminator? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponse? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminator? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminatorType? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponse2? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminator? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponse? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminator? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponse2? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminator? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBServiceDBModel>? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBAssetResourceDBModel>? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBProductDBModel>? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBStaffResourceDBModel>? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBCustomerFacingAgentResponse>? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBProcedureResponse>? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBPhoneAssignmentDBModel>? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.HolidayResponseModel>? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LocationResponse>? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBKnowledgeSourceDBModel>? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerTierResponse>? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBTeamMemberResponse>? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBTeamInviteResponse>? Type2925 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ASTNodeInput>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ASTNodeOutput>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ExportOptions>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EvaluationCriteriaItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DataCollectionItem>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EvaluationCriteriaItem2>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DataCollectionItem2>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentVersionMetadata>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketCommentResponseModel>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TurnCommentResponseModel>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketPriorityChangeResponseModel>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketStatusChangeResponseModel>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentDeploymentRequestItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentKnowledgeBaseRagListingEntryResponseModel>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MergeProposalReview>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MergeProposalComment>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AttachedTestModel>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResourceAccessInfo>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemVersionResponseModel>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemResponseModel>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableAssignment>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AssetResponse>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioSegment>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioKeyMoment>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioEffectsFilterPresetResponseModel>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioEffectsEnvironmentResponseModel>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceSegment>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.McpServersItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentIntegrationConnectionIdentifier>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AllowlistItem>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Llm>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OutboundCallRecipientResponseModel>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetOrCreateRAGIndexRequestModel>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MetronomeUsageColumnFilter>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ColumnFilter>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateParamsItem>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PromptEvaluationCriteria>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OutboundCallRecipient>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DialogueInput>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookEventType>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>, string>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupConfig>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ImageReference>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoReference>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioReference>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockInputModel>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockResponseModel>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CharacterAlignmentModel>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterSnapshotResponseModel>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceStatisticsResponseModel>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>?>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ProcedureValidationError>>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProcedureValidationError>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.List<object>, object>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem2>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.McpServersItem2>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SecretDependencyType>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WebhookEventType>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ClientEvent>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DataCollectionResultCommonModel>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ScopedAnalysisResult>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceRewardModel>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConfigEntityType>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableUpdateCommonModel>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationReasoningModel>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TriggeredGuardrailCommonModel>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigOutput>>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigOutput>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceUsageModel>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.FrustratedConversationRef>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TurnCommentRequestModel>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentSuccessfulResponseExample>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentFailureResponseExample>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigInput>>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigInput>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomGuardrailConfig>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentRule>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBTransferRule>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBProcedure>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DataCollectionValueSchemaType?, global::System.Collections.Generic.List<string>>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WordTimestamp>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReadMetadataChapterDBModel>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Contributor>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SegmentSubtitleFrame>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptSegment>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTargetTranscriptSegment>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingLanguageResponse>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoicesNotPermittedWarning>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingMetadataResponse>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingProjectResponse>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptUtterance>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptWord>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptCharacter>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocator>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EnvironmentVariableResponse>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EnvironmentResponse>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModel>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VerificationAttemptResponseModel>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentWordResponseModel>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketResponseModel>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetWhatsAppAccountResponse>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTopicResponseModel>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentSummaryResponseModel>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem2>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentBranchInfo>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioIsolationHistoryItemResponseModel>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterResponseModel>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VisitedAgentRef>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationSummaryMessageModel>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationTagResponseModel>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationUserResponseModel>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationSummaryResponseModel>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem3>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DocumentUsageModeEnum>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DocumentsItem>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem2>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem3>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem4>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LibraryVoiceResponseModel>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MediaCodec>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem2>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectResponseModel>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SIPLogMessage>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechHistoryItemResponseModel>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestInvocationSummaryResponseModel>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestRunResultSummary>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestRunResponseModel>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestSummaryResponseModel>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem4>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolExecutionResponseModel>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UserVoiceCollectionResponseModel>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceAccentResponseModel>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceResponseModel>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TimeRangeModel>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ImageSubject>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AlertingWebhookHeader>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DiscountResponseModel>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseContentSearchResult>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SearchHighlightSegment>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseRagChunkModel>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SearchStrategy>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMObjectJsonSchemaPropertyInput>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMReasoningEffort>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMServiceTier>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMInfoModel>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?, global::System.Collections.Generic.List<string>>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguageInfo>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AuthConnectionsItem>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetCrawlJobResponseModel>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Tool>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolApprovalStatus>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderSummary>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProcedureListItemResponseModel>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentBranchSummary>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentDeploymentHistoryItem>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechEngineSummaryResponse>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.List<string>>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolApprovalHash>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverrideInput>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverrideOutput>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem5>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPServerResponseModel>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ManualVerificationFileResponseModel>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MediaGenerationResponse>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem3>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.FieldConflict>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MessagesSearchResult>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguageResponseModel>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextChunkResponseModel>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MusicFinetuneResponseModel>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SongSection>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelAttribute>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelScopeSpans>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelSpan>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelResourceSpans>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem3>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem4>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DeliverableInfo>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderItemInfo>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentMergeProposalResponse>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguagePairInfo>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem2>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectVoiceResponseModel>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectSnapshotResponseModel>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseLocator>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem5>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem6>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsVariant1Item>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsVariant1Item2>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TeamInviteRequest>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TeamInviteResult>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RAGDocumentIndexResponseModel>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RagChunkMetadata>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RawLocationInfo>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RealtimeConversationGroupResponseModel>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RequiredConstraint>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerInvoiceLine>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerInvoiceSummary>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerUpcomingPayment>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerWorkspaceSummary>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ShareOptionResponseModel>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SingleTestRunRequestModel>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBGroupMembership>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBIntakeQuestion>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBServiceVariant>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBAddOn>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBServicePromotion>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderFulfillmentType>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBNotificationChannel>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SafetyRule>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TimeRange>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SimilarVoice>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UtteranceResponseModel>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DialogueInputResponseModel>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextWordResponseModel>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AdditionalFormatResponseModel?>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DetectedEntity>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextCharacterResponseModel>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SupportedVoice>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SuggestedAudioTag>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateOutput>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateSummary>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateRunInput>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateRunResponse>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateVersion>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplatePort>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestRunResultBucket>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Icon>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestToolCallParameter>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseModel>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TopicEvaluationCriteriaAggregate>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTransferInput>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTransferOutput>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumberTransfer>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TwilioMachineDetectionRule>? ListType294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TwilioAnsweredBy>? ListType295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemAttachmentDestination>? ListType296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResultsItem>? ListType297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<double>>? ListType298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>? ListType299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VeoImageReference>? ListType300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoSubject>? ListType301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoSegment>? ListType302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoKeyMoment>? ListType303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoicePreviewResponseModel>? ListType304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SampleResponseModel>? ListType305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReaderResourceResponseModel>? ListType306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WhatsAppTemplateTextParam>? ListType307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ParametersItem>? ListType308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PositionInput>? ListType309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PositionOutput>? ListType310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem2>? ListType311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem3>? ListType312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkflowToolLocator>? ListType313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.StepsItem>? ListType314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.StepsItem2>? ListType315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.TimeRangeModel>>? ListType316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>? ListType317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>>? ListType318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>? ListType319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ColumnUnit?>? ListType320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceApiKeyResponseModel>? ListType321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAuditLogEntryResponse>? ListType322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BatchCallResponse>? ListType323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupPermission>? ListType324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceServiceAccountResponseModel>? ListType325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupResponseModel>? ListType326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookResponseModel>? ListType327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>? ListType328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? ListType329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? ListType330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? ListType331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestType>? ListType332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item>? ListType333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GuardrailType>? ListType334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item>? ListType335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketSource>? ListType336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketPriority>? ListType337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentType>? ListType338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolTypeFilter>? ListType339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderState>? ListType340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ModelResponseModel>? ListType341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupByNameResponseModel>? ListType342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceMemberResponseModel>? ListType343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AssignableUserResponseModel>? ListType344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>? ListType345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBServiceDBModel>? ListType346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBAssetResourceDBModel>? ListType347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBProductDBModel>? ListType348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBStaffResourceDBModel>? ListType349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBCustomerFacingAgentResponse>? ListType350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBProcedureResponse>? ListType351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBPhoneAssignmentDBModel>? ListType352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.HolidayResponseModel>? ListType353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LocationResponse>? ListType354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBKnowledgeSourceDBModel>? ListType355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerTierResponse>? ListType356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBTeamMemberResponse>? ListType357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBTeamInviteResponse>? ListType358 { get; set; }
    }
}