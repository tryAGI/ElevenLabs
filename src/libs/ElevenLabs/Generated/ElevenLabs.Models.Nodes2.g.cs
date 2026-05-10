#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Nodes2 : global::System.IEquatable<Nodes2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType? Type { get; }

        /// <summary>
        /// Entry point of the workflow.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowStartNodeModelOutput? Start { get; init; }
#else
        public global::ElevenLabs.WorkflowStartNodeModelOutput? Start { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Start))]
#endif
        public bool IsStart => Start != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WorkflowStartNodeModelOutput? value)
        {
            value = Start;
            return IsStart;
        }

        /// <summary>
        /// Terminates the conversation upon reaching this node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowEndNodeModelOutput? End { get; init; }
#else
        public global::ElevenLabs.WorkflowEndNodeModelOutput? End { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(End))]
#endif
        public bool IsEnd => End != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WorkflowEndNodeModelOutput? value)
        {
            value = End;
            return IsEnd;
        }

        /// <summary>
        /// Transfers the conversation to a phone number.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? PhoneNumber { get; init; }
#else
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? PhoneNumber { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PhoneNumber))]
#endif
        public bool IsPhoneNumber => PhoneNumber != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPhoneNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? value)
        {
            value = PhoneNumber;
            return IsPhoneNumber;
        }

        /// <summary>
        /// A subagent conducting the conversation until one of the exit conditions is met. Each subagent can override the base settings, changing the prompt, knowledge base, and more.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? OverrideAgent { get; init; }
#else
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? OverrideAgent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OverrideAgent))]
#endif
        public bool IsOverrideAgent => OverrideAgent != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOverrideAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? value)
        {
            value = OverrideAgent;
            return IsOverrideAgent;
        }

        /// <summary>
        /// Transfer the conversation to a standalone agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? StandaloneAgent { get; init; }
#else
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? StandaloneAgent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StandaloneAgent))]
#endif
        public bool IsStandaloneAgent => StandaloneAgent != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStandaloneAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? value)
        {
            value = StandaloneAgent;
            return IsStandaloneAgent;
        }

        /// <summary>
        /// Executes one or more tools in parallel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowToolNodeModelOutput? Tool { get; init; }
#else
        public global::ElevenLabs.WorkflowToolNodeModelOutput? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WorkflowToolNodeModelOutput? value)
        {
            value = Tool;
            return IsTool;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes2(global::ElevenLabs.WorkflowStartNodeModelOutput value) => new Nodes2((global::ElevenLabs.WorkflowStartNodeModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowStartNodeModelOutput?(Nodes2 @this) => @this.Start;

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(global::ElevenLabs.WorkflowStartNodeModelOutput? value)
        {
            Start = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Nodes2 FromStart(global::ElevenLabs.WorkflowStartNodeModelOutput? value) => new Nodes2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes2(global::ElevenLabs.WorkflowEndNodeModelOutput value) => new Nodes2((global::ElevenLabs.WorkflowEndNodeModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowEndNodeModelOutput?(Nodes2 @this) => @this.End;

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(global::ElevenLabs.WorkflowEndNodeModelOutput? value)
        {
            End = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Nodes2 FromEnd(global::ElevenLabs.WorkflowEndNodeModelOutput? value) => new Nodes2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes2(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput value) => new Nodes2((global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput?(Nodes2 @this) => @this.PhoneNumber;

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? value)
        {
            PhoneNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Nodes2 FromPhoneNumber(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? value) => new Nodes2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes2(global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput value) => new Nodes2((global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput?(Nodes2 @this) => @this.OverrideAgent;

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? value)
        {
            OverrideAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Nodes2 FromOverrideAgent(global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? value) => new Nodes2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes2(global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput value) => new Nodes2((global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput?(Nodes2 @this) => @this.StandaloneAgent;

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? value)
        {
            StandaloneAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Nodes2 FromStandaloneAgent(global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? value) => new Nodes2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes2(global::ElevenLabs.WorkflowToolNodeModelOutput value) => new Nodes2((global::ElevenLabs.WorkflowToolNodeModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowToolNodeModelOutput?(Nodes2 @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(global::ElevenLabs.WorkflowToolNodeModelOutput? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Nodes2 FromTool(global::ElevenLabs.WorkflowToolNodeModelOutput? value) => new Nodes2(value);

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(
            global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType? type,
            global::ElevenLabs.WorkflowStartNodeModelOutput? start,
            global::ElevenLabs.WorkflowEndNodeModelOutput? end,
            global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? phoneNumber,
            global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? overrideAgent,
            global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? standaloneAgent,
            global::ElevenLabs.WorkflowToolNodeModelOutput? tool
            )
        {
            Type = type;

            Start = start;
            End = end;
            PhoneNumber = phoneNumber;
            OverrideAgent = overrideAgent;
            StandaloneAgent = standaloneAgent;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            StandaloneAgent as object ??
            OverrideAgent as object ??
            PhoneNumber as object ??
            End as object ??
            Start as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Start?.ToString() ??
            End?.ToString() ??
            PhoneNumber?.ToString() ??
            OverrideAgent?.ToString() ??
            StandaloneAgent?.ToString() ??
            Tool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStart && !IsEnd && !IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && !IsTool || !IsStart && IsEnd && !IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && !IsTool || !IsStart && !IsEnd && IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && !IsTool || !IsStart && !IsEnd && !IsPhoneNumber && IsOverrideAgent && !IsStandaloneAgent && !IsTool || !IsStart && !IsEnd && !IsPhoneNumber && !IsOverrideAgent && IsStandaloneAgent && !IsTool || !IsStart && !IsEnd && !IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.WorkflowStartNodeModelOutput, TResult>? start = null,
            global::System.Func<global::ElevenLabs.WorkflowEndNodeModelOutput, TResult>? end = null,
            global::System.Func<global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput, TResult>? phoneNumber = null,
            global::System.Func<global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput, TResult>? overrideAgent = null,
            global::System.Func<global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput, TResult>? standaloneAgent = null,
            global::System.Func<global::ElevenLabs.WorkflowToolNodeModelOutput, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStart && start != null)
            {
                return start(Start!);
            }
            else if (IsEnd && end != null)
            {
                return end(End!);
            }
            else if (IsPhoneNumber && phoneNumber != null)
            {
                return phoneNumber(PhoneNumber!);
            }
            else if (IsOverrideAgent && overrideAgent != null)
            {
                return overrideAgent(OverrideAgent!);
            }
            else if (IsStandaloneAgent && standaloneAgent != null)
            {
                return standaloneAgent(StandaloneAgent!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.WorkflowStartNodeModelOutput>? start = null,

            global::System.Action<global::ElevenLabs.WorkflowEndNodeModelOutput>? end = null,

            global::System.Action<global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput>? phoneNumber = null,

            global::System.Action<global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput>? overrideAgent = null,

            global::System.Action<global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput>? standaloneAgent = null,

            global::System.Action<global::ElevenLabs.WorkflowToolNodeModelOutput>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStart)
            {
                start?.Invoke(Start!);
            }
            else if (IsEnd)
            {
                end?.Invoke(End!);
            }
            else if (IsPhoneNumber)
            {
                phoneNumber?.Invoke(PhoneNumber!);
            }
            else if (IsOverrideAgent)
            {
                overrideAgent?.Invoke(OverrideAgent!);
            }
            else if (IsStandaloneAgent)
            {
                standaloneAgent?.Invoke(StandaloneAgent!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.WorkflowStartNodeModelOutput>? start = null,
            global::System.Action<global::ElevenLabs.WorkflowEndNodeModelOutput>? end = null,
            global::System.Action<global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput>? phoneNumber = null,
            global::System.Action<global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput>? overrideAgent = null,
            global::System.Action<global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput>? standaloneAgent = null,
            global::System.Action<global::ElevenLabs.WorkflowToolNodeModelOutput>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStart)
            {
                start?.Invoke(Start!);
            }
            else if (IsEnd)
            {
                end?.Invoke(End!);
            }
            else if (IsPhoneNumber)
            {
                phoneNumber?.Invoke(PhoneNumber!);
            }
            else if (IsOverrideAgent)
            {
                overrideAgent?.Invoke(OverrideAgent!);
            }
            else if (IsStandaloneAgent)
            {
                standaloneAgent?.Invoke(StandaloneAgent!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Start,
                typeof(global::ElevenLabs.WorkflowStartNodeModelOutput),
                End,
                typeof(global::ElevenLabs.WorkflowEndNodeModelOutput),
                PhoneNumber,
                typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput),
                OverrideAgent,
                typeof(global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput),
                StandaloneAgent,
                typeof(global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput),
                Tool,
                typeof(global::ElevenLabs.WorkflowToolNodeModelOutput),
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
        public bool Equals(Nodes2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowStartNodeModelOutput?>.Default.Equals(Start, other.Start) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowEndNodeModelOutput?>.Default.Equals(End, other.End) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput?>.Default.Equals(PhoneNumber, other.PhoneNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput?>.Default.Equals(OverrideAgent, other.OverrideAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput?>.Default.Equals(StandaloneAgent, other.StandaloneAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowToolNodeModelOutput?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Nodes2 obj1, Nodes2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Nodes2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Nodes2 obj1, Nodes2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Nodes2 o && Equals(o);
        }
    }
}
