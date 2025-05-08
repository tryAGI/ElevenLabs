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
        public static implicit operator Params2(global::ElevenLabs.TransferToNumberToolConfig value) => new Params2((global::ElevenLabs.TransferToNumberToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferToNumberToolConfig?(Params2 @this) => @this.TransferToNumber;

        /// <summary>
        /// 
        /// </summary>
        public Params2(global::ElevenLabs.TransferToNumberToolConfig? value)
        {
            TransferToNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Params2(
            global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType? systemToolType,
            global::ElevenLabs.EndCallToolConfig? endCall,
            global::ElevenLabs.LanguageDetectionToolConfig? languageDetection,
            global::ElevenLabs.TransferToAgentToolConfig? transferToAgent,
            global::ElevenLabs.TransferToNumberToolConfig? transferToNumber
            )
        {
            SystemToolType = systemToolType;

            EndCall = endCall;
            LanguageDetection = languageDetection;
            TransferToAgent = transferToAgent;
            TransferToNumber = transferToNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            TransferToNumber?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndCall && !IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber || !IsEndCall && IsLanguageDetection && !IsTransferToAgent && !IsTransferToNumber || !IsEndCall && !IsLanguageDetection && IsTransferToAgent && !IsTransferToNumber || !IsEndCall && !IsLanguageDetection && !IsTransferToAgent && IsTransferToNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.EndCallToolConfig?, TResult>? endCall = null,
            global::System.Func<global::ElevenLabs.LanguageDetectionToolConfig?, TResult>? languageDetection = null,
            global::System.Func<global::ElevenLabs.TransferToAgentToolConfig?, TResult>? transferToAgent = null,
            global::System.Func<global::ElevenLabs.TransferToNumberToolConfig?, TResult>? transferToNumber = null,
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
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferToNumberToolConfig?>.Default.Equals(TransferToNumber, other.TransferToNumber) 
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
