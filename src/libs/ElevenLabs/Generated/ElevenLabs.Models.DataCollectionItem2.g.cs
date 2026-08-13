#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataCollectionItem2 : global::System.IEquatable<DataCollectionItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource? Source { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AttachedUserDataCollectionRef? User { get; init; }
#else
        public global::ElevenLabs.AttachedUserDataCollectionRef? User { get; }
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
            out global::ElevenLabs.AttachedUserDataCollectionRef? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AttachedUserDataCollectionRef PickUser() => IsUser
            ? User!
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AttachedSystemDataCollectionRef? System { get; init; }
#else
        public global::ElevenLabs.AttachedSystemDataCollectionRef? System { get; }
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
            out global::ElevenLabs.AttachedSystemDataCollectionRef? value)
        {
            value = System;
            return IsSystem;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AttachedSystemDataCollectionRef PickSystem() => IsSystem
            ? System!
            : throw new global::System.InvalidOperationException($"Expected union variant 'System' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataCollectionItem2(global::ElevenLabs.AttachedUserDataCollectionRef value) => new DataCollectionItem2((global::ElevenLabs.AttachedUserDataCollectionRef?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.AttachedUserDataCollectionRef?(DataCollectionItem2 @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public DataCollectionItem2(global::ElevenLabs.AttachedUserDataCollectionRef? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataCollectionItem2 FromUser(global::ElevenLabs.AttachedUserDataCollectionRef? value) => new DataCollectionItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataCollectionItem2(global::ElevenLabs.AttachedSystemDataCollectionRef value) => new DataCollectionItem2((global::ElevenLabs.AttachedSystemDataCollectionRef?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.AttachedSystemDataCollectionRef?(DataCollectionItem2 @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public DataCollectionItem2(global::ElevenLabs.AttachedSystemDataCollectionRef? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataCollectionItem2 FromSystem(global::ElevenLabs.AttachedSystemDataCollectionRef? value) => new DataCollectionItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public DataCollectionItem2(
            global::ElevenLabs.AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource? source,
            global::ElevenLabs.AttachedUserDataCollectionRef? user,
            global::ElevenLabs.AttachedSystemDataCollectionRef? system
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
            global::System.Func<global::ElevenLabs.AttachedUserDataCollectionRef, TResult>? user = null,
            global::System.Func<global::ElevenLabs.AttachedSystemDataCollectionRef, TResult>? system = null,
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
            global::System.Action<global::ElevenLabs.AttachedUserDataCollectionRef>? user = null,

            global::System.Action<global::ElevenLabs.AttachedSystemDataCollectionRef>? system = null,
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
            global::System.Action<global::ElevenLabs.AttachedUserDataCollectionRef>? user = null,
            global::System.Action<global::ElevenLabs.AttachedSystemDataCollectionRef>? system = null,
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
                typeof(global::ElevenLabs.AttachedUserDataCollectionRef),
                System,
                typeof(global::ElevenLabs.AttachedSystemDataCollectionRef),
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
        public bool Equals(DataCollectionItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AttachedUserDataCollectionRef?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AttachedSystemDataCollectionRef?>.Default.Equals(System, other.System) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataCollectionItem2 obj1, DataCollectionItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataCollectionItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataCollectionItem2 obj1, DataCollectionItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataCollectionItem2 o && Equals(o);
        }
    }
}
