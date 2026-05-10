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
        public bool TryPickLlm(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.LLMParameterEvaluationStrategy? value)
        {
            value = Llm;
            return IsLlm;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.LLMParameterEvaluationStrategy PickLlm() => IsLlm
            ? Llm!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Llm' but the value was {ToString()}.");

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
        public bool TryPickRegex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.RegexParameterEvaluationStrategy? value)
        {
            value = Regex;
            return IsRegex;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.RegexParameterEvaluationStrategy PickRegex() => IsRegex
            ? Regex!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Regex' but the value was {ToString()}.");

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
        public bool TryPickExact(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ExactParameterEvaluationStrategy? value)
        {
            value = Exact;
            return IsExact;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ExactParameterEvaluationStrategy PickExact() => IsExact
            ? Exact!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Exact' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MatchAnythingParameterEvaluationStrategy? Anything { get; init; }
#else
        public global::ElevenLabs.MatchAnythingParameterEvaluationStrategy? Anything { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anything))]
#endif
        public bool IsAnything => Anything != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnything(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.MatchAnythingParameterEvaluationStrategy? value)
        {
            value = Anything;
            return IsAnything;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.MatchAnythingParameterEvaluationStrategy PickAnything() => IsAnything
            ? Anything!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anything' but the value was {ToString()}.");
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
        public static Eval FromLlm(global::ElevenLabs.LLMParameterEvaluationStrategy? value) => new Eval(value);

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
        public static Eval FromRegex(global::ElevenLabs.RegexParameterEvaluationStrategy? value) => new Eval(value);

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
        public static Eval FromExact(global::ElevenLabs.ExactParameterEvaluationStrategy? value) => new Eval(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Eval(global::ElevenLabs.MatchAnythingParameterEvaluationStrategy value) => new Eval((global::ElevenLabs.MatchAnythingParameterEvaluationStrategy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MatchAnythingParameterEvaluationStrategy?(Eval @this) => @this.Anything;

        /// <summary>
        /// 
        /// </summary>
        public Eval(global::ElevenLabs.MatchAnythingParameterEvaluationStrategy? value)
        {
            Anything = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Eval FromAnything(global::ElevenLabs.MatchAnythingParameterEvaluationStrategy? value) => new Eval(value);

        /// <summary>
        /// 
        /// </summary>
        public Eval(
            global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType? type,
            global::ElevenLabs.LLMParameterEvaluationStrategy? llm,
            global::ElevenLabs.RegexParameterEvaluationStrategy? regex,
            global::ElevenLabs.ExactParameterEvaluationStrategy? exact,
            global::ElevenLabs.MatchAnythingParameterEvaluationStrategy? anything
            )
        {
            Type = type;

            Llm = llm;
            Regex = regex;
            Exact = exact;
            Anything = anything;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Anything as object ??
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
            Exact?.ToString() ??
            Anything?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLlm && !IsRegex && !IsExact && !IsAnything || !IsLlm && IsRegex && !IsExact && !IsAnything || !IsLlm && !IsRegex && IsExact && !IsAnything || !IsLlm && !IsRegex && !IsExact && IsAnything;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.LLMParameterEvaluationStrategy, TResult>? llm = null,
            global::System.Func<global::ElevenLabs.RegexParameterEvaluationStrategy, TResult>? regex = null,
            global::System.Func<global::ElevenLabs.ExactParameterEvaluationStrategy, TResult>? exact = null,
            global::System.Func<global::ElevenLabs.MatchAnythingParameterEvaluationStrategy, TResult>? anything = null,
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
            else if (IsAnything && anything != null)
            {
                return anything(Anything!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.LLMParameterEvaluationStrategy>? llm = null,

            global::System.Action<global::ElevenLabs.RegexParameterEvaluationStrategy>? regex = null,

            global::System.Action<global::ElevenLabs.ExactParameterEvaluationStrategy>? exact = null,

            global::System.Action<global::ElevenLabs.MatchAnythingParameterEvaluationStrategy>? anything = null,
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
            else if (IsAnything)
            {
                anything?.Invoke(Anything!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.LLMParameterEvaluationStrategy>? llm = null,
            global::System.Action<global::ElevenLabs.RegexParameterEvaluationStrategy>? regex = null,
            global::System.Action<global::ElevenLabs.ExactParameterEvaluationStrategy>? exact = null,
            global::System.Action<global::ElevenLabs.MatchAnythingParameterEvaluationStrategy>? anything = null,
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
            else if (IsAnything)
            {
                anything?.Invoke(Anything!);
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
                Anything,
                typeof(global::ElevenLabs.MatchAnythingParameterEvaluationStrategy),
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
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ExactParameterEvaluationStrategy?>.Default.Equals(Exact, other.Exact) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MatchAnythingParameterEvaluationStrategy?>.Default.Equals(Anything, other.Anything) 
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
