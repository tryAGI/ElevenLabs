#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Params3 : global::System.IEquatable<Params3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType? SystemToolType { get; }

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
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TransferToNumberToolConfigOutput? TransferToNumber { get; init; }
#else
        public global::ElevenLabs.TransferToNumberToolConfigOutput? TransferToNumber { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToNumber))]
#endif
        public bool IsTransferToNumber => TransferToNumber != null;

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
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MemoryEntrySearchToolConfig? MemoryEntrySearch { get; init; }
#else
        public global::ElevenLabs.MemoryEntrySearchToolConfig? MemoryEntrySearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryEntrySearch))]
#endif
        public bool IsMemoryEntrySearch => MemoryEntrySearch != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MemoryEntryCreateToolConfig? MemoryEntryCreate { get; init; }
#else
        public global::ElevenLabs.MemoryEntryCreateToolConfig? MemoryEntryCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryEntryCreate))]
#endif
        public bool IsMemoryEntryCreate => MemoryEntryCreate != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MemoryEntryUpdateToolConfig? MemoryEntryUpdate { get; init; }
#else
        public global::ElevenLabs.MemoryEntryUpdateToolConfig? MemoryEntryUpdate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryEntryUpdate))]
#endif
        public bool IsMemoryEntryUpdate => MemoryEntryUpdate != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MemoryEntryDeleteToolConfig? MemoryEntryDelete { get; init; }
#else
        public global::ElevenLabs.MemoryEntryDeleteToolConfig? MemoryEntryDelete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryEntryDelete))]
#endif
        public bool IsMemoryEntryDelete => MemoryEntryDelete != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AgentPromptChangeToolConfig? AgentPromptChange { get; init; }
#else
        public global::ElevenLabs.AgentPromptChangeToolConfig? AgentPromptChange { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentPromptChange))]
#endif
        public bool IsAgentPromptChange => AgentPromptChange != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::ElevenLabs.EndCallToolConfig value) => new Params3((global::ElevenLabs.EndCallToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.EndCallToolConfig?(Params3 @this) => @this.EndCall;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::ElevenLabs.EndCallToolConfig? value)
        {
            EndCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::ElevenLabs.LanguageDetectionToolConfig value) => new Params3((global::ElevenLabs.LanguageDetectionToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.LanguageDetectionToolConfig?(Params3 @this) => @this.LanguageDetection;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::ElevenLabs.LanguageDetectionToolConfig? value)
        {
            LanguageDetection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::ElevenLabs.TransferToAgentToolConfig value) => new Params3((global::ElevenLabs.TransferToAgentToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToAgentToolConfig?(Params3 @this) => @this.TransferToAgent;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::ElevenLabs.TransferToAgentToolConfig? value)
        {
            TransferToAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::ElevenLabs.TransferToNumberToolConfigOutput value) => new Params3((global::ElevenLabs.TransferToNumberToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToNumberToolConfigOutput?(Params3 @this) => @this.TransferToNumber;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::ElevenLabs.TransferToNumberToolConfigOutput? value)
        {
            TransferToNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::ElevenLabs.SkipTurnToolConfig value) => new Params3((global::ElevenLabs.SkipTurnToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SkipTurnToolConfig?(Params3 @this) => @this.SkipTurn;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::ElevenLabs.SkipTurnToolConfig? value)
        {
            SkipTurn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::ElevenLabs.PlayDTMFToolConfig value) => new Params3((global::ElevenLabs.PlayDTMFToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PlayDTMFToolConfig?(Params3 @this) => @this.PlayKeypadTouchTone;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::ElevenLabs.PlayDTMFToolConfig? value)
        {
            PlayKeypadTouchTone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::ElevenLabs.VoicemailDetectionToolConfig value) => new Params3((global::ElevenLabs.VoicemailDetectionToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.VoicemailDetectionToolConfig?(Params3 @this) => @this.VoicemailDetection;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::ElevenLabs.VoicemailDetectionToolConfig? value)
        {
            VoicemailDetection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::ElevenLabs.MemoryEntrySearchToolConfig value) => new Params3((global::ElevenLabs.MemoryEntrySearchToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MemoryEntrySearchToolConfig?(Params3 @this) => @this.MemoryEntrySearch;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::ElevenLabs.MemoryEntrySearchToolConfig? value)
        {
            MemoryEntrySearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::ElevenLabs.MemoryEntryCreateToolConfig value) => new Params3((global::ElevenLabs.MemoryEntryCreateToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MemoryEntryCreateToolConfig?(Params3 @this) => @this.MemoryEntryCreate;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::ElevenLabs.MemoryEntryCreateToolConfig? value)
        {
            MemoryEntryCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::ElevenLabs.MemoryEntryUpdateToolConfig value) => new Params3((global::ElevenLabs.MemoryEntryUpdateToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MemoryEntryUpdateToolConfig?(Params3 @this) => @this.MemoryEntryUpdate;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::ElevenLabs.MemoryEntryUpdateToolConfig? value)
        {
            MemoryEntryUpdate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::ElevenLabs.MemoryEntryDeleteToolConfig value) => new Params3((global::ElevenLabs.MemoryEntryDeleteToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MemoryEntryDeleteToolConfig?(Params3 @this) => @this.MemoryEntryDelete;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::ElevenLabs.MemoryEntryDeleteToolConfig? value)
        {
            MemoryEntryDelete = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params3(global::ElevenLabs.AgentPromptChangeToolConfig value) => new Params3((global::ElevenLabs.AgentPromptChangeToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.AgentPromptChangeToolConfig?(Params3 @this) => @this.AgentPromptChange;

        /// <summary>
        /// 
        /// </summary>
        public Params3(global::ElevenLabs.AgentPromptChangeToolConfig? value)
        {
            AgentPromptChange = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Params3(
            global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType? systemToolType,
            global::ElevenLabs.EndCallToolConfig? endCall,
            global::ElevenLabs.LanguageDetectionToolConfig? languageDetection,
            global::ElevenLabs.TransferToAgentToolConfig? transferToAgent,
            global::ElevenLabs.TransferToNumberToolConfigOutput? transferToNumber,
            global::ElevenLabs.SkipTurnToolConfig? skipTurn,
            global::ElevenLabs.PlayDTMFToolConfig? playKeypadTouchTone,
            global::ElevenLabs.VoicemailDetectionToolConfig? voicemailDetection,
            global::ElevenLabs.MemoryEntrySearchToolConfig? memoryEntrySearch,
            global::ElevenLabs.MemoryEntryCreateToolConfig? memoryEntryCreate,
            global::ElevenLabs.MemoryEntryUpdateToolConfig? memoryEntryUpdate,
            global::ElevenLabs.MemoryEntryDeleteToolConfig? memoryEntryDelete,
            global::ElevenLabs.AgentPromptChangeToolConfig? agentPromptChange
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
            MemoryEntrySearch = memoryEntrySearch;
            MemoryEntryCreate = memoryEntryCreate;
            MemoryEntryUpdate = memoryEntryUpdate;
            MemoryEntryDelete = memoryEntryDelete;
            AgentPromptChange = agentPromptChange;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentPromptChange as object ??
            MemoryEntryDelete as object ??
            MemoryEntryUpdate as object ??
            MemoryEntryCreate as object ??
            MemoryEntrySearch as object ??
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
            MemoryEntrySearch?.ToString() ??
            MemoryEntryCreate?.ToString() ??
            MemoryEntryUpdate?.ToString() ??
            MemoryEntryDelete?.ToString() ??
            AgentPromptChange?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && IsMemoryEntryUpdate && !IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && IsMemoryEntryDelete && !IsAgentPromptChange || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection && !IsMemoryEntrySearch && !IsMemoryEntryCreate && !IsMemoryEntryUpdate && !IsMemoryEntryDelete && IsAgentPromptChange;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.EndCallToolConfig?, TResult>? endCall = null,
            global::System.Func<global::ElevenLabs.LanguageDetectionToolConfig?, TResult>? languageDetection = null,
            global::System.Func<global::ElevenLabs.TransferToAgentToolConfig?, TResult>? transferToAgent = null,
            global::System.Func<global::ElevenLabs.TransferToNumberToolConfigOutput?, TResult>? transferToNumber = null,
            global::System.Func<global::ElevenLabs.SkipTurnToolConfig?, TResult>? skipTurn = null,
            global::System.Func<global::ElevenLabs.PlayDTMFToolConfig?, TResult>? playKeypadTouchTone = null,
            global::System.Func<global::ElevenLabs.VoicemailDetectionToolConfig?, TResult>? voicemailDetection = null,
            global::System.Func<global::ElevenLabs.MemoryEntrySearchToolConfig?, TResult>? memoryEntrySearch = null,
            global::System.Func<global::ElevenLabs.MemoryEntryCreateToolConfig?, TResult>? memoryEntryCreate = null,
            global::System.Func<global::ElevenLabs.MemoryEntryUpdateToolConfig?, TResult>? memoryEntryUpdate = null,
            global::System.Func<global::ElevenLabs.MemoryEntryDeleteToolConfig?, TResult>? memoryEntryDelete = null,
            global::System.Func<global::ElevenLabs.AgentPromptChangeToolConfig?, TResult>? agentPromptChange = null,
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
            else if (IsMemoryEntrySearch && memoryEntrySearch != null)
            {
                return memoryEntrySearch(MemoryEntrySearch!);
            }
            else if (IsMemoryEntryCreate && memoryEntryCreate != null)
            {
                return memoryEntryCreate(MemoryEntryCreate!);
            }
            else if (IsMemoryEntryUpdate && memoryEntryUpdate != null)
            {
                return memoryEntryUpdate(MemoryEntryUpdate!);
            }
            else if (IsMemoryEntryDelete && memoryEntryDelete != null)
            {
                return memoryEntryDelete(MemoryEntryDelete!);
            }
            else if (IsAgentPromptChange && agentPromptChange != null)
            {
                return agentPromptChange(AgentPromptChange!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.EndCallToolConfig?>? endCall = null,
            global::System.Action<global::ElevenLabs.LanguageDetectionToolConfig?>? languageDetection = null,
            global::System.Action<global::ElevenLabs.TransferToAgentToolConfig?>? transferToAgent = null,
            global::System.Action<global::ElevenLabs.TransferToNumberToolConfigOutput?>? transferToNumber = null,
            global::System.Action<global::ElevenLabs.SkipTurnToolConfig?>? skipTurn = null,
            global::System.Action<global::ElevenLabs.PlayDTMFToolConfig?>? playKeypadTouchTone = null,
            global::System.Action<global::ElevenLabs.VoicemailDetectionToolConfig?>? voicemailDetection = null,
            global::System.Action<global::ElevenLabs.MemoryEntrySearchToolConfig?>? memoryEntrySearch = null,
            global::System.Action<global::ElevenLabs.MemoryEntryCreateToolConfig?>? memoryEntryCreate = null,
            global::System.Action<global::ElevenLabs.MemoryEntryUpdateToolConfig?>? memoryEntryUpdate = null,
            global::System.Action<global::ElevenLabs.MemoryEntryDeleteToolConfig?>? memoryEntryDelete = null,
            global::System.Action<global::ElevenLabs.AgentPromptChangeToolConfig?>? agentPromptChange = null,
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
            else if (IsMemoryEntrySearch)
            {
                memoryEntrySearch?.Invoke(MemoryEntrySearch!);
            }
            else if (IsMemoryEntryCreate)
            {
                memoryEntryCreate?.Invoke(MemoryEntryCreate!);
            }
            else if (IsMemoryEntryUpdate)
            {
                memoryEntryUpdate?.Invoke(MemoryEntryUpdate!);
            }
            else if (IsMemoryEntryDelete)
            {
                memoryEntryDelete?.Invoke(MemoryEntryDelete!);
            }
            else if (IsAgentPromptChange)
            {
                agentPromptChange?.Invoke(AgentPromptChange!);
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
                typeof(global::ElevenLabs.TransferToNumberToolConfigOutput),
                SkipTurn,
                typeof(global::ElevenLabs.SkipTurnToolConfig),
                PlayKeypadTouchTone,
                typeof(global::ElevenLabs.PlayDTMFToolConfig),
                VoicemailDetection,
                typeof(global::ElevenLabs.VoicemailDetectionToolConfig),
                MemoryEntrySearch,
                typeof(global::ElevenLabs.MemoryEntrySearchToolConfig),
                MemoryEntryCreate,
                typeof(global::ElevenLabs.MemoryEntryCreateToolConfig),
                MemoryEntryUpdate,
                typeof(global::ElevenLabs.MemoryEntryUpdateToolConfig),
                MemoryEntryDelete,
                typeof(global::ElevenLabs.MemoryEntryDeleteToolConfig),
                AgentPromptChange,
                typeof(global::ElevenLabs.AgentPromptChangeToolConfig),
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
        public bool Equals(Params3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.EndCallToolConfig?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.LanguageDetectionToolConfig?>.Default.Equals(LanguageDetection, other.LanguageDetection) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToAgentToolConfig?>.Default.Equals(TransferToAgent, other.TransferToAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToNumberToolConfigOutput?>.Default.Equals(TransferToNumber, other.TransferToNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SkipTurnToolConfig?>.Default.Equals(SkipTurn, other.SkipTurn) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PlayDTMFToolConfig?>.Default.Equals(PlayKeypadTouchTone, other.PlayKeypadTouchTone) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.VoicemailDetectionToolConfig?>.Default.Equals(VoicemailDetection, other.VoicemailDetection) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MemoryEntrySearchToolConfig?>.Default.Equals(MemoryEntrySearch, other.MemoryEntrySearch) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MemoryEntryCreateToolConfig?>.Default.Equals(MemoryEntryCreate, other.MemoryEntryCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MemoryEntryUpdateToolConfig?>.Default.Equals(MemoryEntryUpdate, other.MemoryEntryUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MemoryEntryDeleteToolConfig?>.Default.Equals(MemoryEntryDelete, other.MemoryEntryDelete) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AgentPromptChangeToolConfig?>.Default.Equals(AgentPromptChange, other.AgentPromptChange) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Params3 obj1, Params3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Params3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Params3 obj1, Params3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Params3 o && Equals(o);
        }
    }
}
