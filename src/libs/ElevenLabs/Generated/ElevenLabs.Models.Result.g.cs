#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Result : global::System.IEquatable<Result>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType? ResultType { get; }

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
        public static implicit operator Result(global::ElevenLabs.EndCallToolResultModel value) => new Result((global::ElevenLabs.EndCallToolResultModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.EndCallToolResultModel?(Result @this) => @this.EndCallSuccess;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::ElevenLabs.EndCallToolResultModel? value)
        {
            EndCallSuccess = value;
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
        public static implicit operator Result(global::ElevenLabs.LanguageDetectionToolResultModel value) => new Result((global::ElevenLabs.LanguageDetectionToolResultModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.LanguageDetectionToolResultModel?(Result @this) => @this.LanguageDetectionSuccess;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::ElevenLabs.LanguageDetectionToolResultModel? value)
        {
            LanguageDetectionSuccess = value;
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
        public static implicit operator Result(global::ElevenLabs.TransferToAgentToolResultSuccessModel value) => new Result((global::ElevenLabs.TransferToAgentToolResultSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToAgentToolResultSuccessModel?(Result @this) => @this.TransferToAgentSuccess;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::ElevenLabs.TransferToAgentToolResultSuccessModel? value)
        {
            TransferToAgentSuccess = value;
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
        public static implicit operator Result(global::ElevenLabs.TransferToAgentToolResultErrorModel value) => new Result((global::ElevenLabs.TransferToAgentToolResultErrorModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToAgentToolResultErrorModel?(Result @this) => @this.TransferToAgentError;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::ElevenLabs.TransferToAgentToolResultErrorModel? value)
        {
            TransferToAgentError = value;
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
        public static implicit operator Result(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel value) => new Result((global::ElevenLabs.TransferToNumberResultTwilioSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToNumberResultTwilioSuccessModel?(Result @this) => @this.TransferToNumberTwilioSuccess;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? value)
        {
            TransferToNumberTwilioSuccess = value;
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
        public static implicit operator Result(global::ElevenLabs.TransferToNumberResultSipSuccessModel value) => new Result((global::ElevenLabs.TransferToNumberResultSipSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToNumberResultSipSuccessModel?(Result @this) => @this.TransferToNumberSipSuccess;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::ElevenLabs.TransferToNumberResultSipSuccessModel? value)
        {
            TransferToNumberSipSuccess = value;
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
        public static implicit operator Result(global::ElevenLabs.TransferToNumberResultErrorModel value) => new Result((global::ElevenLabs.TransferToNumberResultErrorModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToNumberResultErrorModel?(Result @this) => @this.TransferToNumberError;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::ElevenLabs.TransferToNumberResultErrorModel? value)
        {
            TransferToNumberError = value;
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
        public static implicit operator Result(global::ElevenLabs.SkipTurnToolResponseModel value) => new Result((global::ElevenLabs.SkipTurnToolResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SkipTurnToolResponseModel?(Result @this) => @this.SkipTurnSuccess;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::ElevenLabs.SkipTurnToolResponseModel? value)
        {
            SkipTurnSuccess = value;
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
        public static implicit operator Result(global::ElevenLabs.PlayDTMFResultSuccessModel value) => new Result((global::ElevenLabs.PlayDTMFResultSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PlayDTMFResultSuccessModel?(Result @this) => @this.PlayDtmfSuccess;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::ElevenLabs.PlayDTMFResultSuccessModel? value)
        {
            PlayDtmfSuccess = value;
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
        public static implicit operator Result(global::ElevenLabs.PlayDTMFResultErrorModel value) => new Result((global::ElevenLabs.PlayDTMFResultErrorModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PlayDTMFResultErrorModel?(Result @this) => @this.PlayDtmfError;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::ElevenLabs.PlayDTMFResultErrorModel? value)
        {
            PlayDtmfError = value;
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
        public static implicit operator Result(global::ElevenLabs.VoiceMailDetectionResultSuccessModel value) => new Result((global::ElevenLabs.VoiceMailDetectionResultSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.VoiceMailDetectionResultSuccessModel?(Result @this) => @this.VoicemailDetectionSuccess;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::ElevenLabs.VoiceMailDetectionResultSuccessModel? value)
        {
            VoicemailDetectionSuccess = value;
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
        public static implicit operator Result(global::ElevenLabs.TestToolResultModel value) => new Result((global::ElevenLabs.TestToolResultModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TestToolResultModel?(Result @this) => @this.TestingToolResult;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::ElevenLabs.TestToolResultModel? value)
        {
            TestingToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Result(
            global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType? resultType,
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
            global::ElevenLabs.TestToolResultModel? testingToolResult
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            TestingToolResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && IsTestingToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.EndCallToolResultModel?, TResult>? endCallSuccess = null,
            global::System.Func<global::ElevenLabs.LanguageDetectionToolResultModel?, TResult>? languageDetectionSuccess = null,
            global::System.Func<global::ElevenLabs.TransferToAgentToolResultSuccessModel?, TResult>? transferToAgentSuccess = null,
            global::System.Func<global::ElevenLabs.TransferToAgentToolResultErrorModel?, TResult>? transferToAgentError = null,
            global::System.Func<global::ElevenLabs.TransferToNumberResultTwilioSuccessModel?, TResult>? transferToNumberTwilioSuccess = null,
            global::System.Func<global::ElevenLabs.TransferToNumberResultSipSuccessModel?, TResult>? transferToNumberSipSuccess = null,
            global::System.Func<global::ElevenLabs.TransferToNumberResultErrorModel?, TResult>? transferToNumberError = null,
            global::System.Func<global::ElevenLabs.SkipTurnToolResponseModel?, TResult>? skipTurnSuccess = null,
            global::System.Func<global::ElevenLabs.PlayDTMFResultSuccessModel?, TResult>? playDtmfSuccess = null,
            global::System.Func<global::ElevenLabs.PlayDTMFResultErrorModel?, TResult>? playDtmfError = null,
            global::System.Func<global::ElevenLabs.VoiceMailDetectionResultSuccessModel?, TResult>? voicemailDetectionSuccess = null,
            global::System.Func<global::ElevenLabs.TestToolResultModel?, TResult>? testingToolResult = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.EndCallToolResultModel?>? endCallSuccess = null,
            global::System.Action<global::ElevenLabs.LanguageDetectionToolResultModel?>? languageDetectionSuccess = null,
            global::System.Action<global::ElevenLabs.TransferToAgentToolResultSuccessModel?>? transferToAgentSuccess = null,
            global::System.Action<global::ElevenLabs.TransferToAgentToolResultErrorModel?>? transferToAgentError = null,
            global::System.Action<global::ElevenLabs.TransferToNumberResultTwilioSuccessModel?>? transferToNumberTwilioSuccess = null,
            global::System.Action<global::ElevenLabs.TransferToNumberResultSipSuccessModel?>? transferToNumberSipSuccess = null,
            global::System.Action<global::ElevenLabs.TransferToNumberResultErrorModel?>? transferToNumberError = null,
            global::System.Action<global::ElevenLabs.SkipTurnToolResponseModel?>? skipTurnSuccess = null,
            global::System.Action<global::ElevenLabs.PlayDTMFResultSuccessModel?>? playDtmfSuccess = null,
            global::System.Action<global::ElevenLabs.PlayDTMFResultErrorModel?>? playDtmfError = null,
            global::System.Action<global::ElevenLabs.VoiceMailDetectionResultSuccessModel?>? voicemailDetectionSuccess = null,
            global::System.Action<global::ElevenLabs.TestToolResultModel?>? testingToolResult = null,
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
        public bool Equals(Result other)
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
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TestToolResultModel?>.Default.Equals(TestingToolResult, other.TestingToolResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Result obj1, Result obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Result>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Result obj1, Result obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Result o && Equals(o);
        }
    }
}
