#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Params2 : global::System.IEquatable<Params2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType? SystemToolType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.EndCallToolConfig? EndCall { get; init; }
#else
        public global::ElevenLabs.EndCallToolConfig? EndCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndCall))]
#endif
        public bool IsEndCall => EndCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEndCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.EndCallToolConfig? value)
        {
            value = EndCall;
            return IsEndCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.EndCallToolConfig PickEndCall() => IsEndCall
            ? EndCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EndCall' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.LanguageDetectionToolConfig? LanguageDetection { get; init; }
#else
        public global::ElevenLabs.LanguageDetectionToolConfig? LanguageDetection { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LanguageDetection))]
#endif
        public bool IsLanguageDetection => LanguageDetection != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLanguageDetection(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.LanguageDetectionToolConfig? value)
        {
            value = LanguageDetection;
            return IsLanguageDetection;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.LanguageDetectionToolConfig PickLanguageDetection() => IsLanguageDetection
            ? LanguageDetection!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LanguageDetection' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TransferToAgentToolConfig? TransferToAgent { get; init; }
#else
        public global::ElevenLabs.TransferToAgentToolConfig? TransferToAgent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToAgent))]
#endif
        public bool IsTransferToAgent => TransferToAgent != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransferToAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TransferToAgentToolConfig? value)
        {
            value = TransferToAgent;
            return IsTransferToAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolConfig PickTransferToAgent() => IsTransferToAgent
            ? TransferToAgent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransferToAgent' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TransferToNumberToolConfigInput? TransferToNumber { get; init; }
#else
        public global::ElevenLabs.TransferToNumberToolConfigInput? TransferToNumber { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToNumber))]
#endif
        public bool IsTransferToNumber => TransferToNumber != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransferToNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TransferToNumberToolConfigInput? value)
        {
            value = TransferToNumber;
            return IsTransferToNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TransferToNumberToolConfigInput PickTransferToNumber() => IsTransferToNumber
            ? TransferToNumber!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransferToNumber' but the value was {ToString()}.");

        /// <summary>
        /// Allows the agent to explicitly skip its turn.<br/>
        /// This tool should be invoked by the LLM when the user indicates they would like<br/>
        /// to think or take a short pause before continuing the conversation—e.g. when<br/>
        /// they say: "Give me a second", "Let me think", or "One moment please".  After<br/>
        /// calling this tool, the assistant should not speak until the user speaks<br/>
        /// again, or another normal turn-taking condition is met.  The tool itself has<br/>
        /// no parameters and performs no side-effects other than informing the backend<br/>
        /// that the current turn generation is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SkipTurnToolConfig? SkipTurn { get; init; }
#else
        public global::ElevenLabs.SkipTurnToolConfig? SkipTurn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SkipTurn))]
#endif
        public bool IsSkipTurn => SkipTurn != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSkipTurn(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SkipTurnToolConfig? value)
        {
            value = SkipTurn;
            return IsSkipTurn;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.SkipTurnToolConfig PickSkipTurn() => IsSkipTurn
            ? SkipTurn!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SkipTurn' but the value was {ToString()}.");

        /// <summary>
        /// Allows the agent to play DTMF tones during a phone call.<br/>
        /// This tool can be used to interact with automated phone systems, such as<br/>
        /// navigating phone menus, entering extensions, or inputting numeric codes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PlayDTMFToolConfig? PlayKeypadTouchTone { get; init; }
#else
        public global::ElevenLabs.PlayDTMFToolConfig? PlayKeypadTouchTone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlayKeypadTouchTone))]
#endif
        public bool IsPlayKeypadTouchTone => PlayKeypadTouchTone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPlayKeypadTouchTone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.PlayDTMFToolConfig? value)
        {
            value = PlayKeypadTouchTone;
            return IsPlayKeypadTouchTone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.PlayDTMFToolConfig PickPlayKeypadTouchTone() => IsPlayKeypadTouchTone
            ? PlayKeypadTouchTone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PlayKeypadTouchTone' but the value was {ToString()}.");

        /// <summary>
        /// Allows the agent to detect when a voicemail system is encountered.<br/>
        /// This tool should be invoked by the LLM when it detects that the call has been<br/>
        /// answered by a voicemail system rather than a human. If a voicemail message<br/>
        /// is configured, it will be played; otherwise the call will end immediately.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.VoicemailDetectionToolConfig? VoicemailDetection { get; init; }
#else
        public global::ElevenLabs.VoicemailDetectionToolConfig? VoicemailDetection { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoicemailDetection))]
#endif
        public bool IsVoicemailDetection => VoicemailDetection != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVoicemailDetection(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.VoicemailDetectionToolConfig? value)
        {
            value = VoicemailDetection;
            return IsVoicemailDetection;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.VoicemailDetectionToolConfig PickVoicemailDetection() => IsVoicemailDetection
            ? VoicemailDetection!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VoicemailDetection' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.KnowledgeBaseRagToolConfig? KnowledgeBaseRag { get; init; }
#else
        public global::ElevenLabs.KnowledgeBaseRagToolConfig? KnowledgeBaseRag { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KnowledgeBaseRag))]
#endif
        public bool IsKnowledgeBaseRag => KnowledgeBaseRag != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickKnowledgeBaseRag(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.KnowledgeBaseRagToolConfig? value)
        {
            value = KnowledgeBaseRag;
            return IsKnowledgeBaseRag;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseRagToolConfig PickKnowledgeBaseRag() => IsKnowledgeBaseRag
            ? KnowledgeBaseRag!
            : throw new global::System.InvalidOperationException($"Expected union variant 'KnowledgeBaseRag' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.StartProcedureToolConfigInput? StartProcedure { get; init; }
#else
        public global::ElevenLabs.StartProcedureToolConfigInput? StartProcedure { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StartProcedure))]
#endif
        public bool IsStartProcedure => StartProcedure != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStartProcedure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.StartProcedureToolConfigInput? value)
        {
            value = StartProcedure;
            return IsStartProcedure;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.StartProcedureToolConfigInput PickStartProcedure() => IsStartProcedure
            ? StartProcedure!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StartProcedure' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.EndProcedureToolConfigInput? EndProcedure { get; init; }
#else
        public global::ElevenLabs.EndProcedureToolConfigInput? EndProcedure { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndProcedure))]
#endif
        public bool IsEndProcedure => EndProcedure != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEndProcedure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.EndProcedureToolConfigInput? value)
        {
            value = EndProcedure;
            return IsEndProcedure;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.EndProcedureToolConfigInput PickEndProcedure() => IsEndProcedure
            ? EndProcedure!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EndProcedure' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.RunSubagentToolConfigInput? RunSubagent { get; init; }
#else
        public global::ElevenLabs.RunSubagentToolConfigInput? RunSubagent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunSubagent))]
#endif
        public bool IsRunSubagent => RunSubagent != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRunSubagent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.RunSubagentToolConfigInput? value)
        {
            value = RunSubagent;
            return IsRunSubagent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.RunSubagentToolConfigInput PickRunSubagent() => IsRunSubagent
            ? RunSubagent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunSubagent' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params2(global::ElevenLabs.EndCallToolConfig value) => new Params2((global::ElevenLabs.EndCallToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.EndCallToolConfig?(Params2 @this) => @this.EndCall;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.EndCallToolConfig? value)
        {
            EndCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params2 FromEndCall(global::ElevenLabs.EndCallToolConfig? value) => new Params2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params2(global::ElevenLabs.LanguageDetectionToolConfig value) => new Params2((global::ElevenLabs.LanguageDetectionToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.LanguageDetectionToolConfig?(Params2 @this) => @this.LanguageDetection;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.LanguageDetectionToolConfig? value)
        {
            LanguageDetection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params2 FromLanguageDetection(global::ElevenLabs.LanguageDetectionToolConfig? value) => new Params2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params2(global::ElevenLabs.TransferToAgentToolConfig value) => new Params2((global::ElevenLabs.TransferToAgentToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToAgentToolConfig?(Params2 @this) => @this.TransferToAgent;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.TransferToAgentToolConfig? value)
        {
            TransferToAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params2 FromTransferToAgent(global::ElevenLabs.TransferToAgentToolConfig? value) => new Params2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params2(global::ElevenLabs.TransferToNumberToolConfigInput value) => new Params2((global::ElevenLabs.TransferToNumberToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToNumberToolConfigInput?(Params2 @this) => @this.TransferToNumber;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.TransferToNumberToolConfigInput? value)
        {
            TransferToNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params2 FromTransferToNumber(global::ElevenLabs.TransferToNumberToolConfigInput? value) => new Params2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params2(global::ElevenLabs.SkipTurnToolConfig value) => new Params2((global::ElevenLabs.SkipTurnToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SkipTurnToolConfig?(Params2 @this) => @this.SkipTurn;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.SkipTurnToolConfig? value)
        {
            SkipTurn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params2 FromSkipTurn(global::ElevenLabs.SkipTurnToolConfig? value) => new Params2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params2(global::ElevenLabs.PlayDTMFToolConfig value) => new Params2((global::ElevenLabs.PlayDTMFToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PlayDTMFToolConfig?(Params2 @this) => @this.PlayKeypadTouchTone;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.PlayDTMFToolConfig? value)
        {
            PlayKeypadTouchTone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params2 FromPlayKeypadTouchTone(global::ElevenLabs.PlayDTMFToolConfig? value) => new Params2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params2(global::ElevenLabs.VoicemailDetectionToolConfig value) => new Params2((global::ElevenLabs.VoicemailDetectionToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.VoicemailDetectionToolConfig?(Params2 @this) => @this.VoicemailDetection;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.VoicemailDetectionToolConfig? value)
        {
            VoicemailDetection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params2 FromVoicemailDetection(global::ElevenLabs.VoicemailDetectionToolConfig? value) => new Params2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params2(global::ElevenLabs.KnowledgeBaseRagToolConfig value) => new Params2((global::ElevenLabs.KnowledgeBaseRagToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.KnowledgeBaseRagToolConfig?(Params2 @this) => @this.KnowledgeBaseRag;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.KnowledgeBaseRagToolConfig? value)
        {
            KnowledgeBaseRag = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params2 FromKnowledgeBaseRag(global::ElevenLabs.KnowledgeBaseRagToolConfig? value) => new Params2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params2(global::ElevenLabs.StartProcedureToolConfigInput value) => new Params2((global::ElevenLabs.StartProcedureToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.StartProcedureToolConfigInput?(Params2 @this) => @this.StartProcedure;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.StartProcedureToolConfigInput? value)
        {
            StartProcedure = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params2 FromStartProcedure(global::ElevenLabs.StartProcedureToolConfigInput? value) => new Params2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params2(global::ElevenLabs.EndProcedureToolConfigInput value) => new Params2((global::ElevenLabs.EndProcedureToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.EndProcedureToolConfigInput?(Params2 @this) => @this.EndProcedure;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.EndProcedureToolConfigInput? value)
        {
            EndProcedure = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params2 FromEndProcedure(global::ElevenLabs.EndProcedureToolConfigInput? value) => new Params2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params2(global::ElevenLabs.RunSubagentToolConfigInput value) => new Params2((global::ElevenLabs.RunSubagentToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.RunSubagentToolConfigInput?(Params2 @this) => @this.RunSubagent;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.RunSubagentToolConfigInput? value)
        {
            RunSubagent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params2 FromRunSubagent(global::ElevenLabs.RunSubagentToolConfigInput? value) => new Params2(value);

        /// <summary>
        /// 
        /// </summary>
        public Params2(
            global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType? systemToolType,
            global::ElevenLabs.EndCallToolConfig? endCall,
            global::ElevenLabs.LanguageDetectionToolConfig? languageDetection,
            global::ElevenLabs.TransferToAgentToolConfig? transferToAgent,
            global::ElevenLabs.TransferToNumberToolConfigInput? transferToNumber,
            global::ElevenLabs.SkipTurnToolConfig? skipTurn,
            global::ElevenLabs.PlayDTMFToolConfig? playKeypadTouchTone,
            global::ElevenLabs.VoicemailDetectionToolConfig? voicemailDetection,
            global::ElevenLabs.KnowledgeBaseRagToolConfig? knowledgeBaseRag,
            global::ElevenLabs.StartProcedureToolConfigInput? startProcedure,
            global::ElevenLabs.EndProcedureToolConfigInput? endProcedure,
            global::ElevenLabs.RunSubagentToolConfigInput? runSubagent
            )
        {
            SystemToolType = systemToolType;

            EndCall = endCall;
            LanguageDetection = languageDetection;
            TransferToAgent = transferToAgent;
            TransferToNumber = transferToNumber;
            SkipTurn = skipTurn;
            PlayKeypadTouchTone = playKeypadTouchTone;
            VoicemailDetection = voicemailDetection;
            KnowledgeBaseRag = knowledgeBaseRag;
            StartProcedure = startProcedure;
            EndProcedure = endProcedure;
            RunSubagent = runSubagent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RunSubagent as object ??
            EndProcedure as object ??
            StartProcedure as object ??
            KnowledgeBaseRag as object ??
            VoicemailDetection as object ??
            PlayKeypadTouchTone as object ??
            SkipTurn as object ??
            TransferToNumber as object ??
            TransferToAgent as object ??
            LanguageDetection as object ??
            EndCall as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EndCall?.ToString() ??
            LanguageDetection?.ToString() ??
            TransferToAgent?.ToString() ??
            TransferToNumber?.ToString() ??
            SkipTurn?.ToString() ??
            PlayKeypadTouchTone?.ToString() ??
            VoicemailDetection?.ToString() ??
            KnowledgeBaseRag?.ToString() ??
            StartProcedure?.ToString() ??
            EndProcedure?.ToString() ??
            RunSubagent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsKnowledgeBaseRag && !IsStartProcedure && !IsEndProcedure && !IsRunSubagent || !IsEndCall && IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsKnowledgeBaseRag && !IsStartProcedure && !IsEndProcedure && !IsRunSubagent || !IsEndCall && !IsLanguageDetection && IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsKnowledgeBaseRag && !IsStartProcedure && !IsEndProcedure && !IsRunSubagent || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsKnowledgeBaseRag && !IsStartProcedure && !IsEndProcedure && !IsRunSubagent || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsKnowledgeBaseRag && !IsStartProcedure && !IsEndProcedure && !IsRunSubagent || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsKnowledgeBaseRag && !IsStartProcedure && !IsEndProcedure && !IsRunSubagent || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && IsVoicemailDetection && !IsKnowledgeBaseRag && !IsStartProcedure && !IsEndProcedure && !IsRunSubagent || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && IsKnowledgeBaseRag && !IsStartProcedure && !IsEndProcedure && !IsRunSubagent || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsKnowledgeBaseRag && IsStartProcedure && !IsEndProcedure && !IsRunSubagent || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsKnowledgeBaseRag && !IsStartProcedure && IsEndProcedure && !IsRunSubagent || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsKnowledgeBaseRag && !IsStartProcedure && !IsEndProcedure && IsRunSubagent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.EndCallToolConfig, TResult>? endCall = null,
            global::System.Func<global::ElevenLabs.LanguageDetectionToolConfig, TResult>? languageDetection = null,
            global::System.Func<global::ElevenLabs.TransferToAgentToolConfig, TResult>? transferToAgent = null,
            global::System.Func<global::ElevenLabs.TransferToNumberToolConfigInput, TResult>? transferToNumber = null,
            global::System.Func<global::ElevenLabs.SkipTurnToolConfig, TResult>? skipTurn = null,
            global::System.Func<global::ElevenLabs.PlayDTMFToolConfig, TResult>? playKeypadTouchTone = null,
            global::System.Func<global::ElevenLabs.VoicemailDetectionToolConfig, TResult>? voicemailDetection = null,
            global::System.Func<global::ElevenLabs.KnowledgeBaseRagToolConfig, TResult>? knowledgeBaseRag = null,
            global::System.Func<global::ElevenLabs.StartProcedureToolConfigInput, TResult>? startProcedure = null,
            global::System.Func<global::ElevenLabs.EndProcedureToolConfigInput, TResult>? endProcedure = null,
            global::System.Func<global::ElevenLabs.RunSubagentToolConfigInput, TResult>? runSubagent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCall && endCall != null)
            {
                return endCall(EndCall!);
            }
            else if (IsLanguageDetection && languageDetection != null)
            {
                return languageDetection(LanguageDetection!);
            }
            else if (IsTransferToAgent && transferToAgent != null)
            {
                return transferToAgent(TransferToAgent!);
            }
            else if (IsTransferToNumber && transferToNumber != null)
            {
                return transferToNumber(TransferToNumber!);
            }
            else if (IsSkipTurn && skipTurn != null)
            {
                return skipTurn(SkipTurn!);
            }
            else if (IsPlayKeypadTouchTone && playKeypadTouchTone != null)
            {
                return playKeypadTouchTone(PlayKeypadTouchTone!);
            }
            else if (IsVoicemailDetection && voicemailDetection != null)
            {
                return voicemailDetection(VoicemailDetection!);
            }
            else if (IsKnowledgeBaseRag && knowledgeBaseRag != null)
            {
                return knowledgeBaseRag(KnowledgeBaseRag!);
            }
            else if (IsStartProcedure && startProcedure != null)
            {
                return startProcedure(StartProcedure!);
            }
            else if (IsEndProcedure && endProcedure != null)
            {
                return endProcedure(EndProcedure!);
            }
            else if (IsRunSubagent && runSubagent != null)
            {
                return runSubagent(RunSubagent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.EndCallToolConfig>? endCall = null,

            global::System.Action<global::ElevenLabs.LanguageDetectionToolConfig>? languageDetection = null,

            global::System.Action<global::ElevenLabs.TransferToAgentToolConfig>? transferToAgent = null,

            global::System.Action<global::ElevenLabs.TransferToNumberToolConfigInput>? transferToNumber = null,

            global::System.Action<global::ElevenLabs.SkipTurnToolConfig>? skipTurn = null,

            global::System.Action<global::ElevenLabs.PlayDTMFToolConfig>? playKeypadTouchTone = null,

            global::System.Action<global::ElevenLabs.VoicemailDetectionToolConfig>? voicemailDetection = null,

            global::System.Action<global::ElevenLabs.KnowledgeBaseRagToolConfig>? knowledgeBaseRag = null,

            global::System.Action<global::ElevenLabs.StartProcedureToolConfigInput>? startProcedure = null,

            global::System.Action<global::ElevenLabs.EndProcedureToolConfigInput>? endProcedure = null,

            global::System.Action<global::ElevenLabs.RunSubagentToolConfigInput>? runSubagent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCall)
            {
                endCall?.Invoke(EndCall!);
            }
            else if (IsLanguageDetection)
            {
                languageDetection?.Invoke(LanguageDetection!);
            }
            else if (IsTransferToAgent)
            {
                transferToAgent?.Invoke(TransferToAgent!);
            }
            else if (IsTransferToNumber)
            {
                transferToNumber?.Invoke(TransferToNumber!);
            }
            else if (IsSkipTurn)
            {
                skipTurn?.Invoke(SkipTurn!);
            }
            else if (IsPlayKeypadTouchTone)
            {
                playKeypadTouchTone?.Invoke(PlayKeypadTouchTone!);
            }
            else if (IsVoicemailDetection)
            {
                voicemailDetection?.Invoke(VoicemailDetection!);
            }
            else if (IsKnowledgeBaseRag)
            {
                knowledgeBaseRag?.Invoke(KnowledgeBaseRag!);
            }
            else if (IsStartProcedure)
            {
                startProcedure?.Invoke(StartProcedure!);
            }
            else if (IsEndProcedure)
            {
                endProcedure?.Invoke(EndProcedure!);
            }
            else if (IsRunSubagent)
            {
                runSubagent?.Invoke(RunSubagent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.EndCallToolConfig>? endCall = null,
            global::System.Action<global::ElevenLabs.LanguageDetectionToolConfig>? languageDetection = null,
            global::System.Action<global::ElevenLabs.TransferToAgentToolConfig>? transferToAgent = null,
            global::System.Action<global::ElevenLabs.TransferToNumberToolConfigInput>? transferToNumber = null,
            global::System.Action<global::ElevenLabs.SkipTurnToolConfig>? skipTurn = null,
            global::System.Action<global::ElevenLabs.PlayDTMFToolConfig>? playKeypadTouchTone = null,
            global::System.Action<global::ElevenLabs.VoicemailDetectionToolConfig>? voicemailDetection = null,
            global::System.Action<global::ElevenLabs.KnowledgeBaseRagToolConfig>? knowledgeBaseRag = null,
            global::System.Action<global::ElevenLabs.StartProcedureToolConfigInput>? startProcedure = null,
            global::System.Action<global::ElevenLabs.EndProcedureToolConfigInput>? endProcedure = null,
            global::System.Action<global::ElevenLabs.RunSubagentToolConfigInput>? runSubagent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCall)
            {
                endCall?.Invoke(EndCall!);
            }
            else if (IsLanguageDetection)
            {
                languageDetection?.Invoke(LanguageDetection!);
            }
            else if (IsTransferToAgent)
            {
                transferToAgent?.Invoke(TransferToAgent!);
            }
            else if (IsTransferToNumber)
            {
                transferToNumber?.Invoke(TransferToNumber!);
            }
            else if (IsSkipTurn)
            {
                skipTurn?.Invoke(SkipTurn!);
            }
            else if (IsPlayKeypadTouchTone)
            {
                playKeypadTouchTone?.Invoke(PlayKeypadTouchTone!);
            }
            else if (IsVoicemailDetection)
            {
                voicemailDetection?.Invoke(VoicemailDetection!);
            }
            else if (IsKnowledgeBaseRag)
            {
                knowledgeBaseRag?.Invoke(KnowledgeBaseRag!);
            }
            else if (IsStartProcedure)
            {
                startProcedure?.Invoke(StartProcedure!);
            }
            else if (IsEndProcedure)
            {
                endProcedure?.Invoke(EndProcedure!);
            }
            else if (IsRunSubagent)
            {
                runSubagent?.Invoke(RunSubagent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EndCall,
                typeof(global::ElevenLabs.EndCallToolConfig),
                LanguageDetection,
                typeof(global::ElevenLabs.LanguageDetectionToolConfig),
                TransferToAgent,
                typeof(global::ElevenLabs.TransferToAgentToolConfig),
                TransferToNumber,
                typeof(global::ElevenLabs.TransferToNumberToolConfigInput),
                SkipTurn,
                typeof(global::ElevenLabs.SkipTurnToolConfig),
                PlayKeypadTouchTone,
                typeof(global::ElevenLabs.PlayDTMFToolConfig),
                VoicemailDetection,
                typeof(global::ElevenLabs.VoicemailDetectionToolConfig),
                KnowledgeBaseRag,
                typeof(global::ElevenLabs.KnowledgeBaseRagToolConfig),
                StartProcedure,
                typeof(global::ElevenLabs.StartProcedureToolConfigInput),
                EndProcedure,
                typeof(global::ElevenLabs.EndProcedureToolConfigInput),
                RunSubagent,
                typeof(global::ElevenLabs.RunSubagentToolConfigInput),
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
        public bool Equals(Params2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.EndCallToolConfig?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.LanguageDetectionToolConfig?>.Default.Equals(LanguageDetection, other.LanguageDetection) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToAgentToolConfig?>.Default.Equals(TransferToAgent, other.TransferToAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToNumberToolConfigInput?>.Default.Equals(TransferToNumber, other.TransferToNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SkipTurnToolConfig?>.Default.Equals(SkipTurn, other.SkipTurn) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PlayDTMFToolConfig?>.Default.Equals(PlayKeypadTouchTone, other.PlayKeypadTouchTone) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.VoicemailDetectionToolConfig?>.Default.Equals(VoicemailDetection, other.VoicemailDetection) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.KnowledgeBaseRagToolConfig?>.Default.Equals(KnowledgeBaseRag, other.KnowledgeBaseRag) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.StartProcedureToolConfigInput?>.Default.Equals(StartProcedure, other.StartProcedure) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.EndProcedureToolConfigInput?>.Default.Equals(EndProcedure, other.EndProcedure) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.RunSubagentToolConfigInput?>.Default.Equals(RunSubagent, other.RunSubagent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Params2 obj1, Params2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Params2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Params2 obj1, Params2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Params2 o && Equals(o);
        }
    }
}
