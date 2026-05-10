#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BackwardConditionVariant1 : global::System.IEquatable<BackwardConditionVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Condition that is always true.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowUnconditionalModelInput? Unconditional { get; init; }
#else
        public global::ElevenLabs.WorkflowUnconditionalModelInput? Unconditional { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unconditional))]
#endif
        public bool IsUnconditional => Unconditional != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnconditional(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WorkflowUnconditionalModelInput? value)
        {
            value = Unconditional;
            return IsUnconditional;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WorkflowUnconditionalModelInput PickUnconditional() => IsUnconditional
            ? Unconditional!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unconditional' but the value was {ToString()}.");

        /// <summary>
        /// Condition described using human language and evaluated by an LLM.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowLLMConditionModelInput? Llm { get; init; }
#else
        public global::ElevenLabs.WorkflowLLMConditionModelInput? Llm { get; }
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
            out global::ElevenLabs.WorkflowLLMConditionModelInput? value)
        {
            value = Llm;
            return IsLlm;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WorkflowLLMConditionModelInput PickLlm() => IsLlm
            ? Llm!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Llm' but the value was {ToString()}.");

        /// <summary>
        /// Condition based on the result of the last executed tool dispatch node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowResultConditionModelInput? Result { get; init; }
#else
        public global::ElevenLabs.WorkflowResultConditionModelInput? Result { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Result))]
#endif
        public bool IsResult => Result != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WorkflowResultConditionModelInput? value)
        {
            value = Result;
            return IsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WorkflowResultConditionModelInput PickResult() => IsResult
            ? Result!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Result' but the value was {ToString()}.");

        /// <summary>
        /// Condition described using a deterministic expression.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WorkflowExpressionConditionModelInput? Expression { get; init; }
#else
        public global::ElevenLabs.WorkflowExpressionConditionModelInput? Expression { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Expression))]
#endif
        public bool IsExpression => Expression != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickExpression(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WorkflowExpressionConditionModelInput? value)
        {
            value = Expression;
            return IsExpression;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WorkflowExpressionConditionModelInput PickExpression() => IsExpression
            ? Expression!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Expression' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BackwardConditionVariant1(global::ElevenLabs.WorkflowUnconditionalModelInput value) => new BackwardConditionVariant1((global::ElevenLabs.WorkflowUnconditionalModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowUnconditionalModelInput?(BackwardConditionVariant1 @this) => @this.Unconditional;

        /// <summary>
        /// 
        /// </summary>
        public BackwardConditionVariant1(global::ElevenLabs.WorkflowUnconditionalModelInput? value)
        {
            Unconditional = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BackwardConditionVariant1 FromUnconditional(global::ElevenLabs.WorkflowUnconditionalModelInput? value) => new BackwardConditionVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BackwardConditionVariant1(global::ElevenLabs.WorkflowLLMConditionModelInput value) => new BackwardConditionVariant1((global::ElevenLabs.WorkflowLLMConditionModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowLLMConditionModelInput?(BackwardConditionVariant1 @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public BackwardConditionVariant1(global::ElevenLabs.WorkflowLLMConditionModelInput? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BackwardConditionVariant1 FromLlm(global::ElevenLabs.WorkflowLLMConditionModelInput? value) => new BackwardConditionVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BackwardConditionVariant1(global::ElevenLabs.WorkflowResultConditionModelInput value) => new BackwardConditionVariant1((global::ElevenLabs.WorkflowResultConditionModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowResultConditionModelInput?(BackwardConditionVariant1 @this) => @this.Result;

        /// <summary>
        /// 
        /// </summary>
        public BackwardConditionVariant1(global::ElevenLabs.WorkflowResultConditionModelInput? value)
        {
            Result = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BackwardConditionVariant1 FromResult(global::ElevenLabs.WorkflowResultConditionModelInput? value) => new BackwardConditionVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BackwardConditionVariant1(global::ElevenLabs.WorkflowExpressionConditionModelInput value) => new BackwardConditionVariant1((global::ElevenLabs.WorkflowExpressionConditionModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WorkflowExpressionConditionModelInput?(BackwardConditionVariant1 @this) => @this.Expression;

        /// <summary>
        /// 
        /// </summary>
        public BackwardConditionVariant1(global::ElevenLabs.WorkflowExpressionConditionModelInput? value)
        {
            Expression = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BackwardConditionVariant1 FromExpression(global::ElevenLabs.WorkflowExpressionConditionModelInput? value) => new BackwardConditionVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public BackwardConditionVariant1(
            global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType? type,
            global::ElevenLabs.WorkflowUnconditionalModelInput? unconditional,
            global::ElevenLabs.WorkflowLLMConditionModelInput? llm,
            global::ElevenLabs.WorkflowResultConditionModelInput? result,
            global::ElevenLabs.WorkflowExpressionConditionModelInput? expression
            )
        {
            Type = type;

            Unconditional = unconditional;
            Llm = llm;
            Result = result;
            Expression = expression;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Expression as object ??
            Result as object ??
            Llm as object ??
            Unconditional as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Unconditional?.ToString() ??
            Llm?.ToString() ??
            Result?.ToString() ??
            Expression?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnconditional && !IsLlm && !IsResult && !IsExpression || !IsUnconditional && IsLlm && !IsResult && !IsExpression || !IsUnconditional && !IsLlm && IsResult && !IsExpression || !IsUnconditional && !IsLlm && !IsResult && IsExpression;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.WorkflowUnconditionalModelInput, TResult>? unconditional = null,
            global::System.Func<global::ElevenLabs.WorkflowLLMConditionModelInput, TResult>? llm = null,
            global::System.Func<global::ElevenLabs.WorkflowResultConditionModelInput, TResult>? result = null,
            global::System.Func<global::ElevenLabs.WorkflowExpressionConditionModelInput, TResult>? expression = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnconditional && unconditional != null)
            {
                return unconditional(Unconditional!);
            }
            else if (IsLlm && llm != null)
            {
                return llm(Llm!);
            }
            else if (IsResult && result != null)
            {
                return result(Result!);
            }
            else if (IsExpression && expression != null)
            {
                return expression(Expression!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.WorkflowUnconditionalModelInput>? unconditional = null,

            global::System.Action<global::ElevenLabs.WorkflowLLMConditionModelInput>? llm = null,

            global::System.Action<global::ElevenLabs.WorkflowResultConditionModelInput>? result = null,

            global::System.Action<global::ElevenLabs.WorkflowExpressionConditionModelInput>? expression = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnconditional)
            {
                unconditional?.Invoke(Unconditional!);
            }
            else if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
            else if (IsResult)
            {
                result?.Invoke(Result!);
            }
            else if (IsExpression)
            {
                expression?.Invoke(Expression!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.WorkflowUnconditionalModelInput>? unconditional = null,
            global::System.Action<global::ElevenLabs.WorkflowLLMConditionModelInput>? llm = null,
            global::System.Action<global::ElevenLabs.WorkflowResultConditionModelInput>? result = null,
            global::System.Action<global::ElevenLabs.WorkflowExpressionConditionModelInput>? expression = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnconditional)
            {
                unconditional?.Invoke(Unconditional!);
            }
            else if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
            else if (IsResult)
            {
                result?.Invoke(Result!);
            }
            else if (IsExpression)
            {
                expression?.Invoke(Expression!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Unconditional,
                typeof(global::ElevenLabs.WorkflowUnconditionalModelInput),
                Llm,
                typeof(global::ElevenLabs.WorkflowLLMConditionModelInput),
                Result,
                typeof(global::ElevenLabs.WorkflowResultConditionModelInput),
                Expression,
                typeof(global::ElevenLabs.WorkflowExpressionConditionModelInput),
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
        public bool Equals(BackwardConditionVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowUnconditionalModelInput?>.Default.Equals(Unconditional, other.Unconditional) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowLLMConditionModelInput?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowResultConditionModelInput?>.Default.Equals(Result, other.Result) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WorkflowExpressionConditionModelInput?>.Default.Equals(Expression, other.Expression) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BackwardConditionVariant1 obj1, BackwardConditionVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BackwardConditionVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BackwardConditionVariant1 obj1, BackwardConditionVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BackwardConditionVariant1 o && Equals(o);
        }
    }
}
