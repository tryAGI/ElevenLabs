
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
        public global::ElevenLabs.AddLeadsRequest? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SubmitCampaignRecipient>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitCampaignRecipient? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddLeadsResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignResponse? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddProjectResponseModel? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModel? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddPronunciationDictionaryResponseModel? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddTicketCommentRequestModel? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddTurnCommentRequestModel? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddUrlRequest? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddVoiceIVCResponseModel? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceMatchResponseModel? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddVoiceResponseModel? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddVoiceToUserVoiceCollectionResponseModel? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddWorkspaceGroupMemberResponseModel? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AddWorkspaceInviteResponseModel? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AdditionalFormatResponseModel? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ExportOptions>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptions? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelInput? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentPlatformSettingsRequestModel? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModel? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInput? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EvaluationCriteriaItem>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationCriteriaItem? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedUserEvaluationRef? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedSystemEvaluationRef? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminator? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionItem>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionItem? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedUserDataCollectionRef? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedSystemDataCollectionRef? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminator? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutput? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EvaluationCriteriaItem2>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationCriteriaItem2? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminator? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionItem2>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionItem2? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputDataCollectionItemDiscriminator? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentBan? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BanReasonType? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentBranchBasicInfo? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentBranchResponse? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchProtectionStatus? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchSyncStatus? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfo? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentVersionMetadata>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentVersionMetadata? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentBranchSummary? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentCallLimits? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentChatResponsePartClientEvent? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentChatResponsePartClientEventData? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentChatResponsePartType? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelInput? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariablesConfig? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.BehaviorOverride>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BehaviorOverride? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubagentConfigInput? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInput? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelOutput? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubagentConfigOutput? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutput? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelWorkflowOverrideInput? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariablesConfigWorkflowOverride? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInput? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigAPIModelWorkflowOverrideOutput? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutput? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigOverrideInput? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOverrideInput? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigOverrideOutput? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOverrideOutput? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConfigOverrideConfig? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOverrideConfig? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketPriority? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketResponseModel? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketCommentResponseModel>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketCommentResponseModel? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentResponseModel>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnCommentResponseModel? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketStatus? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriorityChangeResponseModel>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketPriorityChangeResponseModel? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatusChangeResponseModel>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketStatusChangeResponseModel? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketSource? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSearchMatchResponseModel? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentConversationTicketSortBy? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDefinitionSource? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentHistoryItem? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentSource? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentPercentageStrategy? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentRequest? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentDeploymentRequestItem>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentRequestItem? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentDeploymentResponse? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentFailureResponseExample? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentHoldAudioConfig? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentFormat? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagDocumentResponseModel? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagListingEntryResponseModel? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagListingResponseModel? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagListingEntryResponseModel>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagQueryRequestModel? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchStrategy? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentKnowledgeBaseRagQueryResponseModel? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponse? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalReview>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReview? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalComment>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalComment? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Outcome? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenOutcome? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergedOutcome? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClosedOutcome? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminator? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMessagesOverrides? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Llm? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMessagesPersistedAgent? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadata? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadataDBModel? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMetadataResponseModel? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentOutputError? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentOutputStatus? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSettingsInput? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigInput? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisProperty>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisProperty? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AnalysisScope>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisScope? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataConfigInput? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkspaceOverridesInput? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestingSettings? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsV1Input? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthSettings? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentQueueingConfig? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivacyConfigInput? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTrustContext? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicDiscoverySettings? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SentimentAnalysisSettings? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSettings? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentPlatformSettingsResponseModel? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSettingsOutput? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigOutput? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataConfigOutput? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkspaceOverridesOutput? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsV1Output? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivacyConfigOutput? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSettingsResponse? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyResponseModel? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentPolicyOverrideInput? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RetryPolicy? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallingPeriod>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallingPeriod? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DateOverride>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DateOverride? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionConfig? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FollowupContextPolicy? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentPolicyOverrideOutput? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentReasoningResponsePartClientEvent? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentReasoningResponsePartClientEventData? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentResponseAttachment? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentResponseClientEvent? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentResponseClientEventData? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentResponseType? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentResponseAttachment>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentRule? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RulePriority? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSMBMetadata? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBAgentType? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSimulatedChatTestResponseModel? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptResponseModel? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryAnalysisCommonModel? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSortBy? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSuccessfulResponseExample? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSummaryBatchSuccessfulResponseModel? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentSummaryResponseModel? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestEntityType? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTestFolderPathSegmentResponseModel? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AttachedTestModel>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttachedTestModel? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentToolRequestClientEventData? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentToolRequestStreamedEvent? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentToolResponseClientEventData? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentToolResponseStatus? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentToolResponseStreamedEvent? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTopicResponseModel? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicMetricsAggregate? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferInput? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentTransferOutput? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentVersionParents? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResourceAccessInfo>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelInput>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInput? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Nodes? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartNodeModelInput? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeModelInput? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInput? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelInput? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowSayNodeModelInput? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNodeModelInput? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUpdateStateNodeModelInput? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartProcedureNodeModelInput? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminator? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModel? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkflowEdgeModelOutput>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutput? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Nodes2? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartNodeModelOutput? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeModelOutput? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowSayNodeModelOutput? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNodeModelOutput? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUpdateStateNodeModelOutput? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartProcedureNodeModelOutput? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminator? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataWebhook? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIWebhooks? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingMonitorConfig? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingPagerDutyNotifier? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingPagerDutyNotifierResponse? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AlertingMonitorConfig>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookNotifier? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSlackNotifier? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookNotifierResponse? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSlackNotifierResponse? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookSecretHeaderValue? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowedOutputFormats? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowedValues? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AllowlistItem? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisCharging? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisRunningTotal? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisRunSnapshot? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentAction? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentDestination? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemAttachmentResultData? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemKind? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModel? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Definition? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItem? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserDataCollectionAnalysisItemOutput? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModelDefinitionDiscriminator? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemResponseModelDefinitionDiscriminatorKind? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemSource? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModel? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Definition2? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminator? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminatorKind? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionsResponseModel? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemVersionResponseModel>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemsResponseModel? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemResponseModel>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisPropertyType? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOfJsonSchemaPropertyInput? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ObjectJsonSchemaPropertyInput>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyInput? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOfJsonSchemaPropertyOutput? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ObjectJsonSchemaPropertyOutput>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyOutput? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponseScopeSeparator? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependencies? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionStatus? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverrides? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SchemaOverridesVariant12? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConstantSchemaOverride? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableSchemaOverride? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMSchemaOverride? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OmitSchemaOverride? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminator? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookOverridesSchemaOverridesDiscriminatorSource? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseFilterMode? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAIDynamicVariable>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIDynamicVariable? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigInput? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolInterruptionMode? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PreToolSpeechMode? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableAssignment? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallSoundType? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallSoundBehavior? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolErrorHandlingMode? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionMode? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ApplicationNumberType? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyInput? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LiteralJsonSchemaProperty? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArrayJsonSchemaPropertyOutput? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArraySchema? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchema? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetListResponse? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AssetResponse>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetResponse? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscription? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscriptionStatus? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssetTranscriptionData? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignConversationTagsRequestModel? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignResellerTierRequest? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignResellerTierRequestBillingPeriod? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssignableUserResponseModel? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadata? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadataDeliveryStatus? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformMetadataVariant1? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlainPlatformMetadata? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ZendeskPlatformMetadata? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1Discriminator? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemDataCollectionId? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemEvaluationId? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttentionPageResponse? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AttentionView>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttentionView? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttentionResolutionRequest? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AttentionStatus? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysis? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysisStatus? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioAnalysisResult? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioSegment>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioSegment? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioKeyMoment>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioKeyMoment? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsCatalogResponseModel? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsFilterPresetResponseModel>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsFilterPresetResponseModel? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsEnvironmentResponseModel>? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioEffectsEnvironmentResponseModel? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel>? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioFormat? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioInputPacing? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioIsolationHistoryItemResponseModel? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeCreateProjectResponseModel? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeEditContentResponseModel? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeProjectSettingsResponseModel? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioRefChunk? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeRange? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReference? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationReference? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StaticAssetReference? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineAudioReference? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReferenceDiscriminator? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioReferenceDiscriminatorType? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioSchema? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioWithTimestampsAndVoiceSegmentsResponseModel? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAlignmentResponseModel? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceSegment>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSegment? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioWithTimestampsResponseModel? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuditActivityName? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuditClassName? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem3>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem3? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableToolIdentifier? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownToolIdentifier? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesToolDiscriminator? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.McpServersItem? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableMCPServerIdentifier? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownMCPServerIdentifier? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminator? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentIntegrationConnectionIdentifier>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentIntegrationConnectionIdentifier? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionLocator? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AllowlistItem>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthorizationMethod? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoRebaseAttempt? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoRebaseOutcome? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AutoSyncInfo? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AvatarContextResponseModel? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundConfig? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundSourceType? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundPresetId? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackgroundSoundConfigWorkflowOverride? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMDefault? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMDisabled? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLLMOverride? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Llm>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Base64FileSource? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileInputMimeType? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BaseTurnConfig? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnMode? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnEagerness? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpellingPatience? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnModel? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BasicAuthResponse? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallDetailedResponse? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyProvider? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallWhatsAppParams? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallStatus? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyCallConfigOutput? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipientResponseModel>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundCallRecipientResponseModel? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallRecipientStatus? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallResponse? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchCallingCampaignInformation? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignConversationType? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchFailureResponseModel? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BatchSuccessResponseModelAnalysisItemAttachmentResultData? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BearerAuthResponse? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Verbosity? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutputFormat? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InteractionBudget? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BillingPeriod? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BinaryScoring? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddSamplesToPvcVoiceV1VoicesPvcVoiceIdSamplesPost? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAddVoiceV1VoicesAddPost? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPost? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPost? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkDeleteKnowledgeBaseDocumentsV1ConvaiKnowledgeBaseBulkDeletePost? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyBulkMoveTestsToFolderV1ConvaiAgentTestingBulkMovePost? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCheckWatermarkV1ContentProvenanceWatermarkPost? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCommentOnAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdCommentsPost? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPost? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicGenerationMode? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicPrompt? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompositionPlan? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicModelID? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComposeMusicV1MusicPost? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetOrCreateRAGIndexRequestModel>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRAGIndexRequestModel? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentV1ConvaiAgentsCreatePost? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSettings? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPost? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePvcVoiceV1VoicesPvcPost? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPost? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QualityPresetType? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostFiction? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostSourceType? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateUrlDocumentV1ConvaiKnowledgeBaseUrlPost? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoicePost? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentDraftV1ConvaiAgentsAgentIdDraftsPost? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateAgentTestFolderV1ConvaiAgentTestingFoldersPost? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateChapterV1StudioProjectsProjectIdChaptersPost? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateCrawlJobV1ConvaiKnowledgeBaseCrawlPost? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateForcedAlignmentV1ForcedAlignmentPost? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPost? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastConversationMode? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastBulletinMode? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastTextSource? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastURLSource? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateVoiceCollectionV1VoicesCollectionsPost? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookHMACSettings? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePost? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDeleteExistingInvitationV1WorkspaceInvitesDelete? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDownloadHistoryItemsV1HistoryDownloadPost? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPost? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyDuplicateAgentV1ConvaiAgentsAgentIdDuplicatePost? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditPvcVoiceV1VoicesPvcVoiceIdPost? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPost? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePost? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MetronomeUsageColumnFilter>? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetronomeUsageColumnFilter? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnFilter? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetDependentAgentsForMultipleDocumentsV1ConvaiKnowledgeBaseDependentAgentsPost? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaExotelV1ConvaiExotelOutboundCallPost? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataRequestInput? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyCallConfigInput? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaSipTrunkV1ConvaiSipTrunkOutboundCallPost? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SeatType? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyInviteUserV1WorkspaceInvitesAddPost? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConflictResolution>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConflictResolution? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMergeAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdMergePost? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ProcedureVersionRef>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureVersionRef? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyPostAgentHoldAudioV1ConvaiAgentsAgentIdHoldAudioPost? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRebaseABranchOntoMainV1ConvaiAgentsAgentIdBranchesBranchIdRebasePost? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TelephonyDirection? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRegisterMediaV1ProductionsOrdersOrderIdMediaPost? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RenderType? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyReviewAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdReviewsPost? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReviewState? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateParamsItem>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateParamsItem? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParams? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateBodyComponentParams? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateButtonComponentParams? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySendTestWebhookEventV1WorkspaceWebhooksWebhookIdTestPost? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTypes? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySetRulesOnThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdSetRulesPost? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySetWorkspaceThirdPartyDisablingPolicyV1WorkspacesApiKeysThirdPartyDisablingPost? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceResourceType? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSimulationSpecification? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PromptEvaluationCriteria>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptEvaluationCriteria? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySoundGenerationV1SoundGenerationPost? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SFXModelId? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostNumbersFormat? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostMultichannelOutputStyle? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, object>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPost? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamChapterAudioV1StudioProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamComposedMusicV1MusicStreamPost? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPost? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipient>? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundCallRecipient? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPost? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInput>? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DialogueInput? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToDialogueSettingsResponseModel? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EffectsSpecInput? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePost? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTranslatesAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdTranslatePost? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUnshareWorkspaceResourceV1WorkspaceResourcesResourceIdUnsharePost? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdatePvcVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateStudioProjectV1StudioProjectsProjectIdPost? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdPatch? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAgentTestFolderV1ConvaiAgentTestingFoldersFolderIdPatch? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentInputModel? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateFileDocumentV1ConvaiKnowledgeBaseDocumentationIdUpdateFilePatch? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPost? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateOrderV1ProductionsOrdersOrderIdPatch? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderRequest? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateVoiceCollectionV1VoicesCollectionsCollectionIdPatch? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookEventType>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookEventType? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadAssetV1AssetsPost? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadFileV1ConvaiConversationsConversationIdFilesPost? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUploadMusicV1MusicUploadPost? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<bool?, global::ElevenLabs.MusicModelID?>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyUpsertOrderItemV1ProductionsOrdersOrderIdItemsPost? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpsertOrderItemRequest? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVerifyPvcVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVideoToMusicV1MusicVideoToMusicPost? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPost? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerV1VoiceChangerVoiceIdPost? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>, string>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PermissionType>? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PermissionType? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyCreateServiceAccountV1ServiceAccountsPost? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupConfig>? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupConfig? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatch? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<bool?, string>? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchPermissions? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit?>? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchCharacterLimit? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchThirdPartyDisableAllowed? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchTtsConcurrencyLimit? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchDubbingConcurrencyLimit? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchMusicConcurrencyLimit? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchExpiresAtUnix?>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchExpiresAtUnix? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbCancelTeamInvite? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbUpdateTeamMemberRole? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbUpdateTeamMemberRoleRole? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodySmbUploadKnowledgeSource? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueFullWithTimestamps? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueStreamWithTimestamps? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFull? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSettingsResponseModel? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullWithTimestamps? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStream? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamWithTimestamps? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BooleanSchema? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BreakdownTypes? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BucketingStatus? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsInput? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInput? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsOutput? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutput? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsWorkflowOverrideInput? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BuiltInToolsWorkflowOverrideOutput? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25Request? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTarget? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25RequestAspectRatio? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25RequestResolution? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReference? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoReference>? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReference? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioReference>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequest? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequestResolution? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequest? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequestResolution? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2Request? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2RequestAspectRatio? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2RequestResolution? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequest? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequestResolution? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequest? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequestResolution? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallResult? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallStatus? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallView? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DecisionDisposition? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeadDeliveryView? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallingIntervalPolicy? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallingIntervalPolicy>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CallingPeriodPolicy? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignCallsResponse? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallView>? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignConfigInput? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PolicyConfigInput? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AgentPolicyOverrideInput>? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignConfigOutput? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PolicyConfigOutput? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.AgentPolicyOverrideOutput>? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignFollowUpRequestsResponse? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FollowUpRequestCounts? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignLeadsResponse? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LeadView>? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeadView? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignPageResponse? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CampaignResponse>? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignPolicySnapshot? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallingPeriodPolicy>? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DateOverridePolicy>? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DateOverridePolicy? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionPolicy? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignProgressResponse? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeadsProgress? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationProgress? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChannelConfig? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneChannelConfigOutput? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppChannelConfig? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignResponseChannelConfigDiscriminator? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignResponseChannelConfigDiscriminatorChannel? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignStatus? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignVariant? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignSource? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundChannel? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundMode? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignSummaryCounts? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RecipientDeliveryCounts? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelCalendarEventParams? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelGroupSessionForAllParams? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelGroupSessionRegistrationParams? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CancelOrderParams? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CanvasPlacement? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModel? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleHorizontalPlacementModel? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModel? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleTemplateModel? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextAlign? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextStyle? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextWeight? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextTransform? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleModelTextBlendMode? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioTextStyleShadowModel? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioTextStyleOutlineModel? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModel? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModel? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleVerticalPlacementModel? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModelEnterType? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleSectionAnimationModelExitType? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleVerticalPlacementModelAlign? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModelEnterType? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CaptionStyleWordAnimationModelExitType? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChangeResellerTierRequest? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChangeResellerTierRequestBillingPeriod? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockInputModel? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockInputModelSubType? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockResponseModel? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockInputModel>? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterContentResponseModel? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterContentBlockResponseModel>? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterResponseModel? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterResponseModelState? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterStatisticsResponseModel? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotExtendedResponseModel? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CharacterAlignmentModel>? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterAlignmentModel? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotResponseModel? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterSnapshotsResponseModel? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterSnapshotResponseModel>? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceStatisticsResponseModel>? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceStatisticsResponseModel? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChapterWithContentResponseModelState? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CharacterRefreshPeriod? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChatSourceMedium? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CheckServiceAvailabilityParams? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChunkingOverride? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChunkingOverrideRequestModel? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientEvent? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientSecretResponse? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutput? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolCallClientEventData? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolCallEvent? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolCallRequiredAction? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolConfigInput? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolConfigOutput? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolResultItem? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolResultItemErrorType? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimation? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimationEnterEffect? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClipAnimationExitEffect? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalCloseReason? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnFilterOperation? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>?>? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ColumnUnit? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompileProceduresResponseModel? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CompileProceduresValidationErrorResponseModel? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureValidationError>>? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureValidationError>? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureValidationError? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>>? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkInput? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComputedUsagePlatformLimit? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConditionStrength? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConfigEntityType? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConfirmChangeParams? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConflictResolutionChoice? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConflictSection? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.IList<object>, object>? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentConfig? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentThresholdGuardrail? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInput? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailExecutionMode? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction2? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallTriggerAction? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RetryTriggerAction? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminator? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutput? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction3? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminator? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentGuardrailOutputTriggerActionDiscriminatorType? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StringSchema? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumberSchema? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntegerSchema? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageSchema? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSchema? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSchema? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectSchema? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchemaDiscriminator? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchemaDiscriminatorType? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<double?, global::ElevenLabs.ContentThresholdGuardrailThreshold?>? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentThresholdGuardrailThreshold? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContextualUpdateInfo? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContextualUpdateInputItem? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContextualUpdatePlacement? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Contributor? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIEnvVarLocator? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIFileUploadResponseModel? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAISecretLocator? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependencies? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem6>? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem6? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminator? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesToolDiscriminatorType? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem>? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableAgentIdentifier? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentUnknownAgentIdentifier? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminator? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesAgentDiscriminatorType? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentPhoneNumberIdentifier? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.McpServersItem2>? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.McpServersItem2? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminator? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminatorType? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SecretDependencyType>? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecretDependencyType? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIUserSecretDBModel? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WebhookEventType>? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookEventType? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTranscriptFormat? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationASRUsageModel? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationChargingCommonModel? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMCategoryUsage? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformUsage? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTTSUsageModel? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigInput? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ClientEvent>? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileInputConfig? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DTMFInputConfig? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOutput? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideInput? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigOverride? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOverride? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOverride? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideOutput? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideConfigInput? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigOverrideConfig? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOverrideConfig? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigOverrideConfig? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigClientOverrideConfigOutput? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigWorkflowOverrideInput? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileInputConfigWorkflowOverride? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationConfigWorkflowOverrideOutput? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationDeletionSettings? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationErrorType? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationFeedbackRequestModel? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserFeedbackScore? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationFeedbackType? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DataCollectionResultCommonModel>? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionResultCommonModel? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DataCollectionResultCommonModel>? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationSuccessResult? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ScopedAnalysisResult>? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScopedAnalysisResult? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryBatchCallModel? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryElevenAssistantCommonModel? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryErrorCommonModel? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CriteriaScoringMode? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryExotelPhoneCallModel? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryFeedbackCommonModel? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModel? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneCallVariant1? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1Discriminator? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryRagUsageCommonModel? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FeaturesUsageCommonModel? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationSource? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppConversationInfo? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMSConversationInfo? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceRewardModel>? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationVoiceRewardModel? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMultivoiceMessageModel? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryRedactionConfig? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConfigEntityType>? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableUpdateCommonModel>? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableUpdateCommonModel? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelInputRole? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserFeedback? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTurnMetrics? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagRetrievalInfo? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageInput? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptPlatformEvent? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationReasoningModel>? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationReasoningModel? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TriggeredGuardrailCommonModel>? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggeredGuardrailCommonModel? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutputRole? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageOutput? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModelType? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptResponseModelRole? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel>? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultVariant1? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallToolResultModel? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageDetectionToolResultModel? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInput? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultErrorModel? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultSipSuccessModel? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultExotelSuccessModel? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultAmazonConnectSuccessModel? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberResultErrorModel? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SkipTurnToolResponseModel? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFResultSuccessModel? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFResultErrorModel? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceMailDetectionResultSuccessModel? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestToolResultModel? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolResultModel? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolResultModel? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolResultSuccessModel? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolResultErrorModel? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolResultSuccessModel? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolResultErrorModel? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DummyToolResultModel? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultVariant12? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutput? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallIntegrationFunctionDetails? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolType? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolDetailsVariant1? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolDetailsVariant12? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1Discriminator? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInput? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutput? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataInternal? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationSourceInfo? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DynamicVariableInternalValueType? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrchestratorToolMockBehaviorConfig? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigOutput>>? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigOutput>? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseMockConfigOutput? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationInitiationClientDataRequestOutput? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator>? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationProduct? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSentimentAnalysis? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSentimentAnalysisOverallLabel? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSignedUrlResponseModel? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ToolMockConfig>? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolMockConfig? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryMessageModel? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryMessageModelRole? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryResponseModel? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationSummaryResponseModelStatus? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EvaluationCriteriaSummaryResult>? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationCriteriaSummaryResult? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceUsageModel>? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationVoiceUsageModel? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTagResponseModel? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTokenPurpose? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTokenResponseModel? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationTurn? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TextOutputItem>? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextOutputItem? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ClientToolCallRequiredAction>? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.MetricRecord>? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetricRecord? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationUserResponseModel? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SentimentAggregate? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.FrustratedConversationRef>? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FrustratedConversationRef? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfig? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigInput? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetInput>? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetInput? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VADConfig? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelOutput? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigOutput? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LanguagePresetOutput>? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetOutput? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideInput? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnConfigWorkflowOverride? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigWorkflowOverrideInput? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VADConfigWorkflowOverride? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideOutput? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalConfigWorkflowOverrideOutput? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvertChapterResponseModel? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ConvertProjectResponseModel? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CrawlStatus? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CrawlType? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentBranchResponseModel? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentConversationRequest? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentConversationResponse? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentConversationTicketRequestModel? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentRequestModel>? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnCommentRequestModel? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentMergeProposalResponseModel? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentProcedureParams? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentResponseModel? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentRuleParams? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentTestFolderResponseModel? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAgentTestResponseModel? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAssetParams? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateBasicAuthRequest? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateBearerAuthRequest? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientAppointmentParams? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientInteractionParams? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientParams? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateClientSecretRequest? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInput? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExpiresAfter? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateConversationTagRequestModel? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateCrawlJobResponseModel? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateCustomHeaderAuthRequest? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentRequest? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateExotelPhoneNumberRequest? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelApiSubdomain? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateHolidayParams? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateLocationParams? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateMTLSAuthRequest? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateManualTicketRequestModel? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2ClientCredsRequest? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequest? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestAlgorithm? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestTokenResponseField? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOAuth2JWTRequestJwtUsage? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderParams? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderRequest? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateOrderResponse? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePhoneAssignmentRequest? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePhoneNumberResponseModel? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePrivateKeyJWTRequest? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePrivateKeyJWTRequestAlgorithm? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProcedureRequestModel? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureType? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureVisibilityInput? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProcedureResponseModel? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProductParams? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateProductQuoteRequestParams? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatePronunciationDictionaryResponseModel? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateRealtimeConversationGroupRequestModel? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateResponseUnitTestRequest? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestFromConversationMetadataInput? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentSuccessfulResponseExample>? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentFailureResponseExample>? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InboundSIPTrunkConfigRequestModel? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OutboundSIPTrunkConfigRequestModel? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSecretEnvironmentVariableRequest? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest>? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableSecretValueRequest? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateServiceParams? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateServiceQuoteRequestParams? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSimulationTestRequest? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationToolMockBehaviorConfig? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>>? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseMockConfigInput? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateSpeechEngineRequest? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineConfig? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineAuthConfig? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineConversationInitiationClientDataConfig? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateStaffParams? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateStringEnvironmentVariableRequest? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTeamInviteRequest? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTeamInviteRequestRole? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketMessageRequest? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author2? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketRequesterAuthorRequest? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketHumanAgentAuthorRequest? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketMessageRequestAuthorDiscriminator? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketMessageRequestAuthorDiscriminatorType? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketEventVisibility? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketStatus? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketMessageResponse? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketMessageEventResponse? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketRequest? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Requester? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketRequesterByUserIdRequest? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketRequesterByEmailRequest? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketRequesterBySlackRequest? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketRequestRequesterDiscriminator? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketRequestRequesterDiscriminatorType? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketRequestAuthorDiscriminator? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketRequestAuthorDiscriminatorType? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketPriority? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssigneeVariant12? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAIAgentAssigneeRequest? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketHumanAgentAssigneeRequest? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketRequestAssigneeVariant1Discriminator? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketRequestAssigneeVariant1DiscriminatorType? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecondaryAssigneeVariant12? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketRequestSecondaryAssigneeVariant1Discriminator? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketRequestSecondaryAssigneeVariant1DiscriminatorType? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberRequest>? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSubscriberRequest? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketSLAPolicyRequest? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAPolicyTargetInput>? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSLAPolicyTargetInput? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketTagRequest? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateToolCallUnitTestRequest? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallEvaluationModelInput? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTransferRuleParams? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTwilioPhoneNumberRequest? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegionConfigRequest? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatifyAurora2Request? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatifyAurora2RequestResolution? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatifyAuroraRequest? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreatifyAuroraRequestResolution? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CueOptionsRequest? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Currency? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailInput? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailsConfigInput? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailOutput? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailsConfigOutput? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfig? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigModel? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMServiceTier? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerAction? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminator? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomGuardrailConfig>? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomHeaderAuthResponse? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomLLM? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIEnvVarLocator>? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator>? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentAuthConnectionLocator? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomLLMAPIType? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSIPHeader? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardCallSuccessChartModel? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardCriteriaChartModel? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DashboardDataCollectionChartModel? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionValueSchema? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DataCollectionValueSchemaType?, global::System.Collections.Generic.IList<string>>? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DataCollectionValueSchemaType? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DateModel? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupResponseModel? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupResponseModel? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DefaultSharingGroupResponseModelPermissionLevel? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentHoldAudioResponseModel? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentProcedureParams? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAgentRuleParams? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteAssetParams? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteCalendarEventParams? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteChapterResponseModel? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteClientInteractionParams? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteClientParams? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteDubbingResponseModel? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteGroupSessionParams? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteHistoryItemResponse? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteHolidayParams? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteLocationParams? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteProductParams? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteProjectResponseModel? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteSampleResponseModel? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteServiceParams? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteStaffParams? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteTransferRuleParams? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteUserVoiceCollectionResponseModel? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteVoiceResponseModel? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteVoiceSampleResponseModel? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceGroupMemberResponseModel? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceInviteResponseModel? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeleteWorkspaceWebhookResponseModel? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeliverableInfo? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableAgentIdentifierAccessLevel? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableMCPServerIdentifierAccessLevel? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAvailableToolIdentifierAccessLevel? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentBranchInfo? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DetailedMusicResponse? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongMetadata? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WordTimestamp>? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WordTimestamp? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DetectedEntity? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DeviceModel? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DialogueInputResponseModel? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModel? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReadMetadataChapterDBModel>? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReadMetadataChapterDBModel? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelDisplayMode? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReadLegalTerms? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Contributor>? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DirectPublishingReadResponseModelPayoutType? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PreviewAudioDBModel? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleConfigDBModel? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModel? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DiscountResponseModel? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DoDubbingResponseModel? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocumentUsageModeEnum? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocxExportOptions? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubOrderItemRequest? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbedSegment? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SegmentSubtitleFrame>? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentSubtitleFrame? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMediaReference? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkSegmentUpdateRequest? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingSegmentUpdateRequest>? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSegmentUpdateRequest? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkSourceSegmentUpdateResponse? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptSegment>? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptSegment? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkTargetSegmentUpdateRequest? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingTargetSegmentUpdateRequest>? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetSegmentUpdateRequest? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingBulkTargetSegmentUpdateResponse? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTargetTranscriptSegment>? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetTranscriptSegment? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingError? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageListResponse? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingLanguageResponse>? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageResponse? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageOutputs? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingLanguageResponseStatus? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoicesNotPermittedWarning>? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicesNotPermittedWarning? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMediaMetadata? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMetadataPageResponseModel? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingMetadataResponse>? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingMetadataResponse? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectListResponse? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingProjectResponse>? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectResponse? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectResponseStatus? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceMediaInfo? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingRegenerateResponse? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingReleaseChannel? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingRenderResponseModel? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingResource? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerTrack>? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerTrack? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerSegment>? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSegment? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.Render>? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Render? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSegmentCreateRequest? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceSegmentUpdateResponse? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingSourceTranscriptResponse? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetSegmentUpdateResponse? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTargetTranscriptResponse? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscript? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptUtterance>? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptUtterance? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptCharacter? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptResponseModel? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptRevisionResponse? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptWord>? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptWord? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptCharacter>? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptsResponseModel? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DuplicateSpeechEngineRequest? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Eagerness? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditChapterResponseModel? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditProjectResponseModel? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditVoiceResponseModel? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditVoiceSettingsResponseModel? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditedTranscript? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EffectsSpecOutput? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25Request? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25RequestOutputFormat? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocator>? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionLocator? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25VoiceSettings? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenMultilingualV2Request? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TtsVoiceSettings? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3Request? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3RequestOutputFormat? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ElevenV3VoiceSettings? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EmbedVariant? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EmbeddingModelEnum? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndCallToolConfig? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolConfig? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ProcedureVersionRef, global::ElevenLabs.ProcedureDraftRef>? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureDraftRef? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EndProcedureToolErrorStatus? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EntryBehavior? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentResponse? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableAuthConnectionValue? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableResponse? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableResponseType? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableSecretValue>? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariableSecretValue? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.EnvironmentVariableAuthConnectionValue>? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentVariablesListResponse? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentVariableResponse>? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EnvironmentsListResponse? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentResponse>? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EraseUserMemoryRequestModel? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EraseUserMemoryResponseModel? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EvaluationResultFilter? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExactParameterEvaluationStrategy? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigInput? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination7? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneDestinationInput? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneDynamicVariableDestinationInput? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigInputTransferDestinationDiscriminator? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigInputTransferDestinationDiscriminatorType? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigOutput? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination10? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneDestinationOutput? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneDynamicVariableDestinationOutput? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigOutputTransferDestinationDiscriminator? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigOutputTransferDestinationDiscriminatorType? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelOutboundCallResponse? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferInput? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Config3? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigInput? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferInputConfigDiscriminator? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferInputConfigDiscriminatorType? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferOutput? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Config5? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigOutput? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferOutputConfigDiscriminator? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferOutputConfigDiscriminatorType? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination2? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigInputTransferDestinationDiscriminator? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigInputTransferDestinationDiscriminatorType? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination3? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigOutputTransferDestinationDiscriminator? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigOutputTransferDestinationDiscriminatorType? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExperimentAssignment? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExperimentAssignmentSource? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentedJsonExportOptions? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PdfExportOptions? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TxtExportOptions? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HtmlExportOptions? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SrtExportOptions? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptionsDiscriminator? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportOptionsDiscriminatorFormat? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportUserMemoryRequestModel? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExportUserMemoryResponseModel? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RenderedUserMemoryEntity>? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RenderedUserMemoryEntity? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExtendedSubscriptionResponseModel? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<int?, string>? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Price? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionStatusType? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModel? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModel>? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PendingSubscriptionSwitchResponseModel, global::ElevenLabs.PendingCancellationResponseModel>? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingSubscriptionSwitchResponseModel? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingCancellationResponseModel? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalFileSyncInfo? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncProvider? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalFolderSyncInfo? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncJobTrigger? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExternalSyncJobType? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FeatureStatusCommonModel? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowFeaturesUsageCommonModel? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestsFeatureUsageCommonModel? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FieldConflict? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileContentPart? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Source? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileIdSource? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileContentPartSourceDiscriminator? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileContentPartSourceDiscriminatorType? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileRefreshStatus? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FindAgentsUserByIdentityRequestModel? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FindAgentsUserByIdentityResponseModel? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FineTuningResponseModel? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.FineTuningResponseModelState2>? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FineTuningResponseModelState2? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VerificationAttemptResponseModel>? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerificationAttemptResponseModel? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualVerificationResponseModel? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FinetuneCreatedBy? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FinetuneVisibility? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FirstMessageMode? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FlattenedConfigOverrides? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FocusGuardrail? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentCharacterResponseModel? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentResponseModel? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentWordResponseModel>? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForcedAlignmentWordResponseModel? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FrustratedConversationRefOverallLabel? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1Request? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestQuality? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestBackground? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1RequestAspectRatio? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15Request? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestQuality? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestBackground? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15RequestAspectRatio? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequest? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestQuality? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestAspectRatio? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25FlareRequestResolution? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequest? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestQuality? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestAspectRatio? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage25SunburstRequestResolution? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2Request? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestQuality? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestAspectRatio? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2RequestResolution? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini25FlashImageRequest? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini25FlashImageRequestAspectRatio? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequest? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequestAspectRatio? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequestResolution? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashLiteImageRequest? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequest? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequestAspectRatio? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequestResolution? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkInputContextAdherence? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkOutput? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationChunkOutputContextAdherence? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationSourceContext? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferenceVideo? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentConfigParams? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentConversationTicketsPageResponseModel? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketResponseModel>? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentEmbedResponseModel? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigResponseModel? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgebaseSizeResponseModel? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentLinkResponseModel? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModel? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem>? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberTwilioResponseModel? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberExotelResponseModel? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminator? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseModelPhoneNumberDiscriminatorProvider? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetWhatsAppAccountResponse>? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWhatsAppAccountResponse? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ProcedureRefResponseModel>? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureRefResponseModel? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSubagentDependentsResponseModel? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem3>? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem3? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSubagentDependentsResponseModelAgentDiscriminator? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSubagentDependentsResponseModelAgentDiscriminatorType? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentBranchInfo>? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentTestFolderResponseModel? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentTopicsResponseModel? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTopicResponseModel>? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentsPageResponseModel? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentSummaryResponseModel>? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModel? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem4>? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem4? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModelAgentDiscriminator? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalysisItemDependentAgentsResponseModelAgentDiscriminatorType? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAnalyticsSummaryParams? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAppointmentByConfirmationNumberParams? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAudioIsolationHistoryResponseModel? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AudioIsolationHistoryItemResponseModel>? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAudioNativeProjectSettingsResponseModel? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetBookingPageSettingsParams? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetBookingSlugStatusParams? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetChaptersResponseModel? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChapterResponseModel>? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientAppointmentsParams? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientByPhoneParams? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetClientOrdersParams? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModel? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem2>? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChartsItem2? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminator? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConvAISettingsResponseModel? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LivekitStackType? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceUserMemorySettings? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationResponseModel? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationResponseModelStatus? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VisitedAgentRef>? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VisitedAgentRef? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationSummaryResponseModel? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationSummaryResponseModelStatus? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryMessageModel>? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationTagsPageResponseModel? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationTagResponseModel>? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationUsersPageResponseModel? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationUserResponseModel>? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationsPageResponseModel? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationSummaryResponseModel>? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetCrawlJobResponseModel? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentChunkingOverrideResponseModel? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModel? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem5>? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem5? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseFileResponseModel? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentMetadataResponseModel? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DocumentUsageModeEnum>? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KbExternalSyncJob? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModel? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DocumentsItem>? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DocumentsItem? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminator? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem3>? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem3? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminator? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem5>? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem5? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminator? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem4>? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem4? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminator? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem2>? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem2? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminator? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseTextResponseModel? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseURLResponseModel? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetLibraryVoicesResponseModel? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LibraryVoiceResponseModel>? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceResponseModel? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetLiveCountResponse? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrderByConfirmationNumberParams? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberAgentInfo? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberInboundSIPTrunkConfigResponseModel? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPMediaEncryptionEnum? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberOutboundSIPTrunkConfigResponseModel? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkTransportEnum? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MediaCodec>? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaCodec? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModel? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem3>? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem3? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminator? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumbersPageResponseModelPhoneNumberDiscriminatorProvider? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetProjectsResponseModel? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectResponseModel>? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionariesMetadataResponseModel? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModel? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetResponseUnitTestResponseModel? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestFromConversationMetadataOutput? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSIPLogMessagesResponse? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SIPLogMessage>? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPLogMessage? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetScheduleParams? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModel? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependenciesVariant1Item? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminator? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependenciesVariant2Item? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminator? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant2ItemDiscriminatorType? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSimulationTestResponseModel? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistoryResponseModel? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechHistoryItemResponseModel>? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModel? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestInvocationsPageResponseModel? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseMeta? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestInvocationSummaryResponseModel>? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestInvocationSummaryResponseModel? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestSuiteInvocationResponseModel? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestRunResultSummary>? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunResultSummary? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestRunResponseModel>? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModel? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestsPageResponseModel? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestSummaryResponseModel>? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestSummaryResponseModel? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTestsSummariesByIdsResponseModel? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.UnitTestSummaryResponseModel>? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTicketResponse? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketRequesterResponse? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssigneeVariant1? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAIAgentAssigneeResponse? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketHumanAgentAssigneeResponse? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTicketResponseAssigneeVariant1Discriminator? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTicketResponseAssigneeVariant1DiscriminatorType? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecondaryAssigneeVariant1? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTicketResponseSecondaryAssigneeVariant1Discriminator? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTicketResponseSecondaryAssigneeVariant1DiscriminatorType? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberResponse>? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSubscriberResponse? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSLASummaryResponse? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.EventsItem>? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EventsItem? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketCreatedEventResponse? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketDeletedEventResponse? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAssigneeChangedEventResponse? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSubscribersChangedEventResponse? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSubjectChangedEventResponse? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketPriorityChangedEventResponse? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketStatusChangedEventResponse? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketDeadlineChangedEventResponse? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketTagIdsChangedEventResponse? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTicketResponseEventDiscriminator? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTicketResponseEventDiscriminatorType? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolCallUnitTestResponseModel? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallEvaluationModelOutput? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModel? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem2>? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentsItem2? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminator? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolDependentAgentsResponseModelAgentDiscriminatorType? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetToolExecutionsPageResponseModel? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolExecutionResponseModel>? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModel? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetUserVoiceCollectionsResponseModel? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UserVoiceCollectionResponseModel>? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserVoiceCollectionResponseModel? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoiceAccentsResponseModel? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceAccentResponseModel>? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceAccentResponseModel? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoicesResponseModel? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceResponseModel>? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModel? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetVoicesV2ResponseModel? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppAccountType? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWorkspacePlanParams? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetWorkspaceSecretsResponseModel? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailClassifierVerdict? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailLLMVerdict? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailType? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailUnknownVerdict? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GuardrailsResult? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptInjectionGuardrail? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationGuardrailInput? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationGuardrailOutput? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HTTPValidationError? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ValidationError>? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ValidationError? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HidingReason? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HistoryAlignmentResponseModel? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HistoryAlignmentsResponseModel? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HolidayResponseModel? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HolidayType? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeRangeModel? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TimeOffType? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.HttpRequestModel? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UrlModel? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Icon? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IconTheme? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IdentityPolicyInput? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.IdentityPolicyRule>? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IdentityPolicyRule? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IdentityPolicyOutput? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IdentityVerificationMethod? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysis? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysisStatus? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAnalysisResult? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ImageSubject>? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageSubject? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageAvatar? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequest? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequestDiscriminator? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineImageReference? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReferenceDiscriminator? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageReferenceDiscriminatorType? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkCredentialsRequestModel? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IngestFailure? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineAudioReferenceMimeType? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineBase64Reference? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineBase64ReferenceMimeType? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineImageReferenceMimeType? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineVideoReference? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineVideoReferenceMimeType? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntakeQuestionKind? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntegrationType? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InternalSamplingConfigResponseModel? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntervalPlacement? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DiscountResponseModel>? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModelPaymentIntentStatus? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDeletedResponseModel? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResponseModel? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseContentSearchResult>? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResult? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Document? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminator? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminatorType? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchHighlightSegment>? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchHighlightSegment? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDependentType? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseDocumentChunksResponseModel? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel>? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseLocator? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagChunkModel? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolConfig? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolStatus? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseRagChunkModel>? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSortBy? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSourceFileUrlResponseModel? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Data? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminator? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolConfig? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchStrategy>? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolInfo? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseToolStatus? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeSourceStatus? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.KnowledgeSourceType? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMDeprecationConfigModel? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMDeprecationInfoModel? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMInfoModel? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMReasoningEffort>? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMReasoningEffort? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMServiceTier>? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegionalProcessingSurchargeInfo? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMInputOutputTokensUsage? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMTokensCategoryUsage? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMListResponseModel? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMInfoModel>? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMLiteralJsonSchemaPropertyType? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMParameterEvaluationStrategy? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LLMInputOutputTokensUsage>? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorLLMResponseModel? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorPublicRequestModel? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorRequestModel? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LLMUsageCalculatorResponseModel? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageAddedResponse? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageDetectionToolConfig? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageInfo? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePairInfo? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguageInfo>? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagePresetTranslation? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguageResponseModel? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponse? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PairedLanguagesResponse? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleLanguagesResponse? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponseDiscriminator? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LanguagesResponseDiscriminatorKind? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeadDeliveryViewStage? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeadDetailResponse? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TerminalDisposition? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LeaveMessageParams? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LibraryVoiceResponseModelCategory? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerifiedVoiceLanguageResponseModel? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentProceduresParams? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentReferencesParams? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAgentRulesParams? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAssetsParams? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponse? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AuthConnectionsItem>? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AuthConnectionsItem? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2ClientCredsResponse? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshTokenAuthResponse? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponse? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivateKeyJWTResponse? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MTLSAuthResponse? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppAuthResponse? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SlackBotAuthResponse? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UrlSecretAuthResponse? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminator? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCalendarEventsParams? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListClientInteractionsParams? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListClientsParams? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCrawlJobsResponseModel? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetCrawlJobResponseModel>? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCustomerFacingAgentsParams? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListGroupSessionsParams? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListHolidaysParams? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListLocationsParams? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListMCPToolsResponseModel? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Tool>? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Tool? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolApprovalStatus>? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalStatus? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListOrdersResponse? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderSummary>? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderSummary? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListProceduresResponseModel? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProcedureListItemResponseModel>? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureListItemResponseModel? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListProductsParams? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseAgentBranchSummary? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentBranchSummary>? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListResponseAgentDeploymentHistoryItem? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentDeploymentHistoryItem>? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListServicesParams? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListSpeechEnginesResponse? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechEngineSummaryResponse>? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineSummaryResponse? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListStaffParams? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTestsByIdsRequestModel? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTransferRulesParams? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListWhatsAppAccountsResponse? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.IList<string>>? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LiteralJsonSchemaPropertyType? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.LockReason? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovalPolicy? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovalPolicyUpdateRequestModel? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPApprovedToolDefinition? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigInput? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolApprovalHash>? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalHash? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerTransport? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator>? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIUserSecretDBModel>? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable, global::ElevenLabs.ConvAIEnvVarLocator>? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverrideInput>? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInput? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigOutput? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPToolConfigOverrideOutput>? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutput? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerConfigUpdateRequestModel? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerMetadataResponseModel? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerRequestModel? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModel? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem>? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DependentAgentsItem? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminator? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServerResponseModelDependentAgentDiscriminatorType? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPServersResponseModel? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MCPServerResponseModel>? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolAddApprovalRequestModel? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalPolicy? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolApprovalState? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInput? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant1? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminator? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutput? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant12? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminator? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ToolCallSoundType?, string>? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant13? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminator? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideInputInputOverridesDiscriminatorSource? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant14? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminator? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModel? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant15? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModel? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputOverridesVariant16? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ManualVerificationFileResponseModel? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ManualVerificationFileResponseModel>? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MatchAnythingParameterEvaluationStrategy? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationCompletedResponse? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationCreateResponse? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationFailedResponse? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationFailedResponseFailureReason? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationInProgressResponse? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationInProgressResponseStatus? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationListResponse? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MediaGenerationResponse>? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponse? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponseDiscriminator? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeAgentConversationTicketsRequestModel? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModel? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem2>? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumbersItem2? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminator? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergePreviewResponseModelPhoneNumberDiscriminatorProvider? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.FieldConflict>? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalReviewReviewerRole? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergeProposalStatus? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessageSearchSortBy? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessagesSearchResponse? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MessagesSearchResult>? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MessagesSearchResult? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetricType? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetronomeUsageColumnFilterColumn? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MetronomeUsageColumnFilterOperation? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MockNoMatchBehavior? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MockingStrategy? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModelRatesResponseModel? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModelResponseModel? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguageResponseModel>? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationConfig? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ThresholdGuardrail? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModel? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModelSafetyStatus? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModerationStatusResponseModelWarningStatus? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MultichannelSpeechToTextResponseModel? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextChunkResponseModel>? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModel? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MultipartMusicResponse? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicAllowedOutputFormats? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicOnlyOutputFormats? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicExploreSongSourceContext? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneFailureReason? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetunePageResponseModel? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.MusicFinetuneResponseModel>? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneResponseModel? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicFinetuneStatus? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicOutputFormat? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SongSection>? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongSection? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicUploadResponse? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NonStreamingOutputFormats? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumericDistributionAggregate? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumericUniformScoring? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseAlgorithm? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseTokenResponseField? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OAuth2JWTResponseJwtUsage? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelAttribute? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, bool?, double?>? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelResource? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelAttribute>? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelResourceSpans? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelScopeSpans>? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelScopeSpans? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelScope? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelSpan>? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelSpan? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelStatus? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OTelTracePayload? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OTelResourceSpans>? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectJsonSchemaPropertyInputPropertyKind? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequiredConstraints? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ContentSchema>? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioConfigInput? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputConfigInput? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputConfigInput? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioConfigOutput? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputConfigOutput? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputConfigOutput? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputFormat? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioInputTranscription? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAITurnDetection? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIAudioOutputFormat? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIFunctionTool? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIMCPTool? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIMCPToolRequireApproval? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeModel? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem>? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInputToolDiscriminator? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigInputToolDiscriminatorType? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.OpenAIToolChoiceFunction>? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIToolChoiceFunction? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.OpenAITurnDetection, string>? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<string, global::ElevenLabs.OpenAITracingConfiguration>? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAITracingConfiguration? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem4>? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem4? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminator? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminatorType? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenAIToolChoiceFunctionInner? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TurnDetectionType? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OptInSmsReminderParams? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OptOutSmsReminderParams? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrbAvatar? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderDeliverablesResponse? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DeliverableInfo>? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderFulfillmentType? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemInfo? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutput? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QuoteInfo? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemKind? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInput? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubtitleOrderItemRequest? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptionOrderItemRequest? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInputDiscriminator? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestInputDiscriminatorKind? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutputDiscriminator? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderMediaResponse? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderResponse? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OrderState? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderItemInfo>? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerGetClientAppointmentsParams? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListAssetsParams? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListLocationsParams? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListProductsParams? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListServicesParams? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OwnerListStaffParams? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PaginatedResultAgentMergeProposalResponse? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentMergeProposalResponse>? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PaginatedResultTicketListItemResponse? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketListItemResponse>? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketListItemResponse? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PaginatedResultTicketRequesterResponse? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketRequesterResponse>? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PaginatedResultTicketSLAPolicyResponse? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAPolicyResponse>? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSLAPolicyResponse? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PaginatedResultTicketTagResponse? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketTagResponse>? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketTagResponse? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.LanguagePairInfo>? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchAgentConversationTicketRequestModel? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequest? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem>? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChartsItem? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminator? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAIDashboardSettingsRequestChartDiscriminatorType? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConvAISettingsRequest? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchConversationTagRequestModel? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchWorkspaceSecretRequest? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PatchWorkspaceWebhookResponseModel? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PauseAllCampaignsResponse? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingBlocksMetadataModel? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingClipTask? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingClipTaskType? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingExternalAudiosMetadataModel? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PendingSubscriptionSwitchResponseModelNextTier? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneChannelConfigInput? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneVoiceConfigInput? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneVoiceConfigOutput? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberSortBy? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransfer? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem>? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminator? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferCustomSipHeaderDiscriminatorType? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferDestination? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPUriTransferDestination? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPUriDynamicVariableTransferDestination? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminator? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminatorType? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferTypeEnum? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UUITransferConfig? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant1? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsStatic? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsDynamicVariable? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1Discriminator? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionConfig? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformCategory? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformCategoryUsage? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlatformLimits? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StoredUsagePlatformLimit? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.PlatformCategoryUsage>? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlayDTMFToolConfig? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastBulletinModeData? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastConversationModeData? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PodcastProjectResponseModel? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PositionInput? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PositionOutput? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostAgentAvatarResponseModel? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostAgentHoldAudioResponseModel? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostWorkspaceSecretRequest? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostWorkspaceSecretResponseModel? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PricingMode? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserMemorySettingsInput? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserMemorySettingsOutput? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PrivateKeyJWTResponseAlgorithm? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureAtVersionResponseModel? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureVisibilityOutput? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProcedureDraftResponseModel? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaResponseModel? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaResponseModelStatus? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectCreationMetaType? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModel? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelTargetAudience? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelState? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelAccessLevel? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelFiction? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelSourceType? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.CaptionStyleModel>? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelAspectRatio? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioAgentSettingsModel? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionResponseModel? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryLocatorResponseModel? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExtendedResponseModelApplyTextNormalization? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVideoResponseModel? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModel? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectImageResponseModel? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVoiceResponseModel>? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVoiceResponseModel? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SourceContextVariant1? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongSourceContext? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SfxSourceContext? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectMutedTracksResponseModel? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelTargetAudience? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelState? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelAccessLevel? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelFiction? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelSourceType? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectResponseModelAspectRatio? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotExtendedResponseModel? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotResponseModel? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectSnapshotsResponseModel? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectSnapshotResponseModel>? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysis? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromotionTarget? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigInput? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLlmConfig? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminator? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem2>? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem2? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolConfigInput? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfig? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminator? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelInputToolDiscriminatorType? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigOutput? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackupLlmConfig2? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem5>? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsItem5? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolConfigOutput? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminator? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigWorkflowOverrideInput? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride>? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item>? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsVariant1Item? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminator? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagConfigWorkflowOverrideOutput? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsVariant1Item2>? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsVariant1Item2? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryRulesResponseModel? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PronunciationDictionaryVersionResponseModelPermissionOnResource? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceResponse? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSubscription? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteResult>? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteResult? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceSubscription? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriod? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryArrayJsonSchemaPropertyInput? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryArrayJsonSchemaPropertyInputPropertyKind? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryArrayJsonSchemaPropertyOutput? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryParamsJsonSchemaInput? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.QueryArrayJsonSchemaPropertyInput>? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.QueryParamsJsonSchemaOutput? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.QueryArrayJsonSchemaPropertyOutput>? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexResponseModel? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexStatus? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexUsage? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGDocumentIndexesResponseModel? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RAGDocumentIndexResponseModel>? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexBatchSuccessfulResponseModel? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexOverviewResponseModel? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel>? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RAGIndexRequestModel? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RagChunkMetadata? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RagChunkMetadata>? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReaderResourceResponseModel? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReaderResourceResponseModelResourceType? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupResponseModel? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupSharingSummary? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupSharingSummaryEveryoneRole? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RealtimeConversationGroupsResponseModel? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RealtimeConversationGroupResponseModel>? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReassignPhoneRequest? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionAddOn? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionAdjustProductStockRequest? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionAgentInfoResponse? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionAgentInfoResponseCurrency? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkingHours? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceNow? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionAssetResource? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionGroupMembership>? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionGroupMembership? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionConfirmServiceUpdateRequest? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionIntakeQuestion>? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionIntakeQuestion? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionServiceVariant>? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionServiceVariant? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionServiceKind? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ServiceLocationType? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionAddOn>? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionServicePromotion>? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionServicePromotion? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateAgentRuleRequest? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateAssetRequest? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateHolidayRequest? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateProcedureRequest? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateProductRequest? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderFulfillmentType>? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateServiceRequest? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateStaffRequest? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCreateTransferRuleRequest? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCustomerFacingAgentDeactivationReason? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCustomerFacingAgentResponse? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCustomerFacingConfigOutput? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionWidgetAppearance? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionTurnEagerness? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentRule>? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionTransferRule>? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionTransferRule? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionProcedure>? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionProcedure? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionCustomerFacingConfigPatch? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionKnowledgeSource? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionLocationDeactivationReason? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionLocationRequest? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionLocationRequestPatch? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionLocationResponse? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionPhoneAssignment? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionPhoneProvider? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionPhoneAssignmentDeactivationReason? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionPhoneRegulatoryStatus? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionProcedureResponse? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionProduct? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionPronunciationRule? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionPronunciationRulesResponse? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionPronunciationRule>? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionProvisionResellerWorkspaceRequest? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionVertical? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteRequest>? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteRequest? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionService? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionServiceUpdateResponse? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionSetPronunciationRulesRequest? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionStaffResource? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionTeamInviteResponse? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionTeamMemberResponse? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateAgentInfoRequest? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateAgentInfoRequestCurrency? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateAgentRuleRequest? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateAssetRequestPatch? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateCustomerFacingAgentRequest? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateHolidayRequestPatch? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateProcedureRequest? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateProductRequestPatch? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateProductStockRequest? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateServiceRequestPatch? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateStaffRequestPatch? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionUpdateTransferRuleRequest? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionWidgetAppearanceVariant? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReceptionWidgetAppearancePlacement? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RecordingResponseModel? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioClipLocator? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferencedToolCommonModel? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReferencedToolCommonModelType? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegexParameterEvaluationStrategy? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioRegionId? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioEdgeLocation? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegisterForGroupSessionParams? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RegisterMediaResponse? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RemoveOrderItemResponse? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RemoveVoiceFromUserVoiceCollectionResponseModel? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RenderStatus? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RenderedUserMemoryFact>? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RenderedUserMemoryFact? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReplaceWorkspaceConfigRequest? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReplicateVoiceToIsolatedEnvironmentRequestModel? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReplicateVoiceToIsolatedEnvironmentResponseModel? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReportKnowledgeGapParams? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequestPVCManualVerificationResponseModel? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RequiredConstraint? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.RequiredConstraint>? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceDetail? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceStatus? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerInvoiceLine>? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceLine? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceLineKind? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoiceSummary? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerInvoicesResponse? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerInvoiceSummary>? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerTierEconomics? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerTierResponse? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerTierResponseCurrency? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerUpcomingPayment? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerUpcomingPaymentsResponse? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerUpcomingPayment>? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceOnboardingResponse? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSort? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSubscriptionBillingPeriod? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspaceSummary? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResellerWorkspacesResponse? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerWorkspaceSummary>? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoRole? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoAnonymousAccessLevelOverride? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceAccessInfoAccessSource? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceMetadataResponseModel? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResourceMetadataResponseModelAnonymousAccessLevelOverride? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ShareOptionResponseModel>? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ShareOptionResponseModel? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseConversationErrorType? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseFilter? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResponseUnitTestModel? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RestoreCalendarEventParams? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResubmitTestsRequestModel? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModelReviewStatus? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RunAgentTestsRequestModel? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SingleTestRunRequestModel>? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleTestRunRequestModel? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RunConversationEvaluationsRequest? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigInput? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem6>? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem6? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigInputCustomSipHeaderDiscriminator? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigInputCustomSipHeaderDiscriminatorType? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination12? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigInputTransferDestinationDiscriminator? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorType? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigOutput? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem7>? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem7? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigOutputCustomSipHeaderDiscriminator? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigOutputCustomSipHeaderDiscriminatorType? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination13? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminator? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigOutputTransferDestinationDiscriminatorType? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigInput? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem2>? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem2? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigInputCustomSipHeaderDiscriminator? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigInputCustomSipHeaderDiscriminatorType? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination4? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SipUriDestinationInput? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SipUriDynamicVariableDestinationInput? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminator? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigOutput? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem3>? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem3? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigOutputCustomSipHeaderDiscriminator? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigOutputCustomSipHeaderDiscriminatorType? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination5? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SipUriDestinationOutput? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SipUriDynamicVariableDestinationOutput? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigOutputTransferDestinationDiscriminator? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPLogMessageDirection? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferInput? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Config? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferInputConfigDiscriminator? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferInputConfigDiscriminatorType? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferOutput? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Config2? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferOutputConfigDiscriminator? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferOutputConfigDiscriminatorType? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTrunkOutboundCallResponse? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SLAMetric? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBClientAccessConfig? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SearchClientsParams? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendCustomEmailParams? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateClientParams? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateStaffParams? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAssetParams? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateServiceParams? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateProductParams? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderParams? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScheduleGroupSessionParams? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateGroupSessionSeatsParams? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateCalendarEventParams? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentRuleParams? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTransferRuleParams? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentProcedureParams? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateHolidayParams? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitBusinessInfoParams? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBusinessInfoParams? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentConfigParams? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBookingPageSettingsParams? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBookingPageAppearanceParams? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SetBookingSlugParams? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateLocationParams? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TriggerUserVerificationParams? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ValidateUserVerificationCodeParams? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfigParamsDiscriminator? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SMSConversationInfoDirection? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyCommonModelInput? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyEvaluation? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SafetyRule>? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SafetyRule? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleConfigDBModelParentType? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SampleResponseModel? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSeparationResponseModel? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodeLiteralMessageInput? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TranslatedString>? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranslatedString? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodeLiteralMessageOutput? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodePromptMessageInput? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodePromptMessageOutput? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ScimGroupResponseModel? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecretDependencyResourceType? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SectionSource? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TimeRange>? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentCreatePayload? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentCreateResponse? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentDeleteResponse? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentDubResponse? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentMigrationResponse? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentTranscriptionResponse? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentTranslationResponse? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentUpdatePayload? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SegmentUpdateResponse? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SelfSubagent? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SelfSubagentExecutionMode? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageRequest? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InputItem>? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputItem? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserMessageInputItem? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageRequestInputItemDiscriminator? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageRequestInputItemDiscriminatorType? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageStreamRequest? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.InputItem2>? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InputItem2? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageStreamRequestInputItemDiscriminator? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageStreamRequestInputItemDiscriminatorType? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SetConversationGroupRequestModel? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ShareOptionResponseModelType? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimilarVoice? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceCategory? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimilarVoicesForSpeakerResponse? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SimilarVoice>? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SimulationTestModel? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleUseTokenResponseModel? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SingleUseTokenType? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SkipTurnToolConfig? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfig? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigOverride? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigOverrideConfig? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SoftTimeoutConfigWorkflowOverride? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SortDirection? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerAudioResponseModel? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerCreatedResponse? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerResponseModel? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UtteranceResponseModel>? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UtteranceResponseModel? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbedSegment>? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerSeparationResponseModelStatus? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerResponseModel>? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeakerUpdatedResponse? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ConvAISecretLocator, global::ElevenLabs.ConvAIDynamicVariable>? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechEngineResponse? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelVoiceCategory? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelState? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechHistoryItemResponseModelSource? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DialogueInputResponseModel>? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextCharacterResponseModel? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextWordResponseModel>? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWordResponseModel? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AdditionalFormatResponseModel?>? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DetectedEntity>? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditedTranscriptVariant1? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptEditError? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1Discriminator? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWebhookResponseModel? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextWordResponseModelType? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextCharacterResponseModel>? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartPVCVoiceTrainingResponseModel? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolConfig? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartProcedureToolErrorStatus? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StartSpeakerSeparationResponseModel? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StateUpdateInput? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StateUpdateOutput? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StopAllCampaignsResponse? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StopConversationTurnRequest? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamEndedData? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamEndedEvent? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamEnvelope? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Event? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamEnvelopeEventDiscriminator? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamEnvelopeEventDiscriminatorType? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamingAudioChunkWithTimestampsResponseModel? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.StudioAgentToolSettingsModel>? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioAgentToolSettingsModel? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StudioClipLocatorClipType? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubAgentInput? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubAgentInputExecutionMode? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubAgentOutput? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubAgentOutputExecutionMode? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SubAgentInput>? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SubAgentOutput>? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitCampaignRequest? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ChannelConfig2? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitWhatsAppChannelConfig? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitCampaignRequestChannelConfigDiscriminator? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitCampaignRequestChannelConfigDiscriminatorChannel? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitCampaignResponse? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitOrderResponse? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModeConfig2? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppVoiceConfig? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitWhatsAppMessageConfig? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitWhatsAppChannelConfigModeConfigDiscriminator? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitWhatsAppChannelConfigModeConfigDiscriminatorMode? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitWhatsAppTemplateRef? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionExtrasResponseModel? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionUsageResponseModel? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubscriptionResponseModel? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SuggestedAudioTag? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SupportedVoice? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSModelFamily? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SuppressLeadResponse? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SyncSlackRequestersRequest? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SyncSlackRequestersResponse? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params2? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolConfigInput? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberToolConfigInput? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicemailDetectionToolConfig? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInputParamsDiscriminator? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Params3? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolConfigOutput? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToNumberToolConfigOutput? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutputParamsDiscriminator? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSConversationalModel? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SupportedVoice>? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SuggestedAudioTag>? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TTSOutputFormat? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextNormalisationType? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteOutcome? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TeamInviteRequestRole? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateArrayOutput? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunStatus? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateArrayOutputFailureReason? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateOutput>? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutput? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateAudioOutput? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateAudioOutputFailureReason? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateBooleanOutput? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateBooleanOutputFailureReason? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateImageOutput? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateImageOutputFailureReason? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReference? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceReference? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReferenceDiscriminator? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReferenceDiscriminatorType? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateIntegerOutput? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateIntegerOutputFailureReason? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateListResponse? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateSummary>? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateSummary? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateNumberOutput? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateNumberOutputFailureReason? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateObjectOutput? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateObjectOutputFailureReason? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateOutput>? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVideoOutput? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateStringOutput? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutputDiscriminator? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutputDiscriminatorType? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplatePort? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunCreateRequest? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateRunInput>? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunInput? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunListResponse? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunResponse>? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateRunResponse? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateStringOutputFailureReason? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateVersion>? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVersion? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplatePort>? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVideoOutputFailureReason? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestConditionRationaleCommonModel? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestConditionResultCommonModel? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunMetadata? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunMetadataTestType? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunResultBucket? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestRunStatus? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestRunResultBucket>? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestSharingMode? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestType? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextContentPart? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequest? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequestDiscriminator? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author9? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketEventRequesterAuthorResponse? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketEventAIAgentAuthorResponse? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketEventHumanAgentAuthorResponse? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAssigneeChangedEventResponseAuthorDiscriminator? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAssigneeChangedEventResponseAuthorDiscriminatorType? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BeforeVariant1? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAssigneeChangedEventResponseBeforeVariant1Discriminator? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAssigneeChangedEventResponseBeforeVariant1DiscriminatorType? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AfterVariant1? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAssigneeChangedEventResponseAfterVariant1Discriminator? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAssigneeChangedEventResponseAfterVariant1DiscriminatorType? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author3? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketCreatedEventResponseAuthorDiscriminator? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketCreatedEventResponseAuthorDiscriminatorType? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author10? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketDeadlineChangedEventResponseAuthorDiscriminator? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketDeadlineChangedEventResponseAuthorDiscriminatorType? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketDeadlineStatus? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author4? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketDeletedEventResponseAuthorDiscriminator? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketDeletedEventResponseAuthorDiscriminatorType? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssigneeVariant14? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketListItemResponseAssigneeVariant1Discriminator? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketListItemResponseAssigneeVariant1DiscriminatorType? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecondaryAssigneeVariant14? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketListItemResponseSecondaryAssigneeVariant1Discriminator? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketListItemResponseSecondaryAssigneeVariant1DiscriminatorType? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author5? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketMessageEventResponseAuthorDiscriminator? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketMessageEventResponseAuthorDiscriminatorType? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author11? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketPriorityChangedEventResponseAuthorDiscriminator? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketPriorityChangedEventResponseAuthorDiscriminatorType? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAPolicyTargetOutput>? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSLAPolicyTargetOutput? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSLAStatus? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSearchMatchField? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author13? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponseAuthorDiscriminator? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponseAuthorDiscriminatorType? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BeforeVariant12? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponseBeforeVariant1Discriminator? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponseBeforeVariant1DiscriminatorType? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AfterVariant12? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponseAfterVariant1Discriminator? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponseAfterVariant1DiscriminatorType? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSortBy? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author6? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketStatusChangedEventResponseAuthorDiscriminator? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketStatusChangedEventResponseAuthorDiscriminatorType? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author8? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSubjectChangedEventResponseAuthorDiscriminator? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSubjectChangedEventResponseAuthorDiscriminatorType? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author12? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSubscribersChangedEventResponseAuthorDiscriminator? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSubscribersChangedEventResponseAuthorDiscriminatorType? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Author7? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketTagIdsChangedEventResponseAuthorDiscriminator? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketTagIdsChangedEventResponseAuthorDiscriminatorType? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TokenResponseModel? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecution? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Icon>? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolAnnotations? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallUnitTestModel? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionTaskSupport? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolCallDetailsVariant1? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1Discriminator? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModel? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolConfig? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModelToolConfigDiscriminator? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestToolCallParameter>? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameter? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModel? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolConfig2? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModelToolConfigDiscriminator? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolUsageStatsResponseModel? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolSortBy? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolTypeFilter? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ToolsResponseModel? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseModel>? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicEvaluationCriteriaAggregate? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicSentimentAggregate? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TopicEvaluationCriteriaAggregate>? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TopicSortBy? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoConfigured? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoDefaultingToMain? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoTrafficSplit? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferRuleInput? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProviderConfigsItem>? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProviderConfigsItem? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferInput? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferRuleInputProviderConfigDiscriminator? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferRuleInputProviderConfigDiscriminatorType? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferRuleOutput? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProviderConfigsItem2>? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProviderConfigsItem2? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferOutput? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferRuleOutputProviderConfigDiscriminator? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferRuleOutputProviderConfigDiscriminatorType? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTransferInput>? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentTransferOutput>? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchInfoVariant1? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1Discriminator? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BranchInfoVariant12? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1Discriminator? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumberTransfer>? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TransferRuleInput>? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TransferRuleOutput>? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OneOf<global::ElevenLabs.GuardrailLLMVerdict, global::ElevenLabs.GuardrailClassifierVerdict, global::ElevenLabs.GuardrailUnknownVerdict>? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioAnsweredBy? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigInput? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination8? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigInputTransferDestinationDiscriminator? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigInputTransferDestinationDiscriminatorType? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant13? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigInputPostDialDigitsVariant1Discriminator? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigInputPostDialDigitsVariant1DiscriminatorType? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutput? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination11? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutputTransferDestinationDiscriminator? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutputTransferDestinationDiscriminatorType? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant15? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutputPostDialDigitsVariant1Discriminator? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutputPostDialDigitsVariant1DiscriminatorType? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionAction? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionMode? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TwilioMachineDetectionRule>? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioMachineDetectionRule? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TwilioAnsweredBy>? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioOutboundCallResponse? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Config4? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInput? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferInputConfigDiscriminator? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferInputConfigDiscriminatorType? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Config6? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferOutputConfigDiscriminator? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferOutputConfigDiscriminatorType? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination14? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInputTransferDestinationDiscriminator? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInputTransferDestinationDiscriminatorType? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant16? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInputPostDialDigitsVariant1Discriminator? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInputPostDialDigitsVariant1DiscriminatorType? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination15? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminator? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminatorType? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant17? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutputPostDialDigitsVariant1Discriminator? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutputPostDialDigitsVariant1DiscriminatorType? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.URLAvatar? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestGuardrailTriggerEvaluationModel? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TestInfoVariant1? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1Discriminator? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestWorkflowNodeTransitionEvaluationNodeId? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Eval? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminator? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsRequestModel? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemAttachmentDestination>? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModel? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResultsItem3>? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ResultsItem3? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminator? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBasicAuthRequest? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateBearerAuthRequest? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentChunkingOverrideRequestModel? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentChunkingOverrideResponseModel? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateEnvironmentVariableRequest? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMemberUsageLimitRequestModel? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMemberUsageLimitResponseModel? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMusicFinetuneRequestModel? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateMusicFinetuneRequestModelVisibility? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2ClientCredsRequest? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequest? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestAlgorithm? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestTokenResponseField? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOAuth2JWTRequestJwtUsage? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateOrderResponse? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRequest? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateProcedureDraftRequestModel? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateProcedureVisibilityRequestModel? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateRealtimeConversationGroupRequestModel? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateResellerWorkspaceRequest? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateResponseUnitTestRequest? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateSimulationTestRequest? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateSpeechEngineRequest? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTestSuiteInvocationRequestModel? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTicketRequest? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AssigneeVariant13? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTicketRequestAssigneeVariant1Discriminator? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTicketRequestAssigneeVariant1DiscriminatorType? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SecondaryAssigneeVariant13? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTicketRequestSecondaryAssigneeVariant1Discriminator? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTicketRequestSecondaryAssigneeVariant1DiscriminatorType? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTicketSLAPolicyRequest? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTicketTagRequest? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateToolCallUnitTestRequest? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateWhatsAppAccountRequest? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateWorkspaceMemberResponseModel? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpsertOrderItemResponse? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsageAggregationInterval? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsageCharactersResponseModel? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserDataCollectionAnalysisItemInput? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Scoring? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminator? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminatorMode? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserMemoryScale? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ContentItem>? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentItem? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserMessageInputItemContentItemDiscriminator? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserMessageInputItemContentItemDiscriminatorType? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserResponseModel? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserVoiceCollectionResponseModelPermissionOnResource? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UsersSortBy? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?>? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequest? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequestAspectRatio? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31FastRequestResolution? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VeoImageReference>? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VeoImageReference? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31Request? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31RequestAspectRatio? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Veo31RequestResolution? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VeoImageReferenceRole? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VerifyPVCVoiceCaptchaResponseModel? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysisStatus? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoAnalysisResult? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoSubject>? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSubject? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoSegment>? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSegment? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoKeyMoment>? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoKeyMoment? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequest? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequestDiscriminator? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReferenceDiscriminator? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReferenceDiscriminatorType? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceDesignRequestModel? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceDesignRequestModelModelId? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewResponseModel? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewsRequestModel? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoicePreviewsResponseModel? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoicePreviewResponseModel>? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceRemixRequestModel? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.SampleResponseModel>? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelCategory? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModel? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelSafetyControl? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceVerificationResponseModel? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelRecordingQuality? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceResponseModelLabellingStatus? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSamplePreviewResponseModel? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSampleVisualWaveformResponseModel? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingModerationCheckResponseModel? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelStatus? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelCategory? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSharingResponseModelReviewStatus? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReaderResourceResponseModel>? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WatermarkCheck? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WatermarkDetails? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookAuthMethodType? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookOutcome? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookSendResultResponseModel? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetAll? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetIds? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetDiscriminator? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookTargetDiscriminatorType? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInput? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInputMethod? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.LiteralJsonSchemaProperty>? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigInputContentType? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutput? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutputMethod? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookToolApiSchemaConfigOutputContentType? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WebhookUsageType? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppCallPermissionRequest? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppCallPermissionRequestState? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ModeConfig? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppMessageConfig? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppChannelConfigModeConfigDiscriminator? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppChannelConfigModeConfigDiscriminatorMode? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppConversationInfoDirection? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppRecipient? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOpeningMessage? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplate? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOutboundCallResponse? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppOutboundMessageResponse? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateParameterFormat? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateComponent>? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateComponent? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateTextParam>? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateTextParam? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateComponentButton>? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateComponentButton? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateDocumentParam? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateDocumentParamDetails? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ParametersItem>? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ParametersItem? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateImageParam? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateLocationParam? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminator? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateImageParamDetails? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateLocationParamDetails? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetPlacement? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetExpandable? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetFeedbackMode? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetEndFeedbackConfig? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigInputSyntaxHighlightTheme? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTextContents? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetStyles? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetLayout? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WidgetLanguagePreset>? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetLanguagePreset? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigOutputSyntaxHighlightTheme? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetConfigResponseModelSyntaxHighlightTheme? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WidgetLanguagePresetResponse>? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetLanguagePresetResponse? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetEndFeedbackType? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTextContentsTranslation? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WidgetTermsTranslation? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForwardConditionVariant1? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUnconditionalModelInput? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowLLMConditionModelInput? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowResultConditionModelInput? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowExpressionConditionModelInput? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1Discriminator? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackwardConditionVariant1? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PositionInput>? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ForwardConditionVariant12? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUnconditionalModelOutput? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowLLMConditionModelOutput? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowResultConditionModelOutput? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowExpressionConditionModelOutput? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BackwardConditionVariant12? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1Discriminator? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.PositionOutput>? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeOutcome? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem4>? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem4? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminator? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination6? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminator? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant12? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1Discriminator? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProviderConfigsItem3>? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProviderConfigsItem3? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminator? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem5>? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSipHeadersItem5? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TransferDestination9? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminator? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostDialDigitsVariant14? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProviderConfigsItem4>? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProviderConfigsItem4? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminator? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Message? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowSayNodeModelInputMessageDiscriminator? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowSayNodeModelInputMessageDiscriminatorType? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Message2? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowSayNodeModelOutputMessageDiscriminator? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowSayNodeModelOutputMessageDiscriminatorType? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolEdgeStepModel? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocator? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SchemaOverridesVariant1? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminator? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolLocatorSchemaOverridesDiscriminatorSource? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNestedToolsStepModelInput? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkflowToolLocator>? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem>? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StepsItem? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminator? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem2>? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StepsItem2? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminator? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.StateUpdateInput>? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.StateUpdateOutput>? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::ElevenLabs.TimeRangeModel>>? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>>? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ColumnUnit?>? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceApiKeyListResponseModel? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceApiKeyResponseModel>? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceApiKeyResponseModel? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAuditLogEntryResponse? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceAuditLogsPageResponse? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAuditLogEntryResponse>? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceBatchCallsResponse? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.BatchCallResponse>? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceConfigResponse? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateApiKeyResponseModel? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateServiceAccountResponseModel? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceCreateWebhookResponseModel? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupByNameResponseModel? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceGroupPermission? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupPermission>? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceMemberResponseModel? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceServiceAccountListResponseModel? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceServiceAccountResponseModel>? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceServiceAccountResponseModel? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupResponseModel>? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookListResponseModel? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookResponseModel>? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookResponseModel? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkspaceWebhookUsageResponseModel? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationNode? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateOAuth2ClientCredsRequest, global::ElevenLabs.UpdateBasicAuthRequest, global::ElevenLabs.UpdateBearerAuthRequest, global::ElevenLabs.UpdateOAuth2JWTRequest>? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.CreateResponseUnitTestRequest, global::ElevenLabs.CreateToolCallUnitTestRequest, global::ElevenLabs.CreateSimulationTestRequest>? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest>? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.CreateTwilioPhoneNumberRequest, global::ElevenLabs.CreateExotelPhoneNumberRequest, global::ElevenLabs.CreateSIPTrunkPhoneNumberRequestV2>? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.UserEvaluationAnalysisItem, global::ElevenLabs.UserDataCollectionAnalysisItemInput>? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequest? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminator? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistorySortDirection? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistorySource? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetSpeechHistorySourcesVariant1Item>? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetSpeechHistorySourcesVariant1Item? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.NonStreamingOutputFormats?, global::ElevenLabs.AllowedOutputFormats?>? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechFullOutputFormat? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechStreamOutputFormat? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToSpeechFullOutputFormat? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToSpeechStreamOutputFormat? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DubbingProjectListSortDirection? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingStatus? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingStatusesVariant1Item? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsDubbingModelsVariant1Item? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsCreationSourcesVariant1Item? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsFilterByCreator? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsOrderBy? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListDubsOrderDirection? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDubbedTranscriptFileFormatType? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDubbingTranscriptsFormatType? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPronunciationDictionariesMetadataSort? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestType>? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListChatResponseTestsRouteSortMode? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoriesRouteSummaryMode? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item>? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.GuardrailType>? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetConversationHistoryRouteFormat? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item>? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketSource>? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketPriority>? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolTypeFilter>? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CampaignStatus>? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCampaignsMode? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCampaignLeadsStatus? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TerminalDisposition>? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallResult>? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListCampaignCallsStage? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListEnvironmentVariablesType? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatus>? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriority>? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAStatus>? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketDeadlineStatus>? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerateOutputFormat? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComposeDetailedOutputFormat? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ComposeDetailedStreamOutputFormat? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamComposeOutputFormat? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetFinetunesSort? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetFinetunesSortDirection? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.OrderState>? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListVideoGenerationsStatus? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListImageGenerationsStatus? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListTextToSpeechGenerationsStatus? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.DownloadSpeechHistoryItemsResponse? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DubbingTranscriptResponseModel, string>? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ModelResponseModel>? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponse? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponseDiscriminator? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponse? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponseDiscriminator? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.WorkspaceGroupResponseModel>? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupByNameResponseModel>? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceMemberResponseModel>? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponse2? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminator? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentSummariesRouteResponseDiscriminatorStatus? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponse? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminator? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentResponseTestRouteResponseDiscriminatorType? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponse? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminator? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.AssignableUserResponseModel>? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItem? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminator? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersRouteResponseItemDiscriminatorProvider? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponse? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminator? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetPhoneNumberRouteResponseDiscriminatorProvider? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponse? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminator? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdatePhoneNumberRouteResponseDiscriminatorProvider? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponse2? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminator? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponse? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponseDiscriminator? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponse? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminator? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponse? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminator? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateFileDocumentRouteResponseDiscriminatorType? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponse2? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminator? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponse? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminator? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponse2? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminator? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionService>? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionAssetResource>? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionProduct>? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionStaffResource>? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionCustomerFacingAgentResponse>? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionProcedureResponse>? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionPhoneAssignment>? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.HolidayResponseModel>? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionLocationResponse>? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionKnowledgeSource>? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ResellerTierResponse>? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionTeamMemberResponse>? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionTeamInviteResponse>? Type3392 { get; set; }

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
        public global::System.Collections.Generic.List<global::ElevenLabs.SubmitCampaignRecipient>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ExportOptions>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EvaluationCriteriaItem>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DataCollectionItem>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EvaluationCriteriaItem2>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DataCollectionItem2>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentVersionMetadata>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketCommentResponseModel>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TurnCommentResponseModel>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketPriorityChangeResponseModel>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketStatusChangeResponseModel>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentDeploymentRequestItem>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentKnowledgeBaseRagListingEntryResponseModel>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MergeProposalReview>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MergeProposalComment>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CallingPeriod>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DateOverride>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentResponseAttachment>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptResponseModel>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AttachedTestModel>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResourceAccessInfo>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifier, global::ElevenLabs.AlertingPagerDutyNotifier, global::ElevenLabs.AlertingSlackNotifier>>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.AlertingWebhookNotifierResponse, global::ElevenLabs.AlertingPagerDutyNotifierResponse, global::ElevenLabs.AlertingSlackNotifierResponse>>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemVersionResponseModel>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemResponseModel>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ObjectJsonSchemaPropertyInput>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ObjectJsonSchemaPropertyOutput>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableAssignment>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AssetResponse>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AttentionView>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioSegment>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioKeyMoment>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioEffectsFilterPresetResponseModel>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioEffectsEnvironmentResponseModel>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioEffectsBackgroundNoiseResponseModel>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceSegment>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem3>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.McpServersItem>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentIntegrationConnectionIdentifier>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AllowlistItem>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Llm>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OutboundCallRecipientResponseModel>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetOrCreateRAGIndexRequestModel>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorDBModel>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MetronomeUsageColumnFilter>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ColumnFilter>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConflictResolution>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateParamsItem>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PromptEvaluationCriteria>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OutboundCallRecipient>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DialogueInput>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookEventType>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>, string>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PermissionType>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupConfig>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<string>, global::ElevenLabs.BodyEditServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysApiKeyIdPatchAllowedIps?>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ImageReference>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoReference>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioReference>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CallingIntervalPolicy>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CallView>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LeadView>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CampaignResponse>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CallingPeriodPolicy>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DateOverridePolicy>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentParagraphTtsNodeInputModel>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ChapterContentBlockTtsNodeResponseModel, global::ElevenLabs.ChapterContentBlockExtendableNodeResponseModel>>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockInputModel>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterContentBlockResponseModel>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CharacterAlignmentModel>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterSnapshotResponseModel>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceStatisticsResponseModel>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, global::System.DateTime?, bool?>?>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ProcedureValidationError>>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProcedureValidationError>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.List<object>, object>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem6>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.McpServersItem2>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SecretDependencyType>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WebhookEventType>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ClientEvent>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DataCollectionResultCommonModel>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ScopedAnalysisResult>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceRewardModel>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryMultivoiceMessagePartModel>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConfigEntityType>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DynamicVariableUpdateCommonModel>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInput>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationReasoningModel>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TriggeredGuardrailCommonModel>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelOutput>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptFileInputResponseModel>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigOutput>>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigOutput>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationVoiceUsageModel>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TextOutputItem>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ClientToolCallRequiredAction>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.FrustratedConversationRef>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TurnCommentRequestModel>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentSuccessfulResponseExample>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentFailureResponseExample>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigInput>>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseMockConfigInput>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketSubscriberRequest>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketSLAPolicyTargetInput>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomGuardrailConfig>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.DataCollectionValueSchemaType?, global::System.Collections.Generic.List<string>>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WordTimestamp>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReadMetadataChapterDBModel>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DirectPublishingReadResponseModelGenreVariant1Item>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Contributor>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SegmentSubtitleFrame>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptSegment>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTargetTranscriptSegment>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingLanguageResponse>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoicesNotPermittedWarning>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingMetadataResponse>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingProjectResponse>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptUtterance>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptWord>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptCharacter>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocator>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EnvironmentVariableResponse>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EnvironmentResponse>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RenderedUserMemoryEntity>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModel>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VerificationAttemptResponseModel>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentCharacterResponseModel>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ForcedAlignmentWordResponseModel>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketResponseModel>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetWhatsAppAccountResponse>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem3>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentBranchInfo>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTestFolderPathSegmentResponseModel>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTopicResponseModel>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentSummaryResponseModel>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem4>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AudioIsolationHistoryItemResponseModel>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChapterResponseModel>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem2>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VisitedAgentRef>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationSummaryMessageModel>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationTagResponseModel>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationUserResponseModel>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationSummaryResponseModel>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem5>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DocumentUsageModeEnum>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseFolderPathSegmentResponseModel>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DocumentsItem>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem3>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem5>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem4>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem2>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LibraryVoiceResponseModel>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MediaCodec>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem3>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectResponseModel>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SIPLogMessage>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechHistoryItemResponseModel>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestInvocationSummaryResponseModel>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestRunResultSummary>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestRunResponseModel>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestSummaryResponseModel>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketSubscriberResponse>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EventsItem>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentsItem2>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolExecutionResponseModel>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UserVoiceCollectionResponseModel>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceAccentResponseModel>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoiceResponseModel>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ConvAIWorkspaceStoredSecretConfig>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TimeRangeModel>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.IdentityPolicyRule>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ImageSubject>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DiscountResponseModel>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InvoiceResponseModelPaymentIntentStatusse>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseContentSearchResult>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SearchHighlightSegment>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseRagChunkModel>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SearchStrategy>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMReasoningEffort>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMServiceTier>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMInfoModel>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LLMLiteralJsonSchemaPropertyType?, global::System.Collections.Generic.List<string>>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LLMUsageCalculatorLLMResponseModel>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguageInfo>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AuthConnectionsItem>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetCrawlJobResponseModel>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Tool>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolApprovalStatus>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderSummary>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProcedureListItemResponseModel>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentBranchSummary>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentDeploymentHistoryItem>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechEngineSummaryResponse>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnyOf<global::ElevenLabs.LiteralJsonSchemaPropertyType?, global::System.Collections.Generic.List<string>>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolApprovalHash>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverrideInput>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPToolConfigOverrideOutput>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DependentAgentsItem>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MCPServerResponseModel>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ManualVerificationFileResponseModel>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MediaGenerationResponse>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumbersItem2>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.FieldConflict>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MessagesSearchResult>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguageResponseModel>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextChunkResponseModel>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.MusicFinetuneResponseModel>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SongSection>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelAttribute>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelScopeSpans>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelSpan>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OTelResourceSpans>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem4>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DeliverableInfo>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderItemInfo>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentMergeProposalResponse>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketListItemResponse>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketRequesterResponse>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketSLAPolicyResponse>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketTagResponse>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.LanguagePairInfo>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ChartsItem>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionResponseModel>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryLocatorResponseModel>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.ProjectVideoResponseModel, global::ElevenLabs.ProjectExternalAudioResponseModel, global::ElevenLabs.ProjectImageResponseModel>>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectVoiceResponseModel>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectSnapshotResponseModel>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProjectVideoThumbnailSheetResponseModel>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseLocator>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem2>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem5>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsVariant1Item>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolsVariant1Item2>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TeamInviteResult>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RAGDocumentIndexResponseModel>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RAGIndexOverviewEmbeddingModelResponseModel>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RagChunkMetadata>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RealtimeConversationGroupResponseModel>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionGroupMembership>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionIntakeQuestion>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionServiceVariant>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionAddOn>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionServicePromotion>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderFulfillmentType>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentRule>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionTransferRule>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionProcedure>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionPronunciationRule>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TeamInviteRequest>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RenderedUserMemoryFact>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.RequiredConstraint>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerInvoiceLine>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerInvoiceSummary>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerUpcomingPayment>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerWorkspaceSummary>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ShareOptionResponseModel>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SingleTestRunRequestModel>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem6>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem7>? ListType294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem2>? ListType295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem3>? ListType296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SafetyRule>? ListType297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TimeRange>? ListType298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InputItem>? ListType299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.InputItem2>? ListType300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SimilarVoice>? ListType301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UtteranceResponseModel>? ListType302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DialogueInputResponseModel>? ListType303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextWordResponseModel>? ListType304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AdditionalFormatResponseModel?>? ListType305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DetectedEntity>? ListType306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextCharacterResponseModel>? ListType307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SubAgentInput>? ListType308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SubAgentOutput>? ListType309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SupportedVoice>? ListType310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SuggestedAudioTag>? ListType311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PydanticPronunciationDictionaryVersionLocator>? ListType312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateOutput>? ListType313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateSummary>? ListType314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateRunInput>? ListType315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateRunResponse>? ListType316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplateVersion>? ListType317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TemplatePort>? ListType318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestRunResultBucket>? ListType319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketSLAPolicyTargetOutput>? ListType320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Icon>? ListType321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.UnitTestToolCallParameter>? ListType322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolResponseModel>? ListType323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TopicEvaluationCriteriaAggregate>? ListType324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProviderConfigsItem>? ListType325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProviderConfigsItem2>? ListType326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTransferInput>? ListType327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentTransferOutput>? ListType328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PhoneNumberTransfer>? ListType329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TransferRuleInput>? ListType330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TransferRuleOutput>? ListType331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TwilioMachineDetectionRule>? ListType332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TwilioAnsweredBy>? ListType333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnalysisItemAttachmentDestination>? ListType334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResultsItem3>? ListType335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<double>>? ListType336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ContentItem>? ListType337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>? ListType338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VeoImageReference>? ListType339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoSubject>? ListType340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoSegment>? ListType341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VideoKeyMoment>? ListType342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.VoicePreviewResponseModel>? ListType343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.SampleResponseModel>? ListType344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReaderResourceResponseModel>? ListType345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WhatsAppTemplateComponent>? ListType346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WhatsAppTemplateTextParam>? ListType347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WhatsAppTemplateComponentButton>? ListType348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ParametersItem>? ListType349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PositionInput>? ListType350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.PositionOutput>? ListType351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem4>? ListType352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProviderConfigsItem3>? ListType353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CustomSipHeadersItem5>? ListType354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ProviderConfigsItem4>? ListType355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkflowToolLocator>? ListType356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.StepsItem>? ListType357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.StepsItem2>? ListType358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.StateUpdateInput>? ListType359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.StateUpdateOutput>? ListType360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::ElevenLabs.TimeRangeModel>>? ListType361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>? ListType362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>>? ListType363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?>?>? ListType364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ColumnUnit?>? ListType365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceApiKeyResponseModel>? ListType366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAuditLogEntryResponse>? ListType367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.BatchCallResponse>? ListType368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupPermission>? ListType369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceServiceAccountResponseModel>? ListType370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.DefaultSharingGroupResponseModel>? ListType371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookResponseModel>? ListType372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceWebhookUsageResponseModel>? ListType373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetSpeechHistorySourcesVariant1Item>? ListType374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>? ListType375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>? ListType376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>? ListType377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TestType>? ListType378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GetConversationHistoriesRouteExcludeStatusesVariant1Item>? ListType379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.GuardrailType>? ListType380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TextSearchConversationMessagesRouteExcludeStatusesVariant1Item>? ListType381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketSource>? ListType382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AgentConversationTicketPriority>? ListType383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.KnowledgeBaseDocumentType>? ListType384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ToolTypeFilter>? ListType385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CampaignStatus>? ListType386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TerminalDisposition>? ListType387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.CallResult>? ListType388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketStatus>? ListType389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketPriority>? ListType390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketSLAStatus>? ListType391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.TicketDeadlineStatus>? ListType392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.OrderState>? ListType393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ModelResponseModel>? ListType394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceGroupByNameResponseModel>? ListType395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceMemberResponseModel>? ListType396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.AssignableUserResponseModel>? ListType397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>? ListType398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionService>? ListType399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionAssetResource>? ListType400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionProduct>? ListType401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionStaffResource>? ListType402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionCustomerFacingAgentResponse>? ListType403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionProcedureResponse>? ListType404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionPhoneAssignment>? ListType405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.HolidayResponseModel>? ListType406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionLocationResponse>? ListType407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionKnowledgeSource>? ListType408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ResellerTierResponse>? ListType409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionTeamMemberResponse>? ListType410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.ReceptionTeamInviteResponse>? ListType411 { get; set; }
    }
}