#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentTransferOp : global::System.IEquatable<AgentTransferOp>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AgentTransferOpDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AgentTransferOpReplace? Replace { get; init; }
#else
        public global::ElevenLabs.AgentTransferOpReplace? Replace { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Replace))]
#endif
        public bool IsReplace => Replace != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReplace(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AgentTransferOpReplace? value)
        {
            value = Replace;
            return IsReplace;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AgentTransferOpReplace PickReplace() => IsReplace
            ? Replace!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Replace' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AgentTransferOpPush? Push { get; init; }
#else
        public global::ElevenLabs.AgentTransferOpPush? Push { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Push))]
#endif
        public bool IsPush => Push != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPush(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AgentTransferOpPush? value)
        {
            value = Push;
            return IsPush;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AgentTransferOpPush PickPush() => IsPush
            ? Push!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Push' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AgentTransferOpPop? Pop { get; init; }
#else
        public global::ElevenLabs.AgentTransferOpPop? Pop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pop))]
#endif
        public bool IsPop => Pop != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPop(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AgentTransferOpPop? value)
        {
            value = Pop;
            return IsPop;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AgentTransferOpPop PickPop() => IsPop
            ? Pop!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pop' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentTransferOp(global::ElevenLabs.AgentTransferOpReplace value) => new AgentTransferOp((global::ElevenLabs.AgentTransferOpReplace?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.AgentTransferOpReplace?(AgentTransferOp @this) => @this.Replace;

        /// <summary>
        /// 
        /// </summary>
        public AgentTransferOp(global::ElevenLabs.AgentTransferOpReplace? value)
        {
            Replace = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentTransferOp FromReplace(global::ElevenLabs.AgentTransferOpReplace? value) => new AgentTransferOp(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentTransferOp(global::ElevenLabs.AgentTransferOpPush value) => new AgentTransferOp((global::ElevenLabs.AgentTransferOpPush?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.AgentTransferOpPush?(AgentTransferOp @this) => @this.Push;

        /// <summary>
        /// 
        /// </summary>
        public AgentTransferOp(global::ElevenLabs.AgentTransferOpPush? value)
        {
            Push = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentTransferOp FromPush(global::ElevenLabs.AgentTransferOpPush? value) => new AgentTransferOp(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentTransferOp(global::ElevenLabs.AgentTransferOpPop value) => new AgentTransferOp((global::ElevenLabs.AgentTransferOpPop?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.AgentTransferOpPop?(AgentTransferOp @this) => @this.Pop;

        /// <summary>
        /// 
        /// </summary>
        public AgentTransferOp(global::ElevenLabs.AgentTransferOpPop? value)
        {
            Pop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentTransferOp FromPop(global::ElevenLabs.AgentTransferOpPop? value) => new AgentTransferOp(value);

        /// <summary>
        /// 
        /// </summary>
        public AgentTransferOp(
            global::ElevenLabs.AgentTransferOpDiscriminatorType? type,
            global::ElevenLabs.AgentTransferOpReplace? replace,
            global::ElevenLabs.AgentTransferOpPush? push,
            global::ElevenLabs.AgentTransferOpPop? pop
            )
        {
            Type = type;

            Replace = replace;
            Push = push;
            Pop = pop;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Pop as object ??
            Push as object ??
            Replace as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Replace?.ToString() ??
            Push?.ToString() ??
            Pop?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReplace && !IsPush && !IsPop || !IsReplace && IsPush && !IsPop || !IsReplace && !IsPush && IsPop;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.AgentTransferOpReplace, TResult>? replace = null,
            global::System.Func<global::ElevenLabs.AgentTransferOpPush, TResult>? push = null,
            global::System.Func<global::ElevenLabs.AgentTransferOpPop, TResult>? pop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReplace && replace != null)
            {
                return replace(Replace!);
            }
            else if (IsPush && push != null)
            {
                return push(Push!);
            }
            else if (IsPop && pop != null)
            {
                return pop(Pop!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.AgentTransferOpReplace>? replace = null,

            global::System.Action<global::ElevenLabs.AgentTransferOpPush>? push = null,

            global::System.Action<global::ElevenLabs.AgentTransferOpPop>? pop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReplace)
            {
                replace?.Invoke(Replace!);
            }
            else if (IsPush)
            {
                push?.Invoke(Push!);
            }
            else if (IsPop)
            {
                pop?.Invoke(Pop!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.AgentTransferOpReplace>? replace = null,
            global::System.Action<global::ElevenLabs.AgentTransferOpPush>? push = null,
            global::System.Action<global::ElevenLabs.AgentTransferOpPop>? pop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReplace)
            {
                replace?.Invoke(Replace!);
            }
            else if (IsPush)
            {
                push?.Invoke(Push!);
            }
            else if (IsPop)
            {
                pop?.Invoke(Pop!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Replace,
                typeof(global::ElevenLabs.AgentTransferOpReplace),
                Push,
                typeof(global::ElevenLabs.AgentTransferOpPush),
                Pop,
                typeof(global::ElevenLabs.AgentTransferOpPop),
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
        public bool Equals(AgentTransferOp other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AgentTransferOpReplace?>.Default.Equals(Replace, other.Replace) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AgentTransferOpPush?>.Default.Equals(Push, other.Push) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AgentTransferOpPop?>.Default.Equals(Pop, other.Pop) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentTransferOp obj1, AgentTransferOp obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentTransferOp>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentTransferOp obj1, AgentTransferOp obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentTransferOp o && Equals(o);
        }
    }
}
