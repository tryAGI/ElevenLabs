#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OptionValue : global::System.IEquatable<OptionValue>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? OptionValueVariant1 { get; init; }
#else
        public double? OptionValueVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OptionValueVariant1))]
#endif
        public bool IsOptionValueVariant1 => OptionValueVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOptionValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = OptionValueVariant1;
            return IsOptionValueVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickOptionValueVariant1() => OptionValueVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OptionValueVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? OptionValueVariant2 { get; init; }
#else
        public string? OptionValueVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OptionValueVariant2))]
#endif
        public bool IsOptionValueVariant2 => OptionValueVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOptionValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = OptionValueVariant2;
            return IsOptionValueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickOptionValueVariant2() => OptionValueVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OptionValueVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? OptionValueVariant3 { get; init; }
#else
        public bool? OptionValueVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OptionValueVariant3))]
#endif
        public bool IsOptionValueVariant3 => OptionValueVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOptionValueVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = OptionValueVariant3;
            return IsOptionValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickOptionValueVariant3() => OptionValueVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OptionValueVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OptionValue(double value) => new OptionValue((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(OptionValue @this) => @this.OptionValueVariant1;

        /// <summary>
        ///
        /// </summary>
        public OptionValue(double? value)
        {
            OptionValueVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OptionValue FromOptionValueVariant1(double? value) => new OptionValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OptionValue(string value) => new OptionValue((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(OptionValue @this) => @this.OptionValueVariant2;

        /// <summary>
        ///
        /// </summary>
        public OptionValue(string? value)
        {
            OptionValueVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OptionValue FromOptionValueVariant2(string? value) => new OptionValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OptionValue(bool value) => new OptionValue((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(OptionValue @this) => @this.OptionValueVariant3;

        /// <summary>
        ///
        /// </summary>
        public OptionValue(bool? value)
        {
            OptionValueVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OptionValue FromOptionValueVariant3(bool? value) => new OptionValue(value);

        /// <summary>
        ///
        /// </summary>
        public OptionValue(
            double? optionValueVariant1,
            string? optionValueVariant2,
            bool? optionValueVariant3
            )
        {
            OptionValueVariant1 = optionValueVariant1;
            OptionValueVariant2 = optionValueVariant2;
            OptionValueVariant3 = optionValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OptionValueVariant3 as object ??
            OptionValueVariant2 as object ??
            OptionValueVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OptionValueVariant1?.ToString() ??
            OptionValueVariant2?.ToString() ??
            OptionValueVariant3?.ToString().ToLowerInvariant()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOptionValueVariant1 || IsOptionValueVariant2 || IsOptionValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<double?, TResult>? optionValueVariant1 = null,
            global::System.Func<string, TResult>? optionValueVariant2 = null,
            global::System.Func<bool?, TResult>? optionValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OptionValueVariant1 is { } __value0 && optionValueVariant1 != null)
            {
                return optionValueVariant1(__value0);
            }
            else if (OptionValueVariant2 is { } __value1 && optionValueVariant2 != null)
            {
                return optionValueVariant2(__value1);
            }
            else if (OptionValueVariant3 is { } __value2 && optionValueVariant3 != null)
            {
                return optionValueVariant3(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<double?>? optionValueVariant1 = null,

            global::System.Action<string>? optionValueVariant2 = null,

            global::System.Action<bool?>? optionValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OptionValueVariant1 is { } __value0)
            {
                optionValueVariant1?.Invoke(__value0);
            }
            else if (OptionValueVariant2 is { } __value1)
            {
                optionValueVariant2?.Invoke(__value1);
            }
            else if (OptionValueVariant3 is { } __value2)
            {
                optionValueVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<double?>? optionValueVariant1 = null,
            global::System.Action<string>? optionValueVariant2 = null,
            global::System.Action<bool?>? optionValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OptionValueVariant1 is { } __value0)
            {
                optionValueVariant1?.Invoke(__value0);
            }
            else if (OptionValueVariant2 is { } __value1)
            {
                optionValueVariant2?.Invoke(__value1);
            }
            else if (OptionValueVariant3 is { } __value2)
            {
                optionValueVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OptionValueVariant1,
                typeof(double),
                OptionValueVariant2,
                typeof(string),
                OptionValueVariant3,
                typeof(bool),
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
        public bool Equals(OptionValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(OptionValueVariant1, other.OptionValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(OptionValueVariant2, other.OptionValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(OptionValueVariant3, other.OptionValueVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OptionValue obj1, OptionValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OptionValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OptionValue obj1, OptionValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OptionValue o && Equals(o);
        }
    }
}
