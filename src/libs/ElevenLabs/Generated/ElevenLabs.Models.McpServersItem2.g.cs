#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct McpServersItem2 : global::System.IEquatable<McpServersItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DependentAvailableMCPServerIdentifier? Available { get; init; }
#else
        public global::ElevenLabs.DependentAvailableMCPServerIdentifier? Available { get; }
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
            out global::ElevenLabs.DependentAvailableMCPServerIdentifier? value)
        {
            value = Available;
            return IsAvailable;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.DependentAvailableMCPServerIdentifier PickAvailable() => IsAvailable
            ? Available!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Available' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DependentUnknownMCPServerIdentifier? Unknown { get; init; }
#else
        public global::ElevenLabs.DependentUnknownMCPServerIdentifier? Unknown { get; }
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
            out global::ElevenLabs.DependentUnknownMCPServerIdentifier? value)
        {
            value = Unknown;
            return IsUnknown;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.DependentUnknownMCPServerIdentifier PickUnknown() => IsUnknown
            ? Unknown!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unknown' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpServersItem2(global::ElevenLabs.DependentAvailableMCPServerIdentifier value) => new McpServersItem2((global::ElevenLabs.DependentAvailableMCPServerIdentifier?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DependentAvailableMCPServerIdentifier?(McpServersItem2 @this) => @this.Available;

        /// <summary>
        /// 
        /// </summary>
        public McpServersItem2(global::ElevenLabs.DependentAvailableMCPServerIdentifier? value)
        {
            Available = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static McpServersItem2 FromAvailable(global::ElevenLabs.DependentAvailableMCPServerIdentifier? value) => new McpServersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpServersItem2(global::ElevenLabs.DependentUnknownMCPServerIdentifier value) => new McpServersItem2((global::ElevenLabs.DependentUnknownMCPServerIdentifier?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DependentUnknownMCPServerIdentifier?(McpServersItem2 @this) => @this.Unknown;

        /// <summary>
        /// 
        /// </summary>
        public McpServersItem2(global::ElevenLabs.DependentUnknownMCPServerIdentifier? value)
        {
            Unknown = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static McpServersItem2 FromUnknown(global::ElevenLabs.DependentUnknownMCPServerIdentifier? value) => new McpServersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public McpServersItem2(
            global::ElevenLabs.ConvAIStoredSecretDependenciesMcpServerDiscriminatorType? type,
            global::ElevenLabs.DependentAvailableMCPServerIdentifier? available,
            global::ElevenLabs.DependentUnknownMCPServerIdentifier? unknown
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
            global::System.Func<global::ElevenLabs.DependentAvailableMCPServerIdentifier, TResult>? available = null,
            global::System.Func<global::ElevenLabs.DependentUnknownMCPServerIdentifier, TResult>? unknown = null,
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
            global::System.Action<global::ElevenLabs.DependentAvailableMCPServerIdentifier>? available = null,

            global::System.Action<global::ElevenLabs.DependentUnknownMCPServerIdentifier>? unknown = null,
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
            global::System.Action<global::ElevenLabs.DependentAvailableMCPServerIdentifier>? available = null,
            global::System.Action<global::ElevenLabs.DependentUnknownMCPServerIdentifier>? unknown = null,
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
                typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifier),
                Unknown,
                typeof(global::ElevenLabs.DependentUnknownMCPServerIdentifier),
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
        public bool Equals(McpServersItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DependentAvailableMCPServerIdentifier?>.Default.Equals(Available, other.Available) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DependentUnknownMCPServerIdentifier?>.Default.Equals(Unknown, other.Unknown) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(McpServersItem2 obj1, McpServersItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpServersItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(McpServersItem2 obj1, McpServersItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpServersItem2 o && Equals(o);
        }
    }
}
