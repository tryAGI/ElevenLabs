
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
        public global::ElevenLabs.AddVoiceIVCResponseModel? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceMatchResponseModel? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddVoiceResponseModel? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddVoiceToUserVoiceCollectionResponseModel? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddWorkspaceGroupMemberResponseModel? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddWorkspaceInviteResponseModel? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AdditionalFormatResponseModel? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ExportOptions>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptions? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelInput? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentPlatformSettingsRequestModel? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModel? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInput? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EvaluationCriteriaItem>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationCriteriaItem? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedUserEvaluationRef? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedSystemEvaluationRef? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminator? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionItem>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionItem? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedUserDataCollectionRef? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedSystemDataCollectionRef? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminator? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutput? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EvaluationCriteriaItem2>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationCriteriaItem2? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminator? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionItem2>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionItem2? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputDataCollectionItemDiscriminator? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentBan? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BanReasonType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentBranchBasicInfo? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentBranchResponse? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchProtectionStatus? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfo? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentVersionMetadata>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentVersionMetadata? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentBranchSummary? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentCallLimits? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelInput? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariablesConfig? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.BehaviorOverride>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BehaviorOverride? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInput? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelOutput? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutput? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelWorkflowOverrideInput? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariablesConfigWorkflowOverride? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInput? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelWorkflowOverrideOutput? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutput? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigOverrideInput? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOverrideInput? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigOverrideOutput? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOverrideOutput? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigOverrideConfig? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOverrideConfig? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketIssueType? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketPriority? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketResponseModel? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketCommentResponseModel>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketCommentResponseModel? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentResponseModel>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnCommentResponseModel? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketStatus? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriorityChangeResponseModel>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketPriorityChangeResponseModel? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatusChangeResponseModel>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketStatusChangeResponseModel? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketSource? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSearchMatchResponseModel? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketSortBy? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDefinitionSource? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentHistoryItem? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentSource? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentPercentageStrategy? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentRequest? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentDeploymentRequestItem>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentRequestItem? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentResponse? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentFailureResponseExample? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentHoldAudioConfig? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentFormat? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagQueryRequestModel? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagQueryResponseModel? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponse? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalReview>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReview? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalComment>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalComment? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Outcome? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenOutcome? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergedOutcome? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClosedOutcome? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminator? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadata? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadataDBModel? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadataResponseModel? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSettingsInput? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigInput? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisProperty>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisProperty? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisScope>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisScope? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataConfigInput? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkspaceOverridesInput? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestingSettings? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsV1Input? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthSettings? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentQueueingConfig? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivacyConfigInput? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTrustContext? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Llm? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicDiscoverySettings? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SentimentAnalysisSettings? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSettings? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentPlatformSettingsResponseModel? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSettingsOutput? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigOutput? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataConfigOutput? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkspaceOverridesOutput? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsV1Output? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivacyConfigOutput? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSettingsResponse? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyResponseModel? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSMBMetadata? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAgentType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSimulatedChatTestResponseModel? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptResponseModel? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryAnalysisCommonModel? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSortBy? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSuccessfulResponseExample? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSummaryBatchSuccessfulResponseModel? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSummaryResponseModel? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestEntityType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestFolderPathSegmentResponseModel? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AttachedTestModel>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedTestModel? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTopicResponseModel? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicMetricsAggregate? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferInput? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOutput? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOp? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpReplace? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpPush? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpPop? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpDiscriminator? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOpDiscriminatorType? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentVersionParents? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResourceAccessInfo>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelInput>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInput? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Nodes? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartNodeModelInput? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeModelInput? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInput? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelInput? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNodeModelInput? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminator? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModel? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelOutput>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutput? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Nodes2? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartNodeModelOutput? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeModelOutput? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNodeModelOutput? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminator? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataWebhook? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIWebhooks? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingMonitorConfig? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingPagerDutyNotifier? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingPagerDutyNotifierResponse? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AlertingMonitorConfig>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookNotifier? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSlackNotifier? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookNotifierResponse? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSlackNotifierResponse? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookHeader? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookMethod? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookSecretHeaderValue? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowedOutputFormats? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowedValues? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowlistItem? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisCharging? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisRunningTotal? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisRunSnapshot? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentAction? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentDestination? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentResultData? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemKind? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModel? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Definition? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItem? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserDataCollectionAnalysisItemOutput? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModelDefinitionDiscriminator? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModelDefinitionDiscriminatorKind? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemSource? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModel? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Definition2? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminator? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminatorKind? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionsResponseModel? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemVersionResponseModel>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemsResponseModel? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemResponseModel>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisPropertyType? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependencies? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionStatus? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverrides? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SchemaOverridesVariant1? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConstantSchemaOverride? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableSchemaOverride? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMSchemaOverride? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OmitSchemaOverride? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminator? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseFilterMode? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAIDynamicVariable>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIDynamicVariable? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigInput? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolInterruptionMode? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PreToolSpeechMode? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableAssignment? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallSoundType? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallSoundBehavior? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolErrorHandlingMode? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionMode? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArchitectDispatchResponseModel? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyInput? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyInput, global::ElevenLabs.ArrayJsonSchemaPropertyInput>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LiteralJsonSchemaProperty? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyInput? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyOutput? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyOutput? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArraySchema? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchema? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetListResponse? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AssetResponse>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetResponse? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscription? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscriptionStatus? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscriptionData? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignConversationTagsRequestModel? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignableUserResponseModel? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadata? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadataDeliveryStatus? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemDataCollectionId? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemEvaluationId? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysis? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysisStatus? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysisResult? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioSegment>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioSegment? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioKeyMoment>? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioKeyMoment? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsCatalogResponseModel? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsFilterPresetResponseModel>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsFilterPresetResponseModel? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsEnvironmentResponseModel>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsEnvironmentResponseModel? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioFormat? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioInputPacing? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioIsolationHistoryItemResponseModel? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeCreateProjectResponseModel? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeEditContentResponseModel? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeProjectSettingsResponseModel? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioRefChunk? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeRange? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReference? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationReference? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StaticAssetReference? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineAudioReference? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReferenceDiscriminator? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReferenceDiscriminatorType? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioSchema? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioWithTimestampsAndVoiceSegmentsResponseModel? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAlignmentResponseModel? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceSegment>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSegment? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioWithTimestampsResponseModel? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableToolIdentifier? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownToolIdentifier? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesToolDiscriminator? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.McpServersItem? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableMCPServerIdentifier? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownMCPServerIdentifier? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminator? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentIntegrationConnectionIdentifier>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentIntegrationConnectionIdentifier? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionLocator? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AllowlistItem>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthorizationMethod? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoGenerationMetadata? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoSyncInfo? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AvatarContextResponseModel? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundConfig? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundSourceType? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundPresetId? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundConfigWorkflowOverride? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMDefault? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMDisabled? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMOverride? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Llm>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BaseTurnConfig? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnMode? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnEagerness? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpellingPatience? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnModel? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BasicAuthResponse? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallDetailedResponse? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyProvider? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallWhatsAppParams? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallStatus? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyCallConfigOutput? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipientResponseModel>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundCallRecipientResponseModel? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallRecipientStatus? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallResponse? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallingCampaignInformation? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignConversationType? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchFailureResponseModel? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchSuccessResponseModelAnalysisItemAttachmentResultData? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BearerAuthResponse? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Verbosity? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutputFormat? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InteractionBudget? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BillingPeriod? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BinaryScoring? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddSamplesToPvcVoiceV1VoicesPvcVoiceIdSamplesPost? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddVoiceV1VoicesAddPost? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPost? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPost? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkDeleteKnowledgeBaseDocumentsV1ConvaiKnowledgeBaseBulkDeletePost? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkMoveTestsToFolderV1ConvaiAgentTestingBulkMovePost? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCommentOnAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdCommentsPost? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPost? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicGenerationMode? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicPrompt? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompositionPlan? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicModelID? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicV1MusicPost? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetOrCreateRAGIndexRequestModel>? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRAGIndexRequestModel? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentV1ConvaiAgentsCreatePost? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSettings? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPost? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePvcVoiceV1VoicesPvcPost? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPost? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QualityPresetType? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateUrlDocumentV1ConvaiKnowledgeBaseUrlPost? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoicePost? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentTestFolderV1ConvaiAgentTestingFoldersPost? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateChapterV1StudioProjectsProjectIdChaptersPost? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateCrawlJobV1ConvaiKnowledgeBaseCrawlPost? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateForcedAlignmentV1ForcedAlignmentPost? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPost? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastConversationMode? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastBulletinMode? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastTextSource? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastURLSource? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateVoiceCollectionV1VoicesCollectionsPost? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookHMACSettings? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDeleteExistingInvitationV1WorkspaceInvitesDelete? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDownloadHistoryItemsV1HistoryDownloadPost? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPost? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditPvcVoiceV1VoicesPvcVoiceIdPost? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPost? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnFilter? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetDependentAgentsForMultipleDocumentsV1ConvaiKnowledgeBaseDependentAgentsPost? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaExotelV1ConvaiExotelOutboundCallPost? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataRequestInput? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyCallConfigInput? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaSipTrunkV1ConvaiSipTrunkOutboundCallPost? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SeatType? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyInviteUserV1WorkspaceInvitesAddPost? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMergeAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdMergePost? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ProcedureVersionRef>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureVersionRef? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPostAgentHoldAudioV1ConvaiAgentsAgentIdHoldAudioPost? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRebaseABranchOntoMainV1ConvaiAgentsAgentIdBranchesBranchIdRebasePost? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyDirection? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRegisterMediaV1ProductionsOrdersOrderIdMediaPost? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RenderType? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyReviewAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdReviewsPost? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReviewState? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateParamsItem>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateParamsItem? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParams? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateBodyComponentParams? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateButtonComponentParams? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySetRulesOnThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdSetRulesPost? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySetWorkspaceThirdPartyDisablingPolicyV1WorkspacesApiKeysThirdPartyDisablingPost? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceResourceType? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSimulationSpecification? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PromptEvaluationCriteria>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptEvaluationCriteria? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySoundGenerationV1SoundGenerationPost? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SFXModelId? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, object>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPost? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamChapterAudioV1StudioProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamComposedMusicV1MusicStreamPost? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPost? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipient>? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundCallRecipient? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPost? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInput>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DialogueInput? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToDialogueSettingsResponseModel? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EffectsSpecInput? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePost? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTranslatesAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdTranslatePost? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdatePvcVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateStudioProjectV1StudioProjectsProjectIdPost? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdPatch? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAgentTestFolderV1ConvaiAgentTestingFoldersFolderIdPatch? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentInputModel? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateFileDocumentV1ConvaiKnowledgeBaseDocumentationIdUpdateFilePatch? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPost? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateOrderV1ProductionsOrdersOrderIdPatch? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderRequest? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateVoiceCollectionV1VoicesCollectionsCollectionIdPatch? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookEventType>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookEventType? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadAssetV1AssetsPost? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadFileV1ConvaiConversationsConversationIdFilesPost? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadMusicV1MusicUploadPost? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<bool?, global::ElevenLabs.MusicModelID?>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpsertOrderItemV1ProductionsOrdersOrderIdItemsPost? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpsertOrderItemRequest? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVerifyPvcVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVideoToMusicV1MusicVideoToMusicPost? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPost? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerV1VoiceChangerVoiceIdPost? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PermissionType? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateServiceAccountV1ServiceAccountsPost? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupConfig>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupConfig? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<bool?, string>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchExpiresAtUnix?>? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchExpiresAtUnix? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueFullWithTimestamps? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueStreamWithTimestamps? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFull? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSettingsResponseModel? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullWithTimestamps? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStream? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamWithTimestamps? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BooleanSchema? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BreakdownTypes? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BucketingStatus? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsInput? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInput? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsOutput? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutput? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsWorkflowOverrideInput? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsWorkflowOverrideOutput? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25Request? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTarget? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25RequestAspectRatio? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25RequestResolution? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReference? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoReference>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReference? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioReference>? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequest? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequestResolution? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequest? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequestResolution? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2Request? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2RequestAspectRatio? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2RequestResolution? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequest? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequestResolution? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequest? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequestResolution? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallResult? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelCalendarEventParams? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelGroupSessionForAllParams? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelGroupSessionRegistrationParams? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelOrderParams? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CanvasPlacement? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModel? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleHorizontalPlacementModel? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModel? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleTemplateModel? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextAlign? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextStyle? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextWeight? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextTransform? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextBlendMode? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioTextStyleShadowModel? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioTextStyleOutlineModel? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModel? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModel? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleVerticalPlacementModel? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModelEnterType? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModelExitType? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleVerticalPlacementModelAlign? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModelEnterType? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModelExitType? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockInputModel? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockInputModelSubType? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockResponseModel? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockInputModel>? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentResponseModel? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockResponseModel>? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterResponseModel? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterResponseModelState? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterStatisticsResponseModel? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotExtendedResponseModel? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CharacterAlignmentModel>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAlignmentModel? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotResponseModel? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotsResponseModel? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterSnapshotResponseModel>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceStatisticsResponseModel>? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceStatisticsResponseModel? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterWithContentResponseModelState? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAge? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterGender? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterMetadataResponseModel? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterRole? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterRefreshPeriod? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterResponseModel? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChatSourceMedium? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CheckServiceAvailabilityParams? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientEvent? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientSecretResponse? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutput? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolConfigInput? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolConfigOutput? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimation? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimationEnterEffect? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimationExitEffect? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalCloseReason? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnFilterOperation? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>?>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnUnit? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompactionSettingsWorkflowOverride? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompileProceduresResponseModel? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompileProceduresValidationErrorResponseModel? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureValidationError>>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureValidationError>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureValidationError? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkInput? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComputedUsagePlatformLimit? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConditionStrength? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConfigEntityType? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConflictSection? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.IList<object>, object>? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentConfig? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentThresholdGuardrail? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInput? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailExecutionMode? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallTriggerAction? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RetryTriggerAction? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminator? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutput? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction2? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminator? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StringSchema? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumberSchema? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntegerSchema? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageSchema? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSchema? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSchema? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectSchema? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchemaDiscriminator? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchemaDiscriminatorType? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentThresholdGuardrailThreshold? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContextualUpdateInfo? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Contributor? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIEnvVarLocator? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIFileUploadResponseModel? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAISecretLocator? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependencies? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem2>? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem2? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminator? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminatorType? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem>? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableAgentIdentifier? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownAgentIdentifier? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminator? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminatorType? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentPhoneNumberIdentifier? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem2>? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.McpServersItem2? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminator? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminatorType? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SecretDependencyType>? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecretDependencyType? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIUserSecretDBModel? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WebhookEventType>? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookEventType? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTranscriptFormat? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationASRUsageModel? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationChargingCommonModel? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMCategoryUsage? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformUsage? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTTSUsageModel? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigInput? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileInputConfig? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DTMFInputConfig? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOutput? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideInput? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigOverride? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOverride? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOverride? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideOutput? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideConfigInput? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigOverrideConfig? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOverrideConfig? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOverrideConfig? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideConfigOutput? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigWorkflowOverrideInput? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileInputConfigWorkflowOverride? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigWorkflowOverrideOutput? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationDeletionSettings? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationErrorType? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationFeedbackRequestModel? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserFeedbackScore? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationFeedbackType? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DataCollectionResultCommonModel>? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionResultCommonModel? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionResultCommonModel>? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSuccessResult? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ScopedAnalysisResult>? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScopedAnalysisResult? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryBatchCallModel? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryElevenAssistantCommonModel? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryErrorCommonModel? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CriteriaScoringMode? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryExotelPhoneCallModel? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryFeedbackCommonModel? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModel? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneCallVariant1? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1Discriminator? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryRagUsageCommonModel? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FeaturesUsageCommonModel? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationSource? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppConversationInfo? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMSConversationInfo? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceRewardModel>? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationVoiceRewardModel? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMultivoiceMessageModel? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryRedactionConfig? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConfigEntityType>? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableUpdateCommonModel>? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableUpdateCommonModel? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelInputRole? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserFeedback? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTurnMetrics? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagRetrievalInfo? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageInput? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptPlatformEvent? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationReasoningModel>? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationReasoningModel? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TriggeredGuardrailCommonModel>? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggeredGuardrailCommonModel? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutputRole? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageOutput? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel>? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultVariant1? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallToolResultModel? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageDetectionToolResultModel? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInput? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultErrorModel? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultSipSuccessModel? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultExotelSuccessModel? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultAmazonConnectSuccessModel? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultErrorModel? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SkipTurnToolResponseModel? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFResultSuccessModel? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFResultErrorModel? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceMailDetectionResultSuccessModel? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestToolResultModel? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolResultModel? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolResultModel? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolResultSuccessModel? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolResultErrorModel? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolResultSuccessModel? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolResultErrorModel? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DummyToolResultModel? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultVariant12? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutput? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolType? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolDetailsVariant1? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolDetailsVariant12? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1Discriminator? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInput? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutput? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataInternal? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationSourceInfo? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableInternalValueType? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrchestratorToolMockBehaviorConfig? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigOutput>>? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigOutput>? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseMockConfigOutput? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataRequestOutput? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator>? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationProduct? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSentimentAnalysis? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSentimentAnalysisOverallLabel? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSignedUrlResponseModel? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ToolMockConfig>? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolMockConfig? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSource? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryMessageModel? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryMessageModelRole? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryResponseModel? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryResponseModelStatus? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EvaluationCriteriaSummaryResult>? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationCriteriaSummaryResult? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceUsageModel>? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationVoiceUsageModel? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTagResponseModel? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTokenPurpose? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTokenResponseModel? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.MetricRecord>? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetricRecord? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationUserResponseModel? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SentimentAggregate? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.FrustratedConversationRef>? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FrustratedConversationRef? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfig? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigInput? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetInput>? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetInput? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VADConfig? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelOutput? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOutput? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetOutput>? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetOutput? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideInput? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigWorkflowOverride? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigWorkflowOverrideInput? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VADConfigWorkflowOverride? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideOutput? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigWorkflowOverrideOutput? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvertChapterResponseModel? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvertProjectResponseModel? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CrawlStatus? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CrawlType? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentBranchResponseModel? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentConversationTicketRequestModel? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentRequestModel>? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnCommentRequestModel? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentMergeProposalResponseModel? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentProcedureParams? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentResponseModel? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentRuleParams? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentTestFolderResponseModel? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentTestResponseModel? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAssetParams? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateBasicAuthRequest? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateBearerAuthRequest? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientAppointmentParams? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientInteractionParams? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientParams? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientSecretRequest? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInput? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExpiresAfter? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateConversationTagRequestModel? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateCrawlJobResponseModel? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateCustomHeaderAuthRequest? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentRequest? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateExotelPhoneNumberRequest? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelApiSubdomain? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateHolidayParams? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateLocationParams? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateMTLSAuthRequest? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateManualTicketRequestModel? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2ClientCredsRequest? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequest? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderParams? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderRequest? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderResponse? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePhoneNumberResponseModel? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePrivateKeyJWTRequest? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProcedureRequestModel? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureType? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProcedureResponseModel? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProductParams? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProductQuoteRequestParams? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePronunciationDictionaryResponseModel? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateRealtimeConversationGroupRequestModel? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateResponseUnitTestRequest? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestFromConversationMetadataInput? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentSuccessfulResponseExample>? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentFailureResponseExample>? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InboundSIPTrunkConfigRequestModel? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundSIPTrunkConfigRequestModel? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSecretEnvironmentVariableRequest? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest>? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableSecretValueRequest? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateServiceParams? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateServiceQuoteRequestParams? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSimulationTestRequest? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationToolMockBehaviorConfig? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>>? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseMockConfigInput? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSpeechEngineRequest? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineConfig? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineAuthConfig? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineConversationInitiationClientDataConfig? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateStaffParams? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateStringEnvironmentVariableRequest? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateToolCallUnitTestRequest? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallEvaluationModelInput? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTransferRuleParams? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTwilioPhoneNumberRequest? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegionConfigRequest? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatifyAuroraRequest? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatifyAuroraRequestResolution? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CueOptionsRequest? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Currency? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailInput? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailsConfigInput? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailOutput? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailsConfigOutput? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfig? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigModel? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction3? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminator? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomGuardrailConfig>? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomHeaderAuthResponse? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomLLM? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator>? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator>? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentAuthConnectionLocator? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomLLMAPIType? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSIPHeader? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardCallSuccessChartModel? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardCriteriaChartModel? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardDataCollectionChartModel? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionValueSchema? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DataCollectionValueSchemaType?, global::System.Collections.Generic.IList<string>>? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionValueSchemaType? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupResponseModel? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupResponseModel? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentHoldAudioResponseModel? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentProcedureParams? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentRuleParams? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAssetParams? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteCalendarEventParams? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteChapterResponseModel? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteClientInteractionParams? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteClientParams? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteDubbingResponseModel? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteGroupSessionParams? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteHistoryItemResponse? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteHolidayParams? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteLocationParams? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteProductParams? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteProjectResponseModel? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteSampleResponseModel? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteServiceParams? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteStaffParams? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteTransferRuleParams? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteUserVoiceCollectionResponseModel? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteVoiceResponseModel? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteVoiceSampleResponseModel? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceGroupMemberResponseModel? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceInviteResponseModel? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceWebhookResponseModel? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeliverableInfo? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableAgentIdentifierAccessLevel? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentBranchInfo? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DetailedMusicResponse? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongMetadata? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WordTimestamp>? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WordTimestamp? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DetectedEntity? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeviceModel? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DialogueInputResponseModel? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModel? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReadMetadataChapterDBModel>? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReadMetadataChapterDBModel? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReadLegalTerms? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Contributor>? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelPayoutType? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PreviewAudioDBModel? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleConfigDBModel? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModel? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DiscountResponseModel? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DoDubbingResponseModel? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocumentUsageModeEnum? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocxExportOptions? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubOrderItemRequest? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbedSegment? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SegmentSubtitleFrame>? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentSubtitleFrame? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMediaReference? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkSegmentUpdateRequest? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingSegmentUpdateRequest>? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSegmentUpdateRequest? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkSourceSegmentUpdateResponse? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptSegment>? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptSegment? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkTargetSegmentUpdateRequest? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingTargetSegmentUpdateRequest>? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetSegmentUpdateRequest? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkTargetSegmentUpdateResponse? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTargetTranscriptSegment>? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetTranscriptSegment? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingError? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageListResponse? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingLanguageResponse>? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageResponse? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageOutputs? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageResponseStatus? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoicesNotPermittedWarning>? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicesNotPermittedWarning? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMediaMetadata? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMetadataPageResponseModel? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingMetadataResponse>? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMetadataResponse? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectListResponse? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingProjectResponse>? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectResponse? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectResponseStatus? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceMediaInfo? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingRegenerateResponse? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingReleaseChannel? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingRenderResponseModel? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingResource? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerTrack>? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerTrack? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerSegment>? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSegment? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.Render>? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Render? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSegmentCreateRequest? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceSegmentUpdateResponse? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceTranscriptResponse? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetSegmentUpdateResponse? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetTranscriptResponse? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscript? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptUtterance>? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptUtterance? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptCharacter? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptResponseModel? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptRevisionResponse? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptWord>? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptWord? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptCharacter>? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptsResponseModel? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DuplicateSpeechEngineRequest? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Eagerness? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditChapterResponseModel? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditProjectResponseModel? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditVoiceResponseModel? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditVoiceSettingsResponseModel? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditedTranscript? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EffectsSpecOutput? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25Request? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25RequestOutputFormat? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocator>? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocator? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25VoiceSettings? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenMultilingualV2Request? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TtsVoiceSettings? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3Request? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3RequestOutputFormat? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3VoiceSettings? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EmbedVariant? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EmbeddingModelEnum? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallToolConfig? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolConfig? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ProcedureVersionRef, global::ElevenLabs.ProcedureDraftRef>? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureDraftRef? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolErrorStatus? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EntryBehavior? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentResponse? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableAuthConnectionValue? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableResponse? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableResponseType? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableSecretValue? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariablesListResponse? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentVariableResponse>? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentsListResponse? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentResponse>? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationResultFilter? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExactParameterEvaluationStrategy? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelOutboundCallResponse? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExperimentAssignment? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExperimentAssignmentSource? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentedJsonExportOptions? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PdfExportOptions? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TxtExportOptions? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HtmlExportOptions? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SrtExportOptions? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptionsDiscriminator? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptionsDiscriminatorFormat? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExtendedSubscriptionResponseModel? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, string>? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Price? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionStatusType? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModel? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModel>? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel>? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingSubscriptionSwitchResponseModel? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingCancellationResponseModel? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalFileSyncInfo? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncProvider? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalFolderSyncInfo? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncJobTrigger? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncJobType? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FeatureStatusCommonModel? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowFeaturesUsageCommonModel? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestsFeatureUsageCommonModel? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FieldConflict? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileRefreshStatus? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FineTuningResponseModel? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.FineTuningResponseModelState2>? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FineTuningResponseModelState2? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VerificationAttemptResponseModel>? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerificationAttemptResponseModel? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualVerificationResponseModel? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FinetuneCreatedBy? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FinetuneVisibility? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FocusGuardrail? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentCharacterResponseModel? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentResponseModel? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentWordResponseModel>? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentWordResponseModel? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FrustratedConversationRefOverallLabel? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1Request? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestQuality? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestBackground? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestAspectRatio? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15Request? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestQuality? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestBackground? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestAspectRatio? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequest? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestQuality? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestAspectRatio? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestResolution? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequest? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestQuality? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestAspectRatio? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestResolution? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2Request? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestQuality? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestAspectRatio? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestResolution? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini25FlashImageRequest? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini25FlashImageRequestAspectRatio? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequest? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequestAspectRatio? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequestResolution? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashLiteImageRequest? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequest? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequestAspectRatio? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequestResolution? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkInputContextAdherence? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkOutput? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkOutputContextAdherence? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationSourceContext? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferenceVideo? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenesysBotOutcome? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenesysRegion? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentConfigParams? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentConversationTicketsPageResponseModel? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketResponseModel>? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentEmbedResponseModel? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigResponseModel? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgebaseSizeResponseModel? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentLinkResponseModel? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModel? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem>? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberTwilioResponseModel? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberExotelResponseModel? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminator? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetWhatsAppAccountResponse>? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWhatsAppAccountResponse? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ProcedureRefResponseModel>? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureRefResponseModel? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentTestFolderResponseModel? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentTopicsResponseModel? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTopicResponseModel>? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentsPageResponseModel? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentSummaryResponseModel>? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModel? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem2>? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem2? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModelAgentDiscriminator? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorType? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentBranchInfo>? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalyticsSummaryParams? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAppointmentByConfirmationNumberParams? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAudioIsolationHistoryResponseModel? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioIsolationHistoryItemResponseModel>? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAudioNativeProjectSettingsResponseModel? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetBookingPageSettingsParams? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetBookingSlugStatusParams? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetChaptersResponseModel? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterResponseModel>? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientAppointmentsParams? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientByPhoneParams? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientOrdersParams? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModel? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem>? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChartsItem? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminator? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAISettingsResponseModel? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LivekitStackType? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationResponseModel? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationResponseModelStatus? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VisitedAgentRef>? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VisitedAgentRef? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationSummaryResponseModel? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationSummaryResponseModelStatus? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryMessageModel>? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationTagsPageResponseModel? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationTagResponseModel>? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationUsersPageResponseModel? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationUserResponseModel>? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationsPageResponseModel? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryResponseModel>? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetCrawlJobResponseModel? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModel? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem3>? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem3? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseFileResponseModel? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentMetadataResponseModel? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DocumentUsageModeEnum>? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KbExternalSyncJob? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModel? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DocumentsItem>? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocumentsItem? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminator? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem>? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminator? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem2>? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem2? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminator? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem3>? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem3? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminator? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem4>? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem4? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminator? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseTextResponseModel? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseURLResponseModel? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetLibraryVoicesResponseModel? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LibraryVoiceResponseModel>? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceResponseModel? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetLiveCountResponse? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrderByConfirmationNumberParams? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberAgentInfo? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberInboundSIPTrunkConfigResponseModel? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPMediaEncryptionEnum? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberOutboundSIPTrunkConfigResponseModel? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkTransportEnum? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MediaCodec>? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaCodec? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModel? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem2>? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem2? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminator? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetProjectsResponseModel? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectResponseModel>? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionariesMetadataResponseModel? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModel? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetResponseUnitTestResponseModel? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestFromConversationMetadataOutput? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSIPLogMessagesResponse? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SIPLogMessage>? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPLogMessage? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetScheduleParams? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModel? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependenciesVariant1Item? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminator? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependenciesVariant2Item? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminator? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSimulationTestResponseModel? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistoryResponseModel? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechHistoryItemResponseModel>? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModel? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestInvocationsPageResponseModel? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseMeta? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestInvocationSummaryResponseModel>? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestInvocationSummaryResponseModel? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestSuiteInvocationResponseModel? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestRunResultSummary>? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunResultSummary? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestRunResponseModel>? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModel? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestsPageResponseModel? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestSummaryResponseModel>? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestSummaryResponseModel? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestsSummariesByIdsResponseModel? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.UnitTestSummaryResponseModel>? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolCallUnitTestResponseModel? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallEvaluationModelOutput? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModel? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem4>? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem4? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminator? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminatorType? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolExecutionsPageResponseModel? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolExecutionResponseModel>? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModel? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetUserVoiceCollectionsResponseModel? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UserVoiceCollectionResponseModel>? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserVoiceCollectionResponseModel? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoiceAccentsResponseModel? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceAccentResponseModel>? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceAccentResponseModel? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoicesResponseModel? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceResponseModel>? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModel? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoicesV2ResponseModel? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppAccountType? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWorkspacePlanParams? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWorkspaceSecretsResponseModel? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailType? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsResult? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptInjectionGuardrail? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationGuardrailInput? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationGuardrailOutput? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HTTPValidationError? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ValidationError>? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ValidationError? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HidingReason? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HistoryAlignmentResponseModel? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HistoryAlignmentsResponseModel? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HttpRequestModel? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UrlModel? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Icon? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IconTheme? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysis? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysisStatus? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysisResult? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageSubject>? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageSubject? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAvatar? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequest? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequestDiscriminator? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineImageReference? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReferenceDiscriminator? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReferenceDiscriminatorType? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkCredentialsRequestModel? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineAudioReferenceMimeType? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineBase64Reference? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineBase64ReferenceMimeType? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineImageReferenceMimeType? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineVideoReference? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineVideoReferenceMimeType? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntegrationType? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InternalAlertingWebhookNotifier? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AlertingWebhookHeader>? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InternalSamplingConfigResponseModel? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DiscountResponseModel>? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModelPaymentIntentStatus? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDeletedResponseModel? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResponseModel? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseContentSearchResult>? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResult? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Document? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminator? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminatorType? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchHighlightSegment>? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchHighlightSegment? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDependentType? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentChunksResponseModel? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel>? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseLocator? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagChunkModel? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolConfig? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolStatus? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseRagChunkModel>? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSortBy? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSourceFileUrlResponseModel? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Data? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminator? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolConfig? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchStrategy>? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchStrategy? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolInfo? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolStatus? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMAnyOfJsonSchemaPropertyInput? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMObjectJsonSchemaPropertyInput>? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMObjectJsonSchemaPropertyInput? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMAnyOfJsonSchemaPropertyOutput? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMArrayJsonSchemaPropertyInput? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMArrayJsonSchemaPropertyOutput? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMObjectJsonSchemaPropertyOutput? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMDeprecationConfigModel? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMDeprecationInfoModel? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMInfoModel? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMReasoningEffort>? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMReasoningEffort? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMServiceTier>? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMServiceTier? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegionalProcessingSurchargeInfo? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMInputOutputTokensUsage? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMTokensCategoryUsage? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMListResponseModel? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMInfoModel>? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMLiteralJsonSchemaPropertyType? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMParameterEvaluationStrategy? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LLMInputOutputTokensUsage>? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorLLMResponseModel? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorPublicRequestModel? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorRequestModel? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorResponseModel? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageAddedResponse? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageDetectionToolConfig? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageInfo? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePairInfo? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguageInfo>? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetTranslation? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageResponseModel? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponse? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PairedLanguagesResponse? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleLanguagesResponse? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponseDiscriminator? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponseDiscriminatorKind? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeaveMessageParams? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceResponseModelCategory? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerifiedVoiceLanguageResponseModel? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentProceduresParams? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentReferencesParams? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentRulesParams? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAssetsParams? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponse? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AuthConnectionsItem>? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionsItem? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2ClientCredsResponse? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshTokenAuthResponse? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponse? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivateKeyJWTResponse? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MTLSAuthResponse? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppAuthResponse? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SlackBotAuthResponse? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UrlSecretAuthResponse? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminator? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCalendarEventsParams? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListClientInteractionsParams? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListClientsParams? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCrawlJobsResponseModel? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetCrawlJobResponseModel>? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCustomerFacingAgentsParams? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListGroupSessionsParams? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListHolidaysParams? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListLocationsParams? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListMCPToolsResponseModel? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Tool>? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Tool? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolApprovalStatus>? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalStatus? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListOrdersResponse? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderSummary>? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderSummary? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListProceduresResponseModel? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureListItemResponseModel>? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureListItemResponseModel? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListProductsParams? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseAgentBranchSummary? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentBranchSummary>? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseAgentDeploymentHistoryItem? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentDeploymentHistoryItem>? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListServicesParams? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListSpeechEnginesResponse? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechEngineSummaryResponse>? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineSummaryResponse? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListStaffParams? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTestsByIdsRequestModel? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTransferRulesParams? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListWhatsAppAccountsResponse? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LiteralJsonSchemaPropertyType? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LoadMemoryEntryToolErrorStatus? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LoadableMemoryEntry? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LockReason? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovalPolicy? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovalPolicyUpdateRequestModel? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovedToolDefinition? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigInput? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolApprovalHash>? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalHash? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerTransport? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel>? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverrideInput>? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInput? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigOutput? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverrideOutput>? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutput? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigUpdateRequestModel? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerMetadataResponseModel? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerRequestModel? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModel? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem5>? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem5? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminator? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminatorType? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServersResponseModel? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPServerResponseModel>? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolAddApprovalRequestModel? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalPolicy? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalState? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInput? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant1? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminator? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutput? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant12? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminator? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ToolCallSoundType?, string>? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant13? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminator? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminatorSource? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant14? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminator? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModel? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant15? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModel? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant16? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualSource? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualVerificationFileResponseModel? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ManualVerificationFileResponseModel>? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MatchAnythingParameterEvaluationStrategy? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationCompletedResponse? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationCreateResponse? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationFailedResponse? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationFailedResponseFailureReason? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationInProgressResponse? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationInProgressResponseStatus? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationListResponse? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MediaGenerationResponse>? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponse? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponseDiscriminator? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MemoryEntrySearchResult? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConversationSource, global::ElevenLabs.ManualSource>? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeAgentConversationTicketsRequestModel? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModel? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem3>? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem3? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminator? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminatorProvider? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.FieldConflict>? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReviewReviewerRole? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalStatus? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessageSearchSortBy? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessagesSearchResponse? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MessagesSearchResult>? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessagesSearchResult? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetricType? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MockNoMatchBehavior? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MockingStrategy? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModelRatesResponseModel? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModelResponseModel? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguageResponseModel>? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationConfig? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ThresholdGuardrail? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModel? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModelSafetyStatus? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModelWarningStatus? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MultichannelSpeechToTextResponseModel? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextChunkResponseModel>? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModel? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MultipartMusicResponse? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicAllowedOutputFormats? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicOnlyOutputFormats? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicExploreSongSourceContext? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneFailureReason? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetunePageResponseModel? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MusicFinetuneResponseModel>? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneResponseModel? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneStatus? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicOutputFormat? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SongSection>? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongSection? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicUploadResponse? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NonStreamingOutputFormats? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumericDistributionAggregate? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumericUniformScoring? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseAlgorithm? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseTokenResponseField? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelAttribute? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, bool?, double?>? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelResource? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelAttribute>? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelResourceSpans? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelScopeSpans>? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelScopeSpans? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelScope? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelSpan>? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelSpan? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelStatus? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelTracePayload? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelResourceSpans>? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyInputPropertyKind? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequiredConstraints? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ContentSchema>? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioConfigInput? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputConfigInput? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputConfigInput? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioConfigOutput? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputConfigOutput? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputConfigOutput? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputFormat? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputTranscription? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAITurnDetection? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputFormat? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIFunctionTool? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIMCPTool? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIMCPToolRequireApproval? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeModel? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem3>? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem3? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInputToolDiscriminator? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInputToolDiscriminatorType? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.OpenAIToolChoiceFunction>? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIToolChoiceFunction? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.OpenAITurnDetection, string>? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<string, global::ElevenLabs.OpenAITracingConfiguration>? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAITracingConfiguration? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem4>? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem4? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminator? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminatorType? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIToolChoiceFunctionInner? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnDetectionType? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenerConfig? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OptInSmsReminderParams? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OptOutSmsReminderParams? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrbAvatar? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderDeliverablesResponse? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DeliverableInfo>? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemInfo? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutput? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QuoteInfo? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemKind? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInput? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubtitleOrderItemRequest? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptionOrderItemRequest? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInputDiscriminator? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInputDiscriminatorKind? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutputDiscriminator? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderMediaResponse? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderResponse? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderState? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderItemInfo>? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerGetClientAppointmentsParams? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListAssetsParams? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListLocationsParams? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListProductsParams? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListServicesParams? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListStaffParams? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PaginatedResultAgentMergeProposalResponse? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentMergeProposalResponse>? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguagePairInfo>? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchAgentConversationTicketRequestModel? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequest? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem2>? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChartsItem2? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminator? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAISettingsRequest? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConversationTagRequestModel? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchWorkspaceSecretRequest? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchWorkspaceWebhookResponseModel? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingBlocksMetadataModel? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingClipTask? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingClipTaskType? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingExternalAudiosMetadataModel? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberSortBy? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransfer? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem>? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminator? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferDestination? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPUriTransferDestination? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPUriDynamicVariableTransferDestination? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminator? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminatorType? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferTypeEnum? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UUITransferConfig? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant1? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsStatic? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsDynamicVariable? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1Discriminator? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformCategory? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformCategoryUsage? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformLimits? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StoredUsagePlatformLimit? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.PlatformCategoryUsage>? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFToolConfig? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastBulletinModeData? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastConversationModeData? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastProjectResponseModel? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PositionInput? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PositionOutput? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostAgentAvatarResponseModel? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostAgentHoldAudioResponseModel? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostWorkspaceSecretRequest? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostWorkspaceSecretResponseModel? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivateKeyJWTResponseAlgorithm? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureAtVersionResponseModel? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureDraftResponseModel? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaResponseModel? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaResponseModelStatus? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaType? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModel? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelTargetAudience? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelState? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelAccessLevel? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelFiction? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelSourceType? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.CaptionStyleModel>? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelAspectRatio? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioAgentSettingsModel? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionResponseModel? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryLocatorResponseModel? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVideoResponseModel? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModel? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectImageResponseModel? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVoiceResponseModel>? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVoiceResponseModel? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SourceContextVariant1? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongSourceContext? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SfxSourceContext? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectMutedTracksResponseModel? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelTargetAudience? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelState? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelAccessLevel? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelFiction? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelSourceType? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelAspectRatio? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotExtendedResponseModel? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotResponseModel? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotsResponseModel? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectSnapshotResponseModel>? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysis? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigInput? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLlmConfig? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminator? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem5>? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem5? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolConfigInput? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfig? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminator? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminatorType? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigOutput? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLlmConfig2? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem6>? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem6? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolConfigOutput? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminator? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigWorkflowOverrideInput? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride>? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item>? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsVariant1Item? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminator? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigWorkflowOverrideOutput? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item2>? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsVariant1Item2? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryRulesResponseModel? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryParamsJsonSchemaInput? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryParamsJsonSchemaOutput? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexResponseModel? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexStatus? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexUsage? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexesResponseModel? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RAGDocumentIndexResponseModel>? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexBatchSuccessfulResponseModel? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexOverviewResponseModel? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel>? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexRequestModel? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagChunkMetadata? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RagChunkMetadata>? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReaderResourceResponseModel? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReaderResourceResponseModelResourceType? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupResponseModel? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupSharingSummary? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupSharingSummaryEveryoneRole? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupsResponseModel? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RealtimeConversationGroupResponseModel>? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RecordingResponseModel? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioClipLocator? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferencedToolCommonModel? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferencedToolCommonModelType? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegexParameterEvaluationStrategy? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioRegionId? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioEdgeLocation? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegisterForGroupSessionParams? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegisterMediaResponse? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RemoveOrderItemResponse? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RemoveVoiceFromUserVoiceCollectionResponseModel? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RenderStatus? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReplicateVoiceToIsolatedEnvironmentRequestModel? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReplicateVoiceToIsolatedEnvironmentResponseModel? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReportKnowledgeGapParams? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequestPVCManualVerificationResponseModel? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequiredConstraint? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RequiredConstraint>? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoRole? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoAnonymousAccessLevelOverride? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoAccessSource? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceMetadataResponseModel? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ShareOptionResponseModel>? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ShareOptionResponseModel? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseConversationErrorType? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseFilter? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseUnitTestModel? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RestoreCalendarEventParams? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResubmitTestsRequestModel? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModelReviewStatus? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RunAgentTestsRequestModel? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SingleTestRunRequestModel>? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleTestRunRequestModel? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RunConversationEvaluationsRequest? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPLogMessageDirection? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkOutboundCallResponse? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBClientAccessConfig? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchClientsParams? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendCustomEmailParams? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateClientParams? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateStaffParams? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAssetParams? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateServiceParams? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateProductParams? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderParams? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScheduleGroupSessionParams? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateGroupSessionSeatsParams? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateCalendarEventParams? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentRuleParams? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTransferRuleParams? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentProcedureParams? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateHolidayParams? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitBusinessInfoParams? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBusinessInfoParams? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentConfigParams? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBookingPageSettingsParams? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBookingPageAppearanceParams? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SetBookingSlugParams? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateLocationParams? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerUserVerificationParams? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ValidateUserVerificationCodeParams? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfigParamsDiscriminator? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMSConversationInfoDirection? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyCommonModelInput? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyEvaluation? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyCommonModelOutput? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SafetyRule>? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyRule? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleConfigDBModelParentType? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleResponseModel? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSeparationResponseModel? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodeLiteralMessageInput? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TranslatedString>? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranslatedString? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodeLiteralMessageOutput? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodePromptMessageInput? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodePromptMessageOutput? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScimGroupResponseModel? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecretDependencyResourceType? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SectionSource? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TimeRange>? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentCreatePayload? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentCreateResponse? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentDeleteResponse? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentDubResponse? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentMigrationResponse? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentTranscriptionResponse? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentTranslationResponse? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentUpdatePayload? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentUpdateResponse? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SetConversationGroupRequestModel? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ShareOptionResponseModelType? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimilarVoice? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceCategory? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimilarVoicesForSpeakerResponse? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SimilarVoice>? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationLibrarySettings? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationTestModel? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleUseTokenResponseModel? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleUseTokenType? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SkipTurnToolConfig? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfig? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigOverride? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigOverrideConfig? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigWorkflowOverride? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SortDirection? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerAudioResponseModel? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerCreatedResponse? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerResponseModel? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UtteranceResponseModel>? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UtteranceResponseModel? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbedSegment>? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSeparationResponseModelStatus? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerResponseModel>? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerUpdatedResponse? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineResponse? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelVoiceCategory? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelState? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelSource? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInputResponseModel>? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextCharacterResponseModel? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextWordResponseModel>? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWordResponseModel? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AdditionalFormatResponseModel?>? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DetectedEntity>? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditedTranscriptVariant1? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptEditError? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1Discriminator? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWebhookResponseModel? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWordResponseModelType? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextCharacterResponseModel>? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartPVCVoiceTrainingResponseModel? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolConfig? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolErrorStatus? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartSpeakerSeparationResponseModel? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamingAudioChunkWithTimestampsResponseModel? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.StudioAgentToolSettingsModel>? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioAgentToolSettingsModel? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioClipLocatorClipType? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitOrderResponse? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionExtrasResponseModel? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionUsageResponseModel? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionResponseModel? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SuggestedAudioTag? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SupportedVoice? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSModelFamily? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemEvaluationCriteria? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params2? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolConfigInput? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberToolConfigInput? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicemailDetectionToolConfig? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInputParamsDiscriminator? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params3? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolConfigOutput? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberToolConfigOutput? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutputParamsDiscriminator? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalModel? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SupportedVoice>? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SuggestedAudioTag>? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSOutputFormat? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextNormalisationType? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionConfig? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateArrayOutput? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunStatus? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateArrayOutputFailureReason? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateOutput>? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutput? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateAudioOutput? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateAudioOutputFailureReason? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateBooleanOutput? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateBooleanOutputFailureReason? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateImageOutput? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateImageOutputFailureReason? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReference? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceReference? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReferenceDiscriminator? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReferenceDiscriminatorType? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateIntegerOutput? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateIntegerOutputFailureReason? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateListResponse? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateSummary>? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateSummary? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateNumberOutput? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateNumberOutputFailureReason? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateObjectOutput? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateObjectOutputFailureReason? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateOutput>? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVideoOutput? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateStringOutput? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutputDiscriminator? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutputDiscriminatorType? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplatePort? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunCreateRequest? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateRunInput>? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunInput? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunListResponse? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunResponse>? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunResponse? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateStringOutputFailureReason? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateVersion>? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVersion? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplatePort>? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVideoOutputFailureReason? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestConditionRationaleCommonModel? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestConditionResultCommonModel? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunMetadata? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunMetadataTestType? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunResultBucket? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunStatus? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestRunResultBucket>? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestSharingMode? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestType? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequest? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequestDiscriminator? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketMergeProposalLinkResponseModel? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSearchMatchField? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TokenResponseModel? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecution? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Icon>? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolAnnotations? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallUnitTestModel? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionTaskSupport? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallDetailsVariant1? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1Discriminator? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModel? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolConfig? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModelToolConfigDiscriminator? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestToolCallParameter>? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameter? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModel? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolConfig2? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModelToolConfigDiscriminator? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolUsageStatsResponseModel? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolSortBy? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolTypeFilter? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsResponseModel? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseModel>? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicEvaluationCriteriaAggregate? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicSentimentAggregate? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TopicEvaluationCriteriaAggregate>? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicSortBy? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoConfigured? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoDefaultingToMain? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoTrafficSplit? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTransferInput>? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTransferOutput>? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchInfoVariant1? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1Discriminator? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchInfoVariant12? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1Discriminator? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumberTransfer>? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioAnsweredBy? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionAction? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionMode? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TwilioMachineDetectionRule>? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionRule? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TwilioAnsweredBy>? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioOutboundCallResponse? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.URLAvatar? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestGuardrailTriggerEvaluationModel? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestInfoVariant1? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1Discriminator? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestWorkflowNodeTransitionEvaluationNodeId? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Eval? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminator? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsRequestModel? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemAttachmentDestination>? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModel? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResultsItem>? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultsItem? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminator? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBasicAuthRequest? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBearerAuthRequest? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateEnvironmentVariableRequest? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMusicFinetuneRequestModel? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMusicFinetuneRequestModelVisibility? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2ClientCredsRequest? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequest? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderResponse? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRequest? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateProcedureDraftRequestModel? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateRealtimeConversationGroupRequestModel? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateResponseUnitTestRequest? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateSimulationTestRequest? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateSpeechEngineRequest? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTestSuiteInvocationRequestModel? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateToolCallUnitTestRequest? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateWhatsAppAccountRequest? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateWorkspaceMemberResponseModel? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpsertOrderItemResponse? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsageAggregationInterval? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsageCharactersResponseModel? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserDataCollectionAnalysisItemInput? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Scoring? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminator? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminatorMode? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserResponseModel? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserVoiceCollectionResponseModelPermissionOnResource? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsersSortBy? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?>? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequest? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequestAspectRatio? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequestResolution? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VeoImageReference>? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VeoImageReference? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31Request? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31RequestAspectRatio? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31RequestResolution? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VeoImageReferenceRole? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerifyPVCVoiceCaptchaResponseModel? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysisStatus? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysisResult? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoSubject>? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSubject? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoSegment>? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSegment? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoKeyMoment>? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoKeyMoment? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequest? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequestDiscriminator? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReferenceDiscriminator? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReferenceDiscriminatorType? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceDesignRequestModel? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceDesignRequestModelModelId? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewResponseModel? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewsRequestModel? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewsResponseModel? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoicePreviewResponseModel>? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceRemixRequestModel? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SampleResponseModel>? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelCategory? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModel? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelSafetyControl? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceVerificationResponseModel? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelRecordingQuality? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelLabellingStatus? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSamplePreviewResponseModel? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSampleVisualWaveformResponseModel? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingModerationCheckResponseModel? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelStatus? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelCategory? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelReviewStatus? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReaderResourceResponseModel>? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookAuthMethodType? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetAll? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetIds? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetDiscriminator? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetDiscriminatorType? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInput? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInputContentType? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutput? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutputContentType? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookUsageType? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppCallPermissionRequest? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppCallPermissionRequestState? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppConversationInfoDirection? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppRecipient? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOpeningMessage? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOutboundCallResponse? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOutboundMessageResponse? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateTextParam>? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateTextParam? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateDocumentParam? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateDocumentParamDetails? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ParametersItem>? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ParametersItem? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateImageParam? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateLocationParam? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminator? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateImageParamDetails? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateLocationParamDetails? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetPlacement? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetExpandable? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetFeedbackMode? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetEndFeedbackConfig? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigInputSyntaxHighlightTheme? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTextContents? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetStyles? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WidgetLanguagePreset>? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetLanguagePreset? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigOutputSyntaxHighlightTheme? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigResponseModelSyntaxHighlightTheme? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WidgetLanguagePresetResponse>? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetLanguagePresetResponse? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetEndFeedbackType? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTextContentsTranslation? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTermsTranslation? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForwardConditionVariant1? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUnconditionalModelInput? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowLLMConditionModelInput? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowResultConditionModelInput? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowExpressionConditionModelInput? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1Discriminator? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackwardConditionVariant1? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PositionInput>? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForwardConditionVariant12? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUnconditionalModelOutput? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowLLMConditionModelOutput? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowResultConditionModelOutput? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowExpressionConditionModelOutput? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackwardConditionVariant12? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1Discriminator? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PositionOutput>? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeOutcome? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem2>? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem2? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminator? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination2? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminator? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant12? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1Discriminator? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem3>? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem3? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination3? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminator? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant13? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolEdgeStepModel? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocator? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SchemaOverridesVariant12? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminator? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminatorSource? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNestedToolsStepModelInput? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkflowToolLocator>? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem>? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StepsItem? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminator? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem2>? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StepsItem2? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminator? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>>? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ColumnUnit?>? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceApiKeyListResponseModel? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceApiKeyResponseModel>? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceApiKeyResponseModel? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAuditLogEntryResponse? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAuditLogsPageResponse? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAuditLogEntryResponse>? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceBatchCallsResponse? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BatchCallResponse>? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateApiKeyResponseModel? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateServiceAccountResponseModel? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateWebhookResponseModel? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupByNameResponseModel? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupPermission? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupPermission>? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceMemberResponseModel? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceServiceAccountListResponseModel? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceServiceAccountResponseModel>? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceServiceAccountResponseModel? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupResponseModel>? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookListResponseModel? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookResponseModel>? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookResponseModel? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookUsageResponseModel? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationNode? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateOAuth2ClientCredsRequest, global::ElevenLabs.UpdateBasicAuthRequest, global::ElevenLabs.UpdateBearerAuthRequest, global::ElevenLabs.UpdateOAuth2JWTRequest>? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateExotelPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UserEvaluationAnalysisItem, global::ElevenLabs.UserDataCollectionAnalysisItemInput>? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequest? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminator? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistorySortDirection? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistorySource? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechFullOutputFormat? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechStreamOutputFormat? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToSpeechFullOutputFormat? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToSpeechStreamOutputFormat? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectListSortDirection? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingStatus? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingStatusesVariant1Item? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingModelsVariant1Item? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsCreationSourcesVariant1Item? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsFilterByCreator? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsOrderBy? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsOrderDirection? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDubbedTranscriptFileFormatType? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDubbingTranscriptsFormatType? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionariesMetadataSort? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestType>? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListChatResponseTestsRouteSortMode? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoriesRouteSummaryMode? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item>? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GuardrailType>? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoryRouteFormat? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item>? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketSource>? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketPriority>? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolTypeFilter>? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListEnvironmentVariablesType? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerateOutputFormat? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComposeDetailedOutputFormat? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComposeDetailedStreamOutputFormat? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamComposeOutputFormat? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetFinetunesSort? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetFinetunesSortDirection? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderState>? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListVideoGenerationsStatus? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListImageGenerationsStatus? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTextToSpeechGenerationsStatus? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DownloadSpeechHistoryItemsResponse? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DubbingTranscriptResponseModel, string>? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ModelResponseModel>? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponse? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponseDiscriminator? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponse? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponseDiscriminator? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkspaceGroupResponseModel>? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupByNameResponseModel>? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceMemberResponseModel>? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponse2? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminator? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminatorStatus? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponse? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminator? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponse? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminator? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AssignableUserResponseModel>? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItem? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminator? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponse? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminator? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminatorProvider? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponse? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminator? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminatorProvider? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponse2? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponse? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponseDiscriminator? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponse? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminator? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponse? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminator? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminatorType? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponse2? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminator? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponse? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminator? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponse2? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminator? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus? Type2727 { get; set; }

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
        public global::System.Collections.Generic.List<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ColumnFilter>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateParamsItem>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PromptEvaluationCriteria>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OutboundCallRecipient>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DialogueInput>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookEventType>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>, string>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupConfig>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ImageReference>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoReference>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioReference>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockInputModel>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockResponseModel>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CharacterAlignmentModel>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterSnapshotResponseModel>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceStatisticsResponseModel>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>?>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ProcedureValidationError>>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProcedureValidationError>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.List<object>, object>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem2>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.McpServersItem2>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SecretDependencyType>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WebhookEventType>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ClientEvent>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DataCollectionResultCommonModel>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ScopedAnalysisResult>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceRewardModel>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConfigEntityType>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableUpdateCommonModel>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationReasoningModel>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TriggeredGuardrailCommonModel>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigOutput>>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigOutput>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceUsageModel>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.FrustratedConversationRef>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TurnCommentRequestModel>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentSuccessfulResponseExample>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentFailureResponseExample>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigInput>>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigInput>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomGuardrailConfig>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DataCollectionValueSchemaType?, global::System.Collections.Generic.List<string>>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WordTimestamp>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReadMetadataChapterDBModel>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Contributor>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SegmentSubtitleFrame>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptSegment>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTargetTranscriptSegment>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingLanguageResponse>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoicesNotPermittedWarning>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingMetadataResponse>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingProjectResponse>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptUtterance>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptWord>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptCharacter>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocator>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EnvironmentVariableResponse>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EnvironmentResponse>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModel>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VerificationAttemptResponseModel>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentWordResponseModel>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketResponseModel>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetWhatsAppAccountResponse>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTopicResponseModel>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentSummaryResponseModel>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem2>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentBranchInfo>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioIsolationHistoryItemResponseModel>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterResponseModel>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VisitedAgentRef>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationSummaryMessageModel>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationTagResponseModel>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationUserResponseModel>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationSummaryResponseModel>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem3>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DocumentUsageModeEnum>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DocumentsItem>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem2>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem3>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem4>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LibraryVoiceResponseModel>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MediaCodec>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem2>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectResponseModel>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SIPLogMessage>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechHistoryItemResponseModel>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestInvocationSummaryResponseModel>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestRunResultSummary>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestRunResponseModel>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestSummaryResponseModel>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem4>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolExecutionResponseModel>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UserVoiceCollectionResponseModel>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceAccentResponseModel>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceResponseModel>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ImageSubject>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AlertingWebhookHeader>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DiscountResponseModel>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseContentSearchResult>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SearchHighlightSegment>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseRagChunkModel>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SearchStrategy>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMObjectJsonSchemaPropertyInput>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMReasoningEffort>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMServiceTier>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMInfoModel>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?, global::System.Collections.Generic.List<string>>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguageInfo>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AuthConnectionsItem>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetCrawlJobResponseModel>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Tool>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolApprovalStatus>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderSummary>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProcedureListItemResponseModel>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentBranchSummary>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentDeploymentHistoryItem>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechEngineSummaryResponse>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.List<string>>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolApprovalHash>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverrideInput>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverrideOutput>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem5>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPServerResponseModel>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ManualVerificationFileResponseModel>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MediaGenerationResponse>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem3>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.FieldConflict>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MessagesSearchResult>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguageResponseModel>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextChunkResponseModel>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MusicFinetuneResponseModel>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SongSection>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelAttribute>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelScopeSpans>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelSpan>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelResourceSpans>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem3>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem4>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DeliverableInfo>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderItemInfo>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentMergeProposalResponse>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguagePairInfo>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem2>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectVoiceResponseModel>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectSnapshotResponseModel>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseLocator>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem5>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem6>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsVariant1Item>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsVariant1Item2>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RAGDocumentIndexResponseModel>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RagChunkMetadata>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RealtimeConversationGroupResponseModel>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RequiredConstraint>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ShareOptionResponseModel>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SingleTestRunRequestModel>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SafetyRule>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TimeRange>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SimilarVoice>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UtteranceResponseModel>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DialogueInputResponseModel>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextWordResponseModel>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AdditionalFormatResponseModel?>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DetectedEntity>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextCharacterResponseModel>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SupportedVoice>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SuggestedAudioTag>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateOutput>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateSummary>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateRunInput>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateRunResponse>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateVersion>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplatePort>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestRunResultBucket>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Icon>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestToolCallParameter>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseModel>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TopicEvaluationCriteriaAggregate>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTransferInput>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTransferOutput>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumberTransfer>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TwilioMachineDetectionRule>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TwilioAnsweredBy>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemAttachmentDestination>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResultsItem>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<double>>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VeoImageReference>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoSubject>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoSegment>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoKeyMoment>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoicePreviewResponseModel>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SampleResponseModel>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReaderResourceResponseModel>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WhatsAppTemplateTextParam>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ParametersItem>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PositionInput>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PositionOutput>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem2>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem3>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkflowToolLocator>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.StepsItem>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.StepsItem2>? ListType294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>? ListType295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>>? ListType296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>? ListType297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ColumnUnit?>? ListType298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceApiKeyResponseModel>? ListType299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAuditLogEntryResponse>? ListType300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BatchCallResponse>? ListType301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupPermission>? ListType302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceServiceAccountResponseModel>? ListType303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupResponseModel>? ListType304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookResponseModel>? ListType305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>? ListType306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? ListType307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? ListType308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? ListType309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestType>? ListType310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item>? ListType311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GuardrailType>? ListType312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item>? ListType313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketSource>? ListType314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketPriority>? ListType315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentType>? ListType316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolTypeFilter>? ListType317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderState>? ListType318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ModelResponseModel>? ListType319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupByNameResponseModel>? ListType320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceMemberResponseModel>? ListType321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AssignableUserResponseModel>? ListType322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>? ListType323 { get; set; }
    }
}