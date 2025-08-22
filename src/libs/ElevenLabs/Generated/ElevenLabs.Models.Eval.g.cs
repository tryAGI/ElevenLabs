#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Eval : global::System.IEquatable<Eval>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.LLMParameterEvaluationStrategy? Llm { get; init; }
#else
        public global::ElevenLabs.LLMParameterEvaluationStrategy? Llm { get; }
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
        public static implicit operator Eval(global::ElevenLabs.LLMParameterEvaluationStrategy value) => new Eval((global::ElevenLabs.LLMParameterEvaluationStrategy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.LLMParameterEvaluationStrategy?(Eval @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public Eval(global::ElevenLabs.LLMParameterEvaluationStrategy? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.RegexParameterEvaluationStrategy? Regex { get; init; }
#else
        public global::ElevenLabs.RegexParameterEvaluationStrategy? Regex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Regex))]
#endif
        public bool IsRegex => Regex != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Eval(global::ElevenLabs.RegexParameterEvaluationStrategy value) => new Eval((global::ElevenLabs.RegexParameterEvaluationStrategy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.RegexParameterEvaluationStrategy?(Eval @this) => @this.Regex;

        /// <summary>
        /// 
        /// </summary>
        public Eval(global::ElevenLabs.RegexParameterEvaluationStrategy? value)
        {
            Regex = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ExactParameterEvaluationStrategy? Exact { get; init; }
#else
        public global::ElevenLabs.ExactParameterEvaluationStrategy? Exact { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Exact))]
#endif
        public bool IsExact => Exact != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Eval(global::ElevenLabs.ExactParameterEvaluationStrategy value) => new Eval((global::ElevenLabs.ExactParameterEvaluationStrategy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ExactParameterEvaluationStrategy?(Eval @this) => @this.Exact;

        /// <summary>
        /// 
        /// </summary>
        public Eval(global::ElevenLabs.ExactParameterEvaluationStrategy? value)
        {
            Exact = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Eval(
            global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType? type,
            global::ElevenLabs.LLMParameterEvaluationStrategy? llm,
            global::ElevenLabs.RegexParameterEvaluationStrategy? regex,
            global::ElevenLabs.ExactParameterEvaluationStrategy? exact
            )
        {
            Type = type;

            Llm = llm;
            Regex = regex;
            Exact = exact;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Exact as object ??
            Regex as object ??
            Llm as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Llm?.ToString() ??
            Regex?.ToString() ??
            Exact?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLlm && !IsRegex && !IsExact || !IsLlm && IsRegex && !IsExact || !IsLlm && !IsRegex && IsExact;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.LLMParameterEvaluationStrategy?, TResult>? llm = null,
            global::System.Func<global::ElevenLabs.RegexParameterEvaluationStrategy?, TResult>? regex = null,
            global::System.Func<global::ElevenLabs.ExactParameterEvaluationStrategy?, TResult>? exact = null,
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
            else if (IsRegex && regex != null)
            {
                return regex(Regex!);
            }
            else if (IsExact && exact != null)
            {
                return exact(Exact!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.LLMParameterEvaluationStrategy?>? llm = null,
            global::System.Action<global::ElevenLabs.RegexParameterEvaluationStrategy?>? regex = null,
            global::System.Action<global::ElevenLabs.ExactParameterEvaluationStrategy?>? exact = null,
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
            else if (IsRegex)
            {
                regex?.Invoke(Regex!);
            }
            else if (IsExact)
            {
                exact?.Invoke(Exact!);
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
                typeof(global::ElevenLabs.LLMParameterEvaluationStrategy),
                Regex,
                typeof(global::ElevenLabs.RegexParameterEvaluationStrategy),
                Exact,
                typeof(global::ElevenLabs.ExactParameterEvaluationStrategy),
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
        public bool Equals(Eval other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.LLMParameterEvaluationStrategy?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.RegexParameterEvaluationStrategy?>.Default.Equals(Regex, other.Regex) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ExactParameterEvaluationStrategy?>.Default.Equals(Exact, other.Exact) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Eval obj1, Eval obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Eval>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Eval obj1, Eval obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Eval o && Equals(o);
        }
    }
}
