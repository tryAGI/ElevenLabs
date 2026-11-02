#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Definition2 : global::System.IEquatable<Definition2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminatorKind? Kind { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UserEvaluationAnalysisItem? Evaluation { get; init; }
#else
        public global::ElevenLabs.UserEvaluationAnalysisItem? Evaluation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Evaluation))]
#endif
        public bool IsEvaluation => Evaluation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEvaluation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UserEvaluationAnalysisItem? value)
        {
            value = Evaluation;
            return IsEvaluation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserEvaluationAnalysisItem PickEvaluation() => Evaluation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Evaluation' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UserDataCollectionAnalysisItemOutput? DataCollection { get; init; }
#else
        public global::ElevenLabs.UserDataCollectionAnalysisItemOutput? DataCollection { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DataCollection))]
#endif
        public bool IsDataCollection => DataCollection != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDataCollection(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UserDataCollectionAnalysisItemOutput? value)
        {
            value = DataCollection;
            return IsDataCollection;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserDataCollectionAnalysisItemOutput PickDataCollection() => DataCollection is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DataCollection' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Definition2(global::ElevenLabs.UserEvaluationAnalysisItem value) => new Definition2((global::ElevenLabs.UserEvaluationAnalysisItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.UserEvaluationAnalysisItem?(Definition2 @this) => @this.Evaluation;

        /// <summary>
        ///
        /// </summary>
        public Definition2(global::ElevenLabs.UserEvaluationAnalysisItem? value)
        {
            Evaluation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Definition2 FromEvaluation(global::ElevenLabs.UserEvaluationAnalysisItem? value) => new Definition2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Definition2(global::ElevenLabs.UserDataCollectionAnalysisItemOutput value) => new Definition2((global::ElevenLabs.UserDataCollectionAnalysisItemOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.UserDataCollectionAnalysisItemOutput?(Definition2 @this) => @this.DataCollection;

        /// <summary>
        ///
        /// </summary>
        public Definition2(global::ElevenLabs.UserDataCollectionAnalysisItemOutput? value)
        {
            DataCollection = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Definition2 FromDataCollection(global::ElevenLabs.UserDataCollectionAnalysisItemOutput? value) => new Definition2(value);

        /// <summary>
        ///
        /// </summary>
        public Definition2(
            global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminatorKind? kind,
            global::ElevenLabs.UserEvaluationAnalysisItem? evaluation,
            global::ElevenLabs.UserDataCollectionAnalysisItemOutput? dataCollection
            )
        {
            Kind = kind;

            Evaluation = evaluation;
            DataCollection = dataCollection;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DataCollection as object ??
            Evaluation as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Evaluation?.ToString() ??
            DataCollection?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEvaluation && !IsDataCollection || !IsEvaluation && IsDataCollection;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.UserEvaluationAnalysisItem, TResult>? evaluation = null,
            global::System.Func<global::ElevenLabs.UserDataCollectionAnalysisItemOutput, TResult>? dataCollection = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Evaluation is { } __value0 && evaluation != null)
            {
                return evaluation(__value0);
            }
            else if (DataCollection is { } __value1 && dataCollection != null)
            {
                return dataCollection(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.UserEvaluationAnalysisItem>? evaluation = null,

            global::System.Action<global::ElevenLabs.UserDataCollectionAnalysisItemOutput>? dataCollection = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Evaluation is { } __value0)
            {
                evaluation?.Invoke(__value0);
            }
            else if (DataCollection is { } __value1)
            {
                dataCollection?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.UserEvaluationAnalysisItem>? evaluation = null,
            global::System.Action<global::ElevenLabs.UserDataCollectionAnalysisItemOutput>? dataCollection = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Evaluation is { } __value0)
            {
                evaluation?.Invoke(__value0);
            }
            else if (DataCollection is { } __value1)
            {
                dataCollection?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Evaluation,
                typeof(global::ElevenLabs.UserEvaluationAnalysisItem),
                DataCollection,
                typeof(global::ElevenLabs.UserDataCollectionAnalysisItemOutput),
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
        public bool Equals(Definition2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UserEvaluationAnalysisItem?>.Default.Equals(Evaluation, other.Evaluation) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UserDataCollectionAnalysisItemOutput?>.Default.Equals(DataCollection, other.DataCollection)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Definition2 obj1, Definition2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Definition2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Definition2 obj1, Definition2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Definition2 o && Equals(o);
        }
    }
}
