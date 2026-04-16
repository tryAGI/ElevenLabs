#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DynamicVariableNestedValueTypeInput : global::System.IEquatable<DynamicVariableNestedValueTypeInput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DynamicVariableNestedValueTypeInputVariant1 { get; init; }
#else
        public string? DynamicVariableNestedValueTypeInputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableNestedValueTypeInputVariant1))]
#endif
        public bool IsDynamicVariableNestedValueTypeInputVariant1 => DynamicVariableNestedValueTypeInputVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? DynamicVariableNestedValueTypeInputVariant2 { get; init; }
#else
        public int? DynamicVariableNestedValueTypeInputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableNestedValueTypeInputVariant2))]
#endif
        public bool IsDynamicVariableNestedValueTypeInputVariant2 => DynamicVariableNestedValueTypeInputVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? DynamicVariableNestedValueTypeInputVariant3 { get; init; }
#else
        public double? DynamicVariableNestedValueTypeInputVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableNestedValueTypeInputVariant3))]
#endif
        public bool IsDynamicVariableNestedValueTypeInputVariant3 => DynamicVariableNestedValueTypeInputVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? DynamicVariableNestedValueTypeInputVariant4 { get; init; }
#else
        public bool? DynamicVariableNestedValueTypeInputVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableNestedValueTypeInputVariant4))]
#endif
        public bool IsDynamicVariableNestedValueTypeInputVariant4 => DynamicVariableNestedValueTypeInputVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>? DynamicVariableNestedValueTypeInputVariant5 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>? DynamicVariableNestedValueTypeInputVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableNestedValueTypeInputVariant5))]
#endif
        public bool IsDynamicVariableNestedValueTypeInputVariant5 => DynamicVariableNestedValueTypeInputVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? DynamicVariableNestedValueTypeInputVariant6 { get; init; }
#else
        public object? DynamicVariableNestedValueTypeInputVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableNestedValueTypeInputVariant6))]
#endif
        public bool IsDynamicVariableNestedValueTypeInputVariant6 => DynamicVariableNestedValueTypeInputVariant6 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableNestedValueTypeInput(string value) => new DynamicVariableNestedValueTypeInput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(DynamicVariableNestedValueTypeInput @this) => @this.DynamicVariableNestedValueTypeInputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableNestedValueTypeInput(string? value)
        {
            DynamicVariableNestedValueTypeInputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableNestedValueTypeInput(int value) => new DynamicVariableNestedValueTypeInput((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(DynamicVariableNestedValueTypeInput @this) => @this.DynamicVariableNestedValueTypeInputVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableNestedValueTypeInput(int? value)
        {
            DynamicVariableNestedValueTypeInputVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableNestedValueTypeInput(double value) => new DynamicVariableNestedValueTypeInput((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(DynamicVariableNestedValueTypeInput @this) => @this.DynamicVariableNestedValueTypeInputVariant3;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableNestedValueTypeInput(double? value)
        {
            DynamicVariableNestedValueTypeInputVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableNestedValueTypeInput(bool value) => new DynamicVariableNestedValueTypeInput((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(DynamicVariableNestedValueTypeInput @this) => @this.DynamicVariableNestedValueTypeInputVariant4;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableNestedValueTypeInput(bool? value)
        {
            DynamicVariableNestedValueTypeInputVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableNestedValueTypeInput(
            string? dynamicVariableNestedValueTypeInputVariant1,
            int? dynamicVariableNestedValueTypeInputVariant2,
            double? dynamicVariableNestedValueTypeInputVariant3,
            bool? dynamicVariableNestedValueTypeInputVariant4,
            global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>? dynamicVariableNestedValueTypeInputVariant5,
            object? dynamicVariableNestedValueTypeInputVariant6
            )
        {
            DynamicVariableNestedValueTypeInputVariant1 = dynamicVariableNestedValueTypeInputVariant1;
            DynamicVariableNestedValueTypeInputVariant2 = dynamicVariableNestedValueTypeInputVariant2;
            DynamicVariableNestedValueTypeInputVariant3 = dynamicVariableNestedValueTypeInputVariant3;
            DynamicVariableNestedValueTypeInputVariant4 = dynamicVariableNestedValueTypeInputVariant4;
            DynamicVariableNestedValueTypeInputVariant5 = dynamicVariableNestedValueTypeInputVariant5;
            DynamicVariableNestedValueTypeInputVariant6 = dynamicVariableNestedValueTypeInputVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DynamicVariableNestedValueTypeInputVariant6 as object ??
            DynamicVariableNestedValueTypeInputVariant5 as object ??
            DynamicVariableNestedValueTypeInputVariant4 as object ??
            DynamicVariableNestedValueTypeInputVariant3 as object ??
            DynamicVariableNestedValueTypeInputVariant2 as object ??
            DynamicVariableNestedValueTypeInputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DynamicVariableNestedValueTypeInputVariant1?.ToString() ??
            DynamicVariableNestedValueTypeInputVariant2?.ToString() ??
            DynamicVariableNestedValueTypeInputVariant3?.ToString() ??
            DynamicVariableNestedValueTypeInputVariant4?.ToString().ToLowerInvariant() ??
            DynamicVariableNestedValueTypeInputVariant5?.ToString() ??
            DynamicVariableNestedValueTypeInputVariant6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDynamicVariableNestedValueTypeInputVariant1 || IsDynamicVariableNestedValueTypeInputVariant2 || IsDynamicVariableNestedValueTypeInputVariant3 || IsDynamicVariableNestedValueTypeInputVariant4 || IsDynamicVariableNestedValueTypeInputVariant5 || IsDynamicVariableNestedValueTypeInputVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? dynamicVariableNestedValueTypeInputVariant1 = null,
            global::System.Func<int?, TResult>? dynamicVariableNestedValueTypeInputVariant2 = null,
            global::System.Func<double?, TResult>? dynamicVariableNestedValueTypeInputVariant3 = null,
            global::System.Func<bool?, TResult>? dynamicVariableNestedValueTypeInputVariant4 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>?, TResult>? dynamicVariableNestedValueTypeInputVariant5 = null,
            global::System.Func<object?, TResult>? dynamicVariableNestedValueTypeInputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVariableNestedValueTypeInputVariant1 && dynamicVariableNestedValueTypeInputVariant1 != null)
            {
                return dynamicVariableNestedValueTypeInputVariant1(DynamicVariableNestedValueTypeInputVariant1!);
            }
            else if (IsDynamicVariableNestedValueTypeInputVariant2 && dynamicVariableNestedValueTypeInputVariant2 != null)
            {
                return dynamicVariableNestedValueTypeInputVariant2(DynamicVariableNestedValueTypeInputVariant2!);
            }
            else if (IsDynamicVariableNestedValueTypeInputVariant3 && dynamicVariableNestedValueTypeInputVariant3 != null)
            {
                return dynamicVariableNestedValueTypeInputVariant3(DynamicVariableNestedValueTypeInputVariant3!);
            }
            else if (IsDynamicVariableNestedValueTypeInputVariant4 && dynamicVariableNestedValueTypeInputVariant4 != null)
            {
                return dynamicVariableNestedValueTypeInputVariant4(DynamicVariableNestedValueTypeInputVariant4!);
            }
            else if (IsDynamicVariableNestedValueTypeInputVariant5 && dynamicVariableNestedValueTypeInputVariant5 != null)
            {
                return dynamicVariableNestedValueTypeInputVariant5(DynamicVariableNestedValueTypeInputVariant5!);
            }
            else if (IsDynamicVariableNestedValueTypeInputVariant6 && dynamicVariableNestedValueTypeInputVariant6 != null)
            {
                return dynamicVariableNestedValueTypeInputVariant6(DynamicVariableNestedValueTypeInputVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? dynamicVariableNestedValueTypeInputVariant1 = null,
            global::System.Action<int?>? dynamicVariableNestedValueTypeInputVariant2 = null,
            global::System.Action<double?>? dynamicVariableNestedValueTypeInputVariant3 = null,
            global::System.Action<bool?>? dynamicVariableNestedValueTypeInputVariant4 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>?>? dynamicVariableNestedValueTypeInputVariant5 = null,
            global::System.Action<object?>? dynamicVariableNestedValueTypeInputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVariableNestedValueTypeInputVariant1)
            {
                dynamicVariableNestedValueTypeInputVariant1?.Invoke(DynamicVariableNestedValueTypeInputVariant1!);
            }
            else if (IsDynamicVariableNestedValueTypeInputVariant2)
            {
                dynamicVariableNestedValueTypeInputVariant2?.Invoke(DynamicVariableNestedValueTypeInputVariant2!);
            }
            else if (IsDynamicVariableNestedValueTypeInputVariant3)
            {
                dynamicVariableNestedValueTypeInputVariant3?.Invoke(DynamicVariableNestedValueTypeInputVariant3!);
            }
            else if (IsDynamicVariableNestedValueTypeInputVariant4)
            {
                dynamicVariableNestedValueTypeInputVariant4?.Invoke(DynamicVariableNestedValueTypeInputVariant4!);
            }
            else if (IsDynamicVariableNestedValueTypeInputVariant5)
            {
                dynamicVariableNestedValueTypeInputVariant5?.Invoke(DynamicVariableNestedValueTypeInputVariant5!);
            }
            else if (IsDynamicVariableNestedValueTypeInputVariant6)
            {
                dynamicVariableNestedValueTypeInputVariant6?.Invoke(DynamicVariableNestedValueTypeInputVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DynamicVariableNestedValueTypeInputVariant1,
                typeof(string),
                DynamicVariableNestedValueTypeInputVariant2,
                typeof(int),
                DynamicVariableNestedValueTypeInputVariant3,
                typeof(double),
                DynamicVariableNestedValueTypeInputVariant4,
                typeof(bool),
                DynamicVariableNestedValueTypeInputVariant5,
                typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>),
                DynamicVariableNestedValueTypeInputVariant6,
                typeof(object),
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
        public bool Equals(DynamicVariableNestedValueTypeInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DynamicVariableNestedValueTypeInputVariant1, other.DynamicVariableNestedValueTypeInputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(DynamicVariableNestedValueTypeInputVariant2, other.DynamicVariableNestedValueTypeInputVariant2) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(DynamicVariableNestedValueTypeInputVariant3, other.DynamicVariableNestedValueTypeInputVariant3) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(DynamicVariableNestedValueTypeInputVariant4, other.DynamicVariableNestedValueTypeInputVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>?>.Default.Equals(DynamicVariableNestedValueTypeInputVariant5, other.DynamicVariableNestedValueTypeInputVariant5) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(DynamicVariableNestedValueTypeInputVariant6, other.DynamicVariableNestedValueTypeInputVariant6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DynamicVariableNestedValueTypeInput obj1, DynamicVariableNestedValueTypeInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DynamicVariableNestedValueTypeInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DynamicVariableNestedValueTypeInput obj1, DynamicVariableNestedValueTypeInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DynamicVariableNestedValueTypeInput o && Equals(o);
        }
    }
}
