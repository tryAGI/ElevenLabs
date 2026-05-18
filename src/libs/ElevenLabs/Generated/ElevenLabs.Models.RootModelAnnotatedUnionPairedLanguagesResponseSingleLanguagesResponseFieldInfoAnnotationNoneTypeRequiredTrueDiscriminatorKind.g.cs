#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind : global::System.IEquatable<RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKind? Kind { get; }

        /// <summary>
        /// Example: {"kind":"pair","language_pairs":[{"destination_languages":[{"code":"es","label":"Spanish"},{"code":"es-ES","label":"Spanish (Spain)"},{"code":"fr","label":"French"}],"source_language":{"code":"en","label":"English"}},{"destination_languages":[{"code":"en","label":"English"}],"source_language":{"code":"es-ES","label":"Spanish (Spain)"}}]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PairedLanguagesResponse? Pair { get; init; }
#else
        public global::ElevenLabs.PairedLanguagesResponse? Pair { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pair))]
#endif
        public bool IsPair => Pair != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPair(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.PairedLanguagesResponse? value)
        {
            value = Pair;
            return IsPair;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.PairedLanguagesResponse PickPair() => IsPair
            ? Pair!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pair' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"kind":"single","languages":[{"code":"en","label":"English"},{"code":"es-ES","label":"Spanish (Spain)"},{"code":"fr","label":"French"}]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SingleLanguagesResponse? Single { get; init; }
#else
        public global::ElevenLabs.SingleLanguagesResponse? Single { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Single))]
#endif
        public bool IsSingle => Single != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSingle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SingleLanguagesResponse? value)
        {
            value = Single;
            return IsSingle;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.SingleLanguagesResponse PickSingle() => IsSingle
            ? Single!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Single' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind(global::ElevenLabs.PairedLanguagesResponse value) => new RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind((global::ElevenLabs.PairedLanguagesResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PairedLanguagesResponse?(RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind @this) => @this.Pair;

        /// <summary>
        /// 
        /// </summary>
        public RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind(global::ElevenLabs.PairedLanguagesResponse? value)
        {
            Pair = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind FromPair(global::ElevenLabs.PairedLanguagesResponse? value) => new RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind(global::ElevenLabs.SingleLanguagesResponse value) => new RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind((global::ElevenLabs.SingleLanguagesResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SingleLanguagesResponse?(RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind @this) => @this.Single;

        /// <summary>
        /// 
        /// </summary>
        public RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind(global::ElevenLabs.SingleLanguagesResponse? value)
        {
            Single = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind FromSingle(global::ElevenLabs.SingleLanguagesResponse? value) => new RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind(value);

        /// <summary>
        /// 
        /// </summary>
        public RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind(
            global::ElevenLabs.RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKind? kind,
            global::ElevenLabs.PairedLanguagesResponse? pair,
            global::ElevenLabs.SingleLanguagesResponse? single
            )
        {
            Kind = kind;

            Pair = pair;
            Single = single;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Single as object ??
            Pair as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Pair?.ToString() ??
            Single?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPair && !IsSingle || !IsPair && IsSingle;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.PairedLanguagesResponse, TResult>? pair = null,
            global::System.Func<global::ElevenLabs.SingleLanguagesResponse, TResult>? single = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPair && pair != null)
            {
                return pair(Pair!);
            }
            else if (IsSingle && single != null)
            {
                return single(Single!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.PairedLanguagesResponse>? pair = null,

            global::System.Action<global::ElevenLabs.SingleLanguagesResponse>? single = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPair)
            {
                pair?.Invoke(Pair!);
            }
            else if (IsSingle)
            {
                single?.Invoke(Single!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.PairedLanguagesResponse>? pair = null,
            global::System.Action<global::ElevenLabs.SingleLanguagesResponse>? single = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPair)
            {
                pair?.Invoke(Pair!);
            }
            else if (IsSingle)
            {
                single?.Invoke(Single!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Pair,
                typeof(global::ElevenLabs.PairedLanguagesResponse),
                Single,
                typeof(global::ElevenLabs.SingleLanguagesResponse),
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
        public bool Equals(RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PairedLanguagesResponse?>.Default.Equals(Pair, other.Pair) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SingleLanguagesResponse?>.Default.Equals(Single, other.Single) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind obj1, RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind obj1, RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKind o && Equals(o);
        }
    }
}
