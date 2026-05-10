#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TriggerAction : global::System.IEquatable<TriggerAction>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.EndCallTriggerAction? EndCall { get; init; }
#else
        public global::ElevenLabs.EndCallTriggerAction? EndCall { get; }
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
            out global::ElevenLabs.EndCallTriggerAction? value)
        {
            value = EndCall;
            return IsEndCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.EndCallTriggerAction PickEndCall() => IsEndCall
            ? EndCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EndCall' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.RetryTriggerAction? Retry { get; init; }
#else
        public global::ElevenLabs.RetryTriggerAction? Retry { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Retry))]
#endif
        public bool IsRetry => Retry != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRetry(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.RetryTriggerAction? value)
        {
            value = Retry;
            return IsRetry;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.RetryTriggerAction PickRetry() => IsRetry
            ? Retry!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Retry' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TriggerAction(global::ElevenLabs.EndCallTriggerAction value) => new TriggerAction((global::ElevenLabs.EndCallTriggerAction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.EndCallTriggerAction?(TriggerAction @this) => @this.EndCall;

        /// <summary>
        /// 
        /// </summary>
        public TriggerAction(global::ElevenLabs.EndCallTriggerAction? value)
        {
            EndCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TriggerAction FromEndCall(global::ElevenLabs.EndCallTriggerAction? value) => new TriggerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TriggerAction(global::ElevenLabs.RetryTriggerAction value) => new TriggerAction((global::ElevenLabs.RetryTriggerAction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.RetryTriggerAction?(TriggerAction @this) => @this.Retry;

        /// <summary>
        /// 
        /// </summary>
        public TriggerAction(global::ElevenLabs.RetryTriggerAction? value)
        {
            Retry = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TriggerAction FromRetry(global::ElevenLabs.RetryTriggerAction? value) => new TriggerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public TriggerAction(
            global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType? type,
            global::ElevenLabs.EndCallTriggerAction? endCall,
            global::ElevenLabs.RetryTriggerAction? retry
            )
        {
            Type = type;

            EndCall = endCall;
            Retry = retry;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Retry as object ??
            EndCall as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EndCall?.ToString() ??
            Retry?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndCall && !IsRetry || !IsEndCall && IsRetry;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.EndCallTriggerAction, TResult>? endCall = null,
            global::System.Func<global::ElevenLabs.RetryTriggerAction, TResult>? retry = null,
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
            else if (IsRetry && retry != null)
            {
                return retry(Retry!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.EndCallTriggerAction>? endCall = null,

            global::System.Action<global::ElevenLabs.RetryTriggerAction>? retry = null,
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
            else if (IsRetry)
            {
                retry?.Invoke(Retry!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.EndCallTriggerAction>? endCall = null,
            global::System.Action<global::ElevenLabs.RetryTriggerAction>? retry = null,
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
            else if (IsRetry)
            {
                retry?.Invoke(Retry!);
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
                typeof(global::ElevenLabs.EndCallTriggerAction),
                Retry,
                typeof(global::ElevenLabs.RetryTriggerAction),
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
        public bool Equals(TriggerAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.EndCallTriggerAction?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.RetryTriggerAction?>.Default.Equals(Retry, other.Retry) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TriggerAction obj1, TriggerAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TriggerAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TriggerAction obj1, TriggerAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TriggerAction o && Equals(o);
        }
    }
}
