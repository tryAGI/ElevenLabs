#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AssigneeVariant13 : global::System.IEquatable<AssigneeVariant13>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UpdateTicketRequestAssigneeVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketAIAgentAssigneeRequest? AiAgent { get; init; }
#else
        public global::ElevenLabs.TicketAIAgentAssigneeRequest? AiAgent { get; }
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
            out global::ElevenLabs.TicketAIAgentAssigneeRequest? value)
        {
            value = AiAgent;
            return IsAiAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAIAgentAssigneeRequest PickAiAgent() => AiAgent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AiAgent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketHumanAgentAssigneeRequest? HumanAgent { get; init; }
#else
        public global::ElevenLabs.TicketHumanAgentAssigneeRequest? HumanAgent { get; }
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
            out global::ElevenLabs.TicketHumanAgentAssigneeRequest? value)
        {
            value = HumanAgent;
            return IsHumanAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketHumanAgentAssigneeRequest PickHumanAgent() => HumanAgent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HumanAgent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AssigneeVariant13(global::ElevenLabs.TicketAIAgentAssigneeRequest value) => new AssigneeVariant13((global::ElevenLabs.TicketAIAgentAssigneeRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketAIAgentAssigneeRequest?(AssigneeVariant13 @this) => @this.AiAgent;

        /// <summary>
        ///
        /// </summary>
        public AssigneeVariant13(global::ElevenLabs.TicketAIAgentAssigneeRequest? value)
        {
            AiAgent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AssigneeVariant13 FromAiAgent(global::ElevenLabs.TicketAIAgentAssigneeRequest? value) => new AssigneeVariant13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AssigneeVariant13(global::ElevenLabs.TicketHumanAgentAssigneeRequest value) => new AssigneeVariant13((global::ElevenLabs.TicketHumanAgentAssigneeRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketHumanAgentAssigneeRequest?(AssigneeVariant13 @this) => @this.HumanAgent;

        /// <summary>
        ///
        /// </summary>
        public AssigneeVariant13(global::ElevenLabs.TicketHumanAgentAssigneeRequest? value)
        {
            HumanAgent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AssigneeVariant13 FromHumanAgent(global::ElevenLabs.TicketHumanAgentAssigneeRequest? value) => new AssigneeVariant13(value);

        /// <summary>
        ///
        /// </summary>
        public AssigneeVariant13(
            global::ElevenLabs.UpdateTicketRequestAssigneeVariant1DiscriminatorType? type,
            global::ElevenLabs.TicketAIAgentAssigneeRequest? aiAgent,
            global::ElevenLabs.TicketHumanAgentAssigneeRequest? humanAgent
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
            global::System.Func<global::ElevenLabs.TicketAIAgentAssigneeRequest, TResult>? aiAgent = null,
            global::System.Func<global::ElevenLabs.TicketHumanAgentAssigneeRequest, TResult>? humanAgent = null,
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
            global::System.Action<global::ElevenLabs.TicketAIAgentAssigneeRequest>? aiAgent = null,

            global::System.Action<global::ElevenLabs.TicketHumanAgentAssigneeRequest>? humanAgent = null,
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
            global::System.Action<global::ElevenLabs.TicketAIAgentAssigneeRequest>? aiAgent = null,
            global::System.Action<global::ElevenLabs.TicketHumanAgentAssigneeRequest>? humanAgent = null,
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
                typeof(global::ElevenLabs.TicketAIAgentAssigneeRequest),
                HumanAgent,
                typeof(global::ElevenLabs.TicketHumanAgentAssigneeRequest),
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
        public bool Equals(AssigneeVariant13 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketAIAgentAssigneeRequest?>.Default.Equals(AiAgent, other.AiAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketHumanAgentAssigneeRequest?>.Default.Equals(HumanAgent, other.HumanAgent)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AssigneeVariant13 obj1, AssigneeVariant13 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AssigneeVariant13>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AssigneeVariant13 obj1, AssigneeVariant13 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AssigneeVariant13 o && Equals(o);
        }
    }
}
