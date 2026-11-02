#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How this criterion is scored (binary or numeric_uniform).
    /// </summary>
    public readonly partial struct Scoring : global::System.IEquatable<Scoring>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminatorMode? Mode { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BinaryScoring? Binary { get; init; }
#else
        public global::ElevenLabs.BinaryScoring? Binary { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Binary))]
#endif
        public bool IsBinary => Binary != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBinary(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.BinaryScoring? value)
        {
            value = Binary;
            return IsBinary;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BinaryScoring PickBinary() => Binary is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Binary' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.NumericUniformScoring? NumericUniform { get; init; }
#else
        public global::ElevenLabs.NumericUniformScoring? NumericUniform { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumericUniform))]
#endif
        public bool IsNumericUniform => NumericUniform != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNumericUniform(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.NumericUniformScoring? value)
        {
            value = NumericUniform;
            return IsNumericUniform;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumericUniformScoring PickNumericUniform() => NumericUniform is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NumericUniform' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Scoring(global::ElevenLabs.BinaryScoring value) => new Scoring((global::ElevenLabs.BinaryScoring?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.BinaryScoring?(Scoring @this) => @this.Binary;

        /// <summary>
        ///
        /// </summary>
        public Scoring(global::ElevenLabs.BinaryScoring? value)
        {
            Binary = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Scoring FromBinary(global::ElevenLabs.BinaryScoring? value) => new Scoring(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Scoring(global::ElevenLabs.NumericUniformScoring value) => new Scoring((global::ElevenLabs.NumericUniformScoring?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.NumericUniformScoring?(Scoring @this) => @this.NumericUniform;

        /// <summary>
        ///
        /// </summary>
        public Scoring(global::ElevenLabs.NumericUniformScoring? value)
        {
            NumericUniform = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Scoring FromNumericUniform(global::ElevenLabs.NumericUniformScoring? value) => new Scoring(value);

        /// <summary>
        ///
        /// </summary>
        public Scoring(
            global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminatorMode? mode,
            global::ElevenLabs.BinaryScoring? binary,
            global::ElevenLabs.NumericUniformScoring? numericUniform
            )
        {
            Mode = mode;

            Binary = binary;
            NumericUniform = numericUniform;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            NumericUniform as object ??
            Binary as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Binary?.ToString() ??
            NumericUniform?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBinary && !IsNumericUniform || !IsBinary && IsNumericUniform;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.BinaryScoring, TResult>? binary = null,
            global::System.Func<global::ElevenLabs.NumericUniformScoring, TResult>? numericUniform = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Binary is { } __value0 && binary != null)
            {
                return binary(__value0);
            }
            else if (NumericUniform is { } __value1 && numericUniform != null)
            {
                return numericUniform(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.BinaryScoring>? binary = null,

            global::System.Action<global::ElevenLabs.NumericUniformScoring>? numericUniform = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Binary is { } __value0)
            {
                binary?.Invoke(__value0);
            }
            else if (NumericUniform is { } __value1)
            {
                numericUniform?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.BinaryScoring>? binary = null,
            global::System.Action<global::ElevenLabs.NumericUniformScoring>? numericUniform = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Binary is { } __value0)
            {
                binary?.Invoke(__value0);
            }
            else if (NumericUniform is { } __value1)
            {
                numericUniform?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Binary,
                typeof(global::ElevenLabs.BinaryScoring),
                NumericUniform,
                typeof(global::ElevenLabs.NumericUniformScoring),
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
        public bool Equals(Scoring other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BinaryScoring?>.Default.Equals(Binary, other.Binary) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.NumericUniformScoring?>.Default.Equals(NumericUniform, other.NumericUniform)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Scoring obj1, Scoring obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Scoring>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Scoring obj1, Scoring obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Scoring o && Equals(o);
        }
    }
}
