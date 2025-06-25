#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Params : global::System.IEquatable<Params>
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
        public static implicit operator Params(global::ElevenLabs.EndCallToolConfig value) => new Params((global::ElevenLabs.EndCallToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.EndCallToolConfig?(Params @this) => @this.EndCall;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.EndCallToolConfig? value)
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
        public static implicit operator Params(global::ElevenLabs.LanguageDetectionToolConfig value) => new Params((global::ElevenLabs.LanguageDetectionToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.LanguageDetectionToolConfig?(Params @this) => @this.LanguageDetection;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.LanguageDetectionToolConfig? value)
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
        public static implicit operator Params(global::ElevenLabs.TransferToAgentToolConfig value) => new Params((global::ElevenLabs.TransferToAgentToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToAgentToolConfig?(Params @this) => @this.TransferToAgent;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.TransferToAgentToolConfig? value)
        {
            TransferToAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TransferToNumberToolConfig? TransferToNumber { get; init; }
#else
        public global::ElevenLabs.TransferToNumberToolConfig? TransferToNumber { get; }
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
        public static implicit operator Params(global::ElevenLabs.TransferToNumberToolConfig value) => new Params((global::ElevenLabs.TransferToNumberToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToNumberToolConfig?(Params @this) => @this.TransferToNumber;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.TransferToNumberToolConfig? value)
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
        public static implicit operator Params(global::ElevenLabs.SkipTurnToolConfig value) => new Params((global::ElevenLabs.SkipTurnToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SkipTurnToolConfig?(Params @this) => @this.SkipTurn;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.SkipTurnToolConfig? value)
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
        public static implicit operator Params(global::ElevenLabs.PlayDTMFToolConfig value) => new Params((global::ElevenLabs.PlayDTMFToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PlayDTMFToolConfig?(Params @this) => @this.PlayKeypadTouchTone;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.PlayDTMFToolConfig? value)
        {
            PlayKeypadTouchTone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Params(
            global::ElevenLabs.SystemToolConfigInputParamsDiscriminatorSystemToolType? systemToolType,
            global::ElevenLabs.EndCallToolConfig? endCall,
            global::ElevenLabs.LanguageDetectionToolConfig? languageDetection,
            global::ElevenLabs.TransferToAgentToolConfig? transferToAgent,
            global::ElevenLabs.TransferToNumberToolConfig? transferToNumber,
            global::ElevenLabs.SkipTurnToolConfig? skipTurn,
            global::ElevenLabs.PlayDTMFToolConfig? playKeypadTouchTone
            )
        {
            SystemToolType = systemToolType;

            EndCall = endCall;
            LanguageDetection = languageDetection;
            TransferToAgent = transferToAgent;
            TransferToNumber = transferToNumber;
            SkipTurn = skipTurn;
            PlayKeypadTouchTone = playKeypadTouchTone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            PlayKeypadTouchTone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone || !IsEndCall && IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone || !IsEndCall && !IsLanguageDetection && IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && IsTransferToNumber && !IsSkipTurn && !IsPlayKeypadTouchTone || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && IsSkipTurn && !IsPlayKeypadTouchTone || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber && !IsSkipTurn && IsPlayKeypadTouchTone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.EndCallToolConfig?, TResult>? endCall = null,
            global::System.Func<global::ElevenLabs.LanguageDetectionToolConfig?, TResult>? languageDetection = null,
            global::System.Func<global::ElevenLabs.TransferToAgentToolConfig?, TResult>? transferToAgent = null,
            global::System.Func<global::ElevenLabs.TransferToNumberToolConfig?, TResult>? transferToNumber = null,
            global::System.Func<global::ElevenLabs.SkipTurnToolConfig?, TResult>? skipTurn = null,
            global::System.Func<global::ElevenLabs.PlayDTMFToolConfig?, TResult>? playKeypadTouchTone = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.EndCallToolConfig?>? endCall = null,
            global::System.Action<global::ElevenLabs.LanguageDetectionToolConfig?>? languageDetection = null,
            global::System.Action<global::ElevenLabs.TransferToAgentToolConfig?>? transferToAgent = null,
            global::System.Action<global::ElevenLabs.TransferToNumberToolConfig?>? transferToNumber = null,
            global::System.Action<global::ElevenLabs.SkipTurnToolConfig?>? skipTurn = null,
            global::System.Action<global::ElevenLabs.PlayDTMFToolConfig?>? playKeypadTouchTone = null,
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
                typeof(global::ElevenLabs.TransferToNumberToolConfig),
                SkipTurn,
                typeof(global::ElevenLabs.SkipTurnToolConfig),
                PlayKeypadTouchTone,
                typeof(global::ElevenLabs.PlayDTMFToolConfig),
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
        public bool Equals(Params other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.EndCallToolConfig?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.LanguageDetectionToolConfig?>.Default.Equals(LanguageDetection, other.LanguageDetection) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToAgentToolConfig?>.Default.Equals(TransferToAgent, other.TransferToAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToNumberToolConfig?>.Default.Equals(TransferToNumber, other.TransferToNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SkipTurnToolConfig?>.Default.Equals(SkipTurn, other.SkipTurn) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PlayDTMFToolConfig?>.Default.Equals(PlayKeypadTouchTone, other.PlayKeypadTouchTone) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Params obj1, Params obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Params>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Params obj1, Params obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Params o && Equals(o);
        }
    }
}
