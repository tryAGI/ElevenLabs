#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BranchInfoVariant1 : global::System.IEquatable<BranchInfoVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason? BranchReason { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TransferBranchInfoTrafficSplit? TrafficSplit { get; init; }
#else
        public global::ElevenLabs.TransferBranchInfoTrafficSplit? TrafficSplit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrafficSplit))]
#endif
        public bool IsTrafficSplit => TrafficSplit != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTrafficSplit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TransferBranchInfoTrafficSplit? value)
        {
            value = TrafficSplit;
            return IsTrafficSplit;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoTrafficSplit PickTrafficSplit() => IsTrafficSplit
            ? TrafficSplit!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TrafficSplit' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TransferBranchInfoDefaultingToMain? DefaultingToMain { get; init; }
#else
        public global::ElevenLabs.TransferBranchInfoDefaultingToMain? DefaultingToMain { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DefaultingToMain))]
#endif
        public bool IsDefaultingToMain => DefaultingToMain != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDefaultingToMain(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TransferBranchInfoDefaultingToMain? value)
        {
            value = DefaultingToMain;
            return IsDefaultingToMain;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TransferBranchInfoDefaultingToMain PickDefaultingToMain() => IsDefaultingToMain
            ? DefaultingToMain!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DefaultingToMain' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BranchInfoVariant1(global::ElevenLabs.TransferBranchInfoTrafficSplit value) => new BranchInfoVariant1((global::ElevenLabs.TransferBranchInfoTrafficSplit?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferBranchInfoTrafficSplit?(BranchInfoVariant1 @this) => @this.TrafficSplit;

        /// <summary>
        /// 
        /// </summary>
        public BranchInfoVariant1(global::ElevenLabs.TransferBranchInfoTrafficSplit? value)
        {
            TrafficSplit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BranchInfoVariant1 FromTrafficSplit(global::ElevenLabs.TransferBranchInfoTrafficSplit? value) => new BranchInfoVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BranchInfoVariant1(global::ElevenLabs.TransferBranchInfoDefaultingToMain value) => new BranchInfoVariant1((global::ElevenLabs.TransferBranchInfoDefaultingToMain?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TransferBranchInfoDefaultingToMain?(BranchInfoVariant1 @this) => @this.DefaultingToMain;

        /// <summary>
        /// 
        /// </summary>
        public BranchInfoVariant1(global::ElevenLabs.TransferBranchInfoDefaultingToMain? value)
        {
            DefaultingToMain = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BranchInfoVariant1 FromDefaultingToMain(global::ElevenLabs.TransferBranchInfoDefaultingToMain? value) => new BranchInfoVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public BranchInfoVariant1(
            global::ElevenLabs.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason? branchReason,
            global::ElevenLabs.TransferBranchInfoTrafficSplit? trafficSplit,
            global::ElevenLabs.TransferBranchInfoDefaultingToMain? defaultingToMain
            )
        {
            BranchReason = branchReason;

            TrafficSplit = trafficSplit;
            DefaultingToMain = defaultingToMain;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DefaultingToMain as object ??
            TrafficSplit as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TrafficSplit?.ToString() ??
            DefaultingToMain?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTrafficSplit && !IsDefaultingToMain || !IsTrafficSplit && IsDefaultingToMain;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TransferBranchInfoTrafficSplit, TResult>? trafficSplit = null,
            global::System.Func<global::ElevenLabs.TransferBranchInfoDefaultingToMain, TResult>? defaultingToMain = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrafficSplit && trafficSplit != null)
            {
                return trafficSplit(TrafficSplit!);
            }
            else if (IsDefaultingToMain && defaultingToMain != null)
            {
                return defaultingToMain(DefaultingToMain!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.TransferBranchInfoTrafficSplit>? trafficSplit = null,

            global::System.Action<global::ElevenLabs.TransferBranchInfoDefaultingToMain>? defaultingToMain = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrafficSplit)
            {
                trafficSplit?.Invoke(TrafficSplit!);
            }
            else if (IsDefaultingToMain)
            {
                defaultingToMain?.Invoke(DefaultingToMain!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.TransferBranchInfoTrafficSplit>? trafficSplit = null,
            global::System.Action<global::ElevenLabs.TransferBranchInfoDefaultingToMain>? defaultingToMain = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrafficSplit)
            {
                trafficSplit?.Invoke(TrafficSplit!);
            }
            else if (IsDefaultingToMain)
            {
                defaultingToMain?.Invoke(DefaultingToMain!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TrafficSplit,
                typeof(global::ElevenLabs.TransferBranchInfoTrafficSplit),
                DefaultingToMain,
                typeof(global::ElevenLabs.TransferBranchInfoDefaultingToMain),
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
        public bool Equals(BranchInfoVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferBranchInfoTrafficSplit?>.Default.Equals(TrafficSplit, other.TrafficSplit) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TransferBranchInfoDefaultingToMain?>.Default.Equals(DefaultingToMain, other.DefaultingToMain) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BranchInfoVariant1 obj1, BranchInfoVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BranchInfoVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BranchInfoVariant1 obj1, BranchInfoVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BranchInfoVariant1 o && Equals(o);
        }
    }
}
