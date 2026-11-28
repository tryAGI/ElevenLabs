#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Author2 : global::System.IEquatable<Author2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketMessageRequestAuthorDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketRequesterAuthorRequest? Requester { get; init; }
#else
        public global::ElevenLabs.TicketRequesterAuthorRequest? Requester { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Requester))]
#endif
        public bool IsRequester => Requester != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequester(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketRequesterAuthorRequest? value)
        {
            value = Requester;
            return IsRequester;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketRequesterAuthorRequest PickRequester() => Requester is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Requester' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketHumanAgentAuthorRequest? HumanAgent { get; init; }
#else
        public global::ElevenLabs.TicketHumanAgentAuthorRequest? HumanAgent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HumanAgent))]
#endif
        public bool IsHumanAgent => HumanAgent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHumanAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketHumanAgentAuthorRequest? value)
        {
            value = HumanAgent;
            return IsHumanAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketHumanAgentAuthorRequest PickHumanAgent() => HumanAgent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HumanAgent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Author2(global::ElevenLabs.TicketRequesterAuthorRequest value) => new Author2((global::ElevenLabs.TicketRequesterAuthorRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketRequesterAuthorRequest?(Author2 @this) => @this.Requester;

        /// <summary>
        ///
        /// </summary>
        public Author2(global::ElevenLabs.TicketRequesterAuthorRequest? value)
        {
            Requester = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Author2 FromRequester(global::ElevenLabs.TicketRequesterAuthorRequest? value) => new Author2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Author2(global::ElevenLabs.TicketHumanAgentAuthorRequest value) => new Author2((global::ElevenLabs.TicketHumanAgentAuthorRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketHumanAgentAuthorRequest?(Author2 @this) => @this.HumanAgent;

        /// <summary>
        ///
        /// </summary>
        public Author2(global::ElevenLabs.TicketHumanAgentAuthorRequest? value)
        {
            HumanAgent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Author2 FromHumanAgent(global::ElevenLabs.TicketHumanAgentAuthorRequest? value) => new Author2(value);

        /// <summary>
        ///
        /// </summary>
        public Author2(
            global::ElevenLabs.CreateTicketMessageRequestAuthorDiscriminatorType? type,
            global::ElevenLabs.TicketRequesterAuthorRequest? requester,
            global::ElevenLabs.TicketHumanAgentAuthorRequest? humanAgent
            )
        {
            Type = type;

            Requester = requester;
            HumanAgent = humanAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            HumanAgent as object ??
            Requester as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Requester?.ToString() ??
            HumanAgent?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRequester && !IsHumanAgent || !IsRequester && IsHumanAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TicketRequesterAuthorRequest, TResult>? requester = null,
            global::System.Func<global::ElevenLabs.TicketHumanAgentAuthorRequest, TResult>? humanAgent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Requester is { } __value0 && requester != null)
            {
                return requester(__value0);
            }
            else if (HumanAgent is { } __value1 && humanAgent != null)
            {
                return humanAgent(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.TicketRequesterAuthorRequest>? requester = null,

            global::System.Action<global::ElevenLabs.TicketHumanAgentAuthorRequest>? humanAgent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Requester is { } __value0)
            {
                requester?.Invoke(__value0);
            }
            else if (HumanAgent is { } __value1)
            {
                humanAgent?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.TicketRequesterAuthorRequest>? requester = null,
            global::System.Action<global::ElevenLabs.TicketHumanAgentAuthorRequest>? humanAgent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Requester is { } __value0)
            {
                requester?.Invoke(__value0);
            }
            else if (HumanAgent is { } __value1)
            {
                humanAgent?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Requester,
                typeof(global::ElevenLabs.TicketRequesterAuthorRequest),
                HumanAgent,
                typeof(global::ElevenLabs.TicketHumanAgentAuthorRequest),
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
        public bool Equals(Author2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketRequesterAuthorRequest?>.Default.Equals(Requester, other.Requester) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketHumanAgentAuthorRequest?>.Default.Equals(HumanAgent, other.HumanAgent)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Author2 obj1, Author2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Author2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Author2 obj1, Author2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Author2 o && Equals(o);
        }
    }
}
