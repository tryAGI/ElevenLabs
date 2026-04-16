#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DynamicVariableNestedValueTypeOutput : global::System.IEquatable<DynamicVariableNestedValueTypeOutput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DynamicVariableNestedValueTypeOutputVariant1 { get; init; }
#else
        public string? DynamicVariableNestedValueTypeOutputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableNestedValueTypeOutputVariant1))]
#endif
        public bool IsDynamicVariableNestedValueTypeOutputVariant1 => DynamicVariableNestedValueTypeOutputVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? DynamicVariableNestedValueTypeOutputVariant2 { get; init; }
#else
        public int? DynamicVariableNestedValueTypeOutputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableNestedValueTypeOutputVariant2))]
#endif
        public bool IsDynamicVariableNestedValueTypeOutputVariant2 => DynamicVariableNestedValueTypeOutputVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? DynamicVariableNestedValueTypeOutputVariant3 { get; init; }
#else
        public double? DynamicVariableNestedValueTypeOutputVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableNestedValueTypeOutputVariant3))]
#endif
        public bool IsDynamicVariableNestedValueTypeOutputVariant3 => DynamicVariableNestedValueTypeOutputVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? DynamicVariableNestedValueTypeOutputVariant4 { get; init; }
#else
        public bool? DynamicVariableNestedValueTypeOutputVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableNestedValueTypeOutputVariant4))]
#endif
        public bool IsDynamicVariableNestedValueTypeOutputVariant4 => DynamicVariableNestedValueTypeOutputVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>? DynamicVariableNestedValueTypeOutputVariant5 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>? DynamicVariableNestedValueTypeOutputVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableNestedValueTypeOutputVariant5))]
#endif
        public bool IsDynamicVariableNestedValueTypeOutputVariant5 => DynamicVariableNestedValueTypeOutputVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? DynamicVariableNestedValueTypeOutputVariant6 { get; init; }
#else
        public object? DynamicVariableNestedValueTypeOutputVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableNestedValueTypeOutputVariant6))]
#endif
        public bool IsDynamicVariableNestedValueTypeOutputVariant6 => DynamicVariableNestedValueTypeOutputVariant6 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableNestedValueTypeOutput(string value) => new DynamicVariableNestedValueTypeOutput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(DynamicVariableNestedValueTypeOutput @this) => @this.DynamicVariableNestedValueTypeOutputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableNestedValueTypeOutput(string? value)
        {
            DynamicVariableNestedValueTypeOutputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableNestedValueTypeOutput(int value) => new DynamicVariableNestedValueTypeOutput((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(DynamicVariableNestedValueTypeOutput @this) => @this.DynamicVariableNestedValueTypeOutputVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableNestedValueTypeOutput(int? value)
        {
            DynamicVariableNestedValueTypeOutputVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableNestedValueTypeOutput(double value) => new DynamicVariableNestedValueTypeOutput((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(DynamicVariableNestedValueTypeOutput @this) => @this.DynamicVariableNestedValueTypeOutputVariant3;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableNestedValueTypeOutput(double? value)
        {
            DynamicVariableNestedValueTypeOutputVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableNestedValueTypeOutput(bool value) => new DynamicVariableNestedValueTypeOutput((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(DynamicVariableNestedValueTypeOutput @this) => @this.DynamicVariableNestedValueTypeOutputVariant4;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableNestedValueTypeOutput(bool? value)
        {
            DynamicVariableNestedValueTypeOutputVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableNestedValueTypeOutput(
            string? dynamicVariableNestedValueTypeOutputVariant1,
            int? dynamicVariableNestedValueTypeOutputVariant2,
            double? dynamicVariableNestedValueTypeOutputVariant3,
            bool? dynamicVariableNestedValueTypeOutputVariant4,
            global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>? dynamicVariableNestedValueTypeOutputVariant5,
            object? dynamicVariableNestedValueTypeOutputVariant6
            )
        {
            DynamicVariableNestedValueTypeOutputVariant1 = dynamicVariableNestedValueTypeOutputVariant1;
            DynamicVariableNestedValueTypeOutputVariant2 = dynamicVariableNestedValueTypeOutputVariant2;
            DynamicVariableNestedValueTypeOutputVariant3 = dynamicVariableNestedValueTypeOutputVariant3;
            DynamicVariableNestedValueTypeOutputVariant4 = dynamicVariableNestedValueTypeOutputVariant4;
            DynamicVariableNestedValueTypeOutputVariant5 = dynamicVariableNestedValueTypeOutputVariant5;
            DynamicVariableNestedValueTypeOutputVariant6 = dynamicVariableNestedValueTypeOutputVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DynamicVariableNestedValueTypeOutputVariant6 as object ??
            DynamicVariableNestedValueTypeOutputVariant5 as object ??
            DynamicVariableNestedValueTypeOutputVariant4 as object ??
            DynamicVariableNestedValueTypeOutputVariant3 as object ??
            DynamicVariableNestedValueTypeOutputVariant2 as object ??
            DynamicVariableNestedValueTypeOutputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DynamicVariableNestedValueTypeOutputVariant1?.ToString() ??
            DynamicVariableNestedValueTypeOutputVariant2?.ToString() ??
            DynamicVariableNestedValueTypeOutputVariant3?.ToString() ??
            DynamicVariableNestedValueTypeOutputVariant4?.ToString().ToLowerInvariant() ??
            DynamicVariableNestedValueTypeOutputVariant5?.ToString() ??
            DynamicVariableNestedValueTypeOutputVariant6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDynamicVariableNestedValueTypeOutputVariant1 || IsDynamicVariableNestedValueTypeOutputVariant2 || IsDynamicVariableNestedValueTypeOutputVariant3 || IsDynamicVariableNestedValueTypeOutputVariant4 || IsDynamicVariableNestedValueTypeOutputVariant5 || IsDynamicVariableNestedValueTypeOutputVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? dynamicVariableNestedValueTypeOutputVariant1 = null,
            global::System.Func<int?, TResult>? dynamicVariableNestedValueTypeOutputVariant2 = null,
            global::System.Func<double?, TResult>? dynamicVariableNestedValueTypeOutputVariant3 = null,
            global::System.Func<bool?, TResult>? dynamicVariableNestedValueTypeOutputVariant4 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>?, TResult>? dynamicVariableNestedValueTypeOutputVariant5 = null,
            global::System.Func<object?, TResult>? dynamicVariableNestedValueTypeOutputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVariableNestedValueTypeOutputVariant1 && dynamicVariableNestedValueTypeOutputVariant1 != null)
            {
                return dynamicVariableNestedValueTypeOutputVariant1(DynamicVariableNestedValueTypeOutputVariant1!);
            }
            else if (IsDynamicVariableNestedValueTypeOutputVariant2 && dynamicVariableNestedValueTypeOutputVariant2 != null)
            {
                return dynamicVariableNestedValueTypeOutputVariant2(DynamicVariableNestedValueTypeOutputVariant2!);
            }
            else if (IsDynamicVariableNestedValueTypeOutputVariant3 && dynamicVariableNestedValueTypeOutputVariant3 != null)
            {
                return dynamicVariableNestedValueTypeOutputVariant3(DynamicVariableNestedValueTypeOutputVariant3!);
            }
            else if (IsDynamicVariableNestedValueTypeOutputVariant4 && dynamicVariableNestedValueTypeOutputVariant4 != null)
            {
                return dynamicVariableNestedValueTypeOutputVariant4(DynamicVariableNestedValueTypeOutputVariant4!);
            }
            else if (IsDynamicVariableNestedValueTypeOutputVariant5 && dynamicVariableNestedValueTypeOutputVariant5 != null)
            {
                return dynamicVariableNestedValueTypeOutputVariant5(DynamicVariableNestedValueTypeOutputVariant5!);
            }
            else if (IsDynamicVariableNestedValueTypeOutputVariant6 && dynamicVariableNestedValueTypeOutputVariant6 != null)
            {
                return dynamicVariableNestedValueTypeOutputVariant6(DynamicVariableNestedValueTypeOutputVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? dynamicVariableNestedValueTypeOutputVariant1 = null,
            global::System.Action<int?>? dynamicVariableNestedValueTypeOutputVariant2 = null,
            global::System.Action<double?>? dynamicVariableNestedValueTypeOutputVariant3 = null,
            global::System.Action<bool?>? dynamicVariableNestedValueTypeOutputVariant4 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>?>? dynamicVariableNestedValueTypeOutputVariant5 = null,
            global::System.Action<object?>? dynamicVariableNestedValueTypeOutputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVariableNestedValueTypeOutputVariant1)
            {
                dynamicVariableNestedValueTypeOutputVariant1?.Invoke(DynamicVariableNestedValueTypeOutputVariant1!);
            }
            else if (IsDynamicVariableNestedValueTypeOutputVariant2)
            {
                dynamicVariableNestedValueTypeOutputVariant2?.Invoke(DynamicVariableNestedValueTypeOutputVariant2!);
            }
            else if (IsDynamicVariableNestedValueTypeOutputVariant3)
            {
                dynamicVariableNestedValueTypeOutputVariant3?.Invoke(DynamicVariableNestedValueTypeOutputVariant3!);
            }
            else if (IsDynamicVariableNestedValueTypeOutputVariant4)
            {
                dynamicVariableNestedValueTypeOutputVariant4?.Invoke(DynamicVariableNestedValueTypeOutputVariant4!);
            }
            else if (IsDynamicVariableNestedValueTypeOutputVariant5)
            {
                dynamicVariableNestedValueTypeOutputVariant5?.Invoke(DynamicVariableNestedValueTypeOutputVariant5!);
            }
            else if (IsDynamicVariableNestedValueTypeOutputVariant6)
            {
                dynamicVariableNestedValueTypeOutputVariant6?.Invoke(DynamicVariableNestedValueTypeOutputVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DynamicVariableNestedValueTypeOutputVariant1,
                typeof(string),
                DynamicVariableNestedValueTypeOutputVariant2,
                typeof(int),
                DynamicVariableNestedValueTypeOutputVariant3,
                typeof(double),
                DynamicVariableNestedValueTypeOutputVariant4,
                typeof(bool),
                DynamicVariableNestedValueTypeOutputVariant5,
                typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>),
                DynamicVariableNestedValueTypeOutputVariant6,
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
        public bool Equals(DynamicVariableNestedValueTypeOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DynamicVariableNestedValueTypeOutputVariant1, other.DynamicVariableNestedValueTypeOutputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(DynamicVariableNestedValueTypeOutputVariant2, other.DynamicVariableNestedValueTypeOutputVariant2) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(DynamicVariableNestedValueTypeOutputVariant3, other.DynamicVariableNestedValueTypeOutputVariant3) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(DynamicVariableNestedValueTypeOutputVariant4, other.DynamicVariableNestedValueTypeOutputVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>?>.Default.Equals(DynamicVariableNestedValueTypeOutputVariant5, other.DynamicVariableNestedValueTypeOutputVariant5) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(DynamicVariableNestedValueTypeOutputVariant6, other.DynamicVariableNestedValueTypeOutputVariant6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DynamicVariableNestedValueTypeOutput obj1, DynamicVariableNestedValueTypeOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DynamicVariableNestedValueTypeOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DynamicVariableNestedValueTypeOutput obj1, DynamicVariableNestedValueTypeOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DynamicVariableNestedValueTypeOutput o && Equals(o);
        }
    }
}
