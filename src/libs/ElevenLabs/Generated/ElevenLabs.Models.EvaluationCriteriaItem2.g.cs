#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EvaluationCriteriaItem2 : global::System.IEquatable<EvaluationCriteriaItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource? Source { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AttachedUserEvaluationRef? User { get; init; }
#else
        public global::ElevenLabs.AttachedUserEvaluationRef? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AttachedUserEvaluationRef? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AttachedUserEvaluationRef PickUser() => IsUser
            ? User!
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AttachedSystemEvaluationRef? System { get; init; }
#else
        public global::ElevenLabs.AttachedSystemEvaluationRef? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSystem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AttachedSystemEvaluationRef? value)
        {
            value = System;
            return IsSystem;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AttachedSystemEvaluationRef PickSystem() => IsSystem
            ? System!
            : throw new global::System.InvalidOperationException($"Expected union variant 'System' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvaluationCriteriaItem2(global::ElevenLabs.AttachedUserEvaluationRef value) => new EvaluationCriteriaItem2((global::ElevenLabs.AttachedUserEvaluationRef?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.AttachedUserEvaluationRef?(EvaluationCriteriaItem2 @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public EvaluationCriteriaItem2(global::ElevenLabs.AttachedUserEvaluationRef? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EvaluationCriteriaItem2 FromUser(global::ElevenLabs.AttachedUserEvaluationRef? value) => new EvaluationCriteriaItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvaluationCriteriaItem2(global::ElevenLabs.AttachedSystemEvaluationRef value) => new EvaluationCriteriaItem2((global::ElevenLabs.AttachedSystemEvaluationRef?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.AttachedSystemEvaluationRef?(EvaluationCriteriaItem2 @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public EvaluationCriteriaItem2(global::ElevenLabs.AttachedSystemEvaluationRef? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EvaluationCriteriaItem2 FromSystem(global::ElevenLabs.AttachedSystemEvaluationRef? value) => new EvaluationCriteriaItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public EvaluationCriteriaItem2(
            global::ElevenLabs.AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource? source,
            global::ElevenLabs.AttachedUserEvaluationRef? user,
            global::ElevenLabs.AttachedSystemEvaluationRef? system
            )
        {
            Source = source;

            User = user;
            System = system;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            System as object ??
            User as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            User?.ToString() ??
            System?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUser && !IsSystem || !IsUser && IsSystem;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.AttachedUserEvaluationRef, TResult>? user = null,
            global::System.Func<global::ElevenLabs.AttachedSystemEvaluationRef, TResult>? system = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsSystem && system != null)
            {
                return system(System!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.AttachedUserEvaluationRef>? user = null,

            global::System.Action<global::ElevenLabs.AttachedSystemEvaluationRef>? system = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsSystem)
            {
                system?.Invoke(System!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.AttachedUserEvaluationRef>? user = null,
            global::System.Action<global::ElevenLabs.AttachedSystemEvaluationRef>? system = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsSystem)
            {
                system?.Invoke(System!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                User,
                typeof(global::ElevenLabs.AttachedUserEvaluationRef),
                System,
                typeof(global::ElevenLabs.AttachedSystemEvaluationRef),
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
        public bool Equals(EvaluationCriteriaItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AttachedUserEvaluationRef?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AttachedSystemEvaluationRef?>.Default.Equals(System, other.System) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvaluationCriteriaItem2 obj1, EvaluationCriteriaItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvaluationCriteriaItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvaluationCriteriaItem2 obj1, EvaluationCriteriaItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvaluationCriteriaItem2 o && Equals(o);
        }
    }
}
