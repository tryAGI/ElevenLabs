#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DynamicVariableValueTypeInput : global::System.IEquatable<DynamicVariableValueTypeInput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DynamicVariableValueTypeInputVariant1 { get; init; }
#else
        public string? DynamicVariableValueTypeInputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableValueTypeInputVariant1))]
#endif
        public bool IsDynamicVariableValueTypeInputVariant1 => DynamicVariableValueTypeInputVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariableValueTypeInputVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = DynamicVariableValueTypeInputVariant1;
            return IsDynamicVariableValueTypeInputVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? DynamicVariableValueTypeInputVariant2 { get; init; }
#else
        public double? DynamicVariableValueTypeInputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableValueTypeInputVariant2))]
#endif
        public bool IsDynamicVariableValueTypeInputVariant2 => DynamicVariableValueTypeInputVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariableValueTypeInputVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = DynamicVariableValueTypeInputVariant2;
            return IsDynamicVariableValueTypeInputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? DynamicVariableValueTypeInputVariant3 { get; init; }
#else
        public int? DynamicVariableValueTypeInputVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableValueTypeInputVariant3))]
#endif
        public bool IsDynamicVariableValueTypeInputVariant3 => DynamicVariableValueTypeInputVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariableValueTypeInputVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = DynamicVariableValueTypeInputVariant3;
            return IsDynamicVariableValueTypeInputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? DynamicVariableValueTypeInputVariant4 { get; init; }
#else
        public bool? DynamicVariableValueTypeInputVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableValueTypeInputVariant4))]
#endif
        public bool IsDynamicVariableValueTypeInputVariant4 => DynamicVariableValueTypeInputVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariableValueTypeInputVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = DynamicVariableValueTypeInputVariant4;
            return IsDynamicVariableValueTypeInputVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>? DynamicVariableValueTypeInputVariant5 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>? DynamicVariableValueTypeInputVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableValueTypeInputVariant5))]
#endif
        public bool IsDynamicVariableValueTypeInputVariant5 => DynamicVariableValueTypeInputVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariableValueTypeInputVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>? value)
        {
            value = DynamicVariableValueTypeInputVariant5;
            return IsDynamicVariableValueTypeInputVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? DynamicVariableValueTypeInputVariant6 { get; init; }
#else
        public object? DynamicVariableValueTypeInputVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariableValueTypeInputVariant6))]
#endif
        public bool IsDynamicVariableValueTypeInputVariant6 => DynamicVariableValueTypeInputVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariableValueTypeInputVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = DynamicVariableValueTypeInputVariant6;
            return IsDynamicVariableValueTypeInputVariant6;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableValueTypeInput(string value) => new DynamicVariableValueTypeInput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(DynamicVariableValueTypeInput @this) => @this.DynamicVariableValueTypeInputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableValueTypeInput(string? value)
        {
            DynamicVariableValueTypeInputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableValueTypeInput(double value) => new DynamicVariableValueTypeInput((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(DynamicVariableValueTypeInput @this) => @this.DynamicVariableValueTypeInputVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableValueTypeInput(double? value)
        {
            DynamicVariableValueTypeInputVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableValueTypeInput(int value) => new DynamicVariableValueTypeInput((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(DynamicVariableValueTypeInput @this) => @this.DynamicVariableValueTypeInputVariant3;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableValueTypeInput(int? value)
        {
            DynamicVariableValueTypeInputVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DynamicVariableValueTypeInput(bool value) => new DynamicVariableValueTypeInput((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(DynamicVariableValueTypeInput @this) => @this.DynamicVariableValueTypeInputVariant4;

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableValueTypeInput(bool? value)
        {
            DynamicVariableValueTypeInputVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DynamicVariableValueTypeInput(
            string? dynamicVariableValueTypeInputVariant1,
            double? dynamicVariableValueTypeInputVariant2,
            int? dynamicVariableValueTypeInputVariant3,
            bool? dynamicVariableValueTypeInputVariant4,
            global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>? dynamicVariableValueTypeInputVariant5,
            object? dynamicVariableValueTypeInputVariant6
            )
        {
            DynamicVariableValueTypeInputVariant1 = dynamicVariableValueTypeInputVariant1;
            DynamicVariableValueTypeInputVariant2 = dynamicVariableValueTypeInputVariant2;
            DynamicVariableValueTypeInputVariant3 = dynamicVariableValueTypeInputVariant3;
            DynamicVariableValueTypeInputVariant4 = dynamicVariableValueTypeInputVariant4;
            DynamicVariableValueTypeInputVariant5 = dynamicVariableValueTypeInputVariant5;
            DynamicVariableValueTypeInputVariant6 = dynamicVariableValueTypeInputVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DynamicVariableValueTypeInputVariant6 as object ??
            DynamicVariableValueTypeInputVariant5 as object ??
            DynamicVariableValueTypeInputVariant4 as object ??
            DynamicVariableValueTypeInputVariant3 as object ??
            DynamicVariableValueTypeInputVariant2 as object ??
            DynamicVariableValueTypeInputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DynamicVariableValueTypeInputVariant1?.ToString() ??
            DynamicVariableValueTypeInputVariant2?.ToString() ??
            DynamicVariableValueTypeInputVariant3?.ToString() ??
            DynamicVariableValueTypeInputVariant4?.ToString().ToLowerInvariant() ??
            DynamicVariableValueTypeInputVariant5?.ToString() ??
            DynamicVariableValueTypeInputVariant6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDynamicVariableValueTypeInputVariant1 || IsDynamicVariableValueTypeInputVariant2 || IsDynamicVariableValueTypeInputVariant3 || IsDynamicVariableValueTypeInputVariant4 || IsDynamicVariableValueTypeInputVariant5 || IsDynamicVariableValueTypeInputVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? dynamicVariableValueTypeInputVariant1 = null,
            global::System.Func<double?, TResult>? dynamicVariableValueTypeInputVariant2 = null,
            global::System.Func<int?, TResult>? dynamicVariableValueTypeInputVariant3 = null,
            global::System.Func<bool?, TResult>? dynamicVariableValueTypeInputVariant4 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>, TResult>? dynamicVariableValueTypeInputVariant5 = null,
            global::System.Func<object, TResult>? dynamicVariableValueTypeInputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVariableValueTypeInputVariant1 && dynamicVariableValueTypeInputVariant1 != null)
            {
                return dynamicVariableValueTypeInputVariant1(DynamicVariableValueTypeInputVariant1!);
            }
            else if (IsDynamicVariableValueTypeInputVariant2 && dynamicVariableValueTypeInputVariant2 != null)
            {
                return dynamicVariableValueTypeInputVariant2(DynamicVariableValueTypeInputVariant2!);
            }
            else if (IsDynamicVariableValueTypeInputVariant3 && dynamicVariableValueTypeInputVariant3 != null)
            {
                return dynamicVariableValueTypeInputVariant3(DynamicVariableValueTypeInputVariant3!);
            }
            else if (IsDynamicVariableValueTypeInputVariant4 && dynamicVariableValueTypeInputVariant4 != null)
            {
                return dynamicVariableValueTypeInputVariant4(DynamicVariableValueTypeInputVariant4!);
            }
            else if (IsDynamicVariableValueTypeInputVariant5 && dynamicVariableValueTypeInputVariant5 != null)
            {
                return dynamicVariableValueTypeInputVariant5(DynamicVariableValueTypeInputVariant5!);
            }
            else if (IsDynamicVariableValueTypeInputVariant6 && dynamicVariableValueTypeInputVariant6 != null)
            {
                return dynamicVariableValueTypeInputVariant6(DynamicVariableValueTypeInputVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? dynamicVariableValueTypeInputVariant1 = null,

            global::System.Action<double?>? dynamicVariableValueTypeInputVariant2 = null,

            global::System.Action<int?>? dynamicVariableValueTypeInputVariant3 = null,

            global::System.Action<bool?>? dynamicVariableValueTypeInputVariant4 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>>? dynamicVariableValueTypeInputVariant5 = null,

            global::System.Action<object>? dynamicVariableValueTypeInputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVariableValueTypeInputVariant1)
            {
                dynamicVariableValueTypeInputVariant1?.Invoke(DynamicVariableValueTypeInputVariant1!);
            }
            else if (IsDynamicVariableValueTypeInputVariant2)
            {
                dynamicVariableValueTypeInputVariant2?.Invoke(DynamicVariableValueTypeInputVariant2!);
            }
            else if (IsDynamicVariableValueTypeInputVariant3)
            {
                dynamicVariableValueTypeInputVariant3?.Invoke(DynamicVariableValueTypeInputVariant3!);
            }
            else if (IsDynamicVariableValueTypeInputVariant4)
            {
                dynamicVariableValueTypeInputVariant4?.Invoke(DynamicVariableValueTypeInputVariant4!);
            }
            else if (IsDynamicVariableValueTypeInputVariant5)
            {
                dynamicVariableValueTypeInputVariant5?.Invoke(DynamicVariableValueTypeInputVariant5!);
            }
            else if (IsDynamicVariableValueTypeInputVariant6)
            {
                dynamicVariableValueTypeInputVariant6?.Invoke(DynamicVariableValueTypeInputVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? dynamicVariableValueTypeInputVariant1 = null,
            global::System.Action<double?>? dynamicVariableValueTypeInputVariant2 = null,
            global::System.Action<int?>? dynamicVariableValueTypeInputVariant3 = null,
            global::System.Action<bool?>? dynamicVariableValueTypeInputVariant4 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>>? dynamicVariableValueTypeInputVariant5 = null,
            global::System.Action<object>? dynamicVariableValueTypeInputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVariableValueTypeInputVariant1)
            {
                dynamicVariableValueTypeInputVariant1?.Invoke(DynamicVariableValueTypeInputVariant1!);
            }
            else if (IsDynamicVariableValueTypeInputVariant2)
            {
                dynamicVariableValueTypeInputVariant2?.Invoke(DynamicVariableValueTypeInputVariant2!);
            }
            else if (IsDynamicVariableValueTypeInputVariant3)
            {
                dynamicVariableValueTypeInputVariant3?.Invoke(DynamicVariableValueTypeInputVariant3!);
            }
            else if (IsDynamicVariableValueTypeInputVariant4)
            {
                dynamicVariableValueTypeInputVariant4?.Invoke(DynamicVariableValueTypeInputVariant4!);
            }
            else if (IsDynamicVariableValueTypeInputVariant5)
            {
                dynamicVariableValueTypeInputVariant5?.Invoke(DynamicVariableValueTypeInputVariant5!);
            }
            else if (IsDynamicVariableValueTypeInputVariant6)
            {
                dynamicVariableValueTypeInputVariant6?.Invoke(DynamicVariableValueTypeInputVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DynamicVariableValueTypeInputVariant1,
                typeof(string),
                DynamicVariableValueTypeInputVariant2,
                typeof(double),
                DynamicVariableValueTypeInputVariant3,
                typeof(int),
                DynamicVariableValueTypeInputVariant4,
                typeof(bool),
                DynamicVariableValueTypeInputVariant5,
                typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>),
                DynamicVariableValueTypeInputVariant6,
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
        public bool Equals(DynamicVariableValueTypeInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DynamicVariableValueTypeInputVariant1, other.DynamicVariableValueTypeInputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(DynamicVariableValueTypeInputVariant2, other.DynamicVariableValueTypeInputVariant2) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(DynamicVariableValueTypeInputVariant3, other.DynamicVariableValueTypeInputVariant3) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(DynamicVariableValueTypeInputVariant4, other.DynamicVariableValueTypeInputVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>?>.Default.Equals(DynamicVariableValueTypeInputVariant5, other.DynamicVariableValueTypeInputVariant5) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(DynamicVariableValueTypeInputVariant6, other.DynamicVariableValueTypeInputVariant6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DynamicVariableValueTypeInput obj1, DynamicVariableValueTypeInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DynamicVariableValueTypeInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DynamicVariableValueTypeInput obj1, DynamicVariableValueTypeInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DynamicVariableValueTypeInput o && Equals(o);
        }
    }
}
