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
        /// 
        /// </summary>
        public static implicit operator Params2(global::ElevenLabs.TransferToNumberToolConfigOutput value) => new Params2((global::ElevenLabs.TransferToNumberToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToNumberToolConfigOutput?(Params2 @this) => @this.TransferToNumber;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.TransferToNumberToolConfigOutput? value)
        {
            TransferToNumber = value;
        }

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
        public Params2(
            global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType? systemToolType,
            global::ElevenLabs.EndCallToolConfig? endCall,
            global::ElevenLabs.LanguageDetectionToolConfig? languageDetection,
            global::ElevenLabs.TransferToAgentToolConfig? transferToAgent,
            global::ElevenLabs.TransferToNumberToolConfigOutput? transferToNumber,
            global::ElevenLabs.SkipTurnToolConfig? skipTurn,
            global::ElevenLabs.PlayDTMFToolConfig? playKeypadTouchTone,
            global::ElevenLabs.VoicemailDetectionToolConfig? voicemailDetection
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            VoicemailDetection?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection || !IsEndCall && IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection || !IsEndCall && !IsLanguageDetection && IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && IsSkipTurn && !IsPlayKeypadTouchTone && !IsVoicemailDetection || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && IsPlayKeypadTouchTone && !IsVoicemailDetection || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone && IsVoicemailDetection;
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
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToNumberToolConfigOutput?>.Default.Equals(TransferToNumber, other.TransferToNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SkipTurnToolConfig?>.Default.Equals(SkipTurn, other.SkipTurn) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PlayDTMFToolConfig?>.Default.Equals(PlayKeypadTouchTone, other.PlayKeypadTouchTone) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.VoicemailDetectionToolConfig?>.Default.Equals(VoicemailDetection, other.VoicemailDetection) 
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
