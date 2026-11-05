
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
        public global::ElevenLabs.AgentKnowledgeBaseRagQueryRequestModel? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagQueryResponseModel? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalReview>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReview? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalComment>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalComment? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Outcome? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenOutcome? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergedOutcome? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClosedOutcome? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminator? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadata? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadataDBModel? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadataResponseModel? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSettingsInput? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigInput? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisProperty>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisProperty? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisScope>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisScope? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataConfigInput? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkspaceOverridesInput? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestingSettings? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsV1Input? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthSettings? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentQueueingConfig? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivacyConfigInput? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTrustContext? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Llm? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicDiscoverySettings? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SentimentAnalysisSettings? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSettings? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentPlatformSettingsResponseModel? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSettingsOutput? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigOutput? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataConfigOutput? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkspaceOverridesOutput? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsV1Output? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivacyConfigOutput? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSettingsResponse? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyResponseModel? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentRule? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RulePriority? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSMBMetadata? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAgentType? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSimulatedChatTestResponseModel? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptResponseModel? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryAnalysisCommonModel? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSortBy? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSuccessfulResponseExample? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSummaryBatchSuccessfulResponseModel? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSummaryResponseModel? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestEntityType? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestFolderPathSegmentResponseModel? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AttachedTestModel>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedTestModel? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTopicResponseModel? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicMetricsAggregate? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferInput? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOutput? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOp? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpReplace? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpPush? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpPop? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpDiscriminator? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpDiscriminatorType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentVersionParents? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResourceAccessInfo>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelInput>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInput? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Nodes? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartNodeModelInput? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeModelInput? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInput? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelInput? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNodeModelInput? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminator? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModel? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelOutput>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutput? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Nodes2? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartNodeModelOutput? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeModelOutput? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNodeModelOutput? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminator? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataWebhook? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIWebhooks? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingMonitorConfig? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingPagerDutyNotifier? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingPagerDutyNotifierResponse? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AlertingMonitorConfig>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookNotifier? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSlackNotifier? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookNotifierResponse? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSlackNotifierResponse? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookHeader? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookMethod? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookSecretHeaderValue? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowedOutputFormats? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowedValues? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowlistItem? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisCharging? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisRunningTotal? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisRunSnapshot? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentAction? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentDestination? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentResultData? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemKind? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModel? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Definition? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItem? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserDataCollectionAnalysisItemOutput? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModelDefinitionDiscriminator? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModelDefinitionDiscriminatorKind? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemSource? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModel? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Definition2? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminator? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminatorKind? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionsResponseModel? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemVersionResponseModel>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemsResponseModel? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemResponseModel>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisPropertyType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisType? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependencies? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionStatus? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverrides? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SchemaOverridesVariant1? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConstantSchemaOverride? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableSchemaOverride? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMSchemaOverride? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OmitSchemaOverride? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminator? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseFilterMode? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAIDynamicVariable>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIDynamicVariable? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigInput? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolInterruptionMode? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PreToolSpeechMode? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableAssignment? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallSoundType? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallSoundBehavior? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolErrorHandlingMode? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionMode? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApplicationNumberType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AppointmentReminderMode? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArchitectDispatchResponseModel? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyInput? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LiteralJsonSchemaProperty? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyInput? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyOutput? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyOutput? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArraySchema? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchema? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetListResponse? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AssetResponse>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetResponse? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscription? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscriptionStatus? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscriptionData? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignConversationTagsRequestModel? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignResellerTierRequest? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignResellerTierRequestBillingPeriod? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignableUserResponseModel? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadata? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadataDeliveryStatus? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemDataCollectionId? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemEvaluationId? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysis? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysisStatus? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysisResult? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioSegment>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioSegment? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioKeyMoment>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioKeyMoment? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsCatalogResponseModel? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsFilterPresetResponseModel>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsFilterPresetResponseModel? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsEnvironmentResponseModel>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsEnvironmentResponseModel? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioFormat? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioInputPacing? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioIsolationHistoryItemResponseModel? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeCreateProjectResponseModel? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeEditContentResponseModel? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeProjectSettingsResponseModel? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioRefChunk? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeRange? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReference? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationReference? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StaticAssetReference? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineAudioReference? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReferenceDiscriminator? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReferenceDiscriminatorType? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioSchema? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioWithTimestampsAndVoiceSegmentsResponseModel? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAlignmentResponseModel? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceSegment>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSegment? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioWithTimestampsResponseModel? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuditActivityName? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuditClassName? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableToolIdentifier? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownToolIdentifier? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesToolDiscriminator? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.McpServersItem? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableMCPServerIdentifier? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownMCPServerIdentifier? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminator? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentIntegrationConnectionIdentifier>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentIntegrationConnectionIdentifier? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionLocator? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AllowlistItem>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthorizationMethod? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoGenerationMetadata? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoRebaseAttempt? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoRebaseOutcome? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoSyncInfo? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AvatarContextResponseModel? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundConfig? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundSourceType? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundPresetId? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundConfigWorkflowOverride? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMDefault? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMDisabled? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMOverride? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Llm>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BaseTurnConfig? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnMode? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnEagerness? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpellingPatience? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnModel? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BasicAuthResponse? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallDetailedResponse? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyProvider? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallWhatsAppParams? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallStatus? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyCallConfigOutput? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipientResponseModel>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundCallRecipientResponseModel? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallRecipientStatus? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallResponse? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallingCampaignInformation? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignConversationType? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchFailureResponseModel? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchSuccessResponseModelAnalysisItemAttachmentResultData? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BearerAuthResponse? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Verbosity? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutputFormat? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InteractionBudget? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BillingPeriod? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BinaryScoring? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddSamplesToPvcVoiceV1VoicesPvcVoiceIdSamplesPost? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddVoiceV1VoicesAddPost? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string>? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPost? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPost? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkDeleteKnowledgeBaseDocumentsV1ConvaiKnowledgeBaseBulkDeletePost? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkMoveTestsToFolderV1ConvaiAgentTestingBulkMovePost? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCommentOnAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdCommentsPost? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPost? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicGenerationMode? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicPrompt? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompositionPlan? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicModelID? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicV1MusicPost? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetOrCreateRAGIndexRequestModel>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRAGIndexRequestModel? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentV1ConvaiAgentsCreatePost? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSettings? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPost? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePvcVoiceV1VoicesPvcPost? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPost? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QualityPresetType? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateUrlDocumentV1ConvaiKnowledgeBaseUrlPost? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoicePost? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentTestFolderV1ConvaiAgentTestingFoldersPost? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateChapterV1StudioProjectsProjectIdChaptersPost? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateCrawlJobV1ConvaiKnowledgeBaseCrawlPost? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateForcedAlignmentV1ForcedAlignmentPost? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPost? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastConversationMode? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastBulletinMode? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastTextSource? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastURLSource? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateVoiceCollectionV1VoicesCollectionsPost? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookHMACSettings? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDeleteExistingInvitationV1WorkspaceInvitesDelete? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDownloadHistoryItemsV1HistoryDownloadPost? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPost? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditPvcVoiceV1VoicesPvcVoiceIdPost? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPost? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePost? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MetronomeUsageColumnFilter>? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetronomeUsageColumnFilter? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnFilter? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetDependentAgentsForMultipleDocumentsV1ConvaiKnowledgeBaseDependentAgentsPost? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaExotelV1ConvaiExotelOutboundCallPost? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataRequestInput? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyCallConfigInput? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaSipTrunkV1ConvaiSipTrunkOutboundCallPost? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SeatType? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyInviteUserV1WorkspaceInvitesAddPost? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMergeAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdMergePost? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ProcedureVersionRef>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureVersionRef? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPostAgentHoldAudioV1ConvaiAgentsAgentIdHoldAudioPost? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRebaseABranchOntoMainV1ConvaiAgentsAgentIdBranchesBranchIdRebasePost? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyDirection? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRegisterMediaV1ProductionsOrdersOrderIdMediaPost? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RenderType? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyReviewAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdReviewsPost? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReviewState? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateParamsItem>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateParamsItem? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParams? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateBodyComponentParams? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateButtonComponentParams? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySetRulesOnThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdSetRulesPost? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySetWorkspaceThirdPartyDisablingPolicyV1WorkspacesApiKeysThirdPartyDisablingPost? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceResourceType? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSimulationSpecification? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PromptEvaluationCriteria>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptEvaluationCriteria? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySoundGenerationV1SoundGenerationPost? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SFXModelId? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, object>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPost? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamChapterAudioV1StudioProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamComposedMusicV1MusicStreamPost? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPost? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipient>? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundCallRecipient? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPost? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInput>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DialogueInput? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToDialogueSettingsResponseModel? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EffectsSpecInput? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePost? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTranslatesAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdTranslatePost? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdatePvcVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateStudioProjectV1StudioProjectsProjectIdPost? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdPatch? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAgentTestFolderV1ConvaiAgentTestingFoldersFolderIdPatch? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentInputModel? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateFileDocumentV1ConvaiKnowledgeBaseDocumentationIdUpdateFilePatch? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPost? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateOrderV1ProductionsOrdersOrderIdPatch? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderRequest? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateVoiceCollectionV1VoicesCollectionsCollectionIdPatch? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookEventType>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookEventType? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadAssetV1AssetsPost? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadFileV1ConvaiConversationsConversationIdFilesPost? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadMusicV1MusicUploadPost? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<bool?, global::ElevenLabs.MusicModelID?>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpsertOrderItemV1ProductionsOrdersOrderIdItemsPost? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpsertOrderItemRequest? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVerifyPvcVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVideoToMusicV1MusicVideoToMusicPost? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPost? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerV1VoiceChangerVoiceIdPost? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PermissionType? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateServiceAccountV1ServiceAccountsPost? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupConfig>? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupConfig? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<bool?, string>? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchExpiresAtUnix?>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchExpiresAtUnix? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbCancelTeamInvite? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbUpdateTeamMemberRole? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbUpdateTeamMemberRoleRole? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbUploadKnowledgeSource? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueFullWithTimestamps? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueStreamWithTimestamps? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFull? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSettingsResponseModel? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullWithTimestamps? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStream? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamWithTimestamps? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BooleanSchema? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BreakdownTypes? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BucketingStatus? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsInput? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInput? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsOutput? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutput? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsWorkflowOverrideInput? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsWorkflowOverrideOutput? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25Request? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTarget? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25RequestAspectRatio? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25RequestResolution? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReference? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoReference>? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReference? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioReference>? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequest? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequestResolution? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequest? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequestResolution? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2Request? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2RequestAspectRatio? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2RequestResolution? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequest? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequestResolution? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequest? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequestResolution? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CalComConnectionHealthStatus? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CalendlyConnectionHealthStatus? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallResult? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelCalendarEventParams? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelGroupSessionForAllParams? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelGroupSessionRegistrationParams? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelOrderParams? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CanvasPlacement? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModel? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleHorizontalPlacementModel? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModel? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleTemplateModel? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextAlign? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextStyle? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextWeight? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextTransform? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextBlendMode? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioTextStyleShadowModel? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioTextStyleOutlineModel? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModel? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModel? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleVerticalPlacementModel? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModelEnterType? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModelExitType? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleVerticalPlacementModelAlign? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModelEnterType? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModelExitType? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChangeResellerTierRequest? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChangeResellerTierRequestBillingPeriod? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockInputModel? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockInputModelSubType? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockResponseModel? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockInputModel>? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentResponseModel? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockResponseModel>? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterResponseModel? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterResponseModelState? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterStatisticsResponseModel? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotExtendedResponseModel? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CharacterAlignmentModel>? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAlignmentModel? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotResponseModel? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotsResponseModel? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterSnapshotResponseModel>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceStatisticsResponseModel>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceStatisticsResponseModel? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterWithContentResponseModelState? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAge? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterGender? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterMetadataResponseModel? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterRole? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterRefreshPeriod? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterResponseModel? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChatSourceMedium? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CheckServiceAvailabilityParams? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientEvent? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientSecretResponse? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutput? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolConfigInput? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolConfigOutput? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimation? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimationEnterEffect? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimationExitEffect? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalCloseReason? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnFilterOperation? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>?>? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnUnit? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompactionSettingsWorkflowOverride? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompileProceduresResponseModel? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompileProceduresValidationErrorResponseModel? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureValidationError>>? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureValidationError>? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureValidationError? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>>? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkInput? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComputedUsagePlatformLimit? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConditionStrength? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConfigEntityType? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConflictSection? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.IList<object>, object>? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentConfig? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentThresholdGuardrail? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInput? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailExecutionMode? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallTriggerAction? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RetryTriggerAction? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminator? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutput? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction2? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminator? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StringSchema? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumberSchema? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntegerSchema? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageSchema? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSchema? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSchema? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectSchema? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchemaDiscriminator? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchemaDiscriminatorType? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentThresholdGuardrailThreshold? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContextualUpdateInfo? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Contributor? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIEnvVarLocator? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIFileUploadResponseModel? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAISecretLocator? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependencies? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem2>? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem2? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminator? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminatorType? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem>? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableAgentIdentifier? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownAgentIdentifier? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminator? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminatorType? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentPhoneNumberIdentifier? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem2>? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.McpServersItem2? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminator? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminatorType? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SecretDependencyType>? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecretDependencyType? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIUserSecretDBModel? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WebhookEventType>? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookEventType? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTranscriptFormat? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationASRUsageModel? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationChargingCommonModel? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMCategoryUsage? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformUsage? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTTSUsageModel? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigInput? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileInputConfig? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DTMFInputConfig? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOutput? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideInput? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigOverride? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOverride? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOverride? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideOutput? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideConfigInput? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigOverrideConfig? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOverrideConfig? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOverrideConfig? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideConfigOutput? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigWorkflowOverrideInput? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileInputConfigWorkflowOverride? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigWorkflowOverrideOutput? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationDeletionSettings? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationErrorType? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationFeedbackRequestModel? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserFeedbackScore? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationFeedbackType? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DataCollectionResultCommonModel>? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionResultCommonModel? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionResultCommonModel>? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSuccessResult? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ScopedAnalysisResult>? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScopedAnalysisResult? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryBatchCallModel? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryElevenAssistantCommonModel? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryErrorCommonModel? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CriteriaScoringMode? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryExotelPhoneCallModel? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryFeedbackCommonModel? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModel? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneCallVariant1? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1Discriminator? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryRagUsageCommonModel? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FeaturesUsageCommonModel? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationSource? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppConversationInfo? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMSConversationInfo? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceRewardModel>? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationVoiceRewardModel? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMultivoiceMessageModel? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryRedactionConfig? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConfigEntityType>? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableUpdateCommonModel>? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableUpdateCommonModel? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelInputRole? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserFeedback? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTurnMetrics? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagRetrievalInfo? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageInput? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptPlatformEvent? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationReasoningModel>? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationReasoningModel? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TriggeredGuardrailCommonModel>? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggeredGuardrailCommonModel? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutputRole? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageOutput? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel>? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultVariant1? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallToolResultModel? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageDetectionToolResultModel? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInput? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultErrorModel? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultSipSuccessModel? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultExotelSuccessModel? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultAmazonConnectSuccessModel? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultErrorModel? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SkipTurnToolResponseModel? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFResultSuccessModel? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFResultErrorModel? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceMailDetectionResultSuccessModel? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestToolResultModel? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolResultModel? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolResultModel? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolResultSuccessModel? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolResultErrorModel? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolResultSuccessModel? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolResultErrorModel? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DummyToolResultModel? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultVariant12? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutput? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolType? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolDetailsVariant1? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolDetailsVariant12? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1Discriminator? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInput? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutput? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataInternal? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationSourceInfo? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableInternalValueType? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrchestratorToolMockBehaviorConfig? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigOutput>>? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigOutput>? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseMockConfigOutput? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataRequestOutput? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator>? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationProduct? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSentimentAnalysis? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSentimentAnalysisOverallLabel? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSignedUrlResponseModel? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ToolMockConfig>? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolMockConfig? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSource? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryMessageModel? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryMessageModelRole? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryResponseModel? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryResponseModelStatus? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EvaluationCriteriaSummaryResult>? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationCriteriaSummaryResult? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceUsageModel>? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationVoiceUsageModel? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTagResponseModel? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTokenPurpose? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTokenResponseModel? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.MetricRecord>? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetricRecord? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationUserResponseModel? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SentimentAggregate? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.FrustratedConversationRef>? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FrustratedConversationRef? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfig? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigInput? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetInput>? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetInput? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VADConfig? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelOutput? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOutput? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetOutput>? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetOutput? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideInput? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigWorkflowOverride? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigWorkflowOverrideInput? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VADConfigWorkflowOverride? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideOutput? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigWorkflowOverrideOutput? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvertChapterResponseModel? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvertProjectResponseModel? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CrawlStatus? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CrawlType? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentBranchResponseModel? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentConversationTicketRequestModel? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentRequestModel>? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnCommentRequestModel? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentMergeProposalResponseModel? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentProcedureParams? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentResponseModel? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentRuleParams? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentTestFolderResponseModel? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentTestResponseModel? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAssetParams? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateBasicAuthRequest? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateBearerAuthRequest? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientAppointmentParams? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientInteractionParams? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientParams? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientSecretRequest? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInput? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExpiresAfter? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateConversationTagRequestModel? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateCrawlJobResponseModel? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateCustomHeaderAuthRequest? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentRequest? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateExotelPhoneNumberRequest? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelApiSubdomain? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateHolidayParams? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateLocationParams? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateMTLSAuthRequest? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateManualTicketRequestModel? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2ClientCredsRequest? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequest? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderParams? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderRequest? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderResponse? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePhoneAssignmentRequest? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePhoneNumberResponseModel? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePrivateKeyJWTRequest? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProcedureRequestModel? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureType? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProcedureResponseModel? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProductParams? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProductQuoteRequestParams? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePronunciationDictionaryResponseModel? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateRealtimeConversationGroupRequestModel? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateResponseUnitTestRequest? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestFromConversationMetadataInput? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentSuccessfulResponseExample>? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentFailureResponseExample>? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InboundSIPTrunkConfigRequestModel? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundSIPTrunkConfigRequestModel? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSecretEnvironmentVariableRequest? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest>? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableSecretValueRequest? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateServiceParams? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateServiceQuoteRequestParams? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSimulationTestRequest? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationToolMockBehaviorConfig? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>>? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseMockConfigInput? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSpeechEngineRequest? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineConfig? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineAuthConfig? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineConversationInitiationClientDataConfig? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateStaffParams? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateStringEnvironmentVariableRequest? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTeamInviteRequest? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTeamInviteRequestRole? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateToolCallUnitTestRequest? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallEvaluationModelInput? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTransferRuleParams? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTwilioPhoneNumberRequest? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegionConfigRequest? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatifyAuroraRequest? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatifyAuroraRequestResolution? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CueOptionsRequest? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Currency? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailInput? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailsConfigInput? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailOutput? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailsConfigOutput? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfig? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigModel? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction3? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminator? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomGuardrailConfig>? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomHeaderAuthResponse? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomLLM? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator>? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator>? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentAuthConnectionLocator? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomLLMAPIType? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSIPHeader? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomerFacingConfigInput? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMReasoningEffort? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBTurnEagerness? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentRule>? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBTransferRule>? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBTransferRule? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBProcedure>? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBProcedure? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomerFacingConfigOutput? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomerFacingConfigPatch? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardCallSuccessChartModel? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardCriteriaChartModel? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardDataCollectionChartModel? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionValueSchema? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DataCollectionValueSchemaType?, global::System.Collections.Generic.IList<string>>? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionValueSchemaType? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DateModel? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupResponseModel? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupResponseModel? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentHoldAudioResponseModel? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentProcedureParams? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentRuleParams? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAssetParams? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteCalendarEventParams? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteChapterResponseModel? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteClientInteractionParams? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteClientParams? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteDubbingResponseModel? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteGroupSessionParams? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteHistoryItemResponse? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteHolidayParams? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteLocationParams? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteProductParams? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteProjectResponseModel? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteSampleResponseModel? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteServiceParams? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteStaffParams? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteTransferRuleParams? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteUserVoiceCollectionResponseModel? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteVoiceResponseModel? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteVoiceSampleResponseModel? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceGroupMemberResponseModel? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceInviteResponseModel? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceWebhookResponseModel? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeliverableInfo? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableAgentIdentifierAccessLevel? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentBranchInfo? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DetailedMusicResponse? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongMetadata? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WordTimestamp>? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WordTimestamp? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DetectedEntity? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeviceModel? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DialogueInputResponseModel? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModel? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReadMetadataChapterDBModel>? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReadMetadataChapterDBModel? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReadLegalTerms? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Contributor>? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelPayoutType? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PreviewAudioDBModel? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleConfigDBModel? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModel? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DiscountResponseModel? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DoDubbingResponseModel? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocumentUsageModeEnum? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocxExportOptions? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubOrderItemRequest? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbedSegment? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SegmentSubtitleFrame>? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentSubtitleFrame? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMediaReference? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkSegmentUpdateRequest? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingSegmentUpdateRequest>? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSegmentUpdateRequest? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkSourceSegmentUpdateResponse? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptSegment>? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptSegment? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkTargetSegmentUpdateRequest? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingTargetSegmentUpdateRequest>? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetSegmentUpdateRequest? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkTargetSegmentUpdateResponse? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTargetTranscriptSegment>? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetTranscriptSegment? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingError? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageListResponse? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingLanguageResponse>? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageResponse? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageOutputs? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageResponseStatus? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoicesNotPermittedWarning>? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicesNotPermittedWarning? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMediaMetadata? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMetadataPageResponseModel? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingMetadataResponse>? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMetadataResponse? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectListResponse? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingProjectResponse>? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectResponse? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectResponseStatus? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceMediaInfo? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingRegenerateResponse? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingReleaseChannel? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingRenderResponseModel? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingResource? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerTrack>? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerTrack? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerSegment>? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSegment? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.Render>? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Render? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSegmentCreateRequest? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceSegmentUpdateResponse? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceTranscriptResponse? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetSegmentUpdateResponse? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetTranscriptResponse? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscript? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptUtterance>? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptUtterance? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptCharacter? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptResponseModel? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptRevisionResponse? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptWord>? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptWord? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptCharacter>? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptsResponseModel? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DuplicateSpeechEngineRequest? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Eagerness? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditChapterResponseModel? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditProjectResponseModel? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditVoiceResponseModel? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditVoiceSettingsResponseModel? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditedTranscript? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EffectsSpecOutput? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25Request? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25RequestOutputFormat? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocator>? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocator? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25VoiceSettings? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenMultilingualV2Request? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TtsVoiceSettings? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3Request? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3RequestOutputFormat? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3VoiceSettings? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EmbedVariant? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EmbeddingModelEnum? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallToolConfig? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolConfig? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ProcedureVersionRef, global::ElevenLabs.ProcedureDraftRef>? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureDraftRef? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolErrorStatus? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EntryBehavior? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentResponse? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableAuthConnectionValue? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableResponse? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableResponseType? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableSecretValue? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariablesListResponse? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentVariableResponse>? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentsListResponse? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentResponse>? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationResultFilter? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExactParameterEvaluationStrategy? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelOutboundCallResponse? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExperimentAssignment? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExperimentAssignmentSource? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentedJsonExportOptions? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PdfExportOptions? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TxtExportOptions? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HtmlExportOptions? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SrtExportOptions? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptionsDiscriminator? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptionsDiscriminatorFormat? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExtendedSubscriptionResponseModel? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, string>? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Price? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionStatusType? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModel? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModel>? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel>? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingSubscriptionSwitchResponseModel? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingCancellationResponseModel? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalFileSyncInfo? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncProvider? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalFolderSyncInfo? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncJobTrigger? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncJobType? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FeatureStatusCommonModel? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowFeaturesUsageCommonModel? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestsFeatureUsageCommonModel? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FieldConflict? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileRefreshStatus? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FineTuningResponseModel? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.FineTuningResponseModelState2>? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FineTuningResponseModelState2? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VerificationAttemptResponseModel>? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerificationAttemptResponseModel? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualVerificationResponseModel? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FinetuneCreatedBy? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FinetuneVisibility? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FocusGuardrail? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentCharacterResponseModel? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentResponseModel? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentWordResponseModel>? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentWordResponseModel? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FrustratedConversationRefOverallLabel? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1Request? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestQuality? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestBackground? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestAspectRatio? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15Request? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestQuality? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestBackground? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestAspectRatio? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequest? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestQuality? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestAspectRatio? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestResolution? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequest? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestQuality? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestAspectRatio? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestResolution? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2Request? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestQuality? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestAspectRatio? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestResolution? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini25FlashImageRequest? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini25FlashImageRequestAspectRatio? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequest? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequestAspectRatio? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequestResolution? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashLiteImageRequest? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequest? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequestAspectRatio? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequestResolution? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkInputContextAdherence? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkOutput? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkOutputContextAdherence? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationSourceContext? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferenceVideo? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenesysBotOutcome? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenesysRegion? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentConfigParams? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentConversationTicketsPageResponseModel? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketResponseModel>? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentEmbedResponseModel? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigResponseModel? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgebaseSizeResponseModel? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentLinkResponseModel? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModel? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem>? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberTwilioResponseModel? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberExotelResponseModel? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminator? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetWhatsAppAccountResponse>? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWhatsAppAccountResponse? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ProcedureRefResponseModel>? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureRefResponseModel? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentTestFolderResponseModel? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentTopicsResponseModel? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTopicResponseModel>? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentsPageResponseModel? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentSummaryResponseModel>? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModel? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem2>? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem2? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModelAgentDiscriminator? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorType? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentBranchInfo>? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalyticsSummaryParams? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAppointmentByConfirmationNumberParams? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAudioIsolationHistoryResponseModel? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioIsolationHistoryItemResponseModel>? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAudioNativeProjectSettingsResponseModel? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetBookingPageSettingsParams? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetBookingSlugStatusParams? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetChaptersResponseModel? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterResponseModel>? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientAppointmentsParams? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientByPhoneParams? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientOrdersParams? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModel? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem>? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChartsItem? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminator? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAISettingsResponseModel? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LivekitStackType? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationResponseModel? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationResponseModelStatus? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VisitedAgentRef>? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VisitedAgentRef? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationSummaryResponseModel? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationSummaryResponseModelStatus? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryMessageModel>? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationTagsPageResponseModel? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationTagResponseModel>? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationUsersPageResponseModel? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationUserResponseModel>? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationsPageResponseModel? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryResponseModel>? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetCrawlJobResponseModel? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModel? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem3>? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem3? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseFileResponseModel? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentMetadataResponseModel? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DocumentUsageModeEnum>? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KbExternalSyncJob? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModel? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DocumentsItem>? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocumentsItem? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminator? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem>? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminator? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem2>? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem2? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminator? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem3>? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem3? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminator? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem4>? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem4? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminator? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseTextResponseModel? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseURLResponseModel? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetLibraryVoicesResponseModel? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LibraryVoiceResponseModel>? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceResponseModel? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetLiveCountResponse? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrderByConfirmationNumberParams? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberAgentInfo? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberInboundSIPTrunkConfigResponseModel? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPMediaEncryptionEnum? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberOutboundSIPTrunkConfigResponseModel? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkTransportEnum? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MediaCodec>? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaCodec? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModel? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem2>? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem2? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminator? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetProjectsResponseModel? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectResponseModel>? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionariesMetadataResponseModel? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModel? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetResponseUnitTestResponseModel? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestFromConversationMetadataOutput? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSIPLogMessagesResponse? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SIPLogMessage>? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPLogMessage? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetScheduleParams? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModel? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependenciesVariant1Item? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminator? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependenciesVariant2Item? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminator? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSimulationTestResponseModel? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistoryResponseModel? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechHistoryItemResponseModel>? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModel? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestInvocationsPageResponseModel? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseMeta? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestInvocationSummaryResponseModel>? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestInvocationSummaryResponseModel? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestSuiteInvocationResponseModel? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestRunResultSummary>? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunResultSummary? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestRunResponseModel>? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModel? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestsPageResponseModel? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestSummaryResponseModel>? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestSummaryResponseModel? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestsSummariesByIdsResponseModel? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.UnitTestSummaryResponseModel>? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolCallUnitTestResponseModel? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallEvaluationModelOutput? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModel? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem4>? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem4? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminator? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminatorType? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolExecutionsPageResponseModel? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolExecutionResponseModel>? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModel? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetUserVoiceCollectionsResponseModel? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UserVoiceCollectionResponseModel>? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserVoiceCollectionResponseModel? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoiceAccentsResponseModel? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceAccentResponseModel>? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceAccentResponseModel? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoicesResponseModel? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceResponseModel>? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModel? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoicesV2ResponseModel? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppAccountType? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWorkspacePlanParams? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWorkspaceSecretsResponseModel? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailType? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsResult? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptInjectionGuardrail? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationGuardrailInput? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationGuardrailOutput? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HTTPValidationError? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ValidationError>? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ValidationError? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HidingReason? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HistoryAlignmentResponseModel? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HistoryAlignmentsResponseModel? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HolidayResponseModel? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HolidayType? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeRangeModel? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeOffType? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HttpRequestModel? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UrlModel? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Icon? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IconTheme? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysis? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysisStatus? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysisResult? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageSubject>? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageSubject? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAvatar? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequest? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequestDiscriminator? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineImageReference? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReferenceDiscriminator? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReferenceDiscriminatorType? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkCredentialsRequestModel? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IngestFailure? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineAudioReferenceMimeType? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineBase64Reference? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineBase64ReferenceMimeType? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineImageReferenceMimeType? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineVideoReference? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineVideoReferenceMimeType? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntakeQuestionKind? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntegrationType? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InternalAlertingWebhookNotifier? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AlertingWebhookHeader>? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InternalKBCrawlPageTiming? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InternalSamplingConfigResponseModel? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DiscountResponseModel>? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModelPaymentIntentStatus? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDeletedResponseModel? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResponseModel? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseContentSearchResult>? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResult? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Document? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminator? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminatorType? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchHighlightSegment>? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchHighlightSegment? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDependentType? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentChunksResponseModel? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel>? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseLocator? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagChunkModel? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolConfig? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolStatus? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseRagChunkModel>? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSortBy? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSourceFileUrlResponseModel? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Data? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminator? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolConfig? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchStrategy>? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchStrategy? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolInfo? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolStatus? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeSourceStatus? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeSourceType? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMAnyOfJsonSchemaPropertyInput? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMObjectJsonSchemaPropertyInput>? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMObjectJsonSchemaPropertyInput? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMAnyOfJsonSchemaPropertyOutput? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMArrayJsonSchemaPropertyInput? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMArrayJsonSchemaPropertyOutput? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMObjectJsonSchemaPropertyOutput? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMDeprecationConfigModel? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMDeprecationInfoModel? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMInfoModel? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMReasoningEffort>? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMServiceTier>? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMServiceTier? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegionalProcessingSurchargeInfo? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMInputOutputTokensUsage? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMTokensCategoryUsage? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMListResponseModel? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMInfoModel>? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMLiteralJsonSchemaPropertyType? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMParameterEvaluationStrategy? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LLMInputOutputTokensUsage>? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorLLMResponseModel? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorPublicRequestModel? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorRequestModel? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorResponseModel? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageAddedResponse? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageDetectionToolConfig? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageInfo? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePairInfo? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguageInfo>? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetTranslation? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageResponseModel? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponse? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PairedLanguagesResponse? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleLanguagesResponse? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponseDiscriminator? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponseDiscriminatorKind? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeaveMessageParams? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LenientCurrencyEnum? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBVertical? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceResponseModelCategory? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerifiedVoiceLanguageResponseModel? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentProceduresParams? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentReferencesParams? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentRulesParams? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAssetsParams? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponse? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AuthConnectionsItem>? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionsItem? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2ClientCredsResponse? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshTokenAuthResponse? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponse? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivateKeyJWTResponse? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MTLSAuthResponse? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppAuthResponse? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SlackBotAuthResponse? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UrlSecretAuthResponse? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminator? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCalendarEventsParams? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListClientInteractionsParams? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListClientsParams? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCrawlJobsResponseModel? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetCrawlJobResponseModel>? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCustomerFacingAgentsParams? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListGroupSessionsParams? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListHolidaysParams? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListLocationsParams? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListMCPToolsResponseModel? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Tool>? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Tool? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolApprovalStatus>? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalStatus? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListOrdersResponse? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderSummary>? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderSummary? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListProceduresResponseModel? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureListItemResponseModel>? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureListItemResponseModel? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListProductsParams? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseAgentBranchSummary? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentBranchSummary>? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseAgentDeploymentHistoryItem? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentDeploymentHistoryItem>? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListServicesParams? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListSpeechEnginesResponse? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechEngineSummaryResponse>? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineSummaryResponse? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListStaffParams? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTestsByIdsRequestModel? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTransferRulesParams? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListWhatsAppAccountsResponse? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LiteralJsonSchemaPropertyType? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LoadMemoryEntryToolErrorStatus? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LoadableMemoryEntry? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LocationResponse? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkingHours? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBLocationDeactivationReason? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LockReason? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovalPolicy? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovalPolicyUpdateRequestModel? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovedToolDefinition? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigInput? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolApprovalHash>? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalHash? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerTransport? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator>? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel>? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverrideInput>? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInput? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigOutput? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverrideOutput>? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutput? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigUpdateRequestModel? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerMetadataResponseModel? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerRequestModel? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModel? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem5>? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem5? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminator? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminatorType? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServersResponseModel? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPServerResponseModel>? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolAddApprovalRequestModel? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalPolicy? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalState? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInput? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant1? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminator? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutput? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant12? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminator? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ToolCallSoundType?, string>? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant13? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminator? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminatorSource? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant14? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminator? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModel? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant15? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModel? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant16? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPTransport? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualSource? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualVerificationFileResponseModel? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ManualVerificationFileResponseModel>? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MatchAnythingParameterEvaluationStrategy? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationCompletedResponse? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationCreateResponse? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationFailedResponse? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationFailedResponseFailureReason? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationInProgressResponse? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationInProgressResponseStatus? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationListResponse? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MediaGenerationResponse>? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponse? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponseDiscriminator? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MemoryEntrySearchResult? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource>? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeAgentConversationTicketsRequestModel? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModel? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem3>? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem3? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminator? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminatorProvider? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.FieldConflict>? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReviewReviewerRole? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalStatus? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessageSearchSortBy? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessagesSearchResponse? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MessagesSearchResult>? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessagesSearchResult? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetricType? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetronomeUsageColumnFilterColumn? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetronomeUsageColumnFilterOperation? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MockNoMatchBehavior? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MockingStrategy? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModelRatesResponseModel? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModelResponseModel? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguageResponseModel>? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationConfig? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ThresholdGuardrail? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModel? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModelSafetyStatus? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModelWarningStatus? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MultichannelSpeechToTextResponseModel? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextChunkResponseModel>? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModel? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MultipartMusicResponse? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicAllowedOutputFormats? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicOnlyOutputFormats? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicExploreSongSourceContext? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneFailureReason? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetunePageResponseModel? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MusicFinetuneResponseModel>? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneResponseModel? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneStatus? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicOutputFormat? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SongSection>? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongSection? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicUploadResponse? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NonStreamingOutputFormats? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumericDistributionAggregate? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumericUniformScoring? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseAlgorithm? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseTokenResponseField? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelAttribute? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, bool?, double?>? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelResource? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelAttribute>? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelResourceSpans? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelScopeSpans>? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelScopeSpans? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelScope? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelSpan>? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelSpan? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelStatus? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelTracePayload? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelResourceSpans>? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyInputPropertyKind? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequiredConstraints? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ContentSchema>? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioConfigInput? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputConfigInput? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputConfigInput? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioConfigOutput? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputConfigOutput? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputConfigOutput? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputFormat? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputTranscription? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAITurnDetection? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputFormat? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIFunctionTool? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIMCPTool? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIMCPToolRequireApproval? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeModel? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem3>? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem3? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInputToolDiscriminator? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInputToolDiscriminatorType? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.OpenAIToolChoiceFunction>? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIToolChoiceFunction? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.OpenAITurnDetection, string>? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<string, global::ElevenLabs.OpenAITracingConfiguration>? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAITracingConfiguration? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem4>? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem4? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminator? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminatorType? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIToolChoiceFunctionInner? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnDetectionType? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenerConfig? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OptInSmsReminderParams? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OptOutSmsReminderParams? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrbAvatar? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderDeliverablesResponse? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DeliverableInfo>? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderFulfillmentType? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemInfo? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutput? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QuoteInfo? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemKind? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInput? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubtitleOrderItemRequest? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptionOrderItemRequest? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInputDiscriminator? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInputDiscriminatorKind? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutputDiscriminator? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderMediaResponse? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderResponse? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderState? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderItemInfo>? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerGetClientAppointmentsParams? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListAssetsParams? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListLocationsParams? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListProductsParams? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListServicesParams? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListStaffParams? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PaginatedResultAgentMergeProposalResponse? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentMergeProposalResponse>? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguagePairInfo>? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchAgentConversationTicketRequestModel? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequest? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem2>? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChartsItem2? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminator? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAISettingsRequest? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConversationTagRequestModel? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchWorkspaceSecretRequest? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchWorkspaceWebhookResponseModel? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingBlocksMetadataModel? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingClipTask? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingClipTaskType? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingExternalAudiosMetadataModel? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberSortBy? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransfer? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem>? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminator? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferDestination? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPUriTransferDestination? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPUriDynamicVariableTransferDestination? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminator? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminatorType? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferTypeEnum? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UUITransferConfig? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant1? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsStatic? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsDynamicVariable? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1Discriminator? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformCategory? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformCategoryUsage? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformLimits? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StoredUsagePlatformLimit? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.PlatformCategoryUsage>? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFToolConfig? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastBulletinModeData? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastConversationModeData? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastProjectResponseModel? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PositionInput? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PositionOutput? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostAgentAvatarResponseModel? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostAgentHoldAudioResponseModel? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostWorkspaceSecretRequest? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostWorkspaceSecretResponseModel? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PricingMode? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivateKeyJWTResponseAlgorithm? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureAtVersionResponseModel? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureDraftResponseModel? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcessingProgress? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaResponseModel? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaResponseModelStatus? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaType? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModel? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelTargetAudience? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelState? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelAccessLevel? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelFiction? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelSourceType? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.CaptionStyleModel>? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelAspectRatio? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioAgentSettingsModel? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionResponseModel? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryLocatorResponseModel? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVideoResponseModel? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModel? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectImageResponseModel? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVoiceResponseModel>? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVoiceResponseModel? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SourceContextVariant1? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongSourceContext? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SfxSourceContext? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectMutedTracksResponseModel? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelTargetAudience? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelState? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelAccessLevel? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelFiction? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelSourceType? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelAspectRatio? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotExtendedResponseModel? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotResponseModel? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotsResponseModel? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectSnapshotResponseModel>? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysis? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromotionTarget? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigInput? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLlmConfig? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminator? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem5>? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem5? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolConfigInput? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfig? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminator? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminatorType? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigOutput? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLlmConfig2? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem6>? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem6? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolConfigOutput? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminator? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigWorkflowOverrideInput? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride>? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item>? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsVariant1Item? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminator? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigWorkflowOverrideOutput? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item2>? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsVariant1Item2? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryRulesResponseModel? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceRequest? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceSubscription? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteRequest>? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteRequest? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceResponse? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSubscription? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteResult>? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteResult? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriod? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryParamsJsonSchemaInput? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryParamsJsonSchemaOutput? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexResponseModel? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexStatus? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexUsage? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexesResponseModel? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RAGDocumentIndexResponseModel>? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexBatchSuccessfulResponseModel? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexOverviewResponseModel? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel>? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexRequestModel? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagChunkMetadata? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RagChunkMetadata>? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RawBusinessInfo? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RawLocationInfo>? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RawLocationInfo? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RawItem? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReaderResourceResponseModel? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReaderResourceResponseModelResourceType? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupResponseModel? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupSharingSummary? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupSharingSummaryEveryoneRole? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupsResponseModel? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RealtimeConversationGroupResponseModel>? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReassignPhoneRequest? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RecordingResponseModel? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioClipLocator? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferencedToolCommonModel? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferencedToolCommonModelType? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegexParameterEvaluationStrategy? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioRegionId? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioEdgeLocation? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegisterForGroupSessionParams? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegisterMediaResponse? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RemoveOrderItemResponse? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RemoveVoiceFromUserVoiceCollectionResponseModel? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RenderStatus? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReplicateVoiceToIsolatedEnvironmentRequestModel? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReplicateVoiceToIsolatedEnvironmentResponseModel? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReportKnowledgeGapParams? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequestPVCManualVerificationResponseModel? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequiredConstraint? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RequiredConstraint>? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceDetail? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceStatus? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerInvoiceLine>? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceLine? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceLineKind? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceSummary? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoicesResponse? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerInvoiceSummary>? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerTierResponse? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBTierEconomics? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerUpcomingPayment? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerUpcomingPaymentsResponse? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerUpcomingPayment>? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceOnboardingResponse? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSubscriptionBillingPeriod? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSummary? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspacesResponse? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerWorkspaceSummary>? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoRole? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoAnonymousAccessLevelOverride? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoAccessSource? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceMetadataResponseModel? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ShareOptionResponseModel>? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ShareOptionResponseModel? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseConversationErrorType? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseFilter? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseUnitTestModel? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RestoreCalendarEventParams? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResubmitTestsRequestModel? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModelReviewStatus? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RunAgentTestsRequestModel? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SingleTestRunRequestModel>? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleTestRunRequestModel? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RunConversationEvaluationsRequest? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPLogMessageDirection? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkOutboundCallResponse? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAddOn? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAdjustProductStockRequest? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAgentInfoResponse? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAgentInfoResponseCurrency? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceNow? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAgentTarget? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAssetResourceDBModel? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBGroupMembership>? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBGroupMembership? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAssetScrapable? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBClientAccessConfig? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBConfirmServiceUpdateRequest? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBIntakeQuestion>? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBIntakeQuestion? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBServiceVariant>? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBServiceVariant? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBServiceKind? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ServiceLocationType? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBAddOn>? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBServicePromotion>? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBServicePromotion? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateAgentRuleRequest? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateAssetRequest? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateHolidayRequest? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateProcedureRequest? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateProductRequest? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderFulfillmentType>? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateServiceRequest? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateStaffRequest? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCreateTransferRuleRequest? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCustomerFacingAgent? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCustomerFacingAgentDeactivationReason? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBCustomerFacingAgentResponse? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBWidgetAppearance? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBIdentityVerificationConfig? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBNotificationChannel>? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBNotificationChannel? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBKnowledgeSourceDBModel? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBLocationInput? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBLocationOutput? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBLocationRequest? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBLocationRequestPatch? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBPhoneAssignmentDBModel? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBPhoneAssignmentDBModelProvider? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBPhoneAssignmentDeactivationReason? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBPhoneRegulatoryStatus? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBProcedureResponse? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBProductDBModel? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBProductScrapable? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBScrapingMode? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBServiceDBModel? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBServiceScrapable? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBStaffResourceDBModel? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBStaffScrapable? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBTeamInviteResponse? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBTeamMemberResponse? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchClientsParams? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendCustomEmailParams? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateClientParams? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateStaffParams? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAssetParams? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateServiceParams? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateProductParams? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderParams? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScheduleGroupSessionParams? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateGroupSessionSeatsParams? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateCalendarEventParams? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentRuleParams? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTransferRuleParams? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentProcedureParams? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateHolidayParams? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitBusinessInfoParams? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBusinessInfoParams? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentConfigParams? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBookingPageSettingsParams? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBookingPageAppearanceParams? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SetBookingSlugParams? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateLocationParams? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerUserVerificationParams? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ValidateUserVerificationCodeParams? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfigParamsDiscriminator? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateAgentInfoRequest? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateAgentInfoRequestCurrency? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateAgentRuleRequest? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateAssetRequestPatch? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateCustomerFacingAgentRequest? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateHolidayRequestPatch? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateProcedureRequest? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateProductRequestPatch? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateProductStockRequest? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateServiceRequestPatch? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateStaffRequestPatch? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBUpdateTransferRuleRequest? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBWidgetAppearanceVariant? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBWidgetAppearancePlacement? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMSConversationInfoDirection? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyCommonModelInput? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyEvaluation? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyCommonModelOutput? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SafetyRule>? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyRule? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleConfigDBModelParentType? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleResponseModel? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSeparationResponseModel? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodeLiteralMessageInput? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TranslatedString>? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranslatedString? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodeLiteralMessageOutput? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodePromptMessageInput? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodePromptMessageOutput? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScimGroupResponseModel? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecretDependencyResourceType? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SectionSource? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TimeRange>? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentCreatePayload? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentCreateResponse? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentDeleteResponse? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentDubResponse? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentMigrationResponse? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentTranscriptionResponse? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentTranslationResponse? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentUpdatePayload? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentUpdateResponse? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ServiceUpdateResponse? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SetConversationGroupRequestModel? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ShareOptionResponseModelType? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimilarVoice? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceCategory? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimilarVoicesForSpeakerResponse? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SimilarVoice>? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationLibrarySettings? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationTestModel? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleUseTokenResponseModel? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleUseTokenType? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SkipTurnToolConfig? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SmbSipMediaEncryption? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SmbSipTransport? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SmsTemplateStyle? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfig? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigOverride? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigOverrideConfig? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigWorkflowOverride? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SortDirection? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerAudioResponseModel? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerCreatedResponse? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerResponseModel? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UtteranceResponseModel>? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UtteranceResponseModel? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbedSegment>? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSeparationResponseModelStatus? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerResponseModel>? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerUpdatedResponse? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineResponse? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelVoiceCategory? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelState? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelSource? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInputResponseModel>? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextCharacterResponseModel? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextWordResponseModel>? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWordResponseModel? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AdditionalFormatResponseModel?>? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DetectedEntity>? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditedTranscriptVariant1? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptEditError? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1Discriminator? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWebhookResponseModel? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWordResponseModelType? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextCharacterResponseModel>? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartPVCVoiceTrainingResponseModel? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolConfig? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolErrorStatus? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartSpeakerSeparationResponseModel? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamingAudioChunkWithTimestampsResponseModel? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.StudioAgentToolSettingsModel>? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioAgentToolSettingsModel? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioClipLocatorClipType? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitOrderResponse? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionExtrasResponseModel? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionUsageResponseModel? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionResponseModel? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SuggestedAudioTag? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SupportedVoice? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSModelFamily? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemEvaluationCriteria? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params2? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolConfigInput? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberToolConfigInput? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicemailDetectionToolConfig? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInputParamsDiscriminator? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params3? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolConfigOutput? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberToolConfigOutput? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutputParamsDiscriminator? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalModel? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SupportedVoice>? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SuggestedAudioTag>? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSOutputFormat? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextNormalisationType? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteOutcome? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteRequestRole? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionConfig? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateArrayOutput? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunStatus? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateArrayOutputFailureReason? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateOutput>? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutput? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateAudioOutput? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateAudioOutputFailureReason? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateBooleanOutput? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateBooleanOutputFailureReason? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateImageOutput? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateImageOutputFailureReason? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReference? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceReference? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReferenceDiscriminator? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReferenceDiscriminatorType? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateIntegerOutput? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateIntegerOutputFailureReason? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateListResponse? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateSummary>? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateSummary? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateNumberOutput? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateNumberOutputFailureReason? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateObjectOutput? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateObjectOutputFailureReason? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateOutput>? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVideoOutput? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateStringOutput? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutputDiscriminator? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutputDiscriminatorType? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplatePort? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunCreateRequest? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateRunInput>? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunInput? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunListResponse? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunResponse>? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunResponse? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateStringOutputFailureReason? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateVersion>? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVersion? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplatePort>? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVideoOutputFailureReason? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestConditionRationaleCommonModel? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestConditionResultCommonModel? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunMetadata? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunMetadataTestType? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunResultBucket? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunStatus? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestRunResultBucket>? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestSharingMode? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestType? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequest? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequestDiscriminator? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketMergeProposalLinkResponseModel? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSearchMatchField? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TokenResponseModel? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecution? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Icon>? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolAnnotations? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallUnitTestModel? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionTaskSupport? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallDetailsVariant1? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1Discriminator? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModel? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolConfig? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModelToolConfigDiscriminator? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestToolCallParameter>? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameter? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModel? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolConfig2? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModelToolConfigDiscriminator? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolUsageStatsResponseModel? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolSortBy? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolTypeFilter? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsResponseModel? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseModel>? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicEvaluationCriteriaAggregate? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicSentimentAggregate? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TopicEvaluationCriteriaAggregate>? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicSortBy? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoConfigured? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoDefaultingToMain? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoTrafficSplit? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTransferInput>? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTransferOutput>? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchInfoVariant1? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1Discriminator? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchInfoVariant12? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1Discriminator? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumberTransfer>? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioAnsweredBy? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionAction? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionMode? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TwilioMachineDetectionRule>? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionRule? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TwilioAnsweredBy>? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioOutboundCallResponse? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.URLAvatar? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestGuardrailTriggerEvaluationModel? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestInfoVariant1? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1Discriminator? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestWorkflowNodeTransitionEvaluationNodeId? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Eval? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminator? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsRequestModel? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemAttachmentDestination>? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModel? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResultsItem>? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultsItem? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminator? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBasicAuthRequest? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBearerAuthRequest? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateEnvironmentVariableRequest? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMusicFinetuneRequestModel? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMusicFinetuneRequestModelVisibility? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2ClientCredsRequest? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequest? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderResponse? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRequest? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateProcedureDraftRequestModel? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateRealtimeConversationGroupRequestModel? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateResponseUnitTestRequest? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateSimulationTestRequest? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateSpeechEngineRequest? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTestSuiteInvocationRequestModel? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateToolCallUnitTestRequest? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateWhatsAppAccountRequest? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateWorkspaceMemberResponseModel? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpsertOrderItemResponse? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsageAggregationInterval? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsageCharactersResponseModel? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserDataCollectionAnalysisItemInput? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Scoring? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminator? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminatorMode? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserResponseModel? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserVoiceCollectionResponseModelPermissionOnResource? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsersSortBy? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?>? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequest? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequestAspectRatio? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequestResolution? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VeoImageReference>? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VeoImageReference? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31Request? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31RequestAspectRatio? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31RequestResolution? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VeoImageReferenceRole? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerifyPVCVoiceCaptchaResponseModel? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysisStatus? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysisResult? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoSubject>? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSubject? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoSegment>? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSegment? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoKeyMoment>? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoKeyMoment? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequest? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequestDiscriminator? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReferenceDiscriminator? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReferenceDiscriminatorType? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceDesignRequestModel? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceDesignRequestModelModelId? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewResponseModel? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewsRequestModel? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewsResponseModel? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoicePreviewResponseModel>? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceRemixRequestModel? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SampleResponseModel>? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelCategory? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModel? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelSafetyControl? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceVerificationResponseModel? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelRecordingQuality? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelLabellingStatus? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSamplePreviewResponseModel? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSampleVisualWaveformResponseModel? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingModerationCheckResponseModel? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelStatus? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelCategory? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelReviewStatus? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReaderResourceResponseModel>? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookAuthMethodType? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookHttpMethod? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetAll? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetIds? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetDiscriminator? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetDiscriminatorType? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInput? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInputContentType? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutput? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutputContentType? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookUsageType? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppCallPermissionRequest? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppCallPermissionRequestState? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppConversationInfoDirection? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppRecipient? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOpeningMessage? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOutboundCallResponse? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOutboundMessageResponse? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateTextParam>? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateTextParam? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateDocumentParam? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateDocumentParamDetails? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ParametersItem>? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ParametersItem? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateImageParam? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateLocationParam? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminator? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateImageParamDetails? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateLocationParamDetails? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetPlacement? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetExpandable? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetFeedbackMode? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetEndFeedbackConfig? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigInputSyntaxHighlightTheme? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTextContents? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetStyles? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WidgetLanguagePreset>? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetLanguagePreset? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigOutputSyntaxHighlightTheme? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigResponseModelSyntaxHighlightTheme? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WidgetLanguagePresetResponse>? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetLanguagePresetResponse? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetEndFeedbackType? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTextContentsTranslation? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTermsTranslation? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForwardConditionVariant1? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUnconditionalModelInput? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowLLMConditionModelInput? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowResultConditionModelInput? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowExpressionConditionModelInput? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1Discriminator? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackwardConditionVariant1? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PositionInput>? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForwardConditionVariant12? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUnconditionalModelOutput? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowLLMConditionModelOutput? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowResultConditionModelOutput? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowExpressionConditionModelOutput? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackwardConditionVariant12? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1Discriminator? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PositionOutput>? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeOutcome? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem2>? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem2? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminator? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination2? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminator? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant12? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1Discriminator? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem3>? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem3? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination3? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminator? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant13? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolEdgeStepModel? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocator? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SchemaOverridesVariant12? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminator? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminatorSource? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNestedToolsStepModelInput? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkflowToolLocator>? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem>? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StepsItem? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminator? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem2>? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StepsItem2? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminator? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>>? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>>? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ColumnUnit?>? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceApiKeyListResponseModel? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceApiKeyResponseModel>? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceApiKeyResponseModel? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAuditLogEntryResponse? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAuditLogsPageResponse? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAuditLogEntryResponse>? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceBatchCallsResponse? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BatchCallResponse>? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateApiKeyResponseModel? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateServiceAccountResponseModel? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateWebhookResponseModel? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupByNameResponseModel? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupPermission? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupPermission>? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceMemberResponseModel? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceServiceAccountListResponseModel? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceServiceAccountResponseModel>? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceServiceAccountResponseModel? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupResponseModel>? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookListResponseModel? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookResponseModel>? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookResponseModel? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookUsageResponseModel? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationNode? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateOAuth2ClientCredsRequest, global::ElevenLabs.UpdateBasicAuthRequest, global::ElevenLabs.UpdateBearerAuthRequest, global::ElevenLabs.UpdateOAuth2JWTRequest>? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateExotelPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UserEvaluationAnalysisItem, global::ElevenLabs.UserDataCollectionAnalysisItemInput>? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequest? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminator? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistorySortDirection? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistorySource? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechFullOutputFormat? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechStreamOutputFormat? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToSpeechFullOutputFormat? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToSpeechStreamOutputFormat? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectListSortDirection? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingStatus? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingStatusesVariant1Item? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingModelsVariant1Item? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsCreationSourcesVariant1Item? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsFilterByCreator? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsOrderBy? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsOrderDirection? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDubbedTranscriptFileFormatType? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDubbingTranscriptsFormatType? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionariesMetadataSort? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestType>? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListChatResponseTestsRouteSortMode? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoriesRouteSummaryMode? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item>? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GuardrailType>? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoryRouteFormat? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item>? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketSource>? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketPriority>? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolTypeFilter>? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListEnvironmentVariablesType? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerateOutputFormat? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComposeDetailedOutputFormat? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComposeDetailedStreamOutputFormat? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamComposeOutputFormat? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetFinetunesSort? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetFinetunesSortDirection? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderState>? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListVideoGenerationsStatus? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListImageGenerationsStatus? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTextToSpeechGenerationsStatus? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DownloadSpeechHistoryItemsResponse? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DubbingTranscriptResponseModel, string>? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ModelResponseModel>? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponse? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponseDiscriminator? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponse? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponseDiscriminator? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkspaceGroupResponseModel>? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupByNameResponseModel>? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceMemberResponseModel>? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponse2? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminator? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminatorStatus? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponse? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminator? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponse? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminator? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AssignableUserResponseModel>? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItem? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminator? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponse? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminator? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminatorProvider? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponse? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminator? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminatorProvider? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponse2? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponse? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponseDiscriminator? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponse? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminator? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponse? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminator? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminatorType? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponse2? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminator? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponse? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminator? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponse2? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminator? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBServiceDBModel>? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBAssetResourceDBModel>? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBProductDBModel>? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBStaffResourceDBModel>? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBCustomerFacingAgentResponse>? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBProcedureResponse>? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBPhoneAssignmentDBModel>? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.HolidayResponseModel>? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LocationResponse>? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBKnowledgeSourceDBModel>? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerTierResponse>? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBTeamMemberResponse>? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBTeamInviteResponse>? Type2910 { get; set; }

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
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MergeProposalReview>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MergeProposalComment>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AttachedTestModel>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResourceAccessInfo>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemVersionResponseModel>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemResponseModel>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableAssignment>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AssetResponse>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioSegment>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioKeyMoment>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioEffectsFilterPresetResponseModel>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioEffectsEnvironmentResponseModel>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceSegment>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.McpServersItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentIntegrationConnectionIdentifier>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AllowlistItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Llm>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OutboundCallRecipientResponseModel>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetOrCreateRAGIndexRequestModel>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MetronomeUsageColumnFilter>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ColumnFilter>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateParamsItem>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PromptEvaluationCriteria>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OutboundCallRecipient>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DialogueInput>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookEventType>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>, string>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupConfig>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ImageReference>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoReference>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioReference>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockInputModel>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockResponseModel>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CharacterAlignmentModel>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterSnapshotResponseModel>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceStatisticsResponseModel>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>?>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ProcedureValidationError>>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProcedureValidationError>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.List<object>, object>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem2>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.McpServersItem2>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SecretDependencyType>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WebhookEventType>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ClientEvent>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DataCollectionResultCommonModel>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ScopedAnalysisResult>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceRewardModel>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConfigEntityType>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableUpdateCommonModel>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationReasoningModel>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TriggeredGuardrailCommonModel>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigOutput>>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigOutput>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceUsageModel>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.FrustratedConversationRef>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TurnCommentRequestModel>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentSuccessfulResponseExample>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentFailureResponseExample>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigInput>>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigInput>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomGuardrailConfig>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentRule>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBTransferRule>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBProcedure>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DataCollectionValueSchemaType?, global::System.Collections.Generic.List<string>>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WordTimestamp>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReadMetadataChapterDBModel>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Contributor>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SegmentSubtitleFrame>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptSegment>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTargetTranscriptSegment>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingLanguageResponse>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoicesNotPermittedWarning>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingMetadataResponse>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingProjectResponse>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptUtterance>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptWord>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptCharacter>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocator>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EnvironmentVariableResponse>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EnvironmentResponse>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModel>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VerificationAttemptResponseModel>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentWordResponseModel>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketResponseModel>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetWhatsAppAccountResponse>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTopicResponseModel>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentSummaryResponseModel>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem2>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentBranchInfo>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioIsolationHistoryItemResponseModel>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterResponseModel>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VisitedAgentRef>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationSummaryMessageModel>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationTagResponseModel>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationUserResponseModel>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationSummaryResponseModel>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem3>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DocumentUsageModeEnum>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DocumentsItem>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem2>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem3>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem4>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LibraryVoiceResponseModel>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MediaCodec>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem2>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectResponseModel>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SIPLogMessage>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechHistoryItemResponseModel>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestInvocationSummaryResponseModel>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestRunResultSummary>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestRunResponseModel>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestSummaryResponseModel>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem4>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolExecutionResponseModel>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UserVoiceCollectionResponseModel>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceAccentResponseModel>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceResponseModel>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TimeRangeModel>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ImageSubject>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AlertingWebhookHeader>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DiscountResponseModel>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseContentSearchResult>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SearchHighlightSegment>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseRagChunkModel>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SearchStrategy>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMObjectJsonSchemaPropertyInput>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMReasoningEffort>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMServiceTier>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMInfoModel>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?, global::System.Collections.Generic.List<string>>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguageInfo>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AuthConnectionsItem>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetCrawlJobResponseModel>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Tool>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolApprovalStatus>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderSummary>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProcedureListItemResponseModel>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentBranchSummary>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentDeploymentHistoryItem>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechEngineSummaryResponse>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.List<string>>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolApprovalHash>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverrideInput>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverrideOutput>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem5>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPServerResponseModel>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ManualVerificationFileResponseModel>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MediaGenerationResponse>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem3>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.FieldConflict>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MessagesSearchResult>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguageResponseModel>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextChunkResponseModel>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MusicFinetuneResponseModel>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SongSection>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelAttribute>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelScopeSpans>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelSpan>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelResourceSpans>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem3>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem4>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DeliverableInfo>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderItemInfo>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentMergeProposalResponse>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguagePairInfo>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem2>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectVoiceResponseModel>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectSnapshotResponseModel>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseLocator>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem5>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem6>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsVariant1Item>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsVariant1Item2>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TeamInviteRequest>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TeamInviteResult>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RAGDocumentIndexResponseModel>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RagChunkMetadata>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RawLocationInfo>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RealtimeConversationGroupResponseModel>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RequiredConstraint>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerInvoiceLine>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerInvoiceSummary>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerUpcomingPayment>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerWorkspaceSummary>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ShareOptionResponseModel>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SingleTestRunRequestModel>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBGroupMembership>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBIntakeQuestion>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBServiceVariant>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBAddOn>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBServicePromotion>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderFulfillmentType>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBNotificationChannel>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SafetyRule>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TimeRange>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SimilarVoice>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UtteranceResponseModel>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DialogueInputResponseModel>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextWordResponseModel>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AdditionalFormatResponseModel?>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DetectedEntity>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextCharacterResponseModel>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SupportedVoice>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SuggestedAudioTag>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateOutput>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateSummary>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateRunInput>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateRunResponse>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateVersion>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplatePort>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestRunResultBucket>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Icon>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestToolCallParameter>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseModel>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TopicEvaluationCriteriaAggregate>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTransferInput>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTransferOutput>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumberTransfer>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TwilioMachineDetectionRule>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TwilioAnsweredBy>? ListType294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemAttachmentDestination>? ListType295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResultsItem>? ListType296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<double>>? ListType297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>? ListType298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VeoImageReference>? ListType299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoSubject>? ListType300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoSegment>? ListType301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoKeyMoment>? ListType302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoicePreviewResponseModel>? ListType303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SampleResponseModel>? ListType304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReaderResourceResponseModel>? ListType305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WhatsAppTemplateTextParam>? ListType306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ParametersItem>? ListType307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PositionInput>? ListType308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PositionOutput>? ListType309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem2>? ListType310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem3>? ListType311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkflowToolLocator>? ListType312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.StepsItem>? ListType313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.StepsItem2>? ListType314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.TimeRangeModel>>? ListType315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>? ListType316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>>? ListType317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>? ListType318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ColumnUnit?>? ListType319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceApiKeyResponseModel>? ListType320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAuditLogEntryResponse>? ListType321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BatchCallResponse>? ListType322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupPermission>? ListType323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceServiceAccountResponseModel>? ListType324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupResponseModel>? ListType325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookResponseModel>? ListType326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>? ListType327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? ListType328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? ListType329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? ListType330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestType>? ListType331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item>? ListType332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GuardrailType>? ListType333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item>? ListType334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketSource>? ListType335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketPriority>? ListType336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentType>? ListType337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolTypeFilter>? ListType338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderState>? ListType339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ModelResponseModel>? ListType340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupByNameResponseModel>? ListType341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceMemberResponseModel>? ListType342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AssignableUserResponseModel>? ListType343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>? ListType344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBServiceDBModel>? ListType345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBAssetResourceDBModel>? ListType346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBProductDBModel>? ListType347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBStaffResourceDBModel>? ListType348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBCustomerFacingAgentResponse>? ListType349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBProcedureResponse>? ListType350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBPhoneAssignmentDBModel>? ListType351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.HolidayResponseModel>? ListType352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LocationResponse>? ListType353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBKnowledgeSourceDBModel>? ListType354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerTierResponse>? ListType355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBTeamMemberResponse>? ListType356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SMBTeamInviteResponse>? ListType357 { get; set; }
    }
}