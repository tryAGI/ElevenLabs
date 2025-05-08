#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentToolsItem : global::System.IEquatable<AgentToolsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesAgentToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DependentAvailableAgentToolIdentifier? Available { get; init; }
#else
        public global::ElevenLabs.DependentAvailableAgentToolIdentifier? Available { get; }
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
        public static implicit operator AgentToolsItem(global::ElevenLabs.DependentAvailableAgentToolIdentifier value) => new AgentToolsItem((global::ElevenLabs.DependentAvailableAgentToolIdentifier?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DependentAvailableAgentToolIdentifier?(AgentToolsItem @this) => @this.Available;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolsItem(global::ElevenLabs.DependentAvailableAgentToolIdentifier? value)
        {
            Available = value;
        }

        /// <summary>
        /// A model that represents an tool dependent on a knowledge base/tools<br/>
        /// to which the user has no direct access.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DependentUnknownAgentToolIdentifier? Unknown { get; init; }
#else
        public global::ElevenLabs.DependentUnknownAgentToolIdentifier? Unknown { get; }
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
        public static implicit operator AgentToolsItem(global::ElevenLabs.DependentUnknownAgentToolIdentifier value) => new AgentToolsItem((global::ElevenLabs.DependentUnknownAgentToolIdentifier?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DependentUnknownAgentToolIdentifier?(AgentToolsItem @this) => @this.Unknown;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolsItem(global::ElevenLabs.DependentUnknownAgentToolIdentifier? value)
        {
            Unknown = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentToolsItem(
            global::ElevenLabs.ConvAIStoredSecretDependenciesAgentToolDiscriminatorType? type,
            global::ElevenLabs.DependentAvailableAgentToolIdentifier? available,
            global::ElevenLabs.DependentUnknownAgentToolIdentifier? unknown
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
            global::System.Func<global::ElevenLabs.DependentAvailableAgentToolIdentifier?, TResult>? available = null,
            global::System.Func<global::ElevenLabs.DependentUnknownAgentToolIdentifier?, TResult>? unknown = null,
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
            global::System.Action<global::ElevenLabs.DependentAvailableAgentToolIdentifier?>? available = null,
            global::System.Action<global::ElevenLabs.DependentUnknownAgentToolIdentifier?>? unknown = null,
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
                typeof(global::ElevenLabs.DependentAvailableAgentToolIdentifier),
                Unknown,
                typeof(global::ElevenLabs.DependentUnknownAgentToolIdentifier),
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
        public bool Equals(AgentToolsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DependentAvailableAgentToolIdentifier?>.Default.Equals(Available, other.Available) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DependentUnknownAgentToolIdentifier?>.Default.Equals(Unknown, other.Unknown) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentToolsItem obj1, AgentToolsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentToolsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentToolsItem obj1, AgentToolsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentToolsItem o && Equals(o);
        }
    }
}
