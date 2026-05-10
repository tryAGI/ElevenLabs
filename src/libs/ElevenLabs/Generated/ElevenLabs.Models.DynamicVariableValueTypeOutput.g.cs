#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DynamicVariableValueTypeOutput : global::System.IEquatable<DynamicVariableValueTypeOutput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DynamicVariableValueTypeOutputVariant1 { get; init; }
#else
        public string? DynamicVariableValueTypeOutputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableValueTypeOutputVariant1))]
#endif
        public bool IsDynamicVariableValueTypeOutputVariant1 => DynamicVariableValueTypeOutputVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariableValueTypeOutputVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = DynamicVariableValueTypeOutputVariant1;
            return IsDynamicVariableValueTypeOutputVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? DynamicVariableValueTypeOutputVariant2 { get; init; }
#else
        public double? DynamicVariableValueTypeOutputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableValueTypeOutputVariant2))]
#endif
        public bool IsDynamicVariableValueTypeOutputVariant2 => DynamicVariableValueTypeOutputVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariableValueTypeOutputVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = DynamicVariableValueTypeOutputVariant2;
            return IsDynamicVariableValueTypeOutputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? DynamicVariableValueTypeOutputVariant3 { get; init; }
#else
        public int? DynamicVariableValueTypeOutputVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableValueTypeOutputVariant3))]
#endif
        public bool IsDynamicVariableValueTypeOutputVariant3 => DynamicVariableValueTypeOutputVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariableValueTypeOutputVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = DynamicVariableValueTypeOutputVariant3;
            return IsDynamicVariableValueTypeOutputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? DynamicVariableValueTypeOutputVariant4 { get; init; }
#else
        public bool? DynamicVariableValueTypeOutputVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableValueTypeOutputVariant4))]
#endif
        public bool IsDynamicVariableValueTypeOutputVariant4 => DynamicVariableValueTypeOutputVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariableValueTypeOutputVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = DynamicVariableValueTypeOutputVariant4;
            return IsDynamicVariableValueTypeOutputVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>? DynamicVariableValueTypeOutputVariant5 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>? DynamicVariableValueTypeOutputVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableValueTypeOutputVariant5))]
#endif
        public bool IsDynamicVariableValueTypeOutputVariant5 => DynamicVariableValueTypeOutputVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariableValueTypeOutputVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>? value)
        {
            value = DynamicVariableValueTypeOutputVariant5;
            return IsDynamicVariableValueTypeOutputVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? DynamicVariableValueTypeOutputVariant6 { get; init; }
#else
        public object? DynamicVariableValueTypeOutputVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableValueTypeOutputVariant6))]
#endif
        public bool IsDynamicVariableValueTypeOutputVariant6 => DynamicVariableValueTypeOutputVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariableValueTypeOutputVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = DynamicVariableValueTypeOutputVariant6;
            return IsDynamicVariableValueTypeOutputVariant6;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableValueTypeOutput(string value) => new DynamicVariableValueTypeOutput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(DynamicVariableValueTypeOutput @this) => @this.DynamicVariableValueTypeOutputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableValueTypeOutput(string? value)
        {
            DynamicVariableValueTypeOutputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DynamicVariableValueTypeOutput FromDynamicVariableValueTypeOutputVariant1(string? value) => new DynamicVariableValueTypeOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableValueTypeOutput(double value) => new DynamicVariableValueTypeOutput((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(DynamicVariableValueTypeOutput @this) => @this.DynamicVariableValueTypeOutputVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableValueTypeOutput(double? value)
        {
            DynamicVariableValueTypeOutputVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DynamicVariableValueTypeOutput FromDynamicVariableValueTypeOutputVariant2(double? value) => new DynamicVariableValueTypeOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableValueTypeOutput(int value) => new DynamicVariableValueTypeOutput((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(DynamicVariableValueTypeOutput @this) => @this.DynamicVariableValueTypeOutputVariant3;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableValueTypeOutput(int? value)
        {
            DynamicVariableValueTypeOutputVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DynamicVariableValueTypeOutput FromDynamicVariableValueTypeOutputVariant3(int? value) => new DynamicVariableValueTypeOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableValueTypeOutput(bool value) => new DynamicVariableValueTypeOutput((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(DynamicVariableValueTypeOutput @this) => @this.DynamicVariableValueTypeOutputVariant4;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableValueTypeOutput(bool? value)
        {
            DynamicVariableValueTypeOutputVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DynamicVariableValueTypeOutput FromDynamicVariableValueTypeOutputVariant4(bool? value) => new DynamicVariableValueTypeOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableValueTypeOutput(
            string? dynamicVariableValueTypeOutputVariant1,
            double? dynamicVariableValueTypeOutputVariant2,
            int? dynamicVariableValueTypeOutputVariant3,
            bool? dynamicVariableValueTypeOutputVariant4,
            global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>? dynamicVariableValueTypeOutputVariant5,
            object? dynamicVariableValueTypeOutputVariant6
            )
        {
            DynamicVariableValueTypeOutputVariant1 = dynamicVariableValueTypeOutputVariant1;
            DynamicVariableValueTypeOutputVariant2 = dynamicVariableValueTypeOutputVariant2;
            DynamicVariableValueTypeOutputVariant3 = dynamicVariableValueTypeOutputVariant3;
            DynamicVariableValueTypeOutputVariant4 = dynamicVariableValueTypeOutputVariant4;
            DynamicVariableValueTypeOutputVariant5 = dynamicVariableValueTypeOutputVariant5;
            DynamicVariableValueTypeOutputVariant6 = dynamicVariableValueTypeOutputVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DynamicVariableValueTypeOutputVariant6 as object ??
            DynamicVariableValueTypeOutputVariant5 as object ??
            DynamicVariableValueTypeOutputVariant4 as object ??
            DynamicVariableValueTypeOutputVariant3 as object ??
            DynamicVariableValueTypeOutputVariant2 as object ??
            DynamicVariableValueTypeOutputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DynamicVariableValueTypeOutputVariant1?.ToString() ??
            DynamicVariableValueTypeOutputVariant2?.ToString() ??
            DynamicVariableValueTypeOutputVariant3?.ToString() ??
            DynamicVariableValueTypeOutputVariant4?.ToString().ToLowerInvariant() ??
            DynamicVariableValueTypeOutputVariant5?.ToString() ??
            DynamicVariableValueTypeOutputVariant6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDynamicVariableValueTypeOutputVariant1 || IsDynamicVariableValueTypeOutputVariant2 || IsDynamicVariableValueTypeOutputVariant3 || IsDynamicVariableValueTypeOutputVariant4 || IsDynamicVariableValueTypeOutputVariant5 || IsDynamicVariableValueTypeOutputVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? dynamicVariableValueTypeOutputVariant1 = null,
            global::System.Func<double?, TResult>? dynamicVariableValueTypeOutputVariant2 = null,
            global::System.Func<int?, TResult>? dynamicVariableValueTypeOutputVariant3 = null,
            global::System.Func<bool?, TResult>? dynamicVariableValueTypeOutputVariant4 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>, TResult>? dynamicVariableValueTypeOutputVariant5 = null,
            global::System.Func<object, TResult>? dynamicVariableValueTypeOutputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVariableValueTypeOutputVariant1 && dynamicVariableValueTypeOutputVariant1 != null)
            {
                return dynamicVariableValueTypeOutputVariant1(DynamicVariableValueTypeOutputVariant1!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant2 && dynamicVariableValueTypeOutputVariant2 != null)
            {
                return dynamicVariableValueTypeOutputVariant2(DynamicVariableValueTypeOutputVariant2!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant3 && dynamicVariableValueTypeOutputVariant3 != null)
            {
                return dynamicVariableValueTypeOutputVariant3(DynamicVariableValueTypeOutputVariant3!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant4 && dynamicVariableValueTypeOutputVariant4 != null)
            {
                return dynamicVariableValueTypeOutputVariant4(DynamicVariableValueTypeOutputVariant4!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant5 && dynamicVariableValueTypeOutputVariant5 != null)
            {
                return dynamicVariableValueTypeOutputVariant5(DynamicVariableValueTypeOutputVariant5!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant6 && dynamicVariableValueTypeOutputVariant6 != null)
            {
                return dynamicVariableValueTypeOutputVariant6(DynamicVariableValueTypeOutputVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? dynamicVariableValueTypeOutputVariant1 = null,

            global::System.Action<double?>? dynamicVariableValueTypeOutputVariant2 = null,

            global::System.Action<int?>? dynamicVariableValueTypeOutputVariant3 = null,

            global::System.Action<bool?>? dynamicVariableValueTypeOutputVariant4 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>>? dynamicVariableValueTypeOutputVariant5 = null,

            global::System.Action<object>? dynamicVariableValueTypeOutputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVariableValueTypeOutputVariant1)
            {
                dynamicVariableValueTypeOutputVariant1?.Invoke(DynamicVariableValueTypeOutputVariant1!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant2)
            {
                dynamicVariableValueTypeOutputVariant2?.Invoke(DynamicVariableValueTypeOutputVariant2!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant3)
            {
                dynamicVariableValueTypeOutputVariant3?.Invoke(DynamicVariableValueTypeOutputVariant3!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant4)
            {
                dynamicVariableValueTypeOutputVariant4?.Invoke(DynamicVariableValueTypeOutputVariant4!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant5)
            {
                dynamicVariableValueTypeOutputVariant5?.Invoke(DynamicVariableValueTypeOutputVariant5!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant6)
            {
                dynamicVariableValueTypeOutputVariant6?.Invoke(DynamicVariableValueTypeOutputVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? dynamicVariableValueTypeOutputVariant1 = null,
            global::System.Action<double?>? dynamicVariableValueTypeOutputVariant2 = null,
            global::System.Action<int?>? dynamicVariableValueTypeOutputVariant3 = null,
            global::System.Action<bool?>? dynamicVariableValueTypeOutputVariant4 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>>? dynamicVariableValueTypeOutputVariant5 = null,
            global::System.Action<object>? dynamicVariableValueTypeOutputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVariableValueTypeOutputVariant1)
            {
                dynamicVariableValueTypeOutputVariant1?.Invoke(DynamicVariableValueTypeOutputVariant1!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant2)
            {
                dynamicVariableValueTypeOutputVariant2?.Invoke(DynamicVariableValueTypeOutputVariant2!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant3)
            {
                dynamicVariableValueTypeOutputVariant3?.Invoke(DynamicVariableValueTypeOutputVariant3!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant4)
            {
                dynamicVariableValueTypeOutputVariant4?.Invoke(DynamicVariableValueTypeOutputVariant4!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant5)
            {
                dynamicVariableValueTypeOutputVariant5?.Invoke(DynamicVariableValueTypeOutputVariant5!);
            }
            else if (IsDynamicVariableValueTypeOutputVariant6)
            {
                dynamicVariableValueTypeOutputVariant6?.Invoke(DynamicVariableValueTypeOutputVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DynamicVariableValueTypeOutputVariant1,
                typeof(string),
                DynamicVariableValueTypeOutputVariant2,
                typeof(double),
                DynamicVariableValueTypeOutputVariant3,
                typeof(int),
                DynamicVariableValueTypeOutputVariant4,
                typeof(bool),
                DynamicVariableValueTypeOutputVariant5,
                typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>),
                DynamicVariableValueTypeOutputVariant6,
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
        public bool Equals(DynamicVariableValueTypeOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DynamicVariableValueTypeOutputVariant1, other.DynamicVariableValueTypeOutputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(DynamicVariableValueTypeOutputVariant2, other.DynamicVariableValueTypeOutputVariant2) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(DynamicVariableValueTypeOutputVariant3, other.DynamicVariableValueTypeOutputVariant3) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(DynamicVariableValueTypeOutputVariant4, other.DynamicVariableValueTypeOutputVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeOutput>?>.Default.Equals(DynamicVariableValueTypeOutputVariant5, other.DynamicVariableValueTypeOutputVariant5) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(DynamicVariableValueTypeOutputVariant6, other.DynamicVariableValueTypeOutputVariant6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DynamicVariableValueTypeOutput obj1, DynamicVariableValueTypeOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DynamicVariableValueTypeOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DynamicVariableValueTypeOutput obj1, DynamicVariableValueTypeOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DynamicVariableValueTypeOutput o && Equals(o);
        }
    }
}
