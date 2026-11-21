
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
        public global::ElevenLabs.AgentChatResponsePartClientEvent? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentChatResponsePartClientEventData? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentChatResponsePartType? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelInput? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariablesConfig? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.BehaviorOverride>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BehaviorOverride? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubagentConfigInput? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInput? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelOutput? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubagentConfigOutput? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutput? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelWorkflowOverrideInput? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariablesConfigWorkflowOverride? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInput? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelWorkflowOverrideOutput? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutput? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigOverrideInput? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOverrideInput? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigOverrideOutput? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOverrideOutput? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigOverrideConfig? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOverrideConfig? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketPriority? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketResponseModel? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketCommentResponseModel>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketCommentResponseModel? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentResponseModel>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnCommentResponseModel? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketStatus? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriorityChangeResponseModel>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketPriorityChangeResponseModel? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatusChangeResponseModel>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketStatusChangeResponseModel? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketSource? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSearchMatchResponseModel? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketSortBy? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDefinitionSource? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentHistoryItem? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentSource? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentPercentageStrategy? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentRequest? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentDeploymentRequestItem>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentRequestItem? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentResponse? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentFailureResponseExample? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentHoldAudioConfig? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentFormat? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagDocumentResponseModel? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagListingEntryResponseModel? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagListingResponseModel? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagListingEntryResponseModel>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagQueryRequestModel? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchStrategy? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagQueryResponseModel? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalReview>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReview? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalComment>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalComment? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Outcome? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenOutcome? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergedOutcome? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClosedOutcome? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminator? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMessagesOverrides? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Llm? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMessagesPersistedAgent? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadata? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadataDBModel? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadataResponseModel? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentOutputError? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentOutputStatus? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSettingsInput? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigInput? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisProperty>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisProperty? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisScope>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisScope? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataConfigInput? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkspaceOverridesInput? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestingSettings? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsV1Input? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthSettings? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentQueueingConfig? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivacyConfigInput? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTrustContext? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicDiscoverySettings? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SentimentAnalysisSettings? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSettings? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentPlatformSettingsResponseModel? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSettingsOutput? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigOutput? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataConfigOutput? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkspaceOverridesOutput? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsV1Output? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivacyConfigOutput? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSettingsResponse? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyResponseModel? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentPolicyOverrideInput? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RetryPolicy? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallingPeriod>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallingPeriod? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DateOverride>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DateOverride? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionConfig? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FollowupContextPolicy? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentPolicyOverrideOutput? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentReasoningResponsePartClientEvent? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentReasoningResponsePartClientEventData? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentResponseAttachment? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentResponseClientEvent? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentResponseClientEventData? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentResponseType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentResponseAttachment>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentRule? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RulePriority? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSMBMetadata? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAgentType? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSimulatedChatTestResponseModel? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptResponseModel? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryAnalysisCommonModel? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSortBy? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSuccessfulResponseExample? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSummaryBatchSuccessfulResponseModel? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSummaryResponseModel? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestEntityType? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestFolderPathSegmentResponseModel? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AttachedTestModel>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedTestModel? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentToolRequestClientEventData? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentToolRequestStreamedEvent? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentToolResponseClientEventData? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentToolResponseStatus? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentToolResponseStreamedEvent? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTopicResponseModel? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicMetricsAggregate? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferInput? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOutput? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentVersionParents? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResourceAccessInfo>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelInput>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInput? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Nodes? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartNodeModelInput? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeModelInput? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInput? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelInput? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNodeModelInput? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartProcedureNodeModelInput? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminator? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModel? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelOutput>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutput? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Nodes2? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartNodeModelOutput? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeModelOutput? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNodeModelOutput? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartProcedureNodeModelOutput? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminator? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataWebhook? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIWebhooks? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingMonitorConfig? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingPagerDutyNotifier? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingPagerDutyNotifierResponse? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AlertingMonitorConfig>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookNotifier? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSlackNotifier? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookNotifierResponse? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSlackNotifierResponse? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookSecretHeaderValue? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowedOutputFormats? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowedValues? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowlistItem? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisCharging? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisRunningTotal? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisRunSnapshot? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentAction? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentDestination? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentResultData? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemKind? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModel? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Definition? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItem? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserDataCollectionAnalysisItemOutput? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModelDefinitionDiscriminator? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModelDefinitionDiscriminatorKind? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemSource? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModel? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Definition2? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminator? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminatorKind? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionsResponseModel? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemVersionResponseModel>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemsResponseModel? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemResponseModel>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisPropertyType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOfJsonSchemaPropertyInput? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ObjectJsonSchemaPropertyInput>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyInput? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOfJsonSchemaPropertyOutput? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ObjectJsonSchemaPropertyOutput>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyOutput? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependencies? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionStatus? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverrides? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SchemaOverridesVariant12? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConstantSchemaOverride? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableSchemaOverride? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMSchemaOverride? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OmitSchemaOverride? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminator? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseFilterMode? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAIDynamicVariable>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIDynamicVariable? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigInput? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolInterruptionMode? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PreToolSpeechMode? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableAssignment? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallSoundType? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallSoundBehavior? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolErrorHandlingMode? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionMode? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApplicationNumberType? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyInput? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LiteralJsonSchemaProperty? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyOutput? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArraySchema? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchema? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetListResponse? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AssetResponse>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetResponse? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscription? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscriptionStatus? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscriptionData? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignConversationTagsRequestModel? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignResellerTierRequest? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignResellerTierRequestBillingPeriod? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignableUserResponseModel? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadata? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadataDeliveryStatus? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformMetadataVariant1? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlainPlatformMetadata? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ZendeskPlatformMetadata? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1Discriminator? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemDataCollectionId? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemEvaluationId? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttentionPageResponse? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AttentionView>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttentionView? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttentionResolutionRequest? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttentionStatus? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysis? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysisStatus? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysisResult? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioSegment>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioSegment? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioKeyMoment>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioKeyMoment? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsCatalogResponseModel? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsFilterPresetResponseModel>? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsFilterPresetResponseModel? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsEnvironmentResponseModel>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsEnvironmentResponseModel? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioFormat? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioInputPacing? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioIsolationHistoryItemResponseModel? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeCreateProjectResponseModel? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeEditContentResponseModel? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeProjectSettingsResponseModel? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioRefChunk? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeRange? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReference? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationReference? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StaticAssetReference? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineAudioReference? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReferenceDiscriminator? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReferenceDiscriminatorType? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioSchema? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioWithTimestampsAndVoiceSegmentsResponseModel? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAlignmentResponseModel? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceSegment>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSegment? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioWithTimestampsResponseModel? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuditActivityName? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuditClassName? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem3>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem3? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableToolIdentifier? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownToolIdentifier? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesToolDiscriminator? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.McpServersItem? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableMCPServerIdentifier? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownMCPServerIdentifier? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminator? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentIntegrationConnectionIdentifier>? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentIntegrationConnectionIdentifier? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionLocator? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AllowlistItem>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthorizationMethod? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoRebaseAttempt? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoRebaseOutcome? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoSyncInfo? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AvatarContextResponseModel? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundConfig? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundSourceType? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundPresetId? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundConfigWorkflowOverride? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMDefault? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMDisabled? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMOverride? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Llm>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Base64FileSource? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileInputMimeType? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BaseTurnConfig? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnMode? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnEagerness? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpellingPatience? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnModel? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BasicAuthResponse? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallDetailedResponse? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyProvider? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallWhatsAppParams? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallStatus? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyCallConfigOutput? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipientResponseModel>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundCallRecipientResponseModel? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallRecipientStatus? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallResponse? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallingCampaignInformation? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignConversationType? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchFailureResponseModel? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchSuccessResponseModelAnalysisItemAttachmentResultData? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BearerAuthResponse? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Verbosity? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutputFormat? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InteractionBudget? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BillingPeriod? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BinaryScoring? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddSamplesToPvcVoiceV1VoicesPvcVoiceIdSamplesPost? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddVoiceV1VoicesAddPost? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPost? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPost? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkDeleteKnowledgeBaseDocumentsV1ConvaiKnowledgeBaseBulkDeletePost? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkMoveTestsToFolderV1ConvaiAgentTestingBulkMovePost? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCheckWatermarkV1ContentProvenanceWatermarkPost? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCommentOnAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdCommentsPost? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPost? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicGenerationMode? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicPrompt? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompositionPlan? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicModelID? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicV1MusicPost? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetOrCreateRAGIndexRequestModel>? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRAGIndexRequestModel? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentV1ConvaiAgentsCreatePost? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSettings? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string>? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPost? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePvcVoiceV1VoicesPvcPost? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPost? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QualityPresetType? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateUrlDocumentV1ConvaiKnowledgeBaseUrlPost? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoicePost? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentTestFolderV1ConvaiAgentTestingFoldersPost? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateChapterV1StudioProjectsProjectIdChaptersPost? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateCrawlJobV1ConvaiKnowledgeBaseCrawlPost? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateForcedAlignmentV1ForcedAlignmentPost? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPost? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastConversationMode? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastBulletinMode? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastTextSource? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastURLSource? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateVoiceCollectionV1VoicesCollectionsPost? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookHMACSettings? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDeleteExistingInvitationV1WorkspaceInvitesDelete? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDownloadHistoryItemsV1HistoryDownloadPost? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPost? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditPvcVoiceV1VoicesPvcVoiceIdPost? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPost? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePost? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MetronomeUsageColumnFilter>? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetronomeUsageColumnFilter? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnFilter? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetDependentAgentsForMultipleDocumentsV1ConvaiKnowledgeBaseDependentAgentsPost? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaExotelV1ConvaiExotelOutboundCallPost? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataRequestInput? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyCallConfigInput? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaSipTrunkV1ConvaiSipTrunkOutboundCallPost? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SeatType? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyInviteUserV1WorkspaceInvitesAddPost? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConflictResolution>? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConflictResolution? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMergeAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdMergePost? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ProcedureVersionRef>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureVersionRef? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPostAgentHoldAudioV1ConvaiAgentsAgentIdHoldAudioPost? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRebaseABranchOntoMainV1ConvaiAgentsAgentIdBranchesBranchIdRebasePost? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyDirection? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRegisterMediaV1ProductionsOrdersOrderIdMediaPost? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RenderType? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyReviewAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdReviewsPost? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReviewState? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateParamsItem>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateParamsItem? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParams? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateBodyComponentParams? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateButtonComponentParams? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendTestWebhookEventV1WorkspaceWebhooksWebhookIdTestPost? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTypes? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySetRulesOnThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdSetRulesPost? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySetWorkspaceThirdPartyDisablingPolicyV1WorkspacesApiKeysThirdPartyDisablingPost? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceResourceType? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSimulationSpecification? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PromptEvaluationCriteria>? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptEvaluationCriteria? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySoundGenerationV1SoundGenerationPost? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SFXModelId? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostNumbersFormat? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, object>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPost? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamChapterAudioV1StudioProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamComposedMusicV1MusicStreamPost? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPost? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipient>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundCallRecipient? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPost? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInput>? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DialogueInput? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToDialogueSettingsResponseModel? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EffectsSpecInput? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePost? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTranslatesAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdTranslatePost? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdatePvcVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateStudioProjectV1StudioProjectsProjectIdPost? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdPatch? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAgentTestFolderV1ConvaiAgentTestingFoldersFolderIdPatch? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentInputModel? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateFileDocumentV1ConvaiKnowledgeBaseDocumentationIdUpdateFilePatch? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPost? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateOrderV1ProductionsOrdersOrderIdPatch? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderRequest? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateVoiceCollectionV1VoicesCollectionsCollectionIdPatch? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookEventType>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookEventType? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadAssetV1AssetsPost? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadFileV1ConvaiConversationsConversationIdFilesPost? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadMusicV1MusicUploadPost? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<bool?, global::ElevenLabs.MusicModelID?>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpsertOrderItemV1ProductionsOrdersOrderIdItemsPost? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpsertOrderItemRequest? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVerifyPvcVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVideoToMusicV1MusicVideoToMusicPost? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPost? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerV1VoiceChangerVoiceIdPost? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PermissionType? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateServiceAccountV1ServiceAccountsPost? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupConfig>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupConfig? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<bool?, string>? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchExpiresAtUnix?>? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchExpiresAtUnix? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbCancelTeamInvite? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbUpdateTeamMemberRole? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbUpdateTeamMemberRoleRole? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbUploadKnowledgeSource? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueFullWithTimestamps? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueStreamWithTimestamps? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFull? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSettingsResponseModel? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullWithTimestamps? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStream? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamWithTimestamps? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BooleanSchema? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BreakdownTypes? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BucketingStatus? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsInput? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInput? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsOutput? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutput? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsWorkflowOverrideInput? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsWorkflowOverrideOutput? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25Request? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTarget? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25RequestAspectRatio? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25RequestResolution? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReference? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoReference>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReference? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioReference>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequest? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequestResolution? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequest? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequestResolution? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2Request? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2RequestAspectRatio? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2RequestResolution? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequest? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequestResolution? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequest? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequestResolution? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallResult? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallStatus? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallView? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DecisionDisposition? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeadDeliveryView? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallingIntervalPolicy? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallingIntervalPolicy>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallingPeriodPolicy? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignCallsResponse? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallView>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignConfigInput? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PolicyConfigInput? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AgentPolicyOverrideInput>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignConfigOutput? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PolicyConfigOutput? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AgentPolicyOverrideOutput>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignFollowUpRequestsResponse? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FollowUpRequestCounts? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignLeadsResponse? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LeadView>? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeadView? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignPageResponse? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CampaignResponse>? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignResponse? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignPolicySnapshot? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallingPeriodPolicy>? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DateOverridePolicy>? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DateOverridePolicy? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionPolicy? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignProgressResponse? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeadsProgress? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationProgress? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChannelConfig? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneChannelConfigOutput? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppChannelConfig? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignResponseChannelConfigDiscriminator? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignResponseChannelConfigDiscriminatorChannel? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignStatus? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignVariant? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignSource? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundChannel? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundMode? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignSummaryCounts? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RecipientDeliveryCounts? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelCalendarEventParams? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelGroupSessionForAllParams? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelGroupSessionRegistrationParams? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelOrderParams? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CanvasPlacement? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModel? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleHorizontalPlacementModel? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModel? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleTemplateModel? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextAlign? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextStyle? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextWeight? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextTransform? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextBlendMode? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioTextStyleShadowModel? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioTextStyleOutlineModel? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModel? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModel? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleVerticalPlacementModel? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModelEnterType? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModelExitType? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleVerticalPlacementModelAlign? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModelEnterType? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModelExitType? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChangeResellerTierRequest? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChangeResellerTierRequestBillingPeriod? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockInputModel? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockInputModelSubType? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockResponseModel? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockInputModel>? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentResponseModel? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockResponseModel>? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterResponseModel? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterResponseModelState? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterStatisticsResponseModel? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotExtendedResponseModel? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CharacterAlignmentModel>? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAlignmentModel? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotResponseModel? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotsResponseModel? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterSnapshotResponseModel>? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceStatisticsResponseModel>? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceStatisticsResponseModel? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterWithContentResponseModelState? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterRefreshPeriod? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChatSourceMedium? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CheckServiceAvailabilityParams? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChunkingOverride? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChunkingOverrideRequestModel? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientEvent? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientSecretResponse? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutput? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolCallClientEventData? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolCallEvent? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolCallRequiredAction? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolConfigInput? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolConfigOutput? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolResultItem? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolResultItemErrorType? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimation? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimationEnterEffect? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimationExitEffect? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalCloseReason? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnFilterOperation? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>?>? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnUnit? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompileProceduresResponseModel? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompileProceduresValidationErrorResponseModel? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureValidationError>>? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureValidationError>? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureValidationError? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>>? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkInput? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComputedUsagePlatformLimit? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConditionStrength? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConfigEntityType? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConfirmChangeParams? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConflictResolutionChoice? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConflictSection? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.IList<object>, object>? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentConfig? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentThresholdGuardrail? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInput? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailExecutionMode? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction2? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallTriggerAction? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RetryTriggerAction? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminator? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutput? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction3? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminator? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StringSchema? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumberSchema? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntegerSchema? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageSchema? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSchema? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSchema? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectSchema? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchemaDiscriminator? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchemaDiscriminatorType? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentThresholdGuardrailThreshold? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContextualUpdateInfo? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContextualUpdateInputItem? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContextualUpdatePlacement? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Contributor? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIEnvVarLocator? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIFileUploadResponseModel? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAISecretLocator? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependencies? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem6>? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem6? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminator? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminatorType? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem>? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableAgentIdentifier? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownAgentIdentifier? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminator? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminatorType? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentPhoneNumberIdentifier? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem2>? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.McpServersItem2? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminator? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminatorType? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SecretDependencyType>? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecretDependencyType? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIUserSecretDBModel? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WebhookEventType>? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookEventType? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTranscriptFormat? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationASRUsageModel? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationChargingCommonModel? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMCategoryUsage? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformUsage? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTTSUsageModel? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigInput? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileInputConfig? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DTMFInputConfig? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOutput? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideInput? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigOverride? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOverride? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOverride? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideOutput? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideConfigInput? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigOverrideConfig? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOverrideConfig? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOverrideConfig? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideConfigOutput? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigWorkflowOverrideInput? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileInputConfigWorkflowOverride? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigWorkflowOverrideOutput? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationDeletionSettings? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationErrorType? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationFeedbackRequestModel? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserFeedbackScore? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationFeedbackType? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DataCollectionResultCommonModel>? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionResultCommonModel? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionResultCommonModel>? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSuccessResult? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ScopedAnalysisResult>? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScopedAnalysisResult? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryBatchCallModel? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryElevenAssistantCommonModel? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryErrorCommonModel? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CriteriaScoringMode? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryExotelPhoneCallModel? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryFeedbackCommonModel? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModel? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneCallVariant1? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1Discriminator? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryRagUsageCommonModel? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FeaturesUsageCommonModel? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationSource? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppConversationInfo? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMSConversationInfo? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceRewardModel>? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationVoiceRewardModel? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMultivoiceMessageModel? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryRedactionConfig? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConfigEntityType>? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableUpdateCommonModel>? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableUpdateCommonModel? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelInputRole? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserFeedback? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTurnMetrics? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagRetrievalInfo? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageInput? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptPlatformEvent? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationReasoningModel>? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationReasoningModel? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TriggeredGuardrailCommonModel>? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggeredGuardrailCommonModel? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutputRole? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageOutput? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel>? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultVariant1? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallToolResultModel? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageDetectionToolResultModel? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInput? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultErrorModel? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultSipSuccessModel? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultExotelSuccessModel? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultAmazonConnectSuccessModel? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultErrorModel? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SkipTurnToolResponseModel? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFResultSuccessModel? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFResultErrorModel? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceMailDetectionResultSuccessModel? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestToolResultModel? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolResultModel? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolResultModel? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolResultSuccessModel? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolResultErrorModel? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolResultSuccessModel? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolResultErrorModel? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DummyToolResultModel? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultVariant12? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutput? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallIntegrationFunctionDetails? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolType? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolDetailsVariant1? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolDetailsVariant12? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1Discriminator? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInput? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutput? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataInternal? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationSourceInfo? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableInternalValueType? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrchestratorToolMockBehaviorConfig? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigOutput>>? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigOutput>? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseMockConfigOutput? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataRequestOutput? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator>? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationProduct? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSentimentAnalysis? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSentimentAnalysisOverallLabel? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSignedUrlResponseModel? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ToolMockConfig>? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolMockConfig? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryMessageModel? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryMessageModelRole? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryResponseModel? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryResponseModelStatus? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EvaluationCriteriaSummaryResult>? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationCriteriaSummaryResult? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceUsageModel>? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationVoiceUsageModel? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTagResponseModel? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTokenPurpose? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTokenResponseModel? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTurn? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TextOutputItem>? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextOutputItem? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ClientToolCallRequiredAction>? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.MetricRecord>? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetricRecord? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationUserResponseModel? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SentimentAggregate? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.FrustratedConversationRef>? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FrustratedConversationRef? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfig? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigInput? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetInput>? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetInput? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VADConfig? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelOutput? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOutput? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetOutput>? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetOutput? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideInput? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigWorkflowOverride? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigWorkflowOverrideInput? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VADConfigWorkflowOverride? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideOutput? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigWorkflowOverrideOutput? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvertChapterResponseModel? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvertProjectResponseModel? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CrawlStatus? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CrawlType? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentBranchResponseModel? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentConversationRequest? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentConversationResponse? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentConversationTicketRequestModel? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentRequestModel>? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnCommentRequestModel? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentMergeProposalResponseModel? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentProcedureParams? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentResponseModel? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentRuleParams? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentTestFolderResponseModel? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentTestResponseModel? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAssetParams? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateBasicAuthRequest? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateBearerAuthRequest? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientAppointmentParams? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientInteractionParams? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientParams? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientSecretRequest? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInput? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExpiresAfter? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateConversationTagRequestModel? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateCrawlJobResponseModel? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateCustomHeaderAuthRequest? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentRequest? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateExotelPhoneNumberRequest? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelApiSubdomain? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateHolidayParams? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateLocationParams? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateMTLSAuthRequest? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateManualTicketRequestModel? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2ClientCredsRequest? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequest? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestJwtUsage? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderParams? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderRequest? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderResponse? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePhoneAssignmentRequest? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePhoneNumberResponseModel? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePrivateKeyJWTRequest? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProcedureRequestModel? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureType? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProcedureResponseModel? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProductParams? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProductQuoteRequestParams? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePronunciationDictionaryResponseModel? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateRealtimeConversationGroupRequestModel? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateResponseUnitTestRequest? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestFromConversationMetadataInput? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentSuccessfulResponseExample>? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentFailureResponseExample>? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InboundSIPTrunkConfigRequestModel? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundSIPTrunkConfigRequestModel? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSecretEnvironmentVariableRequest? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest>? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableSecretValueRequest? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateServiceParams? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateServiceQuoteRequestParams? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSimulationTestRequest? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationToolMockBehaviorConfig? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>>? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseMockConfigInput? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSpeechEngineRequest? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineConfig? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineAuthConfig? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineConversationInitiationClientDataConfig? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateStaffParams? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateStringEnvironmentVariableRequest? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTeamInviteRequest? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTeamInviteRequestRole? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateToolCallUnitTestRequest? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallEvaluationModelInput? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTransferRuleParams? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTwilioPhoneNumberRequest? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegionConfigRequest? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatifyAuroraRequest? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatifyAuroraRequestResolution? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CueOptionsRequest? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Currency? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailInput? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailsConfigInput? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailOutput? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailsConfigOutput? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfig? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigModel? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMServiceTier? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminator? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomGuardrailConfig>? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomHeaderAuthResponse? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomLLM? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator>? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator>? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentAuthConnectionLocator? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomLLMAPIType? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSIPHeader? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardCallSuccessChartModel? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardCriteriaChartModel? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardDataCollectionChartModel? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionValueSchema? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DataCollectionValueSchemaType?, global::System.Collections.Generic.IList<string>>? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionValueSchemaType? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DateModel? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupResponseModel? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupResponseModel? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentHoldAudioResponseModel? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentProcedureParams? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentRuleParams? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAssetParams? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteCalendarEventParams? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteChapterResponseModel? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteClientInteractionParams? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteClientParams? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteDubbingResponseModel? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteGroupSessionParams? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteHistoryItemResponse? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteHolidayParams? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteLocationParams? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteProductParams? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteProjectResponseModel? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteSampleResponseModel? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteServiceParams? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteStaffParams? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteTransferRuleParams? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteUserVoiceCollectionResponseModel? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteVoiceResponseModel? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteVoiceSampleResponseModel? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceGroupMemberResponseModel? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceInviteResponseModel? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceWebhookResponseModel? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeliverableInfo? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableAgentIdentifierAccessLevel? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentBranchInfo? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DetailedMusicResponse? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongMetadata? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WordTimestamp>? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WordTimestamp? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DetectedEntity? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeviceModel? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DialogueInputResponseModel? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModel? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReadMetadataChapterDBModel>? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReadMetadataChapterDBModel? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReadLegalTerms? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Contributor>? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelPayoutType? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PreviewAudioDBModel? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleConfigDBModel? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModel? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DiscountResponseModel? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DoDubbingResponseModel? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocumentUsageModeEnum? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocxExportOptions? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubOrderItemRequest? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbedSegment? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SegmentSubtitleFrame>? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentSubtitleFrame? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMediaReference? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkSegmentUpdateRequest? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingSegmentUpdateRequest>? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSegmentUpdateRequest? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkSourceSegmentUpdateResponse? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptSegment>? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptSegment? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkTargetSegmentUpdateRequest? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingTargetSegmentUpdateRequest>? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetSegmentUpdateRequest? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkTargetSegmentUpdateResponse? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTargetTranscriptSegment>? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetTranscriptSegment? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingError? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageListResponse? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingLanguageResponse>? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageResponse? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageOutputs? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageResponseStatus? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoicesNotPermittedWarning>? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicesNotPermittedWarning? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMediaMetadata? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMetadataPageResponseModel? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingMetadataResponse>? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMetadataResponse? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectListResponse? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingProjectResponse>? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectResponse? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectResponseStatus? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceMediaInfo? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingRegenerateResponse? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingReleaseChannel? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingRenderResponseModel? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingResource? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerTrack>? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerTrack? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerSegment>? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSegment? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.Render>? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Render? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSegmentCreateRequest? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceSegmentUpdateResponse? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceTranscriptResponse? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetSegmentUpdateResponse? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetTranscriptResponse? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscript? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptUtterance>? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptUtterance? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptCharacter? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptResponseModel? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptRevisionResponse? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptWord>? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptWord? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptCharacter>? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptsResponseModel? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DuplicateSpeechEngineRequest? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Eagerness? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditChapterResponseModel? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditProjectResponseModel? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditVoiceResponseModel? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditVoiceSettingsResponseModel? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditedTranscript? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EffectsSpecOutput? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25Request? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25RequestOutputFormat? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocator>? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocator? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25VoiceSettings? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenMultilingualV2Request? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TtsVoiceSettings? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3Request? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3RequestOutputFormat? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3VoiceSettings? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EmbedVariant? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EmbeddingModelEnum? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallToolConfig? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolConfig? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ProcedureVersionRef, global::ElevenLabs.ProcedureDraftRef>? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureDraftRef? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolErrorStatus? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EntryBehavior? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentResponse? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableAuthConnectionValue? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableResponse? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableResponseType? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableSecretValue? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariablesListResponse? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentVariableResponse>? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentsListResponse? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentResponse>? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationResultFilter? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExactParameterEvaluationStrategy? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigInput? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination7? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneDestinationInput? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneDynamicVariableDestinationInput? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigInputTransferDestinationDiscriminator? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigInputTransferDestinationDiscriminatorType? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigOutput? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination10? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneDestinationOutput? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneDynamicVariableDestinationOutput? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigOutputTransferDestinationDiscriminator? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigOutputTransferDestinationDiscriminatorType? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelOutboundCallResponse? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferInput? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Config3? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigInput? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferInputConfigDiscriminator? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferInputConfigDiscriminatorType? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferOutput? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Config5? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigOutput? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferOutputConfigDiscriminator? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferOutputConfigDiscriminatorType? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination2? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigInputTransferDestinationDiscriminator? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigInputTransferDestinationDiscriminatorType? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination3? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigOutputTransferDestinationDiscriminator? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigOutputTransferDestinationDiscriminatorType? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExperimentAssignment? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExperimentAssignmentSource? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentedJsonExportOptions? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PdfExportOptions? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TxtExportOptions? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HtmlExportOptions? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SrtExportOptions? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptionsDiscriminator? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptionsDiscriminatorFormat? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExtendedSubscriptionResponseModel? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, string>? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Price? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionStatusType? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModel? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModel>? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel>? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingSubscriptionSwitchResponseModel? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingCancellationResponseModel? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalFileSyncInfo? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncProvider? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalFolderSyncInfo? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncJobTrigger? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncJobType? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FeatureStatusCommonModel? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowFeaturesUsageCommonModel? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestsFeatureUsageCommonModel? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FieldConflict? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileContentPart? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Source? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileIdSource? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileContentPartSourceDiscriminator? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileContentPartSourceDiscriminatorType? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileRefreshStatus? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FineTuningResponseModel? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.FineTuningResponseModelState2>? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FineTuningResponseModelState2? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VerificationAttemptResponseModel>? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerificationAttemptResponseModel? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualVerificationResponseModel? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FinetuneCreatedBy? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FinetuneVisibility? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FirstMessageMode? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FlattenedConfigOverrides? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FocusGuardrail? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentCharacterResponseModel? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentResponseModel? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentWordResponseModel>? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentWordResponseModel? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FrustratedConversationRefOverallLabel? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1Request? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestQuality? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestBackground? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestAspectRatio? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15Request? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestQuality? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestBackground? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestAspectRatio? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequest? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestQuality? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestAspectRatio? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestResolution? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequest? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestQuality? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestAspectRatio? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestResolution? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2Request? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestQuality? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestAspectRatio? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestResolution? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini25FlashImageRequest? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini25FlashImageRequestAspectRatio? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequest? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequestAspectRatio? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequestResolution? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashLiteImageRequest? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequest? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequestAspectRatio? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequestResolution? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkInputContextAdherence? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkOutput? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkOutputContextAdherence? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationSourceContext? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferenceVideo? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentConfigParams? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentConversationTicketsPageResponseModel? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketResponseModel>? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentEmbedResponseModel? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigResponseModel? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgebaseSizeResponseModel? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentLinkResponseModel? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModel? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem>? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberTwilioResponseModel? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberExotelResponseModel? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminator? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetWhatsAppAccountResponse>? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWhatsAppAccountResponse? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ProcedureRefResponseModel>? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureRefResponseModel? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSubagentDependentsResponseModel? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem3>? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem3? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSubagentDependentsResponseModelAgentDiscriminator? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSubagentDependentsResponseModelAgentDiscriminatorType? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentBranchInfo>? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentTestFolderResponseModel? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentTopicsResponseModel? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTopicResponseModel>? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentsPageResponseModel? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentSummaryResponseModel>? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModel? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem4>? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem4? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModelAgentDiscriminator? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorType? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalyticsSummaryParams? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAppointmentByConfirmationNumberParams? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAudioIsolationHistoryResponseModel? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioIsolationHistoryItemResponseModel>? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAudioNativeProjectSettingsResponseModel? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetBookingPageSettingsParams? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetBookingSlugStatusParams? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetChaptersResponseModel? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterResponseModel>? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientAppointmentsParams? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientByPhoneParams? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientOrdersParams? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModel? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem2>? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChartsItem2? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminator? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAISettingsResponseModel? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LivekitStackType? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationResponseModel? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationResponseModelStatus? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VisitedAgentRef>? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VisitedAgentRef? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationSummaryResponseModel? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationSummaryResponseModelStatus? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryMessageModel>? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationTagsPageResponseModel? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationTagResponseModel>? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationUsersPageResponseModel? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationUserResponseModel>? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationsPageResponseModel? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryResponseModel>? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetCrawlJobResponseModel? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentChunkingOverrideResponseModel? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModel? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem5>? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem5? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseFileResponseModel? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentMetadataResponseModel? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DocumentUsageModeEnum>? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KbExternalSyncJob? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModel? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DocumentsItem>? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocumentsItem? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminator? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem3>? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem3? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminator? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem5>? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem5? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminator? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem4>? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem4? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminator? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem2>? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem2? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminator? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseTextResponseModel? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseURLResponseModel? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetLibraryVoicesResponseModel? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LibraryVoiceResponseModel>? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceResponseModel? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetLiveCountResponse? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrderByConfirmationNumberParams? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberAgentInfo? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberInboundSIPTrunkConfigResponseModel? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPMediaEncryptionEnum? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberOutboundSIPTrunkConfigResponseModel? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkTransportEnum? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MediaCodec>? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaCodec? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModel? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem3>? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem3? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminator? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetProjectsResponseModel? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectResponseModel>? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionariesMetadataResponseModel? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModel? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetResponseUnitTestResponseModel? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestFromConversationMetadataOutput? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSIPLogMessagesResponse? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SIPLogMessage>? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPLogMessage? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetScheduleParams? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModel? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependenciesVariant1Item? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminator? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependenciesVariant2Item? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminator? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSimulationTestResponseModel? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistoryResponseModel? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechHistoryItemResponseModel>? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModel? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestInvocationsPageResponseModel? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseMeta? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestInvocationSummaryResponseModel>? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestInvocationSummaryResponseModel? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestSuiteInvocationResponseModel? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestRunResultSummary>? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunResultSummary? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestRunResponseModel>? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModel? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestsPageResponseModel? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestSummaryResponseModel>? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestSummaryResponseModel? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestsSummariesByIdsResponseModel? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.UnitTestSummaryResponseModel>? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolCallUnitTestResponseModel? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallEvaluationModelOutput? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModel? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem2>? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem2? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminator? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminatorType? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolExecutionsPageResponseModel? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolExecutionResponseModel>? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModel? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetUserVoiceCollectionsResponseModel? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UserVoiceCollectionResponseModel>? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserVoiceCollectionResponseModel? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoiceAccentsResponseModel? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceAccentResponseModel>? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceAccentResponseModel? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoicesResponseModel? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceResponseModel>? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModel? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoicesV2ResponseModel? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppAccountType? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWorkspacePlanParams? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWorkspaceSecretsResponseModel? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailClassifierVerdict? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailLLMVerdict? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailType? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailUnknownVerdict? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsResult? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptInjectionGuardrail? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationGuardrailInput? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationGuardrailOutput? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HTTPValidationError? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ValidationError>? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ValidationError? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HidingReason? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HistoryAlignmentResponseModel? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HistoryAlignmentsResponseModel? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HolidayResponseModel? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HolidayType? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeRangeModel? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeOffType? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HttpRequestModel? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UrlModel? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Icon? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IconTheme? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysis? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysisStatus? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysisResult? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageSubject>? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageSubject? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAvatar? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequest? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequestDiscriminator? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineImageReference? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReferenceDiscriminator? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReferenceDiscriminatorType? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkCredentialsRequestModel? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IngestFailure? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineAudioReferenceMimeType? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineBase64Reference? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineBase64ReferenceMimeType? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineImageReferenceMimeType? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineVideoReference? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineVideoReferenceMimeType? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntakeQuestionKind? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntegrationType? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InternalSamplingConfigResponseModel? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntervalPlacement? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DiscountResponseModel>? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModelPaymentIntentStatus? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDeletedResponseModel? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResponseModel? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseContentSearchResult>? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResult? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Document? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminator? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminatorType? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchHighlightSegment>? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchHighlightSegment? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDependentType? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentChunksResponseModel? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel>? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseLocator? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagChunkModel? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolConfig? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolStatus? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseRagChunkModel>? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSortBy? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSourceFileUrlResponseModel? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Data? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminator? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolConfig? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchStrategy>? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolInfo? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolStatus? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeSourceStatus? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeSourceType? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMDeprecationConfigModel? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMDeprecationInfoModel? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMInfoModel? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMReasoningEffort>? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMReasoningEffort? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMServiceTier>? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegionalProcessingSurchargeInfo? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMInputOutputTokensUsage? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMTokensCategoryUsage? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMListResponseModel? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMInfoModel>? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMLiteralJsonSchemaPropertyType? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMParameterEvaluationStrategy? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LLMInputOutputTokensUsage>? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorLLMResponseModel? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorPublicRequestModel? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorRequestModel? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorResponseModel? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageAddedResponse? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageDetectionToolConfig? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageInfo? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePairInfo? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguageInfo>? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetTranslation? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageResponseModel? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponse? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PairedLanguagesResponse? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleLanguagesResponse? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponseDiscriminator? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponseDiscriminatorKind? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeadDeliveryViewStage? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeadDetailResponse? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TerminalDisposition? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeaveMessageParams? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceResponseModelCategory? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerifiedVoiceLanguageResponseModel? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentProceduresParams? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentReferencesParams? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentRulesParams? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAssetsParams? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponse? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AuthConnectionsItem>? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionsItem? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2ClientCredsResponse? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshTokenAuthResponse? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponse? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivateKeyJWTResponse? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MTLSAuthResponse? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppAuthResponse? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SlackBotAuthResponse? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UrlSecretAuthResponse? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminator? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCalendarEventsParams? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListClientInteractionsParams? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListClientsParams? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCrawlJobsResponseModel? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetCrawlJobResponseModel>? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCustomerFacingAgentsParams? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListGroupSessionsParams? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListHolidaysParams? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListLocationsParams? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListMCPToolsResponseModel? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Tool>? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Tool? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolApprovalStatus>? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalStatus? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListOrdersResponse? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderSummary>? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderSummary? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListProceduresResponseModel? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureListItemResponseModel>? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureListItemResponseModel? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListProductsParams? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseAgentBranchSummary? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentBranchSummary>? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseAgentDeploymentHistoryItem? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentDeploymentHistoryItem>? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListServicesParams? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListSpeechEnginesResponse? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechEngineSummaryResponse>? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineSummaryResponse? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListStaffParams? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTestsByIdsRequestModel? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTransferRulesParams? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListWhatsAppAccountsResponse? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LiteralJsonSchemaPropertyType? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LockReason? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovalPolicy? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovalPolicyUpdateRequestModel? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovedToolDefinition? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigInput? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolApprovalHash>? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalHash? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerTransport? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator>? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel>? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverrideInput>? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInput? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigOutput? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverrideOutput>? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutput? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigUpdateRequestModel? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerMetadataResponseModel? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerRequestModel? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModel? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem>? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminator? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminatorType? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServersResponseModel? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPServerResponseModel>? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolAddApprovalRequestModel? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalPolicy? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalState? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInput? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant1? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminator? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutput? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant12? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminator? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ToolCallSoundType?, string>? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant13? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminator? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminatorSource? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant14? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminator? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModel? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant15? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModel? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant16? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualVerificationFileResponseModel? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ManualVerificationFileResponseModel>? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MatchAnythingParameterEvaluationStrategy? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationCompletedResponse? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationCreateResponse? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationFailedResponse? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationFailedResponseFailureReason? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationInProgressResponse? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationInProgressResponseStatus? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationListResponse? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MediaGenerationResponse>? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponse? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponseDiscriminator? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeAgentConversationTicketsRequestModel? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModel? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem2>? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem2? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminator? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminatorProvider? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.FieldConflict>? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReviewReviewerRole? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalStatus? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessageSearchSortBy? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessagesSearchResponse? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MessagesSearchResult>? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessagesSearchResult? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetricType? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetronomeUsageColumnFilterColumn? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetronomeUsageColumnFilterOperation? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MockNoMatchBehavior? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MockingStrategy? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModelRatesResponseModel? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModelResponseModel? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguageResponseModel>? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationConfig? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ThresholdGuardrail? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModel? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModelSafetyStatus? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModelWarningStatus? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MultichannelSpeechToTextResponseModel? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextChunkResponseModel>? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModel? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MultipartMusicResponse? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicAllowedOutputFormats? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicOnlyOutputFormats? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicExploreSongSourceContext? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneFailureReason? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetunePageResponseModel? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MusicFinetuneResponseModel>? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneResponseModel? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneStatus? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicOutputFormat? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SongSection>? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongSection? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicUploadResponse? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NonStreamingOutputFormats? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumericDistributionAggregate? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumericUniformScoring? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseAlgorithm? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseTokenResponseField? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseJwtUsage? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelAttribute? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, bool?, double?>? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelResource? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelAttribute>? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelResourceSpans? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelScopeSpans>? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelScopeSpans? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelScope? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelSpan>? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelSpan? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelStatus? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelTracePayload? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelResourceSpans>? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyInputPropertyKind? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequiredConstraints? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ContentSchema>? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioConfigInput? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputConfigInput? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputConfigInput? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioConfigOutput? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputConfigOutput? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputConfigOutput? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputFormat? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputTranscription? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAITurnDetection? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputFormat? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIFunctionTool? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIMCPTool? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIMCPToolRequireApproval? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeModel? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem>? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInputToolDiscriminator? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInputToolDiscriminatorType? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.OpenAIToolChoiceFunction>? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIToolChoiceFunction? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.OpenAITurnDetection, string>? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<string, global::ElevenLabs.OpenAITracingConfiguration>? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAITracingConfiguration? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem4>? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem4? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminator? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminatorType? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIToolChoiceFunctionInner? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnDetectionType? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OptInSmsReminderParams? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OptOutSmsReminderParams? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrbAvatar? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderDeliverablesResponse? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DeliverableInfo>? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderFulfillmentType? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemInfo? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutput? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QuoteInfo? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemKind? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInput? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubtitleOrderItemRequest? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptionOrderItemRequest? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInputDiscriminator? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInputDiscriminatorKind? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutputDiscriminator? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderMediaResponse? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderResponse? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderState? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderItemInfo>? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerGetClientAppointmentsParams? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListAssetsParams? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListLocationsParams? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListProductsParams? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListServicesParams? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListStaffParams? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PaginatedResultAgentMergeProposalResponse? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentMergeProposalResponse>? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguagePairInfo>? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchAgentConversationTicketRequestModel? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequest? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem>? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChartsItem? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminator? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAISettingsRequest? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConversationTagRequestModel? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchWorkspaceSecretRequest? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchWorkspaceWebhookResponseModel? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PauseAllCampaignsResponse? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingBlocksMetadataModel? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingClipTask? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingClipTaskType? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingExternalAudiosMetadataModel? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneChannelConfigInput? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneVoiceConfigInput? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneVoiceConfigOutput? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberSortBy? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransfer? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem>? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminator? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferDestination? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPUriTransferDestination? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPUriDynamicVariableTransferDestination? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminator? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminatorType? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferTypeEnum? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UUITransferConfig? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant1? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsStatic? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsDynamicVariable? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1Discriminator? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionConfig? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformCategory? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformCategoryUsage? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformLimits? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StoredUsagePlatformLimit? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.PlatformCategoryUsage>? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFToolConfig? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastBulletinModeData? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastConversationModeData? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastProjectResponseModel? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PositionInput? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PositionOutput? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostAgentAvatarResponseModel? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostAgentHoldAudioResponseModel? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostWorkspaceSecretRequest? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostWorkspaceSecretResponseModel? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PricingMode? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivateKeyJWTResponseAlgorithm? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureAtVersionResponseModel? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureDraftResponseModel? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaResponseModel? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaResponseModelStatus? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaType? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModel? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelTargetAudience? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelState? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelAccessLevel? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelFiction? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelSourceType? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.CaptionStyleModel>? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelAspectRatio? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioAgentSettingsModel? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionResponseModel? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryLocatorResponseModel? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVideoResponseModel? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModel? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectImageResponseModel? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVoiceResponseModel>? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVoiceResponseModel? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SourceContextVariant1? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongSourceContext? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SfxSourceContext? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectMutedTracksResponseModel? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelTargetAudience? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelState? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelAccessLevel? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelFiction? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelSourceType? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelAspectRatio? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotExtendedResponseModel? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotResponseModel? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotsResponseModel? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectSnapshotResponseModel>? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysis? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromotionTarget? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigInput? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLlmConfig? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminator? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem2>? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem2? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolConfigInput? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfig? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminator? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminatorType? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigOutput? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLlmConfig2? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem5>? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem5? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolConfigOutput? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminator? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigWorkflowOverrideInput? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride>? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item>? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsVariant1Item? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminator? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigWorkflowOverrideOutput? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item2>? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsVariant1Item2? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryRulesResponseModel? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceResponse? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSubscription? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteResult>? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteResult? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceSubscription? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriod? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryArrayJsonSchemaPropertyInput? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryArrayJsonSchemaPropertyInputPropertyKind? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryArrayJsonSchemaPropertyOutput? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryParamsJsonSchemaInput? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.QueryArrayJsonSchemaPropertyInput>? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryParamsJsonSchemaOutput? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.QueryArrayJsonSchemaPropertyOutput>? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexResponseModel? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexStatus? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexUsage? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexesResponseModel? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RAGDocumentIndexResponseModel>? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexBatchSuccessfulResponseModel? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexOverviewResponseModel? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel>? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexRequestModel? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagChunkMetadata? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RagChunkMetadata>? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReaderResourceResponseModel? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReaderResourceResponseModelResourceType? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupResponseModel? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupSharingSummary? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupSharingSummaryEveryoneRole? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupsResponseModel? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RealtimeConversationGroupResponseModel>? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReassignPhoneRequest? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionAddOn? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionAdjustProductStockRequest? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionAgentInfoResponse? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionAgentInfoResponseCurrency? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkingHours? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceNow? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionAssetResource? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionGroupMembership>? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionGroupMembership? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionConfirmServiceUpdateRequest? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionIntakeQuestion>? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionIntakeQuestion? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionServiceVariant>? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionServiceVariant? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionServiceKind? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ServiceLocationType? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionAddOn>? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionServicePromotion>? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionServicePromotion? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateAgentRuleRequest? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateAssetRequest? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateHolidayRequest? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateProcedureRequest? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateProductRequest? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderFulfillmentType>? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateServiceRequest? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateStaffRequest? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateTransferRuleRequest? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCustomerFacingAgentDeactivationReason? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCustomerFacingAgentResponse? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCustomerFacingConfigOutput? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionWidgetAppearance? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionTurnEagerness? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentRule>? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionTransferRule>? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionTransferRule? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionProcedure>? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionProcedure? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCustomerFacingConfigPatch? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionKnowledgeSource? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionLocationDeactivationReason? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionLocationRequest? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionLocationRequestPatch? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionLocationResponse? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionPhoneAssignment? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionPhoneProvider? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionPhoneAssignmentDeactivationReason? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionPhoneRegulatoryStatus? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionProcedureResponse? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionProduct? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionProvisionResellerWorkspaceRequest? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionVertical? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteRequest>? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteRequest? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionService? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionServiceUpdateResponse? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionStaffResource? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionTeamInviteResponse? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionTeamMemberResponse? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateAgentInfoRequest? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateAgentInfoRequestCurrency? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateAgentRuleRequest? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateAssetRequestPatch? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateCustomerFacingAgentRequest? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateHolidayRequestPatch? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateProcedureRequest? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateProductRequestPatch? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateProductStockRequest? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateServiceRequestPatch? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateStaffRequestPatch? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateTransferRuleRequest? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionWidgetAppearanceVariant? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionWidgetAppearancePlacement? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RecordingResponseModel? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioClipLocator? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferencedToolCommonModel? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferencedToolCommonModelType? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegexParameterEvaluationStrategy? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioRegionId? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioEdgeLocation? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegisterForGroupSessionParams? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegisterMediaResponse? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RemoveOrderItemResponse? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RemoveVoiceFromUserVoiceCollectionResponseModel? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RenderStatus? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReplaceWorkspaceConfigRequest? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReplicateVoiceToIsolatedEnvironmentRequestModel? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReplicateVoiceToIsolatedEnvironmentResponseModel? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReportKnowledgeGapParams? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequestPVCManualVerificationResponseModel? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequiredConstraint? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RequiredConstraint>? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceDetail? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceStatus? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerInvoiceLine>? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceLine? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceLineKind? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceSummary? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoicesResponse? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerInvoiceSummary>? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerTierEconomics? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerTierResponse? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerTierResponseCurrency? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerUpcomingPayment? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerUpcomingPaymentsResponse? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerUpcomingPayment>? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceOnboardingResponse? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSubscriptionBillingPeriod? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSummary? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspacesResponse? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerWorkspaceSummary>? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoRole? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoAnonymousAccessLevelOverride? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoAccessSource? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceMetadataResponseModel? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ShareOptionResponseModel>? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ShareOptionResponseModel? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseConversationErrorType? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseFilter? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseUnitTestModel? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RestoreCalendarEventParams? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResubmitTestsRequestModel? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModelReviewStatus? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RunAgentTestsRequestModel? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SingleTestRunRequestModel>? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleTestRunRequestModel? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RunConversationEvaluationsRequest? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigInput? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination12? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigInputTransferDestinationDiscriminator? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorType? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigOutput? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination13? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminator? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminatorType? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigInput? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem2>? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem2? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigInputCustomSipHeaderDiscriminator? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigInputCustomSipHeaderDiscriminatorType? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination4? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SipUriDestinationInput? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SipUriDynamicVariableDestinationInput? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminator? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigOutput? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem3>? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem3? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigOutputCustomSipHeaderDiscriminator? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigOutputCustomSipHeaderDiscriminatorType? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination5? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SipUriDestinationOutput? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SipUriDynamicVariableDestinationOutput? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigOutputTransferDestinationDiscriminator? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPLogMessageDirection? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferInput? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Config? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferInputConfigDiscriminator? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferInputConfigDiscriminatorType? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferOutput? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Config2? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferOutputConfigDiscriminator? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferOutputConfigDiscriminatorType? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkOutboundCallResponse? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBClientAccessConfig? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchClientsParams? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendCustomEmailParams? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateClientParams? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateStaffParams? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAssetParams? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateServiceParams? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateProductParams? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderParams? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScheduleGroupSessionParams? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateGroupSessionSeatsParams? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateCalendarEventParams? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentRuleParams? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTransferRuleParams? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentProcedureParams? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateHolidayParams? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitBusinessInfoParams? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBusinessInfoParams? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentConfigParams? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBookingPageSettingsParams? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBookingPageAppearanceParams? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SetBookingSlugParams? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateLocationParams? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerUserVerificationParams? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ValidateUserVerificationCodeParams? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfigParamsDiscriminator? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMSConversationInfoDirection? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyCommonModelInput? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyEvaluation? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SafetyRule>? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyRule? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleConfigDBModelParentType? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleResponseModel? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSeparationResponseModel? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScimGroupResponseModel? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecretDependencyResourceType? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SectionSource? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TimeRange>? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentCreatePayload? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentCreateResponse? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentDeleteResponse? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentDubResponse? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentMigrationResponse? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentTranscriptionResponse? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentTranslationResponse? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentUpdatePayload? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentUpdateResponse? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SelfSubagent? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SelfSubagentExecutionMode? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageRequest? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InputItem>? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputItem? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserMessageInputItem? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageRequestInputItemDiscriminator? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageRequestInputItemDiscriminatorType? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageStreamRequest? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InputItem2>? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputItem2? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageStreamRequestInputItemDiscriminator? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageStreamRequestInputItemDiscriminatorType? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SetConversationGroupRequestModel? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ShareOptionResponseModelType? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimilarVoice? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceCategory? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimilarVoicesForSpeakerResponse? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SimilarVoice>? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationTestModel? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleUseTokenResponseModel? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleUseTokenType? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SkipTurnToolConfig? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfig? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigOverride? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigOverrideConfig? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigWorkflowOverride? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SortDirection? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerAudioResponseModel? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerCreatedResponse? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerResponseModel? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UtteranceResponseModel>? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UtteranceResponseModel? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbedSegment>? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSeparationResponseModelStatus? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerResponseModel>? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerUpdatedResponse? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineResponse? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelVoiceCategory? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelState? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelSource? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInputResponseModel>? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextCharacterResponseModel? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextWordResponseModel>? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWordResponseModel? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AdditionalFormatResponseModel?>? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DetectedEntity>? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditedTranscriptVariant1? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptEditError? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1Discriminator? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWebhookResponseModel? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWordResponseModelType? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextCharacterResponseModel>? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartPVCVoiceTrainingResponseModel? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolConfig? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolErrorStatus? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartSpeakerSeparationResponseModel? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StopAllCampaignsResponse? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamEndedData? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamEndedEvent? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamEnvelope? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Event? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamEnvelopeEventDiscriminator? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamEnvelopeEventDiscriminatorType? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamingAudioChunkWithTimestampsResponseModel? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.StudioAgentToolSettingsModel>? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioAgentToolSettingsModel? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioClipLocatorClipType? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubAgentInput? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubAgentInputExecutionMode? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubAgentOutput? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubAgentOutputExecutionMode? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SubAgentInput>? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SubAgentOutput>? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitCampaignRecipient? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitCampaignRequest? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SubmitCampaignRecipient>? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChannelConfig2? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitWhatsAppChannelConfig? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitCampaignRequestChannelConfigDiscriminator? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitCampaignRequestChannelConfigDiscriminatorChannel? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitCampaignResponse? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitOrderResponse? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModeConfig2? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppVoiceConfig? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitWhatsAppMessageConfig? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitWhatsAppChannelConfigModeConfigDiscriminator? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitWhatsAppChannelConfigModeConfigDiscriminatorMode? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitWhatsAppTemplateRef? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionExtrasResponseModel? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionUsageResponseModel? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionResponseModel? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SuggestedAudioTag? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SupportedVoice? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSModelFamily? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SuppressLeadResponse? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params2? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolConfigInput? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberToolConfigInput? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicemailDetectionToolConfig? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInputParamsDiscriminator? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params3? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolConfigOutput? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberToolConfigOutput? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutputParamsDiscriminator? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalModel? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SupportedVoice>? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SuggestedAudioTag>? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSOutputFormat? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextNormalisationType? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteOutcome? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteRequestRole? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateArrayOutput? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunStatus? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateArrayOutputFailureReason? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateOutput>? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutput? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateAudioOutput? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateAudioOutputFailureReason? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateBooleanOutput? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateBooleanOutputFailureReason? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateImageOutput? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateImageOutputFailureReason? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReference? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceReference? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReferenceDiscriminator? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReferenceDiscriminatorType? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateIntegerOutput? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateIntegerOutputFailureReason? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateListResponse? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateSummary>? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateSummary? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateNumberOutput? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateNumberOutputFailureReason? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateObjectOutput? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateObjectOutputFailureReason? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateOutput>? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVideoOutput? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateStringOutput? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutputDiscriminator? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutputDiscriminatorType? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplatePort? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunCreateRequest? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateRunInput>? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunInput? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunListResponse? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunResponse>? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunResponse? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateStringOutputFailureReason? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateVersion>? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVersion? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplatePort>? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVideoOutputFailureReason? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestConditionRationaleCommonModel? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestConditionResultCommonModel? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunMetadata? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunMetadataTestType? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunResultBucket? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunStatus? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestRunResultBucket>? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestSharingMode? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestType? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextContentPart? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequest? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequestDiscriminator? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSearchMatchField? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TokenResponseModel? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecution? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Icon>? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolAnnotations? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallUnitTestModel? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionTaskSupport? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallDetailsVariant1? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1Discriminator? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModel? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolConfig? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModelToolConfigDiscriminator? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestToolCallParameter>? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameter? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModel? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolConfig2? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModelToolConfigDiscriminator? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolUsageStatsResponseModel? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolSortBy? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolTypeFilter? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsResponseModel? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseModel>? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicEvaluationCriteriaAggregate? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicSentimentAggregate? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TopicEvaluationCriteriaAggregate>? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicSortBy? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoConfigured? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoDefaultingToMain? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoTrafficSplit? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferRuleInput? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProviderConfigsItem>? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProviderConfigsItem? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferInput? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferRuleInputProviderConfigDiscriminator? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferRuleInputProviderConfigDiscriminatorType? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferRuleOutput? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProviderConfigsItem2>? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProviderConfigsItem2? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferOutput? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferRuleOutputProviderConfigDiscriminator? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferRuleOutputProviderConfigDiscriminatorType? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTransferInput>? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTransferOutput>? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchInfoVariant1? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1Discriminator? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchInfoVariant12? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1Discriminator? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumberTransfer>? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TransferRuleInput>? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TransferRuleOutput>? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.GuardrailLLMVerdict, global::ElevenLabs.GuardrailClassifierVerdict, global::ElevenLabs.GuardrailUnknownVerdict>? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioAnsweredBy? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigInput? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination8? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigInputTransferDestinationDiscriminator? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigInputTransferDestinationDiscriminatorType? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant13? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigInputPostDialDigitsVariant1Discriminator? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigInputPostDialDigitsVariant1DiscriminatorType? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutput? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination11? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutputTransferDestinationDiscriminator? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutputTransferDestinationDiscriminatorType? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant15? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutputPostDialDigitsVariant1Discriminator? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutputPostDialDigitsVariant1DiscriminatorType? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionAction? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionMode? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TwilioMachineDetectionRule>? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionRule? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TwilioAnsweredBy>? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioOutboundCallResponse? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Config4? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInput? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferInputConfigDiscriminator? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferInputConfigDiscriminatorType? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Config6? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferOutputConfigDiscriminator? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferOutputConfigDiscriminatorType? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination14? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInputTransferDestinationDiscriminator? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInputTransferDestinationDiscriminatorType? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant16? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInputPostDialDigitsVariant1Discriminator? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInputPostDialDigitsVariant1DiscriminatorType? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination15? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminator? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminatorType? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant17? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutputPostDialDigitsVariant1Discriminator? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutputPostDialDigitsVariant1DiscriminatorType? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.URLAvatar? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestGuardrailTriggerEvaluationModel? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestInfoVariant1? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1Discriminator? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestWorkflowNodeTransitionEvaluationNodeId? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Eval? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminator? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsRequestModel? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemAttachmentDestination>? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModel? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResultsItem3>? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultsItem3? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminator? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBasicAuthRequest? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBearerAuthRequest? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentChunkingOverrideRequestModel? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentChunkingOverrideResponseModel? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateEnvironmentVariableRequest? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMemberUsageLimitRequestModel? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMemberUsageLimitResponseModel? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMusicFinetuneRequestModel? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMusicFinetuneRequestModelVisibility? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2ClientCredsRequest? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequest? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestJwtUsage? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderResponse? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRequest? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateProcedureDraftRequestModel? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateRealtimeConversationGroupRequestModel? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateResponseUnitTestRequest? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateSimulationTestRequest? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateSpeechEngineRequest? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTestSuiteInvocationRequestModel? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateToolCallUnitTestRequest? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateWhatsAppAccountRequest? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateWorkspaceMemberResponseModel? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpsertOrderItemResponse? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsageAggregationInterval? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsageCharactersResponseModel? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserDataCollectionAnalysisItemInput? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Scoring? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminator? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminatorMode? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ContentItem>? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentItem? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserMessageInputItemContentItemDiscriminator? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserMessageInputItemContentItemDiscriminatorType? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserResponseModel? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserVoiceCollectionResponseModelPermissionOnResource? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsersSortBy? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?>? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequest? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequestAspectRatio? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequestResolution? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VeoImageReference>? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VeoImageReference? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31Request? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31RequestAspectRatio? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31RequestResolution? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VeoImageReferenceRole? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerifyPVCVoiceCaptchaResponseModel? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysisStatus? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysisResult? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoSubject>? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSubject? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoSegment>? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSegment? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoKeyMoment>? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoKeyMoment? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequest? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequestDiscriminator? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReferenceDiscriminator? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReferenceDiscriminatorType? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceDesignRequestModel? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceDesignRequestModelModelId? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewResponseModel? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewsRequestModel? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewsResponseModel? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoicePreviewResponseModel>? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceRemixRequestModel? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SampleResponseModel>? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelCategory? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModel? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelSafetyControl? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceVerificationResponseModel? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelRecordingQuality? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelLabellingStatus? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSamplePreviewResponseModel? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSampleVisualWaveformResponseModel? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingModerationCheckResponseModel? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelStatus? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelCategory? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelReviewStatus? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReaderResourceResponseModel>? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WatermarkCheck? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WatermarkDetails? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookAuthMethodType? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookOutcome? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookSendResultResponseModel? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetAll? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetIds? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetDiscriminator? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetDiscriminatorType? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInput? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInputContentType? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutput? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutputContentType? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookUsageType? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppCallPermissionRequest? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppCallPermissionRequestState? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModeConfig? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppMessageConfig? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppChannelConfigModeConfigDiscriminator? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppChannelConfigModeConfigDiscriminatorMode? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppConversationInfoDirection? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppRecipient? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOpeningMessage? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplate? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOutboundCallResponse? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOutboundMessageResponse? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateParameterFormat? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateComponent>? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateComponent? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateTextParam>? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateTextParam? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateComponentButton>? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateComponentButton? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateDocumentParam? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateDocumentParamDetails? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ParametersItem>? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ParametersItem? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateImageParam? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateLocationParam? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminator? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateImageParamDetails? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateLocationParamDetails? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetPlacement? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetExpandable? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetFeedbackMode? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetEndFeedbackConfig? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigInputSyntaxHighlightTheme? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTextContents? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetStyles? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WidgetLanguagePreset>? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetLanguagePreset? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigOutputSyntaxHighlightTheme? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigResponseModelSyntaxHighlightTheme? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WidgetLanguagePresetResponse>? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetLanguagePresetResponse? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetEndFeedbackType? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTextContentsTranslation? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTermsTranslation? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForwardConditionVariant1? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUnconditionalModelInput? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowLLMConditionModelInput? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowResultConditionModelInput? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowExpressionConditionModelInput? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1Discriminator? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackwardConditionVariant1? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PositionInput>? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForwardConditionVariant12? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUnconditionalModelOutput? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowLLMConditionModelOutput? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowResultConditionModelOutput? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowExpressionConditionModelOutput? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackwardConditionVariant12? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1Discriminator? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PositionOutput>? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeOutcome? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem4>? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem4? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminator? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination6? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminator? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant12? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1Discriminator? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProviderConfigsItem3>? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProviderConfigsItem3? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminator? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem5>? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem5? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination9? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminator? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant14? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProviderConfigsItem4>? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProviderConfigsItem4? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminator? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolEdgeStepModel? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocator? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SchemaOverridesVariant1? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminator? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminatorSource? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNestedToolsStepModelInput? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkflowToolLocator>? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem>? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StepsItem? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminator? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem2>? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StepsItem2? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminator? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>>? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>>? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ColumnUnit?>? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceApiKeyListResponseModel? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceApiKeyResponseModel>? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceApiKeyResponseModel? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAuditLogEntryResponse? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAuditLogsPageResponse? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAuditLogEntryResponse>? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceBatchCallsResponse? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BatchCallResponse>? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceConfigResponse? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateApiKeyResponseModel? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateServiceAccountResponseModel? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateWebhookResponseModel? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupByNameResponseModel? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupPermission? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupPermission>? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceMemberResponseModel? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceServiceAccountListResponseModel? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceServiceAccountResponseModel>? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceServiceAccountResponseModel? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupResponseModel>? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookListResponseModel? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookResponseModel>? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookResponseModel? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookUsageResponseModel? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationNode? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateOAuth2ClientCredsRequest, global::ElevenLabs.UpdateBasicAuthRequest, global::ElevenLabs.UpdateBearerAuthRequest, global::ElevenLabs.UpdateOAuth2JWTRequest>? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateExotelPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UserEvaluationAnalysisItem, global::ElevenLabs.UserDataCollectionAnalysisItemInput>? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequest? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminator? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistorySortDirection? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistorySource? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechFullOutputFormat? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechStreamOutputFormat? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToSpeechFullOutputFormat? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToSpeechStreamOutputFormat? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectListSortDirection? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingStatus? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingStatusesVariant1Item? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingModelsVariant1Item? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsCreationSourcesVariant1Item? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsFilterByCreator? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsOrderBy? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsOrderDirection? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDubbedTranscriptFileFormatType? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDubbingTranscriptsFormatType? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionariesMetadataSort? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestType>? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListChatResponseTestsRouteSortMode? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoriesRouteSummaryMode? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item>? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GuardrailType>? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoryRouteFormat? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item>? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketSource>? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketPriority>? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolTypeFilter>? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CampaignStatus>? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCampaignsMode? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCampaignLeadsStatus? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TerminalDisposition>? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallResult>? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCampaignCallsStage? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListEnvironmentVariablesType? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerateOutputFormat? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComposeDetailedOutputFormat? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComposeDetailedStreamOutputFormat? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamComposeOutputFormat? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetFinetunesSort? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetFinetunesSortDirection? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderState>? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListVideoGenerationsStatus? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListImageGenerationsStatus? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTextToSpeechGenerationsStatus? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DownloadSpeechHistoryItemsResponse? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DubbingTranscriptResponseModel, string>? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ModelResponseModel>? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponse? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponseDiscriminator? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponse? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponseDiscriminator? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkspaceGroupResponseModel>? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupByNameResponseModel>? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceMemberResponseModel>? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponse2? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminator? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminatorStatus? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponse? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminator? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponse? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminator? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AssignableUserResponseModel>? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItem? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminator? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponse? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminator? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminatorProvider? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponse? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminator? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminatorProvider? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponse2? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponse? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponseDiscriminator? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponse? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminator? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponse? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminator? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminatorType? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponse2? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminator? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponse? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminator? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponse2? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminator? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionService>? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionAssetResource>? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionProduct>? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionStaffResource>? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionCustomerFacingAgentResponse>? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionProcedureResponse>? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionPhoneAssignment>? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.HolidayResponseModel>? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionLocationResponse>? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionKnowledgeSource>? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerTierResponse>? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionTeamMemberResponse>? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionTeamInviteResponse>? Type3180 { get; set; }

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
        public global::System.Collections.Generic.List<global::ElevenLabs.CallingPeriod>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DateOverride>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentResponseAttachment>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AttachedTestModel>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResourceAccessInfo>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemVersionResponseModel>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemResponseModel>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ObjectJsonSchemaPropertyInput>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ObjectJsonSchemaPropertyOutput>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableAssignment>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AssetResponse>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AttentionView>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioSegment>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioKeyMoment>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioEffectsFilterPresetResponseModel>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioEffectsEnvironmentResponseModel>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceSegment>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem3>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.McpServersItem>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentIntegrationConnectionIdentifier>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AllowlistItem>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Llm>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OutboundCallRecipientResponseModel>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetOrCreateRAGIndexRequestModel>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MetronomeUsageColumnFilter>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ColumnFilter>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConflictResolution>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateParamsItem>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PromptEvaluationCriteria>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OutboundCallRecipient>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DialogueInput>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookEventType>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>, string>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupConfig>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ImageReference>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoReference>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioReference>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CallingIntervalPolicy>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CallView>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LeadView>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CampaignResponse>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CallingPeriodPolicy>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DateOverridePolicy>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockInputModel>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockResponseModel>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CharacterAlignmentModel>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterSnapshotResponseModel>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceStatisticsResponseModel>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>?>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ProcedureValidationError>>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProcedureValidationError>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.List<object>, object>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem6>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.McpServersItem2>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SecretDependencyType>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WebhookEventType>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ClientEvent>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DataCollectionResultCommonModel>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ScopedAnalysisResult>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceRewardModel>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConfigEntityType>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableUpdateCommonModel>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationReasoningModel>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TriggeredGuardrailCommonModel>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigOutput>>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigOutput>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceUsageModel>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TextOutputItem>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ClientToolCallRequiredAction>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.FrustratedConversationRef>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TurnCommentRequestModel>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentSuccessfulResponseExample>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentFailureResponseExample>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigInput>>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigInput>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomGuardrailConfig>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DataCollectionValueSchemaType?, global::System.Collections.Generic.List<string>>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WordTimestamp>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReadMetadataChapterDBModel>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Contributor>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SegmentSubtitleFrame>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptSegment>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTargetTranscriptSegment>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingLanguageResponse>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoicesNotPermittedWarning>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingMetadataResponse>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingProjectResponse>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptUtterance>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptWord>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptCharacter>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocator>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EnvironmentVariableResponse>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EnvironmentResponse>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModel>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VerificationAttemptResponseModel>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentWordResponseModel>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketResponseModel>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetWhatsAppAccountResponse>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem3>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentBranchInfo>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTopicResponseModel>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentSummaryResponseModel>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem4>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioIsolationHistoryItemResponseModel>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterResponseModel>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem2>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VisitedAgentRef>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationSummaryMessageModel>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationTagResponseModel>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationUserResponseModel>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationSummaryResponseModel>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem5>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DocumentUsageModeEnum>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DocumentsItem>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem3>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem5>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem4>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem2>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LibraryVoiceResponseModel>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MediaCodec>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem3>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectResponseModel>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SIPLogMessage>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechHistoryItemResponseModel>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestInvocationSummaryResponseModel>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestRunResultSummary>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestRunResponseModel>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestSummaryResponseModel>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem2>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolExecutionResponseModel>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UserVoiceCollectionResponseModel>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceAccentResponseModel>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceResponseModel>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TimeRangeModel>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ImageSubject>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DiscountResponseModel>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseContentSearchResult>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SearchHighlightSegment>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseRagChunkModel>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SearchStrategy>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMReasoningEffort>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMServiceTier>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMInfoModel>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?, global::System.Collections.Generic.List<string>>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguageInfo>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AuthConnectionsItem>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetCrawlJobResponseModel>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Tool>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolApprovalStatus>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderSummary>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProcedureListItemResponseModel>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentBranchSummary>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentDeploymentHistoryItem>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechEngineSummaryResponse>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.List<string>>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolApprovalHash>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverrideInput>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverrideOutput>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPServerResponseModel>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ManualVerificationFileResponseModel>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MediaGenerationResponse>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem2>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.FieldConflict>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MessagesSearchResult>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguageResponseModel>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextChunkResponseModel>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MusicFinetuneResponseModel>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SongSection>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelAttribute>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelScopeSpans>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelSpan>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelResourceSpans>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem4>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DeliverableInfo>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderItemInfo>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentMergeProposalResponse>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguagePairInfo>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectVoiceResponseModel>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectSnapshotResponseModel>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseLocator>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem2>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem5>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsVariant1Item>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsVariant1Item2>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TeamInviteResult>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RAGDocumentIndexResponseModel>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RagChunkMetadata>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RealtimeConversationGroupResponseModel>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionGroupMembership>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionIntakeQuestion>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionServiceVariant>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionAddOn>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionServicePromotion>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderFulfillmentType>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentRule>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionTransferRule>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionProcedure>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TeamInviteRequest>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RequiredConstraint>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerInvoiceLine>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerInvoiceSummary>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerUpcomingPayment>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerWorkspaceSummary>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ShareOptionResponseModel>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SingleTestRunRequestModel>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem2>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem3>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SafetyRule>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TimeRange>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InputItem>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InputItem2>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SimilarVoice>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UtteranceResponseModel>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DialogueInputResponseModel>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextWordResponseModel>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AdditionalFormatResponseModel?>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DetectedEntity>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextCharacterResponseModel>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SubAgentInput>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SubAgentOutput>? ListType294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SubmitCampaignRecipient>? ListType295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SupportedVoice>? ListType296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SuggestedAudioTag>? ListType297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? ListType298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateOutput>? ListType299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateSummary>? ListType300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateRunInput>? ListType301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateRunResponse>? ListType302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateVersion>? ListType303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplatePort>? ListType304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestRunResultBucket>? ListType305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Icon>? ListType306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestToolCallParameter>? ListType307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseModel>? ListType308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TopicEvaluationCriteriaAggregate>? ListType309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProviderConfigsItem>? ListType310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProviderConfigsItem2>? ListType311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTransferInput>? ListType312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTransferOutput>? ListType313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumberTransfer>? ListType314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TransferRuleInput>? ListType315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TransferRuleOutput>? ListType316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TwilioMachineDetectionRule>? ListType317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TwilioAnsweredBy>? ListType318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemAttachmentDestination>? ListType319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResultsItem3>? ListType320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<double>>? ListType321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ContentItem>? ListType322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>? ListType323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VeoImageReference>? ListType324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoSubject>? ListType325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoSegment>? ListType326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoKeyMoment>? ListType327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoicePreviewResponseModel>? ListType328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SampleResponseModel>? ListType329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReaderResourceResponseModel>? ListType330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WhatsAppTemplateComponent>? ListType331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WhatsAppTemplateTextParam>? ListType332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WhatsAppTemplateComponentButton>? ListType333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ParametersItem>? ListType334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PositionInput>? ListType335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PositionOutput>? ListType336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem4>? ListType337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProviderConfigsItem3>? ListType338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem5>? ListType339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProviderConfigsItem4>? ListType340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkflowToolLocator>? ListType341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.StepsItem>? ListType342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.StepsItem2>? ListType343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.TimeRangeModel>>? ListType344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>? ListType345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>>? ListType346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>? ListType347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ColumnUnit?>? ListType348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceApiKeyResponseModel>? ListType349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAuditLogEntryResponse>? ListType350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BatchCallResponse>? ListType351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupPermission>? ListType352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceServiceAccountResponseModel>? ListType353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupResponseModel>? ListType354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookResponseModel>? ListType355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>? ListType356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? ListType357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? ListType358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? ListType359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestType>? ListType360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item>? ListType361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GuardrailType>? ListType362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item>? ListType363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketSource>? ListType364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketPriority>? ListType365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentType>? ListType366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolTypeFilter>? ListType367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CampaignStatus>? ListType368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TerminalDisposition>? ListType369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CallResult>? ListType370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderState>? ListType371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ModelResponseModel>? ListType372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupByNameResponseModel>? ListType373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceMemberResponseModel>? ListType374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AssignableUserResponseModel>? ListType375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>? ListType376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionService>? ListType377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionAssetResource>? ListType378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionProduct>? ListType379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionStaffResource>? ListType380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionCustomerFacingAgentResponse>? ListType381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionProcedureResponse>? ListType382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionPhoneAssignment>? ListType383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.HolidayResponseModel>? ListType384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionLocationResponse>? ListType385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionKnowledgeSource>? ListType386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerTierResponse>? ListType387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionTeamMemberResponse>? ListType388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionTeamInviteResponse>? ListType389 { get; set; }
    }
}