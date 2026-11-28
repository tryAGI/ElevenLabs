#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AfterVariant1 : global::System.IEquatable<AfterVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAssigneeChangedEventResponseAfterVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketAIAgentAssigneeResponse? AiAgent { get; init; }
#else
        public global::ElevenLabs.TicketAIAgentAssigneeResponse? AiAgent { get; }
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
            out global::ElevenLabs.TicketAIAgentAssigneeResponse? value)
        {
            value = AiAgent;
            return IsAiAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAIAgentAssigneeResponse PickAiAgent() => AiAgent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AiAgent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketHumanAgentAssigneeResponse? HumanAgent { get; init; }
#else
        public global::ElevenLabs.TicketHumanAgentAssigneeResponse? HumanAgent { get; }
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
            out global::ElevenLabs.TicketHumanAgentAssigneeResponse? value)
        {
            value = HumanAgent;
            return IsHumanAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketHumanAgentAssigneeResponse PickHumanAgent() => HumanAgent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HumanAgent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AfterVariant1(global::ElevenLabs.TicketAIAgentAssigneeResponse value) => new AfterVariant1((global::ElevenLabs.TicketAIAgentAssigneeResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketAIAgentAssigneeResponse?(AfterVariant1 @this) => @this.AiAgent;

        /// <summary>
        ///
        /// </summary>
        public AfterVariant1(global::ElevenLabs.TicketAIAgentAssigneeResponse? value)
        {
            AiAgent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AfterVariant1 FromAiAgent(global::ElevenLabs.TicketAIAgentAssigneeResponse? value) => new AfterVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AfterVariant1(global::ElevenLabs.TicketHumanAgentAssigneeResponse value) => new AfterVariant1((global::ElevenLabs.TicketHumanAgentAssigneeResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketHumanAgentAssigneeResponse?(AfterVariant1 @this) => @this.HumanAgent;

        /// <summary>
        ///
        /// </summary>
        public AfterVariant1(global::ElevenLabs.TicketHumanAgentAssigneeResponse? value)
        {
            HumanAgent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AfterVariant1 FromHumanAgent(global::ElevenLabs.TicketHumanAgentAssigneeResponse? value) => new AfterVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public AfterVariant1(
            global::ElevenLabs.TicketAssigneeChangedEventResponseAfterVariant1DiscriminatorType? type,
            global::ElevenLabs.TicketAIAgentAssigneeResponse? aiAgent,
            global::ElevenLabs.TicketHumanAgentAssigneeResponse? humanAgent
            )
        {
            Type = type;

            AiAgent = aiAgent;
            HumanAgent = humanAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            HumanAgent as object ??
            AiAgent as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AiAgent?.ToString() ??
            HumanAgent?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAiAgent && !IsHumanAgent || !IsAiAgent && IsHumanAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TicketAIAgentAssigneeResponse, TResult>? aiAgent = null,
            global::System.Func<global::ElevenLabs.TicketHumanAgentAssigneeResponse, TResult>? humanAgent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AiAgent is { } __value0 && aiAgent != null)
            {
                return aiAgent(__value0);
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
            global::System.Action<global::ElevenLabs.TicketAIAgentAssigneeResponse>? aiAgent = null,

            global::System.Action<global::ElevenLabs.TicketHumanAgentAssigneeResponse>? humanAgent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AiAgent is { } __value0)
            {
                aiAgent?.Invoke(__value0);
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
            global::System.Action<global::ElevenLabs.TicketAIAgentAssigneeResponse>? aiAgent = null,
            global::System.Action<global::ElevenLabs.TicketHumanAgentAssigneeResponse>? humanAgent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AiAgent is { } __value0)
            {
                aiAgent?.Invoke(__value0);
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
                AiAgent,
                typeof(global::ElevenLabs.TicketAIAgentAssigneeResponse),
                HumanAgent,
                typeof(global::ElevenLabs.TicketHumanAgentAssigneeResponse),
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
        public bool Equals(AfterVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketAIAgentAssigneeResponse?>.Default.Equals(AiAgent, other.AiAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketHumanAgentAssigneeResponse?>.Default.Equals(HumanAgent, other.HumanAgent)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AfterVariant1 obj1, AfterVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AfterVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AfterVariant1 obj1, AfterVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AfterVariant1 o && Equals(o);
        }
    }
}
