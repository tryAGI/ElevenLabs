#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultVariant1 : global::System.IEquatable<ResultVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType? ResultType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.EndCallToolResultModel? EndCallSuccess { get; init; }
#else
        public global::ElevenLabs.EndCallToolResultModel? EndCallSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndCallSuccess))]
#endif
        public bool IsEndCallSuccess => EndCallSuccess != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEndCallSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.EndCallToolResultModel? value)
        {
            value = EndCallSuccess;
            return IsEndCallSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.LanguageDetectionToolResultModel? LanguageDetectionSuccess { get; init; }
#else
        public global::ElevenLabs.LanguageDetectionToolResultModel? LanguageDetectionSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LanguageDetectionSuccess))]
#endif
        public bool IsLanguageDetectionSuccess => LanguageDetectionSuccess != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLanguageDetectionSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.LanguageDetectionToolResultModel? value)
        {
            value = LanguageDetectionSuccess;
            return IsLanguageDetectionSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TransferToAgentToolResultSuccessModel? TransferToAgentSuccess { get; init; }
#else
        public global::ElevenLabs.TransferToAgentToolResultSuccessModel? TransferToAgentSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToAgentSuccess))]
#endif
        public bool IsTransferToAgentSuccess => TransferToAgentSuccess != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransferToAgentSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TransferToAgentToolResultSuccessModel? value)
        {
            value = TransferToAgentSuccess;
            return IsTransferToAgentSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TransferToAgentToolResultErrorModel? TransferToAgentError { get; init; }
#else
        public global::ElevenLabs.TransferToAgentToolResultErrorModel? TransferToAgentError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToAgentError))]
#endif
        public bool IsTransferToAgentError => TransferToAgentError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransferToAgentError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TransferToAgentToolResultErrorModel? value)
        {
            value = TransferToAgentError;
            return IsTransferToAgentError;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? TransferToNumberTwilioSuccess { get; init; }
#else
        public global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? TransferToNumberTwilioSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToNumberTwilioSuccess))]
#endif
        public bool IsTransferToNumberTwilioSuccess => TransferToNumberTwilioSuccess != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransferToNumberTwilioSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? value)
        {
            value = TransferToNumberTwilioSuccess;
            return IsTransferToNumberTwilioSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TransferToNumberResultSipSuccessModel? TransferToNumberSipSuccess { get; init; }
#else
        public global::ElevenLabs.TransferToNumberResultSipSuccessModel? TransferToNumberSipSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToNumberSipSuccess))]
#endif
        public bool IsTransferToNumberSipSuccess => TransferToNumberSipSuccess != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransferToNumberSipSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TransferToNumberResultSipSuccessModel? value)
        {
            value = TransferToNumberSipSuccess;
            return IsTransferToNumberSipSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TransferToNumberResultErrorModel? TransferToNumberError { get; init; }
#else
        public global::ElevenLabs.TransferToNumberResultErrorModel? TransferToNumberError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToNumberError))]
#endif
        public bool IsTransferToNumberError => TransferToNumberError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransferToNumberError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TransferToNumberResultErrorModel? value)
        {
            value = TransferToNumberError;
            return IsTransferToNumberError;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SkipTurnToolResponseModel? SkipTurnSuccess { get; init; }
#else
        public global::ElevenLabs.SkipTurnToolResponseModel? SkipTurnSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SkipTurnSuccess))]
#endif
        public bool IsSkipTurnSuccess => SkipTurnSuccess != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSkipTurnSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SkipTurnToolResponseModel? value)
        {
            value = SkipTurnSuccess;
            return IsSkipTurnSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PlayDTMFResultSuccessModel? PlayDtmfSuccess { get; init; }
#else
        public global::ElevenLabs.PlayDTMFResultSuccessModel? PlayDtmfSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlayDtmfSuccess))]
#endif
        public bool IsPlayDtmfSuccess => PlayDtmfSuccess != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPlayDtmfSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.PlayDTMFResultSuccessModel? value)
        {
            value = PlayDtmfSuccess;
            return IsPlayDtmfSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PlayDTMFResultErrorModel? PlayDtmfError { get; init; }
#else
        public global::ElevenLabs.PlayDTMFResultErrorModel? PlayDtmfError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlayDtmfError))]
#endif
        public bool IsPlayDtmfError => PlayDtmfError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPlayDtmfError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.PlayDTMFResultErrorModel? value)
        {
            value = PlayDtmfError;
            return IsPlayDtmfError;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.VoiceMailDetectionResultSuccessModel? VoicemailDetectionSuccess { get; init; }
#else
        public global::ElevenLabs.VoiceMailDetectionResultSuccessModel? VoicemailDetectionSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoicemailDetectionSuccess))]
#endif
        public bool IsVoicemailDetectionSuccess => VoicemailDetectionSuccess != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVoicemailDetectionSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.VoiceMailDetectionResultSuccessModel? value)
        {
            value = VoicemailDetectionSuccess;
            return IsVoicemailDetectionSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TestToolResultModel? TestingToolResult { get; init; }
#else
        public global::ElevenLabs.TestToolResultModel? TestingToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestingToolResult))]
#endif
        public bool IsTestingToolResult => TestingToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestingToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TestToolResultModel? value)
        {
            value = TestingToolResult;
            return IsTestingToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.KnowledgeBaseRagToolResultModel? KnowledgeBaseRagSuccess { get; init; }
#else
        public global::ElevenLabs.KnowledgeBaseRagToolResultModel? KnowledgeBaseRagSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KnowledgeBaseRagSuccess))]
#endif
        public bool IsKnowledgeBaseRagSuccess => KnowledgeBaseRagSuccess != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickKnowledgeBaseRagSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.KnowledgeBaseRagToolResultModel? value)
        {
            value = KnowledgeBaseRagSuccess;
            return IsKnowledgeBaseRagSuccess;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.EndCallToolResultModel value) => new ResultVariant1((global::ElevenLabs.EndCallToolResultModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.EndCallToolResultModel?(ResultVariant1 @this) => @this.EndCallSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.EndCallToolResultModel? value)
        {
            EndCallSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromEndCallSuccess(global::ElevenLabs.EndCallToolResultModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.LanguageDetectionToolResultModel value) => new ResultVariant1((global::ElevenLabs.LanguageDetectionToolResultModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.LanguageDetectionToolResultModel?(ResultVariant1 @this) => @this.LanguageDetectionSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.LanguageDetectionToolResultModel? value)
        {
            LanguageDetectionSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromLanguageDetectionSuccess(global::ElevenLabs.LanguageDetectionToolResultModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.TransferToAgentToolResultSuccessModel value) => new ResultVariant1((global::ElevenLabs.TransferToAgentToolResultSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToAgentToolResultSuccessModel?(ResultVariant1 @this) => @this.TransferToAgentSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.TransferToAgentToolResultSuccessModel? value)
        {
            TransferToAgentSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromTransferToAgentSuccess(global::ElevenLabs.TransferToAgentToolResultSuccessModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.TransferToAgentToolResultErrorModel value) => new ResultVariant1((global::ElevenLabs.TransferToAgentToolResultErrorModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToAgentToolResultErrorModel?(ResultVariant1 @this) => @this.TransferToAgentError;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.TransferToAgentToolResultErrorModel? value)
        {
            TransferToAgentError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromTransferToAgentError(global::ElevenLabs.TransferToAgentToolResultErrorModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel value) => new ResultVariant1((global::ElevenLabs.TransferToNumberResultTwilioSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToNumberResultTwilioSuccessModel?(ResultVariant1 @this) => @this.TransferToNumberTwilioSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? value)
        {
            TransferToNumberTwilioSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromTransferToNumberTwilioSuccess(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.TransferToNumberResultSipSuccessModel value) => new ResultVariant1((global::ElevenLabs.TransferToNumberResultSipSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToNumberResultSipSuccessModel?(ResultVariant1 @this) => @this.TransferToNumberSipSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.TransferToNumberResultSipSuccessModel? value)
        {
            TransferToNumberSipSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromTransferToNumberSipSuccess(global::ElevenLabs.TransferToNumberResultSipSuccessModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.TransferToNumberResultErrorModel value) => new ResultVariant1((global::ElevenLabs.TransferToNumberResultErrorModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToNumberResultErrorModel?(ResultVariant1 @this) => @this.TransferToNumberError;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.TransferToNumberResultErrorModel? value)
        {
            TransferToNumberError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromTransferToNumberError(global::ElevenLabs.TransferToNumberResultErrorModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.SkipTurnToolResponseModel value) => new ResultVariant1((global::ElevenLabs.SkipTurnToolResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SkipTurnToolResponseModel?(ResultVariant1 @this) => @this.SkipTurnSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.SkipTurnToolResponseModel? value)
        {
            SkipTurnSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromSkipTurnSuccess(global::ElevenLabs.SkipTurnToolResponseModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.PlayDTMFResultSuccessModel value) => new ResultVariant1((global::ElevenLabs.PlayDTMFResultSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PlayDTMFResultSuccessModel?(ResultVariant1 @this) => @this.PlayDtmfSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.PlayDTMFResultSuccessModel? value)
        {
            PlayDtmfSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromPlayDtmfSuccess(global::ElevenLabs.PlayDTMFResultSuccessModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.PlayDTMFResultErrorModel value) => new ResultVariant1((global::ElevenLabs.PlayDTMFResultErrorModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PlayDTMFResultErrorModel?(ResultVariant1 @this) => @this.PlayDtmfError;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.PlayDTMFResultErrorModel? value)
        {
            PlayDtmfError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromPlayDtmfError(global::ElevenLabs.PlayDTMFResultErrorModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.VoiceMailDetectionResultSuccessModel value) => new ResultVariant1((global::ElevenLabs.VoiceMailDetectionResultSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.VoiceMailDetectionResultSuccessModel?(ResultVariant1 @this) => @this.VoicemailDetectionSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.VoiceMailDetectionResultSuccessModel? value)
        {
            VoicemailDetectionSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromVoicemailDetectionSuccess(global::ElevenLabs.VoiceMailDetectionResultSuccessModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.TestToolResultModel value) => new ResultVariant1((global::ElevenLabs.TestToolResultModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TestToolResultModel?(ResultVariant1 @this) => @this.TestingToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.TestToolResultModel? value)
        {
            TestingToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromTestingToolResult(global::ElevenLabs.TestToolResultModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant1(global::ElevenLabs.KnowledgeBaseRagToolResultModel value) => new ResultVariant1((global::ElevenLabs.KnowledgeBaseRagToolResultModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.KnowledgeBaseRagToolResultModel?(ResultVariant1 @this) => @this.KnowledgeBaseRagSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(global::ElevenLabs.KnowledgeBaseRagToolResultModel? value)
        {
            KnowledgeBaseRagSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultVariant1 FromKnowledgeBaseRagSuccess(global::ElevenLabs.KnowledgeBaseRagToolResultModel? value) => new ResultVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant1(
            global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType? resultType,
            global::ElevenLabs.EndCallToolResultModel? endCallSuccess,
            global::ElevenLabs.LanguageDetectionToolResultModel? languageDetectionSuccess,
            global::ElevenLabs.TransferToAgentToolResultSuccessModel? transferToAgentSuccess,
            global::ElevenLabs.TransferToAgentToolResultErrorModel? transferToAgentError,
            global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? transferToNumberTwilioSuccess,
            global::ElevenLabs.TransferToNumberResultSipSuccessModel? transferToNumberSipSuccess,
            global::ElevenLabs.TransferToNumberResultErrorModel? transferToNumberError,
            global::ElevenLabs.SkipTurnToolResponseModel? skipTurnSuccess,
            global::ElevenLabs.PlayDTMFResultSuccessModel? playDtmfSuccess,
            global::ElevenLabs.PlayDTMFResultErrorModel? playDtmfError,
            global::ElevenLabs.VoiceMailDetectionResultSuccessModel? voicemailDetectionSuccess,
            global::ElevenLabs.TestToolResultModel? testingToolResult,
            global::ElevenLabs.KnowledgeBaseRagToolResultModel? knowledgeBaseRagSuccess
            )
        {
            ResultType = resultType;

            EndCallSuccess = endCallSuccess;
            LanguageDetectionSuccess = languageDetectionSuccess;
            TransferToAgentSuccess = transferToAgentSuccess;
            TransferToAgentError = transferToAgentError;
            TransferToNumberTwilioSuccess = transferToNumberTwilioSuccess;
            TransferToNumberSipSuccess = transferToNumberSipSuccess;
            TransferToNumberError = transferToNumberError;
            SkipTurnSuccess = skipTurnSuccess;
            PlayDtmfSuccess = playDtmfSuccess;
            PlayDtmfError = playDtmfError;
            VoicemailDetectionSuccess = voicemailDetectionSuccess;
            TestingToolResult = testingToolResult;
            KnowledgeBaseRagSuccess = knowledgeBaseRagSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            KnowledgeBaseRagSuccess as object ??
            TestingToolResult as object ??
            VoicemailDetectionSuccess as object ??
            PlayDtmfError as object ??
            PlayDtmfSuccess as object ??
            SkipTurnSuccess as object ??
            TransferToNumberError as object ??
            TransferToNumberSipSuccess as object ??
            TransferToNumberTwilioSuccess as object ??
            TransferToAgentError as object ??
            TransferToAgentSuccess as object ??
            LanguageDetectionSuccess as object ??
            EndCallSuccess as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EndCallSuccess?.ToString() ??
            LanguageDetectionSuccess?.ToString() ??
            TransferToAgentSuccess?.ToString() ??
            TransferToAgentError?.ToString() ??
            TransferToNumberTwilioSuccess?.ToString() ??
            TransferToNumberSipSuccess?.ToString() ??
            TransferToNumberError?.ToString() ??
            SkipTurnSuccess?.ToString() ??
            PlayDtmfSuccess?.ToString() ??
            PlayDtmfError?.ToString() ??
            VoicemailDetectionSuccess?.ToString() ??
            TestingToolResult?.ToString() ??
            KnowledgeBaseRagSuccess?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult && !IsKnowledgeBaseRagSuccess || !IsEndCallSuccess && IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult && !IsKnowledgeBaseRagSuccess || !IsEndCallSuccess && !IsLanguageDetectionSuccess && IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult && !IsKnowledgeBaseRagSuccess || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult && !IsKnowledgeBaseRagSuccess || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult && !IsKnowledgeBaseRagSuccess || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult && !IsKnowledgeBaseRagSuccess || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult && !IsKnowledgeBaseRagSuccess || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult && !IsKnowledgeBaseRagSuccess || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult && !IsKnowledgeBaseRagSuccess || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult && !IsKnowledgeBaseRagSuccess || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && IsVoicemailDetectionSuccess && !IsTestingToolResult && !IsKnowledgeBaseRagSuccess || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && IsTestingToolResult && !IsKnowledgeBaseRagSuccess || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult && IsKnowledgeBaseRagSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.EndCallToolResultModel, TResult>? endCallSuccess = null,
            global::System.Func<global::ElevenLabs.LanguageDetectionToolResultModel, TResult>? languageDetectionSuccess = null,
            global::System.Func<global::ElevenLabs.TransferToAgentToolResultSuccessModel, TResult>? transferToAgentSuccess = null,
            global::System.Func<global::ElevenLabs.TransferToAgentToolResultErrorModel, TResult>? transferToAgentError = null,
            global::System.Func<global::ElevenLabs.TransferToNumberResultTwilioSuccessModel, TResult>? transferToNumberTwilioSuccess = null,
            global::System.Func<global::ElevenLabs.TransferToNumberResultSipSuccessModel, TResult>? transferToNumberSipSuccess = null,
            global::System.Func<global::ElevenLabs.TransferToNumberResultErrorModel, TResult>? transferToNumberError = null,
            global::System.Func<global::ElevenLabs.SkipTurnToolResponseModel, TResult>? skipTurnSuccess = null,
            global::System.Func<global::ElevenLabs.PlayDTMFResultSuccessModel, TResult>? playDtmfSuccess = null,
            global::System.Func<global::ElevenLabs.PlayDTMFResultErrorModel, TResult>? playDtmfError = null,
            global::System.Func<global::ElevenLabs.VoiceMailDetectionResultSuccessModel, TResult>? voicemailDetectionSuccess = null,
            global::System.Func<global::ElevenLabs.TestToolResultModel, TResult>? testingToolResult = null,
            global::System.Func<global::ElevenLabs.KnowledgeBaseRagToolResultModel, TResult>? knowledgeBaseRagSuccess = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCallSuccess && endCallSuccess != null)
            {
                return endCallSuccess(EndCallSuccess!);
            }
            else if (IsLanguageDetectionSuccess && languageDetectionSuccess != null)
            {
                return languageDetectionSuccess(LanguageDetectionSuccess!);
            }
            else if (IsTransferToAgentSuccess && transferToAgentSuccess != null)
            {
                return transferToAgentSuccess(TransferToAgentSuccess!);
            }
            else if (IsTransferToAgentError && transferToAgentError != null)
            {
                return transferToAgentError(TransferToAgentError!);
            }
            else if (IsTransferToNumberTwilioSuccess && transferToNumberTwilioSuccess != null)
            {
                return transferToNumberTwilioSuccess(TransferToNumberTwilioSuccess!);
            }
            else if (IsTransferToNumberSipSuccess && transferToNumberSipSuccess != null)
            {
                return transferToNumberSipSuccess(TransferToNumberSipSuccess!);
            }
            else if (IsTransferToNumberError && transferToNumberError != null)
            {
                return transferToNumberError(TransferToNumberError!);
            }
            else if (IsSkipTurnSuccess && skipTurnSuccess != null)
            {
                return skipTurnSuccess(SkipTurnSuccess!);
            }
            else if (IsPlayDtmfSuccess && playDtmfSuccess != null)
            {
                return playDtmfSuccess(PlayDtmfSuccess!);
            }
            else if (IsPlayDtmfError && playDtmfError != null)
            {
                return playDtmfError(PlayDtmfError!);
            }
            else if (IsVoicemailDetectionSuccess && voicemailDetectionSuccess != null)
            {
                return voicemailDetectionSuccess(VoicemailDetectionSuccess!);
            }
            else if (IsTestingToolResult && testingToolResult != null)
            {
                return testingToolResult(TestingToolResult!);
            }
            else if (IsKnowledgeBaseRagSuccess && knowledgeBaseRagSuccess != null)
            {
                return knowledgeBaseRagSuccess(KnowledgeBaseRagSuccess!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.EndCallToolResultModel>? endCallSuccess = null,

            global::System.Action<global::ElevenLabs.LanguageDetectionToolResultModel>? languageDetectionSuccess = null,

            global::System.Action<global::ElevenLabs.TransferToAgentToolResultSuccessModel>? transferToAgentSuccess = null,

            global::System.Action<global::ElevenLabs.TransferToAgentToolResultErrorModel>? transferToAgentError = null,

            global::System.Action<global::ElevenLabs.TransferToNumberResultTwilioSuccessModel>? transferToNumberTwilioSuccess = null,

            global::System.Action<global::ElevenLabs.TransferToNumberResultSipSuccessModel>? transferToNumberSipSuccess = null,

            global::System.Action<global::ElevenLabs.TransferToNumberResultErrorModel>? transferToNumberError = null,

            global::System.Action<global::ElevenLabs.SkipTurnToolResponseModel>? skipTurnSuccess = null,

            global::System.Action<global::ElevenLabs.PlayDTMFResultSuccessModel>? playDtmfSuccess = null,

            global::System.Action<global::ElevenLabs.PlayDTMFResultErrorModel>? playDtmfError = null,

            global::System.Action<global::ElevenLabs.VoiceMailDetectionResultSuccessModel>? voicemailDetectionSuccess = null,

            global::System.Action<global::ElevenLabs.TestToolResultModel>? testingToolResult = null,

            global::System.Action<global::ElevenLabs.KnowledgeBaseRagToolResultModel>? knowledgeBaseRagSuccess = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCallSuccess)
            {
                endCallSuccess?.Invoke(EndCallSuccess!);
            }
            else if (IsLanguageDetectionSuccess)
            {
                languageDetectionSuccess?.Invoke(LanguageDetectionSuccess!);
            }
            else if (IsTransferToAgentSuccess)
            {
                transferToAgentSuccess?.Invoke(TransferToAgentSuccess!);
            }
            else if (IsTransferToAgentError)
            {
                transferToAgentError?.Invoke(TransferToAgentError!);
            }
            else if (IsTransferToNumberTwilioSuccess)
            {
                transferToNumberTwilioSuccess?.Invoke(TransferToNumberTwilioSuccess!);
            }
            else if (IsTransferToNumberSipSuccess)
            {
                transferToNumberSipSuccess?.Invoke(TransferToNumberSipSuccess!);
            }
            else if (IsTransferToNumberError)
            {
                transferToNumberError?.Invoke(TransferToNumberError!);
            }
            else if (IsSkipTurnSuccess)
            {
                skipTurnSuccess?.Invoke(SkipTurnSuccess!);
            }
            else if (IsPlayDtmfSuccess)
            {
                playDtmfSuccess?.Invoke(PlayDtmfSuccess!);
            }
            else if (IsPlayDtmfError)
            {
                playDtmfError?.Invoke(PlayDtmfError!);
            }
            else if (IsVoicemailDetectionSuccess)
            {
                voicemailDetectionSuccess?.Invoke(VoicemailDetectionSuccess!);
            }
            else if (IsTestingToolResult)
            {
                testingToolResult?.Invoke(TestingToolResult!);
            }
            else if (IsKnowledgeBaseRagSuccess)
            {
                knowledgeBaseRagSuccess?.Invoke(KnowledgeBaseRagSuccess!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.EndCallToolResultModel>? endCallSuccess = null,
            global::System.Action<global::ElevenLabs.LanguageDetectionToolResultModel>? languageDetectionSuccess = null,
            global::System.Action<global::ElevenLabs.TransferToAgentToolResultSuccessModel>? transferToAgentSuccess = null,
            global::System.Action<global::ElevenLabs.TransferToAgentToolResultErrorModel>? transferToAgentError = null,
            global::System.Action<global::ElevenLabs.TransferToNumberResultTwilioSuccessModel>? transferToNumberTwilioSuccess = null,
            global::System.Action<global::ElevenLabs.TransferToNumberResultSipSuccessModel>? transferToNumberSipSuccess = null,
            global::System.Action<global::ElevenLabs.TransferToNumberResultErrorModel>? transferToNumberError = null,
            global::System.Action<global::ElevenLabs.SkipTurnToolResponseModel>? skipTurnSuccess = null,
            global::System.Action<global::ElevenLabs.PlayDTMFResultSuccessModel>? playDtmfSuccess = null,
            global::System.Action<global::ElevenLabs.PlayDTMFResultErrorModel>? playDtmfError = null,
            global::System.Action<global::ElevenLabs.VoiceMailDetectionResultSuccessModel>? voicemailDetectionSuccess = null,
            global::System.Action<global::ElevenLabs.TestToolResultModel>? testingToolResult = null,
            global::System.Action<global::ElevenLabs.KnowledgeBaseRagToolResultModel>? knowledgeBaseRagSuccess = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCallSuccess)
            {
                endCallSuccess?.Invoke(EndCallSuccess!);
            }
            else if (IsLanguageDetectionSuccess)
            {
                languageDetectionSuccess?.Invoke(LanguageDetectionSuccess!);
            }
            else if (IsTransferToAgentSuccess)
            {
                transferToAgentSuccess?.Invoke(TransferToAgentSuccess!);
            }
            else if (IsTransferToAgentError)
            {
                transferToAgentError?.Invoke(TransferToAgentError!);
            }
            else if (IsTransferToNumberTwilioSuccess)
            {
                transferToNumberTwilioSuccess?.Invoke(TransferToNumberTwilioSuccess!);
            }
            else if (IsTransferToNumberSipSuccess)
            {
                transferToNumberSipSuccess?.Invoke(TransferToNumberSipSuccess!);
            }
            else if (IsTransferToNumberError)
            {
                transferToNumberError?.Invoke(TransferToNumberError!);
            }
            else if (IsSkipTurnSuccess)
            {
                skipTurnSuccess?.Invoke(SkipTurnSuccess!);
            }
            else if (IsPlayDtmfSuccess)
            {
                playDtmfSuccess?.Invoke(PlayDtmfSuccess!);
            }
            else if (IsPlayDtmfError)
            {
                playDtmfError?.Invoke(PlayDtmfError!);
            }
            else if (IsVoicemailDetectionSuccess)
            {
                voicemailDetectionSuccess?.Invoke(VoicemailDetectionSuccess!);
            }
            else if (IsTestingToolResult)
            {
                testingToolResult?.Invoke(TestingToolResult!);
            }
            else if (IsKnowledgeBaseRagSuccess)
            {
                knowledgeBaseRagSuccess?.Invoke(KnowledgeBaseRagSuccess!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EndCallSuccess,
                typeof(global::ElevenLabs.EndCallToolResultModel),
                LanguageDetectionSuccess,
                typeof(global::ElevenLabs.LanguageDetectionToolResultModel),
                TransferToAgentSuccess,
                typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModel),
                TransferToAgentError,
                typeof(global::ElevenLabs.TransferToAgentToolResultErrorModel),
                TransferToNumberTwilioSuccess,
                typeof(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel),
                TransferToNumberSipSuccess,
                typeof(global::ElevenLabs.TransferToNumberResultSipSuccessModel),
                TransferToNumberError,
                typeof(global::ElevenLabs.TransferToNumberResultErrorModel),
                SkipTurnSuccess,
                typeof(global::ElevenLabs.SkipTurnToolResponseModel),
                PlayDtmfSuccess,
                typeof(global::ElevenLabs.PlayDTMFResultSuccessModel),
                PlayDtmfError,
                typeof(global::ElevenLabs.PlayDTMFResultErrorModel),
                VoicemailDetectionSuccess,
                typeof(global::ElevenLabs.VoiceMailDetectionResultSuccessModel),
                TestingToolResult,
                typeof(global::ElevenLabs.TestToolResultModel),
                KnowledgeBaseRagSuccess,
                typeof(global::ElevenLabs.KnowledgeBaseRagToolResultModel),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResultVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.EndCallToolResultModel?>.Default.Equals(EndCallSuccess, other.EndCallSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.LanguageDetectionToolResultModel?>.Default.Equals(LanguageDetectionSuccess, other.LanguageDetectionSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToAgentToolResultSuccessModel?>.Default.Equals(TransferToAgentSuccess, other.TransferToAgentSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToAgentToolResultErrorModel?>.Default.Equals(TransferToAgentError, other.TransferToAgentError) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToNumberResultTwilioSuccessModel?>.Default.Equals(TransferToNumberTwilioSuccess, other.TransferToNumberTwilioSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToNumberResultSipSuccessModel?>.Default.Equals(TransferToNumberSipSuccess, other.TransferToNumberSipSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToNumberResultErrorModel?>.Default.Equals(TransferToNumberError, other.TransferToNumberError) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SkipTurnToolResponseModel?>.Default.Equals(SkipTurnSuccess, other.SkipTurnSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PlayDTMFResultSuccessModel?>.Default.Equals(PlayDtmfSuccess, other.PlayDtmfSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PlayDTMFResultErrorModel?>.Default.Equals(PlayDtmfError, other.PlayDtmfError) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.VoiceMailDetectionResultSuccessModel?>.Default.Equals(VoicemailDetectionSuccess, other.VoicemailDetectionSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TestToolResultModel?>.Default.Equals(TestingToolResult, other.TestingToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.KnowledgeBaseRagToolResultModel?>.Default.Equals(KnowledgeBaseRagSuccess, other.KnowledgeBaseRagSuccess) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultVariant1 obj1, ResultVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultVariant1 obj1, ResultVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultVariant1 o && Equals(o);
        }
    }
}
