#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Nodes : global::System.IEquatable<Nodes>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType? Type { get; }

        /// <summary>
        /// Entry point of the workflow.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowStartNodeModelInput? Start { get; init; }
#else
        public global::ElevenLabs.WorkflowStartNodeModelInput? Start { get; }
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
            out global::ElevenLabs.WorkflowStartNodeModelInput? value)
        {
            value = Start;
            return IsStart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartNodeModelInput PickStart() => Start is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Start' but the value was {ToString()}.");

        /// <summary>
        /// Terminates the conversation upon reaching this node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowEndNodeModelInput? End { get; init; }
#else
        public global::ElevenLabs.WorkflowEndNodeModelInput? End { get; }
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
            out global::ElevenLabs.WorkflowEndNodeModelInput? value)
        {
            value = End;
            return IsEnd;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowEndNodeModelInput PickEnd() => End is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'End' but the value was {ToString()}.");

        /// <summary>
        /// Transfers the conversation to a phone number.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInput? PhoneNumber { get; init; }
#else
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInput? PhoneNumber { get; }
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
            out global::ElevenLabs.WorkflowPhoneNumberNodeModelInput? value)
        {
            value = PhoneNumber;
            return IsPhoneNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInput PickPhoneNumber() => PhoneNumber is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PhoneNumber' but the value was {ToString()}.");

        /// <summary>
        /// A subagent conducting the conversation until one of the exit conditions is met. Each subagent can override the base settings, changing the prompt, knowledge base, and more.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelInput? OverrideAgent { get; init; }
#else
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelInput? OverrideAgent { get; }
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
            out global::ElevenLabs.WorkflowOverrideAgentNodeModelInput? value)
        {
            value = OverrideAgent;
            return IsOverrideAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowOverrideAgentNodeModelInput PickOverrideAgent() => OverrideAgent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OverrideAgent' but the value was {ToString()}.");

        /// <summary>
        /// Transfer the conversation to a standalone agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput? StandaloneAgent { get; init; }
#else
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput? StandaloneAgent { get; }
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
            out global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput? value)
        {
            value = StandaloneAgent;
            return IsStandaloneAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput PickStandaloneAgent() => StandaloneAgent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StandaloneAgent' but the value was {ToString()}.");

        /// <summary>
        /// Say a predefined literal message or generate a single LLM response according to a given prompt.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowSayNodeModelInput? Say { get; init; }
#else
        public global::ElevenLabs.WorkflowSayNodeModelInput? Say { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Say))]
#endif
        public bool IsSay => Say != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSay(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WorkflowSayNodeModelInput? value)
        {
            value = Say;
            return IsSay;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowSayNodeModelInput PickSay() => Say is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Say' but the value was {ToString()}.");

        /// <summary>
        /// Executes one or more tools in parallel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowToolNodeModelInput? Tool { get; init; }
#else
        public global::ElevenLabs.WorkflowToolNodeModelInput? Tool { get; }
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
            out global::ElevenLabs.WorkflowToolNodeModelInput? value)
        {
            value = Tool;
            return IsTool;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowToolNodeModelInput PickTool() => Tool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tool' but the value was {ToString()}.");

        /// <summary>
        /// Applies updates to the conversation state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowUpdateStateNodeModelInput? UpdateState { get; init; }
#else
        public global::ElevenLabs.WorkflowUpdateStateNodeModelInput? UpdateState { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateState))]
#endif
        public bool IsUpdateState => UpdateState != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateState(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WorkflowUpdateStateNodeModelInput? value)
        {
            value = UpdateState;
            return IsUpdateState;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowUpdateStateNodeModelInput PickUpdateState() => UpdateState is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateState' but the value was {ToString()}.");

        /// <summary>
        /// Starts a procedure, then continues along its outgoing edges.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowStartProcedureNodeModelInput? StartProcedure { get; init; }
#else
        public global::ElevenLabs.WorkflowStartProcedureNodeModelInput? StartProcedure { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StartProcedure))]
#endif
        public bool IsStartProcedure => StartProcedure != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStartProcedure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WorkflowStartProcedureNodeModelInput? value)
        {
            value = StartProcedure;
            return IsStartProcedure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowStartProcedureNodeModelInput PickStartProcedure() => StartProcedure is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StartProcedure' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Nodes(global::ElevenLabs.WorkflowStartNodeModelInput value) => new Nodes((global::ElevenLabs.WorkflowStartNodeModelInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowStartNodeModelInput?(Nodes @this) => @this.Start;

        /// <summary>
        ///
        /// </summary>
        public Nodes(global::ElevenLabs.WorkflowStartNodeModelInput? value)
        {
            Start = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Nodes FromStart(global::ElevenLabs.WorkflowStartNodeModelInput? value) => new Nodes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Nodes(global::ElevenLabs.WorkflowEndNodeModelInput value) => new Nodes((global::ElevenLabs.WorkflowEndNodeModelInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowEndNodeModelInput?(Nodes @this) => @this.End;

        /// <summary>
        ///
        /// </summary>
        public Nodes(global::ElevenLabs.WorkflowEndNodeModelInput? value)
        {
            End = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Nodes FromEnd(global::ElevenLabs.WorkflowEndNodeModelInput? value) => new Nodes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Nodes(global::ElevenLabs.WorkflowPhoneNumberNodeModelInput value) => new Nodes((global::ElevenLabs.WorkflowPhoneNumberNodeModelInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowPhoneNumberNodeModelInput?(Nodes @this) => @this.PhoneNumber;

        /// <summary>
        ///
        /// </summary>
        public Nodes(global::ElevenLabs.WorkflowPhoneNumberNodeModelInput? value)
        {
            PhoneNumber = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Nodes FromPhoneNumber(global::ElevenLabs.WorkflowPhoneNumberNodeModelInput? value) => new Nodes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Nodes(global::ElevenLabs.WorkflowOverrideAgentNodeModelInput value) => new Nodes((global::ElevenLabs.WorkflowOverrideAgentNodeModelInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowOverrideAgentNodeModelInput?(Nodes @this) => @this.OverrideAgent;

        /// <summary>
        ///
        /// </summary>
        public Nodes(global::ElevenLabs.WorkflowOverrideAgentNodeModelInput? value)
        {
            OverrideAgent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Nodes FromOverrideAgent(global::ElevenLabs.WorkflowOverrideAgentNodeModelInput? value) => new Nodes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Nodes(global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput value) => new Nodes((global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput?(Nodes @this) => @this.StandaloneAgent;

        /// <summary>
        ///
        /// </summary>
        public Nodes(global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput? value)
        {
            StandaloneAgent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Nodes FromStandaloneAgent(global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput? value) => new Nodes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Nodes(global::ElevenLabs.WorkflowSayNodeModelInput value) => new Nodes((global::ElevenLabs.WorkflowSayNodeModelInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowSayNodeModelInput?(Nodes @this) => @this.Say;

        /// <summary>
        ///
        /// </summary>
        public Nodes(global::ElevenLabs.WorkflowSayNodeModelInput? value)
        {
            Say = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Nodes FromSay(global::ElevenLabs.WorkflowSayNodeModelInput? value) => new Nodes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Nodes(global::ElevenLabs.WorkflowToolNodeModelInput value) => new Nodes((global::ElevenLabs.WorkflowToolNodeModelInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowToolNodeModelInput?(Nodes @this) => @this.Tool;

        /// <summary>
        ///
        /// </summary>
        public Nodes(global::ElevenLabs.WorkflowToolNodeModelInput? value)
        {
            Tool = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Nodes FromTool(global::ElevenLabs.WorkflowToolNodeModelInput? value) => new Nodes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Nodes(global::ElevenLabs.WorkflowUpdateStateNodeModelInput value) => new Nodes((global::ElevenLabs.WorkflowUpdateStateNodeModelInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowUpdateStateNodeModelInput?(Nodes @this) => @this.UpdateState;

        /// <summary>
        ///
        /// </summary>
        public Nodes(global::ElevenLabs.WorkflowUpdateStateNodeModelInput? value)
        {
            UpdateState = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Nodes FromUpdateState(global::ElevenLabs.WorkflowUpdateStateNodeModelInput? value) => new Nodes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Nodes(global::ElevenLabs.WorkflowStartProcedureNodeModelInput value) => new Nodes((global::ElevenLabs.WorkflowStartProcedureNodeModelInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowStartProcedureNodeModelInput?(Nodes @this) => @this.StartProcedure;

        /// <summary>
        ///
        /// </summary>
        public Nodes(global::ElevenLabs.WorkflowStartProcedureNodeModelInput? value)
        {
            StartProcedure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Nodes FromStartProcedure(global::ElevenLabs.WorkflowStartProcedureNodeModelInput? value) => new Nodes(value);

        /// <summary>
        ///
        /// </summary>
        public Nodes(
            global::ElevenLabs.AgentWorkflowRequestModelNodesDiscriminatorType? type,
            global::ElevenLabs.WorkflowStartNodeModelInput? start,
            global::ElevenLabs.WorkflowEndNodeModelInput? end,
            global::ElevenLabs.WorkflowPhoneNumberNodeModelInput? phoneNumber,
            global::ElevenLabs.WorkflowOverrideAgentNodeModelInput? overrideAgent,
            global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput? standaloneAgent,
            global::ElevenLabs.WorkflowSayNodeModelInput? say,
            global::ElevenLabs.WorkflowToolNodeModelInput? tool,
            global::ElevenLabs.WorkflowUpdateStateNodeModelInput? updateState,
            global::ElevenLabs.WorkflowStartProcedureNodeModelInput? startProcedure
            )
        {
            Type = type;

            Start = start;
            End = end;
            PhoneNumber = phoneNumber;
            OverrideAgent = overrideAgent;
            StandaloneAgent = standaloneAgent;
            Say = say;
            Tool = tool;
            UpdateState = updateState;
            StartProcedure = startProcedure;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StartProcedure as object ??
            UpdateState as object ??
            Tool as object ??
            Say as object ??
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
            Say?.ToString() ??
            Tool?.ToString() ??
            UpdateState?.ToString() ??
            StartProcedure?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStart && !IsEnd && !IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && !IsSay && !IsTool && !IsUpdateState && !IsStartProcedure || !IsStart && IsEnd && !IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && !IsSay && !IsTool && !IsUpdateState && !IsStartProcedure || !IsStart && !IsEnd && IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && !IsSay && !IsTool && !IsUpdateState && !IsStartProcedure || !IsStart && !IsEnd && !IsPhoneNumber && IsOverrideAgent && !IsStandaloneAgent && !IsSay && !IsTool && !IsUpdateState && !IsStartProcedure || !IsStart && !IsEnd && !IsPhoneNumber && !IsOverrideAgent && IsStandaloneAgent && !IsSay && !IsTool && !IsUpdateState && !IsStartProcedure || !IsStart && !IsEnd && !IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && IsSay && !IsTool && !IsUpdateState && !IsStartProcedure || !IsStart && !IsEnd && !IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && !IsSay && IsTool && !IsUpdateState && !IsStartProcedure || !IsStart && !IsEnd && !IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && !IsSay && !IsTool && IsUpdateState && !IsStartProcedure || !IsStart && !IsEnd && !IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && !IsSay && !IsTool && !IsUpdateState && IsStartProcedure;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.WorkflowStartNodeModelInput, TResult>? start = null,
            global::System.Func<global::ElevenLabs.WorkflowEndNodeModelInput, TResult>? end = null,
            global::System.Func<global::ElevenLabs.WorkflowPhoneNumberNodeModelInput, TResult>? phoneNumber = null,
            global::System.Func<global::ElevenLabs.WorkflowOverrideAgentNodeModelInput, TResult>? overrideAgent = null,
            global::System.Func<global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput, TResult>? standaloneAgent = null,
            global::System.Func<global::ElevenLabs.WorkflowSayNodeModelInput, TResult>? say = null,
            global::System.Func<global::ElevenLabs.WorkflowToolNodeModelInput, TResult>? tool = null,
            global::System.Func<global::ElevenLabs.WorkflowUpdateStateNodeModelInput, TResult>? updateState = null,
            global::System.Func<global::ElevenLabs.WorkflowStartProcedureNodeModelInput, TResult>? startProcedure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Start is { } __value0 && start != null)
            {
                return start(__value0);
            }
            else if (End is { } __value1 && end != null)
            {
                return end(__value1);
            }
            else if (PhoneNumber is { } __value2 && phoneNumber != null)
            {
                return phoneNumber(__value2);
            }
            else if (OverrideAgent is { } __value3 && overrideAgent != null)
            {
                return overrideAgent(__value3);
            }
            else if (StandaloneAgent is { } __value4 && standaloneAgent != null)
            {
                return standaloneAgent(__value4);
            }
            else if (Say is { } __value5 && say != null)
            {
                return say(__value5);
            }
            else if (Tool is { } __value6 && tool != null)
            {
                return tool(__value6);
            }
            else if (UpdateState is { } __value7 && updateState != null)
            {
                return updateState(__value7);
            }
            else if (StartProcedure is { } __value8 && startProcedure != null)
            {
                return startProcedure(__value8);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.WorkflowStartNodeModelInput>? start = null,

            global::System.Action<global::ElevenLabs.WorkflowEndNodeModelInput>? end = null,

            global::System.Action<global::ElevenLabs.WorkflowPhoneNumberNodeModelInput>? phoneNumber = null,

            global::System.Action<global::ElevenLabs.WorkflowOverrideAgentNodeModelInput>? overrideAgent = null,

            global::System.Action<global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput>? standaloneAgent = null,

            global::System.Action<global::ElevenLabs.WorkflowSayNodeModelInput>? say = null,

            global::System.Action<global::ElevenLabs.WorkflowToolNodeModelInput>? tool = null,

            global::System.Action<global::ElevenLabs.WorkflowUpdateStateNodeModelInput>? updateState = null,

            global::System.Action<global::ElevenLabs.WorkflowStartProcedureNodeModelInput>? startProcedure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Start is { } __value0)
            {
                start?.Invoke(__value0);
            }
            else if (End is { } __value1)
            {
                end?.Invoke(__value1);
            }
            else if (PhoneNumber is { } __value2)
            {
                phoneNumber?.Invoke(__value2);
            }
            else if (OverrideAgent is { } __value3)
            {
                overrideAgent?.Invoke(__value3);
            }
            else if (StandaloneAgent is { } __value4)
            {
                standaloneAgent?.Invoke(__value4);
            }
            else if (Say is { } __value5)
            {
                say?.Invoke(__value5);
            }
            else if (Tool is { } __value6)
            {
                tool?.Invoke(__value6);
            }
            else if (UpdateState is { } __value7)
            {
                updateState?.Invoke(__value7);
            }
            else if (StartProcedure is { } __value8)
            {
                startProcedure?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.WorkflowStartNodeModelInput>? start = null,
            global::System.Action<global::ElevenLabs.WorkflowEndNodeModelInput>? end = null,
            global::System.Action<global::ElevenLabs.WorkflowPhoneNumberNodeModelInput>? phoneNumber = null,
            global::System.Action<global::ElevenLabs.WorkflowOverrideAgentNodeModelInput>? overrideAgent = null,
            global::System.Action<global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput>? standaloneAgent = null,
            global::System.Action<global::ElevenLabs.WorkflowSayNodeModelInput>? say = null,
            global::System.Action<global::ElevenLabs.WorkflowToolNodeModelInput>? tool = null,
            global::System.Action<global::ElevenLabs.WorkflowUpdateStateNodeModelInput>? updateState = null,
            global::System.Action<global::ElevenLabs.WorkflowStartProcedureNodeModelInput>? startProcedure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Start is { } __value0)
            {
                start?.Invoke(__value0);
            }
            else if (End is { } __value1)
            {
                end?.Invoke(__value1);
            }
            else if (PhoneNumber is { } __value2)
            {
                phoneNumber?.Invoke(__value2);
            }
            else if (OverrideAgent is { } __value3)
            {
                overrideAgent?.Invoke(__value3);
            }
            else if (StandaloneAgent is { } __value4)
            {
                standaloneAgent?.Invoke(__value4);
            }
            else if (Say is { } __value5)
            {
                say?.Invoke(__value5);
            }
            else if (Tool is { } __value6)
            {
                tool?.Invoke(__value6);
            }
            else if (UpdateState is { } __value7)
            {
                updateState?.Invoke(__value7);
            }
            else if (StartProcedure is { } __value8)
            {
                startProcedure?.Invoke(__value8);
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
                typeof(global::ElevenLabs.WorkflowStartNodeModelInput),
                End,
                typeof(global::ElevenLabs.WorkflowEndNodeModelInput),
                PhoneNumber,
                typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelInput),
                OverrideAgent,
                typeof(global::ElevenLabs.WorkflowOverrideAgentNodeModelInput),
                StandaloneAgent,
                typeof(global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput),
                Say,
                typeof(global::ElevenLabs.WorkflowSayNodeModelInput),
                Tool,
                typeof(global::ElevenLabs.WorkflowToolNodeModelInput),
                UpdateState,
                typeof(global::ElevenLabs.WorkflowUpdateStateNodeModelInput),
                StartProcedure,
                typeof(global::ElevenLabs.WorkflowStartProcedureNodeModelInput),
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
        public bool Equals(Nodes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowStartNodeModelInput?>.Default.Equals(Start, other.Start) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowEndNodeModelInput?>.Default.Equals(End, other.End) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowPhoneNumberNodeModelInput?>.Default.Equals(PhoneNumber, other.PhoneNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowOverrideAgentNodeModelInput?>.Default.Equals(OverrideAgent, other.OverrideAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowStandaloneAgentNodeModelInput?>.Default.Equals(StandaloneAgent, other.StandaloneAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowSayNodeModelInput?>.Default.Equals(Say, other.Say) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowToolNodeModelInput?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowUpdateStateNodeModelInput?>.Default.Equals(UpdateState, other.UpdateState) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowStartProcedureNodeModelInput?>.Default.Equals(StartProcedure, other.StartProcedure)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Nodes obj1, Nodes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Nodes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Nodes obj1, Nodes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Nodes o && Equals(o);
        }
    }
}
