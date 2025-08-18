#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StepsItem : global::System.IEquatable<StepsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowToolEdgeStepModel? Edge { get; init; }
#else
        public global::ElevenLabs.WorkflowToolEdgeStepModel? Edge { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Edge))]
#endif
        public bool IsEdge => Edge != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem(global::ElevenLabs.WorkflowToolEdgeStepModel value) => new StepsItem((global::ElevenLabs.WorkflowToolEdgeStepModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowToolEdgeStepModel?(StepsItem @this) => @this.Edge;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem(global::ElevenLabs.WorkflowToolEdgeStepModel? value)
        {
            Edge = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowToolNestedToolsStepModelInput? NestedTools { get; init; }
#else
        public global::ElevenLabs.WorkflowToolNestedToolsStepModelInput? NestedTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NestedTools))]
#endif
        public bool IsNestedTools => NestedTools != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem(global::ElevenLabs.WorkflowToolNestedToolsStepModelInput value) => new StepsItem((global::ElevenLabs.WorkflowToolNestedToolsStepModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowToolNestedToolsStepModelInput?(StepsItem @this) => @this.NestedTools;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem(global::ElevenLabs.WorkflowToolNestedToolsStepModelInput? value)
        {
            NestedTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? MaxIterationsExceeded { get; init; }
#else
        public global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? MaxIterationsExceeded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxIterationsExceeded))]
#endif
        public bool IsMaxIterationsExceeded => MaxIterationsExceeded != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel value) => new StepsItem((global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel?(StepsItem @this) => @this.MaxIterationsExceeded;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? value)
        {
            MaxIterationsExceeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StepsItem(
            global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType? type,
            global::ElevenLabs.WorkflowToolEdgeStepModel? edge,
            global::ElevenLabs.WorkflowToolNestedToolsStepModelInput? nestedTools,
            global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? maxIterationsExceeded
            )
        {
            Type = type;

            Edge = edge;
            NestedTools = nestedTools;
            MaxIterationsExceeded = maxIterationsExceeded;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MaxIterationsExceeded as object ??
            NestedTools as object ??
            Edge as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Edge?.ToString() ??
            NestedTools?.ToString() ??
            MaxIterationsExceeded?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEdge && !IsNestedTools && !IsMaxIterationsExceeded || !IsEdge && IsNestedTools && !IsMaxIterationsExceeded || !IsEdge && !IsNestedTools && IsMaxIterationsExceeded;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.WorkflowToolEdgeStepModel?, TResult>? edge = null,
            global::System.Func<global::ElevenLabs.WorkflowToolNestedToolsStepModelInput?, TResult>? nestedTools = null,
            global::System.Func<global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel?, TResult>? maxIterationsExceeded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEdge && edge != null)
            {
                return edge(Edge!);
            }
            else if (IsNestedTools && nestedTools != null)
            {
                return nestedTools(NestedTools!);
            }
            else if (IsMaxIterationsExceeded && maxIterationsExceeded != null)
            {
                return maxIterationsExceeded(MaxIterationsExceeded!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.WorkflowToolEdgeStepModel?>? edge = null,
            global::System.Action<global::ElevenLabs.WorkflowToolNestedToolsStepModelInput?>? nestedTools = null,
            global::System.Action<global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel?>? maxIterationsExceeded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEdge)
            {
                edge?.Invoke(Edge!);
            }
            else if (IsNestedTools)
            {
                nestedTools?.Invoke(NestedTools!);
            }
            else if (IsMaxIterationsExceeded)
            {
                maxIterationsExceeded?.Invoke(MaxIterationsExceeded!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Edge,
                typeof(global::ElevenLabs.WorkflowToolEdgeStepModel),
                NestedTools,
                typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelInput),
                MaxIterationsExceeded,
                typeof(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel),
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
        public bool Equals(StepsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowToolEdgeStepModel?>.Default.Equals(Edge, other.Edge) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowToolNestedToolsStepModelInput?>.Default.Equals(NestedTools, other.NestedTools) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel?>.Default.Equals(MaxIterationsExceeded, other.MaxIterationsExceeded) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StepsItem obj1, StepsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StepsItem obj1, StepsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepsItem o && Equals(o);
        }
    }
}
