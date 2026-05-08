#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DependenciesVariant1Item : global::System.IEquatable<DependenciesVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DependentAvailableToolIdentifier? Available { get; init; }
#else
        public global::ElevenLabs.DependentAvailableToolIdentifier? Available { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Available))]
#endif
        public bool IsAvailable => Available != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAvailable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DependentAvailableToolIdentifier? value)
        {
            value = Available;
            return IsAvailable;
        }

        /// <summary>
        /// A model that represents an tool dependent on a knowledge base/tools<br/>
        /// to which the user has no direct access.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DependentUnknownToolIdentifier? Unknown { get; init; }
#else
        public global::ElevenLabs.DependentUnknownToolIdentifier? Unknown { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unknown))]
#endif
        public bool IsUnknown => Unknown != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnknown(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DependentUnknownToolIdentifier? value)
        {
            value = Unknown;
            return IsUnknown;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DependenciesVariant1Item(global::ElevenLabs.DependentAvailableToolIdentifier value) => new DependenciesVariant1Item((global::ElevenLabs.DependentAvailableToolIdentifier?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DependentAvailableToolIdentifier?(DependenciesVariant1Item @this) => @this.Available;

        /// <summary>
        /// 
        /// </summary>
        public DependenciesVariant1Item(global::ElevenLabs.DependentAvailableToolIdentifier? value)
        {
            Available = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DependenciesVariant1Item(global::ElevenLabs.DependentUnknownToolIdentifier value) => new DependenciesVariant1Item((global::ElevenLabs.DependentUnknownToolIdentifier?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DependentUnknownToolIdentifier?(DependenciesVariant1Item @this) => @this.Unknown;

        /// <summary>
        /// 
        /// </summary>
        public DependenciesVariant1Item(global::ElevenLabs.DependentUnknownToolIdentifier? value)
        {
            Unknown = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DependenciesVariant1Item(
            global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType? type,
            global::ElevenLabs.DependentAvailableToolIdentifier? available,
            global::ElevenLabs.DependentUnknownToolIdentifier? unknown
            )
        {
            Type = type;

            Available = available;
            Unknown = unknown;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Unknown as object ??
            Available as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Available?.ToString() ??
            Unknown?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAvailable && !IsUnknown || !IsAvailable && IsUnknown;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.DependentAvailableToolIdentifier, TResult>? available = null,
            global::System.Func<global::ElevenLabs.DependentUnknownToolIdentifier, TResult>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAvailable && available != null)
            {
                return available(Available!);
            }
            else if (IsUnknown && unknown != null)
            {
                return unknown(Unknown!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.DependentAvailableToolIdentifier>? available = null,

            global::System.Action<global::ElevenLabs.DependentUnknownToolIdentifier>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAvailable)
            {
                available?.Invoke(Available!);
            }
            else if (IsUnknown)
            {
                unknown?.Invoke(Unknown!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.DependentAvailableToolIdentifier>? available = null,
            global::System.Action<global::ElevenLabs.DependentUnknownToolIdentifier>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAvailable)
            {
                available?.Invoke(Available!);
            }
            else if (IsUnknown)
            {
                unknown?.Invoke(Unknown!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Available,
                typeof(global::ElevenLabs.DependentAvailableToolIdentifier),
                Unknown,
                typeof(global::ElevenLabs.DependentUnknownToolIdentifier),
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
        public bool Equals(DependenciesVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DependentAvailableToolIdentifier?>.Default.Equals(Available, other.Available) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DependentUnknownToolIdentifier?>.Default.Equals(Unknown, other.Unknown) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DependenciesVariant1Item obj1, DependenciesVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DependenciesVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DependenciesVariant1Item obj1, DependenciesVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DependenciesVariant1Item o && Equals(o);
        }
    }
}
