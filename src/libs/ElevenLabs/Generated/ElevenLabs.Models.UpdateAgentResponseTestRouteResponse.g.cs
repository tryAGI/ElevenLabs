#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateAgentResponseTestRouteResponse : global::System.IEquatable<UpdateAgentResponseTestRouteResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetResponseUnitTestResponseModel? Llm { get; init; }
#else
        public global::ElevenLabs.GetResponseUnitTestResponseModel? Llm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Llm))]
#endif
        public bool IsLlm => Llm != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLlm(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetResponseUnitTestResponseModel? value)
        {
            value = Llm;
            return IsLlm;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GetResponseUnitTestResponseModel PickLlm() => IsLlm
            ? Llm!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Llm' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetToolCallUnitTestResponseModel? Tool { get; init; }
#else
        public global::ElevenLabs.GetToolCallUnitTestResponseModel? Tool { get; }
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
            out global::ElevenLabs.GetToolCallUnitTestResponseModel? value)
        {
            value = Tool;
            return IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GetToolCallUnitTestResponseModel PickTool() => IsTool
            ? Tool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tool' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetSimulationTestResponseModel? Simulation { get; init; }
#else
        public global::ElevenLabs.GetSimulationTestResponseModel? Simulation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Simulation))]
#endif
        public bool IsSimulation => Simulation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSimulation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetSimulationTestResponseModel? value)
        {
            value = Simulation;
            return IsSimulation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GetSimulationTestResponseModel PickSimulation() => IsSimulation
            ? Simulation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Simulation' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateAgentResponseTestRouteResponse(global::ElevenLabs.GetResponseUnitTestResponseModel value) => new UpdateAgentResponseTestRouteResponse((global::ElevenLabs.GetResponseUnitTestResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetResponseUnitTestResponseModel?(UpdateAgentResponseTestRouteResponse @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public UpdateAgentResponseTestRouteResponse(global::ElevenLabs.GetResponseUnitTestResponseModel? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateAgentResponseTestRouteResponse FromLlm(global::ElevenLabs.GetResponseUnitTestResponseModel? value) => new UpdateAgentResponseTestRouteResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateAgentResponseTestRouteResponse(global::ElevenLabs.GetToolCallUnitTestResponseModel value) => new UpdateAgentResponseTestRouteResponse((global::ElevenLabs.GetToolCallUnitTestResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetToolCallUnitTestResponseModel?(UpdateAgentResponseTestRouteResponse @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public UpdateAgentResponseTestRouteResponse(global::ElevenLabs.GetToolCallUnitTestResponseModel? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateAgentResponseTestRouteResponse FromTool(global::ElevenLabs.GetToolCallUnitTestResponseModel? value) => new UpdateAgentResponseTestRouteResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateAgentResponseTestRouteResponse(global::ElevenLabs.GetSimulationTestResponseModel value) => new UpdateAgentResponseTestRouteResponse((global::ElevenLabs.GetSimulationTestResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetSimulationTestResponseModel?(UpdateAgentResponseTestRouteResponse @this) => @this.Simulation;

        /// <summary>
        /// 
        /// </summary>
        public UpdateAgentResponseTestRouteResponse(global::ElevenLabs.GetSimulationTestResponseModel? value)
        {
            Simulation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateAgentResponseTestRouteResponse FromSimulation(global::ElevenLabs.GetSimulationTestResponseModel? value) => new UpdateAgentResponseTestRouteResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public UpdateAgentResponseTestRouteResponse(
            global::ElevenLabs.UpdateAgentResponseTestRouteResponseDiscriminatorType? type,
            global::ElevenLabs.GetResponseUnitTestResponseModel? llm,
            global::ElevenLabs.GetToolCallUnitTestResponseModel? tool,
            global::ElevenLabs.GetSimulationTestResponseModel? simulation
            )
        {
            Type = type;

            Llm = llm;
            Tool = tool;
            Simulation = simulation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Simulation as object ??
            Tool as object ??
            Llm as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Llm?.ToString() ??
            Tool?.ToString() ??
            Simulation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLlm && !IsTool && !IsSimulation || !IsLlm && IsTool && !IsSimulation || !IsLlm && !IsTool && IsSimulation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.GetResponseUnitTestResponseModel, TResult>? llm = null,
            global::System.Func<global::ElevenLabs.GetToolCallUnitTestResponseModel, TResult>? tool = null,
            global::System.Func<global::ElevenLabs.GetSimulationTestResponseModel, TResult>? simulation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLlm && llm != null)
            {
                return llm(Llm!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsSimulation && simulation != null)
            {
                return simulation(Simulation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.GetResponseUnitTestResponseModel>? llm = null,

            global::System.Action<global::ElevenLabs.GetToolCallUnitTestResponseModel>? tool = null,

            global::System.Action<global::ElevenLabs.GetSimulationTestResponseModel>? simulation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsSimulation)
            {
                simulation?.Invoke(Simulation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.GetResponseUnitTestResponseModel>? llm = null,
            global::System.Action<global::ElevenLabs.GetToolCallUnitTestResponseModel>? tool = null,
            global::System.Action<global::ElevenLabs.GetSimulationTestResponseModel>? simulation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsSimulation)
            {
                simulation?.Invoke(Simulation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Llm,
                typeof(global::ElevenLabs.GetResponseUnitTestResponseModel),
                Tool,
                typeof(global::ElevenLabs.GetToolCallUnitTestResponseModel),
                Simulation,
                typeof(global::ElevenLabs.GetSimulationTestResponseModel),
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
        public bool Equals(UpdateAgentResponseTestRouteResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetResponseUnitTestResponseModel?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetToolCallUnitTestResponseModel?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetSimulationTestResponseModel?>.Default.Equals(Simulation, other.Simulation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateAgentResponseTestRouteResponse obj1, UpdateAgentResponseTestRouteResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateAgentResponseTestRouteResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateAgentResponseTestRouteResponse obj1, UpdateAgentResponseTestRouteResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateAgentResponseTestRouteResponse o && Equals(o);
        }
    }
}
