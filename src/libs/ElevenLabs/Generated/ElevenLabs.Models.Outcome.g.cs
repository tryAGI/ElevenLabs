#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Outcome : global::System.IEquatable<Outcome>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus? Status { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.OpenOutcome? Open { get; init; }
#else
        public global::ElevenLabs.OpenOutcome? Open { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Open))]
#endif
        public bool IsOpen => Open != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpen(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.OpenOutcome? value)
        {
            value = Open;
            return IsOpen;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.OpenOutcome PickOpen() => Open is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Open' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MergedOutcome? Merged { get; init; }
#else
        public global::ElevenLabs.MergedOutcome? Merged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Merged))]
#endif
        public bool IsMerged => Merged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMerged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.MergedOutcome? value)
        {
            value = Merged;
            return IsMerged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MergedOutcome PickMerged() => Merged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Merged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ClosedOutcome? Closed { get; init; }
#else
        public global::ElevenLabs.ClosedOutcome? Closed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Closed))]
#endif
        public bool IsClosed => Closed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClosed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ClosedOutcome? value)
        {
            value = Closed;
            return IsClosed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClosedOutcome PickClosed() => Closed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Closed' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Outcome(global::ElevenLabs.OpenOutcome value) => new Outcome((global::ElevenLabs.OpenOutcome?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.OpenOutcome?(Outcome @this) => @this.Open;

        /// <summary>
        ///
        /// </summary>
        public Outcome(global::ElevenLabs.OpenOutcome? value)
        {
            Open = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Outcome FromOpen(global::ElevenLabs.OpenOutcome? value) => new Outcome(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Outcome(global::ElevenLabs.MergedOutcome value) => new Outcome((global::ElevenLabs.MergedOutcome?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.MergedOutcome?(Outcome @this) => @this.Merged;

        /// <summary>
        ///
        /// </summary>
        public Outcome(global::ElevenLabs.MergedOutcome? value)
        {
            Merged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Outcome FromMerged(global::ElevenLabs.MergedOutcome? value) => new Outcome(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Outcome(global::ElevenLabs.ClosedOutcome value) => new Outcome((global::ElevenLabs.ClosedOutcome?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ClosedOutcome?(Outcome @this) => @this.Closed;

        /// <summary>
        ///
        /// </summary>
        public Outcome(global::ElevenLabs.ClosedOutcome? value)
        {
            Closed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Outcome FromClosed(global::ElevenLabs.ClosedOutcome? value) => new Outcome(value);

        /// <summary>
        ///
        /// </summary>
        public Outcome(
            global::ElevenLabs.AgentMergeProposalResponseOutcomeDiscriminatorStatus? status,
            global::ElevenLabs.OpenOutcome? open,
            global::ElevenLabs.MergedOutcome? merged,
            global::ElevenLabs.ClosedOutcome? closed
            )
        {
            Status = status;

            Open = open;
            Merged = merged;
            Closed = closed;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Closed as object ??
            Merged as object ??
            Open as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Open?.ToString() ??
            Merged?.ToString() ??
            Closed?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpen && !IsMerged && !IsClosed || !IsOpen && IsMerged && !IsClosed || !IsOpen && !IsMerged && IsClosed;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.OpenOutcome, TResult>? open = null,
            global::System.Func<global::ElevenLabs.MergedOutcome, TResult>? merged = null,
            global::System.Func<global::ElevenLabs.ClosedOutcome, TResult>? closed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Open is { } __value0 && open != null)
            {
                return open(__value0);
            }
            else if (Merged is { } __value1 && merged != null)
            {
                return merged(__value1);
            }
            else if (Closed is { } __value2 && closed != null)
            {
                return closed(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.OpenOutcome>? open = null,

            global::System.Action<global::ElevenLabs.MergedOutcome>? merged = null,

            global::System.Action<global::ElevenLabs.ClosedOutcome>? closed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Open is { } __value0)
            {
                open?.Invoke(__value0);
            }
            else if (Merged is { } __value1)
            {
                merged?.Invoke(__value1);
            }
            else if (Closed is { } __value2)
            {
                closed?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.OpenOutcome>? open = null,
            global::System.Action<global::ElevenLabs.MergedOutcome>? merged = null,
            global::System.Action<global::ElevenLabs.ClosedOutcome>? closed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Open is { } __value0)
            {
                open?.Invoke(__value0);
            }
            else if (Merged is { } __value1)
            {
                merged?.Invoke(__value1);
            }
            else if (Closed is { } __value2)
            {
                closed?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Open,
                typeof(global::ElevenLabs.OpenOutcome),
                Merged,
                typeof(global::ElevenLabs.MergedOutcome),
                Closed,
                typeof(global::ElevenLabs.ClosedOutcome),
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
        public bool Equals(Outcome other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.OpenOutcome?>.Default.Equals(Open, other.Open) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MergedOutcome?>.Default.Equals(Merged, other.Merged) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ClosedOutcome?>.Default.Equals(Closed, other.Closed)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Outcome obj1, Outcome obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Outcome>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Outcome obj1, Outcome obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Outcome o && Equals(o);
        }
    }
}
