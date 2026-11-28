#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Author12 : global::System.IEquatable<Author12>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSubscribersChangedEventResponseAuthorDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketEventRequesterAuthorResponse? Requester { get; init; }
#else
        public global::ElevenLabs.TicketEventRequesterAuthorResponse? Requester { get; }
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
            out global::ElevenLabs.TicketEventRequesterAuthorResponse? value)
        {
            value = Requester;
            return IsRequester;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketEventRequesterAuthorResponse PickRequester() => Requester is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Requester' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketEventAIAgentAuthorResponse? AiAgent { get; init; }
#else
        public global::ElevenLabs.TicketEventAIAgentAuthorResponse? AiAgent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AiAgent))]
#endif
        public bool IsAiAgent => AiAgent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAiAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketEventAIAgentAuthorResponse? value)
        {
            value = AiAgent;
            return IsAiAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketEventAIAgentAuthorResponse PickAiAgent() => AiAgent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AiAgent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketEventHumanAgentAuthorResponse? HumanAgent { get; init; }
#else
        public global::ElevenLabs.TicketEventHumanAgentAuthorResponse? HumanAgent { get; }
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
            out global::ElevenLabs.TicketEventHumanAgentAuthorResponse? value)
        {
            value = HumanAgent;
            return IsHumanAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketEventHumanAgentAuthorResponse PickHumanAgent() => HumanAgent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HumanAgent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Author12(global::ElevenLabs.TicketEventRequesterAuthorResponse value) => new Author12((global::ElevenLabs.TicketEventRequesterAuthorResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketEventRequesterAuthorResponse?(Author12 @this) => @this.Requester;

        /// <summary>
        ///
        /// </summary>
        public Author12(global::ElevenLabs.TicketEventRequesterAuthorResponse? value)
        {
            Requester = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Author12 FromRequester(global::ElevenLabs.TicketEventRequesterAuthorResponse? value) => new Author12(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Author12(global::ElevenLabs.TicketEventAIAgentAuthorResponse value) => new Author12((global::ElevenLabs.TicketEventAIAgentAuthorResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketEventAIAgentAuthorResponse?(Author12 @this) => @this.AiAgent;

        /// <summary>
        ///
        /// </summary>
        public Author12(global::ElevenLabs.TicketEventAIAgentAuthorResponse? value)
        {
            AiAgent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Author12 FromAiAgent(global::ElevenLabs.TicketEventAIAgentAuthorResponse? value) => new Author12(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Author12(global::ElevenLabs.TicketEventHumanAgentAuthorResponse value) => new Author12((global::ElevenLabs.TicketEventHumanAgentAuthorResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketEventHumanAgentAuthorResponse?(Author12 @this) => @this.HumanAgent;

        /// <summary>
        ///
        /// </summary>
        public Author12(global::ElevenLabs.TicketEventHumanAgentAuthorResponse? value)
        {
            HumanAgent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Author12 FromHumanAgent(global::ElevenLabs.TicketEventHumanAgentAuthorResponse? value) => new Author12(value);

        /// <summary>
        ///
        /// </summary>
        public Author12(
            global::ElevenLabs.TicketSubscribersChangedEventResponseAuthorDiscriminatorType? type,
            global::ElevenLabs.TicketEventRequesterAuthorResponse? requester,
            global::ElevenLabs.TicketEventAIAgentAuthorResponse? aiAgent,
            global::ElevenLabs.TicketEventHumanAgentAuthorResponse? humanAgent
            )
        {
            Type = type;

            Requester = requester;
            AiAgent = aiAgent;
            HumanAgent = humanAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            HumanAgent as object ??
            AiAgent as object ??
            Requester as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Requester?.ToString() ??
            AiAgent?.ToString() ??
            HumanAgent?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRequester && !IsAiAgent && !IsHumanAgent || !IsRequester && IsAiAgent && !IsHumanAgent || !IsRequester && !IsAiAgent && IsHumanAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TicketEventRequesterAuthorResponse, TResult>? requester = null,
            global::System.Func<global::ElevenLabs.TicketEventAIAgentAuthorResponse, TResult>? aiAgent = null,
            global::System.Func<global::ElevenLabs.TicketEventHumanAgentAuthorResponse, TResult>? humanAgent = null,
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
            else if (AiAgent is { } __value1 && aiAgent != null)
            {
                return aiAgent(__value1);
            }
            else if (HumanAgent is { } __value2 && humanAgent != null)
            {
                return humanAgent(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.TicketEventRequesterAuthorResponse>? requester = null,

            global::System.Action<global::ElevenLabs.TicketEventAIAgentAuthorResponse>? aiAgent = null,

            global::System.Action<global::ElevenLabs.TicketEventHumanAgentAuthorResponse>? humanAgent = null,
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
            else if (AiAgent is { } __value1)
            {
                aiAgent?.Invoke(__value1);
            }
            else if (HumanAgent is { } __value2)
            {
                humanAgent?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.TicketEventRequesterAuthorResponse>? requester = null,
            global::System.Action<global::ElevenLabs.TicketEventAIAgentAuthorResponse>? aiAgent = null,
            global::System.Action<global::ElevenLabs.TicketEventHumanAgentAuthorResponse>? humanAgent = null,
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
            else if (AiAgent is { } __value1)
            {
                aiAgent?.Invoke(__value1);
            }
            else if (HumanAgent is { } __value2)
            {
                humanAgent?.Invoke(__value2);
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
                typeof(global::ElevenLabs.TicketEventRequesterAuthorResponse),
                AiAgent,
                typeof(global::ElevenLabs.TicketEventAIAgentAuthorResponse),
                HumanAgent,
                typeof(global::ElevenLabs.TicketEventHumanAgentAuthorResponse),
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
        public bool Equals(Author12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketEventRequesterAuthorResponse?>.Default.Equals(Requester, other.Requester) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketEventAIAgentAuthorResponse?>.Default.Equals(AiAgent, other.AiAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketEventHumanAgentAuthorResponse?>.Default.Equals(HumanAgent, other.HumanAgent)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Author12 obj1, Author12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Author12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Author12 obj1, Author12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Author12 o && Equals(o);
        }
    }
}
